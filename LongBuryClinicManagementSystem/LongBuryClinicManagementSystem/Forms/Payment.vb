Public Class Payment
    Private Sub Dentistbtn_Click(sender As Object, e As EventArgs) Handles Dentistbtn.Click
        Dentist.Show()
        Me.Hide()

    End Sub

    Private Sub PBdentist_Click(sender As Object, e As EventArgs) Handles PBdentist.Click
        Dentist.Show()
        Me.Hide()

    End Sub

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

    Private Sub Prescriptionbtn_Click(sender As Object, e As EventArgs) Handles Prescriptionbtn.Click
        Prescription.Show()
        Me.Hide()

    End Sub

    Private Sub PBprescription_Click(sender As Object, e As EventArgs) Handles PBprescription.Click
        Prescription.Show()
        Me.Hide()

    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Close()

    End Sub

    Private Sub PBclose_Click(sender As Object, e As EventArgs) Handles PBclose.Click
        Me.Close()

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAappointment.Fill(DSappointment.TblAppointment)
        TApayment.Fill(DSappointment.TblPayment)

        AppDGV.EnableHeadersVisualStyles = False
        AppDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        AppDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen

        paymentDGV.EnableHeadersVisualStyles = False
        paymentDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        paymentDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen



    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Try
            TApayment.Insert(txtname.Text, txtlastname.Text, txttreatmentname.Text, txttreatmentcost.Text, paymentcb.SelectedItem, paymentdate.Value.Date, txtappid.Text)
            TApayment.Fill(DSappointment.TblPayment)
            txtname.Clear()
            txtlastname.Clear()
            txttreatmentname.Clear()
            txttreatmentcost.Clear()
            paymentcb.ResetText()
            paymentdate.ResetText()
            txtappid.Clear()
            MessageBox.Show("Payment Added Successfully")
        Catch ex As Exception
            MessageBox.Show("Failed to Add Payment")
        End Try
        TAappointment.Fill(DSappointment.TblAppointment)
        TApayment.Fill(DSappointment.TblPayment)
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        Try
            txtname.Clear()
            txtlastname.Clear()
            txttreatmentname.Clear()
            txttreatmentcost.Clear()
            paymentdate.ResetText()
            paymentcb.ResetText()
            txtappid.Clear()
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        TAappointment.FillBy(DSappointment.TblAppointment, txtsearch.Text)
    End Sub

    Private Sub AppDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AppDGV.CellContentClick

    End Sub
End Class