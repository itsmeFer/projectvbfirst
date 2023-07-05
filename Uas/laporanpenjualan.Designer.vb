<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class laporanpenjualan
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.MediumPurple
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1818, 815)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1676, 665)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 126)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'laporanpenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1818, 815)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "laporanpenjualan"
        Me.Text = "laporanpenjualan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As Button
End Class
