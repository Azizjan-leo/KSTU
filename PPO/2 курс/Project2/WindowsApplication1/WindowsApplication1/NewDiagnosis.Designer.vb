<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDiagnosis
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim MedicineLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewDiagnosis))
        Me.AziClinicDataSet = New WindowsApplication1.AziClinicDataSet()
        Me.DiagnosisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiagnosisTableAdapter = New WindowsApplication1.AziClinicDataSetTableAdapters.DiagnosisTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AziClinicDataSetTableAdapters.TableAdapterManager()
        Me.DiagnosisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DiagnosisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.MedicineTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        MedicineLabel = New System.Windows.Forms.Label()
        CType(Me.AziClinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiagnosisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiagnosisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DiagnosisBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(12, 9)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(45, 15)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(9, 76)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(82, 15)
        DescriptionLabel.TabIndex = 3
        DescriptionLabel.Text = "Description:"
        '
        'MedicineLabel
        '
        MedicineLabel.AutoSize = True
        MedicineLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MedicineLabel.Location = New System.Drawing.Point(9, 175)
        MedicineLabel.Name = "MedicineLabel"
        MedicineLabel.Size = New System.Drawing.Size(66, 15)
        MedicineLabel.TabIndex = 5
        MedicineLabel.Text = "Medicine:"
        '
        'AziClinicDataSet
        '
        Me.AziClinicDataSet.DataSetName = "AziClinicDataSet"
        Me.AziClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DiagnosisBindingSource
        '
        Me.DiagnosisBindingSource.DataMember = "Diagnosis"
        Me.DiagnosisBindingSource.DataSource = Me.AziClinicDataSet
        '
        'DiagnosisTableAdapter
        '
        Me.DiagnosisTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DiagnosisTableAdapter = Me.DiagnosisTableAdapter
        Me.TableAdapterManager.SDTableAdapter = Nothing
        Me.TableAdapterManager.SymptomsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AziClinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DiagnosisBindingNavigator
        '
        Me.DiagnosisBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DiagnosisBindingNavigator.BindingSource = Me.DiagnosisBindingSource
        Me.DiagnosisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DiagnosisBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DiagnosisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DiagnosisBindingNavigatorSaveItem})
        Me.DiagnosisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DiagnosisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DiagnosisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DiagnosisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DiagnosisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DiagnosisBindingNavigator.Name = "DiagnosisBindingNavigator"
        Me.DiagnosisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DiagnosisBindingNavigator.Size = New System.Drawing.Size(374, 25)
        Me.DiagnosisBindingNavigator.TabIndex = 0
        Me.DiagnosisBindingNavigator.Text = "BindingNavigator1"
        Me.DiagnosisBindingNavigator.Visible = False
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
        'DiagnosisBindingNavigatorSaveItem
        '
        Me.DiagnosisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DiagnosisBindingNavigatorSaveItem.Image = CType(resources.GetObject("DiagnosisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DiagnosisBindingNavigatorSaveItem.Name = "DiagnosisBindingNavigatorSaveItem"
        Me.DiagnosisBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DiagnosisBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiagnosisBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(12, 25)
        Me.NameTextBox.Multiline = True
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(350, 40)
        Me.NameTextBox.TabIndex = 2
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiagnosisBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(12, 92)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(350, 70)
        Me.DescriptionTextBox.TabIndex = 4
        '
        'MedicineTextBox
        '
        Me.MedicineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiagnosisBindingSource, "Medicine", True))
        Me.MedicineTextBox.Location = New System.Drawing.Point(15, 191)
        Me.MedicineTextBox.Name = "MedicineTextBox"
        Me.MedicineTextBox.Size = New System.Drawing.Size(347, 20)
        Me.MedicineTextBox.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NewDiagnosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 253)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(MedicineLabel)
        Me.Controls.Add(Me.MedicineTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.DiagnosisBindingNavigator)
        Me.Name = "NewDiagnosis"
        Me.Text = "AziClinic"
        CType(Me.AziClinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiagnosisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiagnosisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DiagnosisBindingNavigator.ResumeLayout(False)
        Me.DiagnosisBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AziClinicDataSet As AziClinicDataSet
    Friend WithEvents DiagnosisBindingSource As BindingSource
    Friend WithEvents DiagnosisTableAdapter As AziClinicDataSetTableAdapters.DiagnosisTableAdapter
    Friend WithEvents TableAdapterManager As AziClinicDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DiagnosisBindingNavigator As BindingNavigator
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
    Friend WithEvents DiagnosisBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents MedicineTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
