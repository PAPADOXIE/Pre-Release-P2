Imports System.Console

Public Class MainMenu

    Public Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        file_refresh()
        Parameters.display_data_count_1()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        NewStudent.Show()
        NewStudent.Controls.Clear()
        NewStudent.InitializeComponent()
        NewStudent.NewStudent_Load(sender, e)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        ViewStudents.Show()
        ViewStudents.Controls.Clear()
        ViewStudents.InitializeComponent()
        ViewStudents.ViewStudents_Load(sender, e)
        ViewStudents.display_all()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Hide()
        DeleteStudents.Show()
        DeleteStudents.Controls.Clear()
        DeleteStudents.InitializeComponent()
        DeleteStudents.DeleteStudents_Load(sender, e)
        DeleteStudents.display_all

    End Sub

    Private Sub button_x(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProgramClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            End
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Hide()
        SearchStudents.Show()
        SearchStudents.Controls.Clear()
        SearchStudents.InitializeComponent()
        SearchStudents.Search_Students_Load(sender, e)
        SearchStudents.display_all()

    End Sub
End Class


