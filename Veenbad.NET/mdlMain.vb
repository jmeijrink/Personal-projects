Module mdlMain
    Public Sub SetWindowProperties(ByRef fForm As System.Windows.Forms.Form)
        If (fForm.WindowState = 0) Then
            RegSetValue("HKEY_CURRENT_USER\Software\Veenbad\Vensters\" & fForm.Name & "Left", CStr(fForm.Left))
            RegSetValue("HKEY_CURRENT_USER\Software\Veenbad\Vensters\" & fForm.Name & "Top", CStr(fForm.Top))
            RegSetValue("HKEY_CURRENT_USER\Software\Veenbad\Vensters\" & fForm.Name & "Width", CStr(fForm.Width))
            RegSetValue("HKEY_CURRENT_USER\Software\Veenbad\Vensters\" & fForm.Name & "Height", CStr(fForm.Height))
        End If
        RegSetValue("HKEY_CURRENT_USER\Software\Veenbad\Vensters\" & fForm.Name & "State", CStr(fForm.WindowState))
    End Sub

    Public Sub GetWindowProperties(ByRef fForm As System.Windows.Forms.Form)
        Dim sTemp As String = String.Empty

        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Vensters\" & fForm.Name & "Left", sTemp, CStr(fForm.Left))
        Dim formLeft As Integer = CInt(sTemp)
        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Vensters\" & fForm.Name & "Top", sTemp, CStr(fForm.Top))
        Dim formTop As Integer = CInt(sTemp)
        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Vensters\" & fForm.Name & "Width", sTemp, CStr(fForm.Width))
        Dim formWidth As Integer = CInt(sTemp)
        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Vensters\" & fForm.Name & "Height", sTemp, CStr(fForm.Height))
        Dim formHeight As Integer = CInt(sTemp)
        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Vensters\" & fForm.Name & "State", sTemp, CStr(fForm.WindowState))
        fForm.WindowState = CType(CInt(sTemp), FormWindowState)

        fForm.Left = formLeft
        fForm.Top = formTop
        fForm.Width = formWidth
        fForm.Height = formHeight
    End Sub

    Public Function IIf(Of T)(ByVal expression As Boolean, ByVal trueValue As T, ByVal falseValue As T) As T
        If (expression) Then
            Return trueValue
        Else
            Return falseValue
        End If
    End Function

    Public Function EmptyStringIfNull(ByVal dr As DataRow, ByVal field As String) As String
        If (dr.IsNull(field)) Then Return String.Empty
        Return DirectCast(dr(field), String)
    End Function
End Module