﻿#ExternalChecksum("D:\l505gs\win p 7.5 SDK\SpeedConnect\SpeedConnect\browser.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","E0DB8965EA4E367BFA0CBF93211788C9")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34003
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Shell
Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class browser
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents FeedBrowser As Microsoft.Phone.Controls.WebBrowser
    
    Friend WithEvents BrowserProgressBar As System.Windows.Controls.ProgressBar
    
    Friend WithEvents browserAppBar As Microsoft.Phone.Shell.ApplicationBar
    
    Friend WithEvents newTaskAppBarButton As Microsoft.Phone.Shell.ApplicationBarIconButton
    
    Friend WithEvents btnShare As Microsoft.Phone.Shell.ApplicationBarIconButton
    
    Friend WithEvents btnArabic As Microsoft.Phone.Shell.ApplicationBarIconButton
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        System.Windows.Application.LoadComponent(Me, New System.Uri("/SpeedConnect;component/browser.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.FeedBrowser = CType(Me.FindName("FeedBrowser"),Microsoft.Phone.Controls.WebBrowser)
        Me.BrowserProgressBar = CType(Me.FindName("BrowserProgressBar"),System.Windows.Controls.ProgressBar)
        Me.browserAppBar = CType(Me.FindName("browserAppBar"),Microsoft.Phone.Shell.ApplicationBar)
        Me.newTaskAppBarButton = CType(Me.FindName("newTaskAppBarButton"),Microsoft.Phone.Shell.ApplicationBarIconButton)
        Me.btnShare = CType(Me.FindName("btnShare"),Microsoft.Phone.Shell.ApplicationBarIconButton)
        Me.btnArabic = CType(Me.FindName("btnArabic"),Microsoft.Phone.Shell.ApplicationBarIconButton)
    End Sub
End Class

