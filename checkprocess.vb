Private Sub processchecker()
        Dim p() As Process ' p is process
        p = Process.GetProcessesByName("processname") ' process's name
        If p.Count > 0 Then ' If Process is running
            ' Process is running
            MsgBox("ProcessName.exe dedected")
        Else
            ' Process is not running
            MsgBox("Please Open ProcessName.exe")
        End If
 

