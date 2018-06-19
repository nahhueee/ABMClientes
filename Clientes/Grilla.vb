Public Class Grilla
    Private Sub llenarform()
        ClienteForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ClienteForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ClienteForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ClienteForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        ClienteForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        ClienteForm.operacion = "nuevo"
        ClienteForm.Text = "Nuevo Cliente"
        ClienteForm.Show()
    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click
        If lst.Count = 0 Then Exit Sub

        ClienteForm.operacion = "elimina"
        ClienteForm.Text = "Eliminar Cliente"
        ClienteForm.indice = DataGridView1.CurrentRow.Index
        Llenarform()
        ClienteForm.Show()
    End Sub

    Private Sub modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificar.Click
        If lst.Count = 0 Then Exit Sub

        ClienteForm.operacion = "modifica"
        ClienteForm.Text = "Modificar Cliente"
        ClienteForm.indice = DataGridView1.CurrentRow.Index
        llenarform()
        ClienteForm.Show()
    End Sub

    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        Me.Close()
    End Sub

    Private Sub Grilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst
    End Sub

End Class
