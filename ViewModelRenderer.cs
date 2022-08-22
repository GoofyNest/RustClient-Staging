public class ViewModelRenderer : MonoBehaviour // TypeDefIndex: 11453
{	// Fields
	public List<Texture2D> cachedTextureRefs; // 0x18
	public List<ViewModelDrawEvent> opaqueEvents; // 0x20
	public List<ViewModelDrawEvent> transparentEvents; // 0x28
	public Matrix4x4 prevModelMatrix; // 0x30
	private Renderer viewModelRenderer; // 0x70

	// Methods

	// RVA: 0x7F5A00 Offset: 0x7F4000 VA: 0x1807F5A00
	private void OnEnable() { }

	// RVA: 0x7F59F0 Offset: 0x7F3FF0 VA: 0x1807F59F0
	private void OnDisable() { }

	// RVA: 0x7F4440 Offset: 0x7F2A40 VA: 0x1807F4440
	public void AddDrawEvents() { }

	// RVA: 0x7F5A10 Offset: 0x7F4010 VA: 0x1807F5A10
	public void RemoveDrawEvents() { }

	[ContextMenu] // RVA: 0xB0AD0 Offset: 0xAFED0 VA: 0x1800B0AD0
	[ButtonAttribute] // RVA: 0xB0AD0 Offset: 0xAFED0 VA: 0x1800B0AD0
	// RVA: 0x7F4770 Offset: 0x7F2D70 VA: 0x1807F4770
	public void CacheReferences() { }

	// RVA: 0x7F5230 Offset: 0x7F3830 VA: 0x1807F5230
	private void CacheTextures() { }

	// RVA: 0x7F55D0 Offset: 0x7F3BD0 VA: 0x1807F55D0
	private void DisableTextureStreaming() { }

	// RVA: 0x7F56F0 Offset: 0x7F3CF0 VA: 0x1807F56F0
	private void EnableTextureStreaming() { }

	// RVA: 0x7F5810 Offset: 0x7F3E10 VA: 0x1807F5810
	public static int FindPassWithLightMode(Material material, string lightMode) { }

	// RVA: 0x7F5900 Offset: 0x7F3F00 VA: 0x1807F5900
	public static int FindPassWithRenderType(Material material, string renderType) { }

	// RVA: 0x7F5490 Offset: 0x7F3A90 VA: 0x1807F5490
	public static RenderType CategorizeMaterial(Material material, out int pass, out int grabPass) { }

	// RVA: 0x7F5DF0 Offset: 0x7F43F0 VA: 0x1807F5DF0
	public void .ctor() { }

}

private sealed class ViewModelRenderer.<>c // TypeDefIndex: 11454
{	// Fields
	public static readonly ViewModelRenderer.<>c <>9; // 0x0
	public static Comparison<ViewModelDrawEvent> <>9__9_0; // 0x8
	public static Comparison<ViewModelDrawEvent> <>9__9_1; // 0x10

	// Methods

	// RVA: 0x7F06A0 Offset: 0x7EECA0 VA: 0x1807F06A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7F04C0 Offset: 0x7EEAC0 VA: 0x1807F04C0
	internal int <CacheReferences>b__9_0(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

	// RVA: 0x7F04C0 Offset: 0x7EEAC0 VA: 0x1807F04C0
	internal int <CacheReferences>b__9_1(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

}

