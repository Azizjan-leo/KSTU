Public Class AllSDRelations
    Private Sub AllSDRelations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AziClinicDataSet.SD' table. You can move, or remove it, as needed.
        Me.SDTableAdapter.Fill(Me.AziClinicDataSet.SD)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SymptomDiagnos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.SDTableAdapter.Fill(Me.AziClinicDataSet.SD)
    End Sub
End Class