<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prescription))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Listsbtn = New System.Windows.Forms.PictureBox()
        Me.Reportsbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.PBclose = New System.Windows.Forms.PictureBox()
        Me.Paymentbtn = New System.Windows.Forms.Button()
        Me.PBpayment = New System.Windows.Forms.PictureBox()
        Me.Dentistbtn = New System.Windows.Forms.Button()
        Me.PBdentist = New System.Windows.Forms.PictureBox()
        Me.Treatmentbtn = New System.Windows.Forms.Button()
        Me.PBtreatment = New System.Windows.Forms.PictureBox()
        Me.appbtn = New System.Windows.Forms.Button()
        Me.PBappoint = New System.Windows.Forms.PictureBox()
        Me.Patientbtn = New System.Windows.Forms.Button()
        Me.PBpatient = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ChooseappDGV = New System.Windows.Forms.DataGridView()
        Me.BSappointment = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSappointment = New LongBuryClinicManagementSystem.DSDBproject()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prescriptiondate = New System.Windows.Forms.DateTimePicker()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.txtappid = New System.Windows.Forms.TextBox()
        Me.txtnote = New System.Windows.Forms.TextBox()
        Me.txtassigneddentist = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.PrescriptionDGV = New System.Windows.Forms.DataGridView()
        Me.PrescriptionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientLastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrescribingDentistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrescriptionNoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrescriptionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSprescription = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAappointment = New LongBuryClinicManagementSystem.DSDBprojectTableAdapters.TblAppointmentTableAdapter()
        Me.DSprescription = New LongBuryClinicManagementSystem.DSDBproject()
        Me.TAprescription = New LongBuryClinicManagementSystem.DSDBprojectTableAdapters.TblPrescriptionTableAdapter()
        Me.AppointmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreamentCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignedDentistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.Listsbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBdentist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBtreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBappoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChooseappDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSappointment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSappointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PrescriptionDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSprescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSprescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.Listsbtn)
        Me.Panel2.Controls.Add(Me.Reportsbtn)
        Me.Panel2.Controls.Add(Me.Exitbtn)
        Me.Panel2.Controls.Add(Me.PBclose)
        Me.Panel2.Controls.Add(Me.Paymentbtn)
        Me.Panel2.Controls.Add(Me.PBpayment)
        Me.Panel2.Controls.Add(Me.Dentistbtn)
        Me.Panel2.Controls.Add(Me.PBdentist)
        Me.Panel2.Controls.Add(Me.Treatmentbtn)
        Me.Panel2.Controls.Add(Me.PBtreatment)
        Me.Panel2.Controls.Add(Me.appbtn)
        Me.Panel2.Controls.Add(Me.PBappoint)
        Me.Panel2.Controls.Add(Me.Patientbtn)
        Me.Panel2.Controls.Add(Me.PBpatient)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 652)
        Me.Panel2.TabIndex = 5
        '
        'Listsbtn
        '
        Me.Listsbtn.BackColor = System.Drawing.Color.White
        Me.Listsbtn.Image = CType(resources.GetObject("Listsbtn.Image"), System.Drawing.Image)
        Me.Listsbtn.Location = New System.Drawing.Point(3, 529)
        Me.Listsbtn.Name = "Listsbtn"
        Me.Listsbtn.Size = New System.Drawing.Size(44, 50)
        Me.Listsbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Listsbtn.TabIndex = 15
        Me.Listsbtn.TabStop = False
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
        'PBdentist
        '
        Me.PBdentist.Image = CType(resources.GetObject("PBdentist.Image"), System.Drawing.Image)
        Me.PBdentist.Location = New System.Drawing.Point(3, 386)
        Me.PBdentist.Name = "PBdentist"
        Me.PBdentist.Size = New System.Drawing.Size(44, 50)
        Me.PBdentist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBdentist.TabIndex = 8
        Me.PBdentist.TabStop = False
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
        'PBpatient
        '
        Me.PBpatient.Image = CType(resources.GetObject("PBpatient.Image"), System.Drawing.Image)
        Me.PBpatient.Location = New System.Drawing.Point(3, 176)
        Me.PBpatient.Name = "PBpatient"
        Me.PBpatient.Size = New System.Drawing.Size(44, 50)
        Me.PBpatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBpatient.TabIndex = 2
        Me.PBpatient.TabStop = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(5, 46)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(157, 37)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Prescription"
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
        Me.Panel3.TabIndex = 6
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(6, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(122, 30)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Prescription"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ChooseappDGV)
        Me.GroupBox1.Location = New System.Drawing.Point(207, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 240)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Appointment"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(402, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "SearchAppointments"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(547, 11)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 28)
        Me.TextBox1.TabIndex = 1
        '
        'ChooseappDGV
        '
        Me.ChooseappDGV.AllowUserToAddRows = False
        Me.ChooseappDGV.AllowUserToDeleteRows = False
        Me.ChooseappDGV.AutoGenerateColumns = False
        Me.ChooseappDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ChooseappDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppointmentIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.PatientLastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.TreatmentNameDataGridViewTextBoxColumn, Me.TreamentCostDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.AssignedDentistDataGridViewTextBoxColumn})
        Me.ChooseappDGV.DataSource = Me.BSappointment
        Me.ChooseappDGV.Location = New System.Drawing.Point(11, 45)
        Me.ChooseappDGV.Name = "ChooseappDGV"
        Me.ChooseappDGV.ReadOnly = True
        Me.ChooseappDGV.Size = New System.Drawing.Size(724, 182)
        Me.ChooseappDGV.TabIndex = 0
        '
        'BSappointment
        '
        Me.BSappointment.DataMember = "TblAppointment"
        Me.BSappointment.DataSource = Me.DSappointment
        '
        'DSappointment
        '
        Me.DSappointment.DataSetName = "DSDBproject"
        Me.DSappointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.clearbtn)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.prescriptiondate)
        Me.GroupBox2.Controls.Add(Me.Savebtn)
        Me.GroupBox2.Controls.Add(Me.txtappid)
        Me.GroupBox2.Controls.Add(Me.txtnote)
        Me.GroupBox2.Controls.Add(Me.txtassigneddentist)
        Me.GroupBox2.Controls.Add(Me.txtlastname)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.PrescriptionDGV)
        Me.GroupBox2.Location = New System.Drawing.Point(211, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(737, 340)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prescriptions"
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.DarkOrange
        Me.clearbtn.Location = New System.Drawing.Point(619, 69)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(112, 40)
        Me.clearbtn.TabIndex = 36
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Prescribing Dentist"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "PatientLastName"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Patient Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(305, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "AppointmentID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "PrescriptionNote"
        '
        'prescriptiondate
        '
        Me.prescriptiondate.CustomFormat = "MM-dd-yyyy"
        Me.prescriptiondate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSappointment, "Date", True))
        Me.prescriptiondate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.prescriptiondate.Location = New System.Drawing.Point(390, 66)
        Me.prescriptiondate.Name = "prescriptiondate"
        Me.prescriptiondate.Size = New System.Drawing.Size(204, 20)
        Me.prescriptiondate.TabIndex = 29
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.ForestGreen
        Me.Savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(619, 19)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(112, 44)
        Me.Savebtn.TabIndex = 6
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'txtappid
        '
        Me.txtappid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSappointment, "AppointmentID", True))
        Me.txtappid.Location = New System.Drawing.Point(390, 89)
        Me.txtappid.Name = "txtappid"
        Me.txtappid.ReadOnly = True
        Me.txtappid.Size = New System.Drawing.Size(204, 20)
        Me.txtappid.TabIndex = 5
        '
        'txtnote
        '
        Me.txtnote.Location = New System.Drawing.Point(390, 13)
        Me.txtnote.Multiline = True
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(204, 50)
        Me.txtnote.TabIndex = 4
        '
        'txtassigneddentist
        '
        Me.txtassigneddentist.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSappointment, "AssignedDentist", True))
        Me.txtassigneddentist.Location = New System.Drawing.Point(109, 86)
        Me.txtassigneddentist.Name = "txtassigneddentist"
        Me.txtassigneddentist.ReadOnly = True
        Me.txtassigneddentist.Size = New System.Drawing.Size(149, 20)
        Me.txtassigneddentist.TabIndex = 3
        '
        'txtlastname
        '
        Me.txtlastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSappointment, "PatientLastName", True))
        Me.txtlastname.Location = New System.Drawing.Point(109, 59)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.ReadOnly = True
        Me.txtlastname.Size = New System.Drawing.Size(149, 20)
        Me.txtlastname.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSappointment, "PatientName", True))
        Me.txtname.Location = New System.Drawing.Point(109, 19)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(149, 20)
        Me.txtname.TabIndex = 1
        '
        'PrescriptionDGV
        '
        Me.PrescriptionDGV.AutoGenerateColumns = False
        Me.PrescriptionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrescriptionDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrescriptionIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn1, Me.PatientLastNameDataGridViewTextBoxColumn1, Me.PrescribingDentistDataGridViewTextBoxColumn, Me.PrescriptionNoteDataGridViewTextBoxColumn, Me.PrescriptionDateDataGridViewTextBoxColumn, Me.AppointmentIDDataGridViewTextBoxColumn1})
        Me.PrescriptionDGV.DataSource = Me.BSprescription
        Me.PrescriptionDGV.Location = New System.Drawing.Point(7, 115)
        Me.PrescriptionDGV.Name = "PrescriptionDGV"
        Me.PrescriptionDGV.Size = New System.Drawing.Size(724, 219)
        Me.PrescriptionDGV.TabIndex = 0
        '
        'PrescriptionIDDataGridViewTextBoxColumn
        '
        Me.PrescriptionIDDataGridViewTextBoxColumn.DataPropertyName = "PrescriptionID"
        Me.PrescriptionIDDataGridViewTextBoxColumn.HeaderText = "PrescriptionID"
        Me.PrescriptionIDDataGridViewTextBoxColumn.Name = "PrescriptionIDDataGridViewTextBoxColumn"
        Me.PrescriptionIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatientNameDataGridViewTextBoxColumn1
        '
        Me.PatientNameDataGridViewTextBoxColumn1.DataPropertyName = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn1.HeaderText = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn1.Name = "PatientNameDataGridViewTextBoxColumn1"
        '
        'PatientLastNameDataGridViewTextBoxColumn1
        '
        Me.PatientLastNameDataGridViewTextBoxColumn1.DataPropertyName = "PatientLastName"
        Me.PatientLastNameDataGridViewTextBoxColumn1.HeaderText = "PatientLastName"
        Me.PatientLastNameDataGridViewTextBoxColumn1.Name = "PatientLastNameDataGridViewTextBoxColumn1"
        '
        'PrescribingDentistDataGridViewTextBoxColumn
        '
        Me.PrescribingDentistDataGridViewTextBoxColumn.DataPropertyName = "PrescribingDentist"
        Me.PrescribingDentistDataGridViewTextBoxColumn.HeaderText = "PrescribingDentist"
        Me.PrescribingDentistDataGridViewTextBoxColumn.Name = "PrescribingDentistDataGridViewTextBoxColumn"
        '
        'PrescriptionNoteDataGridViewTextBoxColumn
        '
        Me.PrescriptionNoteDataGridViewTextBoxColumn.DataPropertyName = "PrescriptionNote"
        Me.PrescriptionNoteDataGridViewTextBoxColumn.HeaderText = "PrescriptionNote"
        Me.PrescriptionNoteDataGridViewTextBoxColumn.Name = "PrescriptionNoteDataGridViewTextBoxColumn"
        '
        'PrescriptionDateDataGridViewTextBoxColumn
        '
        Me.PrescriptionDateDataGridViewTextBoxColumn.DataPropertyName = "PrescriptionDate"
        Me.PrescriptionDateDataGridViewTextBoxColumn.HeaderText = "PrescriptionDate"
        Me.PrescriptionDateDataGridViewTextBoxColumn.Name = "PrescriptionDateDataGridViewTextBoxColumn"
        '
        'AppointmentIDDataGridViewTextBoxColumn1
        '
        Me.AppointmentIDDataGridViewTextBoxColumn1.DataPropertyName = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn1.HeaderText = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn1.Name = "AppointmentIDDataGridViewTextBoxColumn1"
        '
        'BSprescription
        '
        Me.BSprescription.DataMember = "TblPrescription"
        Me.BSprescription.DataSource = Me.DSappointment
        '
        'TAappointment
        '
        Me.TAappointment.ClearBeforeFill = True
        '
        'DSprescription
        '
        Me.DSprescription.DataSetName = "DSDBproject"
        Me.DSprescription.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TAprescription
        '
        Me.TAprescription.ClearBeforeFill = True
        '
        'AppointmentIDDataGridViewTextBoxColumn
        '
        Me.AppointmentIDDataGridViewTextBoxColumn.DataPropertyName = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn.HeaderText = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn.Name = "AppointmentIDDataGridViewTextBoxColumn"
        Me.AppointmentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        Me.PatientNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatientLastNameDataGridViewTextBoxColumn
        '
        Me.PatientLastNameDataGridViewTextBoxColumn.DataPropertyName = "PatientLastName"
        Me.PatientLastNameDataGridViewTextBoxColumn.HeaderText = "PatientLastName"
        Me.PatientLastNameDataGridViewTextBoxColumn.Name = "PatientLastNameDataGridViewTextBoxColumn"
        Me.PatientLastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TreatmentNameDataGridViewTextBoxColumn
        '
        Me.TreatmentNameDataGridViewTextBoxColumn.DataPropertyName = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn.HeaderText = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn.Name = "TreatmentNameDataGridViewTextBoxColumn"
        Me.TreatmentNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TreamentCostDataGridViewTextBoxColumn
        '
        Me.TreamentCostDataGridViewTextBoxColumn.DataPropertyName = "TreamentCost"
        Me.TreamentCostDataGridViewTextBoxColumn.HeaderText = "TreamentCost"
        Me.TreamentCostDataGridViewTextBoxColumn.Name = "TreamentCostDataGridViewTextBoxColumn"
        Me.TreamentCostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        Me.TimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AssignedDentistDataGridViewTextBoxColumn
        '
        Me.AssignedDentistDataGridViewTextBoxColumn.DataPropertyName = "AssignedDentist"
        Me.AssignedDentistDataGridViewTextBoxColumn.HeaderText = "AssignedDentist"
        Me.AssignedDentistDataGridViewTextBoxColumn.Name = "AssignedDentistDataGridViewTextBoxColumn"
        Me.AssignedDentistDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Prescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 652)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Prescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Listsbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBdentist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBtreatment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBappoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ChooseappDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSappointment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSappointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PrescriptionDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSprescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSprescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Panel2 As Panel
    Private WithEvents Listsbtn As PictureBox
    Private WithEvents Reportsbtn As Button
    Private WithEvents Exitbtn As Button
    Private WithEvents PBclose As PictureBox
    Private WithEvents Paymentbtn As Button
    Private WithEvents PBpayment As PictureBox
    Private WithEvents Dentistbtn As Button
    Private WithEvents PBdentist As PictureBox
    Private WithEvents Treatmentbtn As Button
    Private WithEvents PBtreatment As PictureBox
    Private WithEvents appbtn As Button
    Private WithEvents PBappoint As PictureBox
    Private WithEvents Patientbtn As Button
    Private WithEvents PBpatient As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents Panel3 As Panel
    Private WithEvents label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChooseappDGV As DataGridView
    Friend WithEvents BSappointment As BindingSource
    Friend WithEvents DSappointment As DSDBproject
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Savebtn As Button
    Friend WithEvents txtappid As TextBox
    Friend WithEvents txtnote As TextBox
    Friend WithEvents txtassigneddentist As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents PrescriptionDGV As DataGridView
    Friend WithEvents PrescriptionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PatientLastNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PrescribingDentistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrescriptionNoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrescriptionDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BSprescription As BindingSource
    Friend WithEvents TAappointment As DSDBprojectTableAdapters.TblAppointmentTableAdapter
    Friend WithEvents DSprescription As DSDBproject
    Friend WithEvents TAprescription As DSDBprojectTableAdapters.TblPrescriptionTableAdapter
    Friend WithEvents prescriptiondate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents clearbtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents AppointmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientLastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TreamentCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssignedDentistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
