Public Class Form1

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' When About in menubar is clicked it will show the aboutbox
        AboutBox1.ShowDialog()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Used this to display the date in format:     on the top right of the menu bar
        Me.Label1.Text = DateString

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' A simple clock to display on the top right of the menu bar
        Me.Label2.Text = TimeString ' Could use timeofday aswell but TimeString gives 24 hour display.

    End Sub
End Class
