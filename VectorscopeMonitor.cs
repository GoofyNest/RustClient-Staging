public sealed class VectorscopeMonitor : Monitor // TypeDefIndex: 11822
{	// Fields
	public int size; // 0x20
	public float exposure; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x11EA930 Offset: 0x11E8F30 VA: 0x1811EA930 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x11EAFD0 Offset: 0x11E95D0 VA: 0x1811EAFD0 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x11EA970 Offset: 0x11E8F70 VA: 0x1811EA970 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x11EB050 Offset: 0x11E9650 VA: 0x1811EB050
	public void .ctor() { }

}

