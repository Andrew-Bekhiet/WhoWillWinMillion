Imports System.Resources

Public Class Qs
    Dim Counter As Integer = 1
    Private Sound As String = ""
    Private _Close As Boolean = False
    Public RightAnsI As Int16 = 1
    Private ReadOnly Names As String() = {"محمد", "يوسف", "أحمد", "محمود", "مصطفى", "ياسين", "طه", "خالد", "حمزة", "بلال", "إبراهيم", "حسن", "حسين", "كريم", "طارق", "عبد الرحمن", "علي", "عمر", "حليم", "مراد", "سالم", "عبدالله", "بيتر", "جون", "جورج", "مينا", "بيشوي", "كيرلس", "مارك", "فادي", "حبيب"}
    Dim I As Integer
    Dim I2 As Integer
    Dim Ans As Label
    Dim Ran As Random = New Random()
    Private Sub Qs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not _Close Then
            If MsgBox("هل تريد الانسحاب؟", MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.MsgBoxRight, "تأكيد") = MsgBoxResult.Yes Then
                Sound = "OptOut"
                If Not SoundPlayer.IsBusy Then SoundPlayer.RunWorkerAsync(My.Resources.OptOut)
            End If
            e.Cancel = True
        End If
    End Sub

    Private Sub SoundPlayer_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SoundPlayer.DoWork
        If Sound = "OptOut" Then
            Try
                My.Computer.Audio.Play(e.Argument, AudioPlayMode.WaitToComplete)
                If RightAnsI = 1 Then
                    If A1.InvokeRequired() Then
                        Invoke(Sub() A1.BackColor = Color.Lime)
                    Else
                        A1.BackColor = Color.Lime
                    End If
                ElseIf RightAnsI = 2 Then
                    If A2.InvokeRequired() Then
                        Invoke(Sub() A2.BackColor = Color.Lime)
                    Else
                        A2.BackColor = Color.Lime
                    End If
                ElseIf RightAnsI = 3 Then
                    If A3.InvokeRequired() Then
                        Invoke(Sub() A3.BackColor = Color.Lime)
                    Else
                        A3.BackColor = Color.Lime
                    End If
                ElseIf RightAnsI = 4 Then
                    If A4.InvokeRequired() Then
                        Invoke(Sub() A4.BackColor = Color.Lime)
                    Else
                        A4.BackColor = Color.Lime
                    End If
                End If
                Threading.Thread.Sleep(1500)
                _Close = True

                If Me.InvokeRequired() Then
                    Invoke(Sub() Main.Show())
                    Invoke(Sub() Main.Sound = "End")
                    Invoke(Sub() Main.SounPlayer.RunWorkerAsync(My.Resources._End))
                    Invoke(Sub() Close())
                Else
                    Main.Show()
                    Main.Sound = "End"
                    Main.SounPlayer.RunWorkerAsync(My.Resources._End)
                    Close()
                End If
            Catch
                Debugger.Break()
            End Try
        End If
        If Sound = "Next" Then
            My.Computer.Audio.Play(My.Resources.Stress, AudioPlayMode.WaitToComplete)
            If RightAnsI = 1 Then
                If A1.InvokeRequired() Then
                    Invoke(Sub() A1.BackColor = Color.Lime)
                Else
                    A1.BackColor = Color.Lime
                End If
            ElseIf RightAnsI = 2 Then
                If A2.InvokeRequired() Then
                    Invoke(Sub() A2.BackColor = Color.Lime)
                Else
                    A2.BackColor = Color.Lime
                End If
            ElseIf RightAnsI = 3 Then
                If A3.InvokeRequired() Then
                    Invoke(Sub() A3.BackColor = Color.Lime)
                Else
                    A3.BackColor = Color.Lime
                End If
            ElseIf RightAnsI = 4 Then
                If A4.InvokeRequired() Then
                    Invoke(Sub() A4.BackColor = Color.Lime)
                Else
                    A4.BackColor = Color.Lime
                End If
            End If
        ElseIf Sound = "False" Then
            My.Computer.Audio.Play(My.Resources.Stress, AudioPlayMode.WaitToComplete)
            Ans.BackColor = Color.Red
        End If
        My.Computer.Audio.Play(e.Argument, AudioPlayMode.WaitToComplete)
        If _Close Then
            Invoke(Sub() Close())
        ElseIf Sound = "FriendHelp" Then
            Dim I As UInt16 = Ran.Next(1, 5)
            My.Computer.Audio.Play(
                My.Resources.ResourceManager.GetStream("Friend" + I.ToString()),
                AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(
                My.Resources.ResourceManager.GetStream("Friend" + I.ToString() + RightAnsI.ToString()),
                AudioPlayMode.WaitToComplete)
            _Friend.Visible = True
        ElseIf Sound = "Delete2" Then
NewI:       I = Ran.Next(1, 5)
            I2 = Ran.Next(1, 5)
            If I = RightAnsI Or I2 = RightAnsI Or I = I2 Then
                GoTo NewI
            End If
            If Not (InvokeRequired Or A2.InvokeRequired Or A3.InvokeRequired Or A4.InvokeRequired) Then
                If I = 1 Then
                    A1.Text = ""
                ElseIf I = 2 Then
                    A2.Text = ""
                ElseIf I = 3 Then
                    A3.Text = ""
                ElseIf I = 4 Then
                    A4.Text = ""
                End If
                If I2 = 1 Then
                    A1.Text = ""
                ElseIf I2 = 2 Then
                    A2.Text = ""
                ElseIf I2 = 3 Then
                    A3.Text = ""
                ElseIf I2 = 4 Then
                    A4.Text = ""
                End If
            Else
                If I = 1 Then
                    Invoke(Sub() A1.Text = "")
                ElseIf I = 2 Then
                    Invoke(Sub() A2.Text = "")
                ElseIf I = 3 Then
                    Invoke(Sub() A3.Text = "")
                ElseIf I = 4 Then
                    Invoke(Sub() A4.Text = "")
                End If
                If I2 = 1 Then
                    Invoke(Sub() A1.Text = "")
                ElseIf I2 = 2 Then
                    Invoke(Sub() A2.Text = "")
                ElseIf I2 = 3 Then
                    Invoke(Sub() A3.Text = "")
                ElseIf I2 = 4 Then
                    Invoke(Sub() A4.Text = "")
                End If
            End If
        ElseIf Sound = "Next" Or Sound = "Start" Then
            Try
                If Counter < 16 Then
                    Invoke(Sub() A1.BackColor = Color.Transparent)
                    Invoke(Sub() A2.BackColor = Color.Transparent)
                    Invoke(Sub() A3.BackColor = Color.Transparent)
                    Invoke(Sub() A4.BackColor = Color.Transparent)
                    RightAnsI = Int(New ResXResourceSet("Data.resx").GetObject("Q" + Counter.ToString() + "RA")) + 1
                    My.Computer.Audio.Play(My.Resources.ResourceManager.GetStream("Q" + Counter.ToString()), AudioPlayMode.WaitToComplete)
                    Invoke(Sub() Q.Text = New ResXResourceSet("Data.resx").GetString("Q" + Counter.ToString()))
                    Invoke(Sub() A1.Text = "أ: " + New ResXResourceSet("Data.resx").GetString("Q" + Counter.ToString() + "A1"))
                    My.Computer.Audio.Play(My.Resources.Ans1, AudioPlayMode.WaitToComplete)
                    Invoke(Sub() A2.Text = "ب: " + New ResXResourceSet("Data.resx").GetString("Q" + Counter.ToString() + "A2"))
                    My.Computer.Audio.Play(My.Resources.Ans2, AudioPlayMode.WaitToComplete)
                    Invoke(Sub() A3.Text = "ج: " + New ResXResourceSet("Data.resx").GetString("Q" + Counter.ToString() + "A3"))
                    My.Computer.Audio.Play(My.Resources.Ans3, AudioPlayMode.WaitToComplete)
                    Invoke(Sub() A4.Text = "د: " + New ResXResourceSet("Data.resx").GetString("Q" + Counter.ToString() + "A4"))
                    My.Computer.Audio.Play(My.Resources.Ans4, AudioPlayMode.WaitToComplete)
                    Invoke(Sub() A1.Enabled = True)
                    Invoke(Sub() A2.Enabled = True)
                    Invoke(Sub() A3.Enabled = True)
                    Invoke(Sub() A4.Enabled = True)
                    My.Computer.Audio.Play(My.Resources.Background, AudioPlayMode.BackgroundLoop)
                Else
                    MsgBox("لقد ربحت المليون!", MsgBoxStyle.Information Or MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading, "مبروك!")
                    Invoke(Sub() Main.Show())
                    Invoke(Sub() Main.Sound = "End")
                    Invoke(Sub() Main.SounPlayer.RunWorkerAsync(My.Resources._End))
                    _Close = True
                    Invoke(Sub() Close())
                End If
            Catch ex As Exception
                Debugger.Break()
            End Try
        ElseIf Sound = "False" Then
            If RightAnsI = 1 Then
                If A1.InvokeRequired() Then
                    Invoke(Sub() A1.BackColor = Color.Lime)
                Else
                    A1.BackColor = Color.Lime
                End If
            ElseIf RightAnsI = 2 Then
                If A2.InvokeRequired() Then
                    Invoke(Sub() A2.BackColor = Color.Lime)
                Else
                    A2.BackColor = Color.Lime
                End If
            ElseIf RightAnsI = 3 Then
                If A3.InvokeRequired() Then
                    Invoke(Sub() A3.BackColor = Color.Lime)
                Else
                    A3.BackColor = Color.Lime
                End If
            ElseIf RightAnsI = 4 Then
                If A4.InvokeRequired() Then
                    Invoke(Sub() A4.BackColor = Color.Lime)
                Else
                    A4.BackColor = Color.Lime
                End If
            End If
            System.Threading.Thread.Sleep(1500)
            Invoke(Sub() Main.Show())
            Invoke(Sub() Main.Sound = "End")
            Invoke(Sub() Main.SounPlayer.RunWorkerAsync(My.Resources._End))
            _Close = True
            Invoke(Sub() Close())
        End If
    End Sub

    Private Sub Qs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sound = "Start"
        SoundPlayer.RunWorkerAsync(My.Resources.Start)
    End Sub

    Private Sub Answer_Click(sender As Object, e As EventArgs) Handles A1.Click, A2.Click, A3.Click, A4.Click
        If Int(sender.Tag) = RightAnsI Then
            Counter += 1
            Sound = "Next"
            SoundPlayer.RunWorkerAsync(My.Resources.ResourceManager.GetStream("A__" + (Counter - 1).ToString() + "_"))
            sender.BackColor = Color.Orange
        Else
            Ans = sender
            Sound = "False"
            SoundPlayer.RunWorkerAsync(My.Resources.ResourceManager.GetStream("_False"))
            sender.BackColor = Color.Orange
        End If
        A1.Enabled = False
        A2.Enabled = False
        A3.Enabled = False
        A4.Enabled = False
    End Sub

    Private Sub HW_Click(sender As Object, e As EventArgs) Handles HW.Click
        If Not SoundPlayer.IsBusy Then
            Sound = "WatchersHelp"
            SoundPlayer.RunWorkerAsync(My.Resources.HelpFromWatchers)
            HelpWatchers.Show()
            HelpWatchers.Location = New Point(Me.Location.X + (HelpWatchers.Size.Width * 2), Me.Location.Y)
            sender.BackgroundImage = My.Resources.ResourceManager.GetObject("Asset_5")
            sender.Enabled = False
        End If
    End Sub

    Private Sub Qs_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        If HelpWatchers.Visible Then
            HelpWatchers.Location = New Point(Me.Location.X + (HelpWatchers.Size.Width * 2), Me.Location.Y)
        End If
    End Sub
    Private Sub HF_Click(sender As Object, e As EventArgs) Handles HF.Click
        If Not SoundPlayer.IsBusy Then
            Sound = "FriendHelp"
            SoundPlayer.RunWorkerAsync(My.Resources.FriendHelp)
            _Friend.Text = _Friend.Text.Replace("(اسم)", Names(Ran.Next(Names.Length + 1)))
            _Friend.Visible = True
            sender.BackgroundImage = My.Resources.ResourceManager.GetObject("Asset_6")
            sender.Enabled = False
        End If
    End Sub


    Private Sub D2_Click(sender As Object, e As EventArgs) Handles D2.Click
        If Not SoundPlayer.IsBusy Then
            Sound = "Delete2"
            SoundPlayer.RunWorkerAsync(My.Resources.Delete2)
            sender.BackgroundImage = My.Resources.ResourceManager.GetObject("Asset_7")
            sender.Enabled = False
        End If
    End Sub

    Private Sub Q_Click(sender As Object, e As EventArgs) Handles Q.Click

    End Sub
End Class