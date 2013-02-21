Public Class roomBookings

    Private Sub roomBookings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' set the textboxt.text properties from the global array. 
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
        ' set the button.text properties from the global array
        Button1.Text = GlobalVar.Rooms(0, 2)
        Button2.Text = GlobalVar.Rooms(1, 2)
        Button3.Text = GlobalVar.Rooms(2, 2)
        Button4.Text = GlobalVar.Rooms(3, 2)
        Button5.Text = GlobalVar.Rooms(4, 2)

        ' Check if rooms are available or occupied by checking if the room arrays are empty with conditional statements below
        If GlobalVar.Room101 Is Nothing Then
            Me.Button1.Enabled = True
        Else
            Me.Button1.Enabled = False
        End If

        If GlobalVar.Room102 Is Nothing Then
            Me.Button2.Enabled = True
        Else
            Me.Button2.Enabled = False
        End If

        If GlobalVar.Room103 Is Nothing Then
            Me.Button3.Enabled = True
        Else
            Me.Button3.Enabled = False
        End If

        If GlobalVar.Room104 Is Nothing Then
            Me.Button4.Enabled = True
        Else
            Me.Button4.Enabled = False
        End If

        If GlobalVar.Room105 Is Nothing Then
            Me.Button5.Enabled = True
        Else
            Me.Button5.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' When this button is clicked it updates the roomnumber.text, roomrate.text and sleeps.text fields in the reservation window
        Reservation.roomNumber.Text = Button1.Text
        Reservation.roomRate.Text = TextBox6.Text
        Reservation.sleeps.Text = TextBox1.Text
        ' Once clicked it also closes the current roomBookings window
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' When this button is clicked it updates the roomnumber.text, roomrate.text and sleeps.text fields in the reservation window
        Reservation.roomNumber.Text = Button2.Text
        Reservation.roomRate.Text = TextBox7.Text
        Reservation.sleeps.Text = TextBox2.Text
        ' Once clicked it also closes the current roomBookings window
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' When this button is clicked it updates the roomnumber.text, roomrate.text and sleeps.text fields in the reservation window
        Reservation.roomNumber.Text = Button3.Text
        Reservation.roomRate.Text = TextBox8.Text
        Reservation.sleeps.Text = TextBox3.Text
        ' Once clicked it also closes the current roomBookings window
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' When this button is clicked it updates the roomnumber.text, roomrate.text and sleeps.text fields in the reservation window
        Reservation.roomNumber.Text = Button4.Text
        Reservation.roomRate.Text = TextBox9.Text
        Reservation.sleeps.Text = TextBox4.Text
        ' Once clicked it also closes the current roomBookings window
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ' When this button is clicked it updates the roomnumber.text, roomrate.text and sleeps.text fields in the reservation window
        Reservation.roomNumber.Text = Button5.Text
        Reservation.roomRate.Text = TextBox10.Text
        Reservation.sleeps.Text = TextBox5.Text
        ' Once clicked it also closes the current roomBookings window
        Me.Close()

    End Sub
End Class