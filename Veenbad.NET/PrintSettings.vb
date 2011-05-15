Public Class PrintSettings
    Private _type As PrintType
    Private _multiplier As Decimal = 1
    Private _offsetX As Integer = 0
    Private _offsetY As Integer = 0

    Public Enum PrintType
        GroepLijst
        PresentieLijst
        DiplomaA
        DiplomaB
        DiplomaC
    End Enum

    Public Property DocumentType() As PrintType
        Get
            Return _type
        End Get
        Set(ByVal value As PrintType)
            _type = value
            GroupBox1.Text = _type.ToString()
        End Set
    End Property

    Public ReadOnly Property Multiplier() As Decimal
        Get
            Return _multiplier
        End Get
    End Property

    Public ReadOnly Property OffsetX() As Integer
        Get
            Return _offsetX
        End Get
    End Property

    Public ReadOnly Property OffsetY() As Integer
        Get
            Return _offsetY
        End Get
    End Property

    Public Sub ReadSettings()
        Dim textType As String = GetTypeString(Me.DocumentType)

        Dim multiplier As String = String.Empty
        Dim offsetX As String = String.Empty
        Dim offsetY As String = String.Empty

        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\" & textType & "Multiplier", multiplier, "1")
        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\" & textType & "OffsetX", offsetX, "0")
        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\" & textType & "OffsetY", offsetY, "0")

        If (Not Decimal.TryParse(multiplier, _multiplier)) Then _multiplier = 1
        Integer.TryParse(offsetX, _offsetX)
        Integer.TryParse(offsetY, _offsetY)

        txtMultiplier.Text = _multiplier.ToString()
        txtOffsetX.Text = _offsetX.ToString()
        txtOffsetY.Text = _offsetY.ToString()
    End Sub

    Public Function SaveSettings() As Boolean
        Dim textType As String = GetTypeString(Me.DocumentType)

        Dim bError As Boolean
        If Not IsNumeric(txtMultiplier.Text) Then
            bError = True
            MsgBox(Me.DocumentType.ToString() & " Multiplier moet een getal zijn.", MsgBoxStyle.Exclamation, "Fout")
        End If
        If Not IsNumeric(txtOffsetX.Text) Then
            bError = True
            MsgBox(Me.DocumentType.ToString() & " Offset X moet een getal zijn.", MsgBoxStyle.Exclamation, "Fout")
        End If
        If Not IsNumeric(txtOffsetY.Text) Then
            bError = True
            MsgBox(Me.DocumentType.ToString() & " Offset Y moet een getal zijn.", MsgBoxStyle.Exclamation, "Fout")
        End If

        If (bError) Then Return False

        RegSetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\" & textType & "Multiplier", (txtMultiplier.Text))
        RegSetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\" & textType & "OffsetX", (txtOffsetX.Text))
        RegSetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\" & textType & "OffsetY", (txtOffsetY.Text))

        Return True
    End Function

    Private Function GetTypeString(ByVal type As PrintType) As String
        Select Case type
            Case PrintType.DiplomaA
                Return "DPA"
            Case PrintType.DiplomaB
                Return "DPB"
            Case PrintType.DiplomaC
                Return "DPC"
            Case PrintType.GroepLijst
                Return "LK"
            Case PrintType.PresentieLijst
                Return "PL"
            Case Else
                Throw New Exception("Unknown print type!")
        End Select
    End Function
End Class
