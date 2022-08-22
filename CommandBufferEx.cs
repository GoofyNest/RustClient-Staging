public static class CommandBufferEx // TypeDefIndex: 10696
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57D140 Offset: 0x57B740 VA: 0x18057D140
	public static void BlitArray(CommandBuffer cb, Mesh blitMesh, RenderTargetIdentifier source, Material mat, int slice, int pass = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57CF70 Offset: 0x57B570 VA: 0x18057CF70
	public static void BlitArray(CommandBuffer cb, Mesh blitMesh, RenderTargetIdentifier source, Texture target, Material mat, int slice, int pass = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57CC40 Offset: 0x57B240 VA: 0x18057CC40
	public static void BlitArrayMip(CommandBuffer cb, Mesh blitMesh, Texture source, int sourceMip, int sourceSlice, Texture target, int targetMip, int targetSlice, Material mat, int pass = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57D2A0 Offset: 0x57B8A0 VA: 0x18057D2A0
	public static void BlitMip(CommandBuffer cb, Mesh blitMesh, Texture source, Texture target, int mip, int slice, Material mat, int pass = 0) { }

}

