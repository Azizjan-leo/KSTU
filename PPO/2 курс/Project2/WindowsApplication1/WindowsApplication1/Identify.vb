Public Class Identify
    Dim MultiFilter As Boolean = False
    Dim SourceFilter As SourceFilter
    Dim FilterString As String = "Symp='"
    Private Sub SymptomsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SymptomsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SymptomsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AziClinicDataSet)

    End Sub

    Private Sub Identify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AziClinicDataSet.SD' table. You can move, or remove it, as needed.
        Me.SDTableAdapter.Fill(Me.AziClinicDataSet.SD)
        'TODO: This line of code loads data into the 'AziClinicDataSet.Symptoms' table. You can move, or remove it, as needed.
        Me.SymptomsTableAdapter.Fill(Me.AziClinicDataSet.Symptoms)

    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox.SelectedIndexChanged

        If MultiFilter = False Then
            FilterString = FilterString & NameComboBox.Text & "'"
            MultiFilter = True
        Else
            FilterString = FilterString & " Or Symp='" & NameComboBox.Text & "'"
        End If
        SDBindingSource.Filter = FilterString
        TextBox1.Text = AziClinicDataSet.SD.Rows.Count
        'TextBox1.Text = DataGridView1.Rows.GetRowCount(where) - 1
    End Sub

End Class