Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class EnterInfo

    Private Sub Table1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InvsysDB)

    End Sub


    Private Sub Table1BindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InvsysDB)

    End Sub

    Private Sub EnterInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InvsysDB.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.InvsysDB.Table1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim openfiledialog1 As New OpenFileDialog


        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"


        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then



            PictureBox1.Image = Image.FromFile(openfiledialog1.FileName)


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DBform.Show()
    End Sub
End Class