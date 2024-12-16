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

// Remove an entry from the dictionary (creates a new Map)
let removeEntry (dict: DigitalDictionary) word =
    dict.Remove(word)

// Case-insensitive search function
let searchDictionary (dict: DigitalDictionary) query =
    dict |> Map.filter (fun key entry -> Regex.IsMatch(entry.Word, query, RegexOptions.IgnoreCase))

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
let form = new Form(Text = "Digital Dictionary", Width = 700, Height = 600) // Increased height for delete button
form.StartPosition <- FormStartPosition.CenterScreen  // Center the form on screen

// Add Entry Section Labels
let wordLabel = new Label(Text = "Enter Word:", Location = Drawing.Point(10, 20), Width = 120)
let definitionLabel = new Label(Text = "Enter Definition:", Location = Drawing.Point(10, 60), Width = 120)

// Add Entry Textboxes
let wordTextBox = new TextBox(Location = Drawing.Point(140, 20), Width = 500, Height = 25)
let definitionTextBox = new TextBox(Location = Drawing.Point(140, 60), Width = 500, Height = 25)

// Add Entry Button
let addButton = new Button(Text = "Add Entry", Location = Drawing.Point(10, 100), Width = 150)

// Search Section Labels
let searchLabel = new Label(Text = "Search for Word:", Location = Drawing.Point(10, 140), Width = 120)

// Search Textbox
let searchTextBox = new TextBox(Location = Drawing.Point(140, 140), Width = 400, Height = 25, Padding = System.Windows.Forms.Padding(3))

// Search Button
let searchButton = new Button(Text = "Search", Location = Drawing.Point(550, 140), Width = 120)

// Edit Section Labels
let editLabel = new Label(Text = "Edit Word:", Location = Drawing.Point(10, 180), Width = 120)

// Edit Word ComboBox
let editWordComboBox = new ComboBox(Location = Drawing.Point(140, 180), Width = 200, Height = 25)

// Edit Definition TextBox
let editDefinitionTextBox = new TextBox(Location = Drawing.Point(140, 220), Width = 500, Height = 25)

// Edit Button
let editButton = new Button(Text = "Edit Entry", Location = Drawing.Point(10, 260), Width = 150)

// Delete Button
let deleteButton = new Button(Text = "Delete Entry", Location = Drawing.Point(170, 260), Width = 150) // New Delete Button

// Result Label
let resultLabel = new Label(Location = Drawing.Point(10, 300), Width = 670, Height = 100, Text = "", TextAlign = System.Drawing.ContentAlignment.TopLeft)

// Load/Save Buttons
let loadButton = new Button(Text = "Load Dictionary", Location = Drawing.Point(10, 400), Width = 150)
let saveButton = new Button(Text = "Save Dictionary", Location = Drawing.Point(170, 400), Width = 150)

// List All Entries Button
let listAllButton = new Button(Text = "List All Entries", Location = Drawing.Point(330, 400), Width = 150) 

// File path to save/load dictionary
let filePath = "C:\\Users\\amrmo\\Desktop\\PL3\\Project\\dictionaryApp\\dictionary.json"

// Use a mutable reference to store the dictionary state
let dictionary = ref initialDictionary

// Utility function for updating result label with messages
let updateResult message =
    resultLabel.Text <- message
    resultLabel.ForeColor <- System.Drawing.Color.Black


// Populate combo box with words for editing
let populateEditComboBox () =
    editWordComboBox.Items.Clear()  // Clear existing items
    // Convert the dictionary keys to a list and add all items at once
    let keys = Map.keys !dictionary |> List.ofSeq // Convert Map keys to a list
    // Cast the list of strings to an array of objects (obj[])
    editWordComboBox.Items.AddRange(keys |> List.toArray |> Array.map box)  // Add words to ComboBox all at once


