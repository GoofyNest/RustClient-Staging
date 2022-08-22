public sealed class VectorscopeMonitor : Monitor // TypeDefIndex: 11822
{	// Fields
	public int size; // 0x20
	public float exposure; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x11EAFD0 Offset: 0x11E95D0 VA: 0x1811EAFD0 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x11EB670 Offset: 0x11E9C70 VA: 0x1811EB670 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x11EB010 Offset: 0x11E9610 VA: 0x1811EB010 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x11EB6F0 Offset: 0x11E9CF0 VA: 0x1811EB6F0
	public void .ctor() { }

}

