Imports System.Data.SqlClient

Public Class Edit_Base

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader


    Public Shared bol As Boolean


    Public Shared YearEdit As String = "2016"


    Private Sub Edit_Base_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd.Connection = cn

        loadListBox()


    End Sub

    Private Sub loadListBox()

        txt_depart.Clear()
        txt_dID.Clear()



        txt_Year.Clear()
        txt_Year.Text = YearEdit



        ListBoxDepartment.Items.Clear()
        ListBoxNum.Items.Clear()




        cn.Open()

        cmd.CommandText = "select dName from department order by dName"

        'δρομέας,o data reader// εκτελει το command
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                ListBoxDepartment.Items.Add(dr("dName"))

            End While
        End If

        cn.Close()

        cn.Open()

        cmd.CommandText = "select bNum from department left outer join base on department.dID=base.dID where bYear='" & YearEdit & "' order by dName"

        'δρομέας,o data reader// εκτελει το command
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                ListBoxNum.Items.Add(dr("bNum"))

            End While
        End If

        cn.Close()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_depart.AutoCompleteCustomSource.Clear()
        txt_depart.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_depart.AutoCompleteSource = AutoCompleteSource.CustomSource

        cn.Open()
        cmd.CommandText = "select distinct dName from department order by dName"
        dr = cmd.ExecuteReader()
        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
            While (dr.Read())
                txt_depart.AutoCompleteCustomSource.Add(dr("dName"))
            End While
        End If
        cn.Close()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto

    End Sub

    Private Sub btnEndEditBase_Click(sender As Object, e As EventArgs) Handles btnEndEditBase.Click
        Me.Close()
        Admin.Show()
    End Sub

    Private Sub ListBoxDepartment_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxDepartment.MouseClick, ListBoxNum.MouseClick



        Dim size As Integer = ListBoxDepartment.Items.Count()  'Subtract 1 here instead of in the For statement


        Dim size2 As Integer = ListBoxNum.Items.Count()  'Subtract 1 here instead of in the For statement


        'MessageBox.Show("total: " + size.ToString + "," + size2.ToString)

        If size = size2 Then
            Dim lb As ListBox

            lb = sender

            If lb.SelectedIndex <> -1 Then

                ListBoxDepartment.SelectedIndex = lb.SelectedIndex
                ListBoxNum.SelectedIndex = lb.SelectedIndex ''''''''''''''''''''''''''''''''''''''''''''''''????????????????????????????
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


                txt_depart.Text = ListBoxDepartment.SelectedItem
                txt_Num.Text = ListBoxNum.SelectedItem

                txt_dID.Clear()

                cn.Open()

                cmd.CommandText = "select dID from department where dName='" & txt_depart.Text & "' order by dName"

                'δρομέας,o data reader// εκτελει το command
                dr = cmd.ExecuteReader()

                If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

                    While (dr.Read())

                        txt_dID.Text = dr("dID")

                    End While
                End If

                cn.Close()

            End If

        Else
            MessageBox.Show("Δεν μπορείς να δεις τα μόρια του τμήματος,δεν έχουν περαστεί ακόμα")
        End If
        '''''''''''''''''''''''''


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txt_depart.Text <> " " And txt_Num.Text <> " " Then

            cn.Open()

            cmd.CommandText = "Update base set bNum='" & txt_Num.Text & "' where bNum ='" & ListBoxNum.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            cn.Close()

            txt_Num.Clear()
            txt_depart.Clear()
            txt_dID.Clear()

            loadListBox()

        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        YearEdit = txt_Year.Text
        txt_Num.Clear()
        loadListBox()
    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If txt_depart.Text <> " " And txt_Num.Text <> " " And txt_Year.Text <> " " Then

            cn.Open()
            cmd.CommandText = "select dID from department where dName='" & txt_depart.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα
                While (dr.Read())
                    txt_dID.Text = dr("dID")
                End While
            End If
            cn.Close()

            cn.Open()
            cmd.CommandText = "insert into base (bNum,bYear,dID) values ('" & txt_Num.Text & "', '" & txt_Year.Text & "' , '" & txt_dID.Text & "')"

            cmd.ExecuteNonQuery()

            cn.Close()

            txt_Num.Clear()
            txt_depart.Clear()
            txt_Year.Clear()

            loadListBox()

        End If
    End Sub






    Private Sub btm_ok_Click(ByVal sender As Object, ByVal e As EventArgs)

        bol = True 'need for ok,when fill the all number of moria


    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click

        If txt_depart.Text <> " " And txt_Num.Text <> " " Then

            cn.Open()

            cmd.CommandText = "delete from base where bNum='" & txt_Num.Text & "'"

            cmd.ExecuteNonQuery()

            cn.Close()

            txt_Num.Clear()
            txt_depart.Clear()
            txt_dID.Clear()

            loadListBox()

        End If

    End Sub

End Class


'Private Sub btn_InsertAll_Click(sender As Object, e As EventArgs)




'    For i = 0 To ListBoxDepartment.Items.Count - 1

'        bol = False

'        txt_depart2.Text = ListBoxDepartment.Items(i)

'        cn.Open()

'        cmd.CommandText = "select dID from department where dName='" & txt_depart2.Text & "' order by dName"

'        'δρομέας,o data reader// εκτελει το command
'        dr = cmd.ExecuteReader()

'        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

'            While (dr.Read())

'                txt_dID2.Text = dr("dID")

'            End While
'        End If

'        cn.Close()


'        While bol = False

'            Application.DoEvents()

'        End While


'        If txt_depart2.Text <> " " And txt_Moria2.Text <> " " And txt_Year.Text <> " " Then

'            cn.Open()


'            cmd.CommandText = "insert into base (bNum,bYear,dID) values ('" & txt_Moria2.Text & "', '" & txt_Year.Text & "' , '" & txt_dID2.Text & "')"

'            cmd.ExecuteNonQuery()

'            cn.Close()

'            txt_Moria2.Clear()
'            txt_depart2.Clear()
'            txt_Year.Clear()

'            loadListBox()

'        End If


'    Next

'End Sub