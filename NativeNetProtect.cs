internal static class NativeNetProtect // TypeDefIndex: 7154
{	// Fields
	private static IntPtr Instance; // 0x2B10440

	// Methods

	// RVA: 0x22E7510 Offset: 0x22E5B10 VA: 0x1822E7510
	private static extern uint dotProtectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

	// RVA: 0x22E75D0 Offset: 0x22E5BD0 VA: 0x1822E75D0
	private static extern uint dotUnprotectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

	// RVA: 0x22E7480 Offset: 0x22E5A80 VA: 0x1822E7480
	private static extern uint dotGetProtectMessageOutputLength(IntPtr Instance, uint InputLength) { }

	// RVA: 0x22E70B0 Offset: 0x22E56B0 VA: 0x1822E70B0
	public static void SetInstance(IntPtr NetProtectInstance) { }

	// RVA: 0x22E6CF0 Offset: 0x22E52F0 VA: 0x1822E6CF0
	public static bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E7110 Offset: 0x22E5710 VA: 0x1822E7110
	public static bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E7440 Offset: 0x22E5A40 VA: 0x1822E7440
	private static void .cctor() { }

}

