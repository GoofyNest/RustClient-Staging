internal static class NativeNetProtect // TypeDefIndex: 7154
{	// Fields
	private static IntPtr Instance; // 0x128D0

	// Methods

	// RVA: 0x22E6BF0 Offset: 0x22E51F0 VA: 0x1822E6BF0
	private static extern uint dotProtectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

	// RVA: 0x22E6CB0 Offset: 0x22E52B0 VA: 0x1822E6CB0
	private static extern uint dotUnprotectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

	// RVA: 0x22E6B60 Offset: 0x22E5160 VA: 0x1822E6B60
	private static extern uint dotGetProtectMessageOutputLength(IntPtr Instance, uint InputLength) { }

	// RVA: 0x22E6790 Offset: 0x22E4D90 VA: 0x1822E6790
	public static void SetInstance(IntPtr NetProtectInstance) { }

	// RVA: 0x22E63D0 Offset: 0x22E49D0 VA: 0x1822E63D0
	public static bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E67F0 Offset: 0x22E4DF0 VA: 0x1822E67F0
	public static bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E6B20 Offset: 0x22E5120 VA: 0x1822E6B20
	private static void .cctor() { }

}

