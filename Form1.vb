Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer
        Dim a As Integer
        Dim b As Integer
        Label4.Visible = True
        If TextBox1.Text = "" Then
            Label4.Visible = False
            MessageBox.Show("Sorry, box cannot be empty.")
            TextBox1.Focus()
        End If
        If TextBox1.Text = "" Then
            Label4.Visible = False
            MessageBox.Show("Sorry, box cannot be empty.")
            TextBox1.Focus()
        End If
        a = (TextBox1.Text)
        b = (TextBox2.Text)
        sum = (a + b)
        Label4.Text = "The Sum of " & a & " and " & b & " is " & sum & "."
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
