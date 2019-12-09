Imports System.Data.SqlClient

Public Class Info_by_University_2

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Public Shared dr As SqlDataReader

    Public Shared nextForm As Boolean = False

    Public Shared selectDepart4 As String

    Private Sub Info_by_University_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd.Connection = cn
        loadListBox()

    End Sub

    Private Sub loadListBox()

        txt_Un.Clear()
        txt_Un.Text = Info_by_University.selectUniver

        ListBoxSect.Items.Clear()

        txt_Sector.Clear()

        ListBoxDepart3.Items.Clear()


        cn.Open()
        cmd.CommandText = "select sectName from university inner join school_sector on school_sector.unID=university.unID where unName='" & txt_Un.Text & "' order by sectName"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                ListBoxSect.Items.Add(dr("sectName"))

            End While

        End If

        cn.Close() 'κλείνουμε το connection

        ListBoxDepart3.Items.Clear()

        cn.Open() 'ανοίγουμε το connection με την βάση

        cmd.CommandText = "select dName from department inner join school_sector on department.sectID=school_sector.sectID inner join university on university.unID=school_sector.unID where unName='" & txt_Un.Text & "'"

        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                ListBoxDepart3.Items.Add(dr("dName"))

            End While

        End If

        'κλείνουμε το connection
        cn.Close()


    End Sub

    Private Sub ListBoxSect_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxSect.MouseClick

        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxSect.SelectedIndex = lb.SelectedIndex
            txt_Sector.Text = ListBoxSect.SelectedItem

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ListBoxDepart3.Items.Clear()

            cn.Open() 'ανοίγουμε το connection με την βάση

            cmd.CommandText = "select dName from department inner join school_sector on department.sectID=school_sector.sectID inner join university on university.unID=school_sector.unID where sectName='" & txt_Sector.Text & "'"

            dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command

            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                While (dr.Read())

                    ListBoxDepart3.Items.Add(dr("dName"))

                End While

            End If

            'κλείνουμε το connection
            cn.Close()

        End If

    End Sub

    Private Sub ListBoxDepart3_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxDepart3.MouseClick

        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then 'SelectedIndex: είναι το στοιχείο που εχει επιλεχθεί από την λίστα

            ListBoxDepart3.SelectedIndex = lb.SelectedIndex

            selectDepart4 = ListBoxDepart3.SelectedItem

            nextForm = True

        End If

    End Sub

    Private Sub btn_Info5_Click(sender As Object, e As EventArgs) Handles btn_Info5.Click
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