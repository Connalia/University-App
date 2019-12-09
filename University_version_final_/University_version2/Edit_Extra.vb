Imports System.Data.SqlClient

Public Class Edit_Extra

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub btn_EndExtra_Click(sender As Object, e As EventArgs) Handles btn_EndExtra.Click
        Me.Close()

        Admin.Show()
    End Sub

    Private Sub Edit_Extra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        loadListBox()
    End Sub

    Private Sub loadListBox()

        ListBoxExtra.Items.Clear()

        txt_Extra.Clear()

        cn.Open()
        cmd.CommandText = "select extraName from extra_courses order by extraName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxExtra.Items.Add(dr("extraName"))
            End While
        End If
        cn.Close()

    End Sub

    Private Sub ListBoxExtra_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxExtra.MouseClick
        Dim lb As ListBox

        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxExtra.SelectedIndex = lb.SelectedIndex

            txt_Extra.Text = ListBoxExtra.SelectedItem

        End If
    End Sub

    Private Sub Up_Extra_Click(sender As Object, e As EventArgs) Handles Up_Extra.Click
        If txt_Extra.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update extra_courses set extraName='" & txt_Extra.Text & "' where extraName ='" & ListBoxExtra.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub In_Extra_Click(sender As Object, e As EventArgs) Handles In_Extra.Click

        If txt_Extra.Text <> " " Then

            cn.Open()

            cmd.CommandText = "insert into extra_courses (extraName) values ('" & txt_Extra.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub
End Class