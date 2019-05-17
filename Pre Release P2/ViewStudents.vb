Public Class ViewStudents

    Public Sub ViewStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        file_refresh()
        Parameters.display_data_count_3()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        MainMenu.Show()
        MainMenu.Controls.Clear()
        MainMenu.InitializeComponent()
        MainMenu.MainMenu_Load(sender, e)

    End Sub

    Public Sub display_all()

        DataGridView1.DataSource = student_data

    End Sub

    Private Sub ProgramClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            End
        End If

    End Sub

End Class