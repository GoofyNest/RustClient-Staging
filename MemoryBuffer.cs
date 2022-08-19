public struct MemoryBuffer // TypeDefIndex: 6915
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private byte[] <Data>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <Length>k__BackingField; // 0x8
	private readonly bool _fromPool; // 0xC

	// Properties
	public byte[] Data { get; set; }
	public int Length { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	private void set_Data(byte[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	public int get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19DFD0 Offset: 0x19D3D0 VA: 0x18019DFD0
	private void set_Length(int value) { }

	// RVA: 0x237330 Offset: 0x236730 VA: 0x180237330
	internal void .ctor(byte[] data, int length, bool fromPool = True) { }

	// RVA: 0x237320 Offset: 0x236720 VA: 0x180237320
	public void Dispose() { }

	// RVA: 0x2207720 Offset: 0x2205D20 VA: 0x182207720
	public static Span<byte> op_Implicit(MemoryBuffer buffer) { }

}

