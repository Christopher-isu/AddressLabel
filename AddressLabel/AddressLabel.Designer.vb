<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddressLabel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.StreetAddressLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayButton
        '
        Me.DisplayButton.Font = New System.Drawing.Font("Roboto Slab", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayButton.Location = New System.Drawing.Point(12, 239)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(357, 92)
        Me.DisplayButton.TabIndex = 0
        Me.DisplayButton.Text = "Display Label"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Roboto Slab", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(12, 346)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(163, 92)
        Me.ClearButton.TabIndex = 0
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Roboto Slab", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(206, 346)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(163, 92)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(27, 29)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(75, 16)
        Me.FirstNameLabel.TabIndex = 2
        Me.FirstNameLabel.Text = "First Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(108, 54)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(243, 22)
        Me.LastNameTextBox.TabIndex = 1
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(27, 57)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(75, 16)
        Me.LastNameLabel.TabIndex = 2
        Me.LastNameLabel.Text = "Last Name:"
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(108, 82)
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(243, 22)
        Me.StreetAddressTextBox.TabIndex = 1
        '
        'StreetAddressLabel
        '
        Me.StreetAddressLabel.AutoSize = True
        Me.StreetAddressLabel.Location = New System.Drawing.Point(4, 85)
        Me.StreetAddressLabel.Name = "StreetAddressLabel"
        Me.StreetAddressLabel.Size = New System.Drawing.Size(99, 16)
        Me.StreetAddressLabel.TabIndex = 2
        Me.StreetAddressLabel.Text = "Street Address:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(108, 26)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(243, 22)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(108, 110)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(243, 22)
        Me.CityTextBox.TabIndex = 1
        '
        'CityTextLabel
        '
        Me.CityTextLabel.AutoSize = True
        Me.CityTextLabel.Location = New System.Drawing.Point(70, 113)
        Me.CityTextLabel.Name = "CityTextLabel"
        Me.CityTextLabel.Size = New System.Drawing.Size(32, 16)
        Me.CityTextLabel.TabIndex = 2
        Me.CityTextLabel.Text = "City:"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(108, 138)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(243, 22)
        Me.StateTextBox.TabIndex = 1
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(61, 141)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(41, 16)
        Me.StateLabel.TabIndex = 2
        Me.StateLabel.Text = "State:"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(108, 166)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(243, 22)
        Me.ZipTextBox.TabIndex = 1
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(37, 169)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(65, 16)
        Me.ZipCodeLabel.TabIndex = 2
        Me.ZipCodeLabel.Text = "Zip Code:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.ZipCodeLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.StateLabel)
        Me.GroupBox1.Controls.Add(Me.StreetAddressTextBox)
        Me.GroupBox1.Controls.Add(Me.CityTextLabel)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(Me.StreetAddressLabel)
        Me.GroupBox1.Controls.Add(Me.StateTextBox)
        Me.GroupBox1.Controls.Add(Me.LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.ZipTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 211)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mailing Address"
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.DisplayLabel)
        Me.OutputGroupBox.Location = New System.Drawing.Point(376, 12)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(412, 426)
        Me.OutputGroupBox.TabIndex = 4
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Address Label"
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Font = New System.Drawing.Font("Roboto Slab", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(21, 32)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(24, 37)
        Me.DisplayLabel.TabIndex = 0
        Me.DisplayLabel.Text = " "
        '
        'AddressLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Name = "AddressLabel"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisplayButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents StreetAddressLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CityTextLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents DisplayLabel As Label
End Class
