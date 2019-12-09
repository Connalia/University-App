Imports System.Data.SqlClient

Public Class Edit_Place

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub btn_End_Click(sender As Object, e As EventArgs) Handles btn_End.Click
        Me.Close()

        Admin.Show()
    End Sub

    Private Sub Edit_Place_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        loadListBox()
    End Sub

    Private Sub loadListBox()

        ListBoxPlace.Items.Clear()

        txt_Place.Clear()

        cn.Open()
        cmd.CommandText = "select plName from indicative_employment_places order by plName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxPlace.Items.Add(dr("plName"))
            End While
        End If
        cn.Close()

    End Sub

    Private Sub ListBoxPlace_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxPlace.MouseClick
        Dim lb As ListBox

        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxPlace.SelectedIndex = lb.SelectedIndex

            txt_Place.Text = ListBoxPlace.SelectedItem

        End If
    End Sub

    Private Sub btn_Up_Click(sender As Object, e As EventArgs) Handles btn_Up.Click
        If txt_Place.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update indicative_employment_places set plName='" & txt_Place.Text & "' where plName ='" & ListBoxPlace.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_In_Click(sender As Object, e As EventArgs) Handles btn_In.Click
        If txt_Place.Text <> " " Then

            cn.Open()

            cmd.CommandText = "insert into indicative_employment_places (plName) values ('" & txt_Place.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub
End Class