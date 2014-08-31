Partial Public Class Air
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
        Dim task As New Microsoft.Phone.Tasks.ConnectionSettingsTask
        task.ConnectionSettingsType = Microsoft.Phone.Tasks.ConnectionSettingsType.AirplaneMode
        task.Show()
        Throw New Exception
    End Sub
End Class
