Imports System.Data.SqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitPB_Click(sender As Object, e As EventArgs) Handles ExitPB.Click
        Me.Close()

    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click

        Dim Username As String
            Dim password As String
            Username = txtUserName.Text
            password = txtPassWord.Text

        If (Username.Equals("Admin") And password.Equals("admin")) Then

            MessageBox.Show("Login Successful. WELCOME ADMIN", "Information", MessageBoxButtons.OK)
            Patient.Show()

        ElseIf (Username.Equals("Bhekani") And password.Equals("mdle")) Then
            MessageBox.Show("Login Successful. WELCOME STAFF", "Information", MessageBoxButtons.OK)
            Patient.Show()

        ElseIf (Username.Equals("Bhekani") And password.Equals("mdletshe")) Then

            MessageBox.Show("Login Successful. WELCOME DENTIST", "Information", MessageBoxButtons.OK)
            Patient.Show()

        ElseIf (Username.Equals("mbongeni") And password.Equals("mbo")) Then
            MessageBox.Show("Login Successful. WELCOME DENTIST", "Information", MessageBoxButtons.OK)
            Patient.Show()

        ElseIf (Username.Equals("Lethu") And password.Equals("mdletse")) Then
            MessageBox.Show("Login Successful. WELCOME STAFF", "Information", MessageBoxButtons.OK)
            Patient.Show()

        ElseIf (Username.Equals("mbo") And password.Equals("mbo")) Then
            MessageBox.Show("Login Successful. WELCOME ADMIN", "Information", MessageBoxButtons.OK)
            Patient.Show()
        ElseIf (Username.Equals("bhe") And password.Equals("m")) Then
            MessageBox.Show("Login Successful. WELCOME DENTIST", "Information", MessageBoxButtons.OK)
            Patient.Show()

        ElseIf (Username.Equals("mbo1") And password.Equals("me")) Then
            MessageBox.Show("Login Successful. WELCOME RECEPTIONIST", "Information", MessageBoxButtons.OK)
            Patient.Show()
        Else
            MessageBox.Show("Error, Try Again")
        End If


















    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtUserName.Clear()
        txtPassWord.Clear()
    End Sub

    Private Sub showLinklbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles showLinklbl.LinkClicked
        If showLinklbl.Text = "Show" Then
            showLinklbl.Text = "Hide"
            txtPassWord.PasswordChar = ""
        Else
            showLinklbl.Text = "Show"
            txtPassWord.PasswordChar = "*"
        End If

    End Sub

    Private Sub txtPassWord_TextChanged(sender As Object, e As EventArgs) Handles txtPassWord.TextChanged

    End Sub
End Class