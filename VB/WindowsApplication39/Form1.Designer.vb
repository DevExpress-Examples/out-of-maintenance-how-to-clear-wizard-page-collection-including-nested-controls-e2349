Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication39
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.wizardControl1 = New DevExpress.XtraWizard.WizardControl()
			Me.welcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
			Me.wizardPage1 = New DevExpress.XtraWizard.WizardPage()
			Me.completionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
			CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.wizardControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' wizardControl1
			' 
			Me.wizardControl1.Controls.Add(Me.welcomeWizardPage1)
			Me.wizardControl1.Controls.Add(Me.wizardPage1)
			Me.wizardControl1.Controls.Add(Me.completionWizardPage1)
			Me.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.wizardControl1.Location = New System.Drawing.Point(0, 0)
			Me.wizardControl1.Name = "wizardControl1"
			Me.wizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() { Me.welcomeWizardPage1, Me.wizardPage1, Me.completionWizardPage1})
			Me.wizardControl1.Size = New System.Drawing.Size(686, 391)
			' 
			' welcomeWizardPage1
			' 
			Me.welcomeWizardPage1.Name = "welcomeWizardPage1"
			Me.welcomeWizardPage1.Size = New System.Drawing.Size(469, 258)
			' 
			' wizardPage1
			' 
			Me.wizardPage1.Name = "wizardPage1"
			Me.wizardPage1.Size = New System.Drawing.Size(654, 246)
			' 
			' completionWizardPage1
			' 
			Me.completionWizardPage1.Name = "completionWizardPage1"
			Me.completionWizardPage1.Size = New System.Drawing.Size(469, 258)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(686, 391)
			Me.Controls.Add(Me.wizardControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.wizardControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private wizardControl1 As DevExpress.XtraWizard.WizardControl
		Private welcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
		Private wizardPage1 As DevExpress.XtraWizard.WizardPage
		Private completionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
	End Class
End Namespace

