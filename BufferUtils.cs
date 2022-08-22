internal static class BufferUtils // TypeDefIndex: 5958
{
[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal static class BufferUtils // TypeDefIndex: 5958

	public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) { }

	public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) { }

	public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) { }

}

