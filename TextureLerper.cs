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

	// RVA: 0x11E5D50 Offset: 0x11E4350 VA: 0x1811E5D50
	internal static TextureLerper get_instance() { }

	// RVA: 0x11E5CB0 Offset: 0x11E42B0 VA: 0x1811E5CB0
	private void .ctor() { }

	// RVA: 0x11E4250 Offset: 0x11E2850 VA: 0x1811E4250
	internal void BeginFrame(PostProcessRenderContext context) { }

	// RVA: 0x11E4510 Offset: 0x11E2B10 VA: 0x1811E4510
	internal void EndFrame() { }

	// RVA: 0x11E47A0 Offset: 0x11E2DA0 VA: 0x1811E47A0
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = False, bool force3D = False) { }

	// RVA: 0x11E5310 Offset: 0x11E3910 VA: 0x1811E5310
	internal Texture Lerp(Texture from, Texture to, float t) { }

	// RVA: 0x11E4A50 Offset: 0x11E3050 VA: 0x1811E4A50
	internal Texture Lerp(Texture from, Color to, float t) { }

	// RVA: 0x11E42B0 Offset: 0x11E28B0 VA: 0x1811E42B0
	internal void Clear() { }

}

