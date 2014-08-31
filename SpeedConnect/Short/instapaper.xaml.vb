Partial Public Class instapaper
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub
    Dim ReadUrl As String = "http://www.instapaper.com/text?u="
    Private Sub btnRead_Click(sender As Object, e As EventArgs)
        If txtUrl.Text.Trim = "" Then
            MessageBox.Show("Enter web page Url To read it .", "Attention", MessageBoxButton.OK)
            Exit Sub
        End If
        If Not txtUrl.Text.StartsWith("http://") Then txtUrl.Text = "http://" & txtUrl.Text
        uri = New System.Uri(ReadUrl & txtUrl.Text, UriKind.Absolute)
        NavigationService.Navigate(New Uri("/Short/browser.xaml", UriKind.Relative))
    End Sub
    Private Sub btnNewUrl_Click(sender As Object, e As RoutedEventArgs)
        txtUrl.Text = ""
    End Sub
End Class
