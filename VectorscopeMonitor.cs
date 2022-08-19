public sealed class VectorscopeMonitor : Monitor // TypeDefIndex: 11822
{	// Fields
	public int size; // 0x20
	public float exposure; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x11EA670 Offset: 0x11E8C70 VA: 0x1811EA670 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x11EAD10 Offset: 0x11E9310 VA: 0x1811EAD10 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x11EA6B0 Offset: 0x11E8CB0 VA: 0x1811EA6B0 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x11EAD90 Offset: 0x11E9390 VA: 0x1811EAD90
	public void .ctor() { }

}

