Public Class Reservation

    Private Sub Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' I have added this feature to update where you are in the statusbar.
        HomeScreen.ToolStripStatusLabel1.Text = "Guest making a Reservation"

    End Sub

    Private Sub Reservation_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ' I added this to change the status back to the welcome screen when returning from other windows
        HomeScreen.ToolStripStatusLabel1.Text = "Welcome to Blue Marlin Hotel System"

    End Sub
End Class