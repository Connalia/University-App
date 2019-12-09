Imports System.Data.SqlClient

Public Class Edit_University

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Public Shared nextForm As Boolean = False

    Public Shared selectUniver As String

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
        Admin.Show()
    End Sub

    Private Sub Edit_University_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        loadListBox()
        autoVariety()
    End Sub

    Private Sub loadListBox()

        ListBoxUn.Items.Clear()

        txt_Univers.Clear()
        txt_Variety.Clear()
        txt_vID.Clear()

        cn.Open()
        cmd.CommandText = "select unName from university order by unName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxUn.Items.Add(dr("unName"))
            End While
        End If
        cn.Close()

    End Sub

    Private Sub ListBoxUn_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxUn.MouseClick
        Dim lb As ListBox

        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxUn.SelectedIndex = lb.SelectedIndex

            txt_Univers.Text = ListBoxUn.SelectedItem


            cn.Open()
            cmd.CommandText = "select  vName from variety_university inner join university on university.vID=variety_university.vID where unName='" & txt_Univers.Text & "'"
            dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_Variety.Text = dr("vName")
                End While
            End If
            cn.Close()

        End If

        ListBoxSect.Items.Clear()

        cn.Open()

        cmd.CommandText = " select distinct sectName from school_sector inner join university on university.unID=school_sector.unID where unName='" & txt_Univers.Text & "'"

        'δρομέας,o data reader// εκτελει το command
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                ListBoxSect.Items.Add(dr("sectName"))

            End While

        End If

        'κλείνουμε το connection
        cn.Close()

    End Sub

    Private Sub btn_upd_Click(sender As Object, e As EventArgs) Handles btn_upd.Click
        If txt_Variety.Text <> " " And txt_Univers.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update university set unName='" & txt_Univers.Text & "' where unName ='" & ListBoxUn.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub autoVariety()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_Variety2.AutoCompleteCustomSource.Clear()
        txt_var2.AutoCompleteCustomSource.Clear()

        txt_Variety2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_Variety2.AutoCompleteSource = AutoCompleteSource.CustomSource

        txt_var2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_var2.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Loop through each listbox item and add it to the Autocomplete source

        cmd.Connection = cn
        cn.Open()
        cmd.CommandText = "select distinct vName from variety_university order by vName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                txt_Variety2.AutoCompleteCustomSource.Add(dr("vName"))
                txt_var2.AutoCompleteCustomSource.Add(dr("vName"))

            End While

        End If
        cn.Close() 'κλείνουμε το connection

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click

        ListBoxUn.Items.Clear()

        cn.Open()
        cmd.CommandText = "select unName from university inner join variety_university on variety_university.vID=university.vID where vName='" & txt_Variety2.Text & "' order by unName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxUn.Items.Add(dr("unName"))
            End While
        End If
        cn.Close()

    End Sub

    Private Sub btn_Insert_Click(sender As Object, e As EventArgs) Handles btn_Insert.Click

        selectUniver = txt_Un2.Text

        If txt_var2.Text <> " " Then
            cn.Open()
            cmd.CommandText = "select vID from variety_university where vName='" & txt_var2.Text & "' "
            dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_vID.Text = dr("vID")
                End While
            End If
            cn.Close()
        End If

        If txt_var2.Text <> " " And txt_Un2.Text <> " " And txt_vID.Text <> " " Then

            cn.Open()

            cmd.CommandText = "insert into university (unName,vID) values ('" & txt_Un2.Text & "','" & txt_vID.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
        Edit_University_Sect.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        selectUniver = txt_Univers.Text
        Edit_University_Sect.Show()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If txt_var2.Text <> " " Then

            cn.Open()

            cmd.CommandText = "select distinct vID from variety_university where vName='" & txt_var2.Text & "'"

            'δρομέας,o data reader// εκτελει το command
            dr = cmd.ExecuteReader()

            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                While (dr.Read())

                    txt_vID.Text = dr("vID")

                End While

            End If

            cn.Close()

        End If
    End Sub
End Class