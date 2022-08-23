internal static class IntExtensions // TypeDefIndex: 6914
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int ToLittleEndianInt(Span<byte> source) { }

	private static T CopyFromMemory<T>(Span<byte> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE3F0 Offset: 0x5CC9F0 VA: 0x1805CE3F0
	|-IntExtensions.CopyFromMemory<ushort>
	|
	|-RVA: 0x5CE590 Offset: 0x5CCB90 VA: 0x1805CE590
	|-IntExtensions.CopyFromMemory<ulong>
	*/

}

