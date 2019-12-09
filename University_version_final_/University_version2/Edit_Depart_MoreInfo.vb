Imports System.Data.SqlClient

Public Class Edit_Depart_MoreInfo

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Public Shared dr As SqlDataReader

    Public departNameEditFlag As Boolean = False
    Private Sub Edit_Depart_MoreInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = cn

        loadListBox()
    End Sub

    Private Sub loadclearCheckbox()
        chlb_pedia.Items.Clear()
        chlb_Extra.Items.Clear()
        chlb_Grad.Items.Clear()
        chlb_Job.Items.Clear()
        chlb_Place.Items.Clear()
    End Sub
    Private Sub loadAll()
        loadListBoxDkateuthinsi()
        loadListBoxRight()
        loadListBoxYear()
        loadPedia()
        loadGrad()
        loadJob()
        loadPlace()
        loadExtra()
    End Sub

    Private Sub loadDefaultAll()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        cn.Open()
        cmd.CommandText = "select distinct scienName from scientific_field order by scienName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                chlb_pedia.Items.Add(dr("scienName"))
            End While
        End If
        cn.Close()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        cn.Open()
        cmd.CommandText = "select distinct extraName from extra_courses order by extraName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                chlb_Extra.Items.Add(dr("extraName"))
            End While
        End If
        cn.Close()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        cn.Open()
        cmd.CommandText = "select distinct plName from indicative_employment_places order by plName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                chlb_Place.Items.Add(dr("plName"))
            End While
        End If
        cn.Close()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        cn.Open()
        cmd.CommandText = "select distinct jobName from profession_job order by jobName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                chlb_Job.Items.Add(dr("jobName"))
            End While
        End If
        cn.Close()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        cn.Open()
        cmd.CommandText = "select distinct gradName from postgraduate order by gradName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                chlb_Grad.Items.Add(dr("gradName"))
            End While
        End If
        cn.Close()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub

    Private Sub loadListBox()


        loadclearCheckbox()

        txt_depat_form2.Clear()

        If departNameEditFlag = False Then
            txt_depat_form2.Text = Edit_Depart.selectDepartEdit
            departNameEditFlag = True
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_depat_form2.AutoCompleteCustomSource.Clear()
        txt_depat_form2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_depat_form2.AutoCompleteSource = AutoCompleteSource.CustomSource

        cn.Open()
        cmd.CommandText = "select distinct dName from department order by dName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txt_depat_form2.AutoCompleteCustomSource.Add(dr("dName"))
            End While
        End If
        cn.Close()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto



        txt_dID.Clear()
        txt_rID.Clear()

        loadAll()


        cn.Open()
        cmd.CommandText = "select dID from department where dName='" & txt_depat_form2.Text & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txt_dID.Text = dr("dID")
            End While
        End If
        cn.Close()

        loadDefaultAll()


    End Sub

    Private Sub loadGrad()
        txt_gradID.Clear()

        txt_Grad.Clear()

        ListBoxGrad.Items.Clear()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_Grad.AutoCompleteCustomSource.Clear()
        txt_Grad.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_Grad.AutoCompleteSource = AutoCompleteSource.CustomSource

        cn.Open()
        cmd.CommandText = "select distinct gradName from postgraduate order by gradName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txt_Grad.AutoCompleteCustomSource.Add(dr("gradName"))
            End While
        End If
        cn.Close()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        cn.Open()
        cmd.CommandText = "select gradName from postgraduate inner join department_postgraduate on postgraduate.gradID=department_postgraduate.gradID inner join department on department.dID=department_postgraduate.dID where dName='" & txt_depat_form2.Text & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxGrad.Items.Add(dr("gradName"))
            End While
        End If
        cn.Close()
    End Sub

    Private Sub loadJob()
        txt_jobID.Clear()

        txt_Job.Clear()

        ListBoxJob.Items.Clear()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_Job.AutoCompleteCustomSource.Clear()
        txt_Job.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_Job.AutoCompleteSource = AutoCompleteSource.CustomSource

        cn.Open()
        cmd.CommandText = "select distinct jobName from profession_job order by jobName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txt_Job.AutoCompleteCustomSource.Add(dr("jobName"))
            End While
        End If
        cn.Close()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        cn.Open()
        cmd.CommandText = "select jobName from profession_job inner join department_profession_job on profession_job.jobID=department_profession_job.jobID inner join department on department.dID=department_profession_job.dID where dName='" & txt_depat_form2.Text & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxJob.Items.Add(dr("jobName"))
            End While
        End If
        cn.Close()
    End Sub

    Private Sub loadPlace()
        txt_placeID.Clear()

        txt_Place.Clear()

        ListBoxPlace.Items.Clear()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_Place.AutoCompleteCustomSource.Clear()
        txt_Place.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_Place.AutoCompleteSource = AutoCompleteSource.CustomSource

        cn.Open()
        cmd.CommandText = "select distinct plName from indicative_employment_places order by plName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txt_Place.AutoCompleteCustomSource.Add(dr("plName"))
            End While
        End If
        cn.Close()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        cn.Open()
        cmd.CommandText = "select plName from indicative_employment_places inner join department_indicative_employment_places on indicative_employment_places.plID=department_indicative_employment_places.plID inner join department on department.dID=department_indicative_employment_places.dID where dName='" & txt_depat_form2.Text & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxPlace.Items.Add(dr("plName"))
            End While
        End If
        cn.Close()
    End Sub

    Private Sub loadExtra()
        txt_extraID.Clear()

        txt_Extra.Clear()

        ListBoxExtra.Items.Clear()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_Extra.AutoCompleteCustomSource.Clear()
        txt_Extra.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_Extra.AutoCompleteSource = AutoCompleteSource.CustomSource

        cn.Open()
        cmd.CommandText = "select distinct extraName from extra_courses order by extraName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txt_Extra.AutoCompleteCustomSource.Add(dr("extraName"))
            End While
        End If
        cn.Close()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        cn.Open()
        cmd.CommandText = "select extraName from extra_courses inner join department_extra_courses on extra_courses.extraID=department_extra_courses.extraID inner join department on department.dID=department_extra_courses.dID where dName='" & txt_depat_form2.Text & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxExtra.Items.Add(dr("extraName"))
            End While
        End If
        cn.Close()
    End Sub

    Private Sub loadPedia()

        txt_scienID.Clear()

        txt_pedia.Clear()

        ListBoxPedia.Items.Clear()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_pedia.AutoCompleteCustomSource.Clear()
        txt_pedia.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_pedia.AutoCompleteSource = AutoCompleteSource.CustomSource

        cn.Open()
        cmd.CommandText = "select distinct scienName from scientific_field order by scienName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txt_pedia.AutoCompleteCustomSource.Add(dr("scienName"))
            End While
        End If
        cn.Close()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        cn.Open()
        cmd.CommandText = "select scienName from scientific_field inner join department_scientific_field on scientific_field.scienID=department_scientific_field.scienID inner join department on department.dID=department_scientific_field.dID where dName='" & txt_depat_form2.Text & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxPedia.Items.Add(dr("scienName"))
            End While
        End If
        cn.Close()



    End Sub

    Private Sub loadListBoxYear()
        txt_Base.Clear()
        txt_Year.Clear()
        ListBoxYear.Items.Clear()

        cn.Open()
        cmd.CommandText = "select distinct bYear from base order by bYear" 'inner join department on department.dID=base.dID where dName= & txt_depat_form2.Text & 
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxYear.Items.Add(dr("bYear"))
            End While
        End If
        cn.Close()
    End Sub
    Private Sub loadListBoxRight()
        '''''''''''''''''''''''''''''''''''''''''
        txt_Right.Clear()
        cn.Open()
        cmd.CommandText = "Select distinct rName from professional_rightsNote inner join department_professional_rightsNote On department_professional_rightsNote.rID=professional_rightsNote.rID inner join department On department_professional_rightsNote.dID=department.dID where dName='" & txt_depat_form2.Text & "'"

        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txt_Right.Text = dr("rName")
            End While
        End If
        cn.Close()
        ''''''''''''''''''''''''''''''''''''''''
    End Sub
    Private Sub loadListBoxDkateuthinsi()
        '''''''''''''''''''''''''''''''''''''''''''
        txt_Kat.Clear()

        ListBoxD.Items.Clear()

        cn.Open()
        cmd.CommandText = "Select directionName from direction inner join department on direction.dID=department.dID where dName='" & txt_depat_form2.Text & "'"

        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                ListBoxD.Items.Add(dr("directionName"))
            End While
        End If
        cn.Close()
        ''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub btn_UpRight_Click(sender As Object, e As EventArgs) Handles btn_UpRight.Click
        If txt_Right.Text <> " " Then

            cn.Open()
            cmd.CommandText = "select professional_rightsNote.rID from professional_rightsNote inner join department_professional_rightsNote On department_professional_rightsNote.rID=professional_rightsNote.rID inner join department On department_professional_rightsNote.dID=department.dID where dName='" & txt_depat_form2.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_rID.Text = dr("rID")
                End While
            End If
            cn.Close()

            cn.Open()

            cmd.CommandText = "Update professional_rightsNote set rName='" & txt_Right.Text & "' where rID='" & txt_rID.Text & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBoxRight()

        End If
    End Sub

    Private Sub btn_inRight_Click(sender As Object, e As EventArgs) Handles btn_inRight.Click
        If txt_Right.Text <> " " Then

            txt_rID.Clear()

            cn.Open()
            cmd.CommandText = "insert into professional_rightsNote (rName) values ('" & txt_Right.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            cn.Open()
            cmd.CommandText = "select rID from professional_rightsNote where rName='" & txt_Right.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_rID.Text = dr("rID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert department_professional_rightsNote (dID,rID) values ('" & txt_dID.Text & "','" & txt_rID.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            loadListBoxRight()

        End If
    End Sub

    Private Sub ListBoxD_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxD.MouseClick
        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxD.SelectedIndex = lb.SelectedIndex

            txt_Kat.Text = ListBoxD.SelectedItem


        End If
    End Sub

    Private Sub btn_upD_Click(sender As Object, e As EventArgs) Handles btn_upD.Click
        If txt_Kat.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update direction set directionName='" & txt_Kat.Text & "'where directionName ='" & ListBoxD.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBoxDkateuthinsi()

        End If
    End Sub

    Private Sub btn_inD_Click(sender As Object, e As EventArgs) Handles btn_inD.Click

        If txt_Kat.Text <> " " Then

            cn.Open()

            cmd.CommandText = "insert into direction (directionName,dID) values ('" & txt_Kat.Text & "','" & txt_dID.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBoxDkateuthinsi()

        End If
    End Sub

    Private Sub ListBoxYear_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxYear.MouseClick
        Dim lb As ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then

            ListBoxYear.SelectedIndex = lb.SelectedIndex

            txt_Year.Text = ListBoxYear.SelectedItem

            txt_Base.Clear()

            cn.Open()
            cmd.CommandText = "select bNum from base inner join department on department.dID=base.dID where dName='" & txt_depat_form2.Text & "' and bYear='" & txt_Year.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_Base.Text = dr("bNum")
                End While
            End If
            cn.Close()

        End If
    End Sub


    Private Sub btn_UpBase_Click(sender As Object, e As EventArgs) Handles btn_UpBase.Click
        If txt_Base.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update base set bNum='" & txt_Base.Text & "'where bYear='" & txt_Year.Text & "' and dID='" & txt_dID.Text & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBoxYear()

        End If
    End Sub

    Private Sub btn_inBase_Click(sender As Object, e As EventArgs) Handles btn_inBase.Click

        If txt_Base.Text <> " " And txt_Year.Text <> " " And txt_dID.Text <> " " Then

            cn.Open()

            cmd.CommandText = "insert into base (bYear,bNum,dID) values ('" & txt_Year.Text & "','" & txt_Base.Text & "','" & txt_dID.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            loadListBoxYear()

        End If
    End Sub

    Private Sub btn_edit_back_Click(sender As Object, e As EventArgs) Handles btn_edit_back.Click
        Me.Close()

        Edit_Depart.Show()
    End Sub

    Private Sub btn_Ok_pedia_Click(sender As Object, e As EventArgs) Handles btn_Ok_pedia.Click
        If txt_pedia.Text <> " " Then

            txt_scienID.Clear()


            cn.Open()
            cmd.CommandText = "select scienID from scientific_field where scienName='" & txt_pedia.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_scienID.Text = dr("scienID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert department_scientific_field (dID,scienID) values ('" & txt_dID.Text & "','" & txt_scienID.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            loadPedia()

        End If
    End Sub

    Private Sub btn_inGrad_Click(sender As Object, e As EventArgs) Handles btn_inGrad.Click
        If txt_Grad.Text <> " " Then

            txt_gradID.Clear()


            cn.Open()
            cmd.CommandText = "select gradID from postgraduate where gradName='" & txt_Grad.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_gradID.Text = dr("gradID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert department_postgraduate (dID,gradID) values ('" & txt_dID.Text & "','" & txt_gradID.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            loadGrad()

        End If
    End Sub

    Private Sub btn_inPlace_Click(sender As Object, e As EventArgs) Handles btn_inPlace.Click
        If txt_Place.Text <> " " Then

            txt_placeID.Clear()


            cn.Open()
            cmd.CommandText = "select plID from indicative_employment_places where plName='" & txt_Place.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_placeID.Text = dr("plID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert department_indicative_employment_places (dID,plID) values ('" & txt_dID.Text & "','" & txt_placeID.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            loadPlace()

        End If
    End Sub

    Private Sub btn_inJob_Click(sender As Object, e As EventArgs) Handles btn_inJob.Click
        If txt_Job.Text <> " " Then

            txt_jobID.Clear()


            cn.Open()
            cmd.CommandText = "select jobID from profession_job where jobName='" & txt_Job.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_jobID.Text = dr("jobID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert department_profession_job (dID,jobID) values ('" & txt_dID.Text & "','" & txt_jobID.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            loadJob()

        End If
    End Sub

    Private Sub btn_inExtra_Click(sender As Object, e As EventArgs) Handles btn_inExtra.Click
        If txt_Extra.Text <> " " Then

            txt_extraID.Clear()


            cn.Open()
            cmd.CommandText = "select extraID from extra_courses where extraName='" & txt_Extra.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_extraID.Text = dr("extraID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert department_extra_courses (dID,extraID) values ('" & txt_dID.Text & "','" & txt_extraID.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            loadExtra()

        End If
    End Sub

    Private Sub chlb_pedia_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chlb_pedia.ItemCheck

        Dim item As String = chlb_pedia.SelectedItem

        If e.NewValue = CheckState.Checked Then
            txt_scienID.Clear()

            cn.Open()
            cmd.CommandText = "select scienID from scientific_field where scienName='" & item & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_scienID.Text = dr("scienID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert department_scientific_field (dID,scienID) values ('" & txt_dID.Text & "','" & txt_scienID.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            loadPedia()

        End If

    End Sub


    Private Sub chlb_Grad_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chlb_Grad.ItemCheck
        Dim item As String = chlb_Grad.SelectedItem

        If e.NewValue = CheckState.Checked Then
            txt_gradID.Clear()

            cn.Open()
            cmd.CommandText = "select gradID from postgraduate where gradName='" & item & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_gradID.Text = dr("gradID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert department_postgraduate (dID,gradID) values ('" & txt_dID.Text & "','" & txt_gradID.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            loadGrad()

        End If
    End Sub

    Private Sub chlb_Place_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chlb_Place.ItemCheck
        Dim item As String = chlb_Place.SelectedItem

        If e.NewValue = CheckState.Checked Then
            txt_placeID.Clear()

            cn.Open()
            cmd.CommandText = "select plID from indicative_employment_places where plName='" & item & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_placeID.Text = dr("plID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert department_indicative_employment_places (dID,plID) values ('" & txt_dID.Text & "','" & txt_placeID.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            loadPlace()

        End If
    End Sub

    Private Sub chlb_Job_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chlb_Job.ItemCheck
        Dim item As String = chlb_Job.SelectedItem

        If e.NewValue = CheckState.Checked Then
            txt_jobID.Clear()

            cn.Open()
            cmd.CommandText = "select jobID from profession_job where jobName='" & item & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_jobID.Text = dr("jobID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert department_profession_job (dID,jobID) values ('" & txt_dID.Text & "','" & txt_jobID.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            loadJob()

        End If
    End Sub

    Private Sub chlb_Extra_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chlb_Extra.ItemCheck
        Dim item As String = chlb_Extra.SelectedItem

        If e.NewValue = CheckState.Checked Then
            txt_extraID.Clear()

            cn.Open()
            cmd.CommandText = "select extraID from extra_courses where extraName='" & item & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_extraID.Text = dr("extraID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert department_extra_courses (dID,extraID) values ('" & txt_dID.Text & "','" & txt_extraID.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()

            loadExtra()

        End If
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        loadAll()


        txt_rID.Clear()
        txt_dID.Clear()

        loadclearCheckbox()
        loadDefaultAll()


        cn.Open()
        cmd.CommandText = "select dID from department where dName='" & txt_depat_form2.Text & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txt_dID.Text = dr("dID")
            End While
        End If
        cn.Close()

    End Sub


End Class