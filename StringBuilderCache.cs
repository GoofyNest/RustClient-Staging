internal static class StringBuilderCache // TypeDefIndex: 464
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static StringBuilder CachedInstance; // 0x80000000

	// Methods

	// RVA: 0x191F810 Offset: 0x191DE10 VA: 0x18191F810
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x191F9B0 Offset: 0x191DFB0 VA: 0x18191F9B0
	public static void Release(StringBuilder sb) { }

	// RVA: 0x191F920 Offset: 0x191DF20 VA: 0x18191F920
	public static string GetStringAndRelease(StringBuilder sb) { }

}

