internal static class IntExtensions // TypeDefIndex: 6914
{
	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static int ToLittleEndianInt(Span<byte> source) { }

	private static T CopyFromMemory<T>(Span<byte> memory) { }
	/* GenericInstMethod :
	|
	|-IntExtensions.CopyFromMemory<ushort>
	|
	|-IntExtensions.CopyFromMemory<ulong>
	*/

}

