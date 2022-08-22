internal static class StringBuilderCache // TypeDefIndex: 464
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static StringBuilder CachedInstance; // 0x80000000

	// Methods

	// RVA: 0x191FA90 Offset: 0x191E090 VA: 0x18191FA90
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x191FC30 Offset: 0x191E230 VA: 0x18191FC30
	public static void Release(StringBuilder sb) { }

	// RVA: 0x191FBA0 Offset: 0x191E1A0 VA: 0x18191FBA0
	public static string GetStringAndRelease(StringBuilder sb) { }

}

