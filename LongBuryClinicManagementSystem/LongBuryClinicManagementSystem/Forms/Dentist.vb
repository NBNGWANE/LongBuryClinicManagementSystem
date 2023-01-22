Imports System.IO
Imports System.Drawing.Imaging


Public Class Dentist
    Private Sub Prescriptionbtn_Click(sender As Object, e As EventArgs) Handles Prescriptionbtn.Click
        Prescription.Show()
        Me.Hide()

    End Sub

    Private Sub PBprescription_Click(sender As Object, e As EventArgs) Handles PBprescription.Click
        Prescription.Show()
        Me.Hide()

    End Sub

    Private Sub Patientbtn_Click(sender As Object, e As EventArgs) Handles Patientbtn.Click
        Patient.Show()
        Me.Hide()

    End Sub

    Private Sub PBpatient_Click(sender As Object, e As EventArgs) Handles PBpatientform.Click
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

    Private Sub Dentist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TADentist.Fill(DSdentist.TblDentist)

        DentistDGV.EnableHeadersVisualStyles = False
        DentistDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DentistDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen

    End Sub

    Private Sub ChooseImagebtn_Click(sender As Object, e As EventArgs) Handles ChooseImagebtn.Click
        Try
            Dim openfiledialog1 As New OpenFileDialog
            openfiledialog1.Filter = "image(*.jpg; *.jpeg; *.png; *.PNG; *.gif;)|*.jpg; *.jpeg; *.png; *.PNG; *.gif;"
            If openfiledialog1.ShowDialog = DialogResult.OK Then
                PBdentist.Image = Image.FromFile(openfiledialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Try
            Dim ms As New MemoryStream
            PBdentist.Image.Save(ms, PBdentist.Image.RawFormat)
            TADentist.Insert(txtnameandlastname.Text, gendercombobox.SelectedItem, dobdentist.Value.Date, txtphone.Text, txtaddress.Text, txtemail.Text, CategoryCb.SelectedItem, ms.ToArray)
            TADentist.Fill(DSdentist.TblDentist)
            txtnameandlastname.Clear()
            gendercombobox.ResetText()
            dobdentist.ResetText()
            txtphone.Clear()
            txtaddress.Clear()
            txtemail.Clear()
            CategoryCb.ResetText()
            PBdentist.Image = Nothing
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        Try
            TADentist.Update(DSdentist.TblDentist)
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        Try
            txtnameandlastname.Clear()
            gendercombobox.ResetText()
            dobdentist.ResetText()
            txtphone.Clear()
            txtaddress.Clear()
            txtemail.Clear()
            CategoryCb.ResetText()
            PBdentist.Image = Nothing
        Catch ex As Exception
            MsgBox("an error occured, try again")
        End Try
    End Sub
End Class