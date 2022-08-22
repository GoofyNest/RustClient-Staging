public static class SystemInfoEx // TypeDefIndex: 9291
{	// Fields
	private static bool[] supportedRenderTextureFormats; // 0x2B10368

	// Properties
	public static int systemMemoryUsed { get; }

	// Methods

	// RVA: 0x7C5A70 Offset: 0x7C4070 VA: 0x1807C5A70
	private static extern ulong System_GetMemoryUsage() { }

	// RVA: 0x7C5AE0 Offset: 0x7C40E0 VA: 0x1807C5AE0
	public static int get_systemMemoryUsed() { }

	// RVA: 0x7C5790 Offset: 0x7C3D90 VA: 0x1807C5790
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

