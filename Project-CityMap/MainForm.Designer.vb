<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.tools = New System.Windows.Forms.ToolStrip()
		Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
		Me.ptl = New System.Windows.Forms.TrackBar()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.view = New System.Windows.Forms.PictureBox()
		Me.autosaver = New System.Windows.Forms.Timer(Me.components)
		Me.tools.SuspendLayout()
		CType(Me.ptl, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tools
		'
		Me.tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripButton1})
		Me.tools.Location = New System.Drawing.Point(0, 0)
		Me.tools.Name = "tools"
		Me.tools.Size = New System.Drawing.Size(717, 25)
		Me.tools.TabIndex = 3
		Me.tools.Text = "ToolStrip1"
		'
		'ToolStripButton3
		'
		Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
		Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton3.Name = "ToolStripButton3"
		Me.ToolStripButton3.Size = New System.Drawing.Size(73, 22)
		Me.ToolStripButton3.Text = "Load Image"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripButton2
		'
		Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
		Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton2.Name = "ToolStripButton2"
		Me.ToolStripButton2.Size = New System.Drawing.Size(64, 22)
		Me.ToolStripButton2.Text = "Load Data"
		'
		'ToolStripButton1
		'
		Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
		Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton1.Name = "ToolStripButton1"
		Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
		Me.ToolStripButton1.Text = "Save Data"
		'
		'ptl
		'
		Me.ptl.Dock = System.Windows.Forms.DockStyle.Left
		Me.ptl.Location = New System.Drawing.Point(0, 25)
		Me.ptl.Maximum = 0
		Me.ptl.Name = "ptl"
		Me.ptl.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.ptl.Size = New System.Drawing.Size(45, 504)
		Me.ptl.TabIndex = 4
		'
		'Panel1
		'
		Me.Panel1.AutoScroll = True
		Me.Panel1.Controls.Add(Me.view)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(45, 25)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(672, 504)
		Me.Panel1.TabIndex = 5
		'
		'view
		'
		Me.view.Location = New System.Drawing.Point(0, 0)
		Me.view.Name = "view"
		Me.view.Size = New System.Drawing.Size(279, 193)
		Me.view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.view.TabIndex = 0
		Me.view.TabStop = False
		'
		'autosaver
		'
		Me.autosaver.Enabled = True
		Me.autosaver.Interval = 100000
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(717, 529)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.ptl)
		Me.Controls.Add(Me.tools)
		Me.Name = "MainForm"
		Me.Text = "Project: City Map"
		Me.tools.ResumeLayout(False)
		Me.tools.PerformLayout()
		CType(Me.ptl, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tools As Windows.Forms.ToolStrip
	Friend WithEvents ToolStripButton3 As Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripButton2 As Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripButton1 As Windows.Forms.ToolStripButton
	Friend WithEvents ptl As Windows.Forms.TrackBar
	Friend WithEvents Panel1 As Windows.Forms.Panel
	Friend WithEvents view As Windows.Forms.PictureBox
	Friend WithEvents autosaver As Windows.Forms.Timer
End Class
