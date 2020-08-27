Imports System.IO
Imports System.Threading

Public Class Form1
    Dim fl As List(Of FileInfo) = New List(Of FileInfo)
    Dim num As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            Label1.Text = "Selected Path: " + FolderBrowserDialog1.SelectedPath
            Label1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim thread As New Thread(AddressOf Backgroudthread1)
        If PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage Then
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        End If
        Label2.Visible = True
        thread.Start()
        Button3.Enabled = True
        Button2.Enabled = False
        PictureBox1.Visible = True
        timer1.start
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        PictureBox1.Image = My.Resources.shredder
        Dim thread As New Thread(AddressOf Backgroundthread2)
            CheckForIllegalCrossThreadCalls = False
            thread.Start()

            ProgressBar1.Visible = True

    End Sub
    Sub Backgroudthread1()
        Control.CheckForIllegalCrossThreadCalls = False
        Label2.Visible = True
        'Dim f2 As FileInfo() = FileLocation.GetFiles("*copy*.jpg")
        Dim files As New IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath)
        For Each file As IO.FileInfo In files.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then

                If (Path.GetExtension(file.ToString.ToLower) = ".jpg") Then
                    If (file.ToString.ToLower.Contains("copy")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 1
                If (Path.GetExtension(file.ToString.ToLower) = ".jpg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 2
                If (Path.GetExtension(file.ToString.ToLower) = ".jpg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 3
                If (Path.GetExtension(file.ToString.ToLower) = ".jpg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 4
                If (Path.GetExtension(file.ToString.ToLower) = ".jpg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 5
                If (Path.GetExtension(file.ToString.ToLower) = ".jpg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 6
                If (Path.GetExtension(file.ToString.ToLower) = ".jpg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 7
                If (Path.GetExtension(file.ToString.ToLower) = ".jpg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 8
                If (Path.GetExtension(file.ToString.ToLower) = ".jpg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 9
                If (Path.GetExtension(file.ToString.ToLower) = ".jpg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpeg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                If (Path.GetExtension(file.ToString.ToLower) = ".jpeg") Then
                    If (file.ToString.ToLower.Contains("copy")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpeg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 1
                If (Path.GetExtension(file.ToString.ToLower) = ".jpeg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpeg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 2
                If (Path.GetExtension(file.ToString.ToLower) = ".jpeg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpeg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 3
                If (Path.GetExtension(file.ToString.ToLower) = ".jpeg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpeg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 4
                If (Path.GetExtension(file.ToString.ToLower) = ".jpeg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpeg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 5
                If (Path.GetExtension(file.ToString.ToLower) = ".jpeg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpeg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 6
                If (Path.GetExtension(file.ToString.ToLower) = ".jpeg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpeg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 7
                If (Path.GetExtension(file.ToString.ToLower) = ".jpeg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpeg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 8
                If (Path.GetExtension(file.ToString.ToLower) = ".jpeg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.jpeg", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 9
                If (Path.GetExtension(file.ToString.ToLower) = ".jpeg") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.png", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                If (Path.GetExtension(file.ToString.ToLower) = ".png") Then
                    If (file.ToString.ToLower.Contains("copy")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.png", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 1
                If (Path.GetExtension(file.ToString.ToLower) = ".png") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.png", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 2
                If (Path.GetExtension(file.ToString.ToLower) = ".png") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.png", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 3
                If (Path.GetExtension(file.ToString.ToLower) = ".png") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.png", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 4
                If (Path.GetExtension(file.ToString.ToLower) = ".png") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.png", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 5
                If (Path.GetExtension(file.ToString.ToLower) = ".png") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.png", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 6
                If (Path.GetExtension(file.ToString.ToLower) = ".png") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.png", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 7
                If (Path.GetExtension(file.ToString.ToLower) = ".png") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.png", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 8
                If (Path.GetExtension(file.ToString.ToLower) = ".png") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        For Each file As IO.FileInfo In files.GetFiles("*.png", IO.SearchOption.AllDirectories)
            If (file IsNot Nothing) Then
                num = 9
                If (Path.GetExtension(file.ToString.ToLower) = ".png") Then
                    If (file.ToString.ToLower.Contains("(" & num & ")")) Then fl.Add(file)
                End If
            End If
        Next
        Label2.Text = "Found " & fl.Count & " duplicates"
        If fl.Count = 0 Then
            Button3.Text = "Nothing to delete"
            Button3.Enabled = False
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox1.Image = My.Resources.success_11
            Button1.Enabled = True
        End If
    End Sub
    Sub Backgroundthread2()
        Try
            CheckForIllegalCrossThreadCalls = False
            For Each File In fl
                My.Computer.FileSystem.DeleteFile(File.FullName)
            Next
            For n As Integer = 0 To fl.Count
                ProgressBar1.Maximum = fl.Count
                Thread.Sleep(100)
                ProgressBar1.Value += 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = True
        If Label2.Text = "Please Wait" Then
        Else

        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox1.Image = My.Resources.success_11
            Button2.Enabled = True
        End If
    End Sub
End Class
