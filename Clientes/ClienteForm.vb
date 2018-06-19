Public Class ClienteForm
    Dim operacion_ As String
    Dim micliente As New Cliente
    Dim indice_ As Byte

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click
        If TextBox1.Text.Length = 0 Then
            MsgBox("Debe ingresar Id")
            Exit Sub
        End If

        If TextBox2.Text.Length = 0 Then
            MsgBox("Debe ingresar Nombre y Apellido")
            Exit Sub
        End If

        If TextBox3.Text.Length = 0 Then
            MsgBox("Debe ingresar Direcciòn")
            Exit Sub
        End If

        If TextBox4.Text.Length = 0 Then
            MsgBox("Debe ingresar un Saldo")
            Exit Sub
        End If

        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Debe ingresar una categoria de Iva")
            Exit Sub
        End If

        micliente.Id = CInt(TextBox1.Text)
        micliente.Nombre = TextBox2.Text
        micliente.Direccion = TextBox3.Text
        micliente.Saldo = CDec(TextBox4.Text)
        micliente.CategoriaIVA = ComboBox1.SelectedItem

        Select Case operacion_
            Case "nuevo"
                lst.Add(micliente)
            Case "elimina"
                lst.RemoveAt(indice_)
            Case "modifica"
                lst.Item(indice_) = micliente

                Grilla.DataGridView1.Refresh()
        End Select
        Me.Close()
    End Sub

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Exit Sub
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsNumber(e.KeyChar) Then e.Handled = True
        Exit Sub
    End Sub

    
End Class
