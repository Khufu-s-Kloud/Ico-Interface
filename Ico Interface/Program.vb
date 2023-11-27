Imports System

Module Program
#Disable Warning IDE0060 ' Remove unused parameter
    Sub Main(args As String())
#Enable Warning IDE0060 ' Remove unused parameter
        Console.Write(42)
    End Sub
    Public Class ContextMarshalException
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
                    Return EnvironmentVariableTarget.Machine

            End Select
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
        End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function

        Public Overrides Function ToString() As String
            Return MyBase.ToString()
        End Function


    End Class
End Module
