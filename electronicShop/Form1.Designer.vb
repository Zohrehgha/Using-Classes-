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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ElectronicShopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectronicShopDBDataSet = New electronicShop.electronicShopDBDataSet()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ElectronicShopTableAdapter = New electronicShop.electronicShopDBDataSetTableAdapters.electronicShopTableAdapter()
        Me.PhoneIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeatureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuiltDayNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuiltDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuiltMonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuiltYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoldDayNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoldDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoldMonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoldYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectronicShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectronicShopDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(516, 79)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Electronic Shop"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "phoneID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 42)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Make"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 42)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Model"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 618)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 42)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Built Date :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 700)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(235, 42)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Name of Day"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(515, 700)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 42)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Day"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(737, 695)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 42)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Month"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1096, 695)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 42)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Year"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(40, 796)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(202, 42)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Sold Date :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(43, 870)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(235, 42)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Name of Day"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(515, 860)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 42)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Day"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(758, 851)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 42)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Month"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1096, 846)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 42)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Year"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(238, 142)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 56)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(238, 227)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(268, 56)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(235, 317)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(268, 56)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(284, 695)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(191, 56)
        Me.TextBox4.TabIndex = 17
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(628, 691)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(65, 56)
        Me.TextBox5.TabIndex = 18
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(905, 695)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(130, 56)
        Me.TextBox6.TabIndex = 19
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(1248, 686)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(141, 56)
        Me.TextBox7.TabIndex = 20
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(290, 856)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(185, 56)
        Me.TextBox8.TabIndex = 21
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(628, 842)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(64, 56)
        Me.TextBox9.TabIndex = 22
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(905, 846)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(130, 56)
        Me.TextBox10.TabIndex = 23
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(1248, 846)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(141, 56)
        Me.TextBox11.TabIndex = 24
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(235, 411)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(268, 56)
        Me.TextBox12.TabIndex = 25
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(235, 501)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(268, 56)
        Me.TextBox13.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(43, 425)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 42)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Price"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(43, 515)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(147, 42)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Feature"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(915, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(289, 42)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Data existing list"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(597, 566)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(283, 94)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Save the object"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(925, 566)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(268, 94)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Clear Form"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1228, 566)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(304, 94)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Search by ID"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PhoneIDDataGridViewTextBoxColumn, Me.MakeDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.FeatureDataGridViewTextBoxColumn, Me.BuiltDayNameDataGridViewTextBoxColumn, Me.BuiltDayDataGridViewTextBoxColumn, Me.BuiltMonthDataGridViewTextBoxColumn, Me.BuiltYearDataGridViewTextBoxColumn, Me.SoldDayNameDataGridViewTextBoxColumn, Me.SoldDayDataGridViewTextBoxColumn, Me.SoldMonthDataGridViewTextBoxColumn, Me.SoldYearDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ElectronicShopBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(551, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(981, 360)
        Me.DataGridView1.TabIndex = 35
        '
        'ElectronicShopBindingSource
        '
        Me.ElectronicShopBindingSource.DataMember = "electronicShop"
        Me.ElectronicShopBindingSource.DataSource = Me.ElectronicShopDBDataSet
        '
        'ElectronicShopDBDataSet
        '
        Me.ElectronicShopDBDataSet.DataSetName = "electronicShopDBDataSet"
        Me.ElectronicShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(2298, 39)
        Me.FillByToolStrip.TabIndex = 36
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(75, 36)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'ElectronicShopTableAdapter
        '
        Me.ElectronicShopTableAdapter.ClearBeforeFill = True
        '
        'PhoneIDDataGridViewTextBoxColumn
        '
        Me.PhoneIDDataGridViewTextBoxColumn.DataPropertyName = "phoneID"
        Me.PhoneIDDataGridViewTextBoxColumn.HeaderText = "phoneID"
        Me.PhoneIDDataGridViewTextBoxColumn.Name = "PhoneIDDataGridViewTextBoxColumn"
        '
        'MakeDataGridViewTextBoxColumn
        '
        Me.MakeDataGridViewTextBoxColumn.DataPropertyName = "make"
        Me.MakeDataGridViewTextBoxColumn.HeaderText = "make"
        Me.MakeDataGridViewTextBoxColumn.Name = "MakeDataGridViewTextBoxColumn"
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'FeatureDataGridViewTextBoxColumn
        '
        Me.FeatureDataGridViewTextBoxColumn.DataPropertyName = "feature"
        Me.FeatureDataGridViewTextBoxColumn.HeaderText = "feature"
        Me.FeatureDataGridViewTextBoxColumn.Name = "FeatureDataGridViewTextBoxColumn"
        '
        'BuiltDayNameDataGridViewTextBoxColumn
        '
        Me.BuiltDayNameDataGridViewTextBoxColumn.DataPropertyName = "builtDayName"
        Me.BuiltDayNameDataGridViewTextBoxColumn.HeaderText = "builtDayName"
        Me.BuiltDayNameDataGridViewTextBoxColumn.Name = "BuiltDayNameDataGridViewTextBoxColumn"
        '
        'BuiltDayDataGridViewTextBoxColumn
        '
        Me.BuiltDayDataGridViewTextBoxColumn.DataPropertyName = "builtDay"
        Me.BuiltDayDataGridViewTextBoxColumn.HeaderText = "builtDay"
        Me.BuiltDayDataGridViewTextBoxColumn.Name = "BuiltDayDataGridViewTextBoxColumn"
        '
        'BuiltMonthDataGridViewTextBoxColumn
        '
        Me.BuiltMonthDataGridViewTextBoxColumn.DataPropertyName = "builtMonth"
        Me.BuiltMonthDataGridViewTextBoxColumn.HeaderText = "builtMonth"
        Me.BuiltMonthDataGridViewTextBoxColumn.Name = "BuiltMonthDataGridViewTextBoxColumn"
        '
        'BuiltYearDataGridViewTextBoxColumn
        '
        Me.BuiltYearDataGridViewTextBoxColumn.DataPropertyName = "builtYear"
        Me.BuiltYearDataGridViewTextBoxColumn.HeaderText = "builtYear"
        Me.BuiltYearDataGridViewTextBoxColumn.Name = "BuiltYearDataGridViewTextBoxColumn"
        '
        'SoldDayNameDataGridViewTextBoxColumn
        '
        Me.SoldDayNameDataGridViewTextBoxColumn.DataPropertyName = "soldDayName"
        Me.SoldDayNameDataGridViewTextBoxColumn.HeaderText = "soldDayName"
        Me.SoldDayNameDataGridViewTextBoxColumn.Name = "SoldDayNameDataGridViewTextBoxColumn"
        '
        'SoldDayDataGridViewTextBoxColumn
        '
        Me.SoldDayDataGridViewTextBoxColumn.DataPropertyName = "soldDay"
        Me.SoldDayDataGridViewTextBoxColumn.HeaderText = "soldDay"
        Me.SoldDayDataGridViewTextBoxColumn.Name = "SoldDayDataGridViewTextBoxColumn"
        '
        'SoldMonthDataGridViewTextBoxColumn
        '
        Me.SoldMonthDataGridViewTextBoxColumn.DataPropertyName = "soldMonth"
        Me.SoldMonthDataGridViewTextBoxColumn.HeaderText = "soldMonth"
        Me.SoldMonthDataGridViewTextBoxColumn.Name = "SoldMonthDataGridViewTextBoxColumn"
        '
        'SoldYearDataGridViewTextBoxColumn
        '
        Me.SoldYearDataGridViewTextBoxColumn.DataPropertyName = "soldYear"
        Me.SoldYearDataGridViewTextBoxColumn.HeaderText = "soldYear"
        Me.SoldYearDataGridViewTextBoxColumn.Name = "SoldYearDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2298, 987)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectronicShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectronicShopDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ElectronicShopDBDataSet As electronicShopDBDataSet
    Friend WithEvents ElectronicShopBindingSource As BindingSource
    Friend WithEvents ElectronicShopTableAdapter As electronicShopDBDataSetTableAdapters.electronicShopTableAdapter
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents PhoneIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MakeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeatureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuiltDayNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuiltDayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuiltMonthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuiltYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoldDayNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoldDayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoldMonthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoldYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
