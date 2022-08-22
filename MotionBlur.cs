public class MotionBlur : ImageEffectBase // TypeDefIndex: 8193
{	// Fields
	public float blurAmount; // 0x28
	public bool extraBlur; // 0x2C
	private RenderTexture accumTexture; // 0x30

	// Methods

	// RVA: 0x21E15D0 Offset: 0x21DFBD0 VA: 0x1821E15D0 Slot: 4
	protected override void Start() { }

	// RVA: 0x21E1140 Offset: 0x21DF740 VA: 0x1821E1140 Slot: 5
	protected override void OnDisable() { }

	// RVA: 0x21E1220 Offset: 0x21DF820 VA: 0x1821E1220
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E1680 Offset: 0x21DFC80 VA: 0x1821E1680
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

	// RVA: 0x101A350 Offset: 0x1018950 VA: 0x18101A350 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x101A420 Offset: 0x1018A20 VA: 0x18101A420
	public void .ctor() { }

}

