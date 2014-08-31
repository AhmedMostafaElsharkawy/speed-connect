Partial Public Class Contact
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
        Dim task As New Microsoft.Phone.Tasks.SaveContactTask
        task.Show()
        Throw New Exception
    End Sub
End Class
