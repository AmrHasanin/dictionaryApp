﻿open System
open System.Windows.Forms

[<STAThread>]
do
    // Create a form
    let form = new Form(Text = "F# Windows Forms App", Width = 400, Height = 300)

    // Create a button and set its properties
    let button = new Button(Text = "I Love Shahd mooooot", Left = 150, Top = 100)
    button.Click.Add(fun _ -> MessageBox.Show("Bthaaaaaaaaaaazr :D <3 <3  <3 <3 <3") |> ignore)

    // Add the button to the form's controls
    form.Controls.Add(button)

    // Run the application
    Application.Run(form)
