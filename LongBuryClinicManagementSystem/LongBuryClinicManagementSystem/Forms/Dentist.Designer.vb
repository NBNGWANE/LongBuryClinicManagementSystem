<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dentist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dentist))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PBlists = New System.Windows.Forms.PictureBox()
        Me.Reportsbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.PBclose = New System.Windows.Forms.PictureBox()
        Me.Paymentbtn = New System.Windows.Forms.Button()
        Me.PBpayment = New System.Windows.Forms.PictureBox()
        Me.Prescriptionbtn = New System.Windows.Forms.Button()
        Me.PBprescription = New System.Windows.Forms.PictureBox()
        Me.Treatmentbtn = New System.Windows.Forms.Button()
        Me.PBtreatment = New System.Windows.Forms.PictureBox()
        Me.appbtn = New System.Windows.Forms.Button()
        Me.PBappoint = New System.Windows.Forms.PictureBox()
        Me.Patientbtn = New System.Windows.Forms.Button()
        Me.PBpatientform = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.DentistDGV = New System.Windows.Forms.DataGridView()
        Me.BSDentist = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSdentist = New LongBuryClinicManagementSystem.DSDBproject()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CategoryCb = New System.Windows.Forms.ComboBox()
        Me.PBdentist = New System.Windows.Forms.PictureBox()
        Me.txtnameandlastname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dobdentist = New System.Windows.Forms.DateTimePicker()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.gendercombobox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ChooseImagebtn = New System.Windows.Forms.Button()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Updatebtn = New System.Windows.Forms.Button()
        Me.TADentist = New LongBuryClinicManagementSystem.DSDBprojectTableAdapters.TblDentistTableAdapter()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.DentistIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistPhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.PBlists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBprescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBtreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBappoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpatientform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DentistDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSDentist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSdentist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBdentist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.PBlists)
        Me.Panel2.Controls.Add(Me.Reportsbtn)
        Me.Panel2.Controls.Add(Me.Exitbtn)
        Me.Panel2.Controls.Add(Me.PBclose)
        Me.Panel2.Controls.Add(Me.Paymentbtn)
        Me.Panel2.Controls.Add(Me.PBpayment)
        Me.Panel2.Controls.Add(Me.Prescriptionbtn)
        Me.Panel2.Controls.Add(Me.PBprescription)
        Me.Panel2.Controls.Add(Me.Treatmentbtn)
        Me.Panel2.Controls.Add(Me.PBtreatment)
        Me.Panel2.Controls.Add(Me.appbtn)
        Me.Panel2.Controls.Add(Me.PBappoint)
        Me.Panel2.Controls.Add(Me.Patientbtn)
        Me.Panel2.Controls.Add(Me.PBpatientform)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 652)
        Me.Panel2.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(211, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(737, 100)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'PBlists
        '
        Me.PBlists.BackColor = System.Drawing.Color.White
        Me.PBlists.Image = CType(resources.GetObject("PBlists.Image"), System.Drawing.Image)
        Me.PBlists.Location = New System.Drawing.Point(3, 529)
        Me.PBlists.Name = "PBlists"
        Me.PBlists.Size = New System.Drawing.Size(44, 50)
        Me.PBlists.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBlists.TabIndex = 15
        Me.PBlists.TabStop = False
        '
        'Reportsbtn
        '
        Me.Reportsbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Reportsbtn.FlatAppearance.BorderSize = 0
        Me.Reportsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reportsbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reportsbtn.Location = New System.Drawing.Point(43, 529)
        Me.Reportsbtn.Name = "Reportsbtn"
        Me.Reportsbtn.Size = New System.Drawing.Size(151, 50)
        Me.Reportsbtn.TabIndex = 14
        Me.Reportsbtn.Text = "Lists"
        Me.Reportsbtn.UseVisualStyleBackColor = False
        '
        'Exitbtn
        '
        Me.Exitbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Exitbtn.FlatAppearance.BorderSize = 0
        Me.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exitbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitbtn.Location = New System.Drawing.Point(43, 599)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(151, 50)
        Me.Exitbtn.TabIndex = 13
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = False
        '
        'PBclose
        '
        Me.PBclose.BackColor = System.Drawing.Color.White
        Me.PBclose.Image = CType(resources.GetObject("PBclose.Image"), System.Drawing.Image)
        Me.PBclose.Location = New System.Drawing.Point(3, 599)
        Me.PBclose.Name = "PBclose"
        Me.PBclose.Size = New System.Drawing.Size(44, 50)
        Me.PBclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBclose.TabIndex = 12
        Me.PBclose.TabStop = False
        '
        'Paymentbtn
        '
        Me.Paymentbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Paymentbtn.FlatAppearance.BorderSize = 0
        Me.Paymentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Paymentbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paymentbtn.Location = New System.Drawing.Point(46, 456)
        Me.Paymentbtn.Name = "Paymentbtn"
        Me.Paymentbtn.Size = New System.Drawing.Size(151, 50)
        Me.Paymentbtn.TabIndex = 11
        Me.Paymentbtn.Text = "Payment"
        Me.Paymentbtn.UseVisualStyleBackColor = False
        '
        'PBpayment
        '
        Me.PBpayment.BackColor = System.Drawing.Color.White
        Me.PBpayment.Image = CType(resources.GetObject("PBpayment.Image"), System.Drawing.Image)
        Me.PBpayment.Location = New System.Drawing.Point(3, 456)
        Me.PBpayment.Name = "PBpayment"
        Me.PBpayment.Size = New System.Drawing.Size(44, 50)
        Me.PBpayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBpayment.TabIndex = 10
        Me.PBpayment.TabStop = False
        '
        'Prescriptionbtn
        '
        Me.Prescriptionbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Prescriptionbtn.FlatAppearance.BorderSize = 0
        Me.Prescriptionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Prescriptionbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prescriptionbtn.Location = New System.Drawing.Point(46, 386)
        Me.Prescriptionbtn.Name = "Prescriptionbtn"
        Me.Prescriptionbtn.Size = New System.Drawing.Size(151, 50)
        Me.Prescriptionbtn.TabIndex = 9
        Me.Prescriptionbtn.Text = "Prescription"
        Me.Prescriptionbtn.UseVisualStyleBackColor = False
        '
        'PBprescription
        '
        Me.PBprescription.Image = CType(resources.GetObject("PBprescription.Image"), System.Drawing.Image)
        Me.PBprescription.Location = New System.Drawing.Point(3, 386)
        Me.PBprescription.Name = "PBprescription"
        Me.PBprescription.Size = New System.Drawing.Size(44, 50)
        Me.PBprescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBprescription.TabIndex = 8
        Me.PBprescription.TabStop = False
        '
        'Treatmentbtn
        '
        Me.Treatmentbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Treatmentbtn.FlatAppearance.BorderSize = 0
        Me.Treatmentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Treatmentbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Treatmentbtn.Location = New System.Drawing.Point(46, 313)
        Me.Treatmentbtn.Name = "Treatmentbtn"
        Me.Treatmentbtn.Size = New System.Drawing.Size(151, 50)
        Me.Treatmentbtn.TabIndex = 7
        Me.Treatmentbtn.Text = "Treatment"
        Me.Treatmentbtn.UseVisualStyleBackColor = False
        '
        'PBtreatment
        '
        Me.PBtreatment.Image = CType(resources.GetObject("PBtreatment.Image"), System.Drawing.Image)
        Me.PBtreatment.Location = New System.Drawing.Point(0, 313)
        Me.PBtreatment.Name = "PBtreatment"
        Me.PBtreatment.Size = New System.Drawing.Size(44, 50)
        Me.PBtreatment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBtreatment.TabIndex = 6
        Me.PBtreatment.TabStop = False
        '
        'appbtn
        '
        Me.appbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.appbtn.FlatAppearance.BorderSize = 0
        Me.appbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.appbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appbtn.Location = New System.Drawing.Point(43, 243)
        Me.appbtn.Name = "appbtn"
        Me.appbtn.Size = New System.Drawing.Size(151, 50)
        Me.appbtn.TabIndex = 5
        Me.appbtn.Text = "Appointment"
        Me.appbtn.UseVisualStyleBackColor = False
        '
        'PBappoint
        '
        Me.PBappoint.Image = CType(resources.GetObject("PBappoint.Image"), System.Drawing.Image)
        Me.PBappoint.Location = New System.Drawing.Point(0, 243)
        Me.PBappoint.Name = "PBappoint"
        Me.PBappoint.Size = New System.Drawing.Size(44, 50)
        Me.PBappoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBappoint.TabIndex = 4
        Me.PBappoint.TabStop = False
        '
        'Patientbtn
        '
        Me.Patientbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Patientbtn.FlatAppearance.BorderSize = 0
        Me.Patientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Patientbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patientbtn.Location = New System.Drawing.Point(43, 176)
        Me.Patientbtn.Name = "Patientbtn"
        Me.Patientbtn.Size = New System.Drawing.Size(151, 50)
        Me.Patientbtn.TabIndex = 3
        Me.Patientbtn.Text = "Patient"
        Me.Patientbtn.UseVisualStyleBackColor = False
        '
        'PBpatientform
        '
        Me.PBpatientform.Image = CType(resources.GetObject("PBpatientform.Image"), System.Drawing.Image)
        Me.PBpatientform.Location = New System.Drawing.Point(3, 176)
        Me.PBpatientform.Name = "PBpatientform"
        Me.PBpatientform.Size = New System.Drawing.Size(44, 50)
        Me.PBpatientform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBpatientform.TabIndex = 2
        Me.PBpatientform.TabStop = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(5, 46)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(101, 37)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Dentist"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(5, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(192, 37)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Dental Surgery"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel3.Controls.Add(Me.label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(200, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(760, 46)
        Me.Panel3.TabIndex = 7
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(6, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(79, 30)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Dentist"
        '
        'DentistDGV
        '
        Me.DentistDGV.AllowUserToAddRows = False
        Me.DentistDGV.AllowUserToDeleteRows = False
        Me.DentistDGV.AutoGenerateColumns = False
        Me.DentistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DentistDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DentistIDDataGridViewTextBoxColumn, Me.FirstNameLastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.PhoneNoDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn, Me.DentistCategoryDataGridViewTextBoxColumn, Me.DentistPhotoDataGridViewImageColumn})
        Me.DentistDGV.DataSource = Me.BSDentist
        Me.DentistDGV.Location = New System.Drawing.Point(211, 313)
        Me.DentistDGV.Name = "DentistDGV"
        Me.DentistDGV.ReadOnly = True
        Me.DentistDGV.Size = New System.Drawing.Size(737, 327)
        Me.DentistDGV.TabIndex = 8
        '
        'BSDentist
        '
        Me.BSDentist.DataMember = "TblDentist"
        Me.BSDentist.DataSource = Me.DSdentist
        '
        'DSdentist
        '
        Me.DSdentist.DataSetName = "DSDBproject"
        Me.DSdentist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(550, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Dentist Category"
        '
        'CategoryCb
        '
        Me.CategoryCb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSDentist, "DentistCategory", True))
        Me.CategoryCb.FormattingEnabled = True
        Me.CategoryCb.Items.AddRange(New Object() {"General Dentist", "Pedodontist", "Orthodontist", "Periodontist", "Endodontist", "Oral Pathologist", "Prosthodontist"})
        Me.CategoryCb.Location = New System.Drawing.Point(648, 216)
        Me.CategoryCb.Name = "CategoryCb"
        Me.CategoryCb.Size = New System.Drawing.Size(126, 21)
        Me.CategoryCb.TabIndex = 55
        '
        'PBdentist
        '
        Me.PBdentist.BackColor = System.Drawing.Color.Maroon
        Me.PBdentist.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BSDentist, "DentistPhoto", True))
        Me.PBdentist.Location = New System.Drawing.Point(780, 118)
        Me.PBdentist.Name = "PBdentist"
        Me.PBdentist.Size = New System.Drawing.Size(136, 119)
        Me.PBdentist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBdentist.TabIndex = 40
        Me.PBdentist.TabStop = False
        '
        'txtnameandlastname
        '
        Me.txtnameandlastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSDentist, "FirstNameLastName", True))
        Me.txtnameandlastname.Location = New System.Drawing.Point(354, 119)
        Me.txtnameandlastname.Multiline = True
        Me.txtnameandlastname.Name = "txtnameandlastname"
        Me.txtnameandlastname.Size = New System.Drawing.Size(126, 39)
        Me.txtnameandlastname.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(550, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Email Address"
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(245, 126)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(101, 13)
        Me.FirstName.TabIndex = 48
        Me.FirstName.Text = "Name and Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(550, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(550, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "PhoneNo"
        '
        'dobdentist
        '
        Me.dobdentist.CustomFormat = "MM-dd-yyyy"
        Me.dobdentist.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSDentist, "DateOfBirth", True))
        Me.dobdentist.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dobdentist.Location = New System.Drawing.Point(354, 218)
        Me.dobdentist.Name = "dobdentist"
        Me.dobdentist.Size = New System.Drawing.Size(126, 20)
        Me.dobdentist.TabIndex = 44
        '
        'txtemail
        '
        Me.txtemail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSDentist, "EmailAddress", True))
        Me.txtemail.Location = New System.Drawing.Point(648, 190)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(126, 20)
        Me.txtemail.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(245, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Date of Birth"
        '
        'txtaddress
        '
        Me.txtaddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSDentist, "Address", True))
        Me.txtaddress.Location = New System.Drawing.Point(648, 145)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(126, 39)
        Me.txtaddress.TabIndex = 46
        '
        'txtphone
        '
        Me.txtphone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSDentist, "PhoneNo", True))
        Me.txtphone.Location = New System.Drawing.Point(648, 118)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(126, 20)
        Me.txtphone.TabIndex = 45
        '
        'gendercombobox
        '
        Me.gendercombobox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSDentist, "Gender", True))
        Me.gendercombobox.FormattingEnabled = True
        Me.gendercombobox.Items.AddRange(New Object() {"Male", "Female"})
        Me.gendercombobox.Location = New System.Drawing.Point(354, 187)
        Me.gendercombobox.Name = "gendercombobox"
        Me.gendercombobox.Size = New System.Drawing.Size(126, 21)
        Me.gendercombobox.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(245, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Gender"
        '
        'ChooseImagebtn
        '
        Me.ChooseImagebtn.BackColor = System.Drawing.Color.MediumBlue
        Me.ChooseImagebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseImagebtn.ForeColor = System.Drawing.Color.White
        Me.ChooseImagebtn.Location = New System.Drawing.Point(783, 264)
        Me.ChooseImagebtn.Name = "ChooseImagebtn"
        Me.ChooseImagebtn.Size = New System.Drawing.Size(136, 43)
        Me.ChooseImagebtn.TabIndex = 59
        Me.ChooseImagebtn.Text = "Choose Image"
        Me.ChooseImagebtn.UseVisualStyleBackColor = False
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.ForestGreen
        Me.Savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(377, 264)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(125, 43)
        Me.Savebtn.TabIndex = 57
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'Updatebtn
        '
        Me.Updatebtn.BackColor = System.Drawing.Color.DarkViolet
        Me.Updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updatebtn.ForeColor = System.Drawing.Color.White
        Me.Updatebtn.Location = New System.Drawing.Point(508, 264)
        Me.Updatebtn.Name = "Updatebtn"
        Me.Updatebtn.Size = New System.Drawing.Size(125, 43)
        Me.Updatebtn.TabIndex = 58
        Me.Updatebtn.Text = "Update"
        Me.Updatebtn.UseVisualStyleBackColor = False
        '
        'TADentist
        '
        Me.TADentist.ClearBeforeFill = True
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.DarkOrange
        Me.clearbtn.ForeColor = System.Drawing.Color.White
        Me.clearbtn.Location = New System.Drawing.Point(648, 267)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(112, 40)
        Me.clearbtn.TabIndex = 60
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'DentistIDDataGridViewTextBoxColumn
        '
        Me.DentistIDDataGridViewTextBoxColumn.DataPropertyName = "DentistID"
        Me.DentistIDDataGridViewTextBoxColumn.HeaderText = "DentistID"
        Me.DentistIDDataGridViewTextBoxColumn.Name = "DentistIDDataGridViewTextBoxColumn"
        Me.DentistIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameLastNameDataGridViewTextBoxColumn
        '
        Me.FirstNameLastNameDataGridViewTextBoxColumn.DataPropertyName = "FirstNameLastName"
        Me.FirstNameLastNameDataGridViewTextBoxColumn.HeaderText = "FirstNameLastName"
        Me.FirstNameLastNameDataGridViewTextBoxColumn.Name = "FirstNameLastNameDataGridViewTextBoxColumn"
        Me.FirstNameLastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNoDataGridViewTextBoxColumn
        '
        Me.PhoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo"
        Me.PhoneNoDataGridViewTextBoxColumn.HeaderText = "PhoneNo"
        Me.PhoneNoDataGridViewTextBoxColumn.Name = "PhoneNoDataGridViewTextBoxColumn"
        Me.PhoneNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailAddressDataGridViewTextBoxColumn
        '
        Me.EmailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn.Name = "EmailAddressDataGridViewTextBoxColumn"
        Me.EmailAddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DentistCategoryDataGridViewTextBoxColumn
        '
        Me.DentistCategoryDataGridViewTextBoxColumn.DataPropertyName = "DentistCategory"
        Me.DentistCategoryDataGridViewTextBoxColumn.HeaderText = "DentistCategory"
        Me.DentistCategoryDataGridViewTextBoxColumn.Name = "DentistCategoryDataGridViewTextBoxColumn"
        Me.DentistCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DentistPhotoDataGridViewImageColumn
        '
        Me.DentistPhotoDataGridViewImageColumn.DataPropertyName = "DentistPhoto"
        Me.DentistPhotoDataGridViewImageColumn.HeaderText = "DentistPhoto"
        Me.DentistPhotoDataGridViewImageColumn.Name = "DentistPhotoDataGridViewImageColumn"
        Me.DentistPhotoDataGridViewImageColumn.ReadOnly = True
        '
        'Dentist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 652)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.ChooseImagebtn)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.Updatebtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CategoryCb)
        Me.Controls.Add(Me.PBdentist)
        Me.Controls.Add(Me.txtnameandlastname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dobdentist)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.gendercombobox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DentistDGV)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dentist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dentist"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PBlists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBprescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBtreatment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBappoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpatientform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DentistDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSDentist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSdentist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBdentist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Panel2 As Panel
    Private WithEvents PBlists As PictureBox
    Private WithEvents Reportsbtn As Button
    Private WithEvents Exitbtn As Button
    Private WithEvents PBclose As PictureBox
    Private WithEvents Paymentbtn As Button
    Private WithEvents PBpayment As PictureBox
    Private WithEvents Prescriptionbtn As Button
    Private WithEvents PBprescription As PictureBox
    Private WithEvents Treatmentbtn As Button
    Private WithEvents PBtreatment As PictureBox
    Private WithEvents appbtn As Button
    Private WithEvents PBappoint As PictureBox
    Private WithEvents Patientbtn As Button
    Private WithEvents PBpatientform As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents Panel3 As Panel
    Private WithEvents label3 As Label
    Friend WithEvents DentistDGV As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents CategoryCb As ComboBox
    Friend WithEvents PBdentist As PictureBox
    Friend WithEvents txtnameandlastname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FirstName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dobdentist As DateTimePicker
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents gendercombobox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ChooseImagebtn As Button
    Friend WithEvents Savebtn As Button
    Friend WithEvents Updatebtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BSDentist As BindingSource
    Friend WithEvents DSdentist As DSDBproject
    Friend WithEvents TADentist As DSDBprojectTableAdapters.TblDentistTableAdapter
    Friend WithEvents clearbtn As Button
    Friend WithEvents DentistIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameLastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentistCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentistPhotoDataGridViewImageColumn As DataGridViewImageColumn
End Class
