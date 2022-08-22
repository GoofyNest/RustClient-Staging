public class ViewModelRenderer : MonoBehaviour // TypeDefIndex: 11453
{	// Fields
	public List<Texture2D> cachedTextureRefs; // 0x18
	public List<ViewModelDrawEvent> opaqueEvents; // 0x20
	public List<ViewModelDrawEvent> transparentEvents; // 0x28
	public Matrix4x4 prevModelMatrix; // 0x30
	private Renderer viewModelRenderer; // 0x70

	// Methods

	// RVA: 0x7F5360 Offset: 0x7F3960 VA: 0x1807F5360
	private void OnEnable() { }

	// RVA: 0x7F5350 Offset: 0x7F3950 VA: 0x1807F5350
	private void OnDisable() { }

	// RVA: 0x7F3DA0 Offset: 0x7F23A0 VA: 0x1807F3DA0
	public void AddDrawEvents() { }

	// RVA: 0x7F5370 Offset: 0x7F3970 VA: 0x1807F5370
	public void RemoveDrawEvents() { }

	[ContextMenu] // RVA: 0xB0AD0 Offset: 0xAFED0 VA: 0x1800B0AD0
	[ButtonAttribute] // RVA: 0xB0AD0 Offset: 0xAFED0 VA: 0x1800B0AD0
	// RVA: 0x7F40D0 Offset: 0x7F26D0 VA: 0x1807F40D0
	public void CacheReferences() { }

	// RVA: 0x7F4B90 Offset: 0x7F3190 VA: 0x1807F4B90
	private void CacheTextures() { }

	// RVA: 0x7F4F30 Offset: 0x7F3530 VA: 0x1807F4F30
	private void DisableTextureStreaming() { }

	// RVA: 0x7F5050 Offset: 0x7F3650 VA: 0x1807F5050
	private void EnableTextureStreaming() { }

	// RVA: 0x7F5170 Offset: 0x7F3770 VA: 0x1807F5170
	public static int FindPassWithLightMode(Material material, string lightMode) { }

	// RVA: 0x7F5260 Offset: 0x7F3860 VA: 0x1807F5260
	public static int FindPassWithRenderType(Material material, string renderType) { }

	// RVA: 0x7F4DF0 Offset: 0x7F33F0 VA: 0x1807F4DF0
	public static RenderType CategorizeMaterial(Material material, out int pass, out int grabPass) { }

	// RVA: 0x7F5750 Offset: 0x7F3D50 VA: 0x1807F5750
	public void .ctor() { }

}

private sealed class ViewModelRenderer.<>c // TypeDefIndex: 11454
{	// Fields
	public static readonly ViewModelRenderer.<>c <>9; // 0x0
	public static Comparison<ViewModelDrawEvent> <>9__9_0; // 0x8
	public static Comparison<ViewModelDrawEvent> <>9__9_1; // 0x10

	// Methods

	// RVA: 0x7F0000 Offset: 0x7EE600 VA: 0x1807F0000
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7EFE20 Offset: 0x7EE420 VA: 0x1807EFE20
	internal int <CacheReferences>b__9_0(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

	// RVA: 0x7EFE20 Offset: 0x7EE420 VA: 0x1807EFE20
	internal int <CacheReferences>b__9_1(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

}

