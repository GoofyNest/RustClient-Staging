public class DepthOfField : PostEffectsBase // TypeDefIndex: 8178
{	// Fields
	public bool visualizeFocus; // 0x28
	public float focalLength; // 0x2C
	public float focalSize; // 0x30
	public float aperture; // 0x34
	public Transform focalTransform; // 0x38
	public float maxBlurSize; // 0x40
	public bool highResolution; // 0x44
	public DepthOfField.BlurType blurType; // 0x48
	public DepthOfField.BlurSampleCount blurSampleCount; // 0x4C
	public bool nearBlur; // 0x50
	public float foregroundOverlap; // 0x54
	private bool forceOnlyFarBlur; // 0x58
	public Shader dofHdrShader; // 0x60
	private Material dofHdrMaterial; // 0x68
	public Shader dx11BokehShader; // 0x70
	private Material dx11bokehMaterial; // 0x78
	public float dx11BokehThreshold; // 0x80
	public float dx11SpawnHeuristic; // 0x84
	public Texture2D dx11BokehTexture; // 0x88
	public float dx11BokehScale; // 0x90
	public float dx11BokehIntensity; // 0x94
	private float focalDistance01; // 0x98
	private ComputeBuffer cbDrawArgs; // 0xA0
	private ComputeBuffer cbPoints; // 0xA8
	private float internalBlurWidth; // 0xB0

	// Properties
	public bool ForceOnlyFarBlur { get; set; }

	// Methods

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_ForceOnlyFarBlur() { }

	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	public void set_ForceOnlyFarBlur(bool value) { }

	// RVA: 0x21DD030 Offset: 0x21DB630 VA: 0x1821DD030 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21DD770 Offset: 0x21DBD70 VA: 0x1821DD770
	private void OnEnable() { }

	// RVA: 0x21DD600 Offset: 0x21DBC00 VA: 0x1821DD600
	private void OnDisable() { }

	// RVA: 0x21DF2C0 Offset: 0x21DD8C0 VA: 0x1821DF2C0
	private void ReleaseComputeResources() { }

	// RVA: 0x21DD240 Offset: 0x21DB840 VA: 0x1821DD240
	private void CreateComputeResources() { }

	// RVA: 0x21DD3D0 Offset: 0x21DB9D0 VA: 0x1821DD3D0
	private float FocalDistance01(float worldDist) { }

	// RVA: 0x21DF330 Offset: 0x21DD930 VA: 0x1821DF330
	private void WriteCoc(RenderTexture fromTo, bool fgDilate) { }

	// RVA: 0x21DD7D0 Offset: 0x21DBDD0 VA: 0x1821DD7D0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DF690 Offset: 0x21DDC90 VA: 0x1821DF690
	public void .ctor() { }

}

public enum DepthOfField.BlurType // TypeDefIndex: 8179
{	// Fields
	public int value__; // 0x0
	public const DepthOfField.BlurType DiscBlur = 0;
	public const DepthOfField.BlurType DX11 = 1;

}

public enum DepthOfField.BlurSampleCount // TypeDefIndex: 8180
{	// Fields
	public int value__; // 0x0
	public const DepthOfField.BlurSampleCount Low = 0;
	public const DepthOfField.BlurSampleCount Medium = 1;
	public const DepthOfField.BlurSampleCount High = 2;

}

public sealed class DepthOfField : PostProcessEffectSettings // TypeDefIndex: 11782
{	// Fields
	[MinAttribute] // RVA: 0x6F800 Offset: 0x6EC00 VA: 0x18006F800
	[TooltipAttribute] // RVA: 0x6F800 Offset: 0x6EC00 VA: 0x18006F800
	public FloatParameter focusDistance; // 0x30
	[RangeAttribute] // RVA: 0x6FCF0 Offset: 0x6F0F0 VA: 0x18006FCF0
	[TooltipAttribute] // RVA: 0x6FCF0 Offset: 0x6F0F0 VA: 0x18006FCF0
	public FloatParameter aperture; // 0x38
	[RangeAttribute] // RVA: 0x6FE20 Offset: 0x6F220 VA: 0x18006FE20
	[TooltipAttribute] // RVA: 0x6FE20 Offset: 0x6F220 VA: 0x18006FE20
	public FloatParameter focalLength; // 0x40
	[DisplayNameAttribute] // RVA: 0x70100 Offset: 0x6F500 VA: 0x180070100
	[TooltipAttribute] // RVA: 0x70100 Offset: 0x6F500 VA: 0x180070100
	public KernelSizeParameter kernelSize; // 0x48

	// Methods

	// RVA: 0x9FD010 Offset: 0x9FB610 VA: 0x1809FD010 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9FD050 Offset: 0x9FB650 VA: 0x1809FD050
	public void .ctor() { }

}

