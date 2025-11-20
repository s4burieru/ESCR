<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim ItemnameLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New Login_and_Roles_using_Local_Database.Database1DataSet()
        Me.TblitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemsTableAdapter = New Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.tblitemsTableAdapter()
        Me.TableAdapterManager = New Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.TableAdapterManager()
        Me.TblitemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ItemnameTextBox = New System.Windows.Forms.TextBox()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        IdLabel = New System.Windows.Forms.Label()
        ItemnameLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblitemsBindingSource
        '
        Me.TblitemsBindingSource.DataMember = "tblitems"
        Me.TblitemsBindingSource.DataSource = Me.Database1DataSet
        '
        'TblitemsTableAdapter
        '
        Me.TblitemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblitemsTableAdapter = Me.TblitemsTableAdapter
        Me.TableAdapterManager.tblusersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblitemsDataGridView
        '
        Me.TblitemsDataGridView.AllowUserToAddRows = False
        Me.TblitemsDataGridView.AllowUserToDeleteRows = False
        Me.TblitemsDataGridView.AutoGenerateColumns = False
        Me.TblitemsDataGridView.BackgroundColor = System.Drawing.Color.Peru
        Me.TblitemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblitemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblitemsDataGridView.DataSource = Me.TblitemsBindingSource
        Me.TblitemsDataGridView.Location = New System.Drawing.Point(724, 33)
        Me.TblitemsDataGridView.Name = "TblitemsDataGridView"
        Me.TblitemsDataGridView.ReadOnly = True
        Me.TblitemsDataGridView.RowTemplate.Height = 31
        Me.TblitemsDataGridView.Size = New System.Drawing.Size(813, 668)
        Me.TblitemsDataGridView.TabIndex = 1
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(79, 126)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(59, 45)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.BackColor = System.Drawing.Color.Bisque
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(277, 123)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(349, 49)
        Me.IdTextBox.TabIndex = 2
        '
        'ItemnameLabel
        '
        ItemnameLabel.AutoSize = True
        ItemnameLabel.Location = New System.Drawing.Point(79, 181)
        ItemnameLabel.Name = "ItemnameLabel"
        ItemnameLabel.Size = New System.Drawing.Size(192, 45)
        ItemnameLabel.TabIndex = 3
        ItemnameLabel.Text = "itemname:"
        '
        'ItemnameTextBox
        '
        Me.ItemnameTextBox.BackColor = System.Drawing.Color.Bisque
        Me.ItemnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "itemname", True))
        Me.ItemnameTextBox.Location = New System.Drawing.Point(277, 178)
        Me.ItemnameTextBox.Name = "ItemnameTextBox"
        Me.ItemnameTextBox.Size = New System.Drawing.Size(349, 49)
        Me.ItemnameTextBox.TabIndex = 4
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.Location = New System.Drawing.Point(79, 236)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(81, 45)
        QtyLabel.TabIndex = 5
        QtyLabel.Text = "qty:"
        '
        'QtyTextBox
        '
        Me.QtyTextBox.BackColor = System.Drawing.Color.Bisque
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(277, 233)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(349, 49)
        Me.QtyTextBox.TabIndex = 6
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(79, 291)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(108, 45)
        PriceLabel.TabIndex = 7
        PriceLabel.Text = "price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BackColor = System.Drawing.Color.Bisque
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(277, 288)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(349, 49)
        Me.PriceTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Bisque
        Me.Button1.Location = New System.Drawing.Point(83, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 71)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Bisque
        Me.Button2.Location = New System.Drawing.Point(277, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 71)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Bisque
        Me.Button3.Location = New System.Drawing.Point(83, 456)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 71)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Peru
        Me.Button4.Location = New System.Drawing.Point(71, 630)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(188, 71)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "back"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Tan
        Me.Label1.Font = New System.Drawing.Font("Road Rage", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(75, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 86)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "itemname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "itemname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 220
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "qty"
        Me.DataGridViewTextBoxColumn3.HeaderText = "qty"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1571, 749)
        Me.ShapeContainer1.TabIndex = 14
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.Peru
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.BorderColor = System.Drawing.Color.Peru
        Me.OvalShape1.BorderWidth = 5
        Me.OvalShape1.Location = New System.Drawing.Point(459, 492)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(112, 105)
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Peru
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 512
        Me.LineShape1.X2 = 512
        Me.LineShape1.Y1 = 597
        Me.LineShape1.Y2 = 704
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 785
        Me.LineShape2.X2 = 785
        Me.LineShape2.Y1 = 321
        Me.LineShape2.Y2 = 428
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Peru
        Me.LineShape3.BorderWidth = 5
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 456
        Me.LineShape3.X2 = 567
        Me.LineShape3.Y1 = 633
        Me.LineShape3.Y2 = 633
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Peru
        Me.RectangleShape1.BorderWidth = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(475, 705)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(75, 84)
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 43.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1571, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(ItemnameLabel)
        Me.Controls.Add(Me.ItemnameTextBox)
        Me.Controls.Add(QtyLabel)
        Me.Controls.Add(Me.QtyTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.TblitemsDataGridView)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As Login_and_Roles_using_Local_Database.Database1DataSet
    Friend WithEvents TblitemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblitemsTableAdapter As Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.tblitemsTableAdapter
    Friend WithEvents TableAdapterManager As Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblitemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
End Class
