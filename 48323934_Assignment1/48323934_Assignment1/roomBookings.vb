Public Class roomBookings

    Private Sub roomBookings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = GlobalVar.Rooms(0, 0)
        TextBox2.Text = GlobalVar.Rooms(1, 0)
        TextBox3.Text = GlobalVar.Rooms(2, 0)
        TextBox4.Text = GlobalVar.Rooms(3, 0)
        TextBox5.Text = GlobalVar.Rooms(4, 0)
        TextBox6.Text = GlobalVar.Rooms(0, 1)
        TextBox7.Text = GlobalVar.Rooms(1, 1)
        TextBox8.Text = GlobalVar.Rooms(2, 1)
        TextBox9.Text = GlobalVar.Rooms(3, 1)
        TextBox10.Text = GlobalVar.Rooms(4, 1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Reservation.roomNumber.Text = Button1.Text
        Reservation.roomRate.Text = TextBox6.Text
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Reservation.roomNumber.Text = Button2.Text
        Reservation.roomRate.Text = TextBox7.Text
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Reservation.roomNumber.Text = Button3.Text
        Reservation.roomRate.Text = TextBox8.Text
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Reservation.roomNumber.Text = Button4.Text
        Reservation.roomRate.Text = TextBox9.Text
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Reservation.roomNumber.Text = Button5.Text
        Reservation.roomRate.Text = TextBox10.Text
        Me.Close()

    End Sub
End Class