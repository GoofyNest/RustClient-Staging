public sealed class ChromaticAberration : PostProcessEffectSettings // TypeDefIndex: 11775
{	[TooltipAttribute] // RVA: 0xECC10 Offset: 0xEC010 VA: 0x1800ECC10
	public TextureParameter spectralLut; // 0x30
	[RangeAttribute] // RVA: 0xECE00 Offset: 0xEC200 VA: 0x1800ECE00
	[TooltipAttribute] // RVA: 0xECE00 Offset: 0xEC200 VA: 0x1800ECE00
	public FloatParameter intensity; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xECF20 Offset: 0xEC320 VA: 0x1800ECF20
	[TooltipAttribute] // RVA: 0xECF20 Offset: 0xEC320 VA: 0x1800ECF20
	public BoolParameter fastMode; // 0x40


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

