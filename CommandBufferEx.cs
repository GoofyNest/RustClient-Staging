public static class CommandBufferEx // TypeDefIndex: 10700
{
	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void BlitArray(CommandBuffer cb, Mesh blitMesh, RenderTargetIdentifier source, Material mat, int slice, int pass = 0) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void BlitArray(CommandBuffer cb, Mesh blitMesh, RenderTargetIdentifier source, Texture target, Material mat, int slice, int pass = 0) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void BlitArrayMip(CommandBuffer cb, Mesh blitMesh, Texture source, int sourceMip, int sourceSlice, Texture target, int targetMip, int targetSlice, Material mat, int pass = 0) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void BlitMip(CommandBuffer cb, Mesh blitMesh, Texture source, Texture target, int mip, int slice, Material mat, int pass = 0) { }

}

