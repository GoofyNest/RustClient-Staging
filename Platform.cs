internal static class Platform // TypeDefIndex: 2597
{	// Fields
	private static bool checkedOS; // 0x0
	private static bool isMacOS; // 0x1
	private static bool isFreeBSD; // 0x2

	// Properties
	public static bool IsMacOS { get; }

	// Methods

	// RVA: 0x117C900 Offset: 0x117AF00 VA: 0x18117C900
	private static extern int uname(IntPtr buf) { }

	// RVA: 0x117C650 Offset: 0x117AC50 VA: 0x18117C650
	private static void CheckOS() { }

	// RVA: 0x117C880 Offset: 0x117AE80 VA: 0x18117C880
	public static bool get_IsMacOS() { }

}

