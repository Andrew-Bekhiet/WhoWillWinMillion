Public Class HelpWatchers
    Dim A1Size As Size
    Dim A2Size As Size
    Dim A3Size As Size
    Dim A4Size As Size

    Dim A1Percent As Double
    Dim A2Percent As Double
    Dim A3Percent As Double
    Dim A4Percent As Double
    Private Sub Up_Tick(sender As Object, e As EventArgs) Handles Up.Tick
        If Visible Then
            If A1.Size.Height < A1Size.Height Then
                A1.Size = New Size(A1.Size.Width, A1.Size.Height + 2)
            End If
            If CDbl(A1P.Text.Replace("%", "")) / 100 < A1Percent Then
                A1P.Text = (CDbl(A1P.Text.Replace("%", "")) + 1).ToString() + "%"
            End If

            If A2.Size.Height < A2Size.Height Then
                A2.Size = New Size(A2.Size.Width, A2.Size.Height + 2)
            End If
            If CDbl(A2P.Text.Replace("%", "")) / 100 < A2Percent Then
                A2P.Text = (CDbl(A2P.Text.Replace("%", "")) + 1).ToString() + "%"
            End If

            If A3.Size.Height < A3Size.Height Then
                A3.Size = New Size(A3.Size.Width, A3.Size.Height + 2)
            End If
            If CDbl(A3P.Text.Replace("%", "")) / 100 < A3Percent Then
                A3P.Text = (CDbl(A3P.Text.Replace("%", "")) + 1).ToString() + "%"
            End If

            If A4.Size.Height < A4Size.Height Then
                A4.Size = New Size(A4.Size.Width, A4.Size.Height + 2)
            End If
            If CDbl(A4P.Text.Replace("%", "")) / 100 < A4Percent Then
                A4P.Text = (CDbl(A4P.Text.Replace("%", "")) + 1).ToString() + "%"
            End If
        End If
    End Sub

    Private Sub HelpWatchers_Opened(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            Dim r As New Random()
            Dim AR As List(Of Integer) = New List(Of Integer)
            AR.Add(r.Next(101))
            AR.Add(r.Next(101))
            AR.Add(r.Next(101))
            AR.Add(r.Next(101))
            AR = AR.OrderBy(Function(x) x).ToList()

            If Qs.RightAnsI = 1 Then
                A1Size = New Size(A1.Size.Width, AR(3) / 100 * 535)
                A1Percent = AR(3) / 100

                A2Size = New Size(A2.Size.Width, AR(2) / 100 * 535)
                A2Percent = AR(2) / 100

                A3Size = New Size(A3.Size.Width, AR(1) / 100 * 535)
                A3Percent = AR(1) / 100

                A4Size = New Size(A4.Size.Width, AR(0) / 100 * 535)
                A4Percent = AR(0) / 100
            ElseIf Qs.RightAnsI = 2 Then
                A2Size = New Size(A2.Size.Width, AR(3) / 100 * 535)
                A2Percent = AR(3) / 100

                A3Size = New Size(A3.Size.Width, AR(2) / 100 * 535)
                A3Percent = AR(2) / 100

                A4Size = New Size(A4.Size.Width, AR(1) / 100 * 535)
                A4Percent = AR(1) / 100

                A1Size = New Size(A1.Size.Width, AR(0) / 100 * 535)
                A1Percent = AR(0) / 100
            ElseIf Qs.RightAnsI = 3 Then
                A3Size = New Size(A3.Size.Width, AR(3) / 100 * 535)
                A3Percent = AR(3) / 100

                A4Size = New Size(A4.Size.Width, AR(2) / 100 * 535)
                A4Percent = AR(2) / 100

                A1Size = New Size(A1.Size.Width, AR(1) / 100 * 535)
                A1Percent = AR(1) / 100

                A2Size = New Size(A2.Size.Width, AR(0) / 100 * 535)
                A2Percent = AR(0) / 100
            Else 'If Qs.RightAnsI = 4 Then
                A4Size = New Size(A4.Size.Width, AR(3) / 100 * 535)
                A4Percent = AR(3) / 100

                A1Size = New Size(A1.Size.Width, AR(2) / 100 * 535)
                A1Percent = AR(2) / 100

                A2Size = New Size(A2.Size.Width, AR(1) / 100 * 535)
                A2Percent = AR(1) / 100

                A3Size = New Size(A3.Size.Width, AR(0) / 100 * 535)
                A3Percent = AR(0) / 100
            End If
        End If
    End Sub
End Class