Imports System
'Imports System.IO
Public Class FileIOForm
    Dim dataArray() As String
    Dim currentFile As String



    Sub DontBeDumb() Handles Me.Load
        Dim fileName As String = "myfile.txt"
        AppendFile(fileName, "save me to a file...")
        Dim temp() As String
        temp = Split(My.Resources.email, vbNewLine)
        Split(fileName, vbNewLine)
        'FileOpen(1, "C:\Users\rosstimo\Documents\__FileDemoStuff\myfile.txt", OpenMode.Input)
        'FileOpen(1, "C:\Users\rosstimo\Documents\__FileDemoStuff\myfile.txt", OpenMode.Output) 'overwrite
        'FileOpen(1, "C:\Users\rosstimo\Documents\__FileDemoStuff\myfile.txt", OpenMode.Append) 'adds to file
        'Write(1, "here is the new data")
        'FileClose(1)

        'FileOpen(1, "C:\Users\rosstimo\Documents\__FileDemoStuff\myfile.txt", OpenMode.Append) 'adds to file

        'Me.Close()
    End Sub

    Private Sub AppendFile(ByVal filename As String, newRecord As String)
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, filename, OpenMode.Append)
            'Write(fileNumber, newRecord)
            WriteLine(fileNumber, newRecord)

        Catch ex As Exception
            'TODO: user select file if it doesn't exist
            'handle file in use exception
            'verify other possible exceptions     
            Console.WriteLine(ex.Message)
        Finally
            FileClose(fileNumber)
        End Try

    End Sub


    Private Sub ReadFile(ByVal filename As String)
        Dim fileNumber As Integer = FreeFile()
        Dim temp As String
        Dim dataString As String
        Dim tempArray() As String

        Try
            FileOpen(fileNumber, filename, OpenMode.Input)

            LOF(fileNumber)

            Do Until EOF(fileNumber)
                'DisplayListBox.Items.Add(LineInput(fileNumber))
                Input(fileNumber, temp$)
                dataString$ &= temp$
                'DisplayListBox.Items.Add(temp$)
            Loop
        Catch noFile As System.IO.IOException
            SetCurrentFile()
        Catch ex As Exception
            'TODO: user select file if it doesn't exist
            'handle file in use exception
            'verify other possible exceptions 
            Console.WriteLine(ex.Message)
        Finally
            FileClose(fileNumber)
        End Try
        tempArray = Split(dataString, "$$")

        For i = 1 To UBound(tempArray)
            DisplayListBox.Items.Add(tempArray(i))
        Next

        dataArray = tempArray

        Console.WriteLine(dataString$)
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Dim fileName As String = "../../email.txt"
        ReadFile(currentFile)
    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Dim tempIndex As Integer = DisplayListBox.SelectedIndex + 1
        Dim tempArray() As String

        tempArray = Split(dataArray(tempIndex), ",")

        FirstNameTextBox.Text = tempArray(0)
        LastNameTextBox.Text = tempArray(1)
        CityTextBox.Text = tempArray(2)
        emailTextBox.Text = tempArray(3)

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        SetCurrentFile()
    End Sub

    Sub SetCurrentFile()
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|VB files|*.vb|All files (*.*)|*.*"
        'OpenFileDialog.
        OpenFileDialog.ShowDialog()
        currentFile = OpenFileDialog.FileName
        'CurrentFileLabel.Text = currentFile
        Me.Text = currentFile
        'Console.WriteLine(currentFile)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim saveFileName As String
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|VB files|*.vb|All files (*.*)|*.*"
        SaveFileDialog.FileName = $"Document_{System.DateTime.Now.Year}{System.DateTime.Now.Month}{System.DateTime.Now.Day}"
        SaveFileDialog.ShowDialog()
        saveFileName = SaveFileDialog.FileName

        WriteNewFile(saveFileName)
    End Sub

    Sub WriteNewFile(newFileName As String)

        'write all records in array to new file
        'loop the array
        'append each record/line
        'close the file
        For Each record In dataArray
            AppendFile(newFileName, "$$" & record)
        Next

    End Sub

    Sub FileStructureExample()

        'Dim myfile As My.Resources
        'Example from: https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.filesystem.writeline?view=netframework-4.8
        ' Open file for output.
        FileOpen(1, "TestFile.txt", OpenMode.Output)
        ' Print text to the file. The quotation marks will be in the display.
        Write(1, "This is a test.")
        Write(1, "This is a test.")
        Write(1, "This is a test.")
        Write(1, "This is a test.")
        Write(1, "This is a test.")
        Write(1, "This is a test.")
        ' Go to the next line.
        WriteLine(1)
        ' Skip a line.
        WriteLine(1)
        ' Print in two print zones. You will see commas and quotation marks
        ' in the output file.
        WriteLine(1, "Zone 1", SPC(10), "Zone 2", "Zone 3", "Zone 4", 12345)
        ' Build a longer string before calling WriteLine.
        WriteLine(1, "Hello" & "  " & "World")
        ' Include five leading spaces.
        WriteLine(1, SPC(5), "Leading spaces")
        ' Print a word starting at column 10.
        WriteLine(1, TAB(10), "Hello")

        ' Assign Boolean and Date values.
        Dim aBool As Boolean
        Dim aDate As DateTime
        aBool = False
        aDate = DateTime.Parse("February 12, 1969")

        ' Dates and Booleans are translated using locale settings of 
        ' your system.
        WriteLine(1, aBool) '& " is a Boolean value.")
        WriteLine(1, aDate) '& " is a date.")

        For i = 0 To 100
            Write(1, i)
        Next

        ' Close the file.



        FileClose(1)

        ' Contents of TestFile.txt
        '"This is a test.",
        '
        '"Zone 1",          "Zone 2"
        '"Hello  World"
        '     "Leading spaces"
        '         ,"Hello"
        '"False is a Boolean value."
        '"2/12/1969 is a date."
    End Sub

    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click
        FileStructureExample()
    End Sub
End Class
