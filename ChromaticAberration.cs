public sealed class ChromaticAberration : PostProcessEffectSettings // TypeDefIndex: 11771
{	[TooltipAttribute] // RVA: 0xECA80 Offset: 0xEBE80 VA: 0x1800ECA80
	public TextureParameter spectralLut; // 0x30
	[RangeAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
	[TooltipAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
	public FloatParameter intensity; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xECCF0 Offset: 0xEC0F0 VA: 0x1800ECCF0
	[TooltipAttribute] // RVA: 0xECCF0 Offset: 0xEC0F0 VA: 0x1800ECCF0
	public BoolParameter fastMode; // 0x40


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

