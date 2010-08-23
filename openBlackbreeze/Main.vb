Public Class Main

    ' A subroutine that will execute a .EXE and wait til its done.
    Sub DoCMD(ByVal file As String, ByVal arg As String)
        Dim procNlite As New Process
        winstyle = 1
        procNlite.StartInfo.FileName = file
        procNlite.StartInfo.Arguments = " " & arg
        procNlite.StartInfo.WindowStyle = winstyle
        Application.DoEvents()
        procNlite.Start()
        Do Until procNlite.HasExited
            Application.DoEvents()
            For i = 0 To 5000000
                Application.DoEvents()
            Next
        Loop
        procNlite.WaitForExit()
    End Sub

    Function GetDirName(ByVal ScanString As String) As String
        Dim intPos As Integer = 1, intPosSave As Integer
        Do
            intPos = InStr(intPos, ScanString, "\")
            If intPos = 0 Then
                Exit Do
            Else
                intPos = intPos + 1
                intPosSave = intPos - 1
            End If
        Loop
        GetDirName = Strings.Left(ScanString, intPosSave)
    End Function

    Sub bspatch(ByVal oldfile As String, ByVal newfile As String, ByVal patchfile As String)
        Shell("bspatch.exe " & Chr(34) & oldfile & Chr(34) & " " & Chr(34) & newfile & Chr(34) & " " & Chr(34) & patchfile & Chr(34), AppWinStyle.Hide, True)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Text = "Browsing for blackra1n.exe..."
        dlgBlackra1n.ShowDialog()

        If dlgBlackra1n.FileName = "" Then End
        Me.Text = "Select a save location..."

        dlgSaveBlackra1n.ShowDialog()
        If dlgBlackra1n.FileName = "" Then End


        Dim iTunesMobileDevice As String = _
                        Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & _
                            "\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll"

        Dim iTunesMobileDevice2 As String = _
                GetDirName(dlgSaveBlackra1n.FileName) & "iTunesMobileDevice2.dll"


        bspatch(dlgBlackra1n.FileName, dlgSaveBlackra1n.FileName, "blackra1n.patch")
        bspatch(iTunesMobileDevice, iTunesMobileDevice2, "iTunes.patch")

        MessageBox.Show("Your files are now Blackbreezed! The saved blackra1n_fixed.exe will now work for iTunes 9.1+" & vbCrLf & vbCrLf & _
                                   "Open-sourced version of blackbreeze programmed by Fallensn0w." & vbCrLf & _
                                   "http://fallensn0w.tk  |  http://fallensn0w.host22.com", _
        Me.Text, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)

        End

    End Sub


End Class
