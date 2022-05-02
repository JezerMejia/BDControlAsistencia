Imports System.Math
Imports System.Drawing.Drawing2D
Imports System.Drawing.Graphics

Public Class Clock
    Public Function BuildAnalogClock(ByVal mypbx As PictureBox) As Integer

        mypbx.Refresh()
        'draw dots
        Dim CX, CY, EX, EY As Integer
        Dim G As Graphics = mypbx.CreateGraphics
        G.SmoothingMode = Drawing2D.SmoothingMode.Default
        Dim nFont As New Font("Arial", 35, FontStyle.Regular, GraphicsUnit.Pixel)
        Dim nBrush As Brush = Brushes.Black
        Const RADIUS As Integer = 45
        CX = CInt(mypbx.Width / 2 - 12)
        CY = CInt(mypbx.Height / 2 - 30)
        Dim myDot As String = "."
        For i = 30 To 360 Step 30
            EX = CInt(CX - Round(RADIUS * Sin(i * PI / 180)))
            EY = CInt(CY - Round(RADIUS * Cos(i * PI / 180)))
            G.DrawString(myDot, nFont, nBrush, EX, EY)
        Next

        'draw hands

        CX = CInt(mypbx.Width / 2) : CY = CInt(mypbx.Height / 2)
        Dim NewRadius As Integer = RADIUS - 15
        Dim HourPen As New Pen(Color.BlueViolet, 4)
        Dim cTime As DateTime = Now()
        EX = CInt(CX + Round(NewRadius * Sin((cTime.Hour * 30 + cTime.Minute / 2) * PI / 180)))
        EY = CInt(CY - Round(NewRadius * Cos((cTime.Hour * 30 + cTime.Minute / 2) * PI / 180)))
        G.DrawLine(HourPen, CX, CY, EX, EY)

        'draw minute

        NewRadius = RADIUS - 6
        Dim MinPen As New Pen(Color.Crimson, 2)
        EX = CInt(CX + Round(NewRadius * Sin(cTime.Minute * 6 * PI / 180)))
        EY = CInt(CY - Round(NewRadius * Cos(cTime.Minute * 6 * PI / 180)))
        G.DrawLine(MinPen, CX, CY, EX, EY)

        'draw second

        NewRadius = RADIUS
        Dim SecondPen As New Pen(Color.OrangeRed, 1)
        EX = CInt(CX + Round(NewRadius * Sin(cTime.Second * 6 * PI / 180)))
        EY = CInt(CY - Round(NewRadius * Cos(cTime.Second * 6 * PI / 180)))
        G.DrawLine(SecondPen, CX, CY, EX, EY)

        'Circle at the center
        Dim CirPen As New Pen(Color.CornflowerBlue, 5)
        G.DrawEllipse(CirPen, CX - 5, CY - 4, 8, 8)

    End Function
End Class
