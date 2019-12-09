Imports System.Data.SqlClient

Public Class Form1

    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p315mitroo;User ID=p315mitroo;Password=pass123456789")
    Dim cmd As New SqlCommand
    Public Shared dr As SqlDataReader

    Public Shared nextForm As Boolean = False

    Public Shared selectDepart6 As String


    Private Sub bLogIn_Click(sender As Object, e As EventArgs) Handles bLogIn.Click

        If txtLoginUsername.Text = "p3150092" Then

            'καθαρίζει κωδικού για να μην φαίνεται
            txtLoginUsername.Clear()

            'νεο παράθυρο
            Admin.Show()

            'ηχιτικο μηνυμα επιβαιβεωσης
            Dim SAPI2
            SAPI2 = CreateObject("SAPI.spvoice")
            SAPI2.Speak("welcome admin")

        Else

            'voice,όταν κάνεις λάθος τον κωδικό
            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.Speak("Wrong Password")

            'καθαρίζει το λανθασμέωο κωδικό
            txtLoginUsername.Clear()

            MessageBox.Show("Wrong Password!")

            'voice,όταν κάνεις λάθος τον κωδικό
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.Speak("Please,try again")

        End If

    End Sub

    Private Sub btnInfoByJob_Click(sender As Object, e As EventArgs) Handles btnInfoByJob.Click

        Info_by_Jobs.Show()

    End Sub

    Private Sub btn_Info_Job_Click(sender As Object, e As EventArgs) Handles btn_Info_Job.Click

        Info_by_City.Show()

    End Sub

    Private Sub btn_Info_Scien_Click(sender As Object, e As EventArgs) Handles btn_Info_Scien.Click

        Info_by_Scien.Show()

    End Sub

    Private Sub btn_Info_University_Click(sender As Object, e As EventArgs) Handles btn_Info_University.Click
        Info_by_University.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto
        'Clear current autocomplete list
        txt_SearchAll.AutoCompleteCustomSource.Clear()

        txt_SearchAll.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_SearchAll.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Loop through each listbox item and add it to the Autocomplete source

        cmd.Connection = cn
        cn.Open()

        cmd.CommandText = "select distinct dName from department order by dName"

        'δρομέας,o data reader// εκτελει το command
        dr = cmd.ExecuteReader()

        If dr.HasRows Then 'αν υπηρχει κατι,γιατι μπορεί να μην υπήρχε τίποτα

            While (dr.Read())

                txt_SearchAll.AutoCompleteCustomSource.Add(dr("dName"))

            End While

        End If

        'κλείνουμε το connection
        cn.Close()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''auto

    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        nextForm = True
        selectDepart6 = txt_SearchAll.Text
        txt_SearchAll.Clear()
        DepartmentInfo.Show()

    End Sub


End Class
