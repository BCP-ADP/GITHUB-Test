<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SickLeaveReport
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
        Me.sickLeaveCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.EmployeesSickLeave1 = New AWEViewerVB.EmployeesSickLeave
        Me.SuspendLayout()
        '
        'sickLeaveCrystalReportViewer
        '
        Me.sickLeaveCrystalReportViewer.ActiveViewIndex = 0
        Me.sickLeaveCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sickLeaveCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sickLeaveCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.sickLeaveCrystalReportViewer.Name = "sickLeaveCrystalReportViewer"
        Me.sickLeaveCrystalReportViewer.ReportSource = Me.EmployeesSickLeave1
        Me.sickLeaveCrystalReportViewer.Size = New System.Drawing.Size(878, 525)
        Me.sickLeaveCrystalReportViewer.TabIndex = 0
        '
        'SickLeaveReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 525)
        Me.Controls.Add(Me.sickLeaveCrystalReportViewer)
        Me.Name = "SickLeaveReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report of Average Sick Leave by Department"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sickLeaveCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents EmployeesSickLeave1 As AWEViewerVB.EmployeesSickLeave
End Class
