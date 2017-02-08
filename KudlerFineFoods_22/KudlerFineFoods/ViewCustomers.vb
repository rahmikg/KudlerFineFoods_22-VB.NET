


Public Class ViewCustomers

    Private Sub KudlerCustomerRegistrationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.KudlerCustomerRegistrationBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.KudlerCustomerRegistry1DataSet2)

    End Sub

    Private Sub ViewCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KudlerCustomerRegistryDataSet2.KudlerCustomerRegistration' table. You can move, or remove it, as needed.
        Me.KudlerCustomerRegistrationTableAdapter2.Fill(Me.KudlerCustomerRegistryDataSet2.KudlerCustomerRegistration)
        'TODO: This line of code loads data into the 'KudlerCustomerRegistryDataSet1.KudlerCustomerRegistration' table. You can move, or remove it, as needed.
        Me.KudlerCustomerRegistrationTableAdapter.Fill(Me.KudlerCustomerRegistryDataSet1.KudlerCustomerRegistration)
        'TODO: This line of code loads data into the 'KudlerCustomerRegistryDataSet.KudlerCustomerRegistration' table. You can move, or remove it, as needed.
        Me.KudlerCustomerRegistrationTableAdapter.Fill(Me.KudlerCustomerRegistryDataSet1.KudlerCustomerRegistration)

    End Sub

    Private Sub KudlerCustomerRegistryBindingToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Me.Validate()
        Me.KudlerCustomerRegistrationBindingSource2.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KudlerCustomerRegistryDataSet2)
        MsgBox("Saved")

    End Sub
End Class