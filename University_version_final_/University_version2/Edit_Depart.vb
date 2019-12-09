Imports System.Data.SqlClient

Public Class Edit_Depart

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Public Shared selectDepartEdit As String
    Private Sub btn_End_Click(sender As Object, e As EventArgs) Handles btn_End.Click
        Me.Close()
        Admin.Show()
    End Sub

    Private Sub Edit_Depart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        loadListBox()
    End Sub

    Private Sub loadListBox()

        ListBoxDepart.Items.Clear()


        txt_city.Clear()
        txt_Code.Clear()
        txt_Depart.Clear()
        txt_duration.Clear()
        txt_link.Clear()
        txt_Note.Clear()
        txt_Sect.Clear()
        txt_sectId.Clear()

        cn.Open()
        cmd.CommandText = "select distinct dName from department order by dName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxDepart.Items.Add(dr("dName"))
            End While
        End If
        cn.Close()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_Depart.AutoCompleteCustomSource.Clear()

        txt_Depart.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_Depart.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Loop through each listbox item and add it to the Autocomplete source
        For i As Integer = 0 To ListBoxDepart.Items.Count - 1
            txt_Depart.AutoCompleteCustomSource.Add(ListBoxDepart.Items(i))
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_Sect.AutoCompleteCustomSource.Clear()

        txt_Sect.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_Sect.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Loop through each listbox item and add it to the Autocomplete source
        cn.Open()

        cmd.CommandText = "select distinct sectName from school_sector"

        'δρομέας,o data reader// εκτελει το command
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                txt_Sect.AutoCompleteCustomSource.Add(dr("sectName"))

            End While

        End If

        'κλείνουμε το connection
        cn.Close()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_city.AutoCompleteCustomSource.Clear()

        txt_city.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_city.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Loop through each listbox item and add it to the Autocomplete source
        cn.Open()

        cmd.CommandText = "select distinct dCity from department"

        'δρομέας,o data reader// εκτελει το command
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                txt_city.AutoCompleteCustomSource.Add(dr("dCity"))

            End While

        End If

        'κλείνουμε το connection
        cn.Close()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto

    End Sub

    Private Sub ListBoxDepart_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxDepart.MouseClick
        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxDepart.SelectedIndex = lb.SelectedIndex

            txt_Depart.Text = ListBoxDepart.SelectedItem

            loadAllInfo()

        End If

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If txt_Sect.Text <> " " Then

            cn.Open()

            cmd.CommandText = "select distinct sectID from school_sector where sectName='" & txt_Sect.Text & "'"

            'δρομέας,o data reader// εκτελει το command
            dr = cmd.ExecuteReader()

            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                While (dr.Read())

                    txt_sectId.Text = dr("sectID")

                End While

            End If

            cn.Close()

        End If
    End Sub

    Private Sub btn_ok_Depart_Click(sender As Object, e As EventArgs) Handles btn_ok_Depart.Click
        If txt_Depart.Text <> " " Then

            loadAllInfo()

        End If
    End Sub

    Private Sub loadAllInfo()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        txt_city.Clear()
        txt_Code.Clear()
        txt_duration.Clear()
        txt_link.Clear()
        txt_Note.Clear()
        txt_Sect.Clear()
        txt_sectId.Clear()

        cn.Open()

        cmd.CommandText = "select dCode,durationStudy,dLink,dNote,dCity,sectID from department where dName='" & txt_Depart.Text & "'"
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                txt_city.Text = dr("dCity")
                txt_Code.Text = dr("dCode")
                txt_duration.Text = dr("durationStudy")
                txt_link.Text = dr("dLink")
                txt_Note.Text = dr("dNote")
                'txt_Sect.Text = dr("JobNote")
                txt_sectId.Text = dr("sectID")

            End While

        End If
        cn.Close()

        cn.Open()

        cmd.CommandText = "select sectName from school_sector where sectID='" & txt_sectId.Text & "'"
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                txt_Sect.Text = dr("sectName")

            End While

        End If
        cn.Close()


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub btn_Up_NameDep_Click(sender As Object, e As EventArgs) Handles btn_Up_NameDep.Click
        If txt_Depart.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update department set dName='" & txt_Depart.Text & "' where dName ='" & ListBoxDepart.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_upLink_Click(sender As Object, e As EventArgs) Handles btn_upLink.Click
        If txt_link.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update department set dLink='" & txt_link.Text & "' where dName ='" & ListBoxDepart.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_UpNote_Click(sender As Object, e As EventArgs) Handles btn_UpNote.Click
        If txt_Note.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update department set dNote='" & txt_Note.Text & "' where dName ='" & ListBoxDepart.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_upCity_Click(sender As Object, e As EventArgs) Handles btn_upCity.Click
        If txt_city.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update department set dCity='" & txt_city.Text & "' where dName ='" & ListBoxDepart.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_UpCode_Click(sender As Object, e As EventArgs) Handles btn_UpCode.Click
        If txt_Code.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update department set dCode='" & txt_Code.Text & "' where dName ='" & ListBoxDepart.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btn_upDuration_Click(sender As Object, e As EventArgs) Handles btn_upDuration.Click
        If txt_duration.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update department set durationStudy='" & txt_duration.Text & "' where dName ='" & ListBoxDepart.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBox()

        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'κλείνουμε το connection
        cn.Close()

        If txt_Depart.Text <> " " And
            txt_city.Text <> " " And
            txt_Code.Text <> " " And
            txt_duration.Text <> " " And
            txt_link.Text <> " " And
            txt_Note.Text <> " " And
            txt_Sect.Text <> " " And
            txt_sectId.Text <> " " Then

            cn.Open()

            cmd.CommandText = "insert into department (dName,dCode,durationStudy,dLink,dNote,dCity,sectID) values ('" & txt_Depart.Text & " ','" & txt_Code.Text & "','" & txt_duration.Text & "','" & txt_link.Text & "','" & txt_Note.Text & "','" & txt_city.Text & "','" & txt_sectId.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            selectDepartEdit = txt_Depart.Text

            loadListBox()

        End If



        Me.Close()
        Edit_Depart_MoreInfo.Show()

    End Sub

    Private Sub btn_more_Click(sender As Object, e As EventArgs) Handles btn_more.Click
        If txt_Depart.Text <> " " Then
            selectDepartEdit = txt_Depart.Text

            Me.Close()
            Edit_Depart_MoreInfo.Show()

        Else

            MessageBox.Show("please select department,if you want to continiue and see more info")

        End If

    End Sub
End Class