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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CompanyNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactTitleColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostalCodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currentRowDetailsButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.currentRowDetailsButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 392)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 58)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompanyNameColumn, Me.ContactNameColumn, Me.ContactTitleColumn, Me.StreetColumn, Me.CityColumn, Me.PostalCodeColumn, Me.CountryNameColumn, Me.PhoneColumn})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(856, 392)
        Me.DataGridView1.TabIndex = 1
        '
        'CompanyNameColumn
        '
        Me.CompanyNameColumn.DataPropertyName = "CompanyName"
        Me.CompanyNameColumn.HeaderText = "Company"
        Me.CompanyNameColumn.Name = "CompanyNameColumn"
        '
        'ContactNameColumn
        '
        Me.ContactNameColumn.DataPropertyName = "FullName"
        Me.ContactNameColumn.HeaderText = "Contact"
        Me.ContactNameColumn.Name = "ContactNameColumn"
        '
        'ContactTitleColumn
        '
        Me.ContactTitleColumn.DataPropertyName = "ContactTitle"
        Me.ContactTitleColumn.HeaderText = "Title"
        Me.ContactTitleColumn.Name = "ContactTitleColumn"
        '
        'StreetColumn
        '
        Me.StreetColumn.DataPropertyName = "Street"
        Me.StreetColumn.HeaderText = "Street"
        Me.StreetColumn.Name = "StreetColumn"
        '
        'CityColumn
        '
        Me.CityColumn.DataPropertyName = "City"
        Me.CityColumn.HeaderText = "City"
        Me.CityColumn.Name = "CityColumn"
        '
        'PostalCodeColumn
        '
        Me.PostalCodeColumn.DataPropertyName = "PostalCode"
        Me.PostalCodeColumn.HeaderText = "Zip code"
        Me.PostalCodeColumn.Name = "PostalCodeColumn"
        '
        'CountryNameColumn
        '
        Me.CountryNameColumn.DataPropertyName = "CountryName"
        Me.CountryNameColumn.HeaderText = "Country"
        Me.CountryNameColumn.Name = "CountryNameColumn"
        '
        'PhoneColumn
        '
        Me.PhoneColumn.DataPropertyName = "Phone"
        Me.PhoneColumn.HeaderText = "Phone"
        Me.PhoneColumn.Name = "PhoneColumn"
        '
        'currentRowDetailsButton
        '
        Me.currentRowDetailsButton.Location = New System.Drawing.Point(18, 17)
        Me.currentRowDetailsButton.Name = "currentRowDetailsButton"
        Me.currentRowDetailsButton.Size = New System.Drawing.Size(128, 23)
        Me.currentRowDetailsButton.TabIndex = 0
        Me.currentRowDetailsButton.Text = "Current Row details"
        Me.currentRowDetailsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL-Server Basic read"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CompanyNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactTitleColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreetColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostalCodeColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneColumn As DataGridViewTextBoxColumn
    Friend WithEvents currentRowDetailsButton As Button
End Class
