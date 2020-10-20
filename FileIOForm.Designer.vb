<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileIOForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.CurrentFileLabel = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.FirstNameCheckBox = New System.Windows.Forms.CheckBox()
        Me.LastNameCheckBox = New System.Windows.Forms.CheckBox()
        Me.CityCheckBox = New System.Windows.Forms.CheckBox()
        Me.StateCheckBox = New System.Windows.Forms.CheckBox()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.FilterButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.ActionsGroupBox.SuspendLayout()
        Me.FilterGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 20
        Me.DisplayListBox.Location = New System.Drawing.Point(12, 310)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(675, 204)
        Me.DisplayListBox.TabIndex = 0
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FirstNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.FirstNameTextBox.Location = New System.Drawing.Point(166, 25)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(209, 26)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(166, 57)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(209, 26)
        Me.LastNameTextBox.TabIndex = 2
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(166, 89)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(209, 26)
        Me.CityTextBox.TabIndex = 3
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(166, 122)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(209, 26)
        Me.StateTextBox.TabIndex = 4
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(166, 155)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(209, 26)
        Me.ZipTextBox.TabIndex = 5
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(166, 187)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(209, 26)
        Me.EmailTextBox.TabIndex = 6
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(6, 25)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(86, 20)
        Me.FirstNameLabel.TabIndex = 7
        Me.FirstNameLabel.Text = "First Name"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(6, 57)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(86, 20)
        Me.LastNameLabel.TabIndex = 8
        Me.LastNameLabel.Text = "Last Name"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(6, 89)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(35, 20)
        Me.CityLabel.TabIndex = 9
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(6, 122)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(48, 20)
        Me.StateLabel.TabIndex = 10
        Me.StateLabel.Text = "State"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(6, 155)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(73, 20)
        Me.ZipLabel.TabIndex = 11
        Me.ZipLabel.Text = "Zip Code"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(6, 187)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(52, 20)
        Me.EmailLabel.TabIndex = 12
        Me.EmailLabel.Text = "Email:"
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.CurrentFileLabel)
        Me.InputGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.EmailLabel)
        Me.InputGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.ZipLabel)
        Me.InputGroupBox.Controls.Add(Me.CityTextBox)
        Me.InputGroupBox.Controls.Add(Me.StateLabel)
        Me.InputGroupBox.Controls.Add(Me.StateTextBox)
        Me.InputGroupBox.Controls.Add(Me.CityLabel)
        Me.InputGroupBox.Controls.Add(Me.ZipTextBox)
        Me.InputGroupBox.Controls.Add(Me.LastNameLabel)
        Me.InputGroupBox.Controls.Add(Me.EmailTextBox)
        Me.InputGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 46)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(381, 258)
        Me.InputGroupBox.TabIndex = 13
        Me.InputGroupBox.TabStop = False
        '
        'CurrentFileLabel
        '
        Me.CurrentFileLabel.AutoSize = True
        Me.CurrentFileLabel.Location = New System.Drawing.Point(7, 232)
        Me.CurrentFileLabel.Name = "CurrentFileLabel"
        Me.CurrentFileLabel.Size = New System.Drawing.Size(0, 20)
        Me.CurrentFileLabel.TabIndex = 13
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(61, 4)
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(702, 33)
        Me.TopMenuStrip.TabIndex = 15
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ActionsGroupBox
        '
        Me.ActionsGroupBox.Controls.Add(Me.RemoveButton)
        Me.ActionsGroupBox.Controls.Add(Me.UpdateButton)
        Me.ActionsGroupBox.Controls.Add(Me.AddButton)
        Me.ActionsGroupBox.Location = New System.Drawing.Point(399, 46)
        Me.ActionsGroupBox.Name = "ActionsGroupBox"
        Me.ActionsGroupBox.Size = New System.Drawing.Size(148, 258)
        Me.ActionsGroupBox.TabIndex = 17
        Me.ActionsGroupBox.TabStop = False
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(6, 169)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(111, 66)
        Me.RemoveButton.TabIndex = 2
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(6, 97)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(111, 66)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(6, 25)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(111, 66)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'FirstNameCheckBox
        '
        Me.FirstNameCheckBox.AutoSize = True
        Me.FirstNameCheckBox.Location = New System.Drawing.Point(6, 25)
        Me.FirstNameCheckBox.Name = "FirstNameCheckBox"
        Me.FirstNameCheckBox.Size = New System.Drawing.Size(112, 24)
        Me.FirstNameCheckBox.TabIndex = 3
        Me.FirstNameCheckBox.Text = "First Name"
        Me.FirstNameCheckBox.UseVisualStyleBackColor = True
        '
        'LastNameCheckBox
        '
        Me.LastNameCheckBox.AutoSize = True
        Me.LastNameCheckBox.Location = New System.Drawing.Point(6, 51)
        Me.LastNameCheckBox.Name = "LastNameCheckBox"
        Me.LastNameCheckBox.Size = New System.Drawing.Size(112, 24)
        Me.LastNameCheckBox.TabIndex = 4
        Me.LastNameCheckBox.Text = "Last Name"
        Me.LastNameCheckBox.UseVisualStyleBackColor = True
        '
        'CityCheckBox
        '
        Me.CityCheckBox.AutoSize = True
        Me.CityCheckBox.Location = New System.Drawing.Point(6, 79)
        Me.CityCheckBox.Name = "CityCheckBox"
        Me.CityCheckBox.Size = New System.Drawing.Size(61, 24)
        Me.CityCheckBox.TabIndex = 5
        Me.CityCheckBox.Text = "City"
        Me.CityCheckBox.UseVisualStyleBackColor = True
        '
        'StateCheckBox
        '
        Me.StateCheckBox.AutoSize = True
        Me.StateCheckBox.Location = New System.Drawing.Point(6, 106)
        Me.StateCheckBox.Name = "StateCheckBox"
        Me.StateCheckBox.Size = New System.Drawing.Size(74, 24)
        Me.StateCheckBox.TabIndex = 6
        Me.StateCheckBox.Text = "State"
        Me.StateCheckBox.UseVisualStyleBackColor = True
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.FilterButton)
        Me.FilterGroupBox.Controls.Add(Me.FirstNameCheckBox)
        Me.FilterGroupBox.Controls.Add(Me.StateCheckBox)
        Me.FilterGroupBox.Controls.Add(Me.LastNameCheckBox)
        Me.FilterGroupBox.Controls.Add(Me.CityCheckBox)
        Me.FilterGroupBox.Location = New System.Drawing.Point(553, 46)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(134, 258)
        Me.FilterGroupBox.TabIndex = 7
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Filter Options"
        '
        'FilterButton
        '
        Me.FilterButton.Location = New System.Drawing.Point(6, 169)
        Me.FilterButton.Name = "FilterButton"
        Me.FilterButton.Size = New System.Drawing.Size(111, 66)
        Me.FilterButton.TabIndex = 8
        Me.FilterButton.Text = "Apply Filter"
        Me.FilterButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'FileIOForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 526)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.Controls.Add(Me.ActionsGroupBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.InputGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.MaximizeBox = False
        Me.Name = "FileIOForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Viewer"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ActionsGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActionsGroupBox As GroupBox
    Friend WithEvents RemoveButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents FirstNameCheckBox As CheckBox
    Friend WithEvents StateCheckBox As CheckBox
    Friend WithEvents CityCheckBox As CheckBox
    Friend WithEvents LastNameCheckBox As CheckBox
    Friend WithEvents FilterButton As Button
    Friend WithEvents FilterGroupBox As GroupBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentFileLabel As Label
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
End Class
