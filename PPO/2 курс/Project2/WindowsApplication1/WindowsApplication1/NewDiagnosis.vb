Public Class NewDiagnosis
    Private Sub DiagnosisBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DiagnosisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DiagnosisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AziClinicDataSet)
    End Sub

    Private Sub NewDiagnosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AziClinicDataSet.Diagnosis' table. You can move, or remove it, as needed.
        Me.DiagnosisTableAdapter.Fill(Me.AziClinicDataSet.Diagnosis)
        DiagnosisBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.DiagnosisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AziClinicDataSet)
        Diagnoses.DiagnosisTableAdapter.Fill(Me.AziClinicDataSet.Diagnosis)
        Me.Close()
    End Sub
End Class