<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Treatment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Treatment))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Listsbtn = New System.Windows.Forms.PictureBox()
        Me.Reportsbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Paymentbtn = New System.Windows.Forms.Button()
        Me.PBpayment = New System.Windows.Forms.PictureBox()
        Me.Dentistbtn = New System.Windows.Forms.Button()
        Me.PBdentist = New System.Windows.Forms.PictureBox()
        Me.Prescriptionbtn = New System.Windows.Forms.Button()
        Me.PBprescription = New System.Windows.Forms.PictureBox()
        Me.appbtn = New System.Windows.Forms.Button()
        Me.PBappoint = New System.Windows.Forms.PictureBox()
        Me.Patientbtn = New System.Windows.Forms.Button()
        Me.PBpatient = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.TreatmentGB = New System.Windows.Forms.GroupBox()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdesctreat = New System.Windows.Forms.TextBox()
        Me.BStreatment = New System.Windows.Forms.BindingSource(Me.components)
        Me.DStreatment = New LongBuryClinicManagementSystem.DSDBproject()
        Me.txtcosttreat = New System.Windows.Forms.TextBox()
        Me.txtnametreat = New System.Windows.Forms.TextBox()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Updatebtn = New System.Windows.Forms.Button()
        Me.TreatmentDGV = New System.Windows.Forms.DataGridView()
        Me.TATreatment = New LongBuryClinicManagementSystem.DSDBprojectTableAdapters.TblTreatmentTableAdapter()
        Me.TreatmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.Listsbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBdentist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBprescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBappoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TreatmentGB.SuspendLayout()
        CType(Me.BStreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DStreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreatmentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.Listsbtn)
        Me.Panel2.Controls.Add(Me.Reportsbtn)
        Me.Panel2.Controls.Add(Me.Exitbtn)
        Me.Panel2.Controls.Add(Me.pictureBox6)
        Me.Panel2.Controls.Add(Me.Paymentbtn)
        Me.Panel2.Controls.Add(Me.PBpayment)
        Me.Panel2.Controls.Add(Me.Dentistbtn)
        Me.Panel2.Controls.Add(Me.PBdentist)
        Me.Panel2.Controls.Add(Me.Prescriptionbtn)
        Me.Panel2.Controls.Add(Me.PBprescription)
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
        Me.Panel2.TabIndex = 4
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
        Me.label2.Size = New System.Drawing.Size(136, 37)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Treatment"
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
        Me.Panel3.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(6, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(106, 30)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Treatment"
        '
        'TreatmentGB
        '
        Me.TreatmentGB.Controls.Add(Me.clearbtn)
        Me.TreatmentGB.Controls.Add(Me.Label6)
        Me.TreatmentGB.Controls.Add(Me.Label5)
        Me.TreatmentGB.Controls.Add(Me.Label4)
        Me.TreatmentGB.Controls.Add(Me.txtdesctreat)
        Me.TreatmentGB.Controls.Add(Me.txtcosttreat)
        Me.TreatmentGB.Controls.Add(Me.txtnametreat)
        Me.TreatmentGB.Controls.Add(Me.Savebtn)
        Me.TreatmentGB.Controls.Add(Me.Updatebtn)
        Me.TreatmentGB.Location = New System.Drawing.Point(211, 72)
        Me.TreatmentGB.Name = "TreatmentGB"
        Me.TreatmentGB.Size = New System.Drawing.Size(737, 250)
        Me.TreatmentGB.TabIndex = 6
        Me.TreatmentGB.TabStop = False
        Me.TreatmentGB.Text = "Treatment Details"
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.DarkOrange
        Me.clearbtn.ForeColor = System.Drawing.Color.White
        Me.clearbtn.Location = New System.Drawing.Point(432, 201)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(109, 43)
        Me.clearbtn.TabIndex = 67
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Name"
        '
        'txtdesctreat
        '
        Me.txtdesctreat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BStreatment, "TreatmentDescription", True))
        Me.txtdesctreat.Location = New System.Drawing.Point(169, 124)
        Me.txtdesctreat.Multiline = True
        Me.txtdesctreat.Name = "txtdesctreat"
        Me.txtdesctreat.Size = New System.Drawing.Size(166, 71)
        Me.txtdesctreat.TabIndex = 63
        '
        'BStreatment
        '
        Me.BStreatment.DataMember = "TblTreatment"
        Me.BStreatment.DataSource = Me.DStreatment
        '
        'DStreatment
        '
        Me.DStreatment.DataSetName = "DSDBproject"
        Me.DStreatment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtcosttreat
        '
        Me.txtcosttreat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BStreatment, "TreatmentCost", True))
        Me.txtcosttreat.Location = New System.Drawing.Point(169, 79)
        Me.txtcosttreat.Multiline = True
        Me.txtcosttreat.Name = "txtcosttreat"
        Me.txtcosttreat.Size = New System.Drawing.Size(166, 38)
        Me.txtcosttreat.TabIndex = 62
        '
        'txtnametreat
        '
        Me.txtnametreat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BStreatment, "TreatmentName", True))
        Me.txtnametreat.Location = New System.Drawing.Point(169, 35)
        Me.txtnametreat.Multiline = True
        Me.txtnametreat.Name = "txtnametreat"
        Me.txtnametreat.Size = New System.Drawing.Size(166, 37)
        Me.txtnametreat.TabIndex = 61
        '
        'Savebtn
        '
        Me.Savebtn.BackColor = System.Drawing.Color.ForestGreen
        Me.Savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.ForeColor = System.Drawing.Color.White
        Me.Savebtn.Location = New System.Drawing.Point(169, 201)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(125, 43)
        Me.Savebtn.TabIndex = 59
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = False
        '
        'Updatebtn
        '
        Me.Updatebtn.BackColor = System.Drawing.Color.DarkViolet
        Me.Updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updatebtn.ForeColor = System.Drawing.Color.White
        Me.Updatebtn.Location = New System.Drawing.Point(300, 201)
        Me.Updatebtn.Name = "Updatebtn"
        Me.Updatebtn.Size = New System.Drawing.Size(125, 43)
        Me.Updatebtn.TabIndex = 60
        Me.Updatebtn.Text = "Update"
        Me.Updatebtn.UseVisualStyleBackColor = False
        '
        'TreatmentDGV
        '
        Me.TreatmentDGV.AllowUserToAddRows = False
        Me.TreatmentDGV.AllowUserToDeleteRows = False
        Me.TreatmentDGV.AutoGenerateColumns = False
        Me.TreatmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TreatmentDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TreatmentIDDataGridViewTextBoxColumn, Me.TreatmentNameDataGridViewTextBoxColumn, Me.TreatmentCostDataGridViewTextBoxColumn, Me.TreatmentDescriptionDataGridViewTextBoxColumn})
        Me.TreatmentDGV.DataSource = Me.BStreatment
        Me.TreatmentDGV.Location = New System.Drawing.Point(211, 337)
        Me.TreatmentDGV.Name = "TreatmentDGV"
        Me.TreatmentDGV.ReadOnly = True
        Me.TreatmentDGV.Size = New System.Drawing.Size(737, 312)
        Me.TreatmentDGV.TabIndex = 7
        '
        'TATreatment
        '
        Me.TATreatment.ClearBeforeFill = True
        '
        'TreatmentIDDataGridViewTextBoxColumn
        '
        Me.TreatmentIDDataGridViewTextBoxColumn.DataPropertyName = "TreatmentID"
        Me.TreatmentIDDataGridViewTextBoxColumn.HeaderText = "TreatmentID"
        Me.TreatmentIDDataGridViewTextBoxColumn.Name = "TreatmentIDDataGridViewTextBoxColumn"
        Me.TreatmentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TreatmentNameDataGridViewTextBoxColumn
        '
        Me.TreatmentNameDataGridViewTextBoxColumn.DataPropertyName = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn.HeaderText = "TreatmentName"
        Me.TreatmentNameDataGridViewTextBoxColumn.Name = "TreatmentNameDataGridViewTextBoxColumn"
        Me.TreatmentNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TreatmentCostDataGridViewTextBoxColumn
        '
        Me.TreatmentCostDataGridViewTextBoxColumn.DataPropertyName = "TreatmentCost"
        Me.TreatmentCostDataGridViewTextBoxColumn.HeaderText = "TreatmentCost"
        Me.TreatmentCostDataGridViewTextBoxColumn.Name = "TreatmentCostDataGridViewTextBoxColumn"
        Me.TreatmentCostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TreatmentDescriptionDataGridViewTextBoxColumn
        '
        Me.TreatmentDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TreatmentDescription"
        Me.TreatmentDescriptionDataGridViewTextBoxColumn.HeaderText = "TreatmentDescription"
        Me.TreatmentDescriptionDataGridViewTextBoxColumn.Name = "TreatmentDescriptionDataGridViewTextBoxColumn"
        Me.TreatmentDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Treatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 652)
        Me.Controls.Add(Me.TreatmentDGV)
        Me.Controls.Add(Me.TreatmentGB)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Treatment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Treatment"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Listsbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBdentist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBprescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBappoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TreatmentGB.ResumeLayout(False)
        Me.TreatmentGB.PerformLayout()
        CType(Me.BStreatment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DStreatment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreatmentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Panel2 As Panel
    Private WithEvents Listsbtn As PictureBox
    Private WithEvents Reportsbtn As Button
    Private WithEvents Exitbtn As Button
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents Paymentbtn As Button
    Private WithEvents PBpayment As PictureBox
    Private WithEvents Dentistbtn As Button
    Private WithEvents PBdentist As PictureBox
    Private WithEvents Prescriptionbtn As Button
    Private WithEvents PBprescription As PictureBox
    Private WithEvents appbtn As Button
    Private WithEvents PBappoint As PictureBox
    Private WithEvents Patientbtn As Button
    Private WithEvents PBpatient As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents Panel3 As Panel
    Private WithEvents label3 As Label
    Friend WithEvents TreatmentGB As GroupBox
    Friend WithEvents TreatmentDGV As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdesctreat As TextBox
    Friend WithEvents txtcosttreat As TextBox
    Friend WithEvents txtnametreat As TextBox
    Friend WithEvents Savebtn As Button
    Friend WithEvents Updatebtn As Button
    Friend WithEvents BStreatment As BindingSource
    Friend WithEvents DStreatment As DSDBproject
    Friend WithEvents TATreatment As DSDBprojectTableAdapters.TblTreatmentTableAdapter
    Friend WithEvents clearbtn As Button
    Friend WithEvents TreatmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
