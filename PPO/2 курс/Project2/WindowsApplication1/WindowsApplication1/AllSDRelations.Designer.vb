<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllSDRelations
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AziClinicDataSet = New WindowsApplication1.AziClinicDataSet()
        Me.SDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SDTableAdapter = New WindowsApplication1.AziClinicDataSetTableAdapters.SDTableAdapter()
        Me.SympDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AziClinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SympDataGridViewTextBoxColumn, Me.DiagnosDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SDBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(613, 219)
        Me.DataGridView1.TabIndex = 0
        '
        'AziClinicDataSet
        '
        Me.AziClinicDataSet.DataSetName = "AziClinicDataSet"
        Me.AziClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SDBindingSource
        '
        Me.SDBindingSource.DataMember = "SD"
        Me.SDBindingSource.DataSource = Me.AziClinicDataSet
        '
        'SDTableAdapter
        '
        Me.SDTableAdapter.ClearBeforeFill = True
        '
        'SympDataGridViewTextBoxColumn
        '
        Me.SympDataGridViewTextBoxColumn.DataPropertyName = "Symp"
        Me.SympDataGridViewTextBoxColumn.HeaderText = "Symp"
        Me.SympDataGridViewTextBoxColumn.MinimumWidth = 250
        Me.SympDataGridViewTextBoxColumn.Name = "SympDataGridViewTextBoxColumn"
        Me.SympDataGridViewTextBoxColumn.Width = 250
        '
        'DiagnosDataGridViewTextBoxColumn
        '
        Me.DiagnosDataGridViewTextBoxColumn.DataPropertyName = "Diagnos"
        Me.DiagnosDataGridViewTextBoxColumn.HeaderText = "Diagnos"
        Me.DiagnosDataGridViewTextBoxColumn.MinimumWidth = 300
        Me.DiagnosDataGridViewTextBoxColumn.Name = "DiagnosDataGridViewTextBoxColumn"
        Me.DiagnosDataGridViewTextBoxColumn.Width = 300
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(551, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(470, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AllSDRelations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 268)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AllSDRelations"
        Me.Text = "AllSDRelations"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AziClinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AziClinicDataSet As AziClinicDataSet
    Friend WithEvents SDBindingSource As BindingSource
    Friend WithEvents SDTableAdapter As AziClinicDataSetTableAdapters.SDTableAdapter
    Friend WithEvents SympDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiagnosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
