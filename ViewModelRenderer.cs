public class ViewModelRenderer : MonoBehaviour // TypeDefIndex: 11457
{	public List<Texture2D> cachedTextureRefs; // 0x18
	public List<ViewModelDrawEvent> opaqueEvents; // 0x20
	public List<ViewModelDrawEvent> transparentEvents; // 0x28
	public Matrix4x4 prevModelMatrix; // 0x30
	private Renderer viewModelRenderer; // 0x70


	private void OnEnable() { }

	private void OnDisable() { }

	public void AddDrawEvents() { }

	public void RemoveDrawEvents() { }

	[ContextMenu] // RVA: 0xB0920 Offset: 0xAFD20 VA: 0x1800B0920
	[ButtonAttribute] // RVA: 0xB0920 Offset: 0xAFD20 VA: 0x1800B0920
	public void CacheReferences() { }

	private void CacheTextures() { }

	private void DisableTextureStreaming() { }

	private void EnableTextureStreaming() { }

	public static int FindPassWithLightMode(Material material, string lightMode) { }

	public static int FindPassWithRenderType(Material material, string renderType) { }

	public static RenderType CategorizeMaterial(Material material, out int pass, out int grabPass) { }

	public void .ctor() { }

}

private sealed class ViewModelRenderer.<>c // TypeDefIndex: 11458
{	public static readonly ViewModelRenderer.<>c <>9; // 0x0
	public static Comparison<ViewModelDrawEvent> <>9__9_0; // 0x8
	public static Comparison<ViewModelDrawEvent> <>9__9_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal int <CacheReferences>b__9_0(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

	internal int <CacheReferences>b__9_1(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

}

