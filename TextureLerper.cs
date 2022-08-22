internal class TextureLerper // TypeDefIndex: 11874
{	// Fields
	private static TextureLerper m_Instance; // 0x0
	private CommandBuffer m_Command; // 0x10
	private PropertySheetFactory m_PropertySheets; // 0x18
	private PostProcessResources m_Resources; // 0x20
	private List<RenderTexture> m_Recycled; // 0x28
	private List<RenderTexture> m_Actives; // 0x30

	// Properties
	internal static TextureLerper instance { get; }

	// Methods

	// RVA: 0x11E56B0 Offset: 0x11E3CB0 VA: 0x1811E56B0
	internal static TextureLerper get_instance() { }

	// RVA: 0x11E5610 Offset: 0x11E3C10 VA: 0x1811E5610
	private void .ctor() { }

	// RVA: 0x11E3BB0 Offset: 0x11E21B0 VA: 0x1811E3BB0
	internal void BeginFrame(PostProcessRenderContext context) { }

	// RVA: 0x11E3E70 Offset: 0x11E2470 VA: 0x1811E3E70
	internal void EndFrame() { }

	// RVA: 0x11E4100 Offset: 0x11E2700 VA: 0x1811E4100
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = False, bool force3D = False) { }

	// RVA: 0x11E4C70 Offset: 0x11E3270 VA: 0x1811E4C70
	internal Texture Lerp(Texture from, Texture to, float t) { }

	// RVA: 0x11E43B0 Offset: 0x11E29B0 VA: 0x1811E43B0
	internal Texture Lerp(Texture from, Color to, float t) { }

	// RVA: 0x11E3C10 Offset: 0x11E2210 VA: 0x1811E3C10
	internal void Clear() { }

}

