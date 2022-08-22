public class ViewModelRenderer : MonoBehaviour // TypeDefIndex: 11453
{	// Fields
	public List<Texture2D> cachedTextureRefs; // 0x18
	public List<ViewModelDrawEvent> opaqueEvents; // 0x20
	public List<ViewModelDrawEvent> transparentEvents; // 0x28
	public Matrix4x4 prevModelMatrix; // 0x30
	private Renderer viewModelRenderer; // 0x70

	// Methods

	// RVA: 0x7F5470 Offset: 0x7F3A70 VA: 0x1807F5470
	private void OnEnable() { }

	// RVA: 0x7F5460 Offset: 0x7F3A60 VA: 0x1807F5460
	private void OnDisable() { }

	// RVA: 0x7F3EB0 Offset: 0x7F24B0 VA: 0x1807F3EB0
	public void AddDrawEvents() { }

	// RVA: 0x7F5480 Offset: 0x7F3A80 VA: 0x1807F5480
	public void RemoveDrawEvents() { }

	[ContextMenu] // RVA: 0xB0AD0 Offset: 0xAFED0 VA: 0x1800B0AD0
	[ButtonAttribute] // RVA: 0xB0AD0 Offset: 0xAFED0 VA: 0x1800B0AD0
	// RVA: 0x7F41E0 Offset: 0x7F27E0 VA: 0x1807F41E0
	public void CacheReferences() { }

	// RVA: 0x7F4CA0 Offset: 0x7F32A0 VA: 0x1807F4CA0
	private void CacheTextures() { }

	// RVA: 0x7F5040 Offset: 0x7F3640 VA: 0x1807F5040
	private void DisableTextureStreaming() { }

	// RVA: 0x7F5160 Offset: 0x7F3760 VA: 0x1807F5160
	private void EnableTextureStreaming() { }

	// RVA: 0x7F5280 Offset: 0x7F3880 VA: 0x1807F5280
	public static int FindPassWithLightMode(Material material, string lightMode) { }

	// RVA: 0x7F5370 Offset: 0x7F3970 VA: 0x1807F5370
	public static int FindPassWithRenderType(Material material, string renderType) { }

	// RVA: 0x7F4F00 Offset: 0x7F3500 VA: 0x1807F4F00
	public static RenderType CategorizeMaterial(Material material, out int pass, out int grabPass) { }

	// RVA: 0x7F5860 Offset: 0x7F3E60 VA: 0x1807F5860
	public void .ctor() { }

}

private sealed class ViewModelRenderer.<>c // TypeDefIndex: 11454
{	// Fields
	public static readonly ViewModelRenderer.<>c <>9; // 0x0
	public static Comparison<ViewModelDrawEvent> <>9__9_0; // 0x8
	public static Comparison<ViewModelDrawEvent> <>9__9_1; // 0x10

	// Methods

	// RVA: 0x7F0110 Offset: 0x7EE710 VA: 0x1807F0110
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7EFF30 Offset: 0x7EE530 VA: 0x1807EFF30
	internal int <CacheReferences>b__9_0(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

	// RVA: 0x7EFF30 Offset: 0x7EE530 VA: 0x1807EFF30
	internal int <CacheReferences>b__9_1(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

}

