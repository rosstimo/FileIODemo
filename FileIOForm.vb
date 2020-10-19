Imports System
'Imports System.IO
Public Class FileIOForm
    Dim dataArray() As String



    Sub DontBeDumb() Handles Me.Load
        Dim fileName As String = "C:\Users\rosstimo\Documents\__FileDemoStuff\myfile.txt"
        AppendFile(fileName, "save me to a file...")



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

            Do Until EOF(fileNumber)
                'DisplayListBox.Items.Add(LineInput(fileNumber))
                Input(fileNumber, temp$)
                dataString$ &= temp$
                'DisplayListBox.Items.Add(temp$)
            Loop

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
        Dim fileName As String = "C:\Users\rosstimo\OneDrive\Sync\github\__RCET0265-F20\FileIODemo\email.txt"
        ReadFile(fileName)
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
End Class
