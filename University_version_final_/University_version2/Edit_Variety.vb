Imports System.Data.SqlClient


Public Class Edit_Variety

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub Edit_Variety_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        loadListBox()
    End Sub

    Private Sub loadListBox()

        ListBoxVariety.Items.Clear()

        txt_Variety.Clear()

        cn.Open()
        cmd.CommandText = "select vName from variety_university order by vName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxVariety.Items.Add(dr("vName"))
            End While
        End If
        cn.Close()

    End Sub


    Private Sub ListBoxVariety_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxVariety.MouseClick
        Dim lb As ListBox

        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxVariety.SelectedIndex = lb.SelectedIndex

            txt_Variety.Text = ListBoxVariety.SelectedItem

        End If
    End Sub

    Private Sub btn_UpdateVar_Click(sender As Object, e As EventArgs) Handles btn_UpdateVar.Click
        If txt_Variety.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update variety_university set vName='" & txt_Variety.Text & "' where vName ='" & ListBoxVariety.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_Insert_Click(sender As Object, e As EventArgs) Handles btn_Insert.Click

        If txt_Variety.Text <> " " Then

            cn.Open()

            cmd.CommandText = "insert into variety_university (vName) values ('" & txt_Variety.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
        Admin.Show()
    End Sub
End Class