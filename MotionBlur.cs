public class MotionBlur : ImageEffectBase // TypeDefIndex: 8193
{	// Fields
	public float blurAmount; // 0x28
	public bool extraBlur; // 0x2C
	private RenderTexture accumTexture; // 0x30

	// Methods

	// RVA: 0x21E1890 Offset: 0x21DFE90 VA: 0x1821E1890 Slot: 4
	protected override void Start() { }

	// RVA: 0x21E1400 Offset: 0x21DFA00 VA: 0x1821E1400 Slot: 5
	protected override void OnDisable() { }

	// RVA: 0x21E14E0 Offset: 0x21DFAE0 VA: 0x1821E14E0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E1940 Offset: 0x21DFF40 VA: 0x1821E1940
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

	// RVA: 0x101A610 Offset: 0x1018C10 VA: 0x18101A610 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x101A6E0 Offset: 0x1018CE0 VA: 0x18101A6E0
	public void .ctor() { }

}

