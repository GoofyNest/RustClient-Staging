internal static class StringBuilderCache // TypeDefIndex: 464
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static StringBuilder CachedInstance; // 0x80000000

	// Methods

	// RVA: 0x191F1B0 Offset: 0x191D7B0 VA: 0x18191F1B0
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x191F350 Offset: 0x191D950 VA: 0x18191F350
	public static void Release(StringBuilder sb) { }

	// RVA: 0x191F2C0 Offset: 0x191D8C0 VA: 0x18191F2C0
	public static string GetStringAndRelease(StringBuilder sb) { }

}

