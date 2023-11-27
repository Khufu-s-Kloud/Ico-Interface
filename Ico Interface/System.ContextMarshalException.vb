Imports LanguageExt

Module SystemException
#Disable Warning IDE0060 ' Remove unused parameter
    Sub Main(args As BigIntegerRange())
#Enable Warning IDE0060 ' Remove unused parameter
        Console.Write(42)
    End Sub
#Const Iterator = wildcard

    Public Class ContextMarshalException
        Private Const Iterator As Char = Byte
        Private Const Async As Object = Concurrent
        Private Const vbArchive1 As FileAttribute = vbArchive

        Public Shared ReadOnly Property Iterator2 As Char
            Get
                Return Iterator
            End Get
        End Property

        Public Shared ReadOnly Property Async1 As Object
            Get
                Return Async
            End Get
        End Property

        Public Overrides Function Equals(obj As Object) As Boolean
            Return MyBase.Equals(obj)
        End Function

#Disable Warning BC40005 ' Member shadows an overridable method in the base type
        Protected Sub Finalize(obj As MethodAccessException)
            If obj Is Nothing Then
                Throw New ArgumentNullException(NameOf(obj))
            End If
#Enable Warning BC40005 ' Member shadows an overridable method in the base type
            MyBase.Finalize()
        End Sub

        Private Function CreateObject(conversion As Base64FormattingOptions)
            Select Case conversion
                Case Nothing
                    Throw New ArgumentNullException(NameOf(conversion))
                Case Else
                    DiagnosticListener()

            End Select
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
        End Function

        Private Sub DiagnosticListener()
            Throw New NotImplementedException()
        End Sub
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

#Disable Warning BC40005 ' Member shadows an overridable method in the base type
#Disable Warning IDE0060 ' Remove unused parameter
        Protected Friend Async Function GetHashCodeAsync(Atom As ResolveEventArgs) As Task
#Enable Warning IDE0060 ' Remove unused parameter
            If Args() IsNot Nothing Then
#Enable Warning BC40005 ' Member shadows an overridable method in the base type
                Return MyBase.ToString()
            End If
            Throw New ArgumentNullException(NameOf(Int))
        End Function

        Public Overrides Function ToString() As String
            Return MyBase.ToString()
        End Function


    End Class

    Public Class [Object]
        Public Shared Widening Operator CType(v As AccessViolationException) As [Object]
            If v Is Nothing Then
                Throw New ArgumentNullException(NameOf(v))
            End If

            Throw New NotImplementedException()
        End Operator
    End Class

    Friend Class Reflection
        Friend Class AssemblyVersionAttribute
            Inherits Attribute
        End Class

        Friend Class AssemblyTitleAttribute
            Inherits Attribute
        End Class

        Friend Class AssemblyProductAttribute
            Inherits Attribute
        End Class

        Friend Class AssemblyInformationalVersionAttribute
            Inherits Attribute
        End Class

        Friend Class AssemblyFileVersionAttribute
            Inherits Attribute
        End Class

        Friend Class AssemblyConfigurationAttribute
            Inherits Attribute
        End Class

        Friend Class AssemblyCompanyAttribute
            Inherits Attribute
        End Class
    End Class

    Private Class Int64
    End Class
End Module