Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Mynumber As Integer
        Dim isEven As Boolean
        Dim isOdd As Boolean
        Mynumber = Val(TextBox1.Text)
        If Mynumber Mod 2 = 0 Then
            isEven = True
            MsgBox("The number " & " " & Mynumber & " is an even number")
        ElseIf Mynumber Mod 2 <> 0 Or Mynumber Mod 2 = 0 Then
            isOdd = True
            MsgBox("The number " & " " & Mynumber & " is an odd number")

        Else
            MsgBox(Mynumber & " " & "is an Prime number")
        End If

    End Sub
End Class
