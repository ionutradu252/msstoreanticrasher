Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Threading

Module modules

    Public Function get_taskbar_shortcuts()
        Dim pathh As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar")
        Dim files As List(Of String) = Directory.GetFiles(pathh).ToList()
        Return files
    End Function


    Public Function get_path_from_shortcut(shortcut As String)
        Dim shell = CreateObject("WScript.Shell")
        Return shell.CreateShortcut(shortcut).TargetPath
    End Function

    Public Sub startexplorer()
        Try
            Dim OskProcess = New Process()
            OskProcess.StartInfo.UseShellExecute = True
            OskProcess.StartInfo.CreateNoWindow = True
            OskProcess.StartInfo.FileName = "C:\Windows\explorer.exe"
            OskProcess.StartInfo.WorkingDirectory = Application.StartupPath
            OskProcess.Start()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
