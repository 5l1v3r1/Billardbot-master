﻿Module ShortcutModules

    Public Sub KillAllBots()
        '''''''''BELOW HERE WAS THE OLD METHOD OF USING 4 BOTS'''''
        'For Each p As Process In Process.GetProcesses()
        '        If p.ProcessName = "Bot1" Then 'Or p.ProcessName = "mspaint"
        '            p.Kill()
        '            Form2.DebuggerList.Items.Add("TERMINATED: Bot1.exe")
        '            Form3.DebuggerList.Items.Add("TERMINATED: Bot1.exe")
        '        End If
        '    Next

        '    For Each p2 As Process In Process.GetProcesses()
        '        If p2.ProcessName = "Bot2" Then 'Or p.ProcessName = "mspaint"
        '            p2.Kill()
        '            Form2.DebuggerList.Items.Add("TERMINATED: Bot2.exe")
        '            Form3.DebuggerList.Items.Add("TERMINATED: Bot2.exe")
        '        End If
        '    Next

        '    For Each p3 As Process In Process.GetProcesses()
        '        If p3.ProcessName = "Bot3" Then 'Or p.ProcessName = "mspaint"
        '            p3.Kill()
        '            Form2.DebuggerList.Items.Add("TERMINATED: Bot3.exe")
        '            Form3.DebuggerList.Items.Add("TERMINATED: Bot3.exe")
        '        End If
        '    Next

        '    For Each p4 As Process In Process.GetProcesses()
        '        If p4.ProcessName = "Bot4" Then 'Or p.ProcessName = "mspaint"
        '            p4.Kill()
        '            Form2.DebuggerList.Items.Add("TERMINATED: Bot4.exe")
        '            Form3.DebuggerList.Items.Add("TERMINATED: Bot4.exe")
        '        End If
        '    Next
        '''''''''''''END OF OLD METHOD

        For Each p5 As Process In Process.GetProcesses()
            If p5.ProcessName = "Bot" Then 'Or p.ProcessName = "mspaint"
                p5.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: Bot.exe")
                Form3.DebuggerList.Items.Add("TERMINATED: Bot.exe")
            End If
        Next

    End Sub

    Public Sub KillAllBots2()
        If MessageBox.Show("Are you sure? All bots will be terminated ", "Terminate Bots", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then

            For Each p5 As Process In Process.GetProcesses()
                If p5.ProcessName = "Bot" Then 'Or p.ProcessName = "mspaint"
                    p5.Kill()
                    Form2.DebuggerList.Items.Add("TERMINATED: Bot.exe")
                    Form3.DebuggerList.Items.Add("TERMINATED: Bot.exe")
                End If
            Next
        End If

    End Sub


    Public Sub KillBs()

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Agent" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: HD-Agent.exe") 'Form3.DebuggerList.Items.Add
                Form3.DebuggerList.Items.Add("TERMINATED: HD-Agent.exe")
            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-LogRotatorService" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: HD-LogRotatorService.exe")
                Form3.DebuggerList.Items.Add("TERMINATED: HD-LogRotatorService.exe")

            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-OBS" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: HD-OBS.exe")
                Form3.DebuggerList.Items.Add("TERMINATED: HD-OBS.exe")
            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Plus-Frontend" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: HD-Plus-Frontend.exe")
                Form3.DebuggerList.Items.Add("TERMINATED: HD-Plus-Frontend.exe")
            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Plus-Service" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: HD-Plus-Service.exe")
                Form3.DebuggerList.Items.Add("TERMINATED: HD-Plus-Service.exe")
            End If
        Next

        'For Each p7 As Process In Process.GetProcesses()
        '    If p7.ProcessName = "BlueStacks_old" Then 'Or p.ProcessName = "mspaint"
        '        p7.Kill()
        '        Form2.DebuggerList.Items.Add("TERMINATED: BlueStacks_old.exe")
        '        Form3.DebuggerList.Items.Add("TERMINATED: BlueStacks_old.exe")
        '    End If
        'Next


    End Sub

    Public Sub KillBs2()

        If MessageBox.Show("Are you sure? BlueStacks processes will be terminated ", "Terminate Bluestacks", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then

            For Each p6 As Process In Process.GetProcesses()
                If p6.ProcessName = "HD-Agent" Then 'Or p.ProcessName = "mspaint"
                    p6.Kill()
                    Form2.DebuggerList.Items.Add("TERMINATED: HD-Agent.exe") 'Form3.DebuggerList.Items.Add
                    Form3.DebuggerList.Items.Add("TERMINATED: HD-Agent.exe")
                End If
            Next

            For Each p6 As Process In Process.GetProcesses()
                If p6.ProcessName = "HD-LogRotatorService" Then 'Or p.ProcessName = "mspaint"
                    p6.Kill()
                    Form2.DebuggerList.Items.Add("TERMINATED: HD-LogRotatorService.exe")
                    Form3.DebuggerList.Items.Add("TERMINATED: HD-LogRotatorService.exe")

                End If
            Next

            For Each p6 As Process In Process.GetProcesses()
                If p6.ProcessName = "HD-OBS" Then 'Or p.ProcessName = "mspaint"
                    p6.Kill()
                    Form2.DebuggerList.Items.Add("TERMINATED: HD-OBS.exe")
                    Form3.DebuggerList.Items.Add("TERMINATED: HD-OBS.exe")
                End If
            Next

            For Each p6 As Process In Process.GetProcesses()
                If p6.ProcessName = "HD-Plus-Frontend" Then 'Or p.ProcessName = "mspaint"
                    p6.Kill()
                    Form2.DebuggerList.Items.Add("TERMINATED: HD-Plus-Frontend.exe")
                    Form3.DebuggerList.Items.Add("TERMINATED: HD-Plus-Frontend.exe")
                End If
            Next

            For Each p6 As Process In Process.GetProcesses()
                If p6.ProcessName = "HD-Plus-Service" Then 'Or p.ProcessName = "mspaint"
                    p6.Kill()
                    Form2.DebuggerList.Items.Add("TERMINATED: HD-Plus-Service.exe")
                    Form3.DebuggerList.Items.Add("TERMINATED: HD-Plus-Service.exe")
                End If
            Next

            'For Each p7 As Process In Process.GetProcesses()
            '    If p7.ProcessName = "BlueStacks_old" Then 'Or p.ProcessName = "mspaint"
            '        p7.Kill()
            '        Form2.DebuggerList.Items.Add("TERMINATED: BlueStacks_old.exe")
            '        Form3.DebuggerList.Items.Add("TERMINATED: BlueStacks_old.exe")
            '    End If
            'Next

        End If





    End Sub





    Public Sub BluestacksRestartBot()


        For Each p5 As Process In Process.GetProcesses()
            If p5.ProcessName = "Restarter" Then 'Or p.ProcessName = "mspaint"
                p5.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: Restarter.exe")
            Else
                KillAllBots()
                KillBs()
                Process.Start("Restarter.exe")
                End


            End If
        Next


    End Sub

    Public Sub StartAllBots()
        'Process.Start("C:\Users\ADmin\Documents\visual studio 2015\Projects\BillardBot\BillardBot\bin\Debug\bots\Bot1.exe")
        'Process.Start("C:\Users\ADmin\Documents\visual studio 2015\Projects\BillardBot\BillardBot\bin\Debug\bots\Bot2.exe")
        'Process.Start("C:\Users\ADmin\Documents\visual studio 2015\Projects\BillardBot\BillardBot\bin\Debug\bots\Bot3.exe")
        'Process.Start("C:\Users\ADmin\Documents\visual studio 2015\Projects\BillardBot\BillardBot\bin\Debug\bots\Bot4.exe")

        'TESTING NEW THING BY OPENING 1 BOT MULTIPLE TIMES 07-27-17 1:50AM
        'Process.Start("bots\Bot1.exe")
        'Process.Start("bots\Bot2.exe")
        'Process.Start("bots\Bot3.exe")
        'Process.Start("bots\Bot4.exe")
        'END OF RESVISION TESTING
        Process.Start("bots\Bot.exe")
        Process.Start("bots\Bot.exe")
        Process.Start("bots\Bot.exe")
        Process.Start("bots\Bot.exe")




        Form2.DebuggerList.Items.Add("STARTED: Bot1, Bot2, Bot3, Bot4")
        'Form2.DebuggerList.Items.Add("STARTED: Bot2.exe")
        'Form2.DebuggerList.Items.Add("STARTED: Bot3.exe")
        'Form2.DebuggerList.Items.Add("STARTED: Bot4.exe")
    End Sub





    Dim HdAgent() As Process
    Dim HdLogRotator() As Process
    Dim HdFronted() As Process
    Dim HdPlusService() As Process
    Dim HdBlueStacks() As Process
    Dim HdObs() As Process
    Dim HdUpdaterService() As Process


    Public Sub CheckIfRunning()


        If HdAgent.Count > 0 Then
            Process.GetProcessesByName("HD-Agent")(0).Kill()

        Else
            Form4.lblHdAgent.ForeColor = Color.Lime
        End If

        If HdLogRotator.Count > 0 Then
            Process.GetProcessesByName("HD-LogRotatorService")(0).Kill()

        Else
            Form4.lblPlugRotator.ForeColor = Color.Lime
        End If

        If HdUpdaterService.Count > 0 Then
            Process.GetProcessesByName("HD-UpdaterService")(0).Kill()

        Else
            Form4.lblUpdaterService.ForeColor = Color.Lime
        End If

        If HdFronted.Count > 0 Then
            Process.GetProcessesByName("HD-Plus-Frontend")(0).Kill()

        Else
            Form4.lblFronted.ForeColor = Color.Lime
        End If

        If HdPlusService.Count > 0 Then
            Process.GetProcessesByName("HD-Plus-Service")(0).Kill()

        Else
            Form4.lblPlusService.ForeColor = Color.Lime
        End If

        If HdObs.Count > 0 Then
            Process.GetProcessesByName("HD-OBS")(0).Kill()

        Else
            Form4.lblObs.ForeColor = Color.Lime

            If HdBlueStacks.Count > 0 Then
                Process.GetProcessesByName("HD-OBS")(0).Kill()

            Else
                Form4.lblBlueStacks.ForeColor = Color.Lime
            End If
        End If




    End Sub

End Module
