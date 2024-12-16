open System
open System.IO
open System.Text.RegularExpressions
open System.Windows.Forms
open Newtonsoft.Json
open System.Collections.Generic

// Data structure to represent the dictionary
type DictionaryEntry = { Word: string; Definition: string }

type DigitalDictionary = Map<string, DictionaryEntry>

// Initialize an empty dictionary (Map) - Immutable structure
let initialDictionary : DigitalDictionary = Map.empty

// Add a new entry to the dictionary (creates a new Map)
let addEntry (dict: DigitalDictionary) word definition =
    let entry = { Word = word; Definition = definition }
    dict.Add(word, entry)

// Update an existing entry in the dictionary (creates a new Map)
let updateEntry (dict: DigitalDictionary) word newDefinition =
    match dict.TryFind(word) with
    | Some existingEntry -> dict.Add(word, { existingEntry with Definition = newDefinition })
    | None -> dict  // Word not found, return the original dictionary

// Delete an entry from the dictionary (creates a new Map)
let deleteEntry (dict: DigitalDictionary) word =
    dict.Remove(word)

// Case-insensitive search function
let searchDictionary (dict: DigitalDictionary) query =
    dict |> Map.filter (fun key entry ->
        Regex.IsMatch(entry.Word, query, RegexOptions.IgnoreCase)
    )

// Save dictionary to a JSON file (serialization)
let saveDictionaryToFile (dict: DigitalDictionary) filePath =
    let json = JsonConvert.SerializeObject(dict, Formatting.Indented)
    File.WriteAllText(filePath, json)

// Load dictionary from a JSON file (deserialization)
let loadDictionaryFromFile filePath =
    if File.Exists(filePath) then
        let json = File.ReadAllText(filePath)
        JsonConvert.DeserializeObject<DigitalDictionary>(json)
    else
        Map.empty // Return an empty dictionary if the file does not exist

// Windows Forms UI elements
let form = new Form(Text = "Digital Dictionary", Width = 700, Height = 400) // Increased form size to 700
form.StartPosition <- FormStartPosition.CenterScreen  // Center the form on screen

// Labels
let wordLabel = new Label(Text = "Enter Word:", Location = Drawing.Point(10, 20), Width = 120)
let definitionLabel = new Label(Text = "Enter Definition:", Location = Drawing.Point(10, 60), Width = 120)
let searchLabel = new Label(Text = "Search for Word:", Location = Drawing.Point(10, 100), Width = 120)

// Textboxes
let wordTextBox = new TextBox(Location = Drawing.Point(140, 20), Width = 500, Height = 25)
let definitionTextBox = new TextBox(Location = Drawing.Point(140, 60), Width = 500, Height = 25)
let searchTextBox = new TextBox(Location = Drawing.Point(140, 100), Width = 400, Height = 25, Padding = System.Windows.Forms.Padding(3))

// Buttons
let addButton = new Button(Text = "Add Entry", Location = Drawing.Point(10, 140), Width = 150)
let searchButton = new Button(Text = "Search", Location = Drawing.Point(550, 100), Width = 120) // Adjusted button width
let loadButton = new Button(Text = "Load Dictionary", Location = Drawing.Point(10, 300), Width = 150)
let saveButton = new Button(Text = "Save Dictionary", Location = Drawing.Point(170, 300), Width = 150)

// Result Label
let resultLabel = new Label(Location = Drawing.Point(10, 180), Width = 670, Height = 100, Text = "", TextAlign = System.Drawing.ContentAlignment.TopLeft)

// File path to save/load dictionary
let filePath = "C:\\Users\\amrmo\\Desktop\\PL3\\Project\\dictionaryApp\\dictionary.json"

// Initialize a mutable reference for the dictionary
let dictionary = ref initialDictionary  // Start with an empty dictionary

// Utility function for updating result label with messages
let updateResult message =
    resultLabel.Text <- message
    resultLabel.ForeColor <- System.Drawing.Color.Black

// Update dictionary when adding an entry
addButton.Click.Add(fun _ ->
    let word = wordTextBox.Text
    let definition = definitionTextBox.Text

    if String.IsNullOrWhiteSpace(word) || String.IsNullOrWhiteSpace(definition) then
        resultLabel.Text <- "Word or Definition cannot be empty."
        resultLabel.ForeColor <- System.Drawing.Color.Red
    else
        // Check if word already exists
        if Map.containsKey word !dictionary then
            resultLabel.Text <- "Word already exists in the dictionary!"
            resultLabel.ForeColor <- System.Drawing.Color.Red
        else
            dictionary := addEntry !dictionary word definition  // Create a new dictionary and update the reference
            updateResult (sprintf "Added: %s => %s" word definition)
            wordTextBox.Clear()
            definitionTextBox.Clear()
)

// Search functionality
searchButton.Click.Add(fun _ ->
    let query = searchTextBox.Text
    if String.IsNullOrWhiteSpace(query) then
        resultLabel.Text <- "Please enter a word to search."
        resultLabel.ForeColor <- System.Drawing.Color.Red
    else
        let searchResults = searchDictionary !dictionary query
        if Map.isEmpty searchResults then
            resultLabel.Text <- "No results found."
            resultLabel.ForeColor <- System.Drawing.Color.Red
        else
            resultLabel.Text <- 
                searchResults |> Map.fold (fun acc key entry ->
                    acc + sprintf "%s: %s\n" key entry.Definition
                ) ""
            resultLabel.ForeColor <- System.Drawing.Color.Black
)

// Save dictionary to file
saveButton.Click.Add(fun _ ->
    saveDictionaryToFile !dictionary filePath  // Dereference to access the dictionary
    updateResult "Dictionary saved to file."
)

// Load dictionary from file when the button is clicked
loadButton.Click.Add(fun _ ->
    dictionary := loadDictionaryFromFile filePath  // Load a new dictionary and update the reference
    updateResult "Dictionary loaded from file."
)

// Add controls to form
form.Controls.Add(wordLabel)
form.Controls.Add(definitionLabel)
form.Controls.Add(wordTextBox)
form.Controls.Add(definitionTextBox)
form.Controls.Add(addButton)
form.Controls.Add(searchLabel)
form.Controls.Add(searchTextBox)
form.Controls.Add(searchButton)
form.Controls.Add(resultLabel)
form.Controls.Add(loadButton)
form.Controls.Add(saveButton)

// Run the application
Application.Run(form)
