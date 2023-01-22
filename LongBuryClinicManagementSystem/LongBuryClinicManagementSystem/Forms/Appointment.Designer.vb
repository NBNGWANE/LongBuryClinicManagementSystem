<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Appointment
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointment))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PBlists = New System.Windows.Forms.PictureBox()
        Me.Reportsbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Paymentbtn = New System.Windows.Forms.Button()
        Me.PBpayment = New System.Windows.Forms.PictureBox()
        Me.Dentistbtn = New System.Windows.Forms.Button()
        Me.PBdentist = New System.Windows.Forms.PictureBox()
        Me.Prescriptionbtn = New System.Windows.Forms.Button()
        Me.PBprescription = New System.Windows.Forms.PictureBox()
        Me.Treatmentbtn = New System.Windows.Forms.Button()
        Me.PBtreatment = New System.Windows.Forms.PictureBox()
        Me.Patientbtn = New System.Windows.Forms.Button()
        Me.PBpatient = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Appointmenttab = New System.Windows.Forms.TabControl()
        Me.ADD = New System.Windows.Forms.TabPage()
        Me.AppointmentGB = New System.Windows.Forms.GroupBox()
        Me.txtdent = New System.Windows.Forms.TextBox()
        Me.BSdentist = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPatient = New LongBuryClinicManagementSystem.DSDBproject()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.appdate = New System.Windows.Forms.DateTimePicker()
        Me.cbtime = New System.Windows.Forms.ComboBox()
        Me.txtcosttreat = New System.Windows.Forms.TextBox()
        Me.BStreatment = New System.Windows.Forms.BindingSource(Me.components)
        Me.txttreatment = New System.Windows.Forms.TextBox()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.BSpatient = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.AppointmentDGV = New System.Windows.Forms.DataGridView()
        Me.AppointmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreamentCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignedDentistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSappointment = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtp = New System.Windows.Forms.TextBox()
        Me.PatientchooseDGV = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdensearch = New System.Windows.Forms.TextBox()
        Me.ChoosedentistDGV = New System.Windows.Forms.DataGridView()
        Me.DentistIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DentistPhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChoosetreatmentDGV = New System.Windows.Forms.DataGridView()
        Me.TreatmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cancelledDGV = New System.Windows.Forms.DataGridView()
        Me.appgb = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchapp = New System.Windows.Forms.TextBox()
        Me.AppDGV = New System.Windows.Forms.DataGridView()
        Me.AppointmentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientLastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreamentCostDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignedDentistDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.emailbody = New System.Windows.Forms.TextBox()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.txtsendto = New System.Windows.Forms.TextBox()
        Me.Sendbtn = New System.Windows.Forms.Button()
        Me.TApatient = New LongBuryClinicManagementSystem.DSDBprojectTableAdapters.TblPatientTableAdapter()
        Me.DSappointment = New LongBuryClinicManagementSystem.DSDBproject()
        Me.TAappointment = New LongBuryClinicManagementSystem.DSDBprojectTableAdapters.TblAppointmentTableAdapter()
        Me.DStreatment = New LongBuryClinicManagementSystem.DSDBproject()
        Me.TAtreatment = New LongBuryClinicManagementSystem.DSDBprojectTableAdapters.TblTreatmentTableAdapter()
        Me.DSdentist = New LongBuryClinicManagementSystem.DSDBproject()
        Me.TAdentist = New LongBuryClinicManagementSystem.DSDBprojectTableAdapters.TblDentistTableAdapter()
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
        Me.Panel2.SuspendLayout()
        CType(Me.PBlists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBdentist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBprescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBtreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Appointmenttab.SuspendLayout()
        Me.ADD.SuspendLayout()
        Me.AppointmentGB.SuspendLayout()
        CType(Me.BSdentist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BStreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSappointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PatientchooseDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ChoosedentistDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ChoosetreatmentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Delete.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cancelledDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.appgb.SuspendLayout()
        CType(Me.AppDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DSappointment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DStreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSdentist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.PBlists)
        Me.Panel2.Controls.Add(Me.Reportsbtn)
        Me.Panel2.Controls.Add(Me.Exitbtn)
        Me.Panel2.Controls.Add(Me.pictureBox6)
        Me.Panel2.Controls.Add(Me.Paymentbtn)
        Me.Panel2.Controls.Add(Me.PBpayment)
        Me.Panel2.Controls.Add(Me.Dentistbtn)
        Me.Panel2.Controls.Add(Me.PBdentist)
        Me.Panel2.Controls.Add(Me.Prescriptionbtn)
        Me.Panel2.Controls.Add(Me.PBprescription)
        Me.Panel2.Controls.Add(Me.Treatmentbtn)
        Me.Panel2.Controls.Add(Me.PBtreatment)
        Me.Panel2.Controls.Add(Me.Patientbtn)
        Me.Panel2.Controls.Add(Me.PBpatient)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 652)
        Me.Panel2.TabIndex = 3
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
        'Patientbtn
        '
        Me.Patientbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Patientbtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.Patientbtn.FlatAppearance.BorderSize = 0
        Me.Patientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Patientbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patientbtn.ForeColor = System.Drawing.SystemColors.ControlText
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
        Me.label2.Size = New System.Drawing.Size(174, 37)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Appointment"
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
        Me.Panel3.TabIndex = 4
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(6, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(135, 30)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Appointment"
        '
        'Appointmenttab
        '
        Me.Appointmenttab.Controls.Add(Me.ADD)
        Me.Appointmenttab.Controls.Add(Me.TabPage1)
        Me.Appointmenttab.Controls.Add(Me.Delete)
        Me.Appointmenttab.Controls.Add(Me.TabPage2)
        Me.Appointmenttab.Location = New System.Drawing.Point(200, 46)
        Me.Appointmenttab.Name = "Appointmenttab"
        Me.Appointmenttab.SelectedIndex = 0
        Me.Appointmenttab.Size = New System.Drawing.Size(760, 606)
        Me.Appointmenttab.TabIndex = 5
        '
        'ADD
        '
        Me.ADD.Controls.Add(Me.AppointmentGB)
        Me.ADD.Controls.Add(Me.GroupBox1)
        Me.ADD.Location = New System.Drawing.Point(4, 22)
        Me.ADD.Name = "ADD"
        Me.ADD.Padding = New System.Windows.Forms.Padding(3)
        Me.ADD.Size = New System.Drawing.Size(752, 580)
        Me.ADD.TabIndex = 0
        Me.ADD.Text = "Add"
        Me.ADD.UseVisualStyleBackColor = True
        '
        'AppointmentGB
        '
        Me.AppointmentGB.Controls.Add(Me.txtdent)
        Me.AppointmentGB.Controls.Add(Me.Label14)
        Me.AppointmentGB.Controls.Add(Me.Label13)
        Me.AppointmentGB.Controls.Add(Me.Label12)
        Me.AppointmentGB.Controls.Add(Me.Label11)
        Me.AppointmentGB.Controls.Add(Me.Label10)
        Me.AppointmentGB.Controls.Add(Me.Label9)
        Me.AppointmentGB.Controls.Add(Me.Label8)
        Me.AppointmentGB.Controls.Add(Me.Label7)
        Me.AppointmentGB.Controls.Add(Me.Clearbtn)
        Me.AppointmentGB.Controls.Add(Me.Savebtn)
        Me.AppointmentGB.Controls.Add(Me.appdate)
        Me.AppointmentGB.Controls.Add(Me.cbtime)
        Me.AppointmentGB.Controls.Add(Me.txtcosttreat)
        Me.AppointmentGB.Controls.Add(Me.txttreatment)
        Me.AppointmentGB.Controls.Add(Me.txtgender)
        Me.AppointmentGB.Controls.Add(Me.txtlastname)
        Me.AppointmentGB.Controls.Add(Me.txtname)
        Me.AppointmentGB.Controls.Add(Me.AppointmentDGV)
        Me.AppointmentGB.Location = New System.Drawing.Point(7, 232)
        Me.AppointmentGB.Name = "AppointmentGB"
        Me.AppointmentGB.Size = New System.Drawing.Size(739, 348)
        Me.AppointmentGB.TabIndex = 2
        Me.AppointmentGB.TabStop = False
        Me.AppointmentGB.Text = "Make Appointment"
        '
        'txtdent
        '
        Me.txtdent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSdentist, "FirstNameLastName", True))
        Me.txtdent.Location = New System.Drawing.Point(392, 67)
        Me.txtdent.Name = "txtdent"
        Me.txtdent.ReadOnly = True
        Me.txtdent.Size = New System.Drawing.Size(154, 20)
        Me.txtdent.TabIndex = 39
        '
        'BSdentist
        '
        Me.BSdentist.DataMember = "TblDentist"
        Me.BSdentist.DataSource = Me.DSPatient
        '
        'DSPatient
        '
        Me.DSPatient.DataSetName = "DSDBproject"
        Me.DSPatient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(295, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Assigned Dentist"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(298, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Time"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(295, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "TreatmentCost"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "TreatmentName"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "PatientLatName"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Patient Name"
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.Color.OrangeRed
        Me.Clearbtn.ForeColor = System.Drawing.Color.White
        Me.Clearbtn.Location = New System.Drawing.Point(493, 109)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(107, 31)
        Me.Clearbtn.TabIndex = 30
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.ForestGreen
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(363, 109)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(107, 31)
        Me.Savebtn.TabIndex = 29
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'appdate
        '
        Me.appdate.CustomFormat = "dd-MM-yyyy"
        Me.appdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.appdate.Location = New System.Drawing.Point(392, 10)
        Me.appdate.MinDate = New Date(2021, 6, 21, 0, 0, 0, 0)
        Me.appdate.Name = "appdate"
        Me.appdate.Size = New System.Drawing.Size(154, 20)
        Me.appdate.TabIndex = 28
        Me.appdate.Value = New Date(2021, 6, 21, 0, 0, 0, 0)
        '
        'cbtime
        '
        Me.cbtime.FormattingEnabled = True
        Me.cbtime.Items.AddRange(New Object() {"08h00-10h00", "10h00-12h00", "12h00-14h00", "16h00-18h00"})
        Me.cbtime.Location = New System.Drawing.Point(392, 40)
        Me.cbtime.Name = "cbtime"
        Me.cbtime.Size = New System.Drawing.Size(154, 21)
        Me.cbtime.TabIndex = 7
        '
        'txtcosttreat
        '
        Me.txtcosttreat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BStreatment, "TreatmentCost", True))
        Me.txtcosttreat.Location = New System.Drawing.Point(106, 120)
        Me.txtcosttreat.Name = "txtcosttreat"
        Me.txtcosttreat.ReadOnly = True
        Me.txtcosttreat.Size = New System.Drawing.Size(154, 20)
        Me.txtcosttreat.TabIndex = 5
        '
        'BStreatment
        '
        Me.BStreatment.DataMember = "TblTreatment"
        Me.BStreatment.DataSource = Me.DSPatient
        '
        'txttreatment
        '
        Me.txttreatment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BStreatment, "TreatmentName", True))
        Me.txttreatment.Location = New System.Drawing.Point(106, 94)
        Me.txttreatment.Name = "txttreatment"
        Me.txttreatment.ReadOnly = True
        Me.txttreatment.Size = New System.Drawing.Size(154, 20)
        Me.txttreatment.TabIndex = 4
        '
        'txtgender
        '
        Me.txtgender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "Gender", True))
        Me.txtgender.Location = New System.Drawing.Point(106, 67)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.ReadOnly = True
        Me.txtgender.Size = New System.Drawing.Size(154, 20)
        Me.txtgender.TabIndex = 3
        '
        'BSpatient
        '
        Me.BSpatient.DataMember = "TblPatient"
        Me.BSpatient.DataSource = Me.DSPatient
        '
        'txtlastname
        '
        Me.txtlastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "LastName", True))
        Me.txtlastname.Location = New System.Drawing.Point(106, 40)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.ReadOnly = True
        Me.txtlastname.Size = New System.Drawing.Size(154, 20)
        Me.txtlastname.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "FirstName", True))
        Me.txtname.Location = New System.Drawing.Point(106, 13)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(154, 20)
        Me.txtname.TabIndex = 1
        '
        'AppointmentDGV
        '
        Me.AppointmentDGV.AutoGenerateColumns = False
        Me.AppointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppointmentIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.PatientLastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn1, Me.TreatmentNameDataGridViewTextBoxColumn, Me.TreamentCostDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.AssignedDentistDataGridViewTextBoxColumn})
        Me.AppointmentDGV.DataSource = Me.BSappointment
        Me.AppointmentDGV.Location = New System.Drawing.Point(7, 146)
        Me.AppointmentDGV.Name = "AppointmentDGV"
        Me.AppointmentDGV.Size = New System.Drawing.Size(726, 194)
        Me.AppointmentDGV.TabIndex = 0
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
        '
        'PatientLastNameDataGridViewTextBoxColumn
        '
        Me.PatientLastNameDataGridViewTextBoxColumn.DataPropertyName = "PatientLastName"
        Me.PatientLastNameDataGridViewTextBoxColumn.HeaderText = "PatientLastName"
        Me.PatientLastNameDataGridViewTextBoxColumn.Name = "PatientLastNameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn1
        '
        Me.GenderDataGridViewTextBoxColumn1.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn1.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn1.Name = "GenderDataGridViewTextBoxColumn1"
        '
        'TreatmentNameDataGridViewTextBoxColumn
        '
        Me.TreatmentNameDataGridViewTextBoxColumn.DataPropertyName = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn.HeaderText = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn.Name = "TreatmentNameDataGridViewTextBoxColumn"
        '
        'TreamentCostDataGridViewTextBoxColumn
        '
        Me.TreamentCostDataGridViewTextBoxColumn.DataPropertyName = "TreamentCost"
        Me.TreamentCostDataGridViewTextBoxColumn.HeaderText = "TreamentCost"
        Me.TreamentCostDataGridViewTextBoxColumn.Name = "TreamentCostDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        '
        'AssignedDentistDataGridViewTextBoxColumn
        '
        Me.AssignedDentistDataGridViewTextBoxColumn.DataPropertyName = "AssignedDentist"
        Me.AssignedDentistDataGridViewTextBoxColumn.HeaderText = "AssignedDentist"
        Me.AssignedDentistDataGridViewTextBoxColumn.Name = "AssignedDentistDataGridViewTextBoxColumn"
        '
        'BSappointment
        '
        Me.BSappointment.DataMember = "TblAppointment"
        Me.BSappointment.DataSource = Me.DSPatient
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtp)
        Me.GroupBox1.Controls.Add(Me.PatientchooseDGV)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(739, 230)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ChoosePatient"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(335, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Search for Patient"
        '
        'txtp
        '
        Me.txtp.Location = New System.Drawing.Point(444, 4)
        Me.txtp.Name = "txtp"
        Me.txtp.Size = New System.Drawing.Size(289, 20)
        Me.txtp.TabIndex = 1
        '
        'PatientchooseDGV
        '
        Me.PatientchooseDGV.AllowUserToAddRows = False
        Me.PatientchooseDGV.AllowUserToDeleteRows = False
        Me.PatientchooseDGV.AutoGenerateColumns = False
        Me.PatientchooseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientchooseDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.PhoneNoDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn, Me.MedicalAidDataGridViewTextBoxColumn, Me.PatientPhotoDataGridViewImageColumn})
        Me.PatientchooseDGV.DataSource = Me.BSpatient
        Me.PatientchooseDGV.Location = New System.Drawing.Point(6, 30)
        Me.PatientchooseDGV.Name = "PatientchooseDGV"
        Me.PatientchooseDGV.ReadOnly = True
        Me.PatientchooseDGV.Size = New System.Drawing.Size(727, 194)
        Me.PatientchooseDGV.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(752, 580)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Treatment & Dentist info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtdensearch)
        Me.GroupBox4.Controls.Add(Me.ChoosedentistDGV)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 261)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(737, 311)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ChooseDentist"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(424, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Search For Dentist"
        '
        'txtdensearch
        '
        Me.txtdensearch.Location = New System.Drawing.Point(531, 19)
        Me.txtdensearch.Multiline = True
        Me.txtdensearch.Name = "txtdensearch"
        Me.txtdensearch.Size = New System.Drawing.Size(179, 32)
        Me.txtdensearch.TabIndex = 1
        '
        'ChoosedentistDGV
        '
        Me.ChoosedentistDGV.AutoGenerateColumns = False
        Me.ChoosedentistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ChoosedentistDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DentistIDDataGridViewTextBoxColumn, Me.FirstNameLastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn3, Me.DateOfBirthDataGridViewTextBoxColumn1, Me.PhoneNoDataGridViewTextBoxColumn1, Me.AddressDataGridViewTextBoxColumn1, Me.EmailAddressDataGridViewTextBoxColumn1, Me.DentistCategoryDataGridViewTextBoxColumn, Me.DentistPhotoDataGridViewImageColumn})
        Me.ChoosedentistDGV.DataSource = Me.BSdentist
        Me.ChoosedentistDGV.Location = New System.Drawing.Point(6, 57)
        Me.ChoosedentistDGV.Name = "ChoosedentistDGV"
        Me.ChoosedentistDGV.Size = New System.Drawing.Size(725, 238)
        Me.ChoosedentistDGV.TabIndex = 0
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
        '
        'GenderDataGridViewTextBoxColumn3
        '
        Me.GenderDataGridViewTextBoxColumn3.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn3.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn3.Name = "GenderDataGridViewTextBoxColumn3"
        '
        'DateOfBirthDataGridViewTextBoxColumn1
        '
        Me.DateOfBirthDataGridViewTextBoxColumn1.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn1.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn1.Name = "DateOfBirthDataGridViewTextBoxColumn1"
        '
        'PhoneNoDataGridViewTextBoxColumn1
        '
        Me.PhoneNoDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNo"
        Me.PhoneNoDataGridViewTextBoxColumn1.HeaderText = "PhoneNo"
        Me.PhoneNoDataGridViewTextBoxColumn1.Name = "PhoneNoDataGridViewTextBoxColumn1"
        '
        'AddressDataGridViewTextBoxColumn1
        '
        Me.AddressDataGridViewTextBoxColumn1.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn1.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn1.Name = "AddressDataGridViewTextBoxColumn1"
        '
        'EmailAddressDataGridViewTextBoxColumn1
        '
        Me.EmailAddressDataGridViewTextBoxColumn1.DataPropertyName = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn1.HeaderText = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn1.Name = "EmailAddressDataGridViewTextBoxColumn1"
        '
        'DentistCategoryDataGridViewTextBoxColumn
        '
        Me.DentistCategoryDataGridViewTextBoxColumn.DataPropertyName = "DentistCategory"
        Me.DentistCategoryDataGridViewTextBoxColumn.HeaderText = "DentistCategory"
        Me.DentistCategoryDataGridViewTextBoxColumn.Name = "DentistCategoryDataGridViewTextBoxColumn"
        '
        'DentistPhotoDataGridViewImageColumn
        '
        Me.DentistPhotoDataGridViewImageColumn.DataPropertyName = "DentistPhoto"
        Me.DentistPhotoDataGridViewImageColumn.HeaderText = "DentistPhoto"
        Me.DentistPhotoDataGridViewImageColumn.Name = "DentistPhotoDataGridViewImageColumn"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChoosetreatmentDGV)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(737, 226)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ChooseTreatments"
        '
        'ChoosetreatmentDGV
        '
        Me.ChoosetreatmentDGV.AutoGenerateColumns = False
        Me.ChoosetreatmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ChoosetreatmentDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TreatmentIDDataGridViewTextBoxColumn, Me.TreatmentNameDataGridViewTextBoxColumn1, Me.TreatmentCostDataGridViewTextBoxColumn, Me.TreatmentDescriptionDataGridViewTextBoxColumn})
        Me.ChoosetreatmentDGV.DataSource = Me.BStreatment
        Me.ChoosetreatmentDGV.Location = New System.Drawing.Point(23, 19)
        Me.ChoosetreatmentDGV.Name = "ChoosetreatmentDGV"
        Me.ChoosetreatmentDGV.Size = New System.Drawing.Size(687, 191)
        Me.ChoosetreatmentDGV.TabIndex = 0
        '
        'TreatmentIDDataGridViewTextBoxColumn
        '
        Me.TreatmentIDDataGridViewTextBoxColumn.DataPropertyName = "TreatmentID"
        Me.TreatmentIDDataGridViewTextBoxColumn.HeaderText = "TreatmentID"
        Me.TreatmentIDDataGridViewTextBoxColumn.Name = "TreatmentIDDataGridViewTextBoxColumn"
        Me.TreatmentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TreatmentNameDataGridViewTextBoxColumn1
        '
        Me.TreatmentNameDataGridViewTextBoxColumn1.DataPropertyName = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn1.HeaderText = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn1.Name = "TreatmentNameDataGridViewTextBoxColumn1"
        '
        'TreatmentCostDataGridViewTextBoxColumn
        '
        Me.TreatmentCostDataGridViewTextBoxColumn.DataPropertyName = "TreatmentCost"
        Me.TreatmentCostDataGridViewTextBoxColumn.HeaderText = "TreatmentCost"
        Me.TreatmentCostDataGridViewTextBoxColumn.Name = "TreatmentCostDataGridViewTextBoxColumn"
        '
        'TreatmentDescriptionDataGridViewTextBoxColumn
        '
        Me.TreatmentDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TreatmentDescription"
        Me.TreatmentDescriptionDataGridViewTextBoxColumn.HeaderText = "TreatmentDescription"
        Me.TreatmentDescriptionDataGridViewTextBoxColumn.Name = "TreatmentDescriptionDataGridViewTextBoxColumn"
        '
        'Delete
        '
        Me.Delete.Controls.Add(Me.GroupBox2)
        Me.Delete.Controls.Add(Me.appgb)
        Me.Delete.Location = New System.Drawing.Point(4, 22)
        Me.Delete.Name = "Delete"
        Me.Delete.Padding = New System.Windows.Forms.Padding(3)
        Me.Delete.Size = New System.Drawing.Size(752, 580)
        Me.Delete.TabIndex = 1
        Me.Delete.Text = "Cancel"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.cancelledDGV)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 290)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(731, 282)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cancelled Appointments"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(307, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Search Cancelled Appointments"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(471, 20)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(214, 30)
        Me.TextBox2.TabIndex = 1
        '
        'cancelledDGV
        '
        Me.cancelledDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cancelledDGV.Location = New System.Drawing.Point(7, 54)
        Me.cancelledDGV.Name = "cancelledDGV"
        Me.cancelledDGV.Size = New System.Drawing.Size(718, 222)
        Me.cancelledDGV.TabIndex = 0
        '
        'appgb
        '
        Me.appgb.Controls.Add(Me.Label4)
        Me.appgb.Controls.Add(Me.searchapp)
        Me.appgb.Controls.Add(Me.AppDGV)
        Me.appgb.Location = New System.Drawing.Point(7, 20)
        Me.appgb.Name = "appgb"
        Me.appgb.Size = New System.Drawing.Size(737, 264)
        Me.appgb.TabIndex = 1
        Me.appgb.TabStop = False
        Me.appgb.Text = "Appointments"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(353, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Search for Appointment"
        '
        'searchapp
        '
        Me.searchapp.Location = New System.Drawing.Point(477, 19)
        Me.searchapp.Multiline = True
        Me.searchapp.Name = "searchapp"
        Me.searchapp.Size = New System.Drawing.Size(214, 28)
        Me.searchapp.TabIndex = 1
        '
        'AppDGV
        '
        Me.AppDGV.AutoGenerateColumns = False
        Me.AppDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppointmentIDDataGridViewTextBoxColumn1, Me.PatientNameDataGridViewTextBoxColumn1, Me.PatientLastNameDataGridViewTextBoxColumn1, Me.GenderDataGridViewTextBoxColumn2, Me.TreatmentNameDataGridViewTextBoxColumn2, Me.TreamentCostDataGridViewTextBoxColumn1, Me.DateDataGridViewTextBoxColumn1, Me.TimeDataGridViewTextBoxColumn1, Me.AssignedDentistDataGridViewTextBoxColumn1})
        Me.AppDGV.DataSource = Me.BSappointment
        Me.AppDGV.Location = New System.Drawing.Point(6, 53)
        Me.AppDGV.Name = "AppDGV"
        Me.AppDGV.Size = New System.Drawing.Size(725, 205)
        Me.AppDGV.TabIndex = 0
        '
        'AppointmentIDDataGridViewTextBoxColumn1
        '
        Me.AppointmentIDDataGridViewTextBoxColumn1.DataPropertyName = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn1.HeaderText = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn1.Name = "AppointmentIDDataGridViewTextBoxColumn1"
        Me.AppointmentIDDataGridViewTextBoxColumn1.ReadOnly = True
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
        'GenderDataGridViewTextBoxColumn2
        '
        Me.GenderDataGridViewTextBoxColumn2.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn2.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn2.Name = "GenderDataGridViewTextBoxColumn2"
        '
        'TreatmentNameDataGridViewTextBoxColumn2
        '
        Me.TreatmentNameDataGridViewTextBoxColumn2.DataPropertyName = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn2.HeaderText = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn2.Name = "TreatmentNameDataGridViewTextBoxColumn2"
        '
        'TreamentCostDataGridViewTextBoxColumn1
        '
        Me.TreamentCostDataGridViewTextBoxColumn1.DataPropertyName = "TreamentCost"
        Me.TreamentCostDataGridViewTextBoxColumn1.HeaderText = "TreamentCost"
        Me.TreamentCostDataGridViewTextBoxColumn1.Name = "TreamentCostDataGridViewTextBoxColumn1"
        '
        'DateDataGridViewTextBoxColumn1
        '
        Me.DateDataGridViewTextBoxColumn1.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn1.Name = "DateDataGridViewTextBoxColumn1"
        '
        'TimeDataGridViewTextBoxColumn1
        '
        Me.TimeDataGridViewTextBoxColumn1.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn1.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn1.Name = "TimeDataGridViewTextBoxColumn1"
        '
        'AssignedDentistDataGridViewTextBoxColumn1
        '
        Me.AssignedDentistDataGridViewTextBoxColumn1.DataPropertyName = "AssignedDentist"
        Me.AssignedDentistDataGridViewTextBoxColumn1.HeaderText = "AssignedDentist"
        Me.AssignedDentistDataGridViewTextBoxColumn1.Name = "AssignedDentistDataGridViewTextBoxColumn1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.emailbody)
        Me.TabPage2.Controls.Add(Me.txtsubject)
        Me.TabPage2.Controls.Add(Me.txtsendto)
        Me.TabPage2.Controls.Add(Me.Sendbtn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(752, 580)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Send Mail"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Send From"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(99, 10)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(284, 33)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.Text = "longburydentalsurgery@gmail.com"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Send To:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Subject:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 126)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "EmailBody:"
        '
        'emailbody
        '
        Me.emailbody.Location = New System.Drawing.Point(99, 126)
        Me.emailbody.Multiline = True
        Me.emailbody.Name = "emailbody"
        Me.emailbody.Size = New System.Drawing.Size(284, 121)
        Me.emailbody.TabIndex = 10
        '
        'txtsubject
        '
        Me.txtsubject.Location = New System.Drawing.Point(99, 89)
        Me.txtsubject.Multiline = True
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.ReadOnly = True
        Me.txtsubject.Size = New System.Drawing.Size(284, 31)
        Me.txtsubject.TabIndex = 9
        Me.txtsubject.Text = "Appointment is booked"
        '
        'txtsendto
        '
        Me.txtsendto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSpatient, "EmailAddress", True))
        Me.txtsendto.Location = New System.Drawing.Point(99, 49)
        Me.txtsendto.Multiline = True
        Me.txtsendto.Name = "txtsendto"
        Me.txtsendto.Size = New System.Drawing.Size(284, 33)
        Me.txtsendto.TabIndex = 8
        '
        'Sendbtn
        '
        Me.Sendbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Sendbtn.ForeColor = System.Drawing.Color.White
        Me.Sendbtn.Location = New System.Drawing.Point(261, 373)
        Me.Sendbtn.Name = "Sendbtn"
        Me.Sendbtn.Size = New System.Drawing.Size(122, 41)
        Me.Sendbtn.TabIndex = 7
        Me.Sendbtn.Text = "SEND"
        Me.Sendbtn.UseVisualStyleBackColor = False
        '
        'TApatient
        '
        Me.TApatient.ClearBeforeFill = True
        '
        'DSappointment
        '
        Me.DSappointment.DataSetName = "DSDBproject"
        Me.DSappointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TAappointment
        '
        Me.TAappointment.ClearBeforeFill = True
        '
        'DStreatment
        '
        Me.DStreatment.DataSetName = "DSDBproject"
        Me.DStreatment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TAtreatment
        '
        Me.TAtreatment.ClearBeforeFill = True
        '
        'DSdentist
        '
        Me.DSdentist.DataSetName = "DSDBproject"
        Me.DSdentist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TAdentist
        '
        Me.TAdentist.ClearBeforeFill = True
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
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 652)
        Me.Controls.Add(Me.Appointmenttab)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Appointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PBlists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBdentist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBprescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBtreatment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Appointmenttab.ResumeLayout(False)
        Me.ADD.ResumeLayout(False)
        Me.AppointmentGB.ResumeLayout(False)
        Me.AppointmentGB.PerformLayout()
        CType(Me.BSdentist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BStreatment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSpatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSappointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PatientchooseDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ChoosedentistDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ChoosetreatmentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Delete.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cancelledDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.appgb.ResumeLayout(False)
        Me.appgb.PerformLayout()
        CType(Me.AppDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DSappointment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DStreatment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSdentist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Panel2 As Panel
    Private WithEvents PBlists As PictureBox
    Private WithEvents Reportsbtn As Button
    Private WithEvents Exitbtn As Button
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents Paymentbtn As Button
    Private WithEvents PBpayment As PictureBox
    Private WithEvents Dentistbtn As Button
    Private WithEvents PBdentist As PictureBox
    Private WithEvents Prescriptionbtn As Button
    Private WithEvents PBprescription As PictureBox
    Private WithEvents Treatmentbtn As Button
    Private WithEvents PBtreatment As PictureBox
    Private WithEvents Patientbtn As Button
    Private WithEvents PBpatient As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents Panel3 As Panel
    Private WithEvents label3 As Label
    Friend WithEvents Appointmenttab As TabControl
    Friend WithEvents ADD As TabPage
    Friend WithEvents Delete As TabPage
    Friend WithEvents AppointmentGB As GroupBox
    Friend WithEvents cbtime As ComboBox
    Friend WithEvents txtcosttreat As TextBox
    Friend WithEvents txttreatment As TextBox
    Friend WithEvents txtgender As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents AppointmentDGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PatientchooseDGV As DataGridView
    Friend WithEvents appdate As DateTimePicker
    Friend WithEvents Savebtn As Button
    Friend WithEvents Clearbtn As Button
    Friend WithEvents AppointmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientLastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TreamentCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssignedDentistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BSappointment As BindingSource
    Friend WithEvents DSPatient As DSDBproject
    Friend WithEvents BSpatient As BindingSource
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ChoosetreatmentDGV As DataGridView
    Friend WithEvents TreatmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BStreatment As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cancelledDGV As DataGridView
    Friend WithEvents appgb As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents searchapp As TextBox
    Friend WithEvents AppDGV As DataGridView
    Friend WithEvents AppointmentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PatientLastNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentNameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TreamentCostDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AssignedDentistDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TApatient As DSDBprojectTableAdapters.TblPatientTableAdapter
    Friend WithEvents DSappointment As DSDBproject
    Friend WithEvents TAappointment As DSDBprojectTableAdapters.TblAppointmentTableAdapter
    Friend WithEvents DStreatment As DSDBproject
    Friend WithEvents TAtreatment As DSDBprojectTableAdapters.TblTreatmentTableAdapter
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdensearch As TextBox
    Friend WithEvents ChoosedentistDGV As DataGridView
    Friend WithEvents DentistIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameLastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DentistCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DentistPhotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents BSdentist As BindingSource
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DSdentist As DSDBproject
    Friend WithEvents TAdentist As DSDBprojectTableAdapters.TblDentistTableAdapter
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdent As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents emailbody As TextBox
    Friend WithEvents txtsubject As TextBox
    Friend WithEvents txtsendto As TextBox
    Friend WithEvents Sendbtn As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents txtp As TextBox
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
