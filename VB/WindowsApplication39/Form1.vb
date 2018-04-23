Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraWizard

Namespace WindowsApplication39
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			ClearWizardPageCollection(wizardControl1.Pages)
			Dim newPage As New WizardPage()
			newPage.Text = "This is new wizard page"
			wizardControl1.Pages.Add(newPage)
		End Sub

		Private Sub ClearWizardPageCollection(ByVal wizardPageCollection As WizardPageCollection)
			For i As Integer = wizardPageCollection.Count - 1 To 0 Step -1
				wizardPageCollection(i).Dispose()
			Next i
		End Sub
	End Class
End Namespace