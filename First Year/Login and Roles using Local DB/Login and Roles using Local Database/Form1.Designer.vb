<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Database1DataSet = New Login_and_Roles_using_Local_Database.Database1DataSet()
        Me.TblusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblusersTableAdapter = New Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.tblusersTableAdapter()
        Me.TableAdapterManager = New Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.TableAdapterManager()
        Me.OvalShape5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "username:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Bisque
        Me.TextBox1.Location = New System.Drawing.Point(352, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(430, 49)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Bisque
        Me.TextBox2.Location = New System.Drawing.Point(352, 122)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(430, 49)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 45)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "password:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Bisque
        Me.Button1.Location = New System.Drawing.Point(224, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 67)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "LOG IN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Bisque
        Me.Button2.Location = New System.Drawing.Point(468, 222)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(193, 67)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "REGISTER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblusersBindingSource
        '
        Me.TblusersBindingSource.DataMember = "tblusers"
        Me.TblusersBindingSource.DataSource = Me.Database1DataSet
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
        'OvalShape5
        '
        Me.OvalShape5.BackColor = System.Drawing.Color.Black
        Me.OvalShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape5.FillGradientColor = System.Drawing.Color.Transparent
        Me.OvalShape5.Location = New System.Drawing.Point(171, 404)
        Me.OvalShape5.Name = "OvalShape5"
        Me.OvalShape5.Size = New System.Drawing.Size(128, 123)
        '
        'OvalShape4
        '
        Me.OvalShape4.BackColor = System.Drawing.Color.Black
        Me.OvalShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape4.FillGradientColor = System.Drawing.Color.Transparent
        Me.OvalShape4.Location = New System.Drawing.Point(577, 404)
        Me.OvalShape4.Name = "OvalShape4"
        Me.OvalShape4.Size = New System.Drawing.Size(128, 123)
        '
        'OvalShape3
        '
        Me.OvalShape3.BackColor = System.Drawing.Color.Peru
        Me.OvalShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape3.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OvalShape3.Location = New System.Drawing.Point(124, 356)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(228, 206)
        '
        'OvalShape2
        '
        Me.OvalShape2.BackColor = System.Drawing.Color.Peru
        Me.OvalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape2.FillGradientColor = System.Drawing.Color.Transparent
        Me.OvalShape2.Location = New System.Drawing.Point(527, 358)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(228, 206)
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.Peru
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.Location = New System.Drawing.Point(190, 421)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(507, 206)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1, Me.OvalShape2, Me.OvalShape3, Me.OvalShape4, Me.OvalShape5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(905, 539)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 43.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(905, 539)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet As Login_and_Roles_using_Local_Database.Database1DataSet
    Friend WithEvents TblusersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblusersTableAdapter As Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.tblusersTableAdapter
    Friend WithEvents TableAdapterManager As Login_and_Roles_using_Local_Database.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents OvalShape5 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape4 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer

End Class
