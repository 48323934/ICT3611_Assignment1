Module GlobalVar
    ' My Global variables
    ' I have set a two dimensional array to access the room number, how many it sleeps and price per room
    ' I have on purpose displayed the array as below to easier grasp the row and column concept
    ' Still playing and testing with this
    Public Rooms(,) As Integer = {{1, 220},
                                  {2, 400},
                                  {3, 580},
                                  {4, 750},
                                  {5, 1000}}

End Module

Public Class HomeScreen

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Activate()

        ' I have added this feature to update where you are in the statusbar.
        Me.ToolStripStatusLabel1.Text = "Welcome to Blue Marlin Hotel System"

    End Sub

    Private Sub ClockTimer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClockTimer1.Tick
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

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        ' Opens the CheckOut window and sets focus on input field
        CheckOut.ShowDialog()
        CheckOut.Focus()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ' Opens the CheckIn window and sets focus on input field
        CheckIn.ShowDialog()
        CheckIn.Focus()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ' Opens the reservation window and sets focus on input field
        Reservation.ShowDialog()
        Reservation.Focus()

    End Sub

End Class
