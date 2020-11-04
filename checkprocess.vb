# Tested on Visual Studio 2017/2019 

Create new Private Sub

Private Sub processchecker()
        Dim p() As Process ' p is process
        p = Process.GetProcessesByName("processname") ' process's name
        If p.Count > 0 Then ' If Process is running
            ' Process is running
            
        Else
            ' Process is not running
            
        End If
 
 For Example (Streamer Mode | Obs Studio 64) 
 
 Private Sub streamerobs()
        Dim p() As Process
        p = Process.GetProcessesByName("obs64")
        If p.Count > 0 Then
            ' Process is running
            MsgBox("Streamer Mode ON", MsgBoxStyle.Information, "")
        Else
            ' Process is not running    
        End If
        
  And Type private sub's name 
  
  Example :
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      streamerobs()
        End Sub
        
