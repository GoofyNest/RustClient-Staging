internal static class Platform // TypeDefIndex: 2597
{	// Fields
	private static bool checkedOS; // 0x0
	private static bool isMacOS; // 0x1
	private static bool isFreeBSD; // 0x2

	// Properties
	public static bool IsMacOS { get; }

	// Methods

	// RVA: 0x117CBC0 Offset: 0x117B1C0 VA: 0x18117CBC0
	private static extern int uname(IntPtr buf) { }

	// RVA: 0x117C910 Offset: 0x117AF10 VA: 0x18117C910
	private static void CheckOS() { }

	// RVA: 0x117CB40 Offset: 0x117B140 VA: 0x18117CB40
	public static bool get_IsMacOS() { }

}

