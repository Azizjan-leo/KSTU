Public Class NewSymptom
    Private Sub SymptomsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SymptomsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SymptomsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AziClinicDataSet)

    End Sub

    Private Sub NewSymptom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AziClinicDataSet.Symptoms' table. You can move, or remove it, as needed.
        Me.SymptomsTableAdapter.Fill(Me.AziClinicDataSet.Symptoms)
        SymptomsBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.SymptomsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AziClinicDataSet)
        Symptoms.SymptomsTableAdapter.Fill(Me.AziClinicDataSet.Symptoms)
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NameTextBox.Text = ""
        DesriptionTextBox.Text = ""
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NameTextBox.Text = ""
        DesriptionTextBox.Text = ""
    End Sub

End Class