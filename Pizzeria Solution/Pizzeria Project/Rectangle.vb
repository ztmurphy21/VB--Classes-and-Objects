' Programmer:   Zach Murphy 5-24-2017
Option Explicit On
Option Strict On
Option Infer Off

Public Class Rectangle
    Private _intLength As Integer
    Private _intWidth As Integer

    Public Property Length As Integer
        Get
            Return _intLength
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intLength = value
            Else
                _intLength = 0
            End If
        End Set
    End Property

    Public Property Width As Integer
        Get
            Return _intWidth
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intWidth = value
            Else
                _intWidth = 0
            End If
        End Set
    End Property

    Public Sub New()
        _intLength = 0
        _intWidth = 0
    End Sub

    'calculates and returns the area
    Public Function GetArea() As Integer
       return _intLength * _intWidth
    End Function
End Class
