<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterInfo
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
        Dim ProudctIDLabel As System.Windows.Forms.Label
        Dim ProudctNameLabel As System.Windows.Forms.Label
        Dim ProudctDiscLabel As System.Windows.Forms.Label
        Dim ProudctStockLabel As System.Windows.Forms.Label
        Dim ProudctPriceLabel As System.Windows.Forms.Label
        Dim ProudctImageLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnterInfo))
        Me.InvsysDB = New InvSys.invsysDB()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New InvSys.invsysDBTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New InvSys.invsysDBTableAdapters.TableAdapterManager()
        Me.Table1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Table1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProudctIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProudctNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProudctDiscTextBox = New System.Windows.Forms.TextBox()
        Me.ProudctStockTextBox = New System.Windows.Forms.TextBox()
        Me.ProudctPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        ProudctIDLabel = New System.Windows.Forms.Label()
        ProudctNameLabel = New System.Windows.Forms.Label()
        ProudctDiscLabel = New System.Windows.Forms.Label()
        ProudctStockLabel = New System.Windows.Forms.Label()
        ProudctPriceLabel = New System.Windows.Forms.Label()
        ProudctImageLabel = New System.Windows.Forms.Label()
        CType(Me.InvsysDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table1BindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProudctIDLabel
        '
        ProudctIDLabel.AutoSize = True
        ProudctIDLabel.BackColor = System.Drawing.Color.WhiteSmoke
        ProudctIDLabel.Location = New System.Drawing.Point(12, 40)
        ProudctIDLabel.Name = "ProudctIDLabel"
        ProudctIDLabel.Size = New System.Drawing.Size(61, 13)
        ProudctIDLabel.TabIndex = 1
        ProudctIDLabel.Text = "Proudct ID:"
        '
        'ProudctNameLabel
        '
        ProudctNameLabel.AutoSize = True
        ProudctNameLabel.BackColor = System.Drawing.Color.WhiteSmoke
        ProudctNameLabel.Location = New System.Drawing.Point(12, 66)
        ProudctNameLabel.Name = "ProudctNameLabel"
        ProudctNameLabel.Size = New System.Drawing.Size(78, 13)
        ProudctNameLabel.TabIndex = 3
        ProudctNameLabel.Text = "Proudct Name:"
        '
        'ProudctDiscLabel
        '
        ProudctDiscLabel.AutoSize = True
        ProudctDiscLabel.BackColor = System.Drawing.Color.WhiteSmoke
        ProudctDiscLabel.Location = New System.Drawing.Point(12, 92)
        ProudctDiscLabel.Name = "ProudctDiscLabel"
        ProudctDiscLabel.Size = New System.Drawing.Size(71, 13)
        ProudctDiscLabel.TabIndex = 5
        ProudctDiscLabel.Text = "Proudct Disc:"
        '
        'ProudctStockLabel
        '
        ProudctStockLabel.AutoSize = True
        ProudctStockLabel.BackColor = System.Drawing.Color.WhiteSmoke
        ProudctStockLabel.Location = New System.Drawing.Point(12, 118)
        ProudctStockLabel.Name = "ProudctStockLabel"
        ProudctStockLabel.Size = New System.Drawing.Size(78, 13)
        ProudctStockLabel.TabIndex = 7
        ProudctStockLabel.Text = "Proudct Stock:"
        '
        'ProudctPriceLabel
        '
        ProudctPriceLabel.AutoSize = True
        ProudctPriceLabel.BackColor = System.Drawing.Color.WhiteSmoke
        ProudctPriceLabel.Location = New System.Drawing.Point(12, 144)
        ProudctPriceLabel.Name = "ProudctPriceLabel"
        ProudctPriceLabel.Size = New System.Drawing.Size(74, 13)
        ProudctPriceLabel.TabIndex = 9
        ProudctPriceLabel.Text = "Proudct Price:"
        '
        'ProudctImageLabel
        '
        ProudctImageLabel.AutoSize = True
        ProudctImageLabel.BackColor = System.Drawing.Color.WhiteSmoke
        ProudctImageLabel.Location = New System.Drawing.Point(12, 167)
        ProudctImageLabel.Name = "ProudctImageLabel"
        ProudctImageLabel.Size = New System.Drawing.Size(79, 13)
        ProudctImageLabel.TabIndex = 11
        ProudctImageLabel.Text = "Proudct Image:"
        '
        'InvsysDB
        '
        Me.InvsysDB.DataSetName = "invsysDB"
        Me.InvsysDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.InvsysDB
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = InvSys.invsysDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table1BindingNavigator
        '
        Me.Table1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Table1BindingNavigator.BindingSource = Me.Table1BindingSource
        Me.Table1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Table1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Table1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Table1BindingNavigatorSaveItem})
        Me.Table1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Table1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Table1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Table1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Table1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Table1BindingNavigator.Name = "Table1BindingNavigator"
        Me.Table1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Table1BindingNavigator.Size = New System.Drawing.Size(349, 25)
        Me.Table1BindingNavigator.TabIndex = 0
        Me.Table1BindingNavigator.Text = "BindingNavigator1"
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
        'Table1BindingNavigatorSaveItem
        '
        Me.Table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Table1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Table1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Table1BindingNavigatorSaveItem.Name = "Table1BindingNavigatorSaveItem"
        Me.Table1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Table1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProudctIDTextBox
        '
        Me.ProudctIDTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProudctIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ProudctID", True))
        Me.ProudctIDTextBox.Location = New System.Drawing.Point(97, 37)
        Me.ProudctIDTextBox.Name = "ProudctIDTextBox"
        Me.ProudctIDTextBox.Size = New System.Drawing.Size(240, 20)
        Me.ProudctIDTextBox.TabIndex = 2
        '
        'ProudctNameTextBox
        '
        Me.ProudctNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProudctNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ProudctName", True))
        Me.ProudctNameTextBox.Location = New System.Drawing.Point(97, 63)
        Me.ProudctNameTextBox.Name = "ProudctNameTextBox"
        Me.ProudctNameTextBox.Size = New System.Drawing.Size(240, 20)
        Me.ProudctNameTextBox.TabIndex = 4
        '
        'ProudctDiscTextBox
        '
        Me.ProudctDiscTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProudctDiscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ProudctDisc", True))
        Me.ProudctDiscTextBox.Location = New System.Drawing.Point(97, 89)
        Me.ProudctDiscTextBox.Name = "ProudctDiscTextBox"
        Me.ProudctDiscTextBox.Size = New System.Drawing.Size(240, 20)
        Me.ProudctDiscTextBox.TabIndex = 6
        '
        'ProudctStockTextBox
        '
        Me.ProudctStockTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProudctStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ProudctStock", True))
        Me.ProudctStockTextBox.Location = New System.Drawing.Point(97, 115)
        Me.ProudctStockTextBox.Name = "ProudctStockTextBox"
        Me.ProudctStockTextBox.Size = New System.Drawing.Size(240, 20)
        Me.ProudctStockTextBox.TabIndex = 8
        '
        'ProudctPriceTextBox
        '
        Me.ProudctPriceTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProudctPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ProudctPrice", True))
        Me.ProudctPriceTextBox.Location = New System.Drawing.Point(97, 141)
        Me.ProudctPriceTextBox.Name = "ProudctPriceTextBox"
        Me.ProudctPriceTextBox.Size = New System.Drawing.Size(240, 20)
        Me.ProudctPriceTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(11, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 79)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "select image"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(14, 286)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(322, 69)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "DBform"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Table1BindingSource, "ProudctImage", True))
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(97, 167)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'EnterInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InvSys.My.Resources.Resources.Black_abstract_art_vectors_background
        Me.ClientSize = New System.Drawing.Size(349, 367)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ProudctIDLabel)
        Me.Controls.Add(Me.ProudctIDTextBox)
        Me.Controls.Add(ProudctNameLabel)
        Me.Controls.Add(Me.ProudctNameTextBox)
        Me.Controls.Add(ProudctDiscLabel)
        Me.Controls.Add(Me.ProudctDiscTextBox)
        Me.Controls.Add(ProudctStockLabel)
        Me.Controls.Add(Me.ProudctStockTextBox)
        Me.Controls.Add(ProudctPriceLabel)
        Me.Controls.Add(Me.ProudctPriceTextBox)
        Me.Controls.Add(ProudctImageLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Table1BindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EnterInfo"
        Me.Text = "EnterInfo"
        CType(Me.InvsysDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table1BindingNavigator.ResumeLayout(False)
        Me.Table1BindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InvsysDB As InvSys.invsysDB
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As InvSys.invsysDBTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As InvSys.invsysDBTableAdapters.TableAdapterManager
    Friend WithEvents Table1BindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Table1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProudctIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProudctNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProudctDiscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProudctStockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProudctPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
