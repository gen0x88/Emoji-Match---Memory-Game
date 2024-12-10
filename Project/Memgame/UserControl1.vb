Imports System.Runtime.InteropServices

Public Class UserControl1

    Private muted As Boolean = True

    'introducing a few private valariables for system volume
    Private Const VolumeMute As Integer = &H80000
    Private Const VolumeUp As Integer = &HA0000
    Private Const VolumeDown As Integer = &H90000
    Private Const WMAppcommand As Integer = &H319
    <DllImport("user32.dll")> Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wparam As IntPtr, ByVal lparam As IntPtr) As IntPtr
    End Function


    Private Sub Savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Savebtn.Click

        'when click sive buttton, the control would hide
        Me.Visible = False

    End Sub

    Private Sub Mutebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mutebtn.Click

        'send message to the system volume to mute the volume
        SendMessageW(Me.Handle, WMAppcommand, Me.Handle, New IntPtr(VolumeMute))


        If muted = False Then

            muted = True
            Mutebtn.BackgroundImage = My.Resources.vol_muted

        Else

            muted = False
            Mutebtn.BackgroundImage = My.Resources.vol_up_512

        End If

    End Sub

    Private Sub Volupbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Volupbtn.Click

        'send message to the system volume to turn up sound
        SendMessageW(Me.Handle, WMAppcommand, Me.Handle, New IntPtr(VolumeUp))

    End Sub

    Private Sub Voldownbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Voldownbtn.Click

        'send message to the system volume to turn down sound
        SendMessageW(Me.Handle, WMAppcommand, Me.Handle, New IntPtr(VolumeDown))

    End Sub


End Class
