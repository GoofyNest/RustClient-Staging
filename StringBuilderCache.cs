internal static class StringBuilderCache // TypeDefIndex: 464
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static StringBuilder CachedInstance; // 0x80000000

	// Methods

	// RVA: 0x191F7D0 Offset: 0x191DDD0 VA: 0x18191F7D0
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x191F970 Offset: 0x191DF70 VA: 0x18191F970
	public static void Release(StringBuilder sb) { }

	// RVA: 0x191F8E0 Offset: 0x191DEE0 VA: 0x18191F8E0
	public static string GetStringAndRelease(StringBuilder sb) { }

}

