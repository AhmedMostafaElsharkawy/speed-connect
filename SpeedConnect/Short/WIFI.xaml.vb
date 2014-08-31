Imports Microsoft.Phone.Tasks

Partial Public Class WIFI
    Inherits PhoneApplicationPage

    Public Sub New()

        Dim task As New ConnectionSettingsTask
        task.ConnectionSettingsType = ConnectionSettingsType.WiFi
        task.Show()
        Throw New Exception
    End Sub
End Class
