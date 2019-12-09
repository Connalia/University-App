Imports System.Data.SqlClient

Public Class Info_by_University

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Public Shared dr As SqlDataReader

    Public Shared selectUniver As String
    Dim nextF As Boolean = False

    Private Sub Info_by_University_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        loadListBox()
    End Sub

    Private Sub loadListBox()

        ListBoxVariety.Items.Clear()

        cn.Open()
        cmd.CommandText = "select distinct vName from variety_university order by vName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                ListBoxVariety.Items.Add(dr("vName"))

            End While

        End If

        cn.Close() 'κλείνουμε το connection

    End Sub

    Private Sub ListBoxVariety_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxVariety.MouseClick

        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxVariety.SelectedIndex = lb.SelectedIndex
            txt_Var.Text = ListBoxVariety.SelectedItem

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ListBoxUnvers.Items.Clear()

            cn.Open() 'ανοίγουμε το connection με την βάση

            cmd.CommandText = "select unName from variety_university inner join university on university.vID= variety_university.vID where vName='" & ListBoxVariety.SelectedItem & "' order by unName"

            dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command

            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                While (dr.Read())

                    ListBoxUnvers.Items.Add(dr("unName"))

                End While

            End If

            'κλείνουμε το connection
            cn.Close()

        End If

    End Sub

    Private Sub ListBoxUnvers_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxUnvers.MouseClick

        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then 'SelectedIndex: είναι το στοιχείο που εχει επιλεχθεί από την λίστα

            ListBoxUnvers.SelectedIndex = lb.SelectedIndex

            selectUniver = ListBoxUnvers.SelectedItem

            nextF = True

        End If

    End Sub

    Private Sub btn_Search_Univers_Click(sender As Object, e As EventArgs) Handles btn_Search_Univers.Click
        If nextF = True Then
            Me.Close()

            Info_by_University_2.Show()

        Else

            MessageBox.Show("please select department,if you want to continiue")

            'voice
            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.Speak("please select department,if you want to continiue")

        End If
    End Sub
End Class