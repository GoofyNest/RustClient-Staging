public class MotionBlur : ImageEffectBase // TypeDefIndex: 8193
{	// Fields
	public float blurAmount; // 0x28
	public bool extraBlur; // 0x2C
	private RenderTexture accumTexture; // 0x30

	// Methods

	// RVA: 0x21E20B0 Offset: 0x21E06B0 VA: 0x1821E20B0 Slot: 4
	protected override void Start() { }

	// RVA: 0x21E1C20 Offset: 0x21E0220 VA: 0x1821E1C20 Slot: 5
	protected override void OnDisable() { }

	// RVA: 0x21E1D00 Offset: 0x21E0300 VA: 0x1821E1D00
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E2160 Offset: 0x21E0760 VA: 0x1821E2160
	public void .ctor() { }

}

public sealed class MotionBlur : PostProcessEffectSettings // TypeDefIndex: 11792
{	// Fields
	[RangeAttribute] // RVA: 0x73B80 Offset: 0x72F80 VA: 0x180073B80
	[TooltipAttribute] // RVA: 0x73B80 Offset: 0x72F80 VA: 0x180073B80
	public FloatParameter shutterAngle; // 0x30
	[RangeAttribute] // RVA: 0x73DC0 Offset: 0x731C0 VA: 0x180073DC0
	[TooltipAttribute] // RVA: 0x73DC0 Offset: 0x731C0 VA: 0x180073DC0
	public IntParameter sampleCount; // 0x38

	// Methods

	// RVA: 0x101B0B0 Offset: 0x10196B0 VA: 0x18101B0B0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x101B180 Offset: 0x1019780 VA: 0x18101B180
	public void .ctor() { }

}

