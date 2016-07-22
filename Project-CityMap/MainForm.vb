Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Public Class MainForm

	Private Data As New List(Of Point)
	Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
		Using ofd = New OpenFileDialog
			If ofd.ShowDialog() = DialogResult.OK Then
				Try
					view.Image = Image.FromFile(ofd.FileName)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Using
	End Sub

	Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
		Using ofd = New OpenFileDialog
			If ofd.ShowDialog() = DialogResult.OK Then
				Data.Clear()
				Try
					Dim dx = File.ReadAllLines(ofd.FileName)
					For Each ln In dx
						Dim pt = ln.Split(","c)
						Data.Add(New Point(pt(0), pt(1)))
					Next
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Using
	End Sub

	Private Sub view_Paint(sender As Object, e As PaintEventArgs) Handles view.Paint
		Dim g = e.Graphics
		g.Clear(Color.White)
		If view.Image IsNot Nothing Then
			g.DrawImage(view.Image, 0, 0, view.Width, view.Height)
		End If
		For Each pt In Data
			g.DrawEllipse(New Pen(Color.Red, 5),
						  New RectangleF(pt.X - 10, pt.Y - 10, 20, 20))
			g.FillEllipse(Brushes.Green,
						  New RectangleF(pt.X - 5, pt.Y - 5, 10, 10))
		Next
	End Sub

	Private Sub view_MouseClick(sender As Object, e As MouseEventArgs) Handles view.MouseClick
		If e.Button = MouseButtons.Left Then
			If ptl.Value = ptl.Maximum Then
				Data.Add(e.Location)
				ptl.Maximum += 1
			Else
				Data(ptl.Value - 1) = e.Location
			End If
			ptl.Value += 1
		ElseIf e.Button = MouseButtons.Right Then
			For Each pt In Data
				If Distance(pt, e.Location) < 12.5 Then
					If Data.IndexOf(pt) < ptl.Value Then
						ptl.Value -= 1
					End If
					ptl.Maximum -= 1
					Data.Remove(pt)
					Exit For
				End If
			Next
		End If
		view.Invalidate()
	End Sub

	Private Shared Function Distance(pt1 As Point, pt2 As Point) As Double
		Dim pt = pt1 - pt2
		Return Math.Sqrt(pt.X ^ 2 + pt.Y ^ 2)
	End Function

	Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
		Using sfd = New SaveFileDialog
			If sfd.ShowDialog = DialogResult.OK Then
				Try
					Dim lst = New List(Of String)
					For Each pt In Data
						lst.Add($"{pt.X},{pt.Y}")
					Next
					File.WriteAllLines(sfd.FileName, lst)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Using
	End Sub

	Private Sub autosaver_Tick(sender As Object, e As EventArgs) Handles autosaver.Tick
		If Data.Count = 0 Then Return

		Try
			Dim lst = New List(Of String)
			For Each pt In Data
				lst.Add($"{pt.X},{pt.Y}")
			Next
			File.WriteAllLines("AutoSave-" + Now.ToString("ss-mm-HH"), lst)
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub
End Class