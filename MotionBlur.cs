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
{	[RangeAttribute] // RVA: 0x72290 Offset: 0x71690 VA: 0x180072290
	[TooltipAttribute] // RVA: 0x72290 Offset: 0x71690 VA: 0x180072290
	public FloatParameter shutterAngle; // 0x30
	[RangeAttribute] // RVA: 0x724C0 Offset: 0x718C0 VA: 0x1800724C0
	[TooltipAttribute] // RVA: 0x724C0 Offset: 0x718C0 VA: 0x1800724C0
	public IntParameter sampleCount; // 0x38


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

