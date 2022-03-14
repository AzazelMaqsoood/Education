Imports System.Data.SqlClient

Public Class Form1



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.cir". При необходимости она может быть перемещена или удалена.
        Me.CirTableAdapter.Fill(Me.DataSet1.cir)

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As Object,
                                     ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = String.Empty Then
            CirBindingSource.RemoveFilter()
        Else
            CirBindingSource.Filter = "Ф.И.О. like '%" +
                TextBox1.Text + "%'"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender _
                                               As System.Object, ByVal e As _
    System.EventArgs) Handles _
     ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = String.Empty Then
            CirBindingSource.RemoveFilter()
        Else
            CirBindingSource.Filter = "Категория обучения = " &
            ComboBox1.SelectedValue.ToString
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender _
                                               As System.Object, ByVal e As System.EventArgs) Handles _
                                           ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = String.Empty Then
            CirBindingSource.RemoveFilter()
        Else
            CirBindingSource.Filter = "ВУЗ= " &
                ComboBox2.SelectedValue.ToString
        End If
    End Sub

End Class
