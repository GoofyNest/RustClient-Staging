public class MotionBlur : ImageEffectBase // TypeDefIndex: 8193
{	public float blurAmount; // 0x28
	public bool extraBlur; // 0x2C
	private RenderTexture accumTexture; // 0x30


	protected override void Start() { }

	protected override void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public sealed class MotionBlur : PostProcessEffectSettings // TypeDefIndex: 11796
{	[RangeAttribute] // RVA: 0x73E10 Offset: 0x73210 VA: 0x180073E10
	[TooltipAttribute] // RVA: 0x73E10 Offset: 0x73210 VA: 0x180073E10
	public FloatParameter shutterAngle; // 0x30
	[RangeAttribute] // RVA: 0x74010 Offset: 0x73410 VA: 0x180074010
	[TooltipAttribute] // RVA: 0x74010 Offset: 0x73410 VA: 0x180074010
	public IntParameter sampleCount; // 0x38


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

