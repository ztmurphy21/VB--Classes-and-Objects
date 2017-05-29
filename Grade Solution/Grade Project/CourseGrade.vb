' Name:         CourseGrade.vb
' Programmer:   Zach Murphy on 5-29-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class CourseGrade
    Private _intScore1 As Integer
    Private _intScore2 As Integer
    Private _strGrade As String

    Public Property Score1 As Integer
        Get
            Return _intScore1
        End Get
        Set(value As Integer)
            _intScore1 = value
        End Set
    End Property

    Public Property Score2 As Integer
        Get
            Return _intScore2
        End Get
        Set(value As Integer)
            _intScore2 = value
        End Set
    End Property

    Public ReadOnly Property Grade As String
        Get
            Return _strGrade
        End Get
    End Property

    Public Sub New()
        _intScore1 = 0
        _intScore2 = 0
        _strGrade = String.Empty
    End Sub

    'assign appropriate grade to _strGrade vartiable
    Public Sub DetermineGrade()
        Select Case _intScore1 + _intScore2
            Case Is >= 180
                _strGrade = "A"
            Case Is >= 160
                _strGrade = "B"
            Case Is >= 140
                _strGrade = "C"
            Case Is >= 120
                _strGrade = "D"
            Case Else
                _strGrade = "F"
        End Select
    End Sub
End Class
