Imports System.Net.Sockets

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim C As New TcpClient
        C.Connect(hostname:=host.Text, port:=port.Text)

        Dim S As NetworkStream
        S = C.GetStream


        Dim Buffer As Byte()
        Buffer = System.Text.Encoding.ASCII.GetBytes(Data.text)


        S.Write(Buffer, 0, Buffer.Length)

        C.Close()

        MsgBox("OK")


    End Sub

End Class
