
Partial Public Class Cel
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
        Dim task As New Microsoft.Phone.Tasks.ConnectionSettingsTask
        task.ConnectionSettingsType = Microsoft.Phone.Tasks.ConnectionSettingsType.Cellular
        task.Show()
        Throw New Exception
    End Sub
End Class
