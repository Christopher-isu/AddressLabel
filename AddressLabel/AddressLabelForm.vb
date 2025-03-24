'ChristopherZ
'Spring 2025
'RCET2265
'Adress Label
'https://github.com/Christopher-isu/AddressLabel.git

Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions
'NOTE: Regex is used becasue it allows for more precise validation over simply determining if the input is a number or letter.

Public Class AddressLabelForm
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        ' Validate inputs and show error messages
        Dim validationResult As String = ValidateInputs() ' Get error messages from validation
        If Not String.IsNullOrEmpty(validationResult) Then ' If there are any error messages
            MessageBox.Show(validationResult, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Show error messages
            Return
        End If

        ' Concatenate First and Last Name
        Dim fullName As String = FirstNameTextBox.Text & " " & LastNameTextBox.Text
        ' Format address
        Dim formattedAddress As String = fullName & Environment.NewLine & '
                                          StreetAddressTextBox.Text & Environment.NewLine &
                                          CityTextBox.Text & ", " & StateTextBox.Text & " " & ZipTextBox.Text
        ' Display in label
        DisplayLabel.Text = formattedAddress
    End Sub

    Private Function ValidateInputs() As String ' Returns error messages if any field did not pass validation
        Dim errorMessages As New List(Of String)() ' List to store error messages
        Dim nameRegex As New Regex("^[a-zA-Z]+$") ' Regex to validate names
        Dim addressRegex As New Regex("^[a-zA-Z0-9\s]+$") ' Regex to validate street address
        Dim zipRegex As New Regex("^\d{5}$") ' Regex to validate zip code


        ' Validate First Name
        If Not nameRegex.IsMatch(FirstNameTextBox.Text) Then
            errorMessages.Add("First Name must contain only letters.")
        End If

        ' Validate Last Name
        If Not nameRegex.IsMatch(LastNameTextBox.Text) Then
            errorMessages.Add("Last Name must contain only letters.")
        End If

        ' Validate Street Address
        If Not addressRegex.IsMatch(StreetAddressTextBox.Text) Then
            errorMessages.Add("Street Address must contain only letters, numbers, and spaces.")
        End If

        ' Validate City
        If Not nameRegex.IsMatch(CityTextBox.Text) Then
            errorMessages.Add("City must contain only letters.")
        End If

        ' Validate State
        If Not nameRegex.IsMatch(StateTextBox.Text) Then
            errorMessages.Add("State must contain only letters.")
        End If

        ' Validate Zip Code
        If Not zipRegex.IsMatch(ZipTextBox.Text) Then
            errorMessages.Add("Zip Code must be exactly 5 digits.")
        End If

        ' Combine all error messages
        Return String.Join(Environment.NewLine, errorMessages)
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear all fields
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        StreetAddressTextBox.Clear()
        CityTextBox.Clear()
        StateTextBox.Clear()
        ZipTextBox.Clear()
        DisplayLabel.Text = String.Empty
    End Sub

    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' When the form loads
        Dim toolTip As New ToolTip() ' Create a new tooltip
        toolTip.ShowAlways = True ' Show the tooltip even if the form is not active

        ' Assign tooltips
        toolTip.SetToolTip(FirstNameTextBox, "Enter your first name.")
        toolTip.SetToolTip(LastNameTextBox, "Enter your last name.")
        toolTip.SetToolTip(StreetAddressTextBox, "Enter your street address.")
        toolTip.SetToolTip(CityTextBox, "Enter your city.")
        toolTip.SetToolTip(StateTextBox, "Enter your state.")
        toolTip.SetToolTip(ZipTextBox, "Enter your 5-digit zip code.")
        toolTip.SetToolTip(DisplayButton, "Click to display the formatted address.")
        toolTip.SetToolTip(ClearButton, "Click to clear all fields.")
        toolTip.SetToolTip(ExitButton, "Click to exit the application.")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Close the application
        Me.Close()
    End Sub
End Class
