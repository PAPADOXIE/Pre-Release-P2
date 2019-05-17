Public Class NewStudent
    Public Sub NewStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        file_refresh()
        Parameters.display_data_count_2()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim student_name As String = TextBox1.Text
        Dim student_email As String = TextBox2.Text

        Parameters.add_to_list(student_name, student_email)

        Me.Controls.Clear()
        InitializeComponent()
        NewStudent_Load(sender, e)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        MainMenu.Show()
        MainMenu.Controls.Clear()
        MainMenu.InitializeComponent()
        MainMenu.MainMenu_Load(sender, e)

    End Sub


    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click

        TextBox1.Text = ""

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click

        TextBox2.Text = ""

    End Sub

    Private Sub Shadows_Enter(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = ChrW(Keys.Return) Then

            Button1_Click(sender, e)

        End If

    End Sub

    Private Sub ProgramClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            End
        End If

    End Sub

End Class

