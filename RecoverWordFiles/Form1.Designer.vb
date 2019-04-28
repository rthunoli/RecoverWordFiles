<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnRecover = New System.Windows.Forms.Button()
        Me.LstFiles = New System.Windows.Forms.ListBox()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'BtnRecover
        '
        Me.BtnRecover.Location = New System.Drawing.Point(114, 361)
        Me.BtnRecover.Name = "BtnRecover"
        Me.BtnRecover.Size = New System.Drawing.Size(75, 23)
        Me.BtnRecover.TabIndex = 0
        Me.BtnRecover.Text = "Recover"
        Me.BtnRecover.UseVisualStyleBackColor = True
        '
        'LstFiles
        '
        Me.LstFiles.FormattingEnabled = True
        Me.LstFiles.Location = New System.Drawing.Point(12, 38)
        Me.LstFiles.Name = "LstFiles"
        Me.LstFiles.Size = New System.Drawing.Size(372, 303)
        Me.LstFiles.TabIndex = 1
        '
        'TxtPath
        '
        Me.TxtPath.Location = New System.Drawing.Point(12, 12)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(335, 20)
        Me.TxtPath.TabIndex = 2
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(353, 10)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(31, 23)
        Me.BtnBrowse.TabIndex = 3
        Me.BtnBrowse.Text = "..."
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(213, 361)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 396)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.TxtPath)
        Me.Controls.Add(Me.LstFiles)
        Me.Controls.Add(Me.BtnRecover)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Word Documents Retriever"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRecover As Button
    Friend WithEvents LstFiles As ListBox
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