// Update dictionary when adding an entry
addButton.Click.Add(fun _ ->
    let word = wordTextBox.Text
    let definition = definitionTextBox.Text
    if String.IsNullOrWhiteSpace(word) || String.IsNullOrWhiteSpace(definition) then
        resultLabel.Text <- "Word or Definition cannot be empty."
        resultLabel.ForeColor <- System.Drawing.Color.Red
    else
        if Map.containsKey word !dictionary then
            resultLabel.Text <- "Word already exists in the dictionary!"
            resultLabel.ForeColor <- System.Drawing.Color.Red
        else
            dictionary := addEntry !dictionary word definition
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
                searchResults |> Map.fold (fun acc key entry -> acc + sprintf "%s: %s\n" key entry.Definition) ""
            resultLabel.ForeColor <- System.Drawing.Color.Black
)

// Edit functionality
editWordComboBox.SelectedIndexChanged.Add(fun _ ->
    let selectedWord = editWordComboBox.SelectedItem :?> string
    match Map.tryFind selectedWord !dictionary with
    | Some entry -> editDefinitionTextBox.Text <- entry.Definition
    | None -> editDefinitionTextBox.Clear()
)

editButton.Click.Add(fun _ ->
    let selectedWord = editWordComboBox.SelectedItem :?> string
    let newDefinition = editDefinitionTextBox.Text
    if String.IsNullOrWhiteSpace(selectedWord) || String.IsNullOrWhiteSpace(newDefinition) then
        resultLabel.Text <- "Word or Definition cannot be empty."
        resultLabel.ForeColor <- System.Drawing.Color.Red
    else
        match Map.tryFind selectedWord !dictionary with
        | Some existingEntry ->
            dictionary := updateEntry !dictionary selectedWord newDefinition
            updateResult (sprintf "Updated: %s => %s" selectedWord newDefinition)
            editWordComboBox.SelectedIndex <- -1  // Deselect the ComboBox
            editDefinitionTextBox.Clear()
        | None ->
            resultLabel.Text <- "Word not found in the dictionary."
            resultLabel.ForeColor <- System.Drawing.Color.Red
)

// Delete functionality
deleteButton.Click.Add(fun _ ->
    let selectedWord = editWordComboBox.SelectedItem :?> string
    if String.IsNullOrWhiteSpace(selectedWord) then
        resultLabel.Text <- "Please select a word to delete."
        resultLabel.ForeColor <- System.Drawing.Color.Red
    else
        dictionary := removeEntry !dictionary selectedWord
        saveDictionaryToFile !dictionary filePath  // Save the updated dictionary after deletion
        populateEditComboBox()  // Refresh ComboBox
        updateResult (sprintf "Deleted: %s" selectedWord)
        editWordComboBox.SelectedIndex <- -1  // Deselect the ComboBox
        editDefinitionTextBox.Clear()
)

// Save dictionary to file
saveButton.Click.Add(fun _ ->
    saveDictionaryToFile !dictionary filePath
    updateResult "Dictionary saved to file."
)

// Load dictionary from file
loadButton.Click.Add(fun _ ->
    dictionary := loadDictionaryFromFile filePath
    updateResult "Dictionary loaded from file."
    populateEditComboBox()  // Update the ComboBox with the newly loaded dictionary
)

// List all dictionary entries
listAllButton.Click.Add(fun _ ->
    if Map.isEmpty !dictionary then
        resultLabel.Text <- "No entries found in the dictionary."
        resultLabel.ForeColor <- System.Drawing.Color.Red
    else
        resultLabel.Text <- 
            !dictionary |> Map.fold (fun acc key entry -> acc + sprintf "%s: %s\n" key entry.Definition) ""
        resultLabel.ForeColor <- System.Drawing.Color.Black
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

form.Controls.Add(editLabel)
form.Controls.Add(editWordComboBox)
form.Controls.Add(editDefinitionTextBox)
form.Controls.Add(editButton)

form.Controls.Add(deleteButton)  // Add the Delete button

form.Controls.Add(resultLabel)

form.Controls.Add(loadButton)
form.Controls.Add(saveButton)
form.Controls.Add(listAllButton)  // Add the "List All Entries" button

// Run the application
Application.Run(form)
