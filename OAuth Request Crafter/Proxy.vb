Public Class SetProxy

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jnk As Integer
        If address.Text = "" Or port.Text = "" Or Not Int32.TryParse(port.Text, jnk) Then
            MsgBox("Invalid Address or Port", vbCritical)
        Else

            My.Settings.paddress = address.Text '
            My.Settings.pport = port.Text
            My.Settings.pusername = username.Text
            My.Settings.ppassword = password.Text
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub SetProxy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        address.Text = My.Settings.paddress
        port.Text = My.Settings.pport
        username.Text = My.Settings.pusername
        password.Text = My.Settings.ppassword
    End Sub
End Class