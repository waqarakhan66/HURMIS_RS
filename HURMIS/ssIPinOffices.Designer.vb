<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssIPinOffices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssIPinOffices))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OfficeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.OfficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HURMISDataSet = New HURMIS.HURMISDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OfficeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.govLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.OfficeTableAdapter = New HURMIS.HURMISDataSetTableAdapters.officeTableAdapter()
        Me.TableAdapterManager = New HURMIS.HURMISDataSetTableAdapters.TableAdapterManager()
        CType(Me.OfficeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OfficeBindingNavigator.SuspendLayout()
        CType(Me.OfficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HURMISDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.govLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OfficeBindingNavigator
        '
        Me.OfficeBindingNavigator.AddNewItem = Nothing
        Me.OfficeBindingNavigator.BindingSource = Me.OfficeBindingSource
        Me.OfficeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OfficeBindingNavigator.DeleteItem = Nothing
        Me.OfficeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.OfficeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OfficeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OfficeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OfficeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OfficeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OfficeBindingNavigator.Name = "OfficeBindingNavigator"
        Me.OfficeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OfficeBindingNavigator.Size = New System.Drawing.Size(706, 25)
        Me.OfficeBindingNavigator.TabIndex = 0
        Me.OfficeBindingNavigator.Text = "BindingNavigator1"
        '
        'OfficeBindingSource
        '
        Me.OfficeBindingSource.DataMember = "office"
        Me.OfficeBindingSource.DataSource = Me.HURMISDataSet
        '
        'HURMISDataSet
        '
        Me.HURMISDataSet.DataSetName = "HURMISDataSet"
        Me.HURMISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(45, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OfficeDataGridView
        '
        Me.OfficeDataGridView.AllowUserToAddRows = False
        Me.OfficeDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        Me.OfficeDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.OfficeDataGridView.AutoGenerateColumns = False
        Me.OfficeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.OfficeDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OfficeDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.OfficeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OfficeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.ss, Me.ip, Me.vac})
        Me.OfficeDataGridView.DataSource = Me.OfficeBindingSource
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OfficeDataGridView.DefaultCellStyle = DataGridViewCellStyle18
        Me.OfficeDataGridView.Location = New System.Drawing.Point(30, 95)
        Me.OfficeDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OfficeDataGridView.Name = "OfficeDataGridView"
        Me.OfficeDataGridView.ReadOnly = True
        Me.OfficeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OfficeDataGridView.Size = New System.Drawing.Size(644, 546)
        Me.OfficeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "oid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "oid"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 2
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "office"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Regional / Field Office(s)"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 260
        '
        'ss
        '
        Me.ss.DataPropertyName = "ss"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ss.DefaultCellStyle = DataGridViewCellStyle15
        Me.ss.HeaderText = "Senction Strength"
        Me.ss.Name = "ss"
        Me.ss.ReadOnly = True
        '
        'ip
        '
        Me.ip.DataPropertyName = "ip"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ip.DefaultCellStyle = DataGridViewCellStyle16
        Me.ip.HeaderText = "In Position"
        Me.ip.Name = "ip"
        Me.ip.ReadOnly = True
        '
        'vac
        '
        Me.vac.DataPropertyName = "vp"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.vac.DefaultCellStyle = DataGridViewCellStyle17
        Me.vac.HeaderText = "Vacant Seat(s)"
        Me.vac.Name = "vac"
        Me.vac.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(26, 918)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(650, 15)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "POWERED BY DATA PROCESSING CENTER , SUPPORT SERVICES WING, PBS HQ  :  VERSION 2.0" & _
            ".0"
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logoPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logoPictureBox.BackgroundImage = CType(resources.GetObject("logoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoPictureBox.Location = New System.Drawing.Point(560, 32)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(114, 58)
        Me.logoPictureBox.TabIndex = 1023
        Me.logoPictureBox.TabStop = False
        '
        'govLogoPictureBox
        '
        Me.govLogoPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.govLogoPictureBox.BackColor = System.Drawing.Color.White
        Me.govLogoPictureBox.BackgroundImage = CType(resources.GetObject("govLogoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.govLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.govLogoPictureBox.Location = New System.Drawing.Point(30, 32)
        Me.govLogoPictureBox.Name = "govLogoPictureBox"
        Me.govLogoPictureBox.Size = New System.Drawing.Size(77, 58)
        Me.govLogoPictureBox.TabIndex = 1024
        Me.govLogoPictureBox.TabStop = False
        '
        'OfficeTableAdapter
        '
        Me.OfficeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.designationsTableAdapter = Nothing
        Me.TableAdapterManager.designationTableAdapter = Nothing
        Me.TableAdapterManager.educationTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.gpTableAdapter = Nothing
        Me.TableAdapterManager.officeTableAdapter = Me.OfficeTableAdapter
        Me.TableAdapterManager.qualificationTableAdapter = Nothing
        Me.TableAdapterManager.sectionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HURMIS.HURMISDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wngTableAdapter = Nothing
        '
        'ssIPinOffices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(706, 978)
        Me.Controls.Add(Me.govLogoPictureBox)
        Me.Controls.Add(Me.logoPictureBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.OfficeDataGridView)
        Me.Controls.Add(Me.OfficeBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ssIPinOffices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Senction Strength / In Position Staff"
        CType(Me.OfficeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OfficeBindingNavigator.ResumeLayout(False)
        Me.OfficeBindingNavigator.PerformLayout()
        CType(Me.OfficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HURMISDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.govLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HURMISDataSet As HURMIS.HURMISDataSet
    Friend WithEvents OfficeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OfficeTableAdapter As HURMIS.HURMISDataSetTableAdapters.officeTableAdapter
    Friend WithEvents TableAdapterManager As HURMIS.HURMISDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OfficeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OfficeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents logoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents govLogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vac As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
