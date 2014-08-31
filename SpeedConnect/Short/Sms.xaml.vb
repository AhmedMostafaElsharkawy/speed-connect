Partial Public Class Sms
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub txtMsg_lostFocus(sender As Object, e As RoutedEventArgs) Handles txtMsg.LostFocus
        txtMsg.BorderBrush = New SolidColorBrush(Colors.LightGray)
    End Sub

    Private Sub btnSendEmail_Click(sender As Object, e As EventArgs)
        Dim task As New Microsoft.Phone.Tasks.EmailComposeTask
        task.Body = txtMsg.Text
        task.Show()
    End Sub

    Private Sub btnSendSms_Click(sender As Object, e As EventArgs)
        Dim task As New Microsoft.Phone.Tasks.SmsComposeTask
        task.Body = txtMsg.Text
        task.Show()
    End Sub

    Private Sub rtl_Checked(sender As Object, e As RoutedEventArgs) Handles rtl.Checked
        txtMsg.TextAlignment = TextAlignment.Right
    End Sub

    Private Sub rtl_Unchecked(sender As Object, e As RoutedEventArgs) Handles rtl.Unchecked
        txtMsg.TextAlignment = TextAlignment.Left
    End Sub
End Class
