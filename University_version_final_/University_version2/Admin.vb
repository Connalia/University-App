'Imports System.Data.SqlClient

Public Class Admin

    Private Sub btnEditBase_Click(sender As Object, e As EventArgs) Handles btnEditBase.Click
        Me.Close()

        Edit_Base.Show()
    End Sub

    Private Sub bVariety_Click(sender As Object, e As EventArgs) Handles bVariety.Click
        Me.Close()

        Edit_Variety.Show()
    End Sub

    Private Sub btnUnivers_Click(sender As Object, e As EventArgs) Handles btnUnivers.Click
        Me.Close()

        Edit_University.Show()
    End Sub

    Private Sub btnScien_Click(sender As Object, e As EventArgs) Handles btnScien.Click
        Me.Close()

        Edit_Scien.Show()
    End Sub

    Private Sub btnExtra_Click(sender As Object, e As EventArgs) Handles btnExtra.Click
        Me.Close()

        Edit_Extra.Show()
    End Sub

    Private Sub btnJobs_Click(sender As Object, e As EventArgs) Handles btnJobs.Click
        Me.Close()

        Edit_Job.Show()
    End Sub

    Private Sub btnPlace_Click(sender As Object, e As EventArgs) Handles btnPlace.Click
        Me.Close()

        Edit_Place.Show()
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        Me.Close()

        Edit_Grad.Show()
    End Sub

    Private Sub btnDepart_Click(sender As Object, e As EventArgs) Handles btnDepart.Click
        Me.Close()

        Edit_Depart.Show()
    End Sub
End Class