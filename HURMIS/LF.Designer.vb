<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LF))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.uPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.uNameTextBox = New System.Windows.Forms.TextBox()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.govLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.govLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(5, 343)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(698, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "POWERED BY DATA PROCESSING CENTER , SUPPORT SERVICES WING, PBS HQ        :       " & _
            " VERSION 2.0.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(194, 238)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "PASSWORD :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(191, 187)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "USER NAME :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(112, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 104)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Human Resource Management" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and Information System (HURMIS)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of Pakistan Bureau of" & _
            " Statistics" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Module - I : R and S Section)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.Navy
        Me.loginButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.ForeColor = System.Drawing.Color.White
        Me.loginButton.Location = New System.Drawing.Point(340, 282)
        Me.loginButton.Margin = New System.Windows.Forms.Padding(5)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(142, 35)
        Me.loginButton.TabIndex = 3
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'uPasswordTextBox
        '
        Me.uPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uPasswordTextBox.Location = New System.Drawing.Point(318, 235)
        Me.uPasswordTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.uPasswordTextBox.MaxLength = 10
        Me.uPasswordTextBox.Name = "uPasswordTextBox"
        Me.uPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.uPasswordTextBox.Size = New System.Drawing.Size(164, 26)
        Me.uPasswordTextBox.TabIndex = 2
        '
        'uNameTextBox
        '
        Me.uNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.uNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uNameTextBox.Location = New System.Drawing.Point(318, 184)
        Me.uNameTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.uNameTextBox.MaxLength = 20
        Me.uNameTextBox.Name = "uNameTextBox"
        Me.uNameTextBox.Size = New System.Drawing.Size(164, 26)
        Me.uNameTextBox.TabIndex = 1
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logoPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logoPictureBox.BackgroundImage = CType(resources.GetObject("logoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoPictureBox.Location = New System.Drawing.Point(586, 6)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(117, 56)
        Me.logoPictureBox.TabIndex = 1023
        Me.logoPictureBox.TabStop = False
        '
        'govLogoPictureBox
        '
        Me.govLogoPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.govLogoPictureBox.BackColor = System.Drawing.Color.White
        Me.govLogoPictureBox.BackgroundImage = CType(resources.GetObject("govLogoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.govLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.govLogoPictureBox.Location = New System.Drawing.Point(8, 6)
        Me.govLogoPictureBox.Name = "govLogoPictureBox"
        Me.govLogoPictureBox.Size = New System.Drawing.Size(88, 83)
        Me.govLogoPictureBox.TabIndex = 1024
        Me.govLogoPictureBox.TabStop = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.Navy
        Me.CancelButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.Color.White
        Me.CancelButton.Location = New System.Drawing.Point(196, 282)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(5)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(142, 35)
        Me.CancelButton.TabIndex = 1025
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'LF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(708, 362)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.govLogoPictureBox)
        Me.Controls.Add(Me.logoPictureBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.uPasswordTextBox)
        Me.Controls.Add(Me.uNameTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "LF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LF"
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.govLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents loginButton As System.Windows.Forms.Button
    Friend WithEvents uPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents uNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents logoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents govLogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CancelButton As System.Windows.Forms.Button
End Class
