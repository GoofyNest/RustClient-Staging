internal static class NativeNetProtect // TypeDefIndex: 7154
{	// Fields
	private static IntPtr Instance; // 0x128D0

	// Methods

	// RVA: 0x22E6CF0 Offset: 0x22E52F0 VA: 0x1822E6CF0
	private static extern uint dotProtectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

	// RVA: 0x22E6DB0 Offset: 0x22E53B0 VA: 0x1822E6DB0
	private static extern uint dotUnprotectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

	// RVA: 0x22E6C60 Offset: 0x22E5260 VA: 0x1822E6C60
	private static extern uint dotGetProtectMessageOutputLength(IntPtr Instance, uint InputLength) { }

	// RVA: 0x22E6890 Offset: 0x22E4E90 VA: 0x1822E6890
	public static void SetInstance(IntPtr NetProtectInstance) { }

	// RVA: 0x22E64D0 Offset: 0x22E4AD0 VA: 0x1822E64D0
	public static bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E68F0 Offset: 0x22E4EF0 VA: 0x1822E68F0
	public static bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E6C20 Offset: 0x22E5220 VA: 0x1822E6C20
	private static void .cctor() { }

}

