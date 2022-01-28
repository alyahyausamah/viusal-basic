Public Class DBform

    Private Sub Table1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InvsysDB)

    End Sub

    Private Sub DBform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InvsysDB.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.InvsysDB.Table1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReportForm.Show()
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Table1BindingSource.Filter = "ProudctName LIKE '" & TextBox1.Text & "%'"

    End Sub

    Private Sub ProudctNameToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProudctNameToolStripButton.Click
        Try
            Me.Table1TableAdapter.ProudctName(Me.InvsysDB.Table1, ProudctNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class