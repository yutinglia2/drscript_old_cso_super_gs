Module Module1


    Public dm As Object

    Public hwnd As Object



    Public value12, value22 As Integer


    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As UInt32) As Short




    '>>>>>>>>>>>>>>>>>>>>按鍵資料<<<<<<<<<<<<<<<<<<<<'
    Dim strKey() As String = {"None", "Enter", "Shift", "Ctrl", "Alt", "Space", "PageUp", "PageDown", "Insert", "Delete", "Home", "End", "Left", "Up", "Right", "Down", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "ESCAPE", "滑鼠中鍵", "滑鼠側鍵1", "滑鼠側鍵2"}
    Private Const WM_KEYDOWN As Integer = &H100
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>按鍵資料2<<<<<<<<<<<<<<<<<<<<'
    Dim strKey2() As String = {"None", "Enter", "Shift", "Ctrl", "Alt", "Space", "PageUp", "PageDown", "Insert", "Delete", "Home", "End", "Left", "Up", "Right", "Down", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "ESCAPE", "[", "]", ",", ".", ";", "'", "-", "="}
    Private Const WM_KEYDOWN2 As Integer = &H100
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>將所有按鍵加入至ComboBox2<<<<<<<<<<<<<<<<<<<<'
    Public Sub AddKeyItem_LA2(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        For i = 0 To strKey2.Length - 1
            cbo.Items.Add(strKey2(i))
        Next
        cbo.SelectedIndex = 0
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

End Module
