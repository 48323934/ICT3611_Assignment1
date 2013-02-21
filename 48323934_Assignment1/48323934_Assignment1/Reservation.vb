Public Class Reservation
   
    Private Sub Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Show()
        Me.Activate()

        ' Display transaction number
        labelTransaction.Text = GlobalVar.transaction

        ' Set focus to Guest Name
        textBoxGuestName.Focus()


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

    Private Sub ButtonPlusAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlusAdult.Click
        Dim total As Integer
        total = Val(TextBoxAdults.Text) + Val(TextBoxChildren.Text)
        If total = Val(sleeps.Text) Then

        Else
            TextBoxAdults.Text = Val(TextBoxAdults.Text) + 1
        End If

    End Sub

    Private Sub ButtonPlusChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlusChild.Click
        Dim total As Integer
        total = Val(TextBoxAdults.Text) + Val(TextBoxChildren.Text)
        If total = Val(sleeps.Text) Then

        Else
            TextBoxChildren.Text = Val(TextBoxChildren.Text) + 1
        End If

    End Sub

    Private Sub ButtonMinusAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMinusAdult.Click
        If Val(TextBoxAdults.Text) = 0 Then
            TextBoxAdults.Text = Val(TextBoxAdults.Text)
        Else
            TextBoxAdults.Text = Val(TextBoxAdults.Text) - 1
        End If

    End Sub

    Private Sub ButtonMinusChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMinusChild.Click
        If Val(TextBoxChildren.Text) = 0 Then
            TextBoxChildren.Text = Val(TextBoxChildren.Text)
        Else
            TextBoxChildren.Text = Val(TextBoxChildren.Text) - 1
        End If

    End Sub

    Private Sub sleeps_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sleeps.TextChanged
        TextBoxSubTotal.Text = Val(roomRate.Text) * Val(periodTextBox.Text)
        Dim total As Integer
        total = Val(TextBoxAdults.Text) + Val(TextBoxChildren.Text)
        If total > Val(sleeps.Text) Then
            TextBoxAdults.Text = "0"
            TextBoxChildren.Text = "0"
        End If

    End Sub

    Private Sub periodTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles periodTextBox.TextChanged
        TextBoxSubTotal.Text = Val(roomRate.Text) * Val(periodTextBox.Text)

    End Sub

    Private Sub TextBoxSubTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSubTotal.TextChanged
        TextBoxDeposit.Text = Val(TextBoxSubTotal.Text / 2)
        TextBoxBalance.Text = Val(TextBoxSubTotal.Text) - Val(TextBoxDeposit.Text)

    End Sub

    Private Sub ButtonSubmitReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubmitReserve.Click
        ' Variables to be used in if statement
        Dim removedDash As String = MaskedTextBoxContact.Text.Replace("-", "")
        Dim adultVal As Integer = Val(TextBoxAdults.Text)

        ' I have made the conditional statements below to verify fields are correctly entered before saving to Variables
        If textBoxGuestName.Text = "" Then
            MsgBox("Please enter the Guest Name!", , "Input Error!")
        ElseIf removedDash.Length <> 10 Then
            MsgBox("Please enter a correct 10 digit Contact number!", , "Input Error!")
        ElseIf roomNumber.Text = "" Then
            MsgBox("Please select a Room!", , "Input Error!")
        ElseIf TextBoxAdults.Text = "" OrElse adultVal < 1 Then
            MsgBox("This booking should contain at least 1 Adult!", , "Input Error!")
        Else
            ' Add one to the transaction number
            GlobalVar.transaction = GlobalVar.transaction + 1
            ' Saving the information to Global Variables to be extracted for reporting later.



            ' Clear all the fields for the next entries, this is a shortcut to clear all textboxes but I did not
            ' want to clear the textboxsubtotal as a textchange is linked to it and it will give an error so I
            ' included the nested if for the textboxsubtotal that it does nothing on that
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    If ctrl Is TextBoxSubTotal Then

                    Else
                        CType(ctrl, TextBox).Text = String.Empty
                    End If
                End If
            Next ctrl

            ' Clear the maskedtextbox seperately
            MaskedTextBoxContact.Text = String.Empty

            ' Close window once completed
            Me.Close()
        End If

    End Sub
End Class