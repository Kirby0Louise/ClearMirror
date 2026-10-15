<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmdLaunchGame = New System.Windows.Forms.Button()
        Me.gbGFXSettings = New System.Windows.Forms.GroupBox()
        Me.gbVSync = New System.Windows.Forms.GroupBox()
        Me.gbLevelOfDetail = New System.Windows.Forms.GroupBox()
        Me.gbVolumetricLighting = New System.Windows.Forms.GroupBox()
        Me.gbBloom = New System.Windows.Forms.GroupBox()
        Me.gbDepthOfField = New System.Windows.Forms.GroupBox()
        Me.gbShadows = New System.Windows.Forms.GroupBox()
        Me.gbSSAO = New System.Windows.Forms.GroupBox()
        Me.gbMSAA = New System.Windows.Forms.GroupBox()
        Me.gbFXAA = New System.Windows.Forms.GroupBox()
        Me.gbAdapter = New System.Windows.Forms.GroupBox()
        Me.cbGPUs = New System.Windows.Forms.ComboBox()
        Me.gbResolution = New System.Windows.Forms.GroupBox()
        Me.rb8K = New System.Windows.Forms.RadioButton()
        Me.rb4K = New System.Windows.Forms.RadioButton()
        Me.rb1440p = New System.Windows.Forms.RadioButton()
        Me.rb1080p = New System.Windows.Forms.RadioButton()
        Me.gbDisplayMode = New System.Windows.Forms.GroupBox()
        Me.rbFullscreen = New System.Windows.Forms.RadioButton()
        Me.rbBorderless = New System.Windows.Forms.RadioButton()
        Me.rbWindowed = New System.Windows.Forms.RadioButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslCASOSupport = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbGFXSettings.SuspendLayout()
        Me.gbAdapter.SuspendLayout()
        Me.gbResolution.SuspendLayout()
        Me.gbDisplayMode.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLaunchGame
        '
        Me.cmdLaunchGame.Location = New System.Drawing.Point(12, 698)
        Me.cmdLaunchGame.Name = "cmdLaunchGame"
        Me.cmdLaunchGame.Size = New System.Drawing.Size(1306, 81)
        Me.cmdLaunchGame.TabIndex = 0
        Me.cmdLaunchGame.Text = "START GAME"
        Me.cmdLaunchGame.UseVisualStyleBackColor = True
        '
        'gbGFXSettings
        '
        Me.gbGFXSettings.Controls.Add(Me.gbVSync)
        Me.gbGFXSettings.Controls.Add(Me.gbLevelOfDetail)
        Me.gbGFXSettings.Controls.Add(Me.gbVolumetricLighting)
        Me.gbGFXSettings.Controls.Add(Me.gbBloom)
        Me.gbGFXSettings.Controls.Add(Me.gbDepthOfField)
        Me.gbGFXSettings.Controls.Add(Me.gbShadows)
        Me.gbGFXSettings.Controls.Add(Me.gbSSAO)
        Me.gbGFXSettings.Controls.Add(Me.gbMSAA)
        Me.gbGFXSettings.Controls.Add(Me.gbFXAA)
        Me.gbGFXSettings.Controls.Add(Me.gbAdapter)
        Me.gbGFXSettings.Controls.Add(Me.gbResolution)
        Me.gbGFXSettings.Controls.Add(Me.gbDisplayMode)
        Me.gbGFXSettings.Location = New System.Drawing.Point(12, 12)
        Me.gbGFXSettings.Name = "gbGFXSettings"
        Me.gbGFXSettings.Size = New System.Drawing.Size(1306, 680)
        Me.gbGFXSettings.TabIndex = 1
        Me.gbGFXSettings.TabStop = False
        Me.gbGFXSettings.Text = "Graphics Config"
        '
        'gbVSync
        '
        Me.gbVSync.Location = New System.Drawing.Point(624, 295)
        Me.gbVSync.Name = "gbVSync"
        Me.gbVSync.Size = New System.Drawing.Size(200, 152)
        Me.gbVSync.TabIndex = 9
        Me.gbVSync.TabStop = False
        Me.gbVSync.Text = "VSync"
        '
        'gbLevelOfDetail
        '
        Me.gbLevelOfDetail.Location = New System.Drawing.Point(418, 295)
        Me.gbLevelOfDetail.Name = "gbLevelOfDetail"
        Me.gbLevelOfDetail.Size = New System.Drawing.Size(200, 152)
        Me.gbLevelOfDetail.TabIndex = 8
        Me.gbLevelOfDetail.TabStop = False
        Me.gbLevelOfDetail.Text = "Level of Detail"
        '
        'gbVolumetricLighting
        '
        Me.gbVolumetricLighting.Location = New System.Drawing.Point(212, 295)
        Me.gbVolumetricLighting.Name = "gbVolumetricLighting"
        Me.gbVolumetricLighting.Size = New System.Drawing.Size(200, 152)
        Me.gbVolumetricLighting.TabIndex = 7
        Me.gbVolumetricLighting.TabStop = False
        Me.gbVolumetricLighting.Text = "Volumetric Lighting"
        '
        'gbBloom
        '
        Me.gbBloom.Location = New System.Drawing.Point(6, 295)
        Me.gbBloom.Name = "gbBloom"
        Me.gbBloom.Size = New System.Drawing.Size(200, 152)
        Me.gbBloom.TabIndex = 6
        Me.gbBloom.TabStop = False
        Me.gbBloom.Text = "Bloom"
        '
        'gbDepthOfField
        '
        Me.gbDepthOfField.Location = New System.Drawing.Point(830, 137)
        Me.gbDepthOfField.Name = "gbDepthOfField"
        Me.gbDepthOfField.Size = New System.Drawing.Size(200, 152)
        Me.gbDepthOfField.TabIndex = 6
        Me.gbDepthOfField.TabStop = False
        Me.gbDepthOfField.Text = "Depth of Field"
        '
        'gbShadows
        '
        Me.gbShadows.Location = New System.Drawing.Point(624, 137)
        Me.gbShadows.Name = "gbShadows"
        Me.gbShadows.Size = New System.Drawing.Size(200, 152)
        Me.gbShadows.TabIndex = 6
        Me.gbShadows.TabStop = False
        Me.gbShadows.Text = "Shadows"
        '
        'gbSSAO
        '
        Me.gbSSAO.Location = New System.Drawing.Point(418, 137)
        Me.gbSSAO.Name = "gbSSAO"
        Me.gbSSAO.Size = New System.Drawing.Size(200, 152)
        Me.gbSSAO.TabIndex = 5
        Me.gbSSAO.TabStop = False
        Me.gbSSAO.Text = "SSAO"
        '
        'gbMSAA
        '
        Me.gbMSAA.Location = New System.Drawing.Point(212, 137)
        Me.gbMSAA.Name = "gbMSAA"
        Me.gbMSAA.Size = New System.Drawing.Size(200, 152)
        Me.gbMSAA.TabIndex = 4
        Me.gbMSAA.TabStop = False
        Me.gbMSAA.Text = "MSAA"
        '
        'gbFXAA
        '
        Me.gbFXAA.Location = New System.Drawing.Point(6, 137)
        Me.gbFXAA.Name = "gbFXAA"
        Me.gbFXAA.Size = New System.Drawing.Size(200, 152)
        Me.gbFXAA.TabIndex = 3
        Me.gbFXAA.TabStop = False
        Me.gbFXAA.Text = "FXAA"
        '
        'gbAdapter
        '
        Me.gbAdapter.Controls.Add(Me.cbGPUs)
        Me.gbAdapter.Location = New System.Drawing.Point(324, 19)
        Me.gbAdapter.Name = "gbAdapter"
        Me.gbAdapter.Size = New System.Drawing.Size(283, 112)
        Me.gbAdapter.TabIndex = 2
        Me.gbAdapter.TabStop = False
        Me.gbAdapter.Text = "Video Card Settings"
        '
        'cbGPUs
        '
        Me.cbGPUs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGPUs.FormattingEnabled = True
        Me.cbGPUs.Location = New System.Drawing.Point(6, 19)
        Me.cbGPUs.Name = "cbGPUs"
        Me.cbGPUs.Size = New System.Drawing.Size(271, 21)
        Me.cbGPUs.TabIndex = 0
        '
        'gbResolution
        '
        Me.gbResolution.Controls.Add(Me.rb8K)
        Me.gbResolution.Controls.Add(Me.rb4K)
        Me.gbResolution.Controls.Add(Me.rb1440p)
        Me.gbResolution.Controls.Add(Me.rb1080p)
        Me.gbResolution.Location = New System.Drawing.Point(118, 19)
        Me.gbResolution.Name = "gbResolution"
        Me.gbResolution.Size = New System.Drawing.Size(200, 112)
        Me.gbResolution.TabIndex = 1
        Me.gbResolution.TabStop = False
        Me.gbResolution.Text = "Resolution"
        '
        'rb8K
        '
        Me.rb8K.AutoSize = True
        Me.rb8K.Location = New System.Drawing.Point(6, 88)
        Me.rb8K.Name = "rb8K"
        Me.rb8K.Size = New System.Drawing.Size(147, 17)
        Me.rb8K.TabIndex = 3
        Me.rb8K.TabStop = True
        Me.rb8K.Text = "7860x4320 (Experimental)"
        Me.rb8K.UseVisualStyleBackColor = True
        '
        'rb4K
        '
        Me.rb4K.AutoSize = True
        Me.rb4K.Location = New System.Drawing.Point(6, 65)
        Me.rb4K.Name = "rb4K"
        Me.rb4K.Size = New System.Drawing.Size(78, 17)
        Me.rb4K.TabIndex = 2
        Me.rb4K.TabStop = True
        Me.rb4K.Text = "3840x2160"
        Me.rb4K.UseVisualStyleBackColor = True
        '
        'rb1440p
        '
        Me.rb1440p.AutoSize = True
        Me.rb1440p.Location = New System.Drawing.Point(6, 42)
        Me.rb1440p.Name = "rb1440p"
        Me.rb1440p.Size = New System.Drawing.Size(147, 17)
        Me.rb1440p.TabIndex = 1
        Me.rb1440p.TabStop = True
        Me.rb1440p.Text = "2560x1440 (Experimental)"
        Me.rb1440p.UseVisualStyleBackColor = True
        '
        'rb1080p
        '
        Me.rb1080p.AutoSize = True
        Me.rb1080p.Location = New System.Drawing.Point(6, 19)
        Me.rb1080p.Name = "rb1080p"
        Me.rb1080p.Size = New System.Drawing.Size(78, 17)
        Me.rb1080p.TabIndex = 0
        Me.rb1080p.TabStop = True
        Me.rb1080p.Text = "1920x1080"
        Me.rb1080p.UseVisualStyleBackColor = True
        '
        'gbDisplayMode
        '
        Me.gbDisplayMode.Controls.Add(Me.rbFullscreen)
        Me.gbDisplayMode.Controls.Add(Me.rbBorderless)
        Me.gbDisplayMode.Controls.Add(Me.rbWindowed)
        Me.gbDisplayMode.Location = New System.Drawing.Point(6, 19)
        Me.gbDisplayMode.Name = "gbDisplayMode"
        Me.gbDisplayMode.Size = New System.Drawing.Size(106, 112)
        Me.gbDisplayMode.TabIndex = 0
        Me.gbDisplayMode.TabStop = False
        Me.gbDisplayMode.Text = "Display Mode"
        '
        'rbFullscreen
        '
        Me.rbFullscreen.AutoSize = True
        Me.rbFullscreen.Location = New System.Drawing.Point(6, 65)
        Me.rbFullscreen.Name = "rbFullscreen"
        Me.rbFullscreen.Size = New System.Drawing.Size(73, 17)
        Me.rbFullscreen.TabIndex = 2
        Me.rbFullscreen.TabStop = True
        Me.rbFullscreen.Text = "Fullscreen"
        Me.rbFullscreen.UseVisualStyleBackColor = True
        '
        'rbBorderless
        '
        Me.rbBorderless.AutoSize = True
        Me.rbBorderless.Location = New System.Drawing.Point(6, 42)
        Me.rbBorderless.Name = "rbBorderless"
        Me.rbBorderless.Size = New System.Drawing.Size(74, 17)
        Me.rbBorderless.TabIndex = 1
        Me.rbBorderless.TabStop = True
        Me.rbBorderless.Text = "Borderless"
        Me.rbBorderless.UseVisualStyleBackColor = True
        '
        'rbWindowed
        '
        Me.rbWindowed.AutoSize = True
        Me.rbWindowed.Location = New System.Drawing.Point(6, 19)
        Me.rbWindowed.Name = "rbWindowed"
        Me.rbWindowed.Size = New System.Drawing.Size(76, 17)
        Me.rbWindowed.TabIndex = 0
        Me.rbWindowed.TabStop = True
        Me.rbWindowed.Text = "Windowed"
        Me.rbWindowed.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslCASOSupport})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 782)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1330, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslCASOSupport
        '
        Me.tsslCASOSupport.Name = "tsslCASOSupport"
        Me.tsslCASOSupport.Size = New System.Drawing.Size(358, 17)
        Me.tsslCASOSupport.Text = "Your system supports CASO (or at least our heuristic thinks it does)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 804)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbGFXSettings)
        Me.Controls.Add(Me.cmdLaunchGame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Clear Mirror v0.1 - AWvsSAO Launcher + Hybrid Graphics"
        Me.gbGFXSettings.ResumeLayout(False)
        Me.gbAdapter.ResumeLayout(False)
        Me.gbResolution.ResumeLayout(False)
        Me.gbResolution.PerformLayout()
        Me.gbDisplayMode.ResumeLayout(False)
        Me.gbDisplayMode.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdLaunchGame As Button
    Friend WithEvents gbGFXSettings As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents gbDisplayMode As GroupBox
    Friend WithEvents rbWindowed As RadioButton
    Friend WithEvents rbFullscreen As RadioButton
    Friend WithEvents rbBorderless As RadioButton
    Friend WithEvents gbResolution As GroupBox
    Friend WithEvents rb8K As RadioButton
    Friend WithEvents rb4K As RadioButton
    Friend WithEvents rb1440p As RadioButton
    Friend WithEvents rb1080p As RadioButton
    Friend WithEvents tsslCASOSupport As ToolStripStatusLabel
    Friend WithEvents gbAdapter As GroupBox
    Friend WithEvents cbGPUs As ComboBox
    Friend WithEvents gbMSAA As GroupBox
    Friend WithEvents gbFXAA As GroupBox
    Friend WithEvents gbVSync As GroupBox
    Friend WithEvents gbLevelOfDetail As GroupBox
    Friend WithEvents gbVolumetricLighting As GroupBox
    Friend WithEvents gbBloom As GroupBox
    Friend WithEvents gbDepthOfField As GroupBox
    Friend WithEvents gbShadows As GroupBox
    Friend WithEvents gbSSAO As GroupBox
End Class
