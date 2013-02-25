Module GlobalVar
    ' My Global variables
    ' I have set a two dimensional array to access the room number, how many it sleeps and price per room
    ' I have on purpose displayed the array as below to easier grasp the row and column concept
    ' Still playing and testing with this
    Public Rooms(,) As String = {{1, 220, "Room 101"},
                                  {2, 400, "Room 102"},
                                  {3, 580, "Room 103"},
                                  {4, 750, "Room 104"},
                                  {5, 1000, "Room 105"}}

    ' A Global transaction number variable as it will be used in various windows
    Public transaction As Integer = 1001

    ' Global variables for reporting on rooms and to check if room is occupied
    ' This will still change busy working on an alternative.
    Public Room101() As String
    Public Room102() As String
    Public Room103() As String
    Public Room104() As String
    Public Room105() As String

    ' 

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
        Reservation.textBoxGuestName.Focus()

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

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ' Opens the reservation window and sets focus on input field
        Reservation.ShowDialog()
        Reservation.Focus()

    End Sub

End Class
