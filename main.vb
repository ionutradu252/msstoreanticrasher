Imports System.IO
Imports System.Security.Cryptography

'made by snaipdefix#1288 on discord

Public Class mainform

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'get taskbar shortcuts and list them
        Dim shortcuts As List(Of String) = get_taskbar_shortcuts()

        'clean
        shortcuts.RemoveAll(Function(s) s.Contains("desktop.ini"))

        'get filenames
        Dim filenames As New List(Of String)
        For Each shortcut In shortcuts
            filenames.Add(Path.GetFileNameWithoutExtension(shortcut))
        Next

        'set row height
        datagridview.RowTemplate.Height = 50

        For i = 0 To filenames.Count - 1
            Dim currenticon = Icon.ExtractAssociatedIcon(shortcuts(i))
            datagridview.Rows.Add(currenticon, filenames(i), get_path_from_shortcut(shortcuts(i)))
        Next

        'hide game running (display only when starting game)
        gamerunningpage.Hide()
        tabcontrol.TabPages.Remove(gamerunningpage)


        update_ver()
        load_values()
        check_old_process()

    End Sub

    Private Sub update_ver()
        versionlbl.Text = "V" & Split(Application.ProductVersion.ToString, ".0.0")(0)
    End Sub

    Private Sub datagridview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridview.CellDoubleClick
        Try
            Process.Start(datagridview.CurrentRow.Cells(2).Value.ToString)
        Catch ex As Exception
            Try
                Process.Start(Replace(datagridview.CurrentRow.Cells(2).Value.ToString, "Program Files (x86)", "Program Files"))
                Return
            Catch
            End Try
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles newexplorerbtn.Click
        Try
            File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp & "\newexplorer.exe", My.Resources.newexplorer)
            Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp & "\newexplorer.exe")
        Catch
        End Try
    End Sub


    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles cmdbtn.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles checkpiddbgbtn.Click

        MsgBox("PID = " & My.Settings.pid)
        MsgBox("Running = " & Process.GetProcesses().Any(Function(x) x.Id = My.Settings.pid))
    End Sub

    Private Sub fh3btn_Click(sender As Object, e As EventArgs) Handles fh3btn.Click
        create_batch_and_run(My.Settings.timeout, "Microsoft.OpusPG_8wekyb3d8bbwe!OpusReleaseFinal", "forza_x64_release_final", My.Settings.updatefreq)
        load_game("fh3", False)
    End Sub

    Private Sub fh4btn_Click(sender As Object, e As EventArgs) Handles fh4btn.Click
        create_batch_and_run(My.Settings.timeout, "Microsoft.SunriseBaseGame_8wekyb3d8bbwe!SunriseReleaseFinal", "ForzaHorizon4", My.Settings.updatefreq)
        load_game("fh4", False)
    End Sub

    Private Sub fh5btn_Click(sender As Object, e As EventArgs) Handles fh5btn.Click
        create_batch_and_run(My.Settings.timeout, "Microsoft.624F8B84B80_8wekyb3d8bbwe!Forzahorizon5", "ForzaHorizon5", My.Settings.updatefreq)
        load_game("fh5", False)
    End Sub

    Private Sub sotgame_Click(sender As Object, e As EventArgs) Handles sotgame.Click
        create_batch_and_run(My.Settings.timeout, "Microsoft.SeaofThieves_8wekyb3d8bbwe!AthenaClientShipping", "SoTGame", My.Settings.updatefreq)
        load_game("sot", False)
    End Sub

    Private Sub msfsgame_Click(sender As Object, e As EventArgs) Handles msfsgamebtn.Click
        create_batch_and_run(My.Settings.timeout, "Microsoft.FlightSimulator_8wekyb3d8bbwe!App", "FlightSimulator", My.Settings.updatefreq)
        load_game("msfs", False)
    End Sub

    Private Sub Guna2TileButton4_Click(sender As Object, e As EventArgs) Handles addgamesdbgbtn.Click
        'add games tab
        tabcontrol.TabPages.Insert(0, gamespage)
        gamespage.Show()
        tabcontrol.SelectedTab = gamespage

        'remove gamerunning tab
        gamerunningpage.Hide()
        tabcontrol.TabPages.Remove(gamerunningpage)
    End Sub

    Private Sub load_values()
        timeoutlbl.Text = "Timeout : " & My.Settings.timeout & " seconds"
        updfreqlbl.Text = "Update frequency : " & My.Settings.updatefreq & " seconds"
        timeoutscroll.Value = My.Settings.timeout
        updfreqscroll.Value = My.Settings.updatefreq
    End Sub

    Private Sub timeoutscroll_Scroll(sender As Object, e As ScrollEventArgs) Handles timeoutscroll.Scroll
        timeoutlbl.Text = "Timeout : " & timeoutscroll.Value & " seconds"
        My.Settings.timeout = timeoutscroll.Value
    End Sub

    Private Sub updfreqscroll_Scroll(sender As Object, e As ScrollEventArgs) Handles updfreqscroll.Scroll
        updfreqlbl.Text = "Update frequency : " & updfreqscroll.Value & " seconds"
        My.Settings.updatefreq = updfreqscroll.Value
    End Sub

    Private Sub resettodefaultbtn_Click(sender As Object, e As EventArgs) Handles resettodefaultbtn.Click
        My.Settings.updatefreq = 5
        My.Settings.timeout = 60
        load_values()
    End Sub

    Private Sub load_game(gamename As String, skiptimer As Boolean)
        'remove games tab
        gamespage.Hide()
        tabcontrol.TabPages.Remove(gamespage)

        'add gamerunning tab
        tabcontrol.TabPages.Insert(0, gamerunningpage)
        gamerunningpage.Show()
        tabcontrol.SelectedTab = gamerunningpage

        If gamename = "fh3" Then
            gameico.Image = My.Resources.fh3
        ElseIf gamename = "fh4" Then
            gameico.Image = My.Resources.fh4
        ElseIf gamename = "fh5" Then
            gameico.Image = My.Resources.fh5
        ElseIf gamename = "msfs" Then
            gameico.Image = My.Resources.msfs
        ElseIf gamename = "sot" Then
            gameico.Image = My.Resources.sot
        ElseIf gamename = "dbg" Then
            gameico.Image = My.Resources.msstoreicon1
        End If

        'load labels
        runninggamelbl.Text = "Running : " & My.Settings.gamename
        pidlbl.Text = "PID : " & My.Settings.pid
        ispidrunninglbl.Text = "Is PID running : " & Process.GetProcesses().Any(Function(x) x.Id = My.Settings.pid)
        tuec = My.Settings.timeout
        If skiptimer = False Then
            tuectimer.Start()
        Else
            tueclbl.Visible = False
        End If
        make_true_green_false_red()
    End Sub

    Private tuec As Integer

    Private Sub make_true_green_false_red()
        For Each label In gamerunningpage.Controls.OfType(Of Label)
            If label.Text.ToLower.Contains("true") Then
                label.ForeColor = Color.Green
            ElseIf label.Text.ToLower.Contains("false") Then
                label.ForeColor = Color.FromArgb(238, 69, 64)
            End If
        Next
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            isgamerunninglbl.Text = "Is game running : " & Process.GetProcesses().Any(Function(x) x.Id = My.Settings.gamepid)
        Catch
        End Try
        ispidrunninglbl.Text = "Is PID running : " & Process.GetProcesses().Any(Function(x) x.Id = My.Settings.pid)

        Dim p() As Process = Process.GetProcessesByName(My.Settings.gamename)
        If Not p.Count = 0 Then
            gamepidlbl.Text = "Game PID : " & p(0).Id
            My.Settings.gamepid = p(0).Id
        Else
            isgamerunninglbl.Text = "Is game running : False"
            gamepidlbl.Text = "Game PID : none"
        End If

        make_true_green_false_red()
    End Sub

    Private Sub quitgamebtn_Click(sender As Object, e As EventArgs) Handles quitantigamebtn.Click
        If Process.GetProcesses().Any(Function(x) x.Id = My.Settings.pid) = True Then

            Dim result As DialogResult = MessageBox.Show("Closing the anti-crasher might result in a game crash. Are you sure?",
                              "snaipdefix",
                              MessageBoxButtons.YesNo)
            'closing anticrasher
            If result = DialogResult.Yes Then
                Dim aProcess As Process
                aProcess = Process.GetProcessById(My.Settings.pid)
                aProcess.Kill()
            Else
                Return
            End If
        Else
            'add games tab
            tabcontrol.TabPages.Insert(0, gamespage)
            gamespage.Show()
            tabcontrol.SelectedTab = gamespage

            'remove gamerunning tab
            gamerunningpage.Hide()
            tabcontrol.TabPages.Remove(gamerunningpage)
        End If


        'running explorer.exe if its not running
        Dim p() As Process = Process.GetProcessesByName("explorer")
        If p.Count = 0 Then
            startexplorer()
        End If
    End Sub

    Private Sub taskmgrbtn_Click(sender As Object, e As EventArgs) Handles taskmgrbtn.Click
        Process.Start("taskmgr.exe")
    End Sub

    Private Sub tuectimer_Tick(sender As Object, e As EventArgs) Handles tuectimer.Tick
        If tuec = 0 Then
            tuectimer.Stop()
            tueclbl.Visible = False
            checkstartgame()
        Else
            tueclbl.Visible = True
        End If

        Dim p() As Process = Process.GetProcessesByName(My.Settings.gamename)
        If Not p.Count = 0 Then
            isgamerunninglbl.Text = "Is game running : True"
            gamepidlbl.Text = "Game PID : " & p(0).Id
            My.Settings.gamepid = p(0).Id
        Else
            isgamerunninglbl.Text = "Is game running : False"
            gamepidlbl.Text = "Game PID : none"
        End If
        make_true_green_false_red()

        tueclbl.Text = "Time until explorer close : " & (tuec - 1)
        tuec -= 1
    End Sub

    Private Sub checkstartgame()
        If Process.GetProcesses().Any(Function(x) x.Id = My.Settings.pid) = False Then
            MsgBox("Game has not launched correctly or is not installed!")

            'running explorer.exe if its not running
            Dim p() As Process = Process.GetProcessesByName("explorer")
            If p.Count = 0 Then
                startexplorer()
            End If
        Else
            Dim p() As Process = Process.GetProcessesByName(My.Settings.gamename)
            If Not p.Count = 0 Then
                isgamerunninglbl.Text = "Is game running : True"
                gamepidlbl.Text = "Game PID : " & p(0).Id
                My.Settings.gamepid = p(0).Id
            Else
                isgamerunninglbl.Text = "Is game running : False"
                gamepidlbl.Text = "Game PID : none"
            End If
        End If
        make_true_green_false_red()
    End Sub

    Private Sub snpfxbtn_Click(sender As Object, e As EventArgs) Handles snpfxbtn.Click
        Process.Start("https://linktr.ee/snaipdefix")
    End Sub

    Private Sub debugbtn_CheckedChanged(sender As Object, e As EventArgs) Handles debugbtn.CheckedChanged
        debugmode = True
        testprocessdbgbtn.Visible = True
        checkpiddbgbtn.Visible = True
        addgamesdbgbtn.Visible = True
    End Sub

    Private debugmode = False

    Private Sub Guna2TileButton1_Click_2(sender As Object, e As EventArgs) Handles testprocessdbgbtn.Click
        create_batch_and_runtest(10, My.Settings.updatefreq)
        load_game("dbg", True)
    End Sub


    Public Sub create_batch_and_run(timeout As Integer, gamename As String, gameprocess As String, updatefreq As Integer)
        Dim sb As New Text.StringBuilder
        sb.AppendLine("@echo off")
        sb.AppendLine("ECHO made by snpfx")
        sb.AppendLine("START explorer.exe shell:AppsFolder\" & gamename)
        sb.AppendLine("TIMEOUT /T " & timeout & " /NOBREAK")
        sb.AppendLine("taskkill /f /im explorer.exe")
        sb.AppendLine(":LOOP")
        sb.AppendLine("TASKLIST | FIND /I " & """" & gameprocess & """" & " >nul 2>&1")
        sb.AppendLine("IF ERRORLEVEL 1 (")
        sb.AppendLine("GOTO CONTINUE")
        sb.AppendLine(") ELSE (")
        sb.AppendLine("ECHO Game still running...")
        sb.AppendLine("TIMEOUT /T " & updatefreq)
        sb.AppendLine("GOTO LOOP")
        sb.AppendLine(")")
        sb.AppendLine(":CONTINUE")
        sb.AppendLine("START """" ""%WINDIR%\explorer.exe""")
        sb.AppendLine("EXIT")


        File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\anticrash.bat", sb.ToString())

        Dim params As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\anticrash.bat"
        Dim myProcessinfo As New ProcessStartInfo
        myProcessinfo.FileName = params
        'myProcessinfo.Arguments = params
        myProcessinfo.WindowStyle = ProcessWindowStyle.Hidden
        Dim myprocess As New Process
        myprocess.EnableRaisingEvents = True
        AddHandler myprocess.Exited, AddressOf GameExited
        myprocess.StartInfo = myProcessinfo
        myprocess.Start()
        My.Settings.pid = myprocess.Id
        My.Settings.gamename = gameprocess
    End Sub



    'debug

    Public Sub create_batch_and_runtest(timeout As Integer, updatefreq As Integer)
        Dim sb As New Text.StringBuilder
        sb.AppendLine("@echo off")
        sb.AppendLine("ECHO made by snpfx")
        sb.AppendLine("TIMEOUT /T " & timeout & " /NOBREAK")
        'sb.AppendLine("taskkill /f /im explorer.exe")
        sb.AppendLine("pause")
        sb.AppendLine(":CONTINUE")
        sb.AppendLine("START """" ""%WINDIR%\explorer.exe""")
        sb.AppendLine("EXIT")


        File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\anticrash.bat", sb.ToString())

        Dim params As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\anticrash.bat"
        Dim myProcessinfo As New ProcessStartInfo
        myProcessinfo.FileName = params
        'myProcessinfo.Arguments = params
        'myProcessinfo.WindowStyle = ProcessWindowStyle.Hidden
        Dim myprocess As New Process
        myprocess.EnableRaisingEvents = True
        AddHandler myprocess.Exited, AddressOf GameExited
        myprocess.StartInfo = myProcessinfo
        myprocess.Start()
        My.Settings.pid = myprocess.Id
        My.Settings.gamename = "test process"
    End Sub

    Sub GameExited(sender As Object, e As EventArgs)
        'Add the games tab to the tab control on the UI thread
        tabcontrol.Invoke(Sub()
                              tabcontrol.TabPages.Insert(0, gamespage)
                              gamespage.Show()
                              tabcontrol.SelectedTab = gamespage
                          End Sub)

        ' Remove the gamerunning tab from the tab control on the UI thread
        tabcontrol.Invoke(Sub()
                              gamerunningpage.Hide()
                              tabcontrol.TabPages.Remove(gamerunningpage)
                          End Sub)
    End Sub

    Private Sub Guna2TileButton1_Click_1(sender As Object, e As EventArgs) Handles ds4btn.Click
        Try
            File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp & "\ds4anticrash.exe", My.Resources.DS4Windows)
            Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp & "\ds4anticrash.exe")
        Catch
        End Try
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        If check_if_anticrashon() = True Then
            Dim result As DialogResult = MessageBox.Show("There is a game running. This will not close the anti-crasher, only the app. Are you sure?",
                              "snaipdefix",
                              MessageBoxButtons.YesNo)
            'closing anticrasher
            If result = DialogResult.Yes Then
                Application.Exit()
            Else
                Return
            End If
        Else
            Application.Exit()
        End If
    End Sub

    Private Function check_if_anticrashon()
        Try
            Return Process.GetProcesses().Any(Function(x) x.Id = My.Settings.pid)
        Catch
        End Try
    End Function

    Private Sub check_old_process()
        Dim games() = {"fh3", "fh4", "fh5", "sot", "msfs", "dbg"}
        Dim processes() = {"forza_x64_release_final", "ForzaHorizon4", "ForzaHorizon5", "SoTGame", "FlightSimulator", "test process"}

        If check_if_anticrashon() = True Then
            'failchecks and gamechecks
            If My.Settings.gamename = Nothing Then Return

            'find index for gamename
            Dim index As Integer = Array.FindIndex(processes, Function(s) s = My.Settings.gamename)
            If index = -1 Then Return

            Dim result As DialogResult = MessageBox.Show("There is a game running. Load running game?",
                              "snaipdefix",
                              MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                load_game(games(index), True)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub quitgamebtn_Click_1(sender As Object, e As EventArgs) Handles quitgamebtn.Click
        If Not My.Settings.gamepid = Nothing Then
            Dim result As DialogResult = MessageBox.Show("This will quit the game. Are you sure?",
                              "snaipdefix",
                              MessageBoxButtons.YesNo)
            'closing anticrasher
            If result = DialogResult.Yes Then
                Try
                    Dim p As Process = Process.GetProcessById(My.Settings.gamepid)
                    p.Kill()
                Catch
                End Try
            Else
                Return
            End If

        End If
    End Sub
End Class
