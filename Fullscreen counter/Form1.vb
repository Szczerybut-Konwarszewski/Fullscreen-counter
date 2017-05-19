Public Class main_window

    ' DECLARING VARIABLES
    Dim c_window_seconds = -1
    Dim c_window_minutes = 0
    Dim c_window_hours = 0

    ' SETTING VISUAL PROPERTIES OF COUNTER

    Private Sub main_window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Timer1.Start()

        toCenter()

    End Sub

    Sub toCenter()
        ' This windows sets position of c_window text box to center
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim init_text As String = "0" & c_window_hours & ":" & "0" & c_window_minutes & ":" & c_window_seconds

        c_window_seconds = c_window_seconds + 1

        If c_window_seconds = 60 Then

            c_window_seconds = 0
            c_window_minutes += 1
        End If
        If c_window_seconds < 10 Then c_window_seconds = "0" & c_window_seconds
        c_label.Text = init_text
    End Sub

End Class
