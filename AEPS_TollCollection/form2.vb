Option Explicit On
Public Class Form2
    Dim sapi As Object
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
        sapi = CreateObject("sapi.spvoice")

        sapi.speak("THANK YOU FOR EARLY REGISTRATION")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        sapi = CreateObject("sapi.spvoice")
        sapi.speak("SORRY STILL ONE MORE STEP NEEDED FOR TRANSACTION")
        MessageBox.Show("PLEASE REGISTER YOUR AADHAR WITH BANK")

    End Sub
End Class
