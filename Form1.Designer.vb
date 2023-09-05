<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbGender = New System.Windows.Forms.ListBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.btnGender = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbGender
        '
        Me.lbGender.FormattingEnabled = True
        Me.lbGender.ItemHeight = 25
        Me.lbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.lbGender.Location = New System.Drawing.Point(314, 82)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(180, 129)
        Me.lbGender.TabIndex = 0
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(168, 82)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(69, 25)
        Me.lblGender.TabIndex = 1
        Me.lblGender.Text = "Gender"
        '
        'btnGender
        '
        Me.btnGender.Location = New System.Drawing.Point(314, 243)
        Me.btnGender.Name = "btnGender"
        Me.btnGender.Size = New System.Drawing.Size(177, 104)
        Me.btnGender.TabIndex = 2
        Me.btnGender.Text = "your Gender"
        Me.btnGender.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lbGender)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbGender As ListBox
    Friend WithEvents lblGender As Label
    Friend WithEvents btnGender As Button
End Class
