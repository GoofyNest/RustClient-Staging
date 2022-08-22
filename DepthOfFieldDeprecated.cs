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

	// RVA: 0x21DC4E0 Offset: 0x21DAAE0 VA: 0x1821DC4E0
	private void CreateMaterials() { }

	// RVA: 0x21DC3A0 Offset: 0x21DA9A0 VA: 0x1821DC3A0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21DC9A0 Offset: 0x21DAFA0 VA: 0x1821DC9A0
	private void OnDisable() { }

	// RVA: 0x21DC9F0 Offset: 0x21DAFF0 VA: 0x1821DC9F0
	private void OnEnable() { }

	// RVA: 0x21DC780 Offset: 0x21DAD80 VA: 0x1821DC780
	private float FocalDistance01(float worldDist) { }

	// RVA: 0x21DC960 Offset: 0x21DAF60 VA: 0x1821DC960
	private int GetDividerBasedOnQuality() { }

	// RVA: 0x21DC980 Offset: 0x21DAF80 VA: 0x1821DC980
	private int GetLowResolutionDividerBasedOnQuality(int baseDivider) { }

	// RVA: 0x21DCA70 Offset: 0x21DB070 VA: 0x1821DCA70
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DC060 Offset: 0x21DA660 VA: 0x1821DC060
	private void Blur(RenderTexture from, RenderTexture to, DepthOfFieldDeprecated.DofBlurriness iterations, int blurPass, float spread) { }

	// RVA: 0x21DBA50 Offset: 0x21DA050 VA: 0x1821DBA50
	private void BlurFg(RenderTexture from, RenderTexture to, DepthOfFieldDeprecated.DofBlurriness iterations, int blurPass, float spread) { }

	// RVA: 0x21DBDB0 Offset: 0x21DA3B0 VA: 0x1821DBDB0
	private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp) { }

	// RVA: 0x21DC600 Offset: 0x21DAC00 VA: 0x1821DC600
	private void Downsample(RenderTexture from, RenderTexture to) { }

	// RVA: 0x21DB140 Offset: 0x21D9740 VA: 0x1821DB140
	private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget) { }

	// RVA: 0x21DD670 Offset: 0x21DBC70 VA: 0x1821DD670
	private void ReleaseTextures() { }

	// RVA: 0x21DB610 Offset: 0x21D9C10 VA: 0x1821DB610
	private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider) { }

	// RVA: 0x21DD880 Offset: 0x21DBE80 VA: 0x1821DD880
	public void .ctor() { }

	// RVA: 0x21DD830 Offset: 0x21DBE30 VA: 0x1821DD830
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

