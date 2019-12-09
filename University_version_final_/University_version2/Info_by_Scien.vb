Imports System.Data.SqlClient

Public Class Info_by_Scien

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Public Shared dr As SqlDataReader

    Public Shared nextForm As Boolean = False

    Public Shared selectDepart3 As String

    Private Sub Info_by_Scien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        loadListBox()
    End Sub

    Private Sub loadListBox()

        ListBoxScien.Items.Clear()

        cn.Open()
        cmd.CommandText = "select distinct scienName from scientific_field"
        dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                ListBoxScien.Items.Add(dr("scienName"))

            End While

        End If

        cn.Close() 'κλείνουμε το connection

    End Sub

    Private Sub ListBoxScien_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxScien.MouseClick

        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxScien.SelectedIndex = lb.SelectedIndex
            txt_Scien.Text = ListBoxScien.SelectedItem

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ListBoxDepart2.Items.Clear()

            cn.Open() 'ανοίγουμε το connection με την βάση

            cmd.CommandText = "select dName  from department inner join department_scientific_field on department.dID= department_scientific_field.dID inner join scientific_field on department_scientific_field.scienID=scientific_field.scienID where scienName='" & ListBoxScien.SelectedItem & "' order by dName"

            dr = cmd.ExecuteReader() 'δρομέας,o data reader// εκτελει το command

            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                While (dr.Read())

                    ListBoxDepart2.Items.Add(dr("dName"))

                End While

            End If

            'κλείνουμε το connection
            cn.Close()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        End If

    End Sub


    Private Sub ListBoxDepart2_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxDepart2.MouseClick
        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then 'SelectedIndex: είναι το στοιχείο που εχει επιλεχθεί από την λίστα

            ListBoxDepart2.SelectedIndex = lb.SelectedIndex

            selectDepart3 = ListBoxDepart2.SelectedItem

            nextForm = True

        End If
    End Sub

    Private Sub btn_more_Info2_Click(sender As Object, e As EventArgs) Handles btn_more_Info2.Click
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