Imports Microsoft.Phone.Tasks
Imports Microsoft.Phone.Info

Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

#Region "short"
  
    Private Sub Blue_Click(sender As Object, e As System.Windows.Input.GestureEventArgs)
        Try
            Dim NewTileData As StandardTileData = New StandardTileData With {.Title = "Bluetooth", .BackgroundImage = New Uri("/Icon/Bluetooth.png", UriKind.Relative)}
            ShellTile.Create(New Uri("/Short/Blue.xaml", UriKind.Relative), NewTileData)

        Catch
            Mesg()
        End Try
    End Sub
    Private Sub Air_Click(sender As Object, e As System.Windows.Input.GestureEventArgs)
        Try
            Dim NewTileData As StandardTileData = New StandardTileData With {.Title = "Air Plane", .BackgroundImage = New Uri("/Icon/Airplane.png", UriKind.Relative)}
            ShellTile.Create(New Uri("/Short/Air.xaml", UriKind.Relative), NewTileData)

        Catch
            Mesg()
        End Try
    End Sub
    Private Sub WiFi_Click(sender As Object, e As System.Windows.Input.GestureEventArgs)
        Try
            Dim NewTileData As StandardTileData = New StandardTileData With {.Title = "WiFi", .BackgroundImage = New Uri("/Icon/WiFi.png", UriKind.Relative)}

            ShellTile.Create(New Uri("/Short/WIFI.xaml", UriKind.Relative), NewTileData)

        Catch
            Mesg()
        End Try
    End Sub
    Private Sub Cel_Click(sender As Object, e As System.Windows.Input.GestureEventArgs)
        Try
            Dim NewTileData As StandardTileData = New StandardTileData With {.BackTitle = "Cellular", .Title = "Cellular", .BackgroundImage = New Uri("/Icon/Cellular.png", UriKind.Relative)}

            ShellTile.Create(New Uri("/Short/Cel.xaml", UriKind.Relative), NewTileData)
        Catch
            Mesg()
        End Try
    End Sub
  
  
#End Region
  

   
    Private Sub btnAbout_Click_1(sender As Object, e As EventArgs)
        Try
            Dim webBrowserTask As WebBrowserTask = New WebBrowserTask()
            webBrowserTask.Uri = New Uri("https://www.facebook.com/ideasSoftware", UriKind.Absolute)
            webBrowserTask.Show()

        Catch ex As Exception

        End Try
    End Sub

  


    Private Sub btn_Write(sender As Object, e As Input.GestureEventArgs)
        Try
            Dim NewTileData As StandardTileData = New StandardTileData With {.BackTitle = "Write", .Title = "Write", .BackgroundImage = New Uri("/Icon/Editor.png", UriKind.Relative)}

            ShellTile.Create(New Uri("/Short/Sms.xaml", UriKind.Relative), NewTileData)
        Catch
            Mesg()
        End Try
    End Sub

    Private Sub btnContact(sender As Object, e As Input.GestureEventArgs)
        Try
            Dim NewTileData As StandardTileData = New StandardTileData With {.BackTitle = "Add Contact", .Title = "Add Contact", .BackgroundImage = New Uri("/Icon/book.contact.png", UriKind.Relative)}

            ShellTile.Create(New Uri("/Short/Contact.xaml", UriKind.Relative), NewTileData)
        Catch
            Mesg()
        End Try
    End Sub

    

    Private Sub Readability_Click(sender As Object, e As Input.GestureEventArgs)
        Try
            Dim NewTileData As StandardTileData = New StandardTileData With {.BackTitle = "Readability", .Title = "Readability", .BackgroundImage = New Uri("/Icon/readability-256.png", UriKind.Relative)}

            ShellTile.Create(New Uri("/Short/WebReader.xaml", UriKind.Relative), NewTileData)
        Catch
            Mesg()
        End Try
    End Sub

    Sub Mesg()
        MessageBox.Show("This tile is already present on your start screen.", "Attention", MessageBoxButton.OK)
    End Sub

    Private Sub instapaper_Click(sender As Object, e As Input.GestureEventArgs)
        Try
            Dim NewTileData As StandardTileData = New StandardTileData With {.BackTitle = "Instapaper", .Title = "Instapaper", .BackgroundImage = New Uri("/Icon/Student-Read-01.png", UriKind.Relative)}

            ShellTile.Create(New Uri("/Short/instapaper.xaml", UriKind.Relative), NewTileData)
        Catch
            Mesg()
        End Try
    End Sub


End Class
