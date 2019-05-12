Public Class SearchStudents
    Public Sub Search_Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        file_refresh()
        Parameters.display_data_count_5()

    End Sub

    Public Sub display_all()

        DataGridView1.DataSource = student_data

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        MainMenu.Show()
        MainMenu.Controls.Clear()
        MainMenu.InitializeComponent()
        MainMenu.MainMenu_Load(sender, e)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim student As New Students(TextBox1.Text, TextBox2.Text)
        Dim index As Integer = Parameters.search_from_list(student)

        display(index)

    End Sub

    Private Sub display(ByVal index As Integer)

        For i = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White
        Next

        DataGridView1.Rows(index).DefaultCellStyle.BackColor = Color.LightGray

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

End Class