Imports System.Threading
Public Class ASD

    Private Declare Sub ReleaseCapture Lib "user32" ()

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    Dim addr = "<hw.dll>+2D9C594"

    '/////////////////////////////////載入主界面時做的事////////////////////////////////////
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '/////////////////////注冊大漠插件/////////////////////////
        Dim app As String
        app = Application.StartupPath
        Shell("regsvr32 /s " & app & "\1.dll")
        '//////////////////////////////////////////////////////////

        Me.TopMost = True


        Dim name1 = Process.GetCurrentProcess().MainModule.FileName

        Dim rndNum1234 As New Random()

        Rename(name1, rndNum1234.Next(50, 99) * rndNum1234.Next(50, 99) & ".exe")

        '/////////////////////檢查大漠插件是否正常注冊/////////////////////////
        Try
            '要執行的動作 
            dm = CreateObject("dm.dmsoft")
        Catch exx As Exception
            'Catch ex As System.Net.WebException
            '擷取錯誤並顯示 
            MsgBox("錯誤訊息 ： 自動註冊DLL失敗 " & vbCrLf & "請確保壓縮檔完整解壓在同一資料夾 和資料夾名稱沒有空格",, "Error")
            Shell("regsvr32 /u /s " & app & "\1.dll")
            End
        End Try
        '/////////////////////注冊大漠插件/////////////////////////


        '///////////////////檢查大漠插件是否正常調用/////////////////////
        Dim ver
        dm = CreateObject("dm.dmsoft")
        ver = dm.ver()
        If ver = 0 Then
            MsgBox("当前大漠插件未能正常调用")
        Else

        End If
        '//////////////////////////////////////////////////////////////////


        '///////////////////檢查更新/////////////////////

        '//////////////////////////////////////////////////

        Dim RandomText As Integer
        Randomize()
        RandomText = int((Rnd() * 999999999))
        Me.Text = Str(RandomText)
        dm = CreateObject("dm.dmsoft")
        hwnd = dm.FindWindow("", "Counter-Strike Online")
        dm.SetKeypadDelay("normal", 0)
        dm.SetKeypadDelay("windows", 0)
        dm.SetKeypadDelay("dx", 0)


        ' 	退出登录(LogOut) url

        '////////////////////找cso視窗////////////////////////////
        If hwnd = 0 Then

            MsgBox("CSO未開啟 !!")
            MsgBox("程式關閉 反注冊DLL完成",, "反注冊DLL")
            Shell("regsvr32 /u /s " & app & "\1.dll")
            End

        End If
        '/////////////////////////////////////////////////////////////


        '////////////////////////初始化////////////////////////

        dm.SetPath(Application.StartupPath)


        checkgame.Enabled = True

        Me.Enabled = True

        dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)

        Me.TopMost = False

        Me.CenterToScreen()

        Show()

        dm.SetWindowState(hwnd, 5)


        '////////////////////////////////////////////////////////////

        Thread1.Start()

    End Sub
    '/////////////////////////////////////////////////////////////////////////

    Dim rndNum12345 As New Random()



    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing


        dm.SetWindowState(hwnd, 9)
        dm.SetWindowState(hwnd, 2)
        dm.SetWindowState(hwnd, 9)
        dm.UnBindWindow()

        Me.TopMost = True

        Dim app As String
        app = Application.StartupPath
        Shell("regsvr32 /u /s " & app & "\1.dll")

        Me.Hide()

        'MsgBox("本次運作時間 : " & runtimeh & "時" & runtimem & "分" & runtime & "秒")

        End

    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////RandomText//////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub RandomText_Tick(sender As Object, e As EventArgs) Handles RandomText.Tick
        Dim RandomText As Integer
        Randomize()
        RandomText = int((Rnd() * 99))

        Dim sText As String
        '取得亂數字串 
        sText = RandonStr("A1a1A1a1")
        'MsgBox(sText)
        'Me.Text = Str(RandomText)
        Me.Text = (RandomText & sText)
    End Sub

    Private Function RandonInt(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim iRnd As Integer

        Randomize()
        iRnd = CInt(int((Max - Min + 1) * Rnd()))
        Return iRnd + Min
    End Function

    ''' <summary> 
    ''' 取得亂數字串。 
    ''' </summary> 
    ''' <param name="Format">字串格式化。A: 表示大寫英文字母; a: 表示小寫英文字母; 1: 表示數字。</param> 
    Private Function RandonStr(ByVal Format As String) As String
        Dim N1 As Integer
        Dim sText As String
        Dim sChar As String
        Dim iCharCode As Integer

        sText = String.Empty
        For N1 = 0 To Format.Length - 1
            sChar = Format.Substring(N1, 1)
            If sChar = "A" Then
                'A-Z 的 ASCII 是 65-90 
                iCharCode = RandonInt(65, 90)
            ElseIf sChar = "a" Then
                'a-z 的 ASCII 是 97-122 
                iCharCode = RandonInt(97, 122)
            ElseIf sChar = "1" Then
                '0-9 的 ASCII 是 48-57 
                iCharCode = RandonInt(48, 57)
            End If
            sText = sText + Chr(iCharCode)
        Next
        Return sText
    End Function
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////checkgame////////////////////////////////
    Private Sub checkgame_Tick(sender As Object, e As EventArgs) Handles checkgame.Tick

        hwnd = dm.FindWindow("", "Counter-Strike Online")



        If hwnd = 0 Then
            hwnd = dm.FindWindow("", "Counter-Strike Online")
            If hwnd = 0 Then
                checkgame.Enabled = False
                Me.Close()
            End If
        End If

    End Sub
    '////////////////////////////////////////////////////////////////////////////////////

    Dim Thread1 As New Thread(AddressOf aa)
    Sub aa()
aa:

        Dim value1 = dm.ReadData(hwnd, addr, 1)
        value12 = Convert.ToInt32(value1, 16)


        If GetAsyncKeyState(Keys.XButton1) <> 0 Or GetAsyncKeyState(Keys.E) Then
            dm.KeyPressChar("space")
            Threading.Thread.Sleep(5)
            dm.KeyDownChar("ctrl")
            Threading.Thread.Sleep(1)
bbc:

            Dim value3 = dm.ReadData(hwnd, addr, 1)
            value12 = Convert.ToInt32(value3, 16)

            If value12 = 1 Then
                dm.KeyUpChar("ctrl")

                dm.KeyPressChar("space")

                GoTo aa

            End If

            GoTo bbc

        End If



        If GetAsyncKeyState(Keys.XButton2) <> 0 Or GetAsyncKeyState(Keys.C) Then
            If value12 = 1 Then
                'dm.WheelDown()

                dm.KeyPressChar("ctrl")

                'dm.KeyDownChar("ctrl")
                'Threading.Thread.Sleep(10)
                'dm.KeyUpChar("ctrl")
                'Threading.Thread.Sleep(10)

bb:
                Dim value2 = dm.ReadData(hwnd, addr, 1)
                value12 = Convert.ToInt32(value2, 16)
                If value12 = 1 Then
                    Threading.Thread.Sleep(10)
                    GoTo aa
                End If
                GoTo bb
                'dm.KeyDownChar("ctrl")
            End If
            GoTo aa
        End If

        Threading.Thread.Sleep(100)
        GoTo aa

    End Sub











    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    'windows style
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MD(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = dm.ReadData(hwnd, addr, 1)
    End Sub


    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<


    'Threading.Thread.Sleep()

End Class
