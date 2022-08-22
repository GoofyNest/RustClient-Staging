internal static class BufferUtils // TypeDefIndex: 5958
{
// Namespace: Newtonsoft.Json.Utilities
[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal static class BufferUtils // TypeDefIndex: 5958
	// Methods

	// RVA: 0x17FE620 Offset: 0x17FCC20 VA: 0x1817FE620
	public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) { }

	// RVA: 0x17FE690 Offset: 0x17FCC90 VA: 0x1817FE690
	public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) { }

	// RVA: 0x17FE580 Offset: 0x17FCB80 VA: 0x1817FE580
	public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) { }

}

