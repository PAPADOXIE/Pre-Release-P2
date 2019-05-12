Public Class DeleteStudents

    Public Sub DeleteStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        file_refresh()
        Parameters.display_data_count_4()

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try

            delete_from_file(DataGridView1.CurrentRow.Index)
            student_data.RemoveAt(DataGridView1.CurrentRow.Index)

        Catch ex As Exception
            MessageBox.Show("No more students to delete")

        End Try

        Me.Controls.Clear()
        Me.InitializeComponent()
        Me.DeleteStudents_Load(sender, e)
        DataGridView1.Refresh()
        ViewStudents.DataGridView1.Refresh()
        file_refresh()
        display_all()

    End Sub

    Private Sub ProgramClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            End
        End If

    End Sub

End Class