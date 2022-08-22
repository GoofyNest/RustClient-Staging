internal static class BufferUtils // TypeDefIndex: 5958
{
// Namespace: Newtonsoft.Json.Utilities
[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal static class BufferUtils // TypeDefIndex: 5958
	// Methods

	// RVA: 0x17FE360 Offset: 0x17FC960 VA: 0x1817FE360
	public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) { }

	// RVA: 0x17FE3D0 Offset: 0x17FC9D0 VA: 0x1817FE3D0
	public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) { }

	// RVA: 0x17FE2C0 Offset: 0x17FC8C0 VA: 0x1817FE2C0
	public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) { }

}

