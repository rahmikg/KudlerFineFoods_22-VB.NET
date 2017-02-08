
'Imports System.Data.Mdb '
Imports System.Data.OleDb

Public Class MainForm
    'Dim con As New SqlConnection'
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

        'con.ConnectionString = "Data Source=RAHMIKHOME;Initial Catalog=Contacts;Integrated Security=True"'


    End Sub



    'Button Clicks
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\KudlerCustomerRegistry.mdb"

        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim str As String
        str = "INSERT INTO KudlerCustomerRegistration ([Card_number],[First_name],[Last_name],[Sex],[Address],[City],[State],[Zip_code],[Phone_number],[Email_address]) Values (@Card,@FName,@Lname,@Sex,@Address,@City,@State,@Zip,@Phone,@Email)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.AddWithValue("@Card", txtFrequentShopperCard.Text)
        cmd.Parameters.AddWithValue("@FName", txtFirstName.Text)
        cmd.Parameters.AddWithValue("@LName", txtLastName.Text)
        cmd.Parameters.AddWithValue("@Sex", CboxMaleFemale.Text)
        cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
        cmd.Parameters.AddWithValue("@City", txtCity.Text)
        cmd.Parameters.AddWithValue("@State", CboxStates.Text)
        cmd.Parameters.AddWithValue("@Zip", txtZip.Text)
        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            txtFrequentShopperCard.Clear()
            txtFirstName.Clear()
            txtLastName.Clear()
            CboxMaleFemale.SelectedIndex = -1
            txtAddress.Clear()
            txtCity.Clear()
            CboxStates.SelectedIndex = -1
            txtZip.Clear()
            txtPhone.Clear()
            txtEmail.Clear()

            txtFrequentShopperCard.Focus()
            MessageBox.Show("Success")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFrequentShopperCard.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        CboxMaleFemale.Refresh()
        txtAddress.Clear()
        txtCity.Clear()
        CboxStates.Refresh()
        txtZip.Clear()
        txtPhone.Clear()
        txtEmail.Clear()


        txtFirstName.Focus()


    End Sub
    'End of button clicks


    'These text boxes will allow only numbers to enter
    Private Sub txtZip_TextChanged(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtZip.KeyPress

        Dim txt As TextBox = CType(sender, TextBox)

        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True

        'statement that would allow backspacing
        If e.KeyChar = Chr(8) Then e.Handled = False

        'allowing decimals
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False


    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtPhone.KeyPress

        Dim txt As TextBox = CType(sender, TextBox)

        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True

        'statement that would allow backspacing
        If e.KeyChar = Chr(8) Then e.Handled = False

        'allowing decimals
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False

    End Sub

    Private Sub txtFrequentShopperCard_TextChanged(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtFrequentShopperCard.KeyPress
        Dim txt As TextBox = CType(sender, TextBox)

        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True

        'statement that would allow backspacing
        If e.KeyChar = Chr(8) Then e.Handled = False

        'allowing decimals
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False

    End Sub
    'end of the text boxes that will enter only numbers


    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Dim frmViewCustomers As New ViewCustomers


        frmViewCustomers.ShowDialog()


    End Sub
End Class
