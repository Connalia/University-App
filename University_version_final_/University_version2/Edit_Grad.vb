Imports System.Data.SqlClient

Public Class Edit_Grad

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Close()

        Admin.Show()
    End Sub

    Private Sub Edit_Grad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd.Connection = cn

        loadListBox()

    End Sub

    Private Sub loadListBox()

        ListBoxGrad.Items.Clear()

        txt_Grad.Clear()
        txt_Note.Clear()
        txt_Univer.Clear()
        txt_UNid.Clear()

        cn.Open()
        cmd.CommandText = "select gradName from postgraduate order by gradName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxGrad.Items.Add(dr("gradName"))
            End While
        End If
        cn.Close()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_Univer.AutoCompleteCustomSource.Clear()

        txt_Univer.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_Univer.AutoCompleteSource = AutoCompleteSource.CustomSource

        cn.Open()

        cmd.CommandText = "select distinct unName from university"

        'δρομέας,o data reader// εκτελει το command
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                txt_Univer.AutoCompleteCustomSource.Add(dr("unName"))

            End While

        End If

        'κλείνουμε το connection
        cn.Close()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto


    End Sub


    Private Sub ListBoxGrad_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxGrad.MouseClick

        Dim lb As ListBox

        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxGrad.SelectedIndex = lb.SelectedIndex

            txt_Grad.Text = ListBoxGrad.SelectedItem

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            txt_Note.Clear()

            'ανοίγουμε το connection με την βάση
            cn.Open()

            cmd.CommandText = "select gradNote,unName from postgraduate left outer join university on university.unID=postgraduate.unID where gradName='" & ListBoxGrad.SelectedItem & "'"

            'δρομέας,o data reader// εκτελει το command
            dr = cmd.ExecuteReader()

            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                While (dr.Read())

                    txt_Note.Text = dr("gradNote")
                    txt_Univer.Text = dr("unName")

                End While

            End If

            'κλείνουμε το connection
            cn.Close()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            txt_UNid.Clear()

            'ανοίγουμε το connection με την βάση
            cn.Open()

            cmd.CommandText = "select unID from postgraduate where gradName='" & ListBoxGrad.SelectedItem & "'"

            'δρομέας,o data reader// εκτελει το command
            dr = cmd.ExecuteReader()

            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                While (dr.Read())

                    txt_UNid.Text = dr("unID")

                End While

            End If

            'κλείνουμε το connection
            cn.Close()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        End If

    End Sub

    Private Sub btn_upGrad_Click(sender As Object, e As EventArgs) Handles btn_upGrad.Click
        If txt_Grad.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update postgraduate set gradName='" & txt_Grad.Text & "' where gradName ='" & ListBoxGrad.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_upNote_Click(sender As Object, e As EventArgs) Handles btn_upNote.Click
        If txt_Note.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update postgraduate set gradNote='" & txt_Note.Text & "' where gradName ='" & ListBoxGrad.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click

        If txt_Grad.Text <> " " And txt_Note.Text <> " " And txt_UNid.Text <> " " Then

            cn.Open()

            cmd.CommandText = "insert into postgraduate (gradName,gradNote,unID) values ('" & txt_Grad.Text & "','" & txt_Note.Text & "','" & txt_UNid.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If txt_Univer.Text <> " " Then

            cn.Open()

            cmd.CommandText = "select distinct unID from university where unName='" & txt_Univer.Text & "'"

            'δρομέας,o data reader// εκτελει το command
            dr = cmd.ExecuteReader()

            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                While (dr.Read())

                    txt_UNid.Text = dr("unID")

                End While

            End If

            cn.Close()

        End If
    End Sub
End Class



