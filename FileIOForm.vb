Imports System
'Imports System.IO
Public Class FileIOForm

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



End Class
