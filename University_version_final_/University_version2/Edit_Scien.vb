Imports System.Data.SqlClient

Public Class Edit_Scien

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub btn_End_Click(sender As Object, e As EventArgs) Handles btn_End.Click
        Me.Close()

        Admin.Show()
    End Sub

    Private Sub Edit_Scien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        loadListBox()
    End Sub

    Private Sub loadListBox()

        ListBoxScien.Items.Clear()

        txt_Scien.Clear()

        cn.Open()
        cmd.CommandText = "select scienName from scientific_field order by scienName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxScien.Items.Add(dr("scienName"))
            End While
        End If
        cn.Close()

    End Sub

    Private Sub ListBoxScien_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxScien.MouseClick
        Dim lb As ListBox

        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxScien.SelectedIndex = lb.SelectedIndex

            txt_Scien.Text = ListBoxScien.SelectedItem

        End If
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        If txt_Scien.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update scientific_field set scienName='" & txt_Scien.Text & "' where scienName ='" & ListBoxScien.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_in_Click(sender As Object, e As EventArgs) Handles btn_in.Click
        If txt_Scien.Text <> " " Then

            cn.Open()

            cmd.CommandText = "insert into scientific_field (scienName) values ('" & txt_Scien.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub
End Class