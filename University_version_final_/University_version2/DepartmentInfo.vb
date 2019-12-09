Imports System.Data.SqlClient

Imports System.Data.DataTable 'need from grid viewer


Public Class DepartmentInfo

    Public departName As String

    Public Shared selectLink As String

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Public boolRefresh As Boolean = True

    Private Sub DepartmentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd.Connection = cn

        loadListBox()

    End Sub




    Private Sub loadListBox()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txtDepart.AutoCompleteCustomSource.Clear()
        txtDepart.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtDepart.AutoCompleteSource = AutoCompleteSource.CustomSource

        cn.Open()
        cmd.CommandText = "select distinct dName from department order by dName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txtDepart.AutoCompleteCustomSource.Add(dr("dName"))
            End While
        End If
        cn.Close()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        If Info_by_Jobs.nextForm = True And boolRefresh = True Then
            departName = Info_by_Jobs.selectDepart
        ElseIf Info_by_City.nextForm = True And boolRefresh = True Then
            departName = Info_by_City.selectDepart2
        ElseIf Info_by_Scien.nextForm = True And boolRefresh = True Then
            departName = Info_by_Scien.selectDepart3
        ElseIf Info_by_University_2.nextForm = True And boolRefresh = True Then
            departName = Info_by_University_2.selectDepart4
        ElseIf Form1.nextForm = True And boolRefresh = True Then
            departName = Form1.selectDepart6
        ElseIf boolRefresh = False Then
            departName = txtDepart.Text
        End If
        boolRefresh = False


        ListBoxYear.Items.Clear()
        ListBoxMoria.Items.Clear()


        txtDepart.Clear()
        txt_dCode.Clear()
        txt_dCity.Clear()
        txt_durationStudy.Clear()
        txt_dLink.Clear()
        txt_dNote.Clear()
        ListBoxScienName.Items.Clear()
        ListBoxExtra.Items.Clear()
        txt_University.Clear()
        txt_Sector.Clear()
        txt_var.Clear()
        ListBoxDirection.Items.Clear()
        ListBoxGrad.Items.Clear()
        ListBoxProfJob.Items.Clear()
        ListBoxPlace.Items.Clear()
        txt_rightsNote.Clear()

        txtDepart.Text = departName




        load()


    End Sub

    Private Sub load()
        'ανοίγουμε το connection με την βάση
        cn.Open()

        cmd.CommandText = "select distinct dCode, durationStudy, dCity,dLink,dNote,sectName,unName,vName,rName,scienName from department inner join school_sector on department.sectID=school_sector.sectID inner join university on university.unID=school_sector.unID inner join variety_university on variety_university.vID=university.vID inner join department_professional_rightsNote on department.dID=department_professional_rightsNote.dID inner join professional_rightsNote on professional_rightsNote.rID=department_professional_rightsNote.rID left outer join department_scientific_field on department.dID= department_scientific_field.dID left outer join scientific_field on department_scientific_field.scienID=scientific_field.scienID where dName='" & departName & "'"

        'δρομέας,o data reader// εκτελει το command
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                txt_dCode.Text = dr("dCode")
                txt_dCity.Text = dr("dCity")
                txt_durationStudy.Text = dr("durationStudy")

                txt_dLink.Text = dr("dLink")



                txt_dNote.Text = dr("dNote")
                txt_Sector.Text = dr("sectName")
                txt_University.Text = dr("unName")
                txt_var.Text = dr("vName")
                txt_rightsNote.Text = dr("rName")
                'ListBoxScienName.Items.Add(dr("scienName"))

            End While

            'selectLink = txt_dLink.Text



        End If
        cn.Close()

        cn.Open()
        cmd.CommandText = "select scienName from scientific_field inner join department_scientific_field on scientific_field.scienID=department_scientific_field.scienID inner join department on department.dID=department_scientific_field.dID where dName='" & departName & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxScienName.Items.Add(dr("scienName"))
            End While
        End If
        cn.Close()

        cn.Open()
        cmd.CommandText = "select extraName from department left outer join department_extra_courses on department.dID=department_extra_courses.dID left outer join extra_courses on department_extra_courses.extraID=extra_courses.extraID where dName='" & departName & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read())

                ListBoxExtra.Items.Add(dr("extraName"))

            End While
        End If

        'κλείνουμε το connection
        cn.Close()

        cn.Open()
        cmd.CommandText = "select gradName from department inner join department_postgraduate on department_postgraduate.dID=department.dID inner join postgraduate on postgraduate.gradID=department_postgraduate.gradID where dName='" & departName & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read())

                ListBoxGrad.Items.Add(dr("gradName"))

            End While
        End If
        'κλείνουμε το connection
        cn.Close()

        cn.Open()
        cmd.CommandText = "select directionName from department inner join direction on direction.dID=department.dID where dName='" & departName & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read())
                ListBoxDirection.Items.Add(dr("directionName"))

            End While
        End If
        'κλείνουμε το connection
        cn.Close()

        cn.Open()
        cmd.CommandText = "select jobName from department inner join department_profession_job on department_profession_job.dID=department.dID inner join profession_job on department_profession_job.jobID=profession_job.jobID where dName='" & departName & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read())

                ListBoxProfJob.Items.Add(dr("jobName"))

            End While
        End If
        'κλείνουμε το connection
        cn.Close()

        cn.Open()
        cmd.CommandText = "select plName from department inner join department_indicative_employment_places on department_indicative_employment_places.dID=department.dID inner join indicative_employment_places on department_indicative_employment_places.plID=indicative_employment_places.plID where dName='" & departName & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read())

                ListBoxPlace.Items.Add(dr("plName"))

            End While
        End If
        'κλείνουμε το connection
        cn.Close()

        cn.Open()
        cmd.CommandText = "SELECT bYear FROM base inner join department on department.dID=base.dID where dName='" & departName & "' order by bYear desc"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read())

                ListBoxYear.Items.Add(dr("bYear"))

            End While
        End If
        'κλείνουμε το connection
        cn.Close()

        cn.Open()
        cmd.CommandText = "SELECT bNum FROM base inner join department on department.dID=base.dID where dName='" & departName & "' order by bYear desc"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read())

                ListBoxMoria.Items.Add(dr("bNum"))

            End While
        End If
        'κλείνουμε το connection
        cn.Close()
    End Sub

    Private Sub btnViewSite_Click(sender As Object, e As EventArgs) Handles btnViewSite.Click
        selectLink = txt_dLink.Text
        WebBrowser.Show()
    End Sub



    Private Sub ListBoxYear_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxYear.MouseClick, ListBoxMoria.MouseClick

        Dim lb As ListBox

        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxYear.SelectedIndex = lb.SelectedIndex
            ListBoxMoria.SelectedIndex = lb.SelectedIndex

        End If

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click

        loadListBox()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        ListBoxYear.Items.Clear()
        ListBoxMoria.Items.Clear()



        txtDepart.Clear()
        txt_dCode.Clear()
        txt_dCity.Clear()
        txt_durationStudy.Clear()
        txt_dLink.Clear()
        txt_dNote.Clear()
        ListBoxScienName.Items.Clear()
        ListBoxExtra.Items.Clear()
        txt_University.Clear()
        txt_Sector.Clear()
        txt_var.Clear()
        ListBoxDirection.Items.Clear()
        ListBoxGrad.Items.Clear()
        ListBoxProfJob.Items.Clear()
        ListBoxPlace.Items.Clear()
        txt_rightsNote.Clear()


        Me.Close()
        Form1.Show()
    End Sub
End Class


''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'cn.Open()
'cmd.CommandText = "select scienName from department  "
'dr = cmd.ExecuteReader()
'If dr.HasRows Then
'While (dr.Read())
'ListBoxScienName.Items.Add(dr("scienName"))
'End While
'End If
'cn.Close()
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


