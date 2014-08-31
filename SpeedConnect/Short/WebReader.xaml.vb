Partial Public Class WebReader
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub
    Dim ReadUrl As String = "http://readability.com/read?url="
    Private Sub btnRead_Click(sender As Object, e As EventArgs)
        If txtUrl.Text.Trim = "" Then
            MessageBox.Show("Enter web page Url To read it .", "Attention", MessageBoxButton.OK)
            Exit Sub
        End If
        If Not txtUrl.Text.StartsWith("http://") Then txtUrl.Text = "http://" & txtUrl.Text
        uri = New System.Uri(ReadUrl & txtUrl.Text, UriKind.Absolute)
        NavigationService.Navigate(New Uri("/Short/browser.xaml", UriKind.Relative))
    End Sub
    Dim SaveUrl As String = "http://readability.com/save?url="

    Private Sub btnSaveToRead_Click(sender As Object, e As EventArgs)
        If txtUrl.Text.Trim = "" Then
            MessageBox.Show("Enter web page Url To Save it .", "Attention", MessageBoxButton.OK)
            Exit Sub
        End If
        If Not txtUrl.Text.StartsWith("http://") Then txtUrl.Text = "http://" & txtUrl.Text
        uri = New System.Uri(SaveUrl & txtUrl.Text, UriKind.Absolute)
        NavigationService.Navigate(New Uri("/Short/browser.xaml", UriKind.Relative))
    End Sub

    Private Sub btnTop_Click(sender As Object, e As EventArgs)

        uri = New System.Uri("http://www.readability.com/topreads/", UriKind.Absolute)
        NavigationService.Navigate(New Uri("/Short/browser.xaml", UriKind.Relative))
    End Sub
    Private Sub btnNewUrl_Click(sender As Object, e As RoutedEventArgs)
        txtUrl.Text = ""
    End Sub
End Class
