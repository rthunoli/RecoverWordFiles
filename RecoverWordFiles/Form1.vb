Imports Word = Microsoft.Office.Interop.Word
Imports System.Runtime.InteropServices
Imports System
Imports System.IO

Public Class Form1
    Dim oWord As Word.Application

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRecover.Click
        If (TxtPath.Text <> "") Then
            ProcessDocs()
        End If
    End Sub

    Private Sub PrintDocs()
        oWord = CreateObject("Word.Application")
        Dim oDoc As Word.Document
        ' Make a reference to a directory.
        Dim di As New DirectoryInfo(TxtPath.Text)
        ' Get a reference to each file in that directory.
        Dim fiArr As FileInfo() = di.GetFiles()
        ' Display the names of the files.
        Dim fri As FileInfo
        For Each fri In fiArr
            oDoc = oWord.Documents.Open(fri.FullName)
            oDoc.PrintOut()
            oDoc.Close()
            oDoc = Nothing
        Next fri
        oWord.Application.Quit()
        oWord = Nothing

    End Sub
    Private Sub ProcessDocs()
        oWord = CreateObject("Word.Application")
        ' Make a reference to a directory.
        Dim di As New DirectoryInfo(TxtPath.Text)
        ' Get a reference to each file in that directory.
        Dim fiArr As FileInfo() = di.GetFiles()
        ' Display the names of the files.
        Dim fri As FileInfo
        For Each fri In fiArr
            Recover(fri.FullName)
        Next fri
        oWord.Application.Quit()
        oWord = Nothing
        MessageBox.Show(LstFiles.Items.Count & " files recovered successfully")

    End Sub

    Private Sub Recover(ByVal sFileName As String)
        Dim oDoc As Word.Document

        Try
            Dim x = Split(sFileName, "\")
            oDoc = oWord.Documents.Open(FileName:=sFileName, OpenAndRepair:=True)
            With oDoc.Sections(1)
                .Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range.Text = x.Last()
            End With
            oDoc.SaveAs2(sFileName)
            oDoc.Close()
            oDoc = Nothing
            LstFiles.Items.Add(x.Last())
            LstFiles.TopIndex = LstFiles.Items.Count - 1
            'checkedListBox1.TopIndex = checkedListBox1.Items.Count - 1;
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        FolderBrowserDialog1.ShowDialog()
        TxtPath.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Function isDomainUser() As Boolean
        Return Environment.MachineName <> Environment.UserDomainName
    End Function

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If (isDomainUser()) Then
            PrintDocs()
        Else
            MsgBox("Login as a domain user to print documents")
        End If
    End Sub
End Class
