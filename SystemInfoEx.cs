public static class SystemInfoEx // TypeDefIndex: 9291
{	// Fields
	private static bool[] supportedRenderTextureFormats; // 0x1CE0

	// Properties
	public static int systemMemoryUsed { get; }

	// Methods

	// RVA: 0x7A7560 Offset: 0x7A5B60 VA: 0x1807A7560
	private static extern ulong System_GetMemoryUsage() { }

	// RVA: 0x7A75D0 Offset: 0x7A5BD0 VA: 0x1807A75D0
	public static int get_systemMemoryUsed() { }

	// RVA: 0x7A7280 Offset: 0x7A5880 VA: 0x1807A7280
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

