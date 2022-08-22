public class SoundClass : ScriptableObject // TypeDefIndex: 9024
{	// Fields
	[HeaderAttribute] // RVA: 0xCD7C0 Offset: 0xCCBC0 VA: 0x1800CD7C0
	public AudioMixerGroup output; // 0x18
	public AudioMixerGroup firstPersonOutput; // 0x20
	[HeaderAttribute] // RVA: 0xCD870 Offset: 0xCCC70 VA: 0x1800CD870
	public bool enableOcclusion; // 0x28
	public bool playIfOccluded; // 0x29
	public float occlusionGain; // 0x2C
	[TooltipAttribute] // RVA: 0xCDAA0 Offset: 0xCCEA0 VA: 0x1800CDAA0
	public AudioMixerGroup occludedOutput; // 0x30
	[HeaderAttribute] // RVA: 0xCDB90 Offset: 0xCCF90 VA: 0x1800CDB90
	public int globalVoiceMaxCount; // 0x38
	public int priority; // 0x3C
	public List<SoundDefinition> definitions; // 0x40

	// Methods

	// RVA: 0xA75290 Offset: 0xA73890 VA: 0x180A75290
	public void .ctor() { }

}

