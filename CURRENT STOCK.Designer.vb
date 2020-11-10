<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CURRENT_STOCK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CURRENT_STOCK))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PRODUCTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUENTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Shope.DataSet1()
        Me.Table1TableAdapter = New Shope.DataSet1TableAdapters.Table1TableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Cyan
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODUCTIDDataGridViewTextBoxColumn, Me.PRODUCTNAMEDataGridViewTextBoxColumn, Me.PRODUCTPRICEDataGridViewTextBoxColumn, Me.QUENTITYDataGridViewTextBoxColumn, Me.NOTEDataGridViewTextBoxColumn, Me.DATEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(23, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1087, 620)
        Me.DataGridView1.TabIndex = 0
        '
        'PRODUCTIDDataGridViewTextBoxColumn
        '
        Me.PRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT ID"
        Me.PRODUCTIDDataGridViewTextBoxColumn.HeaderText = "PRODUCT ID"
        Me.PRODUCTIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PRODUCTIDDataGridViewTextBoxColumn.Name = "PRODUCTIDDataGridViewTextBoxColumn"
        Me.PRODUCTIDDataGridViewTextBoxColumn.Width = 125
        '
        'PRODUCTNAMEDataGridViewTextBoxColumn
        '
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT NAME"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT NAME"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.Name = "PRODUCTNAMEDataGridViewTextBoxColumn"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.Width = 125
        '
        'PRODUCTPRICEDataGridViewTextBoxColumn
        '
        Me.PRODUCTPRICEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT PRICE"
        Me.PRODUCTPRICEDataGridViewTextBoxColumn.HeaderText = "PRODUCT PRICE"
        Me.PRODUCTPRICEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PRODUCTPRICEDataGridViewTextBoxColumn.Name = "PRODUCTPRICEDataGridViewTextBoxColumn"
        Me.PRODUCTPRICEDataGridViewTextBoxColumn.Width = 125
        '
        'QUENTITYDataGridViewTextBoxColumn
        '
        Me.QUENTITYDataGridViewTextBoxColumn.DataPropertyName = "QUENTITY"
        Me.QUENTITYDataGridViewTextBoxColumn.HeaderText = "QUENTITY"
        Me.QUENTITYDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QUENTITYDataGridViewTextBoxColumn.Name = "QUENTITYDataGridViewTextBoxColumn"
        Me.QUENTITYDataGridViewTextBoxColumn.Width = 125
        '
        'NOTEDataGridViewTextBoxColumn
        '
        Me.NOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE"
        Me.NOTEDataGridViewTextBoxColumn.HeaderText = "NOTE"
        Me.NOTEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOTEDataGridViewTextBoxColumn.Name = "NOTEDataGridViewTextBoxColumn"
        Me.NOTEDataGridViewTextBoxColumn.Width = 125
        '
        'DATEDataGridViewTextBoxColumn
        '
        Me.DATEDataGridViewTextBoxColumn.DataPropertyName = "DATE"
        Me.DATEDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.DATEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DATEDataGridViewTextBoxColumn.Name = "DATEDataGridViewTextBoxColumn"
        Me.DATEDataGridViewTextBoxColumn.Width = 125
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'CURRENT_STOCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 721)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CURRENT_STOCK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CURRENT_STOCK"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As DataSet1TableAdapters.Table1TableAdapter
    Friend WithEvents PRODUCTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUENTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
