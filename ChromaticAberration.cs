public sealed class ChromaticAberration : PostProcessEffectSettings // TypeDefIndex: 11771
{	// Fields
	[TooltipAttribute] // RVA: 0xECA80 Offset: 0xEBE80 VA: 0x1800ECA80
	public TextureParameter spectralLut; // 0x30
	[RangeAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
	[TooltipAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
	public FloatParameter intensity; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xECCF0 Offset: 0xEC0F0 VA: 0x1800ECCF0
	[TooltipAttribute] // RVA: 0xECCF0 Offset: 0xEC0F0 VA: 0x1800ECCF0
	public BoolParameter fastMode; // 0x40

	// Methods

	// RVA: 0x9F2180 Offset: 0x9F0780 VA: 0x1809F2180 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9F21C0 Offset: 0x9F07C0 VA: 0x1809F21C0
	public void .ctor() { }

}

