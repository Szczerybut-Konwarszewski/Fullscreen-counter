<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_window
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.c_label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'c_label
        '
        Me.c_label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c_label.Font = New System.Drawing.Font("Arial Black", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.c_label.ForeColor = System.Drawing.SystemColors.Control
        Me.c_label.Location = New System.Drawing.Point(0, 0)
        Me.c_label.Name = "c_label"
        Me.c_label.Size = New System.Drawing.Size(729, 385)
        Me.c_label.TabIndex = 1
        Me.c_label.Text = "00:00:00"
        Me.c_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'main_window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(729, 385)
        Me.Controls.Add(Me.c_label)
        Me.Name = "main_window"
        Me.Text = "Fullscreen counter"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents c_label As Label
End Class
