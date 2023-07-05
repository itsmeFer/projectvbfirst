<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("NewsGoth Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(96, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("NewsGoth Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(96, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(271, 119)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(129, 22)
        Me.txtuser.TabIndex = 2
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(271, 183)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(129, 22)
        Me.txtpw.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnshow)
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.btnlogin)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtpw)
        Me.Panel1.Controls.Add(Me.txtuser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(331, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 272)
        Me.Panel1.TabIndex = 4
        '
        'btnshow
        '
        Me.btnshow.Location = New System.Drawing.Point(331, 227)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(88, 28)
        Me.btnshow.TabIndex = 7
        Me.btnshow.Text = "Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(211, 227)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(88, 28)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(95, 227)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(88, 28)
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(70, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(349, 85)
        Me.Panel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("NewsGoth Lt BT", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(168, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 40)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LOGIN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(66, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 67)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1136, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "login"
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpw As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnshow As Button
End Class
