
Imports System.IO
Imports System.Drawing.Imaging
Public Class Patient
    Private Sub Appointmentbtn_Click(sender As Object, e As EventArgs) Handles Appointmentbtn.Click

        Appointment.Show()
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
        Me.Close()
    End Sub

    Private Sub PBappointment_Click(sender As Object, e As EventArgs) Handles PBappointment.Click
        Appointment.Show()
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

    Private Sub PBdentist_Click(sender As Object, e As EventArgs) Handles PBdentistorm.Click
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

    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TApatient.Fill(DSpatient.TblPatient)

            PatientDGV.EnableHeadersVisualStyles = False
            PatientDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            PatientDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub

    Private Sub Medicalaidcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Medicalaidcombobox.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ChooseImagebtn_Click(sender As Object, e As EventArgs) Handles ChooseImagebtn.Click
        Try
            Dim openfiledialog1 As New OpenFileDialog
            openfiledialog1.Filter = "image(*.jpg; *.jpeg; *.png; *.PNG; *.gif;)|*.jpg; *.jpeg; *.png; *.PNG; *.gif;"
            If openfiledialog1.ShowDialog = DialogResult.OK Then
                PBpatient.Image = Image.FromFile(openfiledialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub

    Private Sub AddPatient_Click(sender As Object, e As EventArgs) Handles AddPatient.Click
        Try
            Dim ms As New MemoryStream
            PBpatient.Image.Save(ms, PBpatient.Image.RawFormat)
            TApatient.Insert(txtname.Text, txtlastname.Text, gendercombobox.SelectedItem, dobpatient.Value.Date, txtphone.Text, txtaddress.Text, txtemail.Text, Medicalaidcombobox.SelectedItem, ms.ToArray)
            TApatient.Fill(DSpatient.TblPatient)
            txtname.Clear()
            txtlastname.Clear()
            gendercombobox.ResetText()
            dobpatient.ResetText()
            txtphone.Clear()
            txtaddress.Clear()
            txtemail.Clear()
            Medicalaidcombobox.ResetText()
            PBpatient.Image = Nothing

            MessageBox.Show("Patient Added Sucessfully")

        Catch ex As Exception
            MessageBox.Show("Failed to Add Patient")
        End Try


    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        Try
            TApatient.Update(DSpatient.TblPatient)
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Try
            txtname.Clear()
            txtlastname.Clear()
            gendercombobox.ResetText()
            dobpatient.ResetText()
            txtphone.Clear()
            txtaddress.Clear()
            txtemail.Clear()
            Medicalaidcombobox.ResetText()
            PBpatient.Image = Nothing
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub

    Private Sub dobpatient_ValueChanged(sender As Object, e As EventArgs) Handles dobpatient.ValueChanged

    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub
End Class
