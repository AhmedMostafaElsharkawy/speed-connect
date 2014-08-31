'
'   Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
'   Use of this sample source code is subject to the terms of the Microsoft license 
'   agreement under which you licensed this sample source code and is provided AS-IS.
'   If you did not accept the terms of the license agreement, you are not authorized 
'   to use this sample source code.  For the terms of the license, please see the 
'   license agreement between you and Microsoft.
'  
'   To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
'  
'
Imports Microsoft.Phone.Tasks
Imports System.IO
Imports System.Text.RegularExpressions

Partial Public Class browser
    Inherits PhoneApplicationPage
    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub browser_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Try

            BrowserProgressBar.Visibility = Windows.Visibility.Visible
            FeedBrowser.Navigate(uri)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub newTaskAppBarButton_Click_1(sender As Object, e As EventArgs)
        Try
            If NavigationService.CanGoBack Then
                NavigationService.GoBack()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FeedBrowser_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles FeedBrowser.LoadCompleted
        BrowserProgressBar.Visibility = Windows.Visibility.Collapsed

    End Sub

    Private Sub btnShare_Click_1(sender As Object, e As EventArgs)
        Dim myShareLansher As New ShareLinkTask
        myShareLansher.LinkUri = uri
        myShareLansher.Show()
    End Sub

  
    Dim site As String
    Private Sub btnArabic_Click_1(sender As Object, e As EventArgs)
        ActiveReadMode()
    End Sub

    Private Sub OnOrientationChanged(sender As Object, e As OrientationChangedEventArgs)
        If (e.Orientation And PageOrientation.Portrait) = (PageOrientation.Portrait) Then
            LayoutRoot.Margin = New Thickness(0, 0, 0, 0)
        ElseIf (e.Orientation And PageOrientation.LandscapeLeft) = (PageOrientation.LandscapeLeft) Then
            LayoutRoot.Margin = New Thickness(0, 0, 35, 0)
        ElseIf (e.Orientation And PageOrientation.LandscapeRight) = (PageOrientation.LandscapeRight) Then
            LayoutRoot.Margin = New Thickness(35, 0, 0, 0)
        End If
    End Sub

    Private Sub FeedBrowser_Navigating(sender As Object, e As NavigatingEventArgs) Handles FeedBrowser.Navigating
        Try
            BrowserProgressBar.Visibility = Windows.Visibility.Visible

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ApplicationBarMenuItemExplorer_Click_2(sender As Object, e As EventArgs)
        Try
            Dim webBrowserTask As WebBrowserTask = New WebBrowserTask()
            webBrowserTask.Uri = New Uri(uri, UriKind.Absolute)
            webBrowserTask.Show()
        Catch ex As Exception
        End Try
    End Sub
    Sub ActiveReadMode()
        FeedBrowser.IsScriptEnabled = True
        BrowserProgressBar.Visibility = Windows.Visibility.Visible
        site = "javascript:(%28function%28%29%7Bwindow.baseUrl%3D%27http%3A//www.readability.com%27%3Bwindow.readabilityToken%3D%27%27%3Bvar%20s%3Ddocument.createElement%28%27script%27%29%3Bs.setAttribute%28%27type%27%2C%27text/javascript%27%29%3Bs.setAttribute%28%27charset%27%2C%27UTF-8%27%29%3Bs.setAttribute%28%27src%27%2CbaseUrl%2B%27/bookmarklet/read.js%27%29%3Bdocument.documentElement.appendChild%28s%29%3B%7D%29%28%29)"
        FeedBrowser.Navigate(New Uri(site, UriKind.Absolute))
    End Sub
  
End Class
Module Core
    Public uri As Uri
End Module