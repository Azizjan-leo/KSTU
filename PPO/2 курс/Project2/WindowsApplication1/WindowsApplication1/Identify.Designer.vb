<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Identify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Identify))
        Me.AziClinicDataSet = New WindowsApplication1.AziClinicDataSet()
        Me.SymptomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SymptomsTableAdapter = New WindowsApplication1.AziClinicDataSetTableAdapters.SymptomsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AziClinicDataSetTableAdapters.TableAdapterManager()
        Me.SDTableAdapter = New WindowsApplication1.AziClinicDataSetTableAdapters.SDTableAdapter()
        Me.SymptomsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SymptomsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SympDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.AziClinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SymptomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SymptomsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SymptomsBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AziClinicDataSet
        '
        Me.AziClinicDataSet.DataSetName = "AziClinicDataSet"
        Me.AziClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SymptomsBindingSource
        '
        Me.SymptomsBindingSource.DataMember = "Symptoms"
        Me.SymptomsBindingSource.DataSource = Me.AziClinicDataSet
        '
        'SymptomsTableAdapter
        '
        Me.SymptomsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DiagnosisTableAdapter = Nothing
        Me.TableAdapterManager.SDTableAdapter = Me.SDTableAdapter
        Me.TableAdapterManager.SymptomsTableAdapter = Me.SymptomsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AziClinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SDTableAdapter
        '
        Me.SDTableAdapter.ClearBeforeFill = True
        '
        'SymptomsBindingNavigator
        '
        Me.SymptomsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SymptomsBindingNavigator.BindingSource = Me.SymptomsBindingSource
        Me.SymptomsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SymptomsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SymptomsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SymptomsBindingNavigatorSaveItem})
        Me.SymptomsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SymptomsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SymptomsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SymptomsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SymptomsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SymptomsBindingNavigator.Name = "SymptomsBindingNavigator"
        Me.SymptomsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SymptomsBindingNavigator.Size = New System.Drawing.Size(502, 25)
        Me.SymptomsBindingNavigator.TabIndex = 0
        Me.SymptomsBindingNavigator.Text = "BindingNavigator1"
        Me.SymptomsBindingNavigator.Visible = False
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
        'SymptomsBindingNavigatorSaveItem
        '
        Me.SymptomsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SymptomsBindingNavigatorSaveItem.Image = CType(resources.GetObject("SymptomsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SymptomsBindingNavigatorSaveItem.Name = "SymptomsBindingNavigatorSaveItem"
        Me.SymptomsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SymptomsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SymptomsBindingSource, "Name", True))
        Me.NameComboBox.DataSource = Me.SymptomsBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(145, 168)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(292, 21)
        Me.NameComboBox.TabIndex = 2
        Me.NameComboBox.ValueMember = "Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SympDataGridViewTextBoxColumn, Me.DiagnosDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SDBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(553, 150)
        Me.DataGridView1.TabIndex = 3
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
        Me.DiagnosDataGridViewTextBoxColumn.MinimumWidth = 250
        Me.DiagnosDataGridViewTextBoxColumn.Name = "DiagnosDataGridViewTextBoxColumn"
        Me.DiagnosDataGridViewTextBoxColumn.Width = 250
        '
        'SDBindingSource
        '
        Me.SDBindingSource.DataMember = "SD"
        Me.SDBindingSource.DataSource = Me.AziClinicDataSet
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 211)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Identify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 268)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(Me.SymptomsBindingNavigator)
        Me.Name = "Identify"
        Me.Text = "AziClinic"
        CType(Me.AziClinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SymptomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SymptomsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SymptomsBindingNavigator.ResumeLayout(False)
        Me.SymptomsBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AziClinicDataSet As AziClinicDataSet
    Friend WithEvents SymptomsBindingSource As BindingSource
    Friend WithEvents SymptomsTableAdapter As AziClinicDataSetTableAdapters.SymptomsTableAdapter
    Friend WithEvents TableAdapterManager As AziClinicDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SymptomsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SymptomsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents SDTableAdapter As AziClinicDataSetTableAdapters.SDTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SDBindingSource As BindingSource
    Friend WithEvents SympDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiagnosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
End Class
