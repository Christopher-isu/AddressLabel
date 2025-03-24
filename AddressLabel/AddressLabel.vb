'ChristopherZ
'Spring 2025
'RCET2265
'Adress Label
'

Public Class AddressLabel
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        ' Concatenate First and Last Name
        Dim fullName As String = FirstNameTextBox.Text & " " & LastNameTextBox.Text
        ' Format address
        Dim formattedAddress As String = fullName & Environment.NewLine &
                                          StreetAddressTextBox.Text & Environment.NewLine &
                                          CityTextBox.Text & ", " & StateTextBox.Text & " " & ZipTextBox.Text
        ' Display in label
        DisplayLabel.Text = formattedAddress
    End Sub

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

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Close the application
        Me.Close()
    End Sub
End Class

