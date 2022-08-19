public class SoundClass : ScriptableObject // TypeDefIndex: 9024
{	// Fields
	[HeaderAttribute] // RVA: 0xCD780 Offset: 0xCCB80 VA: 0x1800CD780
	public AudioMixerGroup output; // 0x18
	public AudioMixerGroup firstPersonOutput; // 0x20
	[HeaderAttribute] // RVA: 0xCD7E0 Offset: 0xCCBE0 VA: 0x1800CD7E0
	public bool enableOcclusion; // 0x28
	public bool playIfOccluded; // 0x29
	public float occlusionGain; // 0x2C
	[TooltipAttribute] // RVA: 0xCD9C0 Offset: 0xCCDC0 VA: 0x1800CD9C0
	public AudioMixerGroup occludedOutput; // 0x30
	[HeaderAttribute] // RVA: 0xCDB00 Offset: 0xCCF00 VA: 0x1800CDB00
	public int globalVoiceMaxCount; // 0x38
	public int priority; // 0x3C
	public List<SoundDefinition> definitions; // 0x40

	// Methods

	// RVA: 0xA74B00 Offset: 0xA73100 VA: 0x180A74B00
	public void .ctor() { }

}

