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
        Dim ItemnameLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New Simple_Inventory_Structure_with_Local_DB.Database1DataSet()
        Me.TblitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemsTableAdapter = New Simple_Inventory_Structure_with_Local_DB.Database1DataSetTableAdapters.tblitemsTableAdapter()
        Me.TableAdapterManager = New Simple_Inventory_Structure_with_Local_DB.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ItemnameComboBox = New System.Windows.Forms.ComboBox()
        Me.QtyTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        ItemnameLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.UpdateOrder = Simple_Inventory_Structure_with_Local_DB.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ItemnameLabel
        '
        ItemnameLabel.AutoSize = True
        ItemnameLabel.Location = New System.Drawing.Point(86, 108)
        ItemnameLabel.Name = "ItemnameLabel"
        ItemnameLabel.Size = New System.Drawing.Size(175, 39)
        ItemnameLabel.TabIndex = 3
        ItemnameLabel.Text = "itemname:"
        '
        'ItemnameComboBox
        '
        Me.ItemnameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "itemname", True))
        Me.ItemnameComboBox.FormattingEnabled = True
        Me.ItemnameComboBox.Items.AddRange(New Object() {"Apple", "Banana", "Mango"})
        Me.ItemnameComboBox.Location = New System.Drawing.Point(267, 105)
        Me.ItemnameComboBox.Name = "ItemnameComboBox"
        Me.ItemnameComboBox.Size = New System.Drawing.Size(310, 46)
        Me.ItemnameComboBox.TabIndex = 4
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.Location = New System.Drawing.Point(86, 161)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(71, 39)
        QtyLabel.TabIndex = 5
        QtyLabel.Text = "qty:"
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "qty", True))
        Me.QtyTextBox.Location = New System.Drawing.Point(267, 158)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(310, 45)
        Me.QtyTextBox.TabIndex = 6
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(86, 212)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(100, 39)
        PriceLabel.TabIndex = 7
        PriceLabel.Text = "price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblitemsBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(267, 209)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(310, 45)
        Me.PriceTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 67)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(340, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 67)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 38.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(677, 513)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ItemnameLabel)
        Me.Controls.Add(Me.ItemnameComboBox)
        Me.Controls.Add(QtyLabel)
        Me.Controls.Add(Me.QtyTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As Simple_Inventory_Structure_with_Local_DB.Database1DataSet
    Friend WithEvents TblitemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblitemsTableAdapter As Simple_Inventory_Structure_with_Local_DB.Database1DataSetTableAdapters.tblitemsTableAdapter
    Friend WithEvents TableAdapterManager As Simple_Inventory_Structure_with_Local_DB.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemnameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
