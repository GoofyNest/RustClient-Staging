internal static class StringBuilderCache // TypeDefIndex: 464
{	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static StringBuilder CachedInstance; // 0x80000000


	public static StringBuilder Acquire(int capacity = 16) { }

	public static void Release(StringBuilder sb) { }

	public static string GetStringAndRelease(StringBuilder sb) { }

}

