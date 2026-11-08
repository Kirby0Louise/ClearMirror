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
        Me.rbVSyncOff = New System.Windows.Forms.RadioButton()
        Me.rbVSyncOn = New System.Windows.Forms.RadioButton()
        Me.gbLevelOfDetail = New System.Windows.Forms.GroupBox()
        Me.rbLODNear = New System.Windows.Forms.RadioButton()
        Me.rbLODMid = New System.Windows.Forms.RadioButton()
        Me.rbLODFar = New System.Windows.Forms.RadioButton()
        Me.gbVolumetricLighting = New System.Windows.Forms.GroupBox()
        Me.rbVolumetricOff = New System.Windows.Forms.RadioButton()
        Me.rbVolumetricOn = New System.Windows.Forms.RadioButton()
        Me.gbBloom = New System.Windows.Forms.GroupBox()
        Me.rbBloomOff = New System.Windows.Forms.RadioButton()
        Me.rbBloomOn = New System.Windows.Forms.RadioButton()
        Me.gbDepthOfField = New System.Windows.Forms.GroupBox()
        Me.rbDOFOff = New System.Windows.Forms.RadioButton()
        Me.rbDOFOn = New System.Windows.Forms.RadioButton()
        Me.gbShadows = New System.Windows.Forms.GroupBox()
        Me.rbShadowsOff = New System.Windows.Forms.RadioButton()
        Me.rbShadowsLow = New System.Windows.Forms.RadioButton()
        Me.rbShadowsHigh = New System.Windows.Forms.RadioButton()
        Me.gbSSAO = New System.Windows.Forms.GroupBox()
        Me.rbSSAOOff = New System.Windows.Forms.RadioButton()
        Me.rbSSAOOn = New System.Windows.Forms.RadioButton()
        Me.gbMSAA = New System.Windows.Forms.GroupBox()
        Me.rbMSAA16x = New System.Windows.Forms.RadioButton()
        Me.rbMSAA8x = New System.Windows.Forms.RadioButton()
        Me.rbMSAA4x = New System.Windows.Forms.RadioButton()
        Me.rbMSAA2x = New System.Windows.Forms.RadioButton()
        Me.rbMSAA1x = New System.Windows.Forms.RadioButton()
        Me.gbFXAA = New System.Windows.Forms.GroupBox()
        Me.rbFXAAOff = New System.Windows.Forms.RadioButton()
        Me.rbFXXAOn = New System.Windows.Forms.RadioButton()
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
        Me.gbVSync.SuspendLayout()
        Me.gbLevelOfDetail.SuspendLayout()
        Me.gbVolumetricLighting.SuspendLayout()
        Me.gbBloom.SuspendLayout()
        Me.gbDepthOfField.SuspendLayout()
        Me.gbShadows.SuspendLayout()
        Me.gbSSAO.SuspendLayout()
        Me.gbMSAA.SuspendLayout()
        Me.gbFXAA.SuspendLayout()
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
        Me.gbVSync.Controls.Add(Me.rbVSyncOff)
        Me.gbVSync.Controls.Add(Me.rbVSyncOn)
        Me.gbVSync.Location = New System.Drawing.Point(624, 295)
        Me.gbVSync.Name = "gbVSync"
        Me.gbVSync.Size = New System.Drawing.Size(200, 152)
        Me.gbVSync.TabIndex = 9
        Me.gbVSync.TabStop = False
        Me.gbVSync.Text = "VSync"
        '
        'rbVSyncOff
        '
        Me.rbVSyncOff.AutoSize = True
        Me.rbVSyncOff.Location = New System.Drawing.Point(6, 42)
        Me.rbVSyncOff.Name = "rbVSyncOff"
        Me.rbVSyncOff.Size = New System.Drawing.Size(39, 17)
        Me.rbVSyncOff.TabIndex = 5
        Me.rbVSyncOff.TabStop = True
        Me.rbVSyncOff.Tag = "0"
        Me.rbVSyncOff.Text = "Off"
        Me.rbVSyncOff.UseVisualStyleBackColor = True
        '
        'rbVSyncOn
        '
        Me.rbVSyncOn.AutoSize = True
        Me.rbVSyncOn.Location = New System.Drawing.Point(6, 19)
        Me.rbVSyncOn.Name = "rbVSyncOn"
        Me.rbVSyncOn.Size = New System.Drawing.Size(39, 17)
        Me.rbVSyncOn.TabIndex = 4
        Me.rbVSyncOn.TabStop = True
        Me.rbVSyncOn.Tag = "1"
        Me.rbVSyncOn.Text = "On"
        Me.rbVSyncOn.UseVisualStyleBackColor = True
        '
        'gbLevelOfDetail
        '
        Me.gbLevelOfDetail.Controls.Add(Me.rbLODNear)
        Me.gbLevelOfDetail.Controls.Add(Me.rbLODMid)
        Me.gbLevelOfDetail.Controls.Add(Me.rbLODFar)
        Me.gbLevelOfDetail.Location = New System.Drawing.Point(418, 295)
        Me.gbLevelOfDetail.Name = "gbLevelOfDetail"
        Me.gbLevelOfDetail.Size = New System.Drawing.Size(200, 152)
        Me.gbLevelOfDetail.TabIndex = 8
        Me.gbLevelOfDetail.TabStop = False
        Me.gbLevelOfDetail.Text = "Level of Detail"
        '
        'rbLODNear
        '
        Me.rbLODNear.AutoSize = True
        Me.rbLODNear.Location = New System.Drawing.Point(6, 65)
        Me.rbLODNear.Name = "rbLODNear"
        Me.rbLODNear.Size = New System.Drawing.Size(48, 17)
        Me.rbLODNear.TabIndex = 9
        Me.rbLODNear.TabStop = True
        Me.rbLODNear.Tag = "0"
        Me.rbLODNear.Text = "Near"
        Me.rbLODNear.UseVisualStyleBackColor = True
        '
        'rbLODMid
        '
        Me.rbLODMid.AutoSize = True
        Me.rbLODMid.Location = New System.Drawing.Point(6, 42)
        Me.rbLODMid.Name = "rbLODMid"
        Me.rbLODMid.Size = New System.Drawing.Size(42, 17)
        Me.rbLODMid.TabIndex = 8
        Me.rbLODMid.TabStop = True
        Me.rbLODMid.Tag = "1"
        Me.rbLODMid.Text = "Mid"
        Me.rbLODMid.UseVisualStyleBackColor = True
        '
        'rbLODFar
        '
        Me.rbLODFar.AutoSize = True
        Me.rbLODFar.Location = New System.Drawing.Point(6, 19)
        Me.rbLODFar.Name = "rbLODFar"
        Me.rbLODFar.Size = New System.Drawing.Size(40, 17)
        Me.rbLODFar.TabIndex = 7
        Me.rbLODFar.TabStop = True
        Me.rbLODFar.Tag = "2"
        Me.rbLODFar.Text = "Far"
        Me.rbLODFar.UseVisualStyleBackColor = True
        '
        'gbVolumetricLighting
        '
        Me.gbVolumetricLighting.Controls.Add(Me.rbVolumetricOff)
        Me.gbVolumetricLighting.Controls.Add(Me.rbVolumetricOn)
        Me.gbVolumetricLighting.Location = New System.Drawing.Point(212, 295)
        Me.gbVolumetricLighting.Name = "gbVolumetricLighting"
        Me.gbVolumetricLighting.Size = New System.Drawing.Size(200, 152)
        Me.gbVolumetricLighting.TabIndex = 7
        Me.gbVolumetricLighting.TabStop = False
        Me.gbVolumetricLighting.Text = "Volumetric Lighting"
        '
        'rbVolumetricOff
        '
        Me.rbVolumetricOff.AutoSize = True
        Me.rbVolumetricOff.Location = New System.Drawing.Point(6, 42)
        Me.rbVolumetricOff.Name = "rbVolumetricOff"
        Me.rbVolumetricOff.Size = New System.Drawing.Size(39, 17)
        Me.rbVolumetricOff.TabIndex = 5
        Me.rbVolumetricOff.TabStop = True
        Me.rbVolumetricOff.Tag = "0"
        Me.rbVolumetricOff.Text = "Off"
        Me.rbVolumetricOff.UseVisualStyleBackColor = True
        '
        'rbVolumetricOn
        '
        Me.rbVolumetricOn.AutoSize = True
        Me.rbVolumetricOn.Location = New System.Drawing.Point(6, 19)
        Me.rbVolumetricOn.Name = "rbVolumetricOn"
        Me.rbVolumetricOn.Size = New System.Drawing.Size(39, 17)
        Me.rbVolumetricOn.TabIndex = 4
        Me.rbVolumetricOn.TabStop = True
        Me.rbVolumetricOn.Tag = "1"
        Me.rbVolumetricOn.Text = "On"
        Me.rbVolumetricOn.UseVisualStyleBackColor = True
        '
        'gbBloom
        '
        Me.gbBloom.Controls.Add(Me.rbBloomOff)
        Me.gbBloom.Controls.Add(Me.rbBloomOn)
        Me.gbBloom.Location = New System.Drawing.Point(6, 295)
        Me.gbBloom.Name = "gbBloom"
        Me.gbBloom.Size = New System.Drawing.Size(200, 152)
        Me.gbBloom.TabIndex = 6
        Me.gbBloom.TabStop = False
        Me.gbBloom.Text = "Bloom"
        '
        'rbBloomOff
        '
        Me.rbBloomOff.AutoSize = True
        Me.rbBloomOff.Location = New System.Drawing.Point(6, 42)
        Me.rbBloomOff.Name = "rbBloomOff"
        Me.rbBloomOff.Size = New System.Drawing.Size(39, 17)
        Me.rbBloomOff.TabIndex = 5
        Me.rbBloomOff.TabStop = True
        Me.rbBloomOff.Tag = "0"
        Me.rbBloomOff.Text = "Off"
        Me.rbBloomOff.UseVisualStyleBackColor = True
        '
        'rbBloomOn
        '
        Me.rbBloomOn.AutoSize = True
        Me.rbBloomOn.Location = New System.Drawing.Point(6, 19)
        Me.rbBloomOn.Name = "rbBloomOn"
        Me.rbBloomOn.Size = New System.Drawing.Size(39, 17)
        Me.rbBloomOn.TabIndex = 4
        Me.rbBloomOn.TabStop = True
        Me.rbBloomOn.Tag = "1"
        Me.rbBloomOn.Text = "On"
        Me.rbBloomOn.UseVisualStyleBackColor = True
        '
        'gbDepthOfField
        '
        Me.gbDepthOfField.Controls.Add(Me.rbDOFOff)
        Me.gbDepthOfField.Controls.Add(Me.rbDOFOn)
        Me.gbDepthOfField.Location = New System.Drawing.Point(830, 137)
        Me.gbDepthOfField.Name = "gbDepthOfField"
        Me.gbDepthOfField.Size = New System.Drawing.Size(200, 152)
        Me.gbDepthOfField.TabIndex = 6
        Me.gbDepthOfField.TabStop = False
        Me.gbDepthOfField.Text = "Depth of Field"
        '
        'rbDOFOff
        '
        Me.rbDOFOff.AutoSize = True
        Me.rbDOFOff.Location = New System.Drawing.Point(6, 42)
        Me.rbDOFOff.Name = "rbDOFOff"
        Me.rbDOFOff.Size = New System.Drawing.Size(39, 17)
        Me.rbDOFOff.TabIndex = 5
        Me.rbDOFOff.TabStop = True
        Me.rbDOFOff.Tag = "0"
        Me.rbDOFOff.Text = "Off"
        Me.rbDOFOff.UseVisualStyleBackColor = True
        '
        'rbDOFOn
        '
        Me.rbDOFOn.AutoSize = True
        Me.rbDOFOn.Location = New System.Drawing.Point(6, 19)
        Me.rbDOFOn.Name = "rbDOFOn"
        Me.rbDOFOn.Size = New System.Drawing.Size(39, 17)
        Me.rbDOFOn.TabIndex = 4
        Me.rbDOFOn.TabStop = True
        Me.rbDOFOn.Tag = "1"
        Me.rbDOFOn.Text = "On"
        Me.rbDOFOn.UseVisualStyleBackColor = True
        '
        'gbShadows
        '
        Me.gbShadows.Controls.Add(Me.rbShadowsOff)
        Me.gbShadows.Controls.Add(Me.rbShadowsLow)
        Me.gbShadows.Controls.Add(Me.rbShadowsHigh)
        Me.gbShadows.Location = New System.Drawing.Point(624, 137)
        Me.gbShadows.Name = "gbShadows"
        Me.gbShadows.Size = New System.Drawing.Size(200, 152)
        Me.gbShadows.TabIndex = 6
        Me.gbShadows.TabStop = False
        Me.gbShadows.Text = "Shadows"
        '
        'rbShadowsOff
        '
        Me.rbShadowsOff.AutoSize = True
        Me.rbShadowsOff.Location = New System.Drawing.Point(6, 65)
        Me.rbShadowsOff.Name = "rbShadowsOff"
        Me.rbShadowsOff.Size = New System.Drawing.Size(39, 17)
        Me.rbShadowsOff.TabIndex = 6
        Me.rbShadowsOff.TabStop = True
        Me.rbShadowsOff.Tag = "0"
        Me.rbShadowsOff.Text = "Off"
        Me.rbShadowsOff.UseVisualStyleBackColor = True
        '
        'rbShadowsLow
        '
        Me.rbShadowsLow.AutoSize = True
        Me.rbShadowsLow.Location = New System.Drawing.Point(6, 42)
        Me.rbShadowsLow.Name = "rbShadowsLow"
        Me.rbShadowsLow.Size = New System.Drawing.Size(45, 17)
        Me.rbShadowsLow.TabIndex = 5
        Me.rbShadowsLow.TabStop = True
        Me.rbShadowsLow.Tag = "1"
        Me.rbShadowsLow.Text = "Low"
        Me.rbShadowsLow.UseVisualStyleBackColor = True
        '
        'rbShadowsHigh
        '
        Me.rbShadowsHigh.AutoSize = True
        Me.rbShadowsHigh.Location = New System.Drawing.Point(6, 19)
        Me.rbShadowsHigh.Name = "rbShadowsHigh"
        Me.rbShadowsHigh.Size = New System.Drawing.Size(47, 17)
        Me.rbShadowsHigh.TabIndex = 4
        Me.rbShadowsHigh.TabStop = True
        Me.rbShadowsHigh.Tag = "2"
        Me.rbShadowsHigh.Text = "High"
        Me.rbShadowsHigh.UseVisualStyleBackColor = True
        '
        'gbSSAO
        '
        Me.gbSSAO.Controls.Add(Me.rbSSAOOff)
        Me.gbSSAO.Controls.Add(Me.rbSSAOOn)
        Me.gbSSAO.Location = New System.Drawing.Point(418, 137)
        Me.gbSSAO.Name = "gbSSAO"
        Me.gbSSAO.Size = New System.Drawing.Size(200, 152)
        Me.gbSSAO.TabIndex = 5
        Me.gbSSAO.TabStop = False
        Me.gbSSAO.Text = "SSAO"
        '
        'rbSSAOOff
        '
        Me.rbSSAOOff.AutoSize = True
        Me.rbSSAOOff.Location = New System.Drawing.Point(6, 42)
        Me.rbSSAOOff.Name = "rbSSAOOff"
        Me.rbSSAOOff.Size = New System.Drawing.Size(39, 17)
        Me.rbSSAOOff.TabIndex = 3
        Me.rbSSAOOff.TabStop = True
        Me.rbSSAOOff.Tag = "0"
        Me.rbSSAOOff.Text = "Off"
        Me.rbSSAOOff.UseVisualStyleBackColor = True
        '
        'rbSSAOOn
        '
        Me.rbSSAOOn.AutoSize = True
        Me.rbSSAOOn.Location = New System.Drawing.Point(6, 19)
        Me.rbSSAOOn.Name = "rbSSAOOn"
        Me.rbSSAOOn.Size = New System.Drawing.Size(39, 17)
        Me.rbSSAOOn.TabIndex = 2
        Me.rbSSAOOn.TabStop = True
        Me.rbSSAOOn.Tag = "1"
        Me.rbSSAOOn.Text = "On"
        Me.rbSSAOOn.UseVisualStyleBackColor = True
        '
        'gbMSAA
        '
        Me.gbMSAA.Controls.Add(Me.rbMSAA16x)
        Me.gbMSAA.Controls.Add(Me.rbMSAA8x)
        Me.gbMSAA.Controls.Add(Me.rbMSAA4x)
        Me.gbMSAA.Controls.Add(Me.rbMSAA2x)
        Me.gbMSAA.Controls.Add(Me.rbMSAA1x)
        Me.gbMSAA.Location = New System.Drawing.Point(212, 137)
        Me.gbMSAA.Name = "gbMSAA"
        Me.gbMSAA.Size = New System.Drawing.Size(200, 152)
        Me.gbMSAA.TabIndex = 4
        Me.gbMSAA.TabStop = False
        Me.gbMSAA.Text = "MSAA"
        '
        'rbMSAA16x
        '
        Me.rbMSAA16x.AutoSize = True
        Me.rbMSAA16x.Location = New System.Drawing.Point(6, 111)
        Me.rbMSAA16x.Name = "rbMSAA16x"
        Me.rbMSAA16x.Size = New System.Drawing.Size(154, 17)
        Me.rbMSAA16x.TabIndex = 4
        Me.rbMSAA16x.TabStop = True
        Me.rbMSAA16x.Tag = "4"
        Me.rbMSAA16x.Text = "16x (Exp unless Arc Xe1/2)"
        Me.rbMSAA16x.UseVisualStyleBackColor = True
        '
        'rbMSAA8x
        '
        Me.rbMSAA8x.AutoSize = True
        Me.rbMSAA8x.Location = New System.Drawing.Point(6, 88)
        Me.rbMSAA8x.Name = "rbMSAA8x"
        Me.rbMSAA8x.Size = New System.Drawing.Size(36, 17)
        Me.rbMSAA8x.TabIndex = 3
        Me.rbMSAA8x.TabStop = True
        Me.rbMSAA8x.Tag = "3"
        Me.rbMSAA8x.Text = "8x"
        Me.rbMSAA8x.UseVisualStyleBackColor = True
        '
        'rbMSAA4x
        '
        Me.rbMSAA4x.AutoSize = True
        Me.rbMSAA4x.Location = New System.Drawing.Point(6, 65)
        Me.rbMSAA4x.Name = "rbMSAA4x"
        Me.rbMSAA4x.Size = New System.Drawing.Size(36, 17)
        Me.rbMSAA4x.TabIndex = 2
        Me.rbMSAA4x.TabStop = True
        Me.rbMSAA4x.Tag = "2"
        Me.rbMSAA4x.Text = "4x"
        Me.rbMSAA4x.UseVisualStyleBackColor = True
        '
        'rbMSAA2x
        '
        Me.rbMSAA2x.AutoSize = True
        Me.rbMSAA2x.Location = New System.Drawing.Point(6, 42)
        Me.rbMSAA2x.Name = "rbMSAA2x"
        Me.rbMSAA2x.Size = New System.Drawing.Size(36, 17)
        Me.rbMSAA2x.TabIndex = 1
        Me.rbMSAA2x.TabStop = True
        Me.rbMSAA2x.Tag = "1"
        Me.rbMSAA2x.Text = "2x"
        Me.rbMSAA2x.UseVisualStyleBackColor = True
        '
        'rbMSAA1x
        '
        Me.rbMSAA1x.AutoSize = True
        Me.rbMSAA1x.Location = New System.Drawing.Point(6, 19)
        Me.rbMSAA1x.Name = "rbMSAA1x"
        Me.rbMSAA1x.Size = New System.Drawing.Size(36, 17)
        Me.rbMSAA1x.TabIndex = 0
        Me.rbMSAA1x.TabStop = True
        Me.rbMSAA1x.Tag = "0"
        Me.rbMSAA1x.Text = "1x"
        Me.rbMSAA1x.UseVisualStyleBackColor = True
        '
        'gbFXAA
        '
        Me.gbFXAA.Controls.Add(Me.rbFXAAOff)
        Me.gbFXAA.Controls.Add(Me.rbFXXAOn)
        Me.gbFXAA.Location = New System.Drawing.Point(6, 137)
        Me.gbFXAA.Name = "gbFXAA"
        Me.gbFXAA.Size = New System.Drawing.Size(200, 152)
        Me.gbFXAA.TabIndex = 3
        Me.gbFXAA.TabStop = False
        Me.gbFXAA.Text = "FXAA"
        '
        'rbFXAAOff
        '
        Me.rbFXAAOff.AutoSize = True
        Me.rbFXAAOff.Location = New System.Drawing.Point(6, 42)
        Me.rbFXAAOff.Name = "rbFXAAOff"
        Me.rbFXAAOff.Size = New System.Drawing.Size(39, 17)
        Me.rbFXAAOff.TabIndex = 1
        Me.rbFXAAOff.TabStop = True
        Me.rbFXAAOff.Tag = "0"
        Me.rbFXAAOff.Text = "Off"
        Me.rbFXAAOff.UseVisualStyleBackColor = True
        '
        'rbFXXAOn
        '
        Me.rbFXXAOn.AutoSize = True
        Me.rbFXXAOn.Location = New System.Drawing.Point(6, 19)
        Me.rbFXXAOn.Name = "rbFXXAOn"
        Me.rbFXXAOn.Size = New System.Drawing.Size(39, 17)
        Me.rbFXXAOn.TabIndex = 0
        Me.rbFXXAOn.TabStop = True
        Me.rbFXXAOn.Tag = "1"
        Me.rbFXXAOn.Text = "On"
        Me.rbFXXAOn.UseVisualStyleBackColor = True
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
        Me.rbFullscreen.Tag = "2"
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
        Me.rbBorderless.Tag = "1"
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
        Me.rbWindowed.Tag = "0"
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
        Me.Text = "Clear Mirror v0.2 (WIP) - AWvsSAO Launcher + Hybrid Graphics"
        Me.gbGFXSettings.ResumeLayout(False)
        Me.gbVSync.ResumeLayout(False)
        Me.gbVSync.PerformLayout()
        Me.gbLevelOfDetail.ResumeLayout(False)
        Me.gbLevelOfDetail.PerformLayout()
        Me.gbVolumetricLighting.ResumeLayout(False)
        Me.gbVolumetricLighting.PerformLayout()
        Me.gbBloom.ResumeLayout(False)
        Me.gbBloom.PerformLayout()
        Me.gbDepthOfField.ResumeLayout(False)
        Me.gbDepthOfField.PerformLayout()
        Me.gbShadows.ResumeLayout(False)
        Me.gbShadows.PerformLayout()
        Me.gbSSAO.ResumeLayout(False)
        Me.gbSSAO.PerformLayout()
        Me.gbMSAA.ResumeLayout(False)
        Me.gbMSAA.PerformLayout()
        Me.gbFXAA.ResumeLayout(False)
        Me.gbFXAA.PerformLayout()
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
    Friend WithEvents rbFXAAOff As RadioButton
    Friend WithEvents rbFXXAOn As RadioButton
    Friend WithEvents rbMSAA8x As RadioButton
    Friend WithEvents rbMSAA4x As RadioButton
    Friend WithEvents rbMSAA2x As RadioButton
    Friend WithEvents rbMSAA1x As RadioButton
    Friend WithEvents rbSSAOOff As RadioButton
    Friend WithEvents rbSSAOOn As RadioButton
    Friend WithEvents rbShadowsOff As RadioButton
    Friend WithEvents rbShadowsLow As RadioButton
    Friend WithEvents rbShadowsHigh As RadioButton
    Friend WithEvents rbDOFOff As RadioButton
    Friend WithEvents rbDOFOn As RadioButton
    Friend WithEvents rbVSyncOff As RadioButton
    Friend WithEvents rbVSyncOn As RadioButton
    Friend WithEvents rbLODNear As RadioButton
    Friend WithEvents rbLODMid As RadioButton
    Friend WithEvents rbLODFar As RadioButton
    Friend WithEvents rbVolumetricOff As RadioButton
    Friend WithEvents rbVolumetricOn As RadioButton
    Friend WithEvents rbBloomOff As RadioButton
    Friend WithEvents rbBloomOn As RadioButton
    Friend WithEvents rbMSAA16x As RadioButton
End Class
