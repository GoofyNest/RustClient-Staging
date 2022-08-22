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

	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	public bool get_ForceOnlyFarBlur() { }

	// RVA: 0x5925D0 Offset: 0x590BD0 VA: 0x1805925D0
	public void set_ForceOnlyFarBlur(bool value) { }

	// RVA: 0x21DD950 Offset: 0x21DBF50 VA: 0x1821DD950 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21DE090 Offset: 0x21DC690 VA: 0x1821DE090
	private void OnEnable() { }

	// RVA: 0x21DDF20 Offset: 0x21DC520 VA: 0x1821DDF20
	private void OnDisable() { }

	// RVA: 0x21DFBE0 Offset: 0x21DE1E0 VA: 0x1821DFBE0
	private void ReleaseComputeResources() { }

	// RVA: 0x21DDB60 Offset: 0x21DC160 VA: 0x1821DDB60
	private void CreateComputeResources() { }

	// RVA: 0x21DDCF0 Offset: 0x21DC2F0 VA: 0x1821DDCF0
	private float FocalDistance01(float worldDist) { }

	// RVA: 0x21DFC50 Offset: 0x21DE250 VA: 0x1821DFC50
	private void WriteCoc(RenderTexture fromTo, bool fgDilate) { }

	// RVA: 0x21DE0F0 Offset: 0x21DC6F0 VA: 0x1821DE0F0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21DFFB0 Offset: 0x21DE5B0 VA: 0x1821DFFB0
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
	[MinAttribute] // RVA: 0x6FBA0 Offset: 0x6EFA0 VA: 0x18006FBA0
	[TooltipAttribute] // RVA: 0x6FBA0 Offset: 0x6EFA0 VA: 0x18006FBA0
	public FloatParameter focusDistance; // 0x30
	[RangeAttribute] // RVA: 0x6FE10 Offset: 0x6F210 VA: 0x18006FE10
	[TooltipAttribute] // RVA: 0x6FE10 Offset: 0x6F210 VA: 0x18006FE10
	public FloatParameter aperture; // 0x38
	[RangeAttribute] // RVA: 0x70010 Offset: 0x6F410 VA: 0x180070010
	[TooltipAttribute] // RVA: 0x70010 Offset: 0x6F410 VA: 0x180070010
	public FloatParameter focalLength; // 0x40
	[DisplayNameAttribute] // RVA: 0x70240 Offset: 0x6F640 VA: 0x180070240
	[TooltipAttribute] // RVA: 0x70240 Offset: 0x6F640 VA: 0x180070240
	public KernelSizeParameter kernelSize; // 0x48

	// Methods

	// RVA: 0x9FD7C0 Offset: 0x9FBDC0 VA: 0x1809FD7C0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9FD800 Offset: 0x9FBE00 VA: 0x1809FD800
	public void .ctor() { }

}

