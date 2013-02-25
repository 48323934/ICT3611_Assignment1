<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.labelTransaction = New System.Windows.Forms.Label()
        Me.transactionNo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaskedTextBoxContact = New System.Windows.Forms.MaskedTextBox()
        Me.textBoxGuestName = New System.Windows.Forms.TextBox()
        Me.TextBoxAdults = New System.Windows.Forms.TextBox()
        Me.TextBoxSubTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxChildren = New System.Windows.Forms.TextBox()
        Me.roomNumber = New System.Windows.Forms.TextBox()
        Me.periodTextBox = New System.Windows.Forms.TextBox()
        Me.TextBoxDeposit = New System.Windows.Forms.TextBox()
        Me.TextBoxBalance = New System.Windows.Forms.TextBox()
        Me.checkInDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.checkOutDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.roomRate = New System.Windows.Forms.TextBox()
        Me.ButtonMinusAdult = New System.Windows.Forms.Button()
        Me.ButtonMinusChild = New System.Windows.Forms.Button()
        Me.ButtonPlusAdult = New System.Windows.Forms.Button()
        Me.ButtonPlusChild = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.sleeps = New System.Windows.Forms.TextBox()
        Me.ButtonSubmitReserve = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 24)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Reservation Form"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(590, 568)
        Me.ShapeContainer1.TabIndex = 32
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 34
        Me.LineShape2.X2 = 554
        Me.LineShape2.Y1 = 374
        Me.LineShape2.Y2 = 374
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 35
        Me.LineShape1.X2 = 555
        Me.LineShape1.Y1 = 50
        Me.LineShape1.Y2 = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Transaction no:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Guest Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(300, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "No. of Adults:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(300, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "No. of Children:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Room Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Check In Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(300, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Check Out Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "No. of Days:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 490)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Balance Due:"
        '
        'labelTransaction
        '
        Me.labelTransaction.AutoSize = True
        Me.labelTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTransaction.Location = New System.Drawing.Point(150, 80)
        Me.labelTransaction.Name = "labelTransaction"
        Me.labelTransaction.Size = New System.Drawing.Size(79, 16)
        Me.labelTransaction.TabIndex = 35
        Me.labelTransaction.Text = "Transaction"
        '
        'transactionNo
        '
        Me.transactionNo.AutoSize = True
        Me.transactionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionNo.Location = New System.Drawing.Point(30, 390)
        Me.transactionNo.Name = "transactionNo"
        Me.transactionNo.Size = New System.Drawing.Size(69, 16)
        Me.transactionNo.TabIndex = 25
        Me.transactionNo.Text = "Sub Total:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 440)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Deposit Due:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(337, 392)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 163)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'MaskedTextBoxContact
        '
        Me.MaskedTextBoxContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxContact.Location = New System.Drawing.Point(430, 127)
        Me.MaskedTextBoxContact.Mask = "000-000-0000"
        Me.MaskedTextBoxContact.Name = "MaskedTextBoxContact"
        Me.MaskedTextBoxContact.Size = New System.Drawing.Size(120, 22)
        Me.MaskedTextBoxContact.TabIndex = 3
        Me.MaskedTextBoxContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textBoxGuestName
        '
        Me.textBoxGuestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxGuestName.Location = New System.Drawing.Point(150, 127)
        Me.textBoxGuestName.Name = "textBoxGuestName"
        Me.textBoxGuestName.Size = New System.Drawing.Size(145, 22)
        Me.textBoxGuestName.TabIndex = 1
        '
        'TextBoxAdults
        '
        Me.TextBoxAdults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdults.Location = New System.Drawing.Point(150, 227)
        Me.TextBoxAdults.Name = "TextBoxAdults"
        Me.TextBoxAdults.ReadOnly = True
        Me.TextBoxAdults.Size = New System.Drawing.Size(35, 22)
        Me.TextBoxAdults.TabIndex = 12
        Me.TextBoxAdults.TabStop = False
        '
        'TextBoxSubTotal
        '
        Me.TextBoxSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSubTotal.Location = New System.Drawing.Point(150, 387)
        Me.TextBoxSubTotal.Name = "TextBoxSubTotal"
        Me.TextBoxSubTotal.ReadOnly = True
        Me.TextBoxSubTotal.Size = New System.Drawing.Size(79, 22)
        Me.TextBoxSubTotal.TabIndex = 26
        Me.TextBoxSubTotal.TabStop = False
        '
        'TextBoxChildren
        '
        Me.TextBoxChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxChildren.Location = New System.Drawing.Point(430, 227)
        Me.TextBoxChildren.Name = "TextBoxChildren"
        Me.TextBoxChildren.ReadOnly = True
        Me.TextBoxChildren.Size = New System.Drawing.Size(35, 22)
        Me.TextBoxChildren.TabIndex = 16
        Me.TextBoxChildren.TabStop = False
        '
        'roomNumber
        '
        Me.roomNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomNumber.Location = New System.Drawing.Point(150, 174)
        Me.roomNumber.Name = "roomNumber"
        Me.roomNumber.ReadOnly = True
        Me.roomNumber.Size = New System.Drawing.Size(79, 22)
        Me.roomNumber.TabIndex = 5
        Me.roomNumber.TabStop = False
        '
        'periodTextBox
        '
        Me.periodTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodTextBox.Location = New System.Drawing.Point(150, 327)
        Me.periodTextBox.Name = "periodTextBox"
        Me.periodTextBox.ReadOnly = True
        Me.periodTextBox.Size = New System.Drawing.Size(35, 22)
        Me.periodTextBox.TabIndex = 24
        Me.periodTextBox.TabStop = False
        '
        'TextBoxDeposit
        '
        Me.TextBoxDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDeposit.Location = New System.Drawing.Point(150, 437)
        Me.TextBoxDeposit.Name = "TextBoxDeposit"
        Me.TextBoxDeposit.ReadOnly = True
        Me.TextBoxDeposit.Size = New System.Drawing.Size(79, 22)
        Me.TextBoxDeposit.TabIndex = 28
        Me.TextBoxDeposit.TabStop = False
        '
        'TextBoxBalance
        '
        Me.TextBoxBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBalance.Location = New System.Drawing.Point(150, 487)
        Me.TextBoxBalance.Name = "TextBoxBalance"
        Me.TextBoxBalance.ReadOnly = True
        Me.TextBoxBalance.Size = New System.Drawing.Size(79, 22)
        Me.TextBoxBalance.TabIndex = 30
        Me.TextBoxBalance.TabStop = False
        '
        'checkInDateTimePicker
        '
        Me.checkInDateTimePicker.Location = New System.Drawing.Point(150, 277)
        Me.checkInDateTimePicker.Name = "checkInDateTimePicker"
        Me.checkInDateTimePicker.Size = New System.Drawing.Size(130, 20)
        Me.checkInDateTimePicker.TabIndex = 20
        '
        'checkOutDateTimePicker
        '
        Me.checkOutDateTimePicker.Location = New System.Drawing.Point(430, 277)
        Me.checkOutDateTimePicker.Name = "checkOutDateTimePicker"
        Me.checkOutDateTimePicker.Size = New System.Drawing.Size(130, 20)
        Me.checkOutDateTimePicker.TabIndex = 22
        Me.checkOutDateTimePicker.Value = New Date(2013, 2, 20, 15, 34, 5, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(276, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "RoomRate:"
        '
        'roomRate
        '
        Me.roomRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomRate.Location = New System.Drawing.Point(364, 174)
        Me.roomRate.Name = "roomRate"
        Me.roomRate.ReadOnly = True
        Me.roomRate.Size = New System.Drawing.Size(65, 22)
        Me.roomRate.TabIndex = 8
        Me.roomRate.TabStop = False
        '
        'ButtonMinusAdult
        '
        Me.ButtonMinusAdult.Location = New System.Drawing.Point(204, 227)
        Me.ButtonMinusAdult.Name = "ButtonMinusAdult"
        Me.ButtonMinusAdult.Size = New System.Drawing.Size(25, 25)
        Me.ButtonMinusAdult.TabIndex = 13
        Me.ButtonMinusAdult.Text = "<"
        Me.ButtonMinusAdult.UseVisualStyleBackColor = True
        '
        'ButtonMinusChild
        '
        Me.ButtonMinusChild.Location = New System.Drawing.Point(484, 227)
        Me.ButtonMinusChild.Name = "ButtonMinusChild"
        Me.ButtonMinusChild.Size = New System.Drawing.Size(25, 25)
        Me.ButtonMinusChild.TabIndex = 17
        Me.ButtonMinusChild.Text = "<"
        Me.ButtonMinusChild.UseVisualStyleBackColor = True
        '
        'ButtonPlusAdult
        '
        Me.ButtonPlusAdult.Location = New System.Drawing.Point(235, 227)
        Me.ButtonPlusAdult.Name = "ButtonPlusAdult"
        Me.ButtonPlusAdult.Size = New System.Drawing.Size(25, 25)
        Me.ButtonPlusAdult.TabIndex = 14
        Me.ButtonPlusAdult.Text = ">"
        Me.ButtonPlusAdult.UseVisualStyleBackColor = True
        '
        'ButtonPlusChild
        '
        Me.ButtonPlusChild.Location = New System.Drawing.Point(515, 227)
        Me.ButtonPlusChild.Name = "ButtonPlusChild"
        Me.ButtonPlusChild.Size = New System.Drawing.Size(25, 25)
        Me.ButtonPlusChild.TabIndex = 18
        Me.ButtonPlusChild.Text = ">"
        Me.ButtonPlusChild.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(235, 174)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 25)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(450, 180)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 16)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Sleeps:"
        '
        'sleeps
        '
        Me.sleeps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sleeps.Location = New System.Drawing.Point(515, 174)
        Me.sleeps.Name = "sleeps"
        Me.sleeps.ReadOnly = True
        Me.sleeps.Size = New System.Drawing.Size(35, 22)
        Me.sleeps.TabIndex = 10
        Me.sleeps.TabStop = False
        '
        'ButtonSubmitReserve
        '
        Me.ButtonSubmitReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubmitReserve.Location = New System.Drawing.Point(70, 535)
        Me.ButtonSubmitReserve.Name = "ButtonSubmitReserve"
        Me.ButtonSubmitReserve.Size = New System.Drawing.Size(126, 23)
        Me.ButtonSubmitReserve.TabIndex = 31
        Me.ButtonSubmitReserve.Text = "Make &Reservation"
        Me.ButtonSubmitReserve.UseVisualStyleBackColor = True
        '
        'Reservation
        '
        Me.AcceptButton = Me.ButtonSubmitReserve
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(590, 568)
        Me.Controls.Add(Me.ButtonSubmitReserve)
        Me.Controls.Add(Me.sleeps)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ButtonPlusChild)
        Me.Controls.Add(Me.ButtonPlusAdult)
        Me.Controls.Add(Me.ButtonMinusChild)
        Me.Controls.Add(Me.ButtonMinusAdult)
        Me.Controls.Add(Me.roomRate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.checkOutDateTimePicker)
        Me.Controls.Add(Me.checkInDateTimePicker)
        Me.Controls.Add(Me.TextBoxBalance)
        Me.Controls.Add(Me.TextBoxDeposit)
        Me.Controls.Add(Me.periodTextBox)
        Me.Controls.Add(Me.roomNumber)
        Me.Controls.Add(Me.TextBoxChildren)
        Me.Controls.Add(Me.TextBoxSubTotal)
        Me.Controls.Add(Me.TextBoxAdults)
        Me.Controls.Add(Me.textBoxGuestName)
        Me.Controls.Add(Me.MaskedTextBoxContact)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.transactionNo)
        Me.Controls.Add(Me.labelTransaction)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reservation"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blue Marlin Reservations"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents labelTransaction As System.Windows.Forms.Label
    Friend WithEvents transactionNo As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MaskedTextBoxContact As System.Windows.Forms.MaskedTextBox
    Friend WithEvents textBoxGuestName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAdults As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxChildren As System.Windows.Forms.TextBox
    Friend WithEvents roomNumber As System.Windows.Forms.TextBox
    Friend WithEvents periodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDeposit As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBalance As System.Windows.Forms.TextBox
    Friend WithEvents checkInDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents checkOutDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents roomRate As System.Windows.Forms.TextBox
    Friend WithEvents ButtonMinusAdult As System.Windows.Forms.Button
    Friend WithEvents ButtonMinusChild As System.Windows.Forms.Button
    Friend WithEvents ButtonPlusAdult As System.Windows.Forms.Button
    Friend WithEvents ButtonPlusChild As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents sleeps As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSubmitReserve As System.Windows.Forms.Button
End Class
