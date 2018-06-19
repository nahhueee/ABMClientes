Public Class Cliente
    Dim Id_ As Integer
    Dim Nombre_, Direccion_, CategoriaIVA_ As String
    Dim Saldo_ As Decimal

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value
        End Set
    End Property

    Public Property CategoriaIVA() As String
        Get
            Return CategoriaIVA_
        End Get
        Set(ByVal value As String)
            CategoriaIVA_ = value
        End Set
    End Property


    Public Property Saldo() As Decimal
        Get
            Return Saldo_
        End Get
        Set(ByVal value As Decimal)
            Saldo_ = value
        End Set
    End Property

End Class
