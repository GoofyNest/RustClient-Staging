public class MotionBlur : ImageEffectBase // TypeDefIndex: 8193
{	public float blurAmount; // 0x28
	public bool extraBlur; // 0x2C
	private RenderTexture accumTexture; // 0x30


	protected override void Start() { }

	protected override void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public sealed class MotionBlur : PostProcessEffectSettings // TypeDefIndex: 11792
{	[RangeAttribute] // RVA: 0x73B80 Offset: 0x72F80 VA: 0x180073B80
	[TooltipAttribute] // RVA: 0x73B80 Offset: 0x72F80 VA: 0x180073B80
	public FloatParameter shutterAngle; // 0x30
	[RangeAttribute] // RVA: 0x73DC0 Offset: 0x731C0 VA: 0x180073DC0
	[TooltipAttribute] // RVA: 0x73DC0 Offset: 0x731C0 VA: 0x180073DC0
	public IntParameter sampleCount; // 0x38


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

