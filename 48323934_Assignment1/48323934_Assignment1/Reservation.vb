Public Class Reservation
   
    Private Sub Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Show()
        Me.Activate()

        ' Display transaction number
        labelTransaction.Text = GlobalVar.transaction

        ' Set focus to Guest Name
        textBoxGuestName.Focus()

        ' period textbox will always start as 1
        periodTextBox.Text = "1"

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
        ' set period as a timespan variable
        Dim period As TimeSpan = checkOutDateTimePicker.Value - checkInDateTimePicker.Value

        ' First assertion test
        'Debug.Assert(period.Days <> "", "period.days can not be zero")
        'Trace.Assert(period.Days <= 1, "period.days can not be zero")

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
        ' This will open the roomBookings window
        roomBookings.ShowDialog()

    End Sub

    Private Sub ButtonPlusAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlusAdult.Click
        ' Buttons created to add to the adults total
        ' The total is number in adults + the number in children
        Dim total As Integer
        total = Val(TextBoxAdults.Text) + Val(TextBoxChildren.Text)
        ' First check if total above is equal to the number that the room can sleep and if it is do nothing
        If total = Val(sleeps.Text) Then

            ' if it is not then add 1
        Else
            ' I am using this Try Catch to fix the problem and this time without a msgbox notification.
            ' I found the error during testing to be that if the textbox is blank it gives an error, therefore in the catch allocating
            ' a value of zero to the textbox before running the function. This could of been prevented by defensive programming
            ' by adding the value to the textbox on load but this is done for purpose of the excersise.
            Try
                TextBoxAdults.Text = addGuest(TextBoxAdults.Text)
            Catch ex As Exception
                TextBoxAdults.Text = 0
                TextBoxAdults.Text = addGuest(TextBoxAdults.Text)
            End Try

        End If

    End Sub

    Private Sub ButtonPlusChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlusChild.Click
        ' Explanation the same as above
        Dim total As Integer
        total = Val(TextBoxAdults.Text) + Val(TextBoxChildren.Text)
        If total = Val(sleeps.Text) Then

        Else
            ' Above I made use of the addGuest Function, I could of done it here as well but wanted to show the alternate
            ' method which would of been fine for this small program but the function is much better for bigger more complicated progs.
            TextBoxChildren.Text = Val(TextBoxChildren.Text) + 1
        End If

    End Sub

    Private Sub ButtonMinusAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMinusAdult.Click
        ' if the adults box = 0 then it will remain 0 nothing else done as if you had to minus from 0 it would be a negative amount
        If Val(TextBoxAdults.Text) = 0 Then
            TextBoxAdults.Text = Val(TextBoxAdults.Text)
            ' if it is not zero it could deduct without going into a negative amount
        Else
            TextBoxAdults.Text = subtractGuest(TextBoxAdults.Text)
        End If

    End Sub

    Private Sub ButtonMinusChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMinusChild.Click
        ' Explanation the same as above
        If Val(TextBoxChildren.Text) = 0 Then
            TextBoxChildren.Text = Val(TextBoxChildren.Text)
        Else
            TextBoxChildren.Text = subtractGuest(TextBoxChildren.Text)
        End If

    End Sub

    Private Sub sleeps_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sleeps.TextChanged
        TextBoxSubTotal.Text = Val(roomRate.Text) * Val(periodTextBox.Text)
        ' I have added the code below as while I was testing my app I relised that on changing the room from a 5 sleep to a 3 sleep
        ' for example it would not change the adult and children text boxes, I therefore reset them to zero
        Dim total As Integer
        total = Val(TextBoxAdults.Text) + Val(TextBoxChildren.Text)
        If total > Val(sleeps.Text) Then
            TextBoxAdults.Text = "0"
            TextBoxChildren.Text = "0"
        End If

    End Sub

    Private Sub periodTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles periodTextBox.TextChanged
        ' when using the datetimepicker the total days(period) changes and as that changes the subtotal changes as well
        TextBoxSubTotal.Text = Val(roomRate.Text) * Val(periodTextBox.Text)

    End Sub

    Private Sub TextBoxSubTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSubTotal.TextChanged
        Dim Retries As Short = 0

        Try
            TextBoxDeposit.Text = Val(TextBoxSubTotal.Text / 2)
        Catch ex As Exception
            Retries += 1
            ' I have only put this messagebox in for the purpose of the excersise. I would not do it this way normally.
            ' I would use the nested if statement below within the loop.
            If Retries >= 2 Then
                MsgBox("Field Error for excersise purpose only!!", , "Devide by zero Error!")
            Else
                MsgBox("Your Reservation has been placed.", , "Reservations")

            End If

        End Try

        TextBoxBalance.Text = Val(TextBoxSubTotal.Text) - Val(TextBoxDeposit.Text)

    End Sub

    Private Sub ButtonSubmitReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubmitReserve.Click
        ' Second assertion test
        Debug.Assert(textBoxGuestName.Text <> "", "can not be empty")

        ' Third assertion test
        Debug.Assert(MaskedTextBoxContact.Text <> "", "can not be empty")

        ' Create the booked rooms
        If roomNumber.Text = "Room 101" Then
            GlobalVar.Room101 = True
        ElseIf roomNumber.Text = "Room 102" Then
            GlobalVar.Room102 = True
        ElseIf roomNumber.Text = "Room 103" Then
            GlobalVar.Room103 = True
        ElseIf roomNumber.Text = "Room 104" Then
            GlobalVar.Room104 = True
        ElseIf roomNumber.Text = "Room 105" Then
            GlobalVar.Room105 = True

        End If

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

            ' Clear all the fields for the next entries, this is a shortcut to clear all textboxes but I did not
            ' want to clear the textboxsubtotal as a textchange is linked to it and it will give an error so I
            ' included the nested if for the textboxsubtotal that it does nothing on that
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    ' When This is added my Try and Catch would not execute.
                    'If ctrl Is TextBoxSubTotal Then

                    'Else
                    'CType(ctrl, TextBox).Text = String.Empty
                    'End If
                    ' if the above nested if statement is included and not commented I would exclude and comment this line
                    CType(ctrl, TextBox).Text = String.Empty
                End If
            Next ctrl

            ' Clear the maskedtextbox seperately
            Me.MaskedTextBoxContact.Text = String.Empty


            ' Close window once completed
            Me.Close()
        End If

    End Sub

    Private Sub checkInDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkInDateTimePicker.ValueChanged
        ' I found this nice and short piece of code to prevent the user picking a date before todays date.
        checkInDateTimePicker.MinDate = Now

    End Sub
End Class