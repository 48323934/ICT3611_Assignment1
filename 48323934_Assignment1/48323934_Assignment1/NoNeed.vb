Public Class NoNeed

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub NoNeed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' I have added this feature to update where you are in the statusbar.
        HomeScreen.ToolStripStatusLabel1.Text = "No Need for this"

    End Sub

    Private Sub Button1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.LostFocus
        ' I added this to change the status back to the welcome screen when returning from other windows
        ' I could alternativly of added this to the close button above .
        HomeScreen.ToolStripStatusLabel1.Text = "Welcome to Blue Marlin Hotel System"

    End Sub
End Class