public class SoundClass : ScriptableObject // TypeDefIndex: 9024
{	[HeaderAttribute] // RVA: 0xCD950 Offset: 0xCCD50 VA: 0x1800CD950
	public AudioMixerGroup output; // 0x18
	public AudioMixerGroup firstPersonOutput; // 0x20
	[HeaderAttribute] // RVA: 0xCDA50 Offset: 0xCCE50 VA: 0x1800CDA50
	public bool enableOcclusion; // 0x28
	public bool playIfOccluded; // 0x29
	public float occlusionGain; // 0x2C
	[TooltipAttribute] // RVA: 0xCDC70 Offset: 0xCD070 VA: 0x1800CDC70
	public AudioMixerGroup occludedOutput; // 0x30
	[HeaderAttribute] // RVA: 0xCDD40 Offset: 0xCD140 VA: 0x1800CDD40
	public int globalVoiceMaxCount; // 0x38
	public int priority; // 0x3C
	public List<SoundDefinition> definitions; // 0x40


	public void .ctor() { }

}

