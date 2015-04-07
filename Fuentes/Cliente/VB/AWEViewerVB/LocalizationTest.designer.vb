<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class LocalizationTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocalizationTest))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.printButton = New System.Windows.Forms.Button
        Me.fontButton = New System.Windows.Forms.Button
        Me.colorButton = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.Controls.Add(Me.printButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.fontButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.colorButton, 0, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        '
        'printButton
        '
        resources.ApplyResources(Me.printButton, "printButton")
        Me.printButton.Name = "printButton"
        '
        'fontButton
        '
        resources.ApplyResources(Me.fontButton, "fontButton")
        Me.fontButton.Name = "fontButton"
        '
        'colorButton
        '
        resources.ApplyResources(Me.colorButton, "colorButton")
        Me.colorButton.Name = "colorButton"
        '
        'LocalizationTest
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "LocalizationTest"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents fontButton As System.Windows.Forms.Button
    Friend WithEvents colorButton As System.Windows.Forms.Button
End Class
