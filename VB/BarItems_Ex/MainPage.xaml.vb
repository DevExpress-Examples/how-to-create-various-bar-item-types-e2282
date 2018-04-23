Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace BarItems_Ex
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			staticItemPos.Content = "Page 1/1"
			staticItemDocName.Content = "Document1.txt"
		End Sub

		Private Sub itemBold_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
			MessageBox.Show("The Bold item has been toggled")
		End Sub

	End Class
End Namespace
