Public Class Prescription
    Private Sub Patientbtn_Click(sender As Object, e As EventArgs) Handles Patientbtn.Click
        Patient.Show()
        Me.Hide()

    End Sub

    Private Sub PBpatient_Click(sender As Object, e As EventArgs) Handles PBpatient.Click
        Patient.Show()
        Me.Hide()

    End Sub

    Private Sub appbtn_Click(sender As Object, e As EventArgs) Handles appbtn.Click
        Appointment.Show()
        Me.Hide()

    End Sub

    Private Sub PBappoint_Click(sender As Object, e As EventArgs) Handles PBappoint.Click
        Appointment.Show()
        Me.Hide()

    End Sub

    Private Sub Treatmentbtn_Click(sender As Object, e As EventArgs) Handles Treatmentbtn.Click
        Treatment.Show()
        Me.Hide()

    End Sub

    Private Sub PBtreatment_Click(sender As Object, e As EventArgs) Handles PBtreatment.Click
        Treatment.Show()
        Me.Hide()

    End Sub

    Private Sub Dentistbtn_Click(sender As Object, e As EventArgs) Handles Dentistbtn.Click
        Dentist.Show()
        Me.Hide()

    End Sub

    Private Sub PBdentist_Click(sender As Object, e As EventArgs) Handles PBdentist.Click
        Dentist.Show()
        Me.Hide()

    End Sub

    Private Sub Paymentbtn_Click(sender As Object, e As EventArgs) Handles Paymentbtn.Click
        Payment.Show()
        Me.Hide()

    End Sub

    Private Sub PBpayment_Click(sender As Object, e As EventArgs) Handles PBpayment.Click
        Payment.Show()
        Me.Hide()

    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click

        Me.Close()

    End Sub

    Private Sub PBclose_Click(sender As Object, e As EventArgs) Handles PBclose.Click
        Me.Close()

    End Sub

    Private Sub Prescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAappointment.Fill(DSappointment.TblAppointment)
        TAprescription.Fill(DSappointment.TblPrescription)

        ChooseappDGV.EnableHeadersVisualStyles = False
        ChooseappDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        ChooseappDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen

        PrescriptionDGV.EnableHeadersVisualStyles = False
        PrescriptionDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        PrescriptionDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen

    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Try
            TAprescription.Insert(txtname.Text, txtlastname.Text, txtassigneddentist.Text, txtnote.Text, prescriptiondate.Value.Date, txtappid.Text)
            TAprescription.Fill(DSappointment.TblPrescription)
            txtname.Clear()
            txtlastname.Clear()
            txtassigneddentist.Clear()
            txtappid.Clear()
            txtnote.Clear()
            prescriptiondate.ResetText()
            MessageBox.Show("Prescription Added Successfully")
        Catch ex As Exception
            MessageBox.Show("Prescription Not Added")
        End Try
        TAappointment.Fill(DSappointment.TblAppointment)
        TAprescription.Fill(DSappointment.TblPrescription)
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        Try
            txtname.Clear()
            txtlastname.Clear()
            txtassigneddentist.Clear()
            txtappid.Clear()
            txtnote.Clear()
            prescriptiondate.ResetText()
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TAappointment.FillBy(DSappointment.TblAppointment, TextBox1.Text)
    End Sub
End Class