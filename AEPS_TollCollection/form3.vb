Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types

Public Class Form3
    Private conn As OracleConnection



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MessageBox.Show("Loading Form1")
            conn = New OracleConnection("Data Source=XE;User Id=system;password=666")
            MessageBox.Show("loading form1 done")

        Catch ex As Exception
            MessageBox.Show("not connected")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim da As OracleDataAdapter
            Dim ds As DataSet = New DataSet
            Dim dt As DataTable
            Dim dr As DataRow
            Dim ans As Integer
            da = New OracleDataAdapter("Select * from murfin", conn)
            Dim auto As New OracleCommandBuilder(da)
            da.Fill(ds, "murfin")
            dt = ds.Tables(0)
            dr = dt.NewRow
            dr.Item(0) = TextBox1.Text
            dr.Item(1) = TextBox2.Text
            dr.Item(2) = TextBox3.Text
            dr.Item(3) = TextBox4.Text
            ans = 2000 - dr.Item(3)
            dt.Rows.Add(dr)

            da.Update(ds, "murfin")
            MessageBox.Show("Record inserted")
            MessageBox.Show("The balance is" & ans)
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Try
            Try
                Dim da As OracleDataAdapter
                Dim ds As DataSet = New DataSet
                Dim dt As DataTable
                Dim dr As DataRow
                da = New OracleDataAdapter("select * from murfin where name ='" & TextBox1.Text & "'", conn)
                Dim auto As New OracleCommandBuilder(da)
                da.Fill(ds, "murfin")
                dt = ds.Tables(0)
                For Each dr In dt.Rows
                    Me.TextBox1.Text = dr.Item(0)
                    Me.TextBox2.Text = dr.Item(1)
                    Me.TextBox3.Text = dr.Item(2)

                Next
                conn.Close()
                Me.Show()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Catch ex As Exception
            MsgBox(" not connected")

        End Try
    End Sub
End Class
