<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeScreen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReserveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.checkinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.checkoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckedInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckedOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1086, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReserveToolStripMenuItem, Me.checkinToolStripMenuItem, Me.checkoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ReserveToolStripMenuItem
        '
        Me.ReserveToolStripMenuItem.Name = "ReserveToolStripMenuItem"
        Me.ReserveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReserveToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ReserveToolStripMenuItem.Text = "Reservation"
        '
        'checkinToolStripMenuItem
        '
        Me.checkinToolStripMenuItem.Name = "checkinToolStripMenuItem"
        Me.checkinToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.checkinToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.checkinToolStripMenuItem.Text = "Check-in"
        '
        'checkoutToolStripMenuItem
        '
        Me.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem"
        Me.checkoutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.checkoutToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.checkoutToolStripMenuItem.Text = "Check-out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuestToolStripMenuItem, Me.RoomToolStripMenuItem})
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'GuestToolStripMenuItem
        '
        Me.GuestToolStripMenuItem.Name = "GuestToolStripMenuItem"
        Me.GuestToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.GuestToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.GuestToolStripMenuItem.Text = "Guest Profile"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.RoomToolStripMenuItem.Text = "Room Details"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'dateLabel
        '
        Me.dateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.Location = New System.Drawing.Point(715, 3)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(360, 20)
        Me.dateLabel.TabIndex = 1
        Me.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckedInToolStripMenuItem, Me.CheckedOutToolStripMenuItem, Me.RoomsToolStripMenuItem, Me.ReservationsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'CheckedInToolStripMenuItem
        '
        Me.CheckedInToolStripMenuItem.Name = "CheckedInToolStripMenuItem"
        Me.CheckedInToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CheckedInToolStripMenuItem.Text = "Checked In"
        '
        'CheckedOutToolStripMenuItem
        '
        Me.CheckedOutToolStripMenuItem.Name = "CheckedOutToolStripMenuItem"
        Me.CheckedOutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CheckedOutToolStripMenuItem.Text = "Checked Out"
        '
        'RoomsToolStripMenuItem
        '
        Me.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem"
        Me.RoomsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RoomsToolStripMenuItem.Text = "Rooms"
        '
        'ReservationsToolStripMenuItem
        '
        Me.ReservationsToolStripMenuItem.Name = "ReservationsToolStripMenuItem"
        Me.ReservationsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReservationsToolStripMenuItem.Text = "Reservations"
        '
        'HomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1086, 654)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HomeScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blue Marlin Hotel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReserveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents checkinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents checkoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckedInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckedOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
