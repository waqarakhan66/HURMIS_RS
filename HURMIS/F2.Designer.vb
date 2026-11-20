<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F2
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
        Dim NicLabel As System.Windows.Forms.Label
        Dim PnoLabel As System.Windows.Forms.Label
        Dim EidLabel As System.Windows.Forms.Label
        Dim SrvLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim BsLabel As System.Windows.Forms.Label
        Dim RelLabel As System.Windows.Forms.Label
        Dim FatherLabel As System.Windows.Forms.Label
        Dim DpLabel As System.Windows.Forms.Label
        Dim DdLabel As System.Windows.Forms.Label
        Dim OidLabel As System.Windows.Forms.Label
        Dim SidLabel As System.Windows.Forms.Label
        Dim BdLabel As System.Windows.Forms.Label
        Dim EdLabel As System.Windows.Forms.Label
        Dim ApdLabel As System.Windows.Forms.Label
        Dim SdLabel As System.Windows.Forms.Label
        Dim CdLabel As System.Windows.Forms.Label
        Dim StLabel As System.Windows.Forms.Label
        Dim CrLabel As System.Windows.Forms.Label
        Dim QtaLabel As System.Windows.Forms.Label
        Dim PhoLabel As System.Windows.Forms.Label
        Dim PhrLabel As System.Windows.Forms.Label
        Dim MobLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PaLabel As System.Windows.Forms.Label
        Dim TaLabel As System.Windows.Forms.Label
        Dim NokRelLabel As System.Windows.Forms.Label
        Dim NokNameLabel As System.Windows.Forms.Label
        Dim ExLabel As System.Windows.Forms.Label
        Dim PtLabel As System.Windows.Forms.Label
        Dim HhLabel As System.Windows.Forms.Label
        Dim DnLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim NroLabel As System.Windows.Forms.Label
        Dim RdLabel As System.Windows.Forms.Label
        Dim AdLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim DoeLabel As System.Windows.Forms.Label
        Dim DeoLabel As System.Windows.Forms.Label
        Dim DesignationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.HURMISDataSet = New HURMIS.HURMISDataSet()
        Me.DesignationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DesignationsTableAdapter = New HURMIS.HURMISDataSetTableAdapters.designationsTableAdapter()
        Me.TableAdapterManager = New HURMIS.HURMISDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeTableAdapter = New HURMIS.HURMISDataSetTableAdapters.employeeTableAdapter()
        Me.QualificationTableAdapter = New HURMIS.HURMISDataSetTableAdapters.qualificationTableAdapter()
        Me.DesignationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DesignationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.post = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minBS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maxBS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.did = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NicTextBox = New System.Windows.Forms.TextBox()
        Me.PnoTextBox = New System.Windows.Forms.TextBox()
        Me.EidTextBox = New System.Windows.Forms.TextBox()
        Me.SrvComboBox = New System.Windows.Forms.ComboBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.BsTextBox = New System.Windows.Forms.TextBox()
        Me.RelComboBox = New System.Windows.Forms.ComboBox()
        Me.FatherTextBox = New System.Windows.Forms.TextBox()
        Me.DpComboBox = New System.Windows.Forms.ComboBox()
        Me.PvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DdComboBox = New System.Windows.Forms.ComboBox()
        Me.DsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OidComboBox = New System.Windows.Forms.ComboBox()
        Me.OfficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SidComboBox = New System.Windows.Forms.ComboBox()
        Me.BdTextBox = New System.Windows.Forms.TextBox()
        Me.EdTextBox = New System.Windows.Forms.TextBox()
        Me.ApdTextBox = New System.Windows.Forms.TextBox()
        Me.SdTextBox = New System.Windows.Forms.TextBox()
        Me.CdTextBox = New System.Windows.Forms.TextBox()
        Me.StComboBox = New System.Windows.Forms.ComboBox()
        Me.CrComboBox = New System.Windows.Forms.ComboBox()
        Me.QtaComboBox = New System.Windows.Forms.ComboBox()
        Me.PhoTextBox = New System.Windows.Forms.TextBox()
        Me.PhrTextBox = New System.Windows.Forms.TextBox()
        Me.MobTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PaTextBox = New System.Windows.Forms.TextBox()
        Me.TaTextBox = New System.Windows.Forms.TextBox()
        Me.NokRelComboBox = New System.Windows.Forms.ComboBox()
        Me.NokNameTextBox = New System.Windows.Forms.TextBox()
        Me.ExComboBox = New System.Windows.Forms.ComboBox()
        Me.PtComboBox = New System.Windows.Forms.ComboBox()
        Me.CountryComboBox = New System.Windows.Forms.ComboBox()
        Me.RdTextBox = New System.Windows.Forms.TextBox()
        Me.AdComboBox = New System.Windows.Forms.ComboBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.DoeTextBox = New System.Windows.Forms.TextBox()
        Me.DeoTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.goBackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.govLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.PvTableAdapter = New HURMIS.HURMISDataSetTableAdapters.pvTableAdapter()
        Me.searchLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OfficeTableAdapter = New HURMIS.HURMISDataSetTableAdapters.officeTableAdapter()
        Me.SectionTableAdapter = New HURMIS.HURMISDataSetTableAdapters.sectionTableAdapter()
        Me.HhComboBox = New System.Windows.Forms.ComboBox()
        Me.DnComboBox = New System.Windows.Forms.ComboBox()
        Me.DsTableAdapter = New HURMIS.HURMISDataSetTableAdapters.dsTableAdapter()
        Me.NroComboBox = New System.Windows.Forms.ComboBox()
        Me.dLabel = New System.Windows.Forms.Label()
        Me.qualificationPanel = New System.Windows.Forms.Panel()
        Me.qDeleteButton = New System.Windows.Forms.Button()
        Me.qAddButton = New System.Windows.Forms.Button()
        Me.YrTextBox = New System.Windows.Forms.TextBox()
        Me.QualificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EdnComboBox = New System.Windows.Forms.ComboBox()
        Me.EducationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjTextBox = New System.Windows.Forms.TextBox()
        Me.DivComboBox = New System.Windows.Forms.ComboBox()
        Me.UniTextBox = New System.Windows.Forms.TextBox()
        Me.GpaTextBox = New System.Windows.Forms.TextBox()
        Me.DurationComboBox = New System.Windows.Forms.ComboBox()
        Me.CountryComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QualificationDataGridView = New System.Windows.Forms.DataGridView()
        Me.qualificationButton = New System.Windows.Forms.Button()
        Me.EducationTableAdapter = New HURMIS.HURMISDataSetTableAdapters.educationTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DesignationTableAdapter = New HURMIS.HURMISDataSetTableAdapters.designationTableAdapter()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NicLabel = New System.Windows.Forms.Label()
        PnoLabel = New System.Windows.Forms.Label()
        EidLabel = New System.Windows.Forms.Label()
        SrvLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        BsLabel = New System.Windows.Forms.Label()
        RelLabel = New System.Windows.Forms.Label()
        FatherLabel = New System.Windows.Forms.Label()
        DpLabel = New System.Windows.Forms.Label()
        DdLabel = New System.Windows.Forms.Label()
        OidLabel = New System.Windows.Forms.Label()
        SidLabel = New System.Windows.Forms.Label()
        BdLabel = New System.Windows.Forms.Label()
        EdLabel = New System.Windows.Forms.Label()
        ApdLabel = New System.Windows.Forms.Label()
        SdLabel = New System.Windows.Forms.Label()
        CdLabel = New System.Windows.Forms.Label()
        StLabel = New System.Windows.Forms.Label()
        CrLabel = New System.Windows.Forms.Label()
        QtaLabel = New System.Windows.Forms.Label()
        PhoLabel = New System.Windows.Forms.Label()
        PhrLabel = New System.Windows.Forms.Label()
        MobLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PaLabel = New System.Windows.Forms.Label()
        TaLabel = New System.Windows.Forms.Label()
        NokRelLabel = New System.Windows.Forms.Label()
        NokNameLabel = New System.Windows.Forms.Label()
        ExLabel = New System.Windows.Forms.Label()
        PtLabel = New System.Windows.Forms.Label()
        HhLabel = New System.Windows.Forms.Label()
        DnLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        NroLabel = New System.Windows.Forms.Label()
        RdLabel = New System.Windows.Forms.Label()
        AdLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        DoeLabel = New System.Windows.Forms.Label()
        DeoLabel = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        CType(Me.HURMISDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DesignationsBindingNavigator.SuspendLayout()
        CType(Me.DesignationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeBindingNavigator.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.govLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.qualificationPanel.SuspendLayout()
        CType(Me.QualificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EducationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualificationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NicLabel
        '
        NicLabel.AutoSize = True
        NicLabel.Location = New System.Drawing.Point(122, 304)
        NicLabel.Name = "NicLabel"
        NicLabel.Size = New System.Drawing.Size(170, 16)
        NicLabel.TabIndex = 2
        NicLabel.Text = "CNIC No. of Employee :"
        '
        'PnoLabel
        '
        PnoLabel.AutoSize = True
        PnoLabel.Location = New System.Drawing.Point(95, 335)
        PnoLabel.Name = "PnoLabel"
        PnoLabel.Size = New System.Drawing.Size(197, 16)
        PnoLabel.TabIndex = 4
        PnoLabel.Text = "Personal No. of Employee :"
        '
        'EidLabel
        '
        EidLabel.AutoSize = True
        EidLabel.Location = New System.Drawing.Point(1104, 335)
        EidLabel.Name = "EidLabel"
        EidLabel.Size = New System.Drawing.Size(105, 16)
        EidLabel.TabIndex = 12
        EidLabel.Text = "Seniority No. :"
        '
        'SrvLabel
        '
        SrvLabel.AutoSize = True
        SrvLabel.Location = New System.Drawing.Point(823, 806)
        SrvLabel.Name = "SrvLabel"
        SrvLabel.Size = New System.Drawing.Size(125, 16)
        SrvLabel.TabIndex = 14
        SrvLabel.Text = "Serving/Retired :"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(483, 304)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(148, 16)
        NameLabel.TabIndex = 16
        NameLabel.Text = "Name of Employee :"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(1142, 304)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(67, 16)
        GenderLabel.TabIndex = 18
        GenderLabel.Text = "Gender :"
        '
        'BsLabel
        '
        BsLabel.AutoSize = True
        BsLabel.Location = New System.Drawing.Point(1037, 365)
        BsLabel.Name = "BsLabel"
        BsLabel.Size = New System.Drawing.Size(174, 16)
        BsLabel.TabIndex = 20
        BsLabel.Text = "Basic Pay Scale (BPS) :"
        '
        'RelLabel
        '
        RelLabel.AutoSize = True
        RelLabel.Location = New System.Drawing.Point(461, 460)
        RelLabel.Name = "RelLabel"
        RelLabel.Size = New System.Drawing.Size(74, 16)
        RelLabel.TabIndex = 22
        RelLabel.Text = "Religion :"
        '
        'FatherLabel
        '
        FatherLabel.AutoSize = True
        FatherLabel.Location = New System.Drawing.Point(514, 335)
        FatherLabel.Name = "FatherLabel"
        FatherLabel.Size = New System.Drawing.Size(117, 16)
        FatherLabel.TabIndex = 24
        FatherLabel.Text = "Father's Name :"
        '
        'DpLabel
        '
        DpLabel.AutoSize = True
        DpLabel.Location = New System.Drawing.Point(150, 428)
        DpLabel.Name = "DpLabel"
        DpLabel.Size = New System.Drawing.Size(142, 16)
        DpLabel.TabIndex = 26
        DpLabel.Text = "Domicile Province :"
        '
        'DdLabel
        '
        DdLabel.AutoSize = True
        DdLabel.Location = New System.Drawing.Point(815, 428)
        DdLabel.Name = "DdLabel"
        DdLabel.Size = New System.Drawing.Size(129, 16)
        DdLabel.TabIndex = 28
        DdLabel.Text = "Domicile District :"
        '
        'OidLabel
        '
        OidLabel.AutoSize = True
        OidLabel.Location = New System.Drawing.Point(129, 396)
        OidLabel.Name = "OidLabel"
        OidLabel.Size = New System.Drawing.Size(163, 16)
        OidLabel.TabIndex = 30
        OidLabel.Text = "Regional/Field Office :"
        '
        'SidLabel
        '
        SidLabel.AutoSize = True
        SidLabel.Location = New System.Drawing.Point(827, 396)
        SidLabel.Name = "SidLabel"
        SidLabel.Size = New System.Drawing.Size(119, 16)
        SidLabel.TabIndex = 32
        SidLabel.Text = "Section (if any) :"
        '
        'BdLabel
        '
        BdLabel.AutoSize = True
        BdLabel.Location = New System.Drawing.Point(208, 460)
        BdLabel.Name = "BdLabel"
        BdLabel.Size = New System.Drawing.Size(84, 16)
        BdLabel.TabIndex = 34
        BdLabel.Text = "Birth Date :"
        '
        'EdLabel
        '
        EdLabel.AutoSize = True
        EdLabel.Location = New System.Drawing.Point(1022, 460)
        EdLabel.Name = "EdLabel"
        EdLabel.Size = New System.Drawing.Size(188, 16)
        EdLabel.TabIndex = 36
        EdLabel.Text = "Entry Date (in Govt. Svc.) :"
        '
        'ApdLabel
        '
        ApdLabel.AutoSize = True
        ApdLabel.Location = New System.Drawing.Point(92, 490)
        ApdLabel.Name = "ApdLabel"
        ApdLabel.Size = New System.Drawing.Size(200, 16)
        ApdLabel.TabIndex = 38
        ApdLabel.Text = "Appointment Date (at post) :"
        '
        'SdLabel
        '
        SdLabel.AutoSize = True
        SdLabel.Location = New System.Drawing.Point(1052, 490)
        SdLabel.Name = "SdLabel"
        SdLabel.Size = New System.Drawing.Size(158, 16)
        SdLabel.TabIndex = 40
        SdLabel.Text = "Present Station Date :"
        '
        'CdLabel
        '
        CdLabel.AutoSize = True
        CdLabel.Location = New System.Drawing.Point(500, 677)
        CdLabel.Name = "CdLabel"
        CdLabel.Size = New System.Drawing.Size(139, 16)
        CdLabel.TabIndex = 42
        CdLabel.Text = "Confirmation Date :"
        '
        'StLabel
        '
        StLabel.AutoSize = True
        StLabel.Location = New System.Drawing.Point(113, 677)
        StLabel.Name = "StLabel"
        StLabel.Size = New System.Drawing.Size(179, 16)
        StLabel.TabIndex = 44
        StLabel.Text = "Permanent / Temporary :"
        '
        'CrLabel
        '
        CrLabel.AutoSize = True
        CrLabel.Location = New System.Drawing.Point(769, 677)
        CrLabel.Name = "CrLabel"
        CrLabel.Size = New System.Drawing.Size(66, 16)
        CrLabel.TabIndex = 46
        CrLabel.Text = "Criteria :"
        '
        'QtaLabel
        '
        QtaLabel.AutoSize = True
        QtaLabel.Location = New System.Drawing.Point(1041, 677)
        QtaLabel.Name = "QtaLabel"
        QtaLabel.Size = New System.Drawing.Size(165, 16)
        QtaLabel.TabIndex = 48
        QtaLabel.Text = "Service Quota (if any) :"
        '
        'PhoLabel
        '
        PhoLabel.AutoSize = True
        PhoLabel.Location = New System.Drawing.Point(150, 610)
        PhoLabel.Name = "PhoLabel"
        PhoLabel.Size = New System.Drawing.Size(142, 16)
        PhoLabel.TabIndex = 50
        PhoLabel.Text = "Phone No. (Office) :"
        '
        'PhrLabel
        '
        PhrLabel.AutoSize = True
        PhrLabel.Location = New System.Drawing.Point(541, 610)
        PhrLabel.Name = "PhrLabel"
        PhrLabel.Size = New System.Drawing.Size(207, 16)
        PhrLabel.TabIndex = 52
        PhrLabel.Text = "Phone Number (Residence) :"
        '
        'MobLabel
        '
        MobLabel.AutoSize = True
        MobLabel.Location = New System.Drawing.Point(1087, 610)
        MobLabel.Name = "MobLabel"
        MobLabel.Size = New System.Drawing.Size(121, 16)
        MobLabel.TabIndex = 54
        MobLabel.Text = "Mobile Number :"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(175, 580)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(117, 16)
        EmailLabel.TabIndex = 56
        EmailLabel.Text = "Email Address :"
        '
        'PaLabel
        '
        PaLabel.AutoSize = True
        PaLabel.Location = New System.Drawing.Point(140, 519)
        PaLabel.Name = "PaLabel"
        PaLabel.Size = New System.Drawing.Size(152, 16)
        PaLabel.TabIndex = 58
        PaLabel.Text = "Permanent Address :"
        '
        'TaLabel
        '
        TaLabel.AutoSize = True
        TaLabel.Location = New System.Drawing.Point(138, 550)
        TaLabel.Name = "TaLabel"
        TaLabel.Size = New System.Drawing.Size(154, 16)
        TaLabel.TabIndex = 60
        TaLabel.Text = "Temporary Address :"
        '
        'NokRelLabel
        '
        NokRelLabel.AutoSize = True
        NokRelLabel.Location = New System.Drawing.Point(122, 709)
        NokRelLabel.Name = "NokRelLabel"
        NokRelLabel.Size = New System.Drawing.Size(170, 16)
        NokRelLabel.TabIndex = 62
        NokRelLabel.Text = "Relation with Nominee :"
        '
        'NokNameLabel
        '
        NokNameLabel.AutoSize = True
        NokNameLabel.Location = New System.Drawing.Point(720, 709)
        NokNameLabel.Name = "NokNameLabel"
        NokNameLabel.Size = New System.Drawing.Size(227, 16)
        NokNameLabel.TabIndex = 64
        NokNameLabel.Text = "Name of Nominee (Next of Kin) :"
        '
        'ExLabel
        '
        ExLabel.AutoSize = True
        ExLabel.Location = New System.Drawing.Point(241, 741)
        ExLabel.Name = "ExLabel"
        ExLabel.Size = New System.Drawing.Size(51, 16)
        ExLabel.TabIndex = 66
        ExLabel.Text = "Wing :"
        '
        'PtLabel
        '
        PtLabel.AutoSize = True
        PtLabel.Location = New System.Drawing.Point(491, 741)
        PtLabel.Name = "PtLabel"
        PtLabel.Size = New System.Drawing.Size(44, 16)
        PtLabel.TabIndex = 68
        PtLabel.Text = "Part :"
        '
        'HhLabel
        '
        HhLabel.AutoSize = True
        HhLabel.Location = New System.Drawing.Point(724, 741)
        HhLabel.Name = "HhLabel"
        HhLabel.Size = New System.Drawing.Size(223, 16)
        HhLabel.TabIndex = 70
        HhLabel.Text = "House Hired by Government ? :"
        '
        'DnLabel
        '
        DnLabel.AutoSize = True
        DnLabel.Location = New System.Drawing.Point(154, 774)
        DnLabel.Name = "DnLabel"
        DnLabel.Size = New System.Drawing.Size(138, 16)
        DnLabel.TabIndex = 72
        DnLabel.Text = "Dual Nationality ? :"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(432, 774)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(204, 16)
        CountryLabel.TabIndex = 74
        CountryLabel.Text = "Country (if Dual Nationality) :"
        '
        'NroLabel
        '
        NroLabel.AutoSize = True
        NroLabel.Location = New System.Drawing.Point(886, 774)
        NroLabel.Name = "NroLabel"
        NroLabel.Size = New System.Drawing.Size(61, 16)
        NroLabel.TabIndex = 76
        NroLabel.Text = "NRO ? :"
        '
        'RdLabel
        '
        RdLabel.AutoSize = True
        RdLabel.Location = New System.Drawing.Point(1082, 806)
        RdLabel.Name = "RdLabel"
        RdLabel.Size = New System.Drawing.Size(128, 16)
        RdLabel.TabIndex = 78
        RdLabel.Text = "Retirement Date :"
        '
        'AdLabel
        '
        AdLabel.AutoSize = True
        AdLabel.Location = New System.Drawing.Point(1083, 774)
        AdLabel.Name = "AdLabel"
        AdLabel.Size = New System.Drawing.Size(128, 16)
        AdLabel.TabIndex = 80
        AdLabel.Text = "Alive/Deceased :"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(163, 836)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(129, 16)
        RemarksLabel.TabIndex = 82
        RemarksLabel.Text = "Remarks (if any) :"
        '
        'DoeLabel
        '
        DoeLabel.AutoSize = True
        DoeLabel.Location = New System.Drawing.Point(41, 894)
        DoeLabel.Name = "DoeLabel"
        DoeLabel.Size = New System.Drawing.Size(48, 16)
        DoeLabel.TabIndex = 84
        DoeLabel.Text = "DEO :"
        '
        'DeoLabel
        '
        DeoLabel.AutoSize = True
        DeoLabel.Location = New System.Drawing.Point(1, 919)
        DeoLabel.Name = "DeoLabel"
        DeoLabel.Size = New System.Drawing.Size(88, 16)
        DeoLabel.TabIndex = 86
        DeoLabel.Text = "Entry Date :"
        DeoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Location = New System.Drawing.Point(193, 365)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(99, 16)
        DesignationLabel.TabIndex = 88
        DesignationLabel.Text = "Designation :"
        '
        'HURMISDataSet
        '
        Me.HURMISDataSet.DataSetName = "HURMISDataSet"
        Me.HURMISDataSet.EnforceConstraints = False
        Me.HURMISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DesignationsBindingSource
        '
        Me.DesignationsBindingSource.DataMember = "designations"
        Me.DesignationsBindingSource.DataSource = Me.HURMISDataSet
        '
        'DesignationsTableAdapter
        '
        Me.DesignationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.designationsTableAdapter = Me.DesignationsTableAdapter
        Me.TableAdapterManager.designationTableAdapter = Nothing
        Me.TableAdapterManager.dsTableAdapter = Nothing
        Me.TableAdapterManager.educationTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.gpTableAdapter = Nothing
        Me.TableAdapterManager.officeTableAdapter = Nothing
        Me.TableAdapterManager.postingTableAdapter = Nothing
        Me.TableAdapterManager.pvTableAdapter = Nothing
        Me.TableAdapterManager.qualificationTableAdapter = Me.QualificationTableAdapter
        Me.TableAdapterManager.sectionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HURMIS.HURMISDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wngTableAdapter = Nothing
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'QualificationTableAdapter
        '
        Me.QualificationTableAdapter.ClearBeforeFill = True
        '
        'DesignationsBindingNavigator
        '
        Me.DesignationsBindingNavigator.AddNewItem = Nothing
        Me.DesignationsBindingNavigator.BindingSource = Me.DesignationsBindingSource
        Me.DesignationsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DesignationsBindingNavigator.DeleteItem = Nothing
        Me.DesignationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.DesignationsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DesignationsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DesignationsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DesignationsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DesignationsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DesignationsBindingNavigator.Name = "DesignationsBindingNavigator"
        Me.DesignationsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DesignationsBindingNavigator.Size = New System.Drawing.Size(1584, 25)
        Me.DesignationsBindingNavigator.TabIndex = 0
        Me.DesignationsBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'DesignationsDataGridView
        '
        Me.DesignationsDataGridView.AllowUserToAddRows = False
        Me.DesignationsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DesignationsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DesignationsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DesignationsDataGridView.AutoGenerateColumns = False
        Me.DesignationsDataGridView.BackgroundColor = System.Drawing.Color.Beige
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DesignationsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DesignationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DesignationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.post, Me.sv, Me.s, Me.v, Me.minBS, Me.maxBS, Me.wid, Me.gid, Me.did, Me.ss})
        Me.DesignationsDataGridView.DataSource = Me.DesignationsBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DesignationsDataGridView.DefaultCellStyle = DataGridViewCellStyle8
        Me.DesignationsDataGridView.Location = New System.Drawing.Point(298, 64)
        Me.DesignationsDataGridView.Name = "DesignationsDataGridView"
        Me.DesignationsDataGridView.ReadOnly = True
        Me.DesignationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DesignationsDataGridView.Size = New System.Drawing.Size(1037, 220)
        Me.DesignationsDataGridView.TabIndex = 40
        '
        'post
        '
        Me.post.DataPropertyName = "post"
        Me.post.HeaderText = "Designation"
        Me.post.Name = "post"
        Me.post.ReadOnly = True
        Me.post.Width = 468
        '
        'sv
        '
        Me.sv.DataPropertyName = "sv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.sv.DefaultCellStyle = DataGridViewCellStyle3
        Me.sv.HeaderText = "Senction Strength"
        Me.sv.Name = "sv"
        Me.sv.ReadOnly = True
        '
        's
        '
        Me.s.DataPropertyName = "s"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.s.DefaultCellStyle = DataGridViewCellStyle4
        Me.s.HeaderText = "In Position"
        Me.s.Name = "s"
        Me.s.ReadOnly = True
        '
        'v
        '
        Me.v.DataPropertyName = "v"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.v.DefaultCellStyle = DataGridViewCellStyle5
        Me.v.HeaderText = "Vacant Posts"
        Me.v.Name = "v"
        Me.v.ReadOnly = True
        '
        'minBS
        '
        Me.minBS.DataPropertyName = "minBS"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.minBS.DefaultCellStyle = DataGridViewCellStyle6
        Me.minBS.HeaderText = "Minimum BPS"
        Me.minBS.Name = "minBS"
        Me.minBS.ReadOnly = True
        '
        'maxBS
        '
        Me.maxBS.DataPropertyName = "maxBS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.maxBS.DefaultCellStyle = DataGridViewCellStyle7
        Me.maxBS.HeaderText = "Maximum BPS"
        Me.maxBS.Name = "maxBS"
        Me.maxBS.ReadOnly = True
        '
        'wid
        '
        Me.wid.DataPropertyName = "wid"
        Me.wid.HeaderText = "wid"
        Me.wid.Name = "wid"
        Me.wid.ReadOnly = True
        Me.wid.Visible = False
        '
        'gid
        '
        Me.gid.DataPropertyName = "gid"
        Me.gid.HeaderText = "gid"
        Me.gid.Name = "gid"
        Me.gid.ReadOnly = True
        Me.gid.Visible = False
        '
        'did
        '
        Me.did.DataPropertyName = "did"
        Me.did.HeaderText = "did"
        Me.did.Name = "did"
        Me.did.ReadOnly = True
        Me.did.Visible = False
        '
        'ss
        '
        Me.ss.DataPropertyName = "ss"
        Me.ss.HeaderText = "ss"
        Me.ss.Name = "ss"
        Me.ss.ReadOnly = True
        Me.ss.Visible = False
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "fk_emp_wid_gid_did"
        Me.EmployeeBindingSource.DataSource = Me.DesignationsBindingSource
        '
        'NicTextBox
        '
        Me.NicTextBox.BackColor = System.Drawing.Color.Beige
        Me.NicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "nic", True))
        Me.NicTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NicTextBox.Location = New System.Drawing.Point(295, 301)
        Me.NicTextBox.MaxLength = 13
        Me.NicTextBox.Name = "NicTextBox"
        Me.NicTextBox.Size = New System.Drawing.Size(121, 22)
        Me.NicTextBox.TabIndex = 2
        Me.NicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnoTextBox
        '
        Me.PnoTextBox.BackColor = System.Drawing.Color.Beige
        Me.PnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "pno", True))
        Me.PnoTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PnoTextBox.Location = New System.Drawing.Point(295, 332)
        Me.PnoTextBox.MaxLength = 8
        Me.PnoTextBox.Name = "PnoTextBox"
        Me.PnoTextBox.Size = New System.Drawing.Size(121, 22)
        Me.PnoTextBox.TabIndex = 5
        Me.PnoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EidTextBox
        '
        Me.EidTextBox.BackColor = System.Drawing.Color.Beige
        Me.EidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "eid", True))
        Me.EidTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EidTextBox.Location = New System.Drawing.Point(1212, 332)
        Me.EidTextBox.MaxLength = 3
        Me.EidTextBox.Name = "EidTextBox"
        Me.EidTextBox.Size = New System.Drawing.Size(121, 22)
        Me.EidTextBox.TabIndex = 7
        Me.EidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SrvComboBox
        '
        Me.SrvComboBox.BackColor = System.Drawing.Color.Beige
        Me.SrvComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "srv", True))
        Me.SrvComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SrvComboBox.FormattingEnabled = True
        Me.SrvComboBox.Location = New System.Drawing.Point(951, 802)
        Me.SrvComboBox.Name = "SrvComboBox"
        Me.SrvComboBox.Size = New System.Drawing.Size(121, 24)
        Me.SrvComboBox.TabIndex = 37
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.Beige
        Me.NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "name", True))
        Me.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NameTextBox.Location = New System.Drawing.Point(635, 301)
        Me.NameTextBox.MaxLength = 35
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(400, 22)
        Me.NameTextBox.TabIndex = 3
        '
        'GenderComboBox
        '
        Me.GenderComboBox.BackColor = System.Drawing.Color.Beige
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "gender", True))
        Me.GenderComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(1212, 300)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 24)
        Me.GenderComboBox.TabIndex = 4
        '
        'BsTextBox
        '
        Me.BsTextBox.BackColor = System.Drawing.Color.Beige
        Me.BsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "bs", True))
        Me.BsTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BsTextBox.Location = New System.Drawing.Point(1212, 362)
        Me.BsTextBox.MaxLength = 2
        Me.BsTextBox.Name = "BsTextBox"
        Me.BsTextBox.Size = New System.Drawing.Size(121, 22)
        Me.BsTextBox.TabIndex = 8
        Me.BsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RelComboBox
        '
        Me.RelComboBox.BackColor = System.Drawing.Color.Beige
        Me.RelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "rel", True))
        Me.RelComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RelComboBox.FormattingEnabled = True
        Me.RelComboBox.Items.AddRange(New Object() {"Muslim", "Hindu", "Christian", "Ahmadi", "Others"})
        Me.RelComboBox.Location = New System.Drawing.Point(538, 456)
        Me.RelComboBox.Name = "RelComboBox"
        Me.RelComboBox.Size = New System.Drawing.Size(123, 24)
        Me.RelComboBox.TabIndex = 14
        '
        'FatherTextBox
        '
        Me.FatherTextBox.BackColor = System.Drawing.Color.Beige
        Me.FatherTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FatherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "father", True))
        Me.FatherTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FatherTextBox.Location = New System.Drawing.Point(635, 332)
        Me.FatherTextBox.MaxLength = 35
        Me.FatherTextBox.Name = "FatherTextBox"
        Me.FatherTextBox.Size = New System.Drawing.Size(400, 22)
        Me.FatherTextBox.TabIndex = 6
        '
        'DpComboBox
        '
        Me.DpComboBox.BackColor = System.Drawing.Color.Beige
        Me.DpComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "dp", True))
        Me.DpComboBox.DataSource = Me.PvBindingSource
        Me.DpComboBox.DisplayMember = "pv"
        Me.DpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DpComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DpComboBox.FormattingEnabled = True
        Me.DpComboBox.Location = New System.Drawing.Point(295, 424)
        Me.DpComboBox.Name = "DpComboBox"
        Me.DpComboBox.Size = New System.Drawing.Size(365, 24)
        Me.DpComboBox.TabIndex = 11
        Me.DpComboBox.ValueMember = "pvid"
        '
        'PvBindingSource
        '
        Me.PvBindingSource.DataMember = "pv"
        Me.PvBindingSource.DataSource = Me.HURMISDataSet
        '
        'DdComboBox
        '
        Me.DdComboBox.BackColor = System.Drawing.Color.Beige
        Me.DdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "dd", True))
        Me.DdComboBox.DataSource = Me.DsBindingSource
        Me.DdComboBox.DisplayMember = "ds"
        Me.DdComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DdComboBox.FormattingEnabled = True
        Me.DdComboBox.Location = New System.Drawing.Point(948, 424)
        Me.DdComboBox.Name = "DdComboBox"
        Me.DdComboBox.Size = New System.Drawing.Size(385, 24)
        Me.DdComboBox.TabIndex = 12
        Me.DdComboBox.ValueMember = "ds"
        '
        'DsBindingSource
        '
        Me.DsBindingSource.DataMember = "ds"
        Me.DsBindingSource.DataSource = Me.HURMISDataSet
        '
        'SectionBindingSource
        '
        Me.SectionBindingSource.DataMember = "section"
        Me.SectionBindingSource.DataSource = Me.HURMISDataSet
        '
        'OidComboBox
        '
        Me.OidComboBox.BackColor = System.Drawing.Color.Beige
        Me.OidComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "oid", True))
        Me.OidComboBox.DataSource = Me.OfficeBindingSource
        Me.OidComboBox.DisplayMember = "office"
        Me.OidComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OidComboBox.FormattingEnabled = True
        Me.OidComboBox.Location = New System.Drawing.Point(295, 392)
        Me.OidComboBox.Name = "OidComboBox"
        Me.OidComboBox.Size = New System.Drawing.Size(365, 24)
        Me.OidComboBox.TabIndex = 9
        Me.OidComboBox.ValueMember = "oid"
        '
        'OfficeBindingSource
        '
        Me.OfficeBindingSource.DataMember = "office"
        Me.OfficeBindingSource.DataSource = Me.HURMISDataSet
        '
        'SidComboBox
        '
        Me.SidComboBox.BackColor = System.Drawing.Color.Beige
        Me.SidComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "sid", True))
        Me.SidComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SidComboBox.FormattingEnabled = True
        Me.SidComboBox.Location = New System.Drawing.Point(948, 392)
        Me.SidComboBox.Name = "SidComboBox"
        Me.SidComboBox.Size = New System.Drawing.Size(385, 24)
        Me.SidComboBox.TabIndex = 10
        '
        'BdTextBox
        '
        Me.BdTextBox.BackColor = System.Drawing.Color.Beige
        Me.BdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "bd", True))
        Me.BdTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BdTextBox.Location = New System.Drawing.Point(295, 457)
        Me.BdTextBox.MaxLength = 10
        Me.BdTextBox.Name = "BdTextBox"
        Me.BdTextBox.Size = New System.Drawing.Size(121, 22)
        Me.BdTextBox.TabIndex = 13
        Me.BdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EdTextBox
        '
        Me.EdTextBox.BackColor = System.Drawing.Color.Beige
        Me.EdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "ed", True))
        Me.EdTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EdTextBox.Location = New System.Drawing.Point(1212, 457)
        Me.EdTextBox.MaxLength = 10
        Me.EdTextBox.Name = "EdTextBox"
        Me.EdTextBox.Size = New System.Drawing.Size(121, 22)
        Me.EdTextBox.TabIndex = 15
        Me.EdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApdTextBox
        '
        Me.ApdTextBox.BackColor = System.Drawing.Color.Beige
        Me.ApdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "apd", True))
        Me.ApdTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ApdTextBox.Location = New System.Drawing.Point(295, 487)
        Me.ApdTextBox.MaxLength = 10
        Me.ApdTextBox.Name = "ApdTextBox"
        Me.ApdTextBox.Size = New System.Drawing.Size(121, 22)
        Me.ApdTextBox.TabIndex = 16
        Me.ApdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SdTextBox
        '
        Me.SdTextBox.BackColor = System.Drawing.Color.Beige
        Me.SdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "sd", True))
        Me.SdTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SdTextBox.Location = New System.Drawing.Point(1212, 487)
        Me.SdTextBox.MaxLength = 10
        Me.SdTextBox.Name = "SdTextBox"
        Me.SdTextBox.Size = New System.Drawing.Size(121, 22)
        Me.SdTextBox.TabIndex = 17
        Me.SdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CdTextBox
        '
        Me.CdTextBox.BackColor = System.Drawing.Color.Beige
        Me.CdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "cd", True))
        Me.CdTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CdTextBox.Location = New System.Drawing.Point(642, 674)
        Me.CdTextBox.MaxLength = 10
        Me.CdTextBox.Name = "CdTextBox"
        Me.CdTextBox.Size = New System.Drawing.Size(121, 22)
        Me.CdTextBox.TabIndex = 25
        Me.CdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StComboBox
        '
        Me.StComboBox.BackColor = System.Drawing.Color.Beige
        Me.StComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "st", True))
        Me.StComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StComboBox.FormattingEnabled = True
        Me.StComboBox.Location = New System.Drawing.Point(295, 673)
        Me.StComboBox.Name = "StComboBox"
        Me.StComboBox.Size = New System.Drawing.Size(196, 24)
        Me.StComboBox.TabIndex = 24
        '
        'CrComboBox
        '
        Me.CrComboBox.BackColor = System.Drawing.Color.Beige
        Me.CrComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "cr", True))
        Me.CrComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CrComboBox.FormattingEnabled = True
        Me.CrComboBox.Location = New System.Drawing.Point(838, 673)
        Me.CrComboBox.Name = "CrComboBox"
        Me.CrComboBox.Size = New System.Drawing.Size(197, 24)
        Me.CrComboBox.TabIndex = 26
        '
        'QtaComboBox
        '
        Me.QtaComboBox.BackColor = System.Drawing.Color.Beige
        Me.QtaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "qta", True))
        Me.QtaComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.QtaComboBox.FormattingEnabled = True
        Me.QtaComboBox.Location = New System.Drawing.Point(1209, 673)
        Me.QtaComboBox.Name = "QtaComboBox"
        Me.QtaComboBox.Size = New System.Drawing.Size(124, 24)
        Me.QtaComboBox.TabIndex = 27
        '
        'PhoTextBox
        '
        Me.PhoTextBox.BackColor = System.Drawing.Color.Beige
        Me.PhoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "pho", True))
        Me.PhoTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PhoTextBox.Location = New System.Drawing.Point(295, 607)
        Me.PhoTextBox.MaxLength = 20
        Me.PhoTextBox.Name = "PhoTextBox"
        Me.PhoTextBox.Size = New System.Drawing.Size(197, 22)
        Me.PhoTextBox.TabIndex = 21
        '
        'PhrTextBox
        '
        Me.PhrTextBox.BackColor = System.Drawing.Color.Beige
        Me.PhrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "phr", True))
        Me.PhrTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PhrTextBox.Location = New System.Drawing.Point(751, 607)
        Me.PhrTextBox.MaxLength = 20
        Me.PhrTextBox.Name = "PhrTextBox"
        Me.PhrTextBox.Size = New System.Drawing.Size(197, 22)
        Me.PhrTextBox.TabIndex = 22
        '
        'MobTextBox
        '
        Me.MobTextBox.BackColor = System.Drawing.Color.Beige
        Me.MobTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "mob", True))
        Me.MobTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MobTextBox.Location = New System.Drawing.Point(1209, 607)
        Me.MobTextBox.MaxLength = 11
        Me.MobTextBox.Name = "MobTextBox"
        Me.MobTextBox.Size = New System.Drawing.Size(124, 22)
        Me.MobTextBox.TabIndex = 23
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.Beige
        Me.EmailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "email", True))
        Me.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmailTextBox.Location = New System.Drawing.Point(295, 577)
        Me.EmailTextBox.MaxLength = 50
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(1038, 22)
        Me.EmailTextBox.TabIndex = 20
        '
        'PaTextBox
        '
        Me.PaTextBox.BackColor = System.Drawing.Color.Beige
        Me.PaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "pa", True))
        Me.PaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PaTextBox.Location = New System.Drawing.Point(295, 517)
        Me.PaTextBox.MaxLength = 100
        Me.PaTextBox.Name = "PaTextBox"
        Me.PaTextBox.Size = New System.Drawing.Size(1038, 22)
        Me.PaTextBox.TabIndex = 18
        '
        'TaTextBox
        '
        Me.TaTextBox.BackColor = System.Drawing.Color.Beige
        Me.TaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "ta", True))
        Me.TaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TaTextBox.Location = New System.Drawing.Point(295, 547)
        Me.TaTextBox.MaxLength = 100
        Me.TaTextBox.Name = "TaTextBox"
        Me.TaTextBox.Size = New System.Drawing.Size(1038, 22)
        Me.TaTextBox.TabIndex = 19
        '
        'NokRelComboBox
        '
        Me.NokRelComboBox.BackColor = System.Drawing.Color.Beige
        Me.NokRelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "nokRel", True))
        Me.NokRelComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NokRelComboBox.FormattingEnabled = True
        Me.NokRelComboBox.Items.AddRange(New Object() {"Spouse", "Son", "Daughter", "Brother", "Sister", "Father", "Mother"})
        Me.NokRelComboBox.Location = New System.Drawing.Point(295, 705)
        Me.NokRelComboBox.Name = "NokRelComboBox"
        Me.NokRelComboBox.Size = New System.Drawing.Size(198, 24)
        Me.NokRelComboBox.TabIndex = 28
        '
        'NokNameTextBox
        '
        Me.NokNameTextBox.BackColor = System.Drawing.Color.Beige
        Me.NokNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "nokName", True))
        Me.NokNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NokNameTextBox.Location = New System.Drawing.Point(950, 706)
        Me.NokNameTextBox.MaxLength = 35
        Me.NokNameTextBox.Name = "NokNameTextBox"
        Me.NokNameTextBox.Size = New System.Drawing.Size(383, 22)
        Me.NokNameTextBox.TabIndex = 29
        '
        'ExComboBox
        '
        Me.ExComboBox.AutoCompleteCustomSource.AddRange(New String() {"FBS", "PCO", "ACO"})
        Me.ExComboBox.BackColor = System.Drawing.Color.Beige
        Me.ExComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "ex", True))
        Me.ExComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExComboBox.FormattingEnabled = True
        Me.ExComboBox.Location = New System.Drawing.Point(295, 737)
        Me.ExComboBox.Name = "ExComboBox"
        Me.ExComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ExComboBox.TabIndex = 30
        '
        'PtComboBox
        '
        Me.PtComboBox.BackColor = System.Drawing.Color.Beige
        Me.PtComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "pt", True))
        Me.PtComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PtComboBox.FormattingEnabled = True
        Me.PtComboBox.Location = New System.Drawing.Point(539, 737)
        Me.PtComboBox.Name = "PtComboBox"
        Me.PtComboBox.Size = New System.Drawing.Size(121, 24)
        Me.PtComboBox.TabIndex = 31
        '
        'CountryComboBox
        '
        Me.CountryComboBox.BackColor = System.Drawing.Color.Beige
        Me.CountryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "country", True))
        Me.CountryComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CountryComboBox.FormattingEnabled = True
        Me.CountryComboBox.Location = New System.Drawing.Point(640, 770)
        Me.CountryComboBox.Name = "CountryComboBox"
        Me.CountryComboBox.Size = New System.Drawing.Size(234, 24)
        Me.CountryComboBox.TabIndex = 34
        '
        'RdTextBox
        '
        Me.RdTextBox.BackColor = System.Drawing.Color.Beige
        Me.RdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "rd", True))
        Me.RdTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RdTextBox.Location = New System.Drawing.Point(1212, 803)
        Me.RdTextBox.MaxLength = 10
        Me.RdTextBox.Name = "RdTextBox"
        Me.RdTextBox.Size = New System.Drawing.Size(121, 22)
        Me.RdTextBox.TabIndex = 38
        Me.RdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AdComboBox
        '
        Me.AdComboBox.BackColor = System.Drawing.Color.Beige
        Me.AdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "ad", True))
        Me.AdComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AdComboBox.FormattingEnabled = True
        Me.AdComboBox.Location = New System.Drawing.Point(1212, 770)
        Me.AdComboBox.Name = "AdComboBox"
        Me.AdComboBox.Size = New System.Drawing.Size(121, 24)
        Me.AdComboBox.TabIndex = 36
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.BackColor = System.Drawing.Color.Beige
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "remarks", True))
        Me.RemarksTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RemarksTextBox.Location = New System.Drawing.Point(295, 833)
        Me.RemarksTextBox.MaxLength = 250
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(1040, 22)
        Me.RemarksTextBox.TabIndex = 39
        '
        'DoeTextBox
        '
        Me.DoeTextBox.BackColor = System.Drawing.Color.Beige
        Me.DoeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "doe", True))
        Me.DoeTextBox.Enabled = False
        Me.DoeTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DoeTextBox.Location = New System.Drawing.Point(92, 891)
        Me.DoeTextBox.MaxLength = 10
        Me.DoeTextBox.Name = "DoeTextBox"
        Me.DoeTextBox.Size = New System.Drawing.Size(84, 22)
        Me.DoeTextBox.TabIndex = 85
        '
        'DeoTextBox
        '
        Me.DeoTextBox.BackColor = System.Drawing.Color.Beige
        Me.DeoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "deo", True))
        Me.DeoTextBox.Enabled = False
        Me.DeoTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeoTextBox.Location = New System.Drawing.Point(92, 916)
        Me.DeoTextBox.Name = "DeoTextBox"
        Me.DeoTextBox.Size = New System.Drawing.Size(84, 22)
        Me.DeoTextBox.TabIndex = 87
        '
        'EmployeeBindingNavigator
        '
        Me.EmployeeBindingNavigator.AddNewItem = Nothing
        Me.EmployeeBindingNavigator.BindingSource = Me.EmployeeBindingSource
        Me.EmployeeBindingNavigator.CountItem = Me.BindingNavigatorCountItem1
        Me.EmployeeBindingNavigator.DeleteItem = Nothing
        Me.EmployeeBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EmployeeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5})
        Me.EmployeeBindingNavigator.Location = New System.Drawing.Point(0, 956)
        Me.EmployeeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.EmployeeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.EmployeeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.EmployeeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.EmployeeBindingNavigator.Name = "EmployeeBindingNavigator"
        Me.EmployeeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem1
        Me.EmployeeBindingNavigator.Size = New System.Drawing.Size(1584, 25)
        Me.EmployeeBindingNavigator.TabIndex = 98
        Me.EmployeeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.Transparent
        Me.SaveButton.Location = New System.Drawing.Point(586, 889)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(210, 36)
        Me.SaveButton.TabIndex = 40
        Me.SaveButton.Text = "Save Change(s)"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'goBackButton
        '
        Me.goBackButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.goBackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.goBackButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goBackButton.ForeColor = System.Drawing.Color.Transparent
        Me.goBackButton.Location = New System.Drawing.Point(799, 889)
        Me.goBackButton.Margin = New System.Windows.Forms.Padding(4)
        Me.goBackButton.Name = "goBackButton"
        Me.goBackButton.Size = New System.Drawing.Size(210, 36)
        Me.goBackButton.TabIndex = 41
        Me.goBackButton.Text = "Go Back"
        Me.goBackButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(258, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1119, 30)
        Me.Label1.TabIndex = 1011
        Me.Label1.Text = "Designation-wise Officers and Officials of Pakistan Bureau of Statistics"
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logoPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logoPictureBox.BackgroundImage = CType(resources.GetObject("logoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoPictureBox.Location = New System.Drawing.Point(1425, 28)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(139, 72)
        Me.logoPictureBox.TabIndex = 1026
        Me.logoPictureBox.TabStop = False
        '
        'govLogoPictureBox
        '
        Me.govLogoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.govLogoPictureBox.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.govLogoPictureBox.BackgroundImage = CType(resources.GetObject("govLogoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.govLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.govLogoPictureBox.Location = New System.Drawing.Point(15, 26)
        Me.govLogoPictureBox.Name = "govLogoPictureBox"
        Me.govLogoPictureBox.Size = New System.Drawing.Size(97, 94)
        Me.govLogoPictureBox.TabIndex = 1027
        Me.govLogoPictureBox.TabStop = False
        '
        'PvTableAdapter
        '
        Me.PvTableAdapter.ClearBeforeFill = True
        '
        'searchLabel
        '
        Me.searchLabel.AutoSize = True
        Me.searchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchLabel.Location = New System.Drawing.Point(39, 140)
        Me.searchLabel.Name = "searchLabel"
        Me.searchLabel.Size = New System.Drawing.Size(222, 24)
        Me.searchLabel.TabIndex = 1028
        Me.searchLabel.Text = "Search for Designation"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Olive
        Me.Label4.Location = New System.Drawing.Point(465, 936)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(854, 15)
        Me.Label4.TabIndex = 1030
        Me.Label4.Text = "POWERED BY DATA PROCESSING CENTER , SUPPORT SERVICES WING, PBS HEADQUATER, ISLAMA" &
    "BAD        :        VERSION 2.0.0"
        '
        'OfficeTableAdapter
        '
        Me.OfficeTableAdapter.ClearBeforeFill = True
        '
        'SectionTableAdapter
        '
        Me.SectionTableAdapter.ClearBeforeFill = True
        '
        'HhComboBox
        '
        Me.HhComboBox.BackColor = System.Drawing.Color.Beige
        Me.HhComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "hh", True))
        Me.HhComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhComboBox.FormattingEnabled = True
        Me.HhComboBox.Location = New System.Drawing.Point(951, 737)
        Me.HhComboBox.Name = "HhComboBox"
        Me.HhComboBox.Size = New System.Drawing.Size(121, 24)
        Me.HhComboBox.TabIndex = 32
        '
        'DnComboBox
        '
        Me.DnComboBox.BackColor = System.Drawing.Color.Beige
        Me.DnComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "dn", True))
        Me.DnComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DnComboBox.FormattingEnabled = True
        Me.DnComboBox.Location = New System.Drawing.Point(295, 770)
        Me.DnComboBox.Name = "DnComboBox"
        Me.DnComboBox.Size = New System.Drawing.Size(121, 24)
        Me.DnComboBox.TabIndex = 33
        '
        'DsTableAdapter
        '
        Me.DsTableAdapter.ClearBeforeFill = True
        '
        'NroComboBox
        '
        Me.NroComboBox.BackColor = System.Drawing.Color.Beige
        Me.NroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.EmployeeBindingSource, "nro", True))
        Me.NroComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NroComboBox.FormattingEnabled = True
        Me.NroComboBox.Location = New System.Drawing.Point(951, 770)
        Me.NroComboBox.Name = "NroComboBox"
        Me.NroComboBox.Size = New System.Drawing.Size(121, 24)
        Me.NroComboBox.TabIndex = 35
        '
        'dLabel
        '
        Me.dLabel.AutoSize = True
        Me.dLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dLabel.Location = New System.Drawing.Point(295, 364)
        Me.dLabel.Name = "dLabel"
        Me.dLabel.Size = New System.Drawing.Size(97, 18)
        Me.dLabel.TabIndex = 1035
        Me.dLabel.Text = "Designation"
        '
        'qualificationPanel
        '
        Me.qualificationPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.qualificationPanel.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.qualificationPanel.Controls.Add(Me.qDeleteButton)
        Me.qualificationPanel.Controls.Add(Me.qAddButton)
        Me.qualificationPanel.Controls.Add(Me.YrTextBox)
        Me.qualificationPanel.Controls.Add(Me.EdnComboBox)
        Me.qualificationPanel.Controls.Add(Me.SubjTextBox)
        Me.qualificationPanel.Controls.Add(Me.DivComboBox)
        Me.qualificationPanel.Controls.Add(Me.UniTextBox)
        Me.qualificationPanel.Controls.Add(Me.GpaTextBox)
        Me.qualificationPanel.Controls.Add(Me.DurationComboBox)
        Me.qualificationPanel.Controls.Add(Me.CountryComboBox1)
        Me.qualificationPanel.Controls.Add(Me.Label2)
        Me.qualificationPanel.Controls.Add(Me.QualificationDataGridView)
        Me.qualificationPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.qualificationPanel.Location = New System.Drawing.Point(81, 515)
        Me.qualificationPanel.Name = "qualificationPanel"
        Me.qualificationPanel.Size = New System.Drawing.Size(1417, 370)
        Me.qualificationPanel.TabIndex = 1036
        Me.qualificationPanel.Visible = False
        '
        'qDeleteButton
        '
        Me.qDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.qDeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.qDeleteButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qDeleteButton.ForeColor = System.Drawing.Color.Transparent
        Me.qDeleteButton.Location = New System.Drawing.Point(825, 329)
        Me.qDeleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.qDeleteButton.Name = "qDeleteButton"
        Me.qDeleteButton.Size = New System.Drawing.Size(315, 36)
        Me.qDeleteButton.TabIndex = 1013
        Me.qDeleteButton.Text = "Delete Selected Qualification"
        Me.qDeleteButton.UseVisualStyleBackColor = False
        '
        'qAddButton
        '
        Me.qAddButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.qAddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.qAddButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qAddButton.ForeColor = System.Drawing.Color.Transparent
        Me.qAddButton.Location = New System.Drawing.Point(506, 329)
        Me.qAddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.qAddButton.Name = "qAddButton"
        Me.qAddButton.Size = New System.Drawing.Size(315, 36)
        Me.qAddButton.TabIndex = 1012
        Me.qAddButton.Text = "Add Qualification"
        Me.qAddButton.UseVisualStyleBackColor = False
        '
        'YrTextBox
        '
        Me.YrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "yr", True))
        Me.YrTextBox.Location = New System.Drawing.Point(60, 297)
        Me.YrTextBox.MaxLength = 4
        Me.YrTextBox.Name = "YrTextBox"
        Me.YrTextBox.Size = New System.Drawing.Size(84, 22)
        Me.YrTextBox.TabIndex = 76
        Me.YrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QualificationBindingSource
        '
        Me.QualificationBindingSource.DataMember = "fk_qua_nic"
        Me.QualificationBindingSource.DataSource = Me.EmployeeBindingSource
        '
        'EdnComboBox
        '
        Me.EdnComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.QualificationBindingSource, "edn", True))
        Me.EdnComboBox.DataSource = Me.EducationBindingSource
        Me.EdnComboBox.DisplayMember = "eab"
        Me.EdnComboBox.FormattingEnabled = True
        Me.EdnComboBox.Location = New System.Drawing.Point(149, 296)
        Me.EdnComboBox.Name = "EdnComboBox"
        Me.EdnComboBox.Size = New System.Drawing.Size(121, 24)
        Me.EdnComboBox.TabIndex = 78
        Me.EdnComboBox.ValueMember = "eab"
        '
        'EducationBindingSource
        '
        Me.EducationBindingSource.DataMember = "education"
        Me.EducationBindingSource.DataSource = Me.HURMISDataSet
        '
        'SubjTextBox
        '
        Me.SubjTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "subj", True))
        Me.SubjTextBox.Location = New System.Drawing.Point(276, 297)
        Me.SubjTextBox.Name = "SubjTextBox"
        Me.SubjTextBox.Size = New System.Drawing.Size(327, 22)
        Me.SubjTextBox.TabIndex = 80
        '
        'DivComboBox
        '
        Me.DivComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "div", True))
        Me.DivComboBox.FormattingEnabled = True
        Me.DivComboBox.Items.AddRange(New Object() {"1st", "2nd", "3rd", "A+", "A", "B", "C", "D", "E"})
        Me.DivComboBox.Location = New System.Drawing.Point(609, 296)
        Me.DivComboBox.Name = "DivComboBox"
        Me.DivComboBox.Size = New System.Drawing.Size(91, 24)
        Me.DivComboBox.TabIndex = 82
        '
        'UniTextBox
        '
        Me.UniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "uni", True))
        Me.UniTextBox.Location = New System.Drawing.Point(706, 297)
        Me.UniTextBox.Name = "UniTextBox"
        Me.UniTextBox.Size = New System.Drawing.Size(327, 22)
        Me.UniTextBox.TabIndex = 84
        '
        'GpaTextBox
        '
        Me.GpaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "gpa", True))
        Me.GpaTextBox.Location = New System.Drawing.Point(1133, 297)
        Me.GpaTextBox.Name = "GpaTextBox"
        Me.GpaTextBox.Size = New System.Drawing.Size(67, 22)
        Me.GpaTextBox.TabIndex = 86
        Me.GpaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DurationComboBox
        '
        Me.DurationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "duration", True))
        Me.DurationComboBox.FormattingEnabled = True
        Me.DurationComboBox.Items.AddRange(New Object() {"1 year", "2 years", "3 years", "4 years", "5 years", "8 years"})
        Me.DurationComboBox.Location = New System.Drawing.Point(1039, 296)
        Me.DurationComboBox.Name = "DurationComboBox"
        Me.DurationComboBox.Size = New System.Drawing.Size(90, 24)
        Me.DurationComboBox.TabIndex = 85
        '
        'CountryComboBox1
        '
        Me.CountryComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationBindingSource, "country", True))
        Me.CountryComboBox1.FormattingEnabled = True
        Me.CountryComboBox1.Items.AddRange(New Object() {"Pakistan", "U.K.", "Netherlands", "Holland", "Italy"})
        Me.CountryComboBox1.Location = New System.Drawing.Point(1206, 296)
        Me.CountryComboBox1.Name = "CountryComboBox1"
        Me.CountryComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.CountryComboBox1.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Algerian", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(433, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(547, 30)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "QUALIFICATION(S) / EDUCATION DETAIL"
        '
        'QualificationDataGridView
        '
        Me.QualificationDataGridView.AllowUserToAddRows = False
        Me.QualificationDataGridView.AllowUserToDeleteRows = False
        Me.QualificationDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.QualificationDataGridView.AutoGenerateColumns = False
        Me.QualificationDataGridView.BackgroundColor = System.Drawing.Color.Beige
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QualificationDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.QualificationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QualificationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn1})
        Me.QualificationDataGridView.DataSource = Me.QualificationBindingSource
        Me.QualificationDataGridView.Location = New System.Drawing.Point(14, 48)
        Me.QualificationDataGridView.Name = "QualificationDataGridView"
        Me.QualificationDataGridView.ReadOnly = True
        Me.QualificationDataGridView.Size = New System.Drawing.Size(1385, 244)
        Me.QualificationDataGridView.TabIndex = 0
        '
        'qualificationButton
        '
        Me.qualificationButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.qualificationButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.qualificationButton.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qualificationButton.ForeColor = System.Drawing.Color.Transparent
        Me.qualificationButton.Location = New System.Drawing.Point(1011, 889)
        Me.qualificationButton.Margin = New System.Windows.Forms.Padding(4)
        Me.qualificationButton.Name = "qualificationButton"
        Me.qualificationButton.Size = New System.Drawing.Size(210, 36)
        Me.qualificationButton.TabIndex = 1037
        Me.qualificationButton.Text = "Show Qualification(s)"
        Me.qualificationButton.UseVisualStyleBackColor = False
        '
        'EducationTableAdapter
        '
        Me.EducationTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.DataSource = Me.DesignationBindingSource
        Me.ComboBox1.DisplayMember = "designation"
        Me.ComboBox1.DropDownHeight = 720
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.ItemHeight = 16
        Me.ComboBox1.Location = New System.Drawing.Point(15, 166)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(277, 24)
        Me.ComboBox1.TabIndex = 1038
        Me.ComboBox1.ValueMember = "designation"
        '
        'DesignationBindingSource
        '
        Me.DesignationBindingSource.DataMember = "designation"
        Me.DesignationBindingSource.DataSource = Me.HURMISDataSet
        '
        'DesignationTableAdapter
        '
        Me.DesignationTableAdapter.ClearBeforeFill = True
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FotoPictureBox.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.FotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FotoPictureBox.Location = New System.Drawing.Point(1425, 300)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(139, 144)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPictureBox.TabIndex = 1043
        Me.FotoPictureBox.TabStop = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "yr"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Passing Year"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 4
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "edn"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.EducationBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "eab"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Education(s)"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "eab"
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "subj"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Subject(s)"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 40
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 350
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "div"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Division / Grade"
        Me.DataGridViewTextBoxColumn5.Items.AddRange(New Object() {"1st", "2nd", "3rd", "A+", "A", "B", "C", "D", "E"})
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "uni"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Board/University"
        Me.DataGridViewTextBoxColumn6.MaxInputLength = 60
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 350
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "duration"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Duration (in years)"
        Me.DataGridViewTextBoxColumn9.Items.AddRange(New Object() {"1 year", "2 years", "3 years", "4 years", "5 years", "8 years"})
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "gpa"
        Me.DataGridViewTextBoxColumn8.HeaderText = "GPA"
        Me.DataGridViewTextBoxColumn8.MaxInputLength = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "country"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn10.Items.AddRange(New Object() {"Pakistan", "U.K.", "Netherlands", "Holland", "Italy"})
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.Width = 180
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nic"
        Me.DataGridViewTextBoxColumn1.HeaderText = "nic"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 13
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'F2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(1584, 981)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.qualificationButton)
        Me.Controls.Add(Me.qualificationPanel)
        Me.Controls.Add(Me.dLabel)
        Me.Controls.Add(Me.NroComboBox)
        Me.Controls.Add(Me.DnComboBox)
        Me.Controls.Add(Me.HhComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.logoPictureBox)
        Me.Controls.Add(Me.govLogoPictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.goBackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.EmployeeBindingNavigator)
        Me.Controls.Add(NicLabel)
        Me.Controls.Add(Me.NicTextBox)
        Me.Controls.Add(PnoLabel)
        Me.Controls.Add(Me.PnoTextBox)
        Me.Controls.Add(EidLabel)
        Me.Controls.Add(Me.EidTextBox)
        Me.Controls.Add(SrvLabel)
        Me.Controls.Add(Me.SrvComboBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(BsLabel)
        Me.Controls.Add(Me.BsTextBox)
        Me.Controls.Add(RelLabel)
        Me.Controls.Add(Me.RelComboBox)
        Me.Controls.Add(FatherLabel)
        Me.Controls.Add(Me.FatherTextBox)
        Me.Controls.Add(DpLabel)
        Me.Controls.Add(Me.DpComboBox)
        Me.Controls.Add(DdLabel)
        Me.Controls.Add(Me.DdComboBox)
        Me.Controls.Add(OidLabel)
        Me.Controls.Add(Me.OidComboBox)
        Me.Controls.Add(SidLabel)
        Me.Controls.Add(Me.SidComboBox)
        Me.Controls.Add(BdLabel)
        Me.Controls.Add(Me.BdTextBox)
        Me.Controls.Add(EdLabel)
        Me.Controls.Add(Me.EdTextBox)
        Me.Controls.Add(ApdLabel)
        Me.Controls.Add(Me.ApdTextBox)
        Me.Controls.Add(SdLabel)
        Me.Controls.Add(Me.SdTextBox)
        Me.Controls.Add(CdLabel)
        Me.Controls.Add(Me.CdTextBox)
        Me.Controls.Add(StLabel)
        Me.Controls.Add(Me.StComboBox)
        Me.Controls.Add(CrLabel)
        Me.Controls.Add(Me.CrComboBox)
        Me.Controls.Add(QtaLabel)
        Me.Controls.Add(Me.QtaComboBox)
        Me.Controls.Add(PhoLabel)
        Me.Controls.Add(Me.PhoTextBox)
        Me.Controls.Add(PhrLabel)
        Me.Controls.Add(Me.PhrTextBox)
        Me.Controls.Add(MobLabel)
        Me.Controls.Add(Me.MobTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PaLabel)
        Me.Controls.Add(Me.PaTextBox)
        Me.Controls.Add(TaLabel)
        Me.Controls.Add(Me.TaTextBox)
        Me.Controls.Add(NokRelLabel)
        Me.Controls.Add(Me.NokRelComboBox)
        Me.Controls.Add(NokNameLabel)
        Me.Controls.Add(Me.NokNameTextBox)
        Me.Controls.Add(ExLabel)
        Me.Controls.Add(Me.ExComboBox)
        Me.Controls.Add(PtLabel)
        Me.Controls.Add(Me.PtComboBox)
        Me.Controls.Add(HhLabel)
        Me.Controls.Add(DnLabel)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryComboBox)
        Me.Controls.Add(NroLabel)
        Me.Controls.Add(RdLabel)
        Me.Controls.Add(Me.RdTextBox)
        Me.Controls.Add(AdLabel)
        Me.Controls.Add(Me.AdComboBox)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(DoeLabel)
        Me.Controls.Add(Me.DoeTextBox)
        Me.Controls.Add(DeoLabel)
        Me.Controls.Add(Me.DeoTextBox)
        Me.Controls.Add(DesignationLabel)
        Me.Controls.Add(Me.DesignationsDataGridView)
        Me.Controls.Add(Me.DesignationsBindingNavigator)
        Me.Controls.Add(Me.searchLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "F2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Human Resource Management and Information System (HURMIS) of Pakistan Bureau of S" &
    "tatistics"
        CType(Me.HURMISDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DesignationsBindingNavigator.ResumeLayout(False)
        Me.DesignationsBindingNavigator.PerformLayout()
        CType(Me.DesignationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeBindingNavigator.ResumeLayout(False)
        Me.EmployeeBindingNavigator.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.govLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.qualificationPanel.ResumeLayout(False)
        Me.qualificationPanel.PerformLayout()
        CType(Me.QualificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EducationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualificationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HURMISDataSet As HURMIS.HURMISDataSet
    Friend WithEvents DesignationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DesignationsTableAdapter As HURMIS.HURMISDataSetTableAdapters.designationsTableAdapter
    Friend WithEvents TableAdapterManager As HURMIS.HURMISDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DesignationsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DesignationsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmployeeTableAdapter As HURMIS.HURMISDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SrvComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FatherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DpComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OidComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SidComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CrComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QtaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PhoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NokRelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NokNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PtComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CountryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DoeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents goBackButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents govLogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PvTableAdapter As HURMIS.HURMISDataSetTableAdapters.pvTableAdapter
    Friend WithEvents searchLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OfficeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OfficeTableAdapter As HURMIS.HURMISDataSetTableAdapters.officeTableAdapter
    Friend WithEvents SectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SectionTableAdapter As HURMIS.HURMISDataSetTableAdapters.sectionTableAdapter
    Friend WithEvents HhComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DnComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTableAdapter As HURMIS.HURMISDataSetTableAdapters.dsTableAdapter
    Friend WithEvents NroComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents post As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents minBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents maxBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents did As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dLabel As System.Windows.Forms.Label
    Friend WithEvents qualificationPanel As System.Windows.Forms.Panel
    Friend WithEvents qualificationButton As System.Windows.Forms.Button
    Friend WithEvents QualificationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QualificationTableAdapter As HURMIS.HURMISDataSetTableAdapters.qualificationTableAdapter
    Friend WithEvents QualificationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EducationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EducationTableAdapter As HURMIS.HURMISDataSetTableAdapters.educationTableAdapter
    Friend WithEvents YrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EdnComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubjTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DivComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GpaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DurationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CountryComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents qDeleteButton As System.Windows.Forms.Button
    Friend WithEvents qAddButton As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DesignationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DesignationTableAdapter As HURMIS.HURMISDataSetTableAdapters.designationTableAdapter
    Friend WithEvents FotoPictureBox As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
