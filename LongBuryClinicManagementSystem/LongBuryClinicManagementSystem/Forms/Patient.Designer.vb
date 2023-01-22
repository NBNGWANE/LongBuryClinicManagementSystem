<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.PBappointment = New System.Windows.Forms.PictureBox()
        Me.Appointmentbtn = New System.Windows.Forms.Button()
        Me.PBtreatment = New System.Windows.Forms.PictureBox()
        Me.Treatmentbtn = New System.Windows.Forms.Button()
        Me.PBprescription = New System.Windows.Forms.PictureBox()
        Me.Prescriptionbtn = New System.Windows.Forms.Button()
        Me.PBdentistorm = New System.Windows.Forms.PictureBox()
        Me.Dentistbtn = New System.Windows.Forms.Button()
        Me.PBpayment = New System.Windows.Forms.PictureBox()
        Me.Paymentbtn = New System.Windows.Forms.Button()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PBlists = New System.Windows.Forms.PictureBox()
        Me.Listsbtn = New System.Windows.Forms.Button()
        Me.PatientDGV = New System.Windows.Forms.DataGridView()
        Me.BSpatient = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSpatient = New LongBuryClinicManagementSystem.DSDBproject()
        Me.TApatient = New LongBuryClinicManagementSystem.DSDBprojectTableAdapters.TblPatientTableAdapter()
        Me.AddPatient = New System.Windows.Forms.Button()
        Me.Updatebtn = New System.Windows.Forms.Button()
        Me.PatientGB = New System.Windows.Forms.GroupBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.ChooseImagebtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Medicalaidcombobox = New System.Windows.Forms.ComboBox()
        Me.PBpatient = New System.Windows.Forms.PictureBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dobpatient = New System.Windows.Forms.DateTimePicker()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.gendercombobox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PatientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalAidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientPhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.PBappointment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBtreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBprescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBdentistorm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PBlists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientGB.SuspendLayout()
        CType(Me.PBpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel3.Controls.Add(Me.label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(200, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(760, 46)
        Me.Panel3.TabIndex = 3
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(6, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(77, 30)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Patient"
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
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(5, 46)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(99, 37)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Patient"
        '
        'PBappointment
        '
        Me.PBappointment.Image = CType(resources.GetObject("PBappointment.Image"), System.Drawing.Image)
        Me.PBappointment.Location = New System.Drawing.Point(3, 176)
        Me.PBappointment.Name = "PBappointment"
        Me.PBappointment.Size = New System.Drawing.Size(44, 50)
        Me.PBappointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBappointment.TabIndex = 2
        Me.PBappointment.TabStop = False
        '
        'Appointmentbtn
        '
        Me.Appointmentbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Appointmentbtn.FlatAppearance.BorderSize = 0
        Me.Appointmentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Appointmentbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appointmentbtn.Location = New System.Drawing.Point(43, 176)
        Me.Appointmentbtn.Name = "Appointmentbtn"
        Me.Appointmentbtn.Size = New System.Drawing.Size(151, 50)
        Me.Appointmentbtn.TabIndex = 3
        Me.Appointmentbtn.Text = "Appointment"
        Me.Appointmentbtn.UseVisualStyleBackColor = False
        '
        'PBtreatment
        '
        Me.PBtreatment.Image = CType(resources.GetObject("PBtreatment.Image"), System.Drawing.Image)
        Me.PBtreatment.Location = New System.Drawing.Point(0, 243)
        Me.PBtreatment.Name = "PBtreatment"
        Me.PBtreatment.Size = New System.Drawing.Size(44, 50)
        Me.PBtreatment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBtreatment.TabIndex = 4
        Me.PBtreatment.TabStop = False
        '
        'Treatmentbtn
        '
        Me.Treatmentbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Treatmentbtn.FlatAppearance.BorderSize = 0
        Me.Treatmentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Treatmentbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Treatmentbtn.Location = New System.Drawing.Point(43, 243)
        Me.Treatmentbtn.Name = "Treatmentbtn"
        Me.Treatmentbtn.Size = New System.Drawing.Size(151, 50)
        Me.Treatmentbtn.TabIndex = 5
        Me.Treatmentbtn.Text = "Treatment"
        Me.Treatmentbtn.UseVisualStyleBackColor = False
        '
        'PBprescription
        '
        Me.PBprescription.Image = CType(resources.GetObject("PBprescription.Image"), System.Drawing.Image)
        Me.PBprescription.Location = New System.Drawing.Point(0, 313)
        Me.PBprescription.Name = "PBprescription"
        Me.PBprescription.Size = New System.Drawing.Size(44, 50)
        Me.PBprescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBprescription.TabIndex = 6
        Me.PBprescription.TabStop = False
        '
        'Prescriptionbtn
        '
        Me.Prescriptionbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Prescriptionbtn.FlatAppearance.BorderSize = 0
        Me.Prescriptionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Prescriptionbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prescriptionbtn.Location = New System.Drawing.Point(46, 313)
        Me.Prescriptionbtn.Name = "Prescriptionbtn"
        Me.Prescriptionbtn.Size = New System.Drawing.Size(151, 50)
        Me.Prescriptionbtn.TabIndex = 7
        Me.Prescriptionbtn.Text = "Prescription"
        Me.Prescriptionbtn.UseVisualStyleBackColor = False
        '
        'PBdentistorm
        '
        Me.PBdentistorm.Image = CType(resources.GetObject("PBdentistorm.Image"), System.Drawing.Image)
        Me.PBdentistorm.Location = New System.Drawing.Point(3, 386)
        Me.PBdentistorm.Name = "PBdentistorm"
        Me.PBdentistorm.Size = New System.Drawing.Size(44, 50)
        Me.PBdentistorm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBdentistorm.TabIndex = 8
        Me.PBdentistorm.TabStop = False
        '
        'Dentistbtn
        '
        Me.Dentistbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Dentistbtn.FlatAppearance.BorderSize = 0
        Me.Dentistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dentistbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dentistbtn.Location = New System.Drawing.Point(46, 386)
        Me.Dentistbtn.Name = "Dentistbtn"
        Me.Dentistbtn.Size = New System.Drawing.Size(151, 50)
        Me.Dentistbtn.TabIndex = 9
        Me.Dentistbtn.Text = "Dentist"
        Me.Dentistbtn.UseVisualStyleBackColor = False
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
        'pictureBox6
        '
        Me.pictureBox6.BackColor = System.Drawing.Color.White
        Me.pictureBox6.Image = CType(resources.GetObject("pictureBox6.Image"), System.Drawing.Image)
        Me.pictureBox6.Location = New System.Drawing.Point(3, 599)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(44, 50)
        Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox6.TabIndex = 12
        Me.pictureBox6.TabStop = False
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.PBlists)
        Me.Panel2.Controls.Add(Me.Listsbtn)
        Me.Panel2.Controls.Add(Me.Exitbtn)
        Me.Panel2.Controls.Add(Me.pictureBox6)
        Me.Panel2.Controls.Add(Me.Paymentbtn)
        Me.Panel2.Controls.Add(Me.PBpayment)
        Me.Panel2.Controls.Add(Me.Dentistbtn)
        Me.Panel2.Controls.Add(Me.PBdentistorm)
        Me.Panel2.Controls.Add(Me.Prescriptionbtn)
        Me.Panel2.Controls.Add(Me.PBprescription)
        Me.Panel2.Controls.Add(Me.Treatmentbtn)
        Me.Panel2.Controls.Add(Me.PBtreatment)
        Me.Panel2.Controls.Add(Me.Appointmentbtn)
        Me.Panel2.Controls.Add(Me.PBappointment)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 652)
        Me.Panel2.TabIndex = 2
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
        'Listsbtn
        '
        Me.Listsbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Listsbtn.FlatAppearance.BorderSize = 0
        Me.Listsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Listsbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listsbtn.Location = New System.Drawing.Point(43, 529)
        Me.Listsbtn.Name = "Listsbtn"
        Me.Listsbtn.Size = New System.Drawing.Size(151, 50)
        Me.Listsbtn.TabIndex = 14
        Me.Listsbtn.Text = "Lists"
        Me.Listsbtn.UseVisualStyleBackColor = False
        '
        'PatientDGV
        '
        Me.PatientDGV.AllowUserToAddRows = False
        Me.PatientDGV.AllowUserToDeleteRows = False
        Me.PatientDGV.AutoGenerateColumns = False
        Me.PatientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.PhoneNoDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn, Me.MedicalAidDataGridViewTextBoxColumn, Me.PatientPhotoDataGridViewImageColumn})
        Me.PatientDGV.DataSource = Me.BSpatient
        Me.PatientDGV.Location = New System.Drawing.Point(206, 313)
        Me.PatientDGV.Name = "PatientDGV"
        Me.PatientDGV.ReadOnly = True
        Me.PatientDGV.Size = New System.Drawing.Size(742, 336)
        Me.PatientDGV.TabIndex = 4
        '
        'BSpatient
        '
        Me.BSpatient.DataMember = "TblPatient"
        Me.BSpatient.DataSource = Me.DSpatient
        '
        'DSpatient
        '
        Me.DSpatient.DataSetName = "DSDBproject"
        Me.DSpatient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TApatient
        '
        Me.TApatient.ClearBeforeFill = True
        '
        'AddPatient
        '
        Me.AddPatient.BackColor = System.Drawing.Color.ForestGreen
        Me.AddPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPatient.ForeColor = System.Drawing.Color.White
        Me.AddPatient.Location = New System.Drawing.Point(165, 212)
        Me.AddPatient.Name = "AddPatient"
        Me.AddPatient.Size = New System.Drawing.Size(125, 43)
        Me.AddPatient.TabIndex = 5
        Me.AddPatient.Text = "Save"
        Me.AddPatient.UseVisualStyleBackColor = False
        '
        'Updatebtn
        '
        Me.Updatebtn.BackColor = System.Drawing.Color.DarkViolet
        Me.Updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updatebtn.ForeColor = System.Drawing.Color.White
        Me.Updatebtn.Location = New System.Drawing.Point(296, 212)
        Me.Updatebtn.Name = "Updatebtn"
        Me.Updatebtn.Size = New System.Drawing.Size(125, 43)
        Me.Updatebtn.TabIndex = 6
        Me.Updatebtn.Text = "Update"
        Me.Updatebtn.UseVisualStyleBackColor = False
        '
        'PatientGB
        '
        Me.PatientGB.Controls.Add(Me.btnclear)
        Me.PatientGB.Controls.Add(Me.ChooseImagebtn)
        Me.PatientGB.Controls.Add(Me.Label7)
        Me.PatientGB.Controls.Add(Me.txtlastname)
        Me.PatientGB.Controls.Add(Me.Medicalaidcombobox)
        Me.PatientGB.Controls.Add(Me.PBpatient)
        Me.PatientGB.Controls.Add(Me.txtname)
        Me.PatientGB.Controls.Add(Me.Label6)
        Me.PatientGB.Controls.Add(Me.FirstName)
        Me.PatientGB.Controls.Add(Me.Label4)
        Me.PatientGB.Controls.Add(Me.Label5)
        Me.PatientGB.Controls.Add(Me.Label8)
        Me.PatientGB.Controls.Add(Me.dobpatient)
        Me.PatientGB.Controls.Add(Me.txtemail)
        Me.PatientGB.Controls.Add(Me.Label9)
        Me.PatientGB.Controls.Add(Me.txtaddress)
        Me.PatientGB.Controls.Add(Me.txtphone)
        Me.PatientGB.Controls.Add(Me.gendercombobox)
        Me.PatientGB.Controls.Add(Me.Label10)
        Me.PatientGB.Controls.Add(Me.AddPatient)
        Me.PatientGB.Controls.Add(Me.Updatebtn)
        Me.PatientGB.Location = New System.Drawing.Point(206, 52)
        Me.PatientGB.Name = "PatientGB"
        Me.PatientGB.Size = New System.Drawing.Size(742, 255)
        Me.PatientGB.TabIndex = 7
        Me.PatientGB.TabStop = False
        Me.PatientGB.Text = "Patient"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Orange
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(428, 212)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(121, 43)
        Me.btnclear.TabIndex = 41
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'ChooseImagebtn
        '
        Me.ChooseImagebtn.BackColor = System.Drawing.Color.MediumBlue
        Me.ChooseImagebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseImagebtn.ForeColor = System.Drawing.Color.White
        Me.ChooseImagebtn.Location = New System.Drawing.Point(571, 212)
        Me.ChooseImagebtn.Name = "ChooseImagebtn"
        Me.ChooseImagebtn.Size = New System.Drawing.Size(136, 43)
        Me.ChooseImagebtn.TabIndex = 40
        Me.ChooseImagebtn.Text = "Choose Image"
        Me.ChooseImagebtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(341, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Medical Aid"
        '
        'txtlastname
        '
        Me.txtlastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "LastName", True))
        Me.txtlastname.Location = New System.Drawing.Point(145, 89)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(126, 20)
        Me.txtlastname.TabIndex = 25
        '
        'Medicalaidcombobox
        '
        Me.Medicalaidcombobox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "MedicalAid", True))
        Me.Medicalaidcombobox.FormattingEnabled = True
        Me.Medicalaidcombobox.Items.AddRange(New Object() {"Discovey", "Old Mutual", "Bonitas", "Medicare"})
        Me.Medicalaidcombobox.Location = New System.Drawing.Point(439, 153)
        Me.Medicalaidcombobox.Name = "Medicalaidcombobox"
        Me.Medicalaidcombobox.Size = New System.Drawing.Size(126, 21)
        Me.Medicalaidcombobox.TabIndex = 38
        '
        'PBpatient
        '
        Me.PBpatient.BackColor = System.Drawing.Color.Maroon
        Me.PBpatient.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BSpatient, "PatientPhoto", True))
        Me.PBpatient.Location = New System.Drawing.Point(571, 55)
        Me.PBpatient.Name = "PBpatient"
        Me.PBpatient.Size = New System.Drawing.Size(136, 119)
        Me.PBpatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBpatient.TabIndex = 21
        Me.PBpatient.TabStop = False
        '
        'txtname
        '
        Me.txtname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "FirstName", True))
        Me.txtname.Location = New System.Drawing.Point(145, 56)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(126, 20)
        Me.txtname.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(341, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Email Address"
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(36, 63)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(54, 13)
        Me.FirstName.TabIndex = 31
        Me.FirstName.Text = "FirstName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "LastName"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(341, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "PhoneNo"
        '
        'dobpatient
        '
        Me.dobpatient.CustomFormat = "MM-dd-yyyy"
        Me.dobpatient.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "DateOfBirth", True))
        Me.dobpatient.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dobpatient.Location = New System.Drawing.Point(145, 155)
        Me.dobpatient.Name = "dobpatient"
        Me.dobpatient.Size = New System.Drawing.Size(126, 20)
        Me.dobpatient.TabIndex = 27
        '
        'txtemail
        '
        Me.txtemail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "EmailAddress", True))
        Me.txtemail.Location = New System.Drawing.Point(439, 127)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(126, 20)
        Me.txtemail.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Date of Birth"
        '
        'txtaddress
        '
        Me.txtaddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "Address", True))
        Me.txtaddress.Location = New System.Drawing.Point(439, 82)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(126, 39)
        Me.txtaddress.TabIndex = 29
        '
        'txtphone
        '
        Me.txtphone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "PhoneNo", True))
        Me.txtphone.Location = New System.Drawing.Point(439, 55)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(126, 20)
        Me.txtphone.TabIndex = 28
        '
        'gendercombobox
        '
        Me.gendercombobox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "Gender", True))
        Me.gendercombobox.FormattingEnabled = True
        Me.gendercombobox.Items.AddRange(New Object() {"Male", "Female"})
        Me.gendercombobox.Location = New System.Drawing.Point(145, 124)
        Me.gendercombobox.Name = "gendercombobox"
        Me.gendercombobox.Size = New System.Drawing.Size(126, 21)
        Me.gendercombobox.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Gender"
        '
        'PatientIDDataGridViewTextBoxColumn
        '
        Me.PatientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.HeaderText = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.Name = "PatientIDDataGridViewTextBoxColumn"
        Me.PatientIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
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
        'MedicalAidDataGridViewTextBoxColumn
        '
        Me.MedicalAidDataGridViewTextBoxColumn.DataPropertyName = "MedicalAid"
        Me.MedicalAidDataGridViewTextBoxColumn.HeaderText = "MedicalAid"
        Me.MedicalAidDataGridViewTextBoxColumn.Name = "MedicalAidDataGridViewTextBoxColumn"
        Me.MedicalAidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatientPhotoDataGridViewImageColumn
        '
        Me.PatientPhotoDataGridViewImageColumn.DataPropertyName = "PatientPhoto"
        Me.PatientPhotoDataGridViewImageColumn.HeaderText = "PatientPhoto"
        Me.PatientPhotoDataGridViewImageColumn.Name = "PatientPhotoDataGridViewImageColumn"
        Me.PatientPhotoDataGridViewImageColumn.ReadOnly = True
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 652)
        Me.Controls.Add(Me.PatientGB)
        Me.Controls.Add(Me.PatientDGV)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PBappointment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBtreatment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBprescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBdentistorm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PBlists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSpatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientGB.ResumeLayout(False)
        Me.PatientGB.PerformLayout()
        CType(Me.PBpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel3 As Panel
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents PBappointment As PictureBox
    Private WithEvents Appointmentbtn As Button
    Private WithEvents PBtreatment As PictureBox
    Private WithEvents Treatmentbtn As Button
    Private WithEvents PBprescription As PictureBox
    Private WithEvents Prescriptionbtn As Button
    Private WithEvents PBdentistorm As PictureBox
    Private WithEvents Dentistbtn As Button
    Private WithEvents PBpayment As PictureBox
    Private WithEvents Paymentbtn As Button
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents Exitbtn As Button
    Private WithEvents Panel2 As Panel
    Private WithEvents PBlists As PictureBox
    Private WithEvents Listsbtn As Button
    Friend WithEvents PatientDGV As DataGridView
    Friend WithEvents BSpatient As BindingSource
    Friend WithEvents DSpatient As DSDBproject
    Friend WithEvents TApatient As DSDBprojectTableAdapters.TblPatientTableAdapter
    Friend WithEvents AddPatient As Button
    Friend WithEvents Updatebtn As Button
    Friend WithEvents PatientGB As GroupBox
    Friend WithEvents ChooseImagebtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Medicalaidcombobox As ComboBox
    Friend WithEvents PBpatient As PictureBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FirstName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dobpatient As DateTimePicker
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents gendercombobox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents PatientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicalAidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientPhotoDataGridViewImageColumn As DataGridViewImageColumn
End Class
