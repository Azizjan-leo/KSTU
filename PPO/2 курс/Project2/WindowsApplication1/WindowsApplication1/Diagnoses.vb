Public Class Diagnoses
    Private Sub Diagnoses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AziClinicDataSet.Diagnosis' table. You can move, or remove it, as needed.
        Me.DiagnosisTableAdapter.Fill(Me.AziClinicDataSet.Diagnosis)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DiagnosisBindingSource.Filter = "Name='" & TextBox1.Text & "'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NewDiagnosis.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DiagnosisBindingSource.Filter = ""
        Me.DiagnosisTableAdapter.Fill(Me.AziClinicDataSet.Diagnosis)
    End Sub
End Class