public struct MemoryBuffer // TypeDefIndex: 6915
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private byte[] <Data>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int <Length>k__BackingField; // 0x8
	private readonly bool _fromPool; // 0xC

	public byte[] Data { get; set; }
	public int Length { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Data(byte[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public int get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Length(int value) { }

	internal void .ctor(byte[] data, int length, bool fromPool = True) { }

	public void Dispose() { }

	public static Span<byte> op_Implicit(MemoryBuffer buffer) { }

}

