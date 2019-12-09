Imports System.Data.SqlClient

Public Class Edit_University_Sect

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Public Shared flag As Boolean


    Private Sub btn_End_Click(sender As Object, e As EventArgs) Handles btn_End.Click
        Me.Close()

        Edit_University.Show()
    End Sub

    Private Sub Edit_University_Sect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        flag = True

        loadListBox()
    End Sub

    Private Sub loadListBox()

        ListBoxUnver.Items.Clear()
        ListBoxSect.Items.Clear()

        txt_Sect.Clear()
        txt_unId.Clear()


        If flag = True Then
            txt_Unver.Clear()
            txt_Unver.Text = Edit_University.selectUniver
            flag = False

        End If


        cn.Open()
        cmd.CommandText = "select unName from university order by unName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxUnver.Items.Add(dr("unName"))
            End While
        End If
        cn.Close()

        cn.Open()
        cmd.CommandText = "select unID from university where unName='" & txt_Unver.Text & "'"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txt_unId.Text = dr("unID")
            End While
        End If
        cn.Close()

        cn.Open()
        cmd.CommandText = "select sectName from school_sector left outer join university on university.unID=school_sector.unID where unName='" & txt_Unver.Text & "'"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxSect.Items.Add(dr("sectName"))
            End While
        End If
        cn.Close()

    End Sub

    Private Sub ListBoxSect_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxSect.MouseClick
        Dim lb As ListBox

        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxSect.SelectedIndex = lb.SelectedIndex

            txt_Sect.Text = ListBoxSect.SelectedItem

        End If
    End Sub


    Private Sub ListBoxUnver_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxUnver.MouseClick
        txt_Unver.Clear()
        Dim lb As ListBox

        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxUnver.SelectedIndex = lb.SelectedIndex


            txt_Unver.Text = ListBoxUnver.SelectedItem

        End If

        loadListBox()



    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If txt_Sect.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update school_sector set sectName='" & txt_Sect.Text & "' where sectName ='" & ListBoxSect.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_in_Click(sender As Object, e As EventArgs) Handles btn_in.Click
        If txt_Sect.Text <> " " And txt_unId.Text <> " " Then

            cn.Open()

            cmd.CommandText = "insert into school_sector (sectName,unID) values ('" & txt_Sect.Text & "','" & txt_unId.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub
End Class