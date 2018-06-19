
Imports System.ComponentModel
Public Class ClienteCollection
    Inherits BindingList(Of Cliente)
    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New Cliente()
    End Sub
End Class
