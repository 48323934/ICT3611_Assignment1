Public Class HomeScreen

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Used this to display the date in format: MMMM dd, yyyy  on the top right of the menu bar
        

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' A simple clock to display on the top right of the menu bar
        Dim datenow As Date = Now
        Me.dateLabel.Text = datenow.ToString("dddd, MMMM dd, yyyy.       HH:mm:ss tt")

    End Sub

    Private Sub ReserveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReserveToolStripMenuItem.Click
        ' Opens the reservation window and sets focus on input field
        Reservation.ShowDialog()
        Reservation.Focus()

    End Sub

    Private Sub checkinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkinToolStripMenuItem.Click
        ' Opens the CheckIn window and sets focus on input field
        CheckIn.ShowDialog()
        CheckIn.Focus()

    End Sub

    Private Sub checkoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkoutToolStripMenuItem.Click
        ' Opens the CheckOut window and sets focus on input field
        CheckOut.ShowDialog()
        CheckOut.Focus()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Closes the program
        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' Opens the About box window
        AboutBox1.ShowDialog()

    End Sub

    Private Sub GuestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestToolStripMenuItem.Click
        NoNeed.ShowDialog()

    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        NoNeed.ShowDialog()

    End Sub
End Class
