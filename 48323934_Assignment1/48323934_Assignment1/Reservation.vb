Public Class Reservation
   
    Private Sub Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Activate()

        ' Set focus to Guest Name
        guestName.Focus()


        ' I have added this feature to update where you are in the statusbar.
        HomeScreen.ToolStripStatusLabel1.Text = "Guest making a Reservation"

        ' On loading this form I have set the checkout datetimepicker to tomorrows date to make the minimum booking 1 day
        checkOutDateTimePicker.Value = checkInDateTimePicker.Value.Date.AddDays(1)

    End Sub

    Private Sub Reservation_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ' I added this to change the status back to the welcome screen when returning from other windows
        HomeScreen.ToolStripStatusLabel1.Text = "Welcome to Blue Marlin Hotel System"

    End Sub

    Private Sub checkOutDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkOutDateTimePicker.ValueChanged
        Dim period As TimeSpan = checkOutDateTimePicker.Value - checkInDateTimePicker.Value
        ' test.Text = period.Days       ' with this test code I realised I had to add the +1 to the period.Days
        ' I have set this conditional statement to ensure you can not pick a date before today and if you do will change it automatically
        If period.Days < 1 Then
            checkOutDateTimePicker.Value = checkInDateTimePicker.Value.Date.AddDays(1)
            periodTextBox.Text = "1"
        Else
            ' Had to add the +1 to ave the correct number of days
            periodTextBox.Text = period.Days + 1

        End If
        
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        roomBookings.ShowDialog()

    End Sub
End Class