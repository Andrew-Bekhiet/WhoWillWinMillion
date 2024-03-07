Imports System.Reflection
Imports System.Resources

Public Class Design
    Private Sub Design_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 15
            Dim Q As New Question()
            Q.Dock = DockStyle.Fill
            Q.SetQIndex(i)
            If i Mod 2 = 0 Then Q.BackColor = Color.White
            Q.Anchor = AnchorStyles.Top Or AnchorStyles.Right Or AnchorStyles.Left Or AnchorStyles.Bottom
            If TLP.RowCount = 1 Then
                TLP.RowStyles(0) = New RowStyle(SizeType.AutoSize, CSng(100 / 15))
            Else
                TLP.RowStyles.Add(New RowStyle(SizeType.AutoSize, CSng(100 / 15)))
            End If
            TLP.Controls.Add(Q, 0, i - 1)
        Next
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        If MsgBox("هل تريد حفظ البيانات؟", MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Close()
        Else
            Save_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim Verification As List(Of Boolean) = New List(Of Boolean)
        For Each Q As Question In TLP.Controls
            Verification.Add(Q.IsAllFilled())
        Next
        If Verification.TrueForAll(Function(x) x) Then
            Dim writer As ResXResourceWriter = New ResXResourceWriter("Data.resx")
            For Each Q As Question In TLP.Controls
                writer.AddResource("Q" + (TLP.Controls.IndexOf(Q) + 1).ToString(), Q.Q.Text)
                writer.AddResource("Q" + (TLP.Controls.IndexOf(Q) + 1).ToString() + "A1", Q.A1.Text)
                writer.AddResource("Q" + (TLP.Controls.IndexOf(Q) + 1).ToString() + "A2", Q.A2.Text)
                writer.AddResource("Q" + (TLP.Controls.IndexOf(Q) + 1).ToString() + "A3", Q.A3.Text)
                writer.AddResource("Q" + (TLP.Controls.IndexOf(Q) + 1).ToString() + "A4", Q.A4.Text)
                writer.AddResource("Q" + (TLP.Controls.IndexOf(Q) + 1).ToString() + "RA", Q.RA.SelectedIndex.ToString())
            Next
            writer.Generate()
            writer.Close()
        Else
            MsgBox("يجب ملئ جميع الأسئلة وأجوبتها!", MsgBoxStyle.MsgBoxRight Or MsgBoxStyle.MsgBoxRtlReading Or MsgBoxStyle.Critical)
        End If
    End Sub
End Class