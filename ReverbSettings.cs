public class ReverbSettings : ScriptableObject // TypeDefIndex: 9017
{	// Fields
	[RangeAttribute] // RVA: 0xCAE60 Offset: 0xCA260 VA: 0x1800CAE60
	public int room; // 0x18
	[RangeAttribute] // RVA: 0xCAE60 Offset: 0xCA260 VA: 0x1800CAE60
	public int roomHF; // 0x1C
	[RangeAttribute] // RVA: 0xCAE60 Offset: 0xCA260 VA: 0x1800CAE60
	public int roomLF; // 0x20
	[RangeAttribute] // RVA: 0xCAF70 Offset: 0xCA370 VA: 0x1800CAF70
	public float decayTime; // 0x24
	[RangeAttribute] // RVA: 0xCB010 Offset: 0xCA410 VA: 0x1800CB010
	public float decayHFRatio; // 0x28
	[RangeAttribute] // RVA: 0xCB090 Offset: 0xCA490 VA: 0x1800CB090
	public int reflections; // 0x2C
	[RangeAttribute] // RVA: 0xCB0E0 Offset: 0xCA4E0 VA: 0x1800CB0E0
	public float reflectionsDelay; // 0x30
	[RangeAttribute] // RVA: 0xCB1F0 Offset: 0xCA5F0 VA: 0x1800CB1F0
	public int reverb; // 0x34
	[RangeAttribute] // RVA: 0xCB2B0 Offset: 0xCA6B0 VA: 0x1800CB2B0
	public float reverbDelay; // 0x38
	[RangeAttribute] // RVA: 0xCB360 Offset: 0xCA760 VA: 0x1800CB360
	public float HFReference; // 0x3C
	[RangeAttribute] // RVA: 0xCB490 Offset: 0xCA890 VA: 0x1800CB490
	public float LFReference; // 0x40
	[RangeAttribute] // RVA: 0x77D60 Offset: 0x77160 VA: 0x180077D60
	public float diffusion; // 0x44
	[RangeAttribute] // RVA: 0x77D60 Offset: 0x77160 VA: 0x180077D60
	public float density; // 0x48

	// Methods

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

