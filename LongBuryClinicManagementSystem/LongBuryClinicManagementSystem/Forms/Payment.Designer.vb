<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PBlists = New System.Windows.Forms.PictureBox()
        Me.Listsbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.PBclose = New System.Windows.Forms.PictureBox()
        Me.Dentistbtn = New System.Windows.Forms.Button()
        Me.PBdentist = New System.Windows.Forms.PictureBox()
        Me.Prescriptionbtn = New System.Windows.Forms.Button()
        Me.PBprescription = New System.Windows.Forms.PictureBox()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.AppDGV = New System.Windows.Forms.DataGridView()
        Me.AppointmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreamentCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignedDentistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSappointment = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSappointment = New LongBuryClinicManagementSystem.DSDBproject()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttreatmentcost = New System.Windows.Forms.TextBox()
        Me.txttreatmentname = New System.Windows.Forms.TextBox()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.paymentcb = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.paymentdate = New System.Windows.Forms.DateTimePicker()
        Me.txtappid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.paymentDGV = New System.Windows.Forms.DataGridView()
        Me.PaymentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientLastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreastmentCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSpayment = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAappointment = New LongBuryClinicManagementSystem.DSDBprojectTableAdapters.TblAppointmentTableAdapter()
        Me.DSpayment = New LongBuryClinicManagementSystem.DSDBproject()
        Me.TApayment = New LongBuryClinicManagementSystem.DSDBprojectTableAdapters.TblPaymentTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.PBlists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBdentist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBprescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBtreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBappoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AppDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSappointment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSappointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.paymentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSpayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSpayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.PBlists)
        Me.Panel2.Controls.Add(Me.Listsbtn)
        Me.Panel2.Controls.Add(Me.Exitbtn)
        Me.Panel2.Controls.Add(Me.PBclose)
        Me.Panel2.Controls.Add(Me.Dentistbtn)
        Me.Panel2.Controls.Add(Me.PBdentist)
        Me.Panel2.Controls.Add(Me.Prescriptionbtn)
        Me.Panel2.Controls.Add(Me.PBprescription)
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
        Me.Panel2.TabIndex = 7
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
        'Dentistbtn
        '
        Me.Dentistbtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Dentistbtn.FlatAppearance.BorderSize = 0
        Me.Dentistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dentistbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dentistbtn.Location = New System.Drawing.Point(46, 456)
        Me.Dentistbtn.Name = "Dentistbtn"
        Me.Dentistbtn.Size = New System.Drawing.Size(151, 50)
        Me.Dentistbtn.TabIndex = 11
        Me.Dentistbtn.Text = "Dentist"
        Me.Dentistbtn.UseVisualStyleBackColor = False
        '
        'PBdentist
        '
        Me.PBdentist.BackColor = System.Drawing.Color.White
        Me.PBdentist.Image = CType(resources.GetObject("PBdentist.Image"), System.Drawing.Image)
        Me.PBdentist.Location = New System.Drawing.Point(3, 456)
        Me.PBdentist.Name = "PBdentist"
        Me.PBdentist.Size = New System.Drawing.Size(44, 50)
        Me.PBdentist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBdentist.TabIndex = 10
        Me.PBdentist.TabStop = False
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
        Me.label2.Size = New System.Drawing.Size(119, 37)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Payment"
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
        Me.Panel3.TabIndex = 8
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(6, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(93, 30)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Payment"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.AppDGV)
        Me.GroupBox1.Location = New System.Drawing.Point(206, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 275)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Appointment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Search Appointments"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(502, 29)
        Me.txtsearch.Multiline = True
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(234, 29)
        Me.txtsearch.TabIndex = 1
        '
        'AppDGV
        '
        Me.AppDGV.AllowUserToAddRows = False
        Me.AppDGV.AllowUserToDeleteRows = False
        Me.AppDGV.AutoGenerateColumns = False
        Me.AppDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppointmentIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.PatientLastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.TreatmentNameDataGridViewTextBoxColumn, Me.TreamentCostDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.AssignedDentistDataGridViewTextBoxColumn})
        Me.AppDGV.DataSource = Me.BSappointment
        Me.AppDGV.Location = New System.Drawing.Point(6, 64)
        Me.AppDGV.Name = "AppDGV"
        Me.AppDGV.ReadOnly = True
        Me.AppDGV.Size = New System.Drawing.Size(730, 205)
        Me.AppDGV.TabIndex = 0
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
        Me.GroupBox2.Controls.Add(Me.Clearbtn)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txttreatmentcost)
        Me.GroupBox2.Controls.Add(Me.txttreatmentname)
        Me.GroupBox2.Controls.Add(Me.Savebtn)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.paymentcb)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.paymentdate)
        Me.GroupBox2.Controls.Add(Me.txtappid)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtlastname)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.paymentDGV)
        Me.GroupBox2.Location = New System.Drawing.Point(207, 331)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(741, 321)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Payments"
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.Color.OrangeRed
        Me.Clearbtn.ForeColor = System.Drawing.Color.White
        Me.Clearbtn.Location = New System.Drawing.Point(490, 82)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(107, 31)
        Me.Clearbtn.TabIndex = 52
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "TreatmentCost"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "TreatmentName"
        '
        'txttreatmentcost
        '
        Me.txttreatmentcost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSappointment, "TreamentCost", True))
        Me.txttreatmentcost.Location = New System.Drawing.Point(116, 93)
        Me.txttreatmentcost.Name = "txttreatmentcost"
        Me.txttreatmentcost.ReadOnly = True
        Me.txttreatmentcost.Size = New System.Drawing.Size(149, 20)
        Me.txttreatmentcost.TabIndex = 49
        '
        'txttreatmentname
        '
        Me.txttreatmentname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSappointment, "TreatmentName", True))
        Me.txttreatmentname.Location = New System.Drawing.Point(116, 67)
        Me.txttreatmentname.Name = "txttreatmentname"
        Me.txttreatmentname.ReadOnly = True
        Me.txttreatmentname.Size = New System.Drawing.Size(149, 20)
        Me.txttreatmentname.TabIndex = 48
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.ForestGreen
        Me.Savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(372, 80)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(112, 33)
        Me.Savebtn.TabIndex = 47
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(305, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "PaymentType"
        '
        'paymentcb
        '
        Me.paymentcb.FormattingEnabled = True
        Me.paymentcb.Items.AddRange(New Object() {"Cash", "MedicalAid", "CreditCard"})
        Me.paymentcb.Location = New System.Drawing.Point(393, 9)
        Me.paymentcb.Name = "paymentcb"
        Me.paymentcb.Size = New System.Drawing.Size(204, 21)
        Me.paymentcb.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(305, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "AppointmentID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Date"
        '
        'paymentdate
        '
        Me.paymentdate.CustomFormat = "MM-dd-yyyy"
        Me.paymentdate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSappointment, "Date", True))
        Me.paymentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.paymentdate.Location = New System.Drawing.Point(393, 36)
        Me.paymentdate.Name = "paymentdate"
        Me.paymentdate.Size = New System.Drawing.Size(204, 20)
        Me.paymentdate.TabIndex = 42
        '
        'txtappid
        '
        Me.txtappid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSappointment, "AppointmentID", True))
        Me.txtappid.Location = New System.Drawing.Point(393, 59)
        Me.txtappid.Name = "txtappid"
        Me.txtappid.ReadOnly = True
        Me.txtappid.Size = New System.Drawing.Size(204, 20)
        Me.txtappid.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "PatientLastName"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Patient Name"
        '
        'txtlastname
        '
        Me.txtlastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSappointment, "PatientLastName", True))
        Me.txtlastname.Location = New System.Drawing.Point(116, 39)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.ReadOnly = True
        Me.txtlastname.Size = New System.Drawing.Size(149, 20)
        Me.txtlastname.TabIndex = 37
        '
        'txtname
        '
        Me.txtname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSappointment, "PatientName", True))
        Me.txtname.Location = New System.Drawing.Point(116, 15)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(149, 20)
        Me.txtname.TabIndex = 36
        '
        'paymentDGV
        '
        Me.paymentDGV.AutoGenerateColumns = False
        Me.paymentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.paymentDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn1, Me.PatientLastNameDataGridViewTextBoxColumn1, Me.TreatmentNameDataGridViewTextBoxColumn1, Me.TreastmentCostDataGridViewTextBoxColumn, Me.PaymentTypeDataGridViewTextBoxColumn, Me.PaymentDateDataGridViewTextBoxColumn, Me.AppointmentIDDataGridViewTextBoxColumn1})
        Me.paymentDGV.DataSource = Me.BSpayment
        Me.paymentDGV.Location = New System.Drawing.Point(7, 119)
        Me.paymentDGV.Name = "paymentDGV"
        Me.paymentDGV.Size = New System.Drawing.Size(728, 202)
        Me.paymentDGV.TabIndex = 0
        '
        'PaymentIDDataGridViewTextBoxColumn
        '
        Me.PaymentIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentID"
        Me.PaymentIDDataGridViewTextBoxColumn.HeaderText = "PaymentID"
        Me.PaymentIDDataGridViewTextBoxColumn.Name = "PaymentIDDataGridViewTextBoxColumn"
        Me.PaymentIDDataGridViewTextBoxColumn.ReadOnly = True
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
        'TreatmentNameDataGridViewTextBoxColumn1
        '
        Me.TreatmentNameDataGridViewTextBoxColumn1.DataPropertyName = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn1.HeaderText = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn1.Name = "TreatmentNameDataGridViewTextBoxColumn1"
        '
        'TreastmentCostDataGridViewTextBoxColumn
        '
        Me.TreastmentCostDataGridViewTextBoxColumn.DataPropertyName = "TreastmentCost"
        Me.TreastmentCostDataGridViewTextBoxColumn.HeaderText = "TreastmentCost"
        Me.TreastmentCostDataGridViewTextBoxColumn.Name = "TreastmentCostDataGridViewTextBoxColumn"
        '
        'PaymentTypeDataGridViewTextBoxColumn
        '
        Me.PaymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType"
        Me.PaymentTypeDataGridViewTextBoxColumn.HeaderText = "PaymentType"
        Me.PaymentTypeDataGridViewTextBoxColumn.Name = "PaymentTypeDataGridViewTextBoxColumn"
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate"
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        '
        'AppointmentIDDataGridViewTextBoxColumn1
        '
        Me.AppointmentIDDataGridViewTextBoxColumn1.DataPropertyName = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn1.HeaderText = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn1.Name = "AppointmentIDDataGridViewTextBoxColumn1"
        '
        'BSpayment
        '
        Me.BSpayment.DataMember = "TblPayment"
        Me.BSpayment.DataSource = Me.DSappointment
        '
        'TAappointment
        '
        Me.TAappointment.ClearBeforeFill = True
        '
        'DSpayment
        '
        Me.DSpayment.DataSetName = "DSDBproject"
        Me.DSpayment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TApayment
        '
        Me.TApayment.ClearBeforeFill = True
        '
        'Payment
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
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PBlists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBdentist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBprescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBtreatment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBappoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AppDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSappointment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSappointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.paymentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSpayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSpayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Panel2 As Panel
    Private WithEvents PBlists As PictureBox
    Private WithEvents Listsbtn As Button
    Private WithEvents Exitbtn As Button
    Private WithEvents PBclose As PictureBox
    Private WithEvents Dentistbtn As Button
    Private WithEvents PBdentist As PictureBox
    Private WithEvents Prescriptionbtn As Button
    Private WithEvents PBprescription As PictureBox
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
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents AppDGV As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents paymentDGV As DataGridView
    Friend WithEvents BSappointment As BindingSource
    Friend WithEvents DSappointment As DSDBproject
    Friend WithEvents PaymentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PatientLastNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TreastmentCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BSpayment As BindingSource
    Friend WithEvents TAappointment As DSDBprojectTableAdapters.TblAppointmentTableAdapter
    Friend WithEvents DSpayment As DSDBproject
    Friend WithEvents TApayment As DSDBprojectTableAdapters.TblPaymentTableAdapter
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents paymentcb As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents paymentdate As DateTimePicker
    Friend WithEvents txtappid As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txttreatmentcost As TextBox
    Friend WithEvents txttreatmentname As TextBox
    Friend WithEvents Savebtn As Button
    Friend WithEvents Clearbtn As Button
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
