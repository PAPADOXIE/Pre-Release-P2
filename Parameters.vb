Module Parameters

    Public student_data As New List(Of Students)

    Sub enter_data(ByRef name As String, ByRef email As String)

        If NewStudent.TextBox1.Text = "Enter Name of Student" Or NewStudent.TextBox1.Text = vbNullString Then
            name = vbNullString

            If NewStudent.TextBox2.Text = "Enter Email of Student" Or NewStudent.TextBox2.Text = vbNullString Then
                email = vbNullString

            End If

        End If

        NewStudent.TextBox1.Text = "Enter Name of Student"
        NewStudent.TextBox2.Text = "Enter Email of Student"

    End Sub

    Sub add_to_list(ByVal student_name As String, ByVal student_email As String)

        enter_data(student_name, student_email)

        If student_name <> vbNullString And student_email <> vbNullString Then

            FileHandler.add_to_file(student_name, student_email)
            student_data.Clear()
            FileHandler.file_refresh()

        End If

    End Sub

    Function search_from_list(ByVal student As Students)

        Dim index As Integer

        For i = 0 To student_data.Count - 1
            If student_data(i).student_name = student.student_name Or student_data(i).student_email = student.student_email Then
                index = i
            End If
        Next

        Return index

    End Function

    Sub display_data_count_1()

        MainMenu.Label1.Text = "Total Students = " & student_data.Count

    End Sub

    Sub display_data_count_2()

        NewStudent.Label1.Text = "Total Students = " & student_data.Count

    End Sub

    Sub display_data_count_3()

        ViewStudents.Label1.Text = "Total Students = " & student_data.Count

    End Sub

    Sub display_data_count_4()

        DeleteStudents.Label1.Text = "Total Students = " & student_data.Count

    End Sub

    Sub display_data_count_5()

        SearchStudents.Label1.Text = "Total Students = " & student_data.Count

    End Sub

End Module
