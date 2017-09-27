<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBrowser
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
        Me.pnlBrowser = New System.Windows.Forms.Panel()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.btnH1s = New System.Windows.Forms.Button()
        Me.btnMSDN = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.pnlBrowser.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBrowser
        '
        Me.pnlBrowser.Controls.Add(Me.pnlActions)
        Me.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBrowser.Location = New System.Drawing.Point(0, 0)
        Me.pnlBrowser.Name = "pnlBrowser"
        Me.pnlBrowser.Size = New System.Drawing.Size(1016, 610)
        Me.pnlBrowser.TabIndex = 0
        '
        'pnlActions
        '
        Me.pnlActions.Controls.Add(Me.btnTest)
        Me.pnlActions.Controls.Add(Me.btnH1s)
        Me.pnlActions.Controls.Add(Me.btnMSDN)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlActions.Location = New System.Drawing.Point(0, 510)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(1016, 100)
        Me.pnlActions.TabIndex = 0
        '
        'btnH1s
        '
        Me.btnH1s.Location = New System.Drawing.Point(597, 22)
        Me.btnH1s.Name = "btnH1s"
        Me.btnH1s.Size = New System.Drawing.Size(75, 23)
        Me.btnH1s.TabIndex = 1
        Me.btnH1s.Text = "Find H1's"
        Me.btnH1s.UseVisualStyleBackColor = True
        '
        'btnMSDN
        '
        Me.btnMSDN.Location = New System.Drawing.Point(416, 31)
        Me.btnMSDN.Name = "btnMSDN"
        Me.btnMSDN.Size = New System.Drawing.Size(75, 23)
        Me.btnMSDN.TabIndex = 0
        Me.btnMSDN.Text = "MSDN"
        Me.btnMSDN.UseVisualStyleBackColor = True
        '
        'frmBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 610)
        Me.Controls.Add(Me.pnlBrowser)
        Me.Name = "frmBrowser"
        Me.Text = "Browser"
        Me.pnlBrowser.ResumeLayout(False)
        Me.pnlActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBrowser As Panel
    Friend WithEvents pnlActions As Panel
    Friend WithEvents btnMSDN As Button
    Friend WithEvents btnH1s As Button
    Friend WithEvents btnTest As Button
End Class
