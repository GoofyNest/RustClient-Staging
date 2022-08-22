public struct MemoryBuffer // TypeDefIndex: 6915
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte[] <Data>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Length>k__BackingField; // 0x8
	private readonly bool _fromPool; // 0xC

	// Properties
	public byte[] Data { get; set; }
	public int Length { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	private void set_Data(byte[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122E10 Offset: 0x122210 VA: 0x180122E10
	public int get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DF50 Offset: 0x19D350 VA: 0x18019DF50
	private void set_Length(int value) { }

	// RVA: 0x2372B0 Offset: 0x2366B0 VA: 0x1802372B0
	internal void .ctor(byte[] data, int length, bool fromPool = True) { }

	// RVA: 0x2372A0 Offset: 0x2366A0 VA: 0x1802372A0
	public void Dispose() { }

	// RVA: 0x2207560 Offset: 0x2205B60 VA: 0x182207560
	public static Span<byte> op_Implicit(MemoryBuffer buffer) { }

}

