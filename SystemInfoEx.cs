public static class SystemInfoEx // TypeDefIndex: 9291
{	// Fields
	private static bool[] supportedRenderTextureFormats; // 0x1CE0

	// Properties
	public static int systemMemoryUsed { get; }

	// Methods

	// RVA: 0x7A7670 Offset: 0x7A5C70 VA: 0x1807A7670
	private static extern ulong System_GetMemoryUsage() { }

	// RVA: 0x7A76E0 Offset: 0x7A5CE0 VA: 0x1807A76E0
	public static int get_systemMemoryUsed() { }

	// RVA: 0x7A7390 Offset: 0x7A5990 VA: 0x1807A7390
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

