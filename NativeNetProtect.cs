internal static class NativeNetProtect // TypeDefIndex: 7154
{	// Fields
	private static IntPtr Instance; // 0x128D0

	// Methods

	// RVA: 0x22E6A30 Offset: 0x22E5030 VA: 0x1822E6A30
	private static extern uint dotProtectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

	// RVA: 0x22E6AF0 Offset: 0x22E50F0 VA: 0x1822E6AF0
	private static extern uint dotUnprotectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

	// RVA: 0x22E69A0 Offset: 0x22E4FA0 VA: 0x1822E69A0
	private static extern uint dotGetProtectMessageOutputLength(IntPtr Instance, uint InputLength) { }

	// RVA: 0x22E65D0 Offset: 0x22E4BD0 VA: 0x1822E65D0
	public static void SetInstance(IntPtr NetProtectInstance) { }

	// RVA: 0x22E6210 Offset: 0x22E4810 VA: 0x1822E6210
	public static bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E6630 Offset: 0x22E4C30 VA: 0x1822E6630
	public static bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E6960 Offset: 0x22E4F60 VA: 0x1822E6960
	private static void .cctor() { }

}

