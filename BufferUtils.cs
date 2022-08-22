internal static class BufferUtils // TypeDefIndex: 5958
{
// Namespace: Newtonsoft.Json.Utilities
[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal static class BufferUtils // TypeDefIndex: 5958
	// Methods

	// RVA: 0x17EBA60 Offset: 0x17EA060 VA: 0x1817EBA60
	public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) { }

	// RVA: 0x17EBAD0 Offset: 0x17EA0D0 VA: 0x1817EBAD0
	public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) { }

	// RVA: 0x17EB9C0 Offset: 0x17E9FC0 VA: 0x1817EB9C0
	public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) { }

}

