﻿#ExternalChecksum("D:\l505gs\win p 7.5 SDK\SpeedConnect\SpeedConnect\Short\Sms.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","432972BC2A2135494C44E0735BC10046")
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
Partial Public Class Sms
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents TitlePanel As System.Windows.Controls.StackPanel
    
    Friend WithEvents ApplicationTitle As System.Windows.Controls.TextBlock
    
    Friend WithEvents PageTitle As System.Windows.Controls.TextBlock
    
    Friend WithEvents txtMsg As System.Windows.Controls.TextBox
    
    Friend WithEvents rtl As Microsoft.Phone.Controls.ToggleSwitch
    
    Friend WithEvents btnSend As Microsoft.Phone.Shell.ApplicationBarIconButton
    
    Friend WithEvents btnSendSms As Microsoft.Phone.Shell.ApplicationBarIconButton
    
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
        System.Windows.Application.LoadComponent(Me, New System.Uri("/SpeedConnect;component/Short/Sms.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.TitlePanel = CType(Me.FindName("TitlePanel"),System.Windows.Controls.StackPanel)
        Me.ApplicationTitle = CType(Me.FindName("ApplicationTitle"),System.Windows.Controls.TextBlock)
        Me.PageTitle = CType(Me.FindName("PageTitle"),System.Windows.Controls.TextBlock)
        Me.txtMsg = CType(Me.FindName("txtMsg"),System.Windows.Controls.TextBox)
        Me.rtl = CType(Me.FindName("rtl"),Microsoft.Phone.Controls.ToggleSwitch)
        Me.btnSend = CType(Me.FindName("btnSend"),Microsoft.Phone.Shell.ApplicationBarIconButton)
        Me.btnSendSms = CType(Me.FindName("btnSendSms"),Microsoft.Phone.Shell.ApplicationBarIconButton)
    End Sub
End Class

