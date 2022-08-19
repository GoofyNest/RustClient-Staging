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

	// RVA: 0x11E53F0 Offset: 0x11E39F0 VA: 0x1811E53F0
	internal static TextureLerper get_instance() { }

	// RVA: 0x11E5350 Offset: 0x11E3950 VA: 0x1811E5350
	private void .ctor() { }

	// RVA: 0x11E38F0 Offset: 0x11E1EF0 VA: 0x1811E38F0
	internal void BeginFrame(PostProcessRenderContext context) { }

	// RVA: 0x11E3BB0 Offset: 0x11E21B0 VA: 0x1811E3BB0
	internal void EndFrame() { }

	// RVA: 0x11E3E40 Offset: 0x11E2440 VA: 0x1811E3E40
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = False, bool force3D = False) { }

	// RVA: 0x11E49B0 Offset: 0x11E2FB0 VA: 0x1811E49B0
	internal Texture Lerp(Texture from, Texture to, float t) { }

	// RVA: 0x11E40F0 Offset: 0x11E26F0 VA: 0x1811E40F0
	internal Texture Lerp(Texture from, Color to, float t) { }

	// RVA: 0x11E3950 Offset: 0x11E1F50 VA: 0x1811E3950
	internal void Clear() { }

}

