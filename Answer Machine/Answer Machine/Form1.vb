Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            Tanswer.Text = "Ask A Question!"
        ElseIf TextBox1.Text = "" Then
            Tanswer.Text = "I Will Not Answer You!"
        ElseIf TextBox2.Text = "" Then
            Tanswer.Text = "Ask A Question!"
        Else
            Tanswer.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Tanswer.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Helpbtn.Click
        MsgBox("You Have To Enter The Answer behind The Question's Felt", 64, "Help To Get Answer")
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
