Public Class Treatment
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

    Private Sub Prescriptionbtn_Click(sender As Object, e As EventArgs) Handles Prescriptionbtn.Click
        Prescription.Show()
        Me.Hide()

    End Sub

    Private Sub PBprescription_Click(sender As Object, e As EventArgs) Handles PBprescription.Click
        Prescription.Show()
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

    Private Sub pictureBox6_Click(sender As Object, e As EventArgs) Handles pictureBox6.Click
        Me.Close()

    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Try
            TATreatment.Insert(txtnametreat.Text, txtcosttreat.Text, txtdesctreat.Text)
            TATreatment.Fill(DStreatment.TblTreatment)
            txtnametreat.Clear()
            txtcosttreat.Clear()
            txtdesctreat.Clear()
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        Try
            TATreatment.Update(DStreatment.TblTreatment)
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub

    Private Sub Treatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TATreatment.Fill(DStreatment.TblTreatment)

        TreatmentDGV.EnableHeadersVisualStyles = False
        TreatmentDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        TreatmentDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen

    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        Try
            txtnametreat.Clear()
            txtcosttreat.Clear()
            txtdesctreat.Clear()
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub
End Class