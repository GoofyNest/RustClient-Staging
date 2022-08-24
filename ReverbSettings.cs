public class ReverbSettings : ScriptableObject // TypeDefIndex: 9017
{	[RangeAttribute] // RVA: 0xCAFD0 Offset: 0xCA3D0 VA: 0x1800CAFD0
	public int room; // 0x18
	[RangeAttribute] // RVA: 0xCAFD0 Offset: 0xCA3D0 VA: 0x1800CAFD0
	public int roomHF; // 0x1C
	[RangeAttribute] // RVA: 0xCAFD0 Offset: 0xCA3D0 VA: 0x1800CAFD0
	public int roomLF; // 0x20
	[RangeAttribute] // RVA: 0xCB130 Offset: 0xCA530 VA: 0x1800CB130
	public float decayTime; // 0x24
	[RangeAttribute] // RVA: 0xCB1D0 Offset: 0xCA5D0 VA: 0x1800CB1D0
	public float decayHFRatio; // 0x28
	[RangeAttribute] // RVA: 0xCB220 Offset: 0xCA620 VA: 0x1800CB220
	public int reflections; // 0x2C
	[RangeAttribute] // RVA: 0xCB270 Offset: 0xCA670 VA: 0x1800CB270
	public float reflectionsDelay; // 0x30
	[RangeAttribute] // RVA: 0xCB3B0 Offset: 0xCA7B0 VA: 0x1800CB3B0
	public int reverb; // 0x34
	[RangeAttribute] // RVA: 0xCB440 Offset: 0xCA840 VA: 0x1800CB440
	public float reverbDelay; // 0x38
	[RangeAttribute] // RVA: 0xCB4C0 Offset: 0xCA8C0 VA: 0x1800CB4C0
	public float HFReference; // 0x3C
	[RangeAttribute] // RVA: 0xCB5C0 Offset: 0xCA9C0 VA: 0x1800CB5C0
	public float LFReference; // 0x40
	[RangeAttribute] // RVA: 0x78180 Offset: 0x77580 VA: 0x180078180
	public float diffusion; // 0x44
	[RangeAttribute] // RVA: 0x78180 Offset: 0x77580 VA: 0x180078180
	public float density; // 0x48


	public void .ctor() { }

}

