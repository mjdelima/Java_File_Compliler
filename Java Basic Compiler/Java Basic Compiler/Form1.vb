Imports System.IO.Path

Public Class Form1
    Dim file_location As String = ""
    Dim file As String = ""

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
    End Sub

    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop, TextBox1.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)

        Dim temp As String = ""
        For Each path In files

            file_location = GetDirectoryName(path)
            file = GetFileNameWithoutExtension(path)
            TextBox1.Text = path

        Next

    End Sub

    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter, TextBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub BtnCompile_Click(sender As Object, e As EventArgs) Handles btnCompileRun.Click
        Try
            If ckRemove.Checked = True Then
                removePackage()

            End If
            RunCMDCom("cd " + Chr(34) + file_location + Chr(34) + " && " + "javac " + file + ".java && java " + file + " && pause && exit", "/W", True)
            'RunCMDCom("cd " + GetDirectoryName(TextBox1.Text) + "&& java " + GetFileNameWithoutExtension(TextBox1.Text) + " && pause && exit", "/W", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub RunCMDCom(command As String, arguments As String, permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " "
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub

    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        RunCMDCom("cd " + Chr(34) + file_location + Chr(34) + " &&  java " + Chr(34) + file + Chr(34) + " && pause && exit", "/W", True)

    End Sub

    Public Sub removePackage()
        Dim content As String

        ' read all text from the file to the content variable
        content = System.IO.File.ReadAllText(TextBox1.Text)

        ' replace number, text, etc. in code
        content = content.Replace("package ", "//package ")

        ' write new text back to the file (by completely overwriting the old content)
        System.IO.File.WriteAllText(TextBox1.Text, content)
    End Sub

    Private Sub BtnCompileOnly_Click(sender As Object, e As EventArgs) Handles btnCompileOnly.Click
        Try
            If ckRemove.Checked = True Then
                removePackage()

            End If
            RunCMDCom("cd " + Chr(34) + file_location + Chr(34) + " &&  javac " + Chr(34) + file + ".java" + Chr(34) + " && exit", "/W", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class