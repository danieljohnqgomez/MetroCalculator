<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCalc))
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.lbl_maximize = New System.Windows.Forms.Label()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btn_point = New System.Windows.Forms.Button()
        Me.btn_multiply = New System.Windows.Forms.Button()
        Me.btn_divide = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_subtract = New System.Windows.Forms.Button()
        Me.btn_equals = New System.Windows.Forms.Button()
        Me.btn_clear_all = New System.Windows.Forms.Button()
        Me.tbResult = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_close
        '
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.BackColor = System.Drawing.Color.Transparent
        Me.lbl_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_close.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.lbl_close.ForeColor = System.Drawing.Color.White
        Me.lbl_close.Location = New System.Drawing.Point(330, 9)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(25, 30)
        Me.lbl_close.TabIndex = 1
        Me.lbl_close.Text = "X"
        '
        'lbl_maximize
        '
        Me.lbl_maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_maximize.AutoSize = True
        Me.lbl_maximize.BackColor = System.Drawing.Color.Transparent
        Me.lbl_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_maximize.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.lbl_maximize.ForeColor = System.Drawing.Color.White
        Me.lbl_maximize.Location = New System.Drawing.Point(302, 9)
        Me.lbl_maximize.Name = "lbl_maximize"
        Me.lbl_maximize.Size = New System.Drawing.Size(22, 30)
        Me.lbl_maximize.TabIndex = 2
        Me.lbl_maximize.Text = "_"
        '
        'btn_7
        '
        Me.btn_7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_7.FlatAppearance.BorderSize = 0
        Me.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_7.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_7.ForeColor = System.Drawing.Color.White
        Me.btn_7.Location = New System.Drawing.Point(23, 161)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(60, 50)
        Me.btn_7.TabIndex = 1
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = False
        '
        'btn_8
        '
        Me.btn_8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_8.FlatAppearance.BorderSize = 0
        Me.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_8.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_8.ForeColor = System.Drawing.Color.White
        Me.btn_8.Location = New System.Drawing.Point(89, 161)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(60, 50)
        Me.btn_8.TabIndex = 4
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = False
        '
        'btn_9
        '
        Me.btn_9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_9.FlatAppearance.BorderSize = 0
        Me.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_9.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_9.ForeColor = System.Drawing.Color.White
        Me.btn_9.Location = New System.Drawing.Point(155, 161)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(60, 50)
        Me.btn_9.TabIndex = 5
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = False
        '
        'btn_4
        '
        Me.btn_4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_4.FlatAppearance.BorderSize = 0
        Me.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_4.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_4.ForeColor = System.Drawing.Color.White
        Me.btn_4.Location = New System.Drawing.Point(23, 217)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(60, 50)
        Me.btn_4.TabIndex = 6
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = False
        '
        'btn_5
        '
        Me.btn_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_5.FlatAppearance.BorderSize = 0
        Me.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_5.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_5.ForeColor = System.Drawing.Color.White
        Me.btn_5.Location = New System.Drawing.Point(89, 217)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(60, 50)
        Me.btn_5.TabIndex = 7
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = False
        '
        'btn_6
        '
        Me.btn_6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_6.FlatAppearance.BorderSize = 0
        Me.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_6.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_6.ForeColor = System.Drawing.Color.White
        Me.btn_6.Location = New System.Drawing.Point(155, 217)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(60, 50)
        Me.btn_6.TabIndex = 8
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = False
        '
        'btn_3
        '
        Me.btn_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_3.FlatAppearance.BorderSize = 0
        Me.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_3.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_3.ForeColor = System.Drawing.Color.White
        Me.btn_3.Location = New System.Drawing.Point(155, 273)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(60, 50)
        Me.btn_3.TabIndex = 11
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = False
        '
        'btn_2
        '
        Me.btn_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_2.FlatAppearance.BorderSize = 0
        Me.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_2.ForeColor = System.Drawing.Color.White
        Me.btn_2.Location = New System.Drawing.Point(89, 273)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(60, 50)
        Me.btn_2.TabIndex = 10
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = False
        '
        'btn_1
        '
        Me.btn_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_1.FlatAppearance.BorderSize = 0
        Me.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_1.ForeColor = System.Drawing.Color.White
        Me.btn_1.Location = New System.Drawing.Point(23, 273)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(60, 50)
        Me.btn_1.TabIndex = 9
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'btn_0
        '
        Me.btn_0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_0.FlatAppearance.BorderSize = 0
        Me.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_0.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_0.ForeColor = System.Drawing.Color.White
        Me.btn_0.Location = New System.Drawing.Point(23, 329)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(126, 50)
        Me.btn_0.TabIndex = 12
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = False
        '
        'btn_point
        '
        Me.btn_point.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_point.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_point.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_point.FlatAppearance.BorderSize = 0
        Me.btn_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_point.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_point.ForeColor = System.Drawing.Color.White
        Me.btn_point.Location = New System.Drawing.Point(155, 329)
        Me.btn_point.Name = "btn_point"
        Me.btn_point.Size = New System.Drawing.Size(60, 50)
        Me.btn_point.TabIndex = 13
        Me.btn_point.Text = "."
        Me.btn_point.UseVisualStyleBackColor = False
        '
        'btn_multiply
        '
        Me.btn_multiply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_multiply.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_multiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_multiply.FlatAppearance.BorderSize = 0
        Me.btn_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_multiply.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_multiply.ForeColor = System.Drawing.Color.White
        Me.btn_multiply.Location = New System.Drawing.Point(221, 161)
        Me.btn_multiply.Name = "btn_multiply"
        Me.btn_multiply.Size = New System.Drawing.Size(60, 50)
        Me.btn_multiply.TabIndex = 14
        Me.btn_multiply.Text = "*"
        Me.btn_multiply.UseVisualStyleBackColor = False
        '
        'btn_divide
        '
        Me.btn_divide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_divide.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_divide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_divide.FlatAppearance.BorderSize = 0
        Me.btn_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_divide.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_divide.ForeColor = System.Drawing.Color.White
        Me.btn_divide.Location = New System.Drawing.Point(221, 217)
        Me.btn_divide.Name = "btn_divide"
        Me.btn_divide.Size = New System.Drawing.Size(60, 50)
        Me.btn_divide.TabIndex = 15
        Me.btn_divide.Text = "/"
        Me.btn_divide.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(221, 273)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(60, 50)
        Me.btn_add.TabIndex = 16
        Me.btn_add.Text = "+"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_subtract
        '
        Me.btn_subtract.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_subtract.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_subtract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_subtract.FlatAppearance.BorderSize = 0
        Me.btn_subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_subtract.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_subtract.ForeColor = System.Drawing.Color.White
        Me.btn_subtract.Location = New System.Drawing.Point(221, 329)
        Me.btn_subtract.Name = "btn_subtract"
        Me.btn_subtract.Size = New System.Drawing.Size(60, 50)
        Me.btn_subtract.TabIndex = 17
        Me.btn_subtract.Text = "-"
        Me.btn_subtract.UseVisualStyleBackColor = False
        '
        'btn_equals
        '
        Me.btn_equals.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_equals.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_equals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_equals.FlatAppearance.BorderSize = 0
        Me.btn_equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_equals.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_equals.ForeColor = System.Drawing.Color.White
        Me.btn_equals.Location = New System.Drawing.Point(287, 273)
        Me.btn_equals.Name = "btn_equals"
        Me.btn_equals.Size = New System.Drawing.Size(58, 106)
        Me.btn_equals.TabIndex = 0
        Me.btn_equals.Text = "="
        Me.btn_equals.UseVisualStyleBackColor = False
        '
        'btn_clear_all
        '
        Me.btn_clear_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear_all.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_clear_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_clear_all.FlatAppearance.BorderSize = 0
        Me.btn_clear_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear_all.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.btn_clear_all.ForeColor = System.Drawing.Color.White
        Me.btn_clear_all.Location = New System.Drawing.Point(287, 217)
        Me.btn_clear_all.Name = "btn_clear_all"
        Me.btn_clear_all.Size = New System.Drawing.Size(58, 50)
        Me.btn_clear_all.TabIndex = 19
        Me.btn_clear_all.Text = "&C"
        Me.btn_clear_all.UseVisualStyleBackColor = False
        '
        'tbResult
        '
        Me.tbResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbResult.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbResult.Font = New System.Drawing.Font("Segoe UI Light", 34.0!)
        Me.tbResult.ForeColor = System.Drawing.Color.White
        Me.tbResult.Location = New System.Drawing.Point(10, 0)
        Me.tbResult.Name = "tbResult"
        Me.tbResult.ReadOnly = True
        Me.tbResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.tbResult.Size = New System.Drawing.Size(302, 78)
        Me.tbResult.TabIndex = 0
        Me.tbResult.Text = ""
        Me.tbResult.WordWrap = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel1.Controls.Add(Me.tbResult)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Panel1.Size = New System.Drawing.Size(322, 78)
        Me.Panel1.TabIndex = 24
        '
        'btn_del
        '
        Me.btn_del.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_del.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_del.BackgroundImage = Global.Calculator_Ni_DJ.My.Resources.Resources.arrow
        Me.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_del.FlatAppearance.BorderSize = 0
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.btn_del.ForeColor = System.Drawing.Color.White
        Me.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.Location = New System.Drawing.Point(287, 161)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(58, 50)
        Me.btn_del.TabIndex = 18
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'FormCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(367, 403)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_clear_all)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_equals)
        Me.Controls.Add(Me.btn_subtract)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_divide)
        Me.Controls.Add(Me.btn_multiply)
        Me.Controls.Add(Me.btn_point)
        Me.Controls.Add(Me.btn_0)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_5)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.lbl_maximize)
        Me.Controls.Add(Me.lbl_close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_close As System.Windows.Forms.Label
    Friend WithEvents lbl_maximize As System.Windows.Forms.Label
    Friend WithEvents btn_7 As System.Windows.Forms.Button
    Friend WithEvents btn_8 As System.Windows.Forms.Button
    Friend WithEvents btn_9 As System.Windows.Forms.Button
    Friend WithEvents btn_4 As System.Windows.Forms.Button
    Friend WithEvents btn_5 As System.Windows.Forms.Button
    Friend WithEvents btn_6 As System.Windows.Forms.Button
    Friend WithEvents btn_3 As System.Windows.Forms.Button
    Friend WithEvents btn_2 As System.Windows.Forms.Button
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents btn_0 As System.Windows.Forms.Button
    Friend WithEvents btn_point As System.Windows.Forms.Button
    Friend WithEvents btn_multiply As System.Windows.Forms.Button
    Friend WithEvents btn_divide As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_subtract As System.Windows.Forms.Button
    Friend WithEvents btn_equals As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents btn_clear_all As System.Windows.Forms.Button
    Friend WithEvents tbResult As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
