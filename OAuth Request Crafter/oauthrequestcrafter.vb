Imports System.Net
Imports System.Threading
Imports System.Globalization
Imports System.Text
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security

Public Class oauthrequestcrafter



    Public flag As Integer
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim html As String = ""

        If urlz.Text = "" Or method.Text = "" Or version.Text = "" Or signaturemethod.Text = "" Or csecret.Text = "" Or ckey.Text = "" Then
            MsgBox("Missing OAuth Fields", vbCritical)
        Else
            If (CheckBox2.Checked = True) Then
                html = oauth_auth_header.Text.Replace("XURL", urlz.Text).Replace("XPARAMS", parameters.Text).Replace("XMETHOD", method.Text).Replace("XVERSION", version.Text).Replace("XSIG_METHOD", signaturemethod.Text).Replace("XCONSUMER_KEY", ckey.Text).Replace("XCONSUMER_SECRET", csecret.Text).Replace("XOTOKEN", token.Text).Replace("XTOKEN_SECRET", tokensecret.Text)
                browserparams.DocumentText = html
                flag = 0
            Else

                html = TextBox1.Text.Replace("XURL", urlz.Text).Replace("XPARAMS", parameters.Text).Replace("XMETHOD", method.Text).Replace("XVERSION", version.Text).Replace("XSIG_METHOD", signaturemethod.Text).Replace("XCONSUMER_KEY", ckey.Text).Replace("XCONSUMER_SECRET", csecret.Text).Replace("XOTOKEN", token.Text).Replace("XTOKEN_SECRET", tokensecret.Text)
                browserparams.DocumentText = html
                flag = 1
            End If
        End If
    End Sub

    Private Sub oauthrequestcrafter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.xmethod = method.Text
        My.Settings.xurl = urlz.Text
        My.Settings.xparams = parameters.Text
        My.Settings.xversion = version.Text
        My.Settings.xck = ckey.Text
        My.Settings.xcs = csecret.Text
        My.Settings.xt = token.Text
        My.Settings.xts = tokensecret.Text
        My.Settings.xsig = signaturemethod.Text
        My.Settings.Save()
    End Sub

    Private Sub oauthrequestcrafter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        method.Text = My.Settings.xmethod
        urlz.Text = My.Settings.xurl
        parameters.Text = My.Settings.xparams
        version.Text = My.Settings.xversion
        ckey.Text = My.Settings.xck
        csecret.Text = My.Settings.xcs
        token.Text = My.Settings.xt
        tokensecret.Text = My.Settings.xts
        signaturemethod.Text = My.Settings.xsig
    End Sub

    Public Shared Function ValidateRemoteCertificate(ByVal sender As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) As Boolean
        Return True
    End Function

   
    Private Sub browserparams_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles browserparams.Navigated
        ServicePointManager.ServerCertificateValidationCallback = AddressOf ValidateRemoteCertificate

        If (e.Url.ToString().Contains("http://")) Then
            Dim oauthparams As String = e.Url.AbsolutePath.Remove(0, 1)

            If (flag = 1) Then
                If (method.Text = "POST") Or (method.Text = "PUT") Then
                    Dim para() = parameters.Text.Split("&")
                    For Each p As String In para
                        oauthparams = oauthparams.Replace("&" + p, "")
                    Next

                End If
            Else
                oauthparams = oauthparams.Replace("%22", """").Replace("%20", " ")
            End If
            '  MsgBox(oauthparams)
            If method.Text.Contains("POST") Or method.Text.Contains("PUT") Then
                responseheaders.Text = ""
                browser.DocumentText = ""
                Try

                    Dim postReq As HttpWebRequest
                    If (flag = 1) Then
                        postReq = DirectCast(WebRequest.Create(urlz.Text + "?" + oauthparams), HttpWebRequest)
                    Else
                        postReq = DirectCast(WebRequest.Create(urlz.Text), HttpWebRequest)
                    End If
                    Dim encoding As New UTF8Encoding
                    Dim postData As String = parameters.Text
                    Dim byteData As Byte() = encoding.GetBytes(postData)
                    Dim tempCookies As New CookieContainer
                    'Proxy support
                    If CheckBox1.Checked = True Then

                        Try
                            Dim myProxy As New WebProxy()
                            Dim newUri As New Uri("http://" & My.Settings.paddress & ":" & My.Settings.pport)
                            myProxy.Address = newUri
                            myProxy.Credentials = New NetworkCredential(My.Settings.pusername, My.Settings.ppassword)
                            postReq.Proxy = myProxy
                        Catch ex As Exception
                            MsgBox(ex.Message.ToString, vbCritical)
                        End Try

                    End If
                    postReq.Method = method.Text
                    If (flag = 0) Then
                        postReq.Headers.Add("Authorization", oauthparams)

                    End If
                    postReq.ContentType = "application/x-www-form-urlencoded; charset=UTF-8"
                    postReq.KeepAlive = True
                    'ADD HEADERS
                    Dim cnt As Integer = 0
                    Dim posSep, hname, hvalue As String
                    While cnt < headers.Items.Count
                        posSep = headers.Items(cnt).IndexOf(":")
                        hname = headers.Items(cnt).Substring(0, posSep)
                        hvalue = headers.Items(cnt).Substring(posSep + 1)
                        If hname.Contains("User-Agent") Then
                            postReq.UserAgent = hvalue
                        ElseIf hname.Contains("Connection") Then
                            postReq.Connection = hvalue
                        ElseIf hname.Contains("Content-Type") Then
                            postReq.ContentType = hvalue
                        ElseIf hname.Equals("Accept") Then
                            postReq.Accept = hvalue
                        ElseIf hname.Contains("Referer") Then
                            postReq.Referer = hvalue
                        ElseIf hname.Contains("Expect") Then
                            postReq.Expect = hvalue
                        Else
                            postReq.Headers.Add(hname, hvalue)
                        End If
                        cnt = cnt + 1
                    End While
                    'Cookie
                    For Each cok As String In cookies.Items
                        posSep = cok.IndexOf(":")
                        hname = cok.Substring(0, posSep)
                        hvalue = cok.Substring(posSep + 1)
                        tempCookies.Add(New Uri(urlz.Text), New Cookie(hname, hvalue))
                    Next

                    postReq.CookieContainer = tempCookies
                    postReq.ContentLength = byteData.Length
                    Dim postreqstream As Stream = postReq.GetRequestStream()
                    postreqstream.Write(byteData, 0, byteData.Length)
                    postreqstream.Close()

                    '   RESPONSE


                    Dim myHttpWebResponse As HttpWebResponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
                    tempCookies.Add(myHttpWebResponse.Cookies)
                    Dim postreqreader As New StreamReader(myHttpWebResponse.GetResponseStream, encoding)
                    browser.DocumentText = postreqreader.ReadToEnd
                    responseheaders.Text = "HTTP/" + myHttpWebResponse.ProtocolVersion.ToString + " " + Str(myHttpWebResponse.StatusCode) + " " + myHttpWebResponse.StatusDescription.ToString + ControlChars.CrLf

                    Dim i As Integer
                    While i < myHttpWebResponse.Headers.Count
                        responseheaders.Text += myHttpWebResponse.Headers.Keys(i) + ":" + myHttpWebResponse.Headers(i) + ControlChars.CrLf
                        i = i + 1
                    End While

                    myHttpWebResponse.Close()
                Catch xxx As Exception
                    responseheaders.Text = xxx.Message.ToString
                End Try

            ElseIf method.Text.Contains("GET") Or method.Text.Contains("DELETE") Then
                responseheaders.Text = ""
                browser.DocumentText = ""
                Try
                    Dim tempCookies As New CookieContainer
                    Dim postReq As HttpWebRequest
                    If (flag = 1) Then
                        postReq = CType(WebRequest.Create(urlz.Text + "?" + oauthparams), HttpWebRequest)
                    Else
                        postReq = CType(WebRequest.Create(urlz.Text + "?" + parameters.Text), HttpWebRequest)
                    End If

                    'Proxy support

                    If CheckBox1.Checked = True Then

                        Try
                            Dim myProxy As New WebProxy()
                            Dim newUri As New Uri("http://" & My.Settings.paddress & ":" & My.Settings.pport)
                            myProxy.Address = newUri
                            myProxy.Credentials = New NetworkCredential(My.Settings.pusername, My.Settings.ppassword)
                            postReq.Proxy = myProxy
                        Catch ex As Exception
                            MsgBox(ex.Message.ToString, vbCritical)
                        End Try

                    End If

                    postReq.Method = method.Text
                    'ADD HEADER
                    If (flag = 0) Then
                        postReq.Headers.Add("Authorization", oauthparams)

                    End If
                    postReq.ContentType = "application/x-www-form-urlencoded; charset=UTF-8"
                    Dim cnt As Integer = 0
                    Dim posSep, hname, hvalue As String
                    While cnt < headers.Items.Count
                        posSep = headers.Items(cnt).IndexOf(":")
                        hname = headers.Items(cnt).Substring(0, posSep)
                        hvalue = headers.Items(cnt).Substring(posSep + 1)
                        If hname.Contains("User-Agent") Then
                            postReq.UserAgent = hvalue
                        ElseIf hname.Contains("Connection") Then
                            postReq.Connection = hvalue
                        ElseIf hname.Contains("Content-Type") Then
                            postReq.ContentType = hvalue
                        ElseIf hname.Equals("Accept") Then
                            postReq.Accept = hvalue
                        ElseIf hname.Contains("Referer") Then
                            postReq.Referer = hvalue
                        ElseIf hname.Contains("Expect") Then
                            postReq.Expect = hvalue
                        Else
                            postReq.Headers.Add(hname, hvalue)
                        End If
                        cnt = cnt + 1
                    End While

                    'Cookie
                    For Each cok As String In cookies.Items
                        posSep = cok.IndexOf(":")
                        hname = cok.Substring(0, posSep)
                        hvalue = cok.Substring(posSep + 1)
                        tempCookies.Add(New Uri(urlz.Text), New Cookie(hname, hvalue))
                    Next
                    postReq.CookieContainer = tempCookies

                    'RESPONSE
                    Dim myHttpWebResponse As HttpWebResponse = CType(postReq.GetResponse(), HttpWebResponse)

                    Dim postreqreader As New StreamReader(myHttpWebResponse.GetResponseStream)
                    browser.DocumentText = postreqreader.ReadToEnd
                    responseheaders.Text += "HTTP/" + myHttpWebResponse.ProtocolVersion.ToString + " " + Str(myHttpWebResponse.StatusCode) + " " + myHttpWebResponse.StatusDescription.ToString + ControlChars.CrLf
                    Dim i As Integer
                    While i < myHttpWebResponse.Headers.Count
                        responseheaders.Text += myHttpWebResponse.Headers.Keys(i) + ":" + myHttpWebResponse.Headers(i) + ControlChars.CrLf
                        i = i + 1
                    End While

                    myHttpWebResponse.Close()
                Catch xxx As Exception
                    responseheaders.Text = xxx.Message.ToString
                End Try
            Else
                MsgBox("Unsupported Method!", vbCritical)

            End If

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim header As String = InputBox("Enter the Header Name and Value","Add Header")
        If (header.Contains(":") And header.Length > 2) Then
            headers.Items.Add(header)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If headers.SelectedIndex >= 0 Then
            Dim eheader As String = InputBox("Enter the Header", "Edit Header")
            If (eheader.Contains(":") And eheader.Length > 2) Then
                headers.Items(headers.SelectedIndex) = eheader
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If headers.SelectedIndex >= 0 Then
            headers.Items.RemoveAt(headers.SelectedIndex)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        headers.Items.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim namevalue As String = InputBox("Enter the Cookie Name and Value", "Add Cookie")
        If (namevalue.Contains(":") And namevalue.Length > 2) Then
            cookies.Items.Add(namevalue)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If cookies.SelectedIndex >= 0 Then
            Dim cook As String = InputBox("Enter the Cookie", "Edit Cookie")
            If (cook.Contains(":") And cook.Length > 2) Then
                cookies.Items(cookies.SelectedIndex) = cook
            End If
        End If
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If cookies.SelectedIndex >= 0 Then
            cookies.Items.RemoveAt(cookies.SelectedIndex)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cookies.Items.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SetProxyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetProxyToolStripMenuItem.Click
        SetProxy.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("OAuth1.0a Request Crafter" + vbCrLf + "A Simple Tool to generate OAuth Signature and make the Request on the Go." + vbCrLf + "Ajin Abraham" + vbCrLf + "opensecurity.in")
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
