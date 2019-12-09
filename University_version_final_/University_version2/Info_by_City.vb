Imports System.Data.SqlClient

Public Class Info_by_City

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Public Shared dr As SqlDataReader

    Public Shared nextForm As Boolean = False

    Public Shared selectDepart2 As String

    Private Sub Info_by_City_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        loadListBox()
    End Sub

    Private Sub loadListBox()

        ListBoxCities.Items.Clear()

        cn.Open()
        cmd.CommandText = "select distinct dCity from department order by dCity"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                ListBoxCities.Items.Add(dr("dCity"))

            End While

        End If

        cn.Close() 'κλείνουμε το connection

    End Sub

    Private Sub ListBoxCities_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxCities.MouseClick

        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxCities.SelectedIndex = lb.SelectedIndex
            txt_City.Text = ListBoxCities.SelectedItem

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ListBoxDepart.Items.Clear()

            cn.Open() 'ανοίγουμε το connection με την βάση

            cmd.CommandText = "select dName from department where dCity='" & ListBoxCities.SelectedItem & "' order by dName"

            dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command

            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                While (dr.Read())

                    ListBoxDepart.Items.Add(dr("dName"))

                End While

            End If

            'κλείνουμε το connection
            cn.Close()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        End If

    End Sub

    Private Sub ListBoxDepart_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxDepart.MouseClick

        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then 'SelectedIndex: είναι το στοιχείο που εχει επιλεχθεί από την λίστα

            ListBoxDepart.SelectedIndex = lb.SelectedIndex

            selectDepart2 = ListBoxDepart.SelectedItem

            nextForm = True

        End If

    End Sub

    Private Sub btn_MoreInfo_Click(sender As Object, e As EventArgs) Handles btn_MoreInfo.Click
        If nextForm = True Then
            Me.Close()

            DepartmentInfo.Show()

        Else

            MessageBox.Show("please select department,if you want to continiue")

            'voice
            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.Speak("please select department,if you want to continiue")

        End If
    End Sub

End Class