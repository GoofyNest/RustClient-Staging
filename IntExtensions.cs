internal static class IntExtensions // TypeDefIndex: 6914
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2207F00 Offset: 0x2206500 VA: 0x182207F00
	public static int ToLittleEndianInt(Span<byte> source) { }

	// RVA: -1 Offset: -1
	private static T CopyFromMemory<T>(Span<byte> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE320 Offset: 0x5CC920 VA: 0x1805CE320
	|-IntExtensions.CopyFromMemory<ushort>
	|
	|-RVA: 0x5CE4C0 Offset: 0x5CCAC0 VA: 0x1805CE4C0
	|-IntExtensions.CopyFromMemory<ulong>
	*/

}

