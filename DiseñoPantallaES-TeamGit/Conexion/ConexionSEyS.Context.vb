﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class BDSistemaEySEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=BDSistemaEySEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Administraciones() As DbSet(Of Administraciones)
    Public Overridable Property Asistencia() As DbSet(Of UserAttendance)
    Public Overridable Property Cargo() As DbSet(Of Cargo)
    Public Overridable Property Departamento() As DbSet(Of Departamento)
    Public Overridable Property Empleado() As DbSet(Of Empleado)
    Public Overridable Property Grupos() As DbSet(Of Grupos)
    Public Overridable Property Horario() As DbSet(Of Horario)
    Public Overridable Property SolVacaciones() As DbSet(Of SolVacaciones)

End Class
