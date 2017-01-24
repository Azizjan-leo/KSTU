Public Class Symptoms
    Private Sub Symptoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AziClinicDataSet.Symptoms' table. You can move, or remove it, as needed.
        Me.SymptomsTableAdapter.Fill(Me.AziClinicDataSet.Symptoms)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SymptomsBindingSource.Filter = "Name='" & TextBox1.Text & "'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NewSymptom.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SymptomsBindingSource.Filter = ""
        Me.SymptomsTableAdapter.Fill(Me.AziClinicDataSet.Symptoms)
    End Sub
End Class