<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewCustomers))
        Me.KudlerCustomerRegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KudlerCustomerRegistrationDataGridView = New System.Windows.Forms.DataGridView()
        Me.CardnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KudlerCustomerRegistrationBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KudlerCustomerRegistryDataSet2 = New KudlerFineFoods.KudlerCustomerRegistryDataSet2()
        Me.KudlerCustomerRegistrationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KudlerCustomerRegistryDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KudlerCustomerRegistryDataSet1 = New KudlerFineFoods.KudlerCustomerRegistryDataSet2()
        Me.KudlerCustomerRegistry1DataSet2 = New KudlerFineFoods.KudlerCustomerRegistryDataSet2()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.KudlerCustomerRegistrationTableAdapter1 = New KudlerFineFoods.KudlerCustomerRegistryDataSet2TableAdapters.KudlerCustomerRegistrationTableAdapter()
        Me.TableAdapterManager1 = New KudlerFineFoods.KudlerCustomerRegistryDataSet2TableAdapters.TableAdapterManager()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KudlerCustomerRegistrationTableAdapter = New KudlerFineFoods.KudlerCustomerRegistryDataSet2TableAdapters.KudlerCustomerRegistrationTableAdapter()
        Me.KudlerCustomerRegistrationTableAdapter2 = New KudlerFineFoods.KudlerCustomerRegistryDataSet2TableAdapters.KudlerCustomerRegistrationTableAdapter()
        Me.TableAdapterManager = New KudlerFineFoods.KudlerCustomerRegistryDataSet2TableAdapters.TableAdapterManager()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.KudlerCustomerRegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KudlerCustomerRegistrationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KudlerCustomerRegistrationBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KudlerCustomerRegistryDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KudlerCustomerRegistrationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KudlerCustomerRegistryDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KudlerCustomerRegistryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KudlerCustomerRegistry1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KudlerCustomerRegistrationDataGridView
        '
        Me.KudlerCustomerRegistrationDataGridView.AutoGenerateColumns = False
        Me.KudlerCustomerRegistrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KudlerCustomerRegistrationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CardnumberDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipcodeDataGridViewTextBoxColumn, Me.PhonenumberDataGridViewTextBoxColumn, Me.EmailaddressDataGridViewTextBoxColumn})
        Me.KudlerCustomerRegistrationDataGridView.DataSource = Me.KudlerCustomerRegistrationBindingSource2
        Me.KudlerCustomerRegistrationDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.KudlerCustomerRegistrationDataGridView.Name = "KudlerCustomerRegistrationDataGridView"
        Me.KudlerCustomerRegistrationDataGridView.Size = New System.Drawing.Size(1095, 511)
        Me.KudlerCustomerRegistrationDataGridView.TabIndex = 0
        '
        'CardnumberDataGridViewTextBoxColumn
        '
        Me.CardnumberDataGridViewTextBoxColumn.DataPropertyName = "Card_number"
        Me.CardnumberDataGridViewTextBoxColumn.HeaderText = "Card_number"
        Me.CardnumberDataGridViewTextBoxColumn.Name = "CardnumberDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "First_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "First_name"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Last_name"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'ZipcodeDataGridViewTextBoxColumn
        '
        Me.ZipcodeDataGridViewTextBoxColumn.DataPropertyName = "Zip_code"
        Me.ZipcodeDataGridViewTextBoxColumn.HeaderText = "Zip_code"
        Me.ZipcodeDataGridViewTextBoxColumn.Name = "ZipcodeDataGridViewTextBoxColumn"
        '
        'PhonenumberDataGridViewTextBoxColumn
        '
        Me.PhonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.HeaderText = "Phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.Name = "PhonenumberDataGridViewTextBoxColumn"
        '
        'EmailaddressDataGridViewTextBoxColumn
        '
        Me.EmailaddressDataGridViewTextBoxColumn.DataPropertyName = "Email_address"
        Me.EmailaddressDataGridViewTextBoxColumn.HeaderText = "Email_address"
        Me.EmailaddressDataGridViewTextBoxColumn.Name = "EmailaddressDataGridViewTextBoxColumn"
        '
        'KudlerCustomerRegistrationBindingSource2
        '
        Me.KudlerCustomerRegistrationBindingSource2.DataMember = "KudlerCustomerRegistration"
        Me.KudlerCustomerRegistrationBindingSource2.DataSource = Me.KudlerCustomerRegistryDataSet2
        '
        'KudlerCustomerRegistryDataSet2
        '
        Me.KudlerCustomerRegistryDataSet2.DataSetName = "KudlerCustomerRegistryDataSet2"
        Me.KudlerCustomerRegistryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KudlerCustomerRegistrationBindingSource1
        '
        Me.KudlerCustomerRegistrationBindingSource1.DataMember = "KudlerCustomerRegistration"
        Me.KudlerCustomerRegistrationBindingSource1.DataSource = Me.KudlerCustomerRegistryDataSet1BindingSource
        '
        'KudlerCustomerRegistryDataSet1BindingSource
        '
        Me.KudlerCustomerRegistryDataSet1BindingSource.DataSource = Me.KudlerCustomerRegistryDataSet1
        Me.KudlerCustomerRegistryDataSet1BindingSource.Position = 0
        '
        'KudlerCustomerRegistryDataSet1
        '
        Me.KudlerCustomerRegistryDataSet1.DataSetName = "KudlerCustomerRegistryDataSet1"
        Me.KudlerCustomerRegistryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KudlerCustomerRegistry1DataSet2
        '
        Me.KudlerCustomerRegistry1DataSet2.DataSetName = "KudlerCustomerRegistry1DataSet"
        Me.KudlerCustomerRegistry1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1095, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.IsLink = True
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(31, 22)
        Me.ToolStripLabel1.Text = "Save"
        '
        'KudlerCustomerRegistrationTableAdapter1
        '
        Me.KudlerCustomerRegistrationTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.KudlerCustomerRegistrationTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = KudlerFineFoods.KudlerCustomerRegistryDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KudlerCustomerRegistrationTableAdapter
        '
        Me.KudlerCustomerRegistrationTableAdapter.ClearBeforeFill = True
        '
        'KudlerCustomerRegistrationTableAdapter2
        '
        Me.KudlerCustomerRegistrationTableAdapter2.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KudlerCustomerRegistrationTableAdapter = Me.KudlerCustomerRegistrationTableAdapter2
        Me.TableAdapterManager.UpdateOrder = KudlerFineFoods.KudlerCustomerRegistryDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ViewCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 559)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.KudlerCustomerRegistrationDataGridView)
        Me.Name = "ViewCustomers"
        Me.Text = "ViewCustomers"
        CType(Me.KudlerCustomerRegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KudlerCustomerRegistrationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KudlerCustomerRegistrationBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KudlerCustomerRegistryDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KudlerCustomerRegistrationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KudlerCustomerRegistryDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KudlerCustomerRegistryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KudlerCustomerRegistry1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KudlerCustomerRegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KudlerCustomerRegistrationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KudlerCustomerRegistry1DataSet2 As KudlerFineFoods.KudlerCustomerRegistryDataSet2
    Friend WithEvents KudlerCustomerRegistrationTableAdapter1 As KudlerFineFoods.KudlerCustomerRegistryDataSet2TableAdapters.KudlerCustomerRegistrationTableAdapter
    Friend WithEvents TableAdapterManager1 As KudlerFineFoods.KudlerCustomerRegistryDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents KudlerCustomerRegistryDataSet1BindingSource As BindingSource
    Friend WithEvents KudlerCustomerRegistryDataSet1 As KudlerCustomerRegistryDataSet2
    Friend WithEvents KudlerCustomerRegistrationBindingSource1 As BindingSource
    Friend WithEvents KudlerCustomerRegistrationTableAdapter As KudlerCustomerRegistryDataSet2TableAdapters.KudlerCustomerRegistrationTableAdapter
    Friend WithEvents KudlerCustomerRegistryDataSet2 As KudlerFineFoods.KudlerCustomerRegistryDataSet2
    Friend WithEvents KudlerCustomerRegistrationBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents KudlerCustomerRegistrationTableAdapter2 As KudlerFineFoods.KudlerCustomerRegistryDataSet2TableAdapters.KudlerCustomerRegistrationTableAdapter
    Friend WithEvents TableAdapterManager As KudlerFineFoods.KudlerCustomerRegistryDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CardnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhonenumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailaddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
