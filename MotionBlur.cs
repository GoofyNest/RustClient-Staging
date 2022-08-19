public class MotionBlur : ImageEffectBase // TypeDefIndex: 8193
{	// Fields
	public float blurAmount; // 0x28
	public bool extraBlur; // 0x2C
	private RenderTexture accumTexture; // 0x30

	// Methods

	// RVA: 0x21E1790 Offset: 0x21DFD90 VA: 0x1821E1790 Slot: 4
	protected override void Start() { }

	// RVA: 0x21E1300 Offset: 0x21DF900 VA: 0x1821E1300 Slot: 5
	protected override void OnDisable() { }

	// RVA: 0x21E13E0 Offset: 0x21DF9E0 VA: 0x1821E13E0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E1840 Offset: 0x21DFE40 VA: 0x1821E1840
	public void .ctor() { }

}

public sealed class MotionBlur : PostProcessEffectSettings // TypeDefIndex: 11792
{	// Fields
	[RangeAttribute] // RVA: 0x73A80 Offset: 0x72E80 VA: 0x180073A80
	[TooltipAttribute] // RVA: 0x73A80 Offset: 0x72E80 VA: 0x180073A80
	public FloatParameter shutterAngle; // 0x30
	[RangeAttribute] // RVA: 0x73C60 Offset: 0x73060 VA: 0x180073C60
	[TooltipAttribute] // RVA: 0x73C60 Offset: 0x73060 VA: 0x180073C60
	public IntParameter sampleCount; // 0x38

	// Methods

	// RVA: 0x101A350 Offset: 0x1018950 VA: 0x18101A350 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x101A420 Offset: 0x1018A20 VA: 0x18101A420
	public void .ctor() { }

}

