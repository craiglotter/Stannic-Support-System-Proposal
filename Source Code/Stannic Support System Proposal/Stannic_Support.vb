'***********************************************************************************
' Stannic Help System Proposal - 1 March 2003
' by Craig Lotter (083 3085018)
' 
' Notes:
' This proposal for a Stannic Help/Support System is a quickly hobbled together
' application that I threw together in 2 days. Where necessary I have hard-coded and 
' hacked the thing together. However, the coding ideas behind this prototype system
' is sound and with more time can be developed in a workable system. Unfortunately,
' I was given 2 days to complete the prototype in :(
'***********************************************************************************

Public Class Stannic_Support
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents terminal As System.Windows.Forms.RichTextBox
    Friend WithEvents infopoint As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents entered As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents access As System.Windows.Forms.Label
    Friend WithEvents bentarrow As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Stannic_Support))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.terminal = New System.Windows.Forms.RichTextBox()
        Me.infopoint = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.entered = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.bentarrow = New System.Windows.Forms.PictureBox()
        Me.access = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(536, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 48)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(480, 64)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'terminal
        '
        Me.terminal.BackColor = System.Drawing.Color.Black
        Me.terminal.Cursor = System.Windows.Forms.Cursors.Default
        Me.terminal.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terminal.ForeColor = System.Drawing.Color.White
        Me.terminal.Location = New System.Drawing.Point(32, 104)
        Me.terminal.Name = "terminal"
        Me.terminal.ReadOnly = True
        Me.terminal.Size = New System.Drawing.Size(544, 288)
        Me.terminal.TabIndex = 9
        Me.terminal.Text = ""
        '
        'infopoint
        '
        Me.infopoint.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.infopoint.Cursor = System.Windows.Forms.Cursors.Default
        Me.infopoint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infopoint.ForeColor = System.Drawing.Color.Black
        Me.infopoint.Location = New System.Drawing.Point(32, 432)
        Me.infopoint.Name = "infopoint"
        Me.infopoint.ReadOnly = True
        Me.infopoint.Size = New System.Drawing.Size(720, 128)
        Me.infopoint.TabIndex = 6
        Me.infopoint.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(560, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Integrated Credit Control System"
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Contents    Index    Search    "
        '
        'entered
        '
        Me.entered.BackColor = System.Drawing.Color.Black
        Me.entered.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.entered.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entered.ForeColor = System.Drawing.Color.White
        Me.entered.Location = New System.Drawing.Point(32, 392)
        Me.entered.Name = "entered"
        Me.entered.Size = New System.Drawing.Size(544, 24)
        Me.entered.TabIndex = 1
        Me.entered.Text = ""
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(200, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Terminal "
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Bitmap)
        Me.PictureBox3.Location = New System.Drawing.Point(608, 136)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 40)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Bitmap)
        Me.PictureBox4.Location = New System.Drawing.Point(704, 136)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(56, 40)
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Bitmap)
        Me.PictureBox5.Location = New System.Drawing.Point(664, 128)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'bentarrow
        '
        Me.bentarrow.Image = CType(resources.GetObject("bentarrow.Image"), System.Drawing.Bitmap)
        Me.bentarrow.Location = New System.Drawing.Point(576, 368)
        Me.bentarrow.Name = "bentarrow"
        Me.bentarrow.Size = New System.Drawing.Size(64, 56)
        Me.bentarrow.TabIndex = 14
        Me.bentarrow.TabStop = False
        '
        'access
        '
        Me.access.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.access.ForeColor = System.Drawing.Color.Navy
        Me.access.Location = New System.Drawing.Point(584, 200)
        Me.access.Name = "access"
        Me.access.Size = New System.Drawing.Size(192, 160)
        Me.access.TabIndex = 15
        Me.access.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(624, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "  BACK   HOME   NEXT"
        '
        'Stannic_Support
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.access, Me.bentarrow, Me.PictureBox5, Me.PictureBox4, Me.PictureBox3, Me.Label3, Me.entered, Me.Label2, Me.Label1, Me.infopoint, Me.terminal, Me.PictureBox2, Me.PictureBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Stannic_Support"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stannic Support System"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' Global Variables

    ' Help file control variables
    Private filetoread As System.IO.FileStream
    Private filereader As System.IO.StreamReader
    Private stringread As String

    ' File position control variables
    Private currentterminal As Integer
    Private currentinfopoint As Integer
    Private currentaccess As Integer
    Private oldcurrentinfopoint As Integer
    Private oldcurrentaccess As Integer




    ' Handles the loading of the program
    Private Sub Stannic_Support_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Opens file that contains the help text.
        ' See the Screen_Text.txt file for format of file
        filetoread = New System.IO.FileStream("Screen_Text.txt", IO.FileMode.Open)
        filereader = New System.IO.StreamReader(filetoread, System.Text.Encoding.ASCII)

        ' Set up the first help screen on load. The full application would have some contents 
        ' page or something
        initialise()
    End Sub




    ' Handles the program close event
    Private Sub Stannic_Support_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ' Close the file that we were using
        filereader.Close()
        filetoread.Close()
    End Sub




    ' Handles the user clicking on Terminal option in the main menu
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        ' Set up the first help screen on load. The full application a separate process containing
        ' just the terminal would be launched
        initialise()
    End Sub



    ' Sets up the initial help screen
    Private Sub initialise()

        ' Initialise file position
        filetoread.Position = filetoread.Seek(0, IO.SeekOrigin.Begin)
        filereader.DiscardBufferedData()

        ' Find required text in file
        stringread = filereader.ReadLine()

        ' Locates terminal text
        If stringread = "@@@@1" Then
            stringread = filereader.ReadLine()
            terminal.Text = ""
            While Not stringread.StartsWith("++++")
                terminal.Text = terminal.Text & stringread & vbCrLf
                stringread = filereader.ReadLine()
            End While
            terminal.Text = terminal.Text.Remove(terminal.Text.Length - 1, 1)
        End If

        ' Locates infopoint text
        If stringread = "++++1" Then
            stringread = filereader.ReadLine()
            infopoint.Text = ""
            While (Not stringread.StartsWith("++++")) And (Not stringread.StartsWith("####"))
                infopoint.Text = infopoint.Text & stringread & vbCrLf
                stringread = filereader.ReadLine()
            End While
            infopoint.Text = infopoint.Text.Remove(infopoint.Text.Length - 1, 1)
            If infopoint.Text.StartsWith("_") Then
                infopoint.Text = ""
            End If
        End If

        ' Locates access text
        While Not stringread = "EOF"
            If stringread = "####1" Then
                stringread = filereader.ReadLine()
                access.Text = ""
                While (Not stringread.StartsWith("####")) And (Not stringread.StartsWith("@@@@")) And (Not stringread = "EOF") And (Not stringread.StartsWith("++++"))
                    access.Text = access.Text & stringread & vbCrLf
                    stringread = filereader.ReadLine()
                End While
                access.Text = access.Text.Remove(access.Text.Length - 1, 1)
                If access.Text.StartsWith("_") Then
                    access.Text = ""
                    bentarrow.Visible = False
                Else
                    bentarrow.Visible = True
                End If
                Exit While
            End If
            stringread = filereader.ReadLine()
        End While

        ' Set control variables
        currentterminal = 1
        currentinfopoint = 1
        currentaccess = 1
        oldcurrentinfopoint = 1
        oldcurrentaccess = 1
        entered.Text = ""

    End Sub

    ' Sets the help to display a change in terminal screen info
    Private Sub initialise(ByVal id As Integer)

        ' Locates terminal text
        If stringread = "@@@@" & id.ToString Then
            stringread = filereader.ReadLine()
            terminal.Text = ""
            While Not stringread.StartsWith("++++")
                terminal.Text = terminal.Text & stringread & vbCrLf
                stringread = filereader.ReadLine()
            End While
            terminal.Text = terminal.Text.Remove(terminal.Text.Length - 1, 1)
        End If

        ' Locates infopoint text
        If stringread = "++++1" Then
            stringread = filereader.ReadLine()
            infopoint.Text = ""
            While (Not stringread.StartsWith("++++")) And (Not stringread.StartsWith("####"))
                infopoint.Text = infopoint.Text & stringread & vbCrLf
                stringread = filereader.ReadLine()
            End While
            infopoint.Text = infopoint.Text.Remove(infopoint.Text.Length - 1, 1)
            If infopoint.Text.StartsWith("_") Then
                infopoint.Text = ""
            End If
        End If

        ' Locates access text
        While Not stringread = "EOF"

            If stringread = "####1" Then
                stringread = filereader.ReadLine()
                access.Text = ""
                While (Not stringread.StartsWith("####")) And (Not stringread.StartsWith("@@@@")) And (Not stringread = "EOF") And (Not stringread.StartsWith("++++"))

                    access.Text = access.Text & stringread & vbCrLf
                    stringread = filereader.ReadLine()
                End While
                access.Text = access.Text.Remove(access.Text.Length - 1, 1)
                If access.Text.StartsWith("_") Then
                    access.Text = ""
                    bentarrow.Visible = False
                Else
                    bentarrow.Visible = True
                End If
                Exit While
            End If
            stringread = filereader.ReadLine()
        End While

        ' Sets control variables
        currentterminal = id
        currentinfopoint = 1
        currentaccess = 1
        entered.Text = ""

    End Sub




    ' Handles the user moving to the previous help screen
    Private Sub MovePrevious()

        ' Resets file position
        filetoread.Position = filetoread.Seek(0, IO.SeekOrigin.Begin)
        filereader.DiscardBufferedData()
        stringread = filereader.ReadLine()
        Dim flag As Boolean = False

        ' Hard-coded hack. Would have procedures to find this out upon load
        Dim maxinfopoint(3) As Integer
        maxinfopoint(0) = 1
        maxinfopoint(1) = 1
        maxinfopoint(2) = 13
        Dim maxaccess(3) As Integer
        maxaccess(0) = 4
        maxaccess(1) = 1
        maxaccess(2) = 1

        ' Sets the control variables
        If currentaccess > 1 And flag = False Then
            currentaccess = currentaccess - 1
            flag = True
        End If

        If currentinfopoint > 1 And flag = False Then
            currentinfopoint = currentinfopoint - 1
            currentaccess = 1
            flag = True
        End If

        If currentterminal > 1 And flag = False Then
            currentterminal = currentterminal - 1
            oldcurrentinfopoint = maxinfopoint(currentterminal - 1)
            oldcurrentaccess = maxaccess(currentterminal - 1)
            currentinfopoint = oldcurrentinfopoint
            currentaccess = oldcurrentaccess
            flag = True
        End If

        ' Sets loop control variables
        Dim flagread As Boolean = False
        Dim lastreadterminal As Integer
        Dim lastreadinfopoint As Integer
        Dim lastreadaccess As Integer

        While Not stringread = "EOF"
            flagread = False

            ' Retrieve numbers to compare against control variables
            If stringread.StartsWith("@@@@") Then
                lastreadterminal = Val(stringread.Remove(0, 4))
            End If

            If stringread.StartsWith("++++") Then
                lastreadinfopoint = Val(stringread.Remove(0, 4))
            End If
            If stringread.StartsWith("####") Then
                lastreadaccess = Val(stringread.Remove(0, 4))
            End If

            ' Locates terminal screen text
            If stringread = "@@@@" & currentterminal.ToString And flagread = False Then
                stringread = filereader.ReadLine()
                terminal.Text = ""
                While Not stringread.StartsWith("++++")
                    terminal.Text = terminal.Text & stringread & vbCrLf
                    stringread = filereader.ReadLine()
                End While
                terminal.Text = terminal.Text.Remove(terminal.Text.Length - 1, 1)
                flagread = True
            End If

            ' Locates infopoint screen text
            If stringread = "++++" & currentinfopoint.ToString And flagread = False And currentterminal = lastreadterminal Then 'And currentaccess = lastreadaccess And currentinfopoint = lastreadinfopoint Then
                stringread = filereader.ReadLine()
                infopoint.Text = ""
                While (Not stringread.StartsWith("++++")) And (Not stringread.StartsWith("####"))
                    infopoint.Text = infopoint.Text & stringread & vbCrLf
                    stringread = filereader.ReadLine()
                End While
                infopoint.Text = infopoint.Text.Remove(infopoint.Text.Length - 1, 1)
                If infopoint.Text.StartsWith("_") Then
                    infopoint.Text = ""
                End If
                flagread = True
            End If

            ' Locates access screen text
            If stringread = "####" & currentaccess.ToString And flagread = False And currentaccess = lastreadaccess And currentinfopoint = lastreadinfopoint And currentterminal = lastreadterminal Then
                stringread = filereader.ReadLine()
                access.Text = ""
                While (Not stringread.StartsWith("####")) And (Not stringread.StartsWith("@@@@")) And (Not stringread = "EOF") And (Not stringread.StartsWith("++++"))
                    access.Text = access.Text & stringread & vbCrLf
                    stringread = filereader.ReadLine()
                End While
                access.Text = access.Text.Remove(access.Text.Length - 1, 1)
                If access.Text.StartsWith("_") Then
                    access.Text = ""
                    bentarrow.Visible = False
                Else
                    bentarrow.Visible = True
                End If
                flagread = True
                Exit Sub

            End If

            entered.Text = ""
            If flagread = False Then
                stringread = filereader.ReadLine()
            End If
        End While

    End Sub




    ' Handles the user moving to the next help screen
    Private Sub MoveNext()

        entered.Text = ""

        ' Checks that the last help text isn't currently being displayed
        If stringread = "EOF" Then
            If MsgBox("You have reached the end of this Support file. Click OK to go to the beginning of the help system, or Cancel to stay at the current screen.", MsgBoxStyle.OKCancel, "Stannic Support System") = MsgBoxResult.OK Then
                initialise()
            End If
            Exit Sub
        End If

        ' Sees if there exists a new infopoint screen to load from the current terminal screen
        If stringread.StartsWith("++++" & ((currentinfopoint + 1).ToString)) Then
            stringread = filereader.ReadLine()
            infopoint.Text = ""
            While (Not stringread.StartsWith("++++")) And (Not stringread.StartsWith("####"))
                infopoint.Text = infopoint.Text & stringread & vbCrLf
                stringread = filereader.ReadLine()
            End While
            infopoint.Text = infopoint.Text.Remove(infopoint.Text.Length - 1, 1)
            If infopoint.Text.StartsWith("_") Then
                infopoint.Text = ""
            End If
            oldcurrentinfopoint = currentinfopoint
            currentinfopoint = currentinfopoint + 1
            currentaccess = 1
        End If

        ' Sees if there exists a new access screen to load from the current terminal screen
        While Not stringread = "EOF"
            If stringread = "####" & ((currentaccess + 1).ToString) Then
                stringread = filereader.ReadLine()
                access.Text = ""
                While (Not stringread.StartsWith("####")) And (Not stringread.StartsWith("@@@@")) And (Not stringread = "EOF") And (Not stringread.StartsWith("++++"))
                    access.Text = access.Text & stringread & vbCrLf
                    stringread = filereader.ReadLine()
                End While
                access.Text = access.Text.Remove(access.Text.Length - 1, 1)
                If access.Text.StartsWith("_") Then
                    access.Text = ""
                    bentarrow.Visible = False
                Else
                    bentarrow.Visible = True
                End If
                oldcurrentaccess = currentaccess
                currentaccess = currentaccess + 1
                Exit While
            End If

            ' If a new terminal screen is to be displayed, then initialise it
            If stringread = "@@@@" & ((currentterminal + 1).ToString) Then
                oldcurrentinfopoint = currentinfopoint
                oldcurrentaccess = currentaccess
                initialise(currentterminal + 1)
                Exit While
            End If

            ' Find infopoint text
            If stringread.StartsWith("++++") Then
                Exit While
            End If

            ' Find access text
            If stringread = "####" & ((currentaccess).ToString) Then
                stringread = filereader.ReadLine()
                access.Text = ""
                While (Not stringread.StartsWith("####")) And (Not stringread.StartsWith("@@@@")) And (Not stringread = "EOF") And (Not stringread.StartsWith("++++"))
                    access.Text = access.Text & stringread & vbCrLf
                    stringread = filereader.ReadLine()
                End While
                access.Text = access.Text.Remove(access.Text.Length - 1, 1)
                If access.Text.StartsWith("_") Then
                    access.Text = ""
                    bentarrow.Visible = False
                Else
                    bentarrow.Visible = True
                End If
                oldcurrentaccess = currentaccess
                currentaccess = currentaccess
                Exit While
            End If
            stringread = filereader.ReadLine()
        End While

    End Sub




    ' Handles user clicking on the right arrow icon
    Private Sub Right_Arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        MoveNext()
    End Sub




    ' Handles user clicking on the house icon
    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        initialise()
    End Sub




    ' Handles user clicking on the left arrow icon
    Private Sub Left_Arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        MovePrevious()
    End Sub




    ' Terminal Keypress Handler
    Private Sub entered_keydown(ByVal sender As System.Object, ByVal keyselected As System.Windows.Forms.KeyEventArgs) Handles entered.KeyDown
        ' This function is hard-coded. In the application, each terminal screens key-mappings
        ' would be found in the config file

        ' Delete text
        If keyselected.KeyCode = Keys.Back Or keyselected.KeyCode = Keys.Delete Then
            entered.Text = ""
            keyselected.Handled = True
            Exit Sub
        End If

        ' Terminal Screen 1's bindings
        If keyselected.KeyCode = Keys.Enter And keyselected.KeyData = Keys.Enter And currentterminal = 1 Then
            If entered.Text <> Nothing Then
                If (Not entered.Text.Equals("333")) And currentaccess = 1 Then
                    If MsgBox("The Bank Code you have entered would not be accepted on the live system. Click OK to proceed anyway, or Cancel to re-enter the bank code.", MsgBoxStyle.OKCancel, "Stannic Support System") = MsgBoxResult.OK Then
                        MoveNext()
                    Else
                        entered.Text = ""
                    End If
                    keyselected.Handled = True
                    Exit Sub
                End If
                If (entered.Text.Equals("333")) And currentaccess = 1 Then
                    MoveNext()
                    keyselected.Handled = True
                    Exit Sub
                End If
                If (Not IsNumeric(entered.Text)) And currentaccess = 2 Then
                    If MsgBox("The Department Code you have entered would not be accepted on the live system as it contains letters. Click OK to proceed anyway, or Cancel to re-enter the department code.", MsgBoxStyle.OKCancel, "Stannic Support System") = MsgBoxResult.OK Then
                        MoveNext()
                    Else
                        entered.Text = ""
                    End If
                    keyselected.Handled = True
                    Exit Sub
                End If
                If (IsNumeric(entered.Text)) And currentaccess = 2 Then
                    MoveNext()
                    keyselected.Handled = True
                    Exit Sub
                End If
                If (Not IsNumeric(entered.Text)) And currentaccess = 3 Then
                    If MsgBox("The Adjustor Code you have entered would not be accepted on the live system as it contains letters. Click OK to proceed anyway, or Cancel to re-enter the adjustor code.", MsgBoxStyle.OKCancel, "Stannic Support System") = MsgBoxResult.OK Then
                        MoveNext()
                    Else
                        entered.Text = ""
                    End If
                    keyselected.Handled = True
                    Exit Sub
                End If
                If (IsNumeric(entered.Text)) And currentaccess = 3 Then
                    MoveNext()
                    keyselected.Handled = True
                    Exit Sub
                End If
                If currentaccess = 4 Then
                    MoveNext()
                    keyselected.Handled = True
                    Exit Sub
                End If
            End If
        End If

        ' Terminal Screen 2's bindings
        If (keyselected.KeyCode = Keys.F1 Or keyselected.KeyCode = Keys.F6) And currentterminal = 2 Then
            MsgBox("Unfortunately, the requested action has not been included in this prototype system.", MsgBoxStyle.OKOnly)
            keyselected.Handled = True
            Exit Sub
        End If
        If keyselected.KeyCode = Keys.F11 And currentterminal = 2 Then
            MoveNext()
            keyselected.Handled = True
            Exit Sub
        End If

        If keyselected.KeyCode = Keys.F3 And currentterminal = 2 Then
            initialise()
            keyselected.Handled = True
            Exit Sub
        End If

        ' Terminal Screen 3's bindings
        If keyselected.KeyCode = Keys.F1 And currentterminal = 3 Then
            MsgBox("Unfortunately, the requested action has not been included in this prototype system.", MsgBoxStyle.OKOnly)
            keyselected.Handled = True
            Exit Sub
        End If
        If keyselected.KeyCode = Keys.F3 And currentterminal = 3 Then
            initialise()
            keyselected.Handled = True
            Exit Sub
        End If

        If (keyselected.KeyCode = Keys.F2 Or keyselected.KeyCode = Keys.F12) And currentterminal = 3 Then
            MovePrevious()
            keyselected.Handled = True
            Exit Sub
        End If
        If keyselected.KeyCode = Keys.Enter And currentterminal = 3 Then
            If entered.Text <> Nothing Then
                If entered.Text.Equals("1") Or entered.Text.Equals("2") Or entered.Text.Equals("3") Or entered.Text.Equals("4") Or entered.Text.Equals("5") Or entered.Text.Equals("6") Or entered.Text.Equals("7") Or entered.Text.Equals("8") Or entered.Text.Equals("9") Or entered.Text.Equals("10") Or entered.Text.Equals("11") Then
                    MsgBox("Unfortunately, the requested action has not been included in this prototype system.", MsgBoxStyle.OKOnly)
                    keyselected.Handled = True
                    Exit Sub
                Else
                    MsgBox("Invalid Selection.", MsgBoxStyle.OKOnly)
                    entered.Text = ""
                    keyselected.Handled = True
                    Exit Sub
                End If
            End If
        End If

        keyselected.Handled = True
    End Sub




End Class
