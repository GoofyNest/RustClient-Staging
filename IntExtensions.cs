internal static class IntExtensions // TypeDefIndex: 6914
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22075E0 Offset: 0x2205BE0 VA: 0x1822075E0
	public static int ToLittleEndianInt(Span<byte> source) { }

	// RVA: -1 Offset: -1
	private static T CopyFromMemory<T>(Span<byte> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE390 Offset: 0x5CC990 VA: 0x1805CE390
	|-IntExtensions.CopyFromMemory<ushort>
	|
	|-RVA: 0x5CE530 Offset: 0x5CCB30 VA: 0x1805CE530
	|-IntExtensions.CopyFromMemory<ulong>
	*/

}

