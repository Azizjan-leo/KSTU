Public Class SymptomDiagnos
    Private Sub SDBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SDBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AziClinicDataSet)

    End Sub

    Private Sub SymptomDiagnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AziClinicDataSet.Symptoms' table. You can move, or remove it, as needed.
        Me.SymptomsTableAdapter.Fill(Me.AziClinicDataSet.Symptoms)
        'TODO: This line of code loads data into the 'AziClinicDataSet.Diagnosis' table. You can move, or remove it, as needed.
        Me.DiagnosisTableAdapter.Fill(Me.AziClinicDataSet.Diagnosis)
        'TODO: This line of code loads data into the 'AziClinicDataSet.SD' table. You can move, or remove it, as needed.
        Me.SDTableAdapter.Fill(Me.AziClinicDataSet.SD)
        SDBindingSource.AddNew()

    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox.SelectedIndexChanged
        DiagnosTextBox.Text = NameComboBox.Text
    End Sub

    Private Sub NameComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox1.SelectedIndexChanged
        SympTextBox.Text = NameComboBox1.Text
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        SDBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.SDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AziClinicDataSet)
        SDBindingSource.AddNew()
    End Sub
End Class