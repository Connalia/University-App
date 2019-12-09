Imports System.Data.SqlClient

Public Class Info_by_Jobs

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Public Shared dr As SqlDataReader

    Public Shared nextForm As Boolean = False

    Public Shared selectDepart As String

    Private Sub Info_by_Jobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd.Connection = cn

        loadListBox()

    End Sub

    Private Sub loadListBox()


        'καθαρίζουμε την λίστα μας,γιατι κάθε φορά που την γεμίζουμε θα φαινονται τα προηγουμενα
        ListBoxJobs.Items.Clear()
        ListBoxDepartment.Items.Clear()

        'ανοίγουμε το connection με την βάση
        cn.Open()

        cmd.CommandText = "select Jobname from profession_job order by Jobname"

        'δρομέας,o data reader// εκτελει το command
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                ListBoxJobs.Items.Add(dr("JobName"))

            End While

        End If

        'κλείνουμε το connection
        cn.Close()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_Job.AutoCompleteCustomSource.Clear()

        txt_Job.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_Job.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Loop through each listbox item and add it to the Autocomplete source
        For i As Integer = 0 To ListBoxJobs.Items.Count - 1
            txt_Job.AutoCompleteCustomSource.Add(ListBoxJobs.Items(i))
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto

    End Sub

    Private Sub ListBoxJobs_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxJobs.MouseClick

        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxJobs.SelectedIndex = lb.SelectedIndex

            txt_Job.Text = ListBoxJobs.SelectedItem

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ListBoxDepartment.Items.Clear()
            txtJobNote.Clear()

            'ανοίγουμε το connection με την βάση
            cn.Open()

            cmd.CommandText = "select dName,JobNote from department left outer join department_profession_job on department.dID=department_profession_job.dID left outer join profession_job on department_profession_job.jobID=profession_job.jobID where jobName='" & ListBoxJobs.SelectedItem & "' order by dName"

            'δρομέας,o data reader// εκτελει το command
            dr = cmd.ExecuteReader()

            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                While (dr.Read())

                    ListBoxDepartment.Items.Add(dr("dName"))


                    txtJobNote.Text = dr("JobNote")

                End While

            End If

            'κλείνουμε το connection
            cn.Close()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        End If

    End Sub



    Private Sub btnMoreInfo_Click(sender As Object, e As EventArgs) Handles btnMoreInfo.Click

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

    Public Sub ListBoxDepartment_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxDepartment.MouseClick

        Dim lb As ListBox
        lb = sender

        'SelectedIndex: είναι το στοιχείο που εχει επιλεχθεί από την λίστα
        If lb.SelectedIndex <> -1 Then

            ListBoxDepartment.SelectedIndex = lb.SelectedIndex

            selectDepart = ListBoxDepartment.SelectedItem

            nextForm = True

        End If

    End Sub

    Private Sub btn_SearchJob_Click(sender As Object, e As EventArgs) Handles btn_SearchJob.Click



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ListBoxDepartment.Items.Clear()
        txtJobNote.Clear()

        'ανοίγουμε το connection με την βάση
        cn.Open()

        cmd.CommandText = "select dName,JobNote from department left outer join department_profession_job on department.dID=department_profession_job.dID left outer join profession_job on department_profession_job.jobID=profession_job.jobID where jobName='" & txt_Job.Text & "' order by dName"

        'δρομέας,o data reader// εκτελει το command
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                ListBoxDepartment.Items.Add(dr("dName"))


                txtJobNote.Text = dr("JobNote")

            End While

        End If

        'κλείνουμε το connection
        cn.Close()

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    End Sub

End Class