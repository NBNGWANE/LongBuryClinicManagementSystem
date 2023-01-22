Imports System.Net.Mail

Public Class Appointment
    Private Sub Patientbtn_Click(sender As Object, e As EventArgs) Handles Patientbtn.Click
        Patient.Show()
        Me.Hide()
    End Sub

    Private Sub Treatmentbtn_Click(sender As Object, e As EventArgs) Handles Treatmentbtn.Click
        Treatment.Show()
        Me.Hide()
    End Sub

    Private Sub Prescriptionbtn_Click(sender As Object, e As EventArgs) Handles Prescriptionbtn.Click
        Prescription.Show()
        Me.Hide()

    End Sub

    Private Sub Dentistbtn_Click(sender As Object, e As EventArgs) Handles Dentistbtn.Click
        Dentist.Show()
        Me.Hide()
    End Sub

    Private Sub Paymentbtn_Click(sender As Object, e As EventArgs) Handles Paymentbtn.Click
        Payment.Show()
        Me.Hide()


    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Hide()

    End Sub

    Private Sub PBpatient_Click(sender As Object, e As EventArgs) Handles PBpatient.Click
        Patient.Show()
        Me.Hide()

    End Sub

    Private Sub PBtreatment_Click(sender As Object, e As EventArgs) Handles PBtreatment.Click
        Treatment.Show()
        Me.Hide()

    End Sub

    Private Sub PBprescription_Click(sender As Object, e As EventArgs) Handles PBprescription.Click
        Prescription.Show()
        Me.Hide()

    End Sub

    Private Sub PBdentist_Click(sender As Object, e As EventArgs) Handles PBdentist.Click
        Dentist.Show()
        Me.Hide()

    End Sub

    Private Sub PBpayment_Click(sender As Object, e As EventArgs) Handles PBpayment.Click
        Payment.Show()
        Me.Hide()

    End Sub

    Private Sub pictureBox6_Click(sender As Object, e As EventArgs) Handles pictureBox6.Click
        Me.Close()

    End Sub

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TApatient.Fill(DSPatient.TblPatient)
        TAappointment.Fill(DSPatient.TblAppointment)
        TAtreatment.Fill(DSPatient.TblTreatment)
        TAdentist.Fill(DSPatient.TblDentist)

        PatientchooseDGV.EnableHeadersVisualStyles = False
        PatientchooseDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        PatientchooseDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen

        AppointmentDGV.EnableHeadersVisualStyles = False
        AppointmentDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        AppointmentDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen

        ChoosetreatmentDGV.EnableHeadersVisualStyles = False
        ChoosetreatmentDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        ChoosetreatmentDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen

        ChoosedentistDGV.EnableHeadersVisualStyles = False
        ChoosedentistDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        ChoosedentistDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen

        AppDGV.EnableHeadersVisualStyles = False
        AppDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        AppDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen

    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Try
            TAappointment.Insert(txtname.Text, txtlastname.Text, txtgender.Text, txttreatment.Text, txtcosttreat.Text, appdate.Value.Date, cbtime.SelectedItem, txtdent.Text)
            TAappointment.Fill(DSPatient.TblAppointment)
            emailbody.Text = txttreatment.Text & Environment.NewLine
            emailbody.Text = txtcosttreat.Text & Environment.NewLine
            emailbody.Text = cbtime.SelectedItem & Environment.NewLine
            emailbody.Text = appdate.Value.Date & Environment.NewLine
            cbtime.Items.Remove(cbtime.SelectedItem)
            emailbody.Text = txttreatment.Text
            txtname.Clear()
            txtlastname.Clear()
            txtgender.Clear()
            txttreatment.Clear()
            txtcosttreat.Clear()
            appdate.ResetText()
            cbtime.ResetText()
            txtdent.Clear()
            MessageBox.Show("Appointment Succesfully Added")

        Catch ex As Exception
            MessageBox.Show("Failed to book Appointment")

        End Try
        TApatient.Fill(DSPatient.TblPatient)
        TAdentist.Fill(DSPatient.TblDentist)
        TAtreatment.Fill(DSPatient.TblTreatment)


    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        Try
            txtname.Clear()
            txtlastname.Clear()
            txtgender.Clear()
            txttreatment.Clear()
            txtcosttreat.Clear()
            appdate.ResetText()
            cbtime.ResetText()
            txtdent.Clear()
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub

    Private Sub appdate_ValueChanged(sender As Object, e As EventArgs) Handles appdate.ValueChanged
        appdate.MinDate = Now.Date

    End Sub

    Private Sub Sendbtn_Click(sender As Object, e As EventArgs) Handles Sendbtn.Click
        Dim emailmessage As New MailMessage()
        Try
            emailmessage.From = New MailAddress("longburydentalsurgery@gmail.com")
            emailmessage.To.Add(txtsendto.Text)
            emailmessage.Subject = txtsubject.Text
            emailmessage.Body = emailbody.Text
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New Net.NetworkCredential("longburydentalsurgery@gmail.com", "Wealthy@23")
            SMTP.Send(emailmessage)
            MessageBox.Show("Email Sent To Patient")
        Catch ex As Exception
            MessageBox.Show("failed to send Email")
        End Try

    End Sub

    Private Sub txtp_TextChanged(sender As Object, e As EventArgs) Handles txtp.TextChanged
        TApatient.FillBy(DSPatient.TblPatient, txtp.Text)
    End Sub

    Private Sub txtdensearch_TextChanged(sender As Object, e As EventArgs) Handles txtdensearch.TextChanged
        TAdentist.FillBy(DSPatient.TblDentist, txtdensearch.Text)
    End Sub

    Private Sub searchapp_TextChanged(sender As Object, e As EventArgs) Handles searchapp.TextChanged
        TAappointment.FillBy(DSPatient.TblAppointment, searchapp.Text)
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub
End Class