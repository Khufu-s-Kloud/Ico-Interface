Friend Class Atom
    Public Shared Widening Operator CType(args As DiagnosticSource) As Atom
        If args Is Nothing Then
            Throw New ArgumentNullException(NameOf(args))
        End If

        Throw New NotImplementedException()
    End Operator
End Class

Namespace LanguageExt.TypeClasses
    Friend Structure Arithmetic
        Implements IArithmetic

        Private Base As Object

        Public Sub New(base As Object)
            Me.Base = base
        End Sub

        Public Overrides Function Equals(obj As Object) As Boolean Implements IArithmetic.Equals
            Return Base.Equals(obj)
        End Function

        Public Overrides Function GetHashCode() As Integer Implements IArithmetic.GetHashCode
            Return Base.GetHashCode()
        End Function

        Public Overrides Function ToString() As String Implements IArithmetic.ToString
            Return Base.ToString()
        End Function
    End Structure
End Namespace
