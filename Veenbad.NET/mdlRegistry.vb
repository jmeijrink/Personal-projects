Option Strict Off
Option Explicit On
Module mdlRegistry
    Public Sub RegGetValue( _
            ByRef KeyName As String, _
            ByRef ReturnValue As String, _
            ByRef DefaultValue As String)
        Dim keyPath As String = KeyName.Substring(0, KeyName.LastIndexOf("\") + 1)
        Dim keyValue As String = KeyName.Substring(KeyName.LastIndexOf("\") + 1)

        ReturnValue = CStr(My.Computer.Registry.GetValue(keyPath, keyValue, DefaultValue))
        If (ReturnValue Is Nothing) Then ReturnValue = DefaultValue
    End Sub

    Public Function RegSetValue(ByRef KeyName As String, ByRef Value As Object) As Boolean
        Dim keyPath As String = KeyName.Substring(0, KeyName.LastIndexOf("\") + 1)
        Dim keyValue As String = KeyName.Substring(KeyName.LastIndexOf("\") + 1)

        My.Computer.Registry.SetValue(keyPath, keyValue, Value)
    End Function
End Module