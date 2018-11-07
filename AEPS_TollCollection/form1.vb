mports Oracle.ManagedDataAccess.Client
Public Class Form1
    Dim sapi As Object
   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sapi = CreateObject("sapi.spvoice")
        sapi.speak("WELCOME TO THE AEPS LINKED TOLL COLLECTION SYSTEM")
        sapi.speak("Enter the username and password")
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "adithiya" And TextBox2.Text = "12345" Then
            form2.show()
            Me.Hide()
        End If
    End Sub
End Class
