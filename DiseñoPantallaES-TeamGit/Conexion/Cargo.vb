'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Cargo
    Public Property idCargo As Integer
    Public Property nombreCargo As String
    Public Property descripcionCargo As String

    Public Overridable Property Empleado As ICollection(Of Empleado) = New HashSet(Of Empleado)

End Class
