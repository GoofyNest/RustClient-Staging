internal static class Platform // TypeDefIndex: 2597
{	// Fields
	private static bool checkedOS; // 0x0
	private static bool isMacOS; // 0x1
	private static bool isFreeBSD; // 0x2

	// Properties
	public static bool IsMacOS { get; }

	// Methods

	// RVA: 0x11814E0 Offset: 0x117FAE0 VA: 0x1811814E0
	private static extern int uname(IntPtr buf) { }

	// RVA: 0x1181230 Offset: 0x117F830 VA: 0x181181230
	private static void CheckOS() { }

	// RVA: 0x1181460 Offset: 0x117FA60 VA: 0x181181460
	public static bool get_IsMacOS() { }

}

