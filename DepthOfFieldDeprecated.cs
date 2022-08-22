public class DepthOfFieldDeprecated : PostEffectsBase // TypeDefIndex: 8181
{	// Fields
	private static int SMOOTH_DOWNSAMPLE_PASS; // 0x0
	private static float BOKEH_EXTRA_BLUR; // 0x4
	public DepthOfFieldDeprecated.Dof34QualitySetting quality; // 0x28
	public DepthOfFieldDeprecated.DofResolution resolution; // 0x2C
	public bool simpleTweakMode; // 0x30
	public float focalPoint; // 0x34
	public float smoothness; // 0x38
	public float focalZDistance; // 0x3C
	public float focalZStartCurve; // 0x40
	public float focalZEndCurve; // 0x44
	private float focalStartCurve; // 0x48
	private float focalEndCurve; // 0x4C
	private float focalDistance01; // 0x50
	public Transform objectFocus; // 0x58
	public float focalSize; // 0x60
	public DepthOfFieldDeprecated.DofBlurriness bluriness; // 0x64
	public float maxBlurSpread; // 0x68
	public float foregroundBlurExtrude; // 0x6C
	public Shader dofBlurShader; // 0x70
	private Material dofBlurMaterial; // 0x78
	public Shader dofShader; // 0x80
	private Material dofMaterial; // 0x88
	public bool visualize; // 0x90
	public DepthOfFieldDeprecated.BokehDestination bokehDestination; // 0x94
	private float widthOverHeight; // 0x98
	private float oneOverBaseSize; // 0x9C
	public bool bokeh; // 0xA0
	public bool bokehSupport; // 0xA1
	public Shader bokehShader; // 0xA8
	public Texture2D bokehTexture; // 0xB0
	public float bokehScale; // 0xB8
	public float bokehIntensity; // 0xBC
	public float bokehThresholdContrast; // 0xC0
	public float bokehThresholdLuminance; // 0xC4
	public int bokehDownsample; // 0xC8
	private Material bokehMaterial; // 0xD0
	private Camera _camera; // 0xD8
	private RenderTexture foregroundTexture; // 0xE0
	private RenderTexture mediumRezWorkTexture; // 0xE8
	private RenderTexture finalDefocus; // 0xF0
	private RenderTexture lowRezWorkTexture; // 0xF8
	private RenderTexture bokehSource; // 0x100
	private RenderTexture bokehSource2; // 0x108

	// Methods

	// RVA: 0x21DBA00 Offset: 0x21DA000 VA: 0x1821DBA00
	private void CreateMaterials() { }

	// RVA: 0x21DB8C0 Offset: 0x21D9EC0 VA: 0x1821DB8C0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21DBEC0 Offset: 0x21DA4C0 VA: 0x1821DBEC0
	private void OnDisable() { }

	// RVA: 0x21DBF10 Offset: 0x21DA510 VA: 0x1821DBF10
	private void OnEnable() { }

	// RVA: 0x21DBCA0 Offset: 0x21DA2A0 VA: 0x1821DBCA0
	private float FocalDistance01(float worldDist) { }

	// RVA: 0x21DBE80 Offset: 0x21DA480 VA: 0x1821DBE80
	private int GetDividerBasedOnQuality() { }

	// RVA: 0x21DBEA0 Offset: 0x21DA4A0 VA: 0x1821DBEA0
	private int GetLowResolutionDividerBasedOnQuality(int baseDivider) { }

	// RVA: 0x21DBF90 Offset: 0x21DA590 VA: 0x1821DBF90
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DB580 Offset: 0x21D9B80 VA: 0x1821DB580
	private void Blur(RenderTexture from, RenderTexture to, DepthOfFieldDeprecated.DofBlurriness iterations, int blurPass, float spread) { }

	// RVA: 0x21DAF70 Offset: 0x21D9570 VA: 0x1821DAF70
	private void BlurFg(RenderTexture from, RenderTexture to, DepthOfFieldDeprecated.DofBlurriness iterations, int blurPass, float spread) { }

	// RVA: 0x21DB2D0 Offset: 0x21D98D0 VA: 0x1821DB2D0
	private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp) { }

	// RVA: 0x21DBB20 Offset: 0x21DA120 VA: 0x1821DBB20
	private void Downsample(RenderTexture from, RenderTexture to) { }

	// RVA: 0x21DA660 Offset: 0x21D8C60 VA: 0x1821DA660
	private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget) { }

	// RVA: 0x21DCB90 Offset: 0x21DB190 VA: 0x1821DCB90
	private void ReleaseTextures() { }

	// RVA: 0x21DAB30 Offset: 0x21D9130 VA: 0x1821DAB30
	private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider) { }

	// RVA: 0x21DCDA0 Offset: 0x21DB3A0 VA: 0x1821DCDA0
	public void .ctor() { }

	// RVA: 0x21DCD50 Offset: 0x21DB350 VA: 0x1821DCD50
	private static void .cctor() { }

}

public enum DepthOfFieldDeprecated.Dof34QualitySetting // TypeDefIndex: 8182
{	// Fields
	public int value__; // 0x0
	public const DepthOfFieldDeprecated.Dof34QualitySetting OnlyBackground = 1;
	public const DepthOfFieldDeprecated.Dof34QualitySetting BackgroundAndForeground = 2;

}

public enum DepthOfFieldDeprecated.DofResolution // TypeDefIndex: 8183
{	// Fields
	public int value__; // 0x0
	public const DepthOfFieldDeprecated.DofResolution High = 2;
	public const DepthOfFieldDeprecated.DofResolution Medium = 3;
	public const DepthOfFieldDeprecated.DofResolution Low = 4;

}

public enum DepthOfFieldDeprecated.DofBlurriness // TypeDefIndex: 8184
{	// Fields
	public int value__; // 0x0
	public const DepthOfFieldDeprecated.DofBlurriness Low = 1;
	public const DepthOfFieldDeprecated.DofBlurriness High = 2;
	public const DepthOfFieldDeprecated.DofBlurriness VeryHigh = 4;

}

public enum DepthOfFieldDeprecated.BokehDestination // TypeDefIndex: 8185
{	// Fields
	public int value__; // 0x0
	public const DepthOfFieldDeprecated.BokehDestination Background = 1;
	public const DepthOfFieldDeprecated.BokehDestination Foreground = 2;
	public const DepthOfFieldDeprecated.BokehDestination BackgroundAndForeground = 3;

}

