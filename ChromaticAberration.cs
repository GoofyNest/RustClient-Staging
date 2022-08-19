public sealed class ChromaticAberration : PostProcessEffectSettings // TypeDefIndex: 11771
{	// Fields
	[TooltipAttribute] // RVA: 0xEC9D0 Offset: 0xEBDD0 VA: 0x1800EC9D0
	public TextureParameter spectralLut; // 0x30
	[RangeAttribute] // RVA: 0xECA90 Offset: 0xEBE90 VA: 0x1800ECA90
	[TooltipAttribute] // RVA: 0xECA90 Offset: 0xEBE90 VA: 0x1800ECA90
	public FloatParameter intensity; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xECC60 Offset: 0xEC060 VA: 0x1800ECC60
	[TooltipAttribute] // RVA: 0xECC60 Offset: 0xEC060 VA: 0x1800ECC60
	public BoolParameter fastMode; // 0x40

	// Methods

	// RVA: 0x9F19D0 Offset: 0x9EFFD0 VA: 0x1809F19D0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9F1A10 Offset: 0x9F0010 VA: 0x1809F1A10
	public void .ctor() { }

}

