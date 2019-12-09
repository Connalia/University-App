Public Class WebBrowser


    Private Sub btnViewSiteURL_Click(sender As Object, e As EventArgs) Handles btnViewSiteURL.Click

        WebBrowser1.Navigate(txt_URL.Text)

    End Sub

    Private Sub WebBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadBrowser()

    End Sub

    Private Sub loadBrowser()
        txt_URL.Clear()
        txt_URL.Text = DepartmentInfo.selectLink
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        WebBrowser1.GoBack()

    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click

        WebBrowser1.GoForward()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        WebBrowser1.Refresh()

    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated

        txt_URL.Text = WebBrowser1.Url.ToString

    End Sub
End Class