public class ReverbSettings : ScriptableObject // TypeDefIndex: 9017
{	[RangeAttribute] // RVA: 0xCAF20 Offset: 0xCA320 VA: 0x1800CAF20
	public int room; // 0x18
	[RangeAttribute] // RVA: 0xCAF20 Offset: 0xCA320 VA: 0x1800CAF20
	public int roomHF; // 0x1C
	[RangeAttribute] // RVA: 0xCAF20 Offset: 0xCA320 VA: 0x1800CAF20
	public int roomLF; // 0x20
	[RangeAttribute] // RVA: 0xCB090 Offset: 0xCA490 VA: 0x1800CB090
	public float decayTime; // 0x24
	[RangeAttribute] // RVA: 0xCB190 Offset: 0xCA590 VA: 0x1800CB190
	public float decayHFRatio; // 0x28
	[RangeAttribute] // RVA: 0xCB240 Offset: 0xCA640 VA: 0x1800CB240
	public int reflections; // 0x2C
	[RangeAttribute] // RVA: 0xCB290 Offset: 0xCA690 VA: 0x1800CB290
	public float reflectionsDelay; // 0x30
	[RangeAttribute] // RVA: 0xCB3F0 Offset: 0xCA7F0 VA: 0x1800CB3F0
	public int reverb; // 0x34
	[RangeAttribute] // RVA: 0xCB4D0 Offset: 0xCA8D0 VA: 0x1800CB4D0
	public float reverbDelay; // 0x38
	[RangeAttribute] // RVA: 0xCB580 Offset: 0xCA980 VA: 0x1800CB580
	public float HFReference; // 0x3C
	[RangeAttribute] // RVA: 0xCB650 Offset: 0xCAA50 VA: 0x1800CB650
	public float LFReference; // 0x40
	[RangeAttribute] // RVA: 0x77AC0 Offset: 0x76EC0 VA: 0x180077AC0
	public float diffusion; // 0x44
	[RangeAttribute] // RVA: 0x77AC0 Offset: 0x76EC0 VA: 0x180077AC0
	public float density; // 0x48


	public void .ctor() { }

}

