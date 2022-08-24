public class SoundClass : ScriptableObject // TypeDefIndex: 9024
{	[HeaderAttribute] // RVA: 0xCD870 Offset: 0xCCC70 VA: 0x1800CD870
	public AudioMixerGroup output; // 0x18
	public AudioMixerGroup firstPersonOutput; // 0x20
	[HeaderAttribute] // RVA: 0xCD950 Offset: 0xCCD50 VA: 0x1800CD950
	public bool enableOcclusion; // 0x28
	public bool playIfOccluded; // 0x29
	public float occlusionGain; // 0x2C
	[TooltipAttribute] // RVA: 0xCDB80 Offset: 0xCCF80 VA: 0x1800CDB80
	public AudioMixerGroup occludedOutput; // 0x30
	[HeaderAttribute] // RVA: 0xCDC10 Offset: 0xCD010 VA: 0x1800CDC10
	public int globalVoiceMaxCount; // 0x38
	public int priority; // 0x3C
	public List<SoundDefinition> definitions; // 0x40


	public void .ctor() { }

}

