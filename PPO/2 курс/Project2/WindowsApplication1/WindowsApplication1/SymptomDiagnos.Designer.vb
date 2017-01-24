<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SymptomDiagnos
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
        Dim SympLabel As System.Windows.Forms.Label
        Dim DiagnosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SymptomDiagnos))
        Me.AziClinicDataSet = New WindowsApplication1.AziClinicDataSet()
        Me.SDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SDTableAdapter = New WindowsApplication1.AziClinicDataSetTableAdapters.SDTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AziClinicDataSetTableAdapters.TableAdapterManager()
        Me.DiagnosisTableAdapter = New WindowsApplication1.AziClinicDataSetTableAdapters.DiagnosisTableAdapter()
        Me.SymptomsTableAdapter = New WindowsApplication1.AziClinicDataSetTableAdapters.SymptomsTableAdapter()
        Me.SDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SympTextBox = New System.Windows.Forms.TextBox()
        Me.DiagnosTextBox = New System.Windows.Forms.TextBox()
        Me.DiagnosisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.SymptomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SymptomsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        SympLabel = New System.Windows.Forms.Label()
        DiagnosLabel = New System.Windows.Forms.Label()
        CType(Me.AziClinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SDBindingNavigator.SuspendLayout()
        CType(Me.DiagnosisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SymptomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SymptomsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SympLabel
        '
        SympLabel.AutoSize = True
        SympLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SympLabel.Location = New System.Drawing.Point(9, 33)
        SympLabel.Name = "SympLabel"
        SympLabel.Size = New System.Drawing.Size(44, 15)
        SympLabel.TabIndex = 1
        SympLabel.Text = "Symp:"
        '
        'DiagnosLabel
        '
        DiagnosLabel.AutoSize = True
        DiagnosLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DiagnosLabel.Location = New System.Drawing.Point(12, 121)
        DiagnosLabel.Name = "DiagnosLabel"
        DiagnosLabel.Size = New System.Drawing.Size(61, 15)
        DiagnosLabel.TabIndex = 3
        DiagnosLabel.Text = "Diagnos:"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DiagnosisTableAdapter = Me.DiagnosisTableAdapter
        Me.TableAdapterManager.SDTableAdapter = Me.SDTableAdapter
        Me.TableAdapterManager.SymptomsTableAdapter = Me.SymptomsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AziClinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DiagnosisTableAdapter
        '
        Me.DiagnosisTableAdapter.ClearBeforeFill = True
        '
        'SymptomsTableAdapter
        '
        Me.SymptomsTableAdapter.ClearBeforeFill = True
        '
        'SDBindingNavigator
        '
        Me.SDBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SDBindingNavigator.BindingSource = Me.SDBindingSource
        Me.SDBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SDBindingNavigatorSaveItem})
        Me.SDBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SDBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SDBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SDBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SDBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SDBindingNavigator.Name = "SDBindingNavigator"
        Me.SDBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SDBindingNavigator.Size = New System.Drawing.Size(290, 25)
        Me.SDBindingNavigator.TabIndex = 0
        Me.SDBindingNavigator.Text = "BindingNavigator1"
        Me.SDBindingNavigator.Visible = False
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
        'SDBindingNavigatorSaveItem
        '
        Me.SDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SDBindingNavigatorSaveItem.Image = CType(resources.GetObject("SDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SDBindingNavigatorSaveItem.Name = "SDBindingNavigatorSaveItem"
        Me.SDBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SDBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SympTextBox
        '
        Me.SympTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDBindingSource, "Symp", True))
        Me.SympTextBox.Location = New System.Drawing.Point(12, 49)
        Me.SympTextBox.Multiline = True
        Me.SympTextBox.Name = "SympTextBox"
        Me.SympTextBox.Size = New System.Drawing.Size(266, 42)
        Me.SympTextBox.TabIndex = 2
        '
        'DiagnosTextBox
        '
        Me.DiagnosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDBindingSource, "Diagnos", True))
        Me.DiagnosTextBox.Location = New System.Drawing.Point(15, 139)
        Me.DiagnosTextBox.Multiline = True
        Me.DiagnosTextBox.Name = "DiagnosTextBox"
        Me.DiagnosTextBox.Size = New System.Drawing.Size(263, 44)
        Me.DiagnosTextBox.TabIndex = 4
        '
        'DiagnosisBindingSource
        '
        Me.DiagnosisBindingSource.DataMember = "Diagnosis"
        Me.DiagnosisBindingSource.DataSource = Me.AziClinicDataSet
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiagnosisBindingSource, "Name", True))
        Me.NameComboBox.DataSource = Me.DiagnosisBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(15, 189)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(263, 21)
        Me.NameComboBox.TabIndex = 6
        Me.NameComboBox.ValueMember = "Name"
        '
        'SymptomsBindingSource
        '
        Me.SymptomsBindingSource.DataMember = "Symptoms"
        Me.SymptomsBindingSource.DataSource = Me.AziClinicDataSet
        '
        'NameComboBox1
        '
        Me.NameComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SymptomsBindingSource, "Name", True))
        Me.NameComboBox1.DataSource = Me.SymptomsBindingSource1
        Me.NameComboBox1.DisplayMember = "Name"
        Me.NameComboBox1.FormattingEnabled = True
        Me.NameComboBox1.Location = New System.Drawing.Point(12, 97)
        Me.NameComboBox1.Name = "NameComboBox1"
        Me.NameComboBox1.Size = New System.Drawing.Size(266, 21)
        Me.NameComboBox1.TabIndex = 8
        Me.NameComboBox1.ValueMember = "Name"
        '
        'SymptomsBindingSource1
        '
        Me.SymptomsBindingSource1.DataMember = "Symptoms"
        Me.SymptomsBindingSource1.DataSource = Me.AziClinicDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "NEW RELATION"
        '
        'SymptomDiagnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 268)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NameComboBox1)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(DiagnosLabel)
        Me.Controls.Add(Me.DiagnosTextBox)
        Me.Controls.Add(SympLabel)
        Me.Controls.Add(Me.SympTextBox)
        Me.Controls.Add(Me.SDBindingNavigator)
        Me.Name = "SymptomDiagnos"
        Me.Text = "AziClinic"
        CType(Me.AziClinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SDBindingNavigator.ResumeLayout(False)
        Me.SDBindingNavigator.PerformLayout()
        CType(Me.DiagnosisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SymptomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SymptomsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AziClinicDataSet As AziClinicDataSet
    Friend WithEvents SDBindingSource As BindingSource
    Friend WithEvents SDTableAdapter As AziClinicDataSetTableAdapters.SDTableAdapter
    Friend WithEvents TableAdapterManager As AziClinicDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SDBindingNavigator As BindingNavigator
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
    Friend WithEvents SDBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SympTextBox As TextBox
    Friend WithEvents DiagnosTextBox As TextBox
    Friend WithEvents DiagnosisTableAdapter As AziClinicDataSetTableAdapters.DiagnosisTableAdapter
    Friend WithEvents DiagnosisBindingSource As BindingSource
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents SymptomsTableAdapter As AziClinicDataSetTableAdapters.SymptomsTableAdapter
    Friend WithEvents SymptomsBindingSource As BindingSource
    Friend WithEvents NameComboBox1 As ComboBox
    Friend WithEvents SymptomsBindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
