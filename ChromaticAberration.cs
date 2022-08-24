public sealed class ChromaticAberration : PostProcessEffectSettings // TypeDefIndex: 11775
{	[TooltipAttribute] // RVA: 0xEC980 Offset: 0xEBD80 VA: 0x1800EC980
	public TextureParameter spectralLut; // 0x30
	[RangeAttribute] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
	[TooltipAttribute] // RVA: 0xEC9B0 Offset: 0xEBDB0 VA: 0x1800EC9B0
	public FloatParameter intensity; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xECA00 Offset: 0xEBE00 VA: 0x1800ECA00
	[TooltipAttribute] // RVA: 0xECA00 Offset: 0xEBE00 VA: 0x1800ECA00
	public BoolParameter fastMode; // 0x40


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

