Module FileHandler

    Sub add_to_file(ByVal student_name As String, ByVal student_email As String)

        Dim indexer As Integer = hash(student_name, student_email)

        openfile()

        FilePut(1, student_name & "#" & student_email, indexer)

        closefile()

    End Sub

    Sub read_from_file()

        Dim raw_data As String = ""
        Dim name As String
        Dim email As String

        openfile()

        Do While Not EOF(1)

            FileGet(1, raw_data)

            If raw_data <> vbNullString Then

                name = Mid(raw_data, 1, (InStr(raw_data, "#") - 1))
                email = Mid(raw_data, (InStr(raw_data, "#") + 1), (Len(raw_data) - Len(name)))
                student_data.Add(New Students(name, email))

            End If

        Loop

        closefile()

    End Sub

    Sub delete_from_file(ByVal removable As Integer)

        Try


            Dim name As String = student_data(removable).student_name
            Dim email As String = student_data(removable).student_email

            Dim indexer As Integer = hash(name, email)

            openfile()

            FilePut(1, vbNullString, indexer)

            closefile()

        Catch ex As Exception
            MessageBox.Show("No more students to delete")

        End Try

    End Sub

    Sub file_refresh()
        student_data.Clear()
        read_from_file()
    End Sub

    Sub openfile()
        FileOpen(1, "Student File.bin", OpenMode.Random, OpenAccess.Default, -1)
    End Sub

    Sub closefile()
        FileClose(1)
    End Sub

    Function hash(ByVal student_name As String, ByVal student_email As String)

        Dim hasher As Integer

        For i = 1 To student_name.Length
            hasher = (hasher + Asc(Mid(student_name, i, 1)))
        Next

        For i = 1 To student_email.Length
            hasher = (hasher + Asc(Mid(student_email, i, 1)))
        Next


        Return hasher

    End Function

End Module
