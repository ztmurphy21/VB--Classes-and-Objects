' Name:         Shapes.vb
' Programmer:   Zach Murphy on 5-29-2017

Option Explicit On
Option Strict On
Option Infer Off

' base class
Public Class Square
    Public Property Side As Double

    Public Sub New()
        _Side = 0
    End Sub

    Public Sub New(ByVal dblS As Double)
        Side = dblS
    End Sub

    Public Function GetArea() As Double
        ' returns the area of a square
        Return _Side ^ 2
    End Function
End Class

' derived class
Public Class Cube
    Inherits Square

    'invokes the base class's default constructor
    Public Sub New()
        MyBase.New()
    End Sub

    'invokes the base class's parameterized constructor
    Public Sub New(ByVal dblS As Double)
        MyBase.New(dblS)
    End Sub

    'indicates that the methodoverrides one in the base class
    Public Overridable Function GetArea() As Double
        Return MyBase.GetArea() * 6
    End Function
End Class