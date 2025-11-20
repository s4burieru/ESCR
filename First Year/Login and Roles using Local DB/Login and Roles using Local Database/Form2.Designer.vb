<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim RoleLabel As System.Windows.Forms.Label
        Me.TblusersDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TblusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Login_and_Roles_using_Local_Database.Database1DataSet()
        Me.TblusersTableAdapter = New Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.tblusersTableAdapter()
        Me.TableAdapterManager = New Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        IdLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        RoleLabel = New System.Windows.Forms.Label()
        CType(Me.TblusersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblusersDataGridView
        '
        Me.TblusersDataGridView.AllowUserToAddRows = False
        Me.TblusersDataGridView.AllowUserToDeleteRows = False
        Me.TblusersDataGridView.AutoGenerateColumns = False
        Me.TblusersDataGridView.BackgroundColor = System.Drawing.Color.Peru
        Me.TblusersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblusersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblusersDataGridView.DataSource = Me.TblusersBindingSource
        Me.TblusersDataGridView.Location = New System.Drawing.Point(706, 32)
        Me.TblusersDataGridView.Name = "TblusersDataGridView"
        Me.TblusersDataGridView.ReadOnly = True
        Me.TblusersDataGridView.RowTemplate.Height = 31
        Me.TblusersDataGridView.Size = New System.Drawing.Size(783, 665)
        Me.TblusersDataGridView.TabIndex = 1
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(49, 80)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(59, 45)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.BackColor = System.Drawing.Color.Bisque
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblusersBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(243, 77)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(411, 49)
        Me.IdTextBox.TabIndex = 2
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(49, 135)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(188, 45)
        UsernameLabel.TabIndex = 3
        UsernameLabel.Text = "username:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.Bisque
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblusersBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(243, 132)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(411, 49)
        Me.UsernameTextBox.TabIndex = 4
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(49, 190)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(185, 45)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.Bisque
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblusersBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(243, 187)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(411, 49)
        Me.PasswordTextBox.TabIndex = 6
        '
        'RoleLabel
        '
        RoleLabel.AutoSize = True
        RoleLabel.Location = New System.Drawing.Point(49, 246)
        RoleLabel.Name = "RoleLabel"
        RoleLabel.Size = New System.Drawing.Size(91, 45)
        RoleLabel.TabIndex = 7
        RoleLabel.Text = "role:"
        '
        'RoleComboBox
        '
        Me.RoleComboBox.BackColor = System.Drawing.Color.Bisque
        Me.RoleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblusersBindingSource, "role", True))
        Me.RoleComboBox.FormattingEnabled = True
        Me.RoleComboBox.Items.AddRange(New Object() {"admin", "user"})
        Me.RoleComboBox.Location = New System.Drawing.Point(243, 243)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(411, 51)
        Me.RoleComboBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Bisque
        Me.Button1.Location = New System.Drawing.Point(44, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 68)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Bisque
        Me.Button2.Location = New System.Drawing.Point(243, 357)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(193, 68)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Bisque
        Me.Button3.Location = New System.Drawing.Point(44, 431)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(193, 68)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "back"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TblusersBindingSource
        '
        Me.TblusersBindingSource.DataMember = "tblusers"
        Me.TblusersBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblusersTableAdapter
        '
        Me.TblusersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblitemsTableAdapter = Nothing
        Me.TableAdapterManager.tblusersTableAdapter = Me.TblusersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.FillWeight = 12.27496!
        Me.DataGridViewTextBoxColumn2.HeaderText = "username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 220
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn3.FillWeight = 51.55483!
        Me.DataGridViewTextBoxColumn3.HeaderText = "password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 220
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "role"
        Me.DataGridViewTextBoxColumn4.FillWeight = 236.1702!
        Me.DataGridViewTextBoxColumn4.HeaderText = "role"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape5, Me.OvalShape4, Me.OvalShape3, Me.OvalShape2, Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1544, 743)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.Peru
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.Location = New System.Drawing.Point(104, 647)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(507, 206)
        '
        'OvalShape2
        '
        Me.OvalShape2.BackColor = System.Drawing.Color.Peru
        Me.OvalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape2.FillGradientColor = System.Drawing.Color.Transparent
        Me.OvalShape2.Location = New System.Drawing.Point(441, 584)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(228, 206)
        '
        'OvalShape3
        '
        Me.OvalShape3.BackColor = System.Drawing.Color.Peru
        Me.OvalShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape3.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OvalShape3.Location = New System.Drawing.Point(38, 582)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(228, 206)
        '
        'OvalShape4
        '
        Me.OvalShape4.BackColor = System.Drawing.Color.Black
        Me.OvalShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape4.FillGradientColor = System.Drawing.Color.Transparent
        Me.OvalShape4.Location = New System.Drawing.Point(491, 630)
        Me.OvalShape4.Name = "OvalShape4"
        Me.OvalShape4.Size = New System.Drawing.Size(128, 123)
        '
        'OvalShape5
        '
        Me.OvalShape5.BackColor = System.Drawing.Color.Black
        Me.OvalShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape5.FillGradientColor = System.Drawing.Color.Transparent
        Me.OvalShape5.Location = New System.Drawing.Point(85, 630)
        Me.OvalShape5.Name = "OvalShape5"
        Me.OvalShape5.Size = New System.Drawing.Size(128, 123)
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 43.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1544, 743)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(RoleLabel)
        Me.Controls.Add(Me.RoleComboBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.TblusersDataGridView)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.TblusersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As Login_and_Roles_using_Local_Database.Database1DataSet
    Friend WithEvents TblusersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblusersTableAdapter As Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.tblusersTableAdapter
    Friend WithEvents TableAdapterManager As Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblusersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape5 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape4 As Microsoft.VisualBasic.PowerPacks.OvalShape
End Class
