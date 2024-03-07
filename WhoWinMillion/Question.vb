<Serializable()>
Public Class Question
    Public Function GetQIndex() As String
        Return Q.Text
    End Function

    Public Sub SetQIndex(Value As Integer)
        If Value = 1 Then
            QL.Text = "السؤال الأول:"
        ElseIf Value = 2 Then
            QL.Text = "السؤال الثاني:"
        ElseIf Value = 3 Then
            QL.Text = "السؤال الثالث:"
        ElseIf Value = 4 Then
            QL.Text = "السؤال الرابع:"
        ElseIf Value = 5 Then
            QL.Text = "السؤال الخامس:"
        ElseIf Value = 6 Then
            QL.Text = "السؤال السادس:"
        ElseIf Value = 7 Then
            QL.Text = "السؤال السابع:"
        ElseIf Value = 8 Then
            QL.Text = "السؤال الثامن:"
        ElseIf Value = 9 Then
            QL.Text = "السؤال التاسع:"
        ElseIf Value = 10 Then
            QL.Text = "السؤال العاشر:"
        ElseIf Value = 11 Then
            QL.Text = "السؤال الحادي عشر:"
        ElseIf Value = 12 Then
            QL.Text = "السؤال الثاني عشر:"
        ElseIf Value = 13 Then
            QL.Text = "السؤال الثالث عشر:"
        ElseIf Value = 14 Then
            QL.Text = "السؤال الرابع عشر:"
        ElseIf Value = 15 Then
            QL.Text = "السؤال الخامس عشر:"
        End If
    End Sub

    Public Function IsAllFilled() As Boolean
        Return Not (A1.Text = "" And A2.Text = "" And A3.Text = "" And A4.Text = "" And RA.SelectedIndex = -1)
    End Function
End Class
