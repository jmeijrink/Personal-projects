Public Class PrintCoordinator
    Public Multiplier As Decimal
    Public Offset As Integer

    Public Function Calc(ByVal relativeCoordinate As Integer) As Single
        Return CInt(relativeCoordinate * Multiplier / 2.5) + Offset
    End Function
End Class
