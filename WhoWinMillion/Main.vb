Public Class Main
    Public Sound As String

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        End
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        My.Forms.About.ShowDialog()
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Sound = "Enter"
        SounPlayer.RunWorkerAsync(My.Resources.Enter)
    End Sub

    Private Sub SounPlayer_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SounPlayer.DoWork

        If Sound = "Starter" Or Sound = "End" Then
            My.Computer.Audio.Play(e.Argument, AudioPlayMode.Background)
        Else
            My.Computer.Audio.Play(e.Argument, AudioPlayMode.WaitToComplete)
        End If
        If Sound = "Enter" Then
            Me.Invoke(Sub() Qs.Show())
            Me.Invoke(Sub() Me.Hide())
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sound = "Starter"
        SounPlayer.RunWorkerAsync(My.Resources.Welcome)
        'Dim rm As ResXResourceSet = New ResXResourceSet("AppResources.resx")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Design.Show()
    End Sub
End Class
