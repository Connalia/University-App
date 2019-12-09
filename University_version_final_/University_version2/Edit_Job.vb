Imports System.Data.SqlClient

Public Class Edit_Job

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub btn_EndJob_Click(sender As Object, e As EventArgs) Handles btn_EndJob.Click
        Me.Close()

        Admin.Show()
    End Sub

    Private Sub Edit_Job_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        loadListBox()
    End Sub

    Private Sub loadListBox()

        ListBoxJob.Items.Clear()

        txt_Job.Clear()
        txt_Note.Clear()

        cn.Open()
        cmd.CommandText = "select jobName from profession_job order by jobName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxJob.Items.Add(dr("jobName"))
            End While
        End If
        cn.Close()

    End Sub

    Private Sub ListBoxJob_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxJob.MouseClick
        Dim lb As ListBox

        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxJob.SelectedIndex = lb.SelectedIndex

            txt_Job.Text = ListBoxJob.SelectedItem

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            txt_Note.Clear()

            'ανοίγουμε το connection με την βάση
            cn.Open()

            cmd.CommandText = "select jobNote from profession_job where jobName='" & ListBoxJob.SelectedItem & "'"

            'δρομέας,o data reader// εκτελει το command
            dr = cmd.ExecuteReader()

            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                While (dr.Read())

                    txt_Note.Text = dr("JobNote")

                End While

            End If

            'κλείνουμε το connection
            cn.Close()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        End If
    End Sub

    Private Sub btn_Up_Job_Click(sender As Object, e As EventArgs) Handles btn_Up_Job.Click
        If txt_Job.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update profession_job set JobName='" & txt_Job.Text & "' where JobName ='" & ListBoxJob.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If

    End Sub

    Private Sub btnUpNote_Click(sender As Object, e As EventArgs) Handles btnUpNote.Click
        If txt_Job.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update profession_job set JobNote='" & txt_Note.Text & "' where JobName ='" & ListBoxJob.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_InJOB_Click(sender As Object, e As EventArgs) Handles btn_InJOB.Click
        If txt_Job.Text <> " " And txt_Note.Text <> " " Then

            cn.Open()

            cmd.CommandText = "insert into profession_job (JobName,JobNote) values ('" & txt_Job.Text & "','" & txt_Note.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub


End Class