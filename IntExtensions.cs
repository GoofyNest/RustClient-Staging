internal static class IntExtensions // TypeDefIndex: 6914
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static int ToLittleEndianInt(Span<byte> source) { }

	private static T CopyFromMemory<T>(Span<byte> memory) { }
	/* GenericInstMethod :
	|
	|-IntExtensions.CopyFromMemory<ushort>
	|
	|-IntExtensions.CopyFromMemory<ulong>
	*/

}

