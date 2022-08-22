public sealed class WaveformMonitor : Monitor // TypeDefIndex: 11823
{	// Fields
	public float exposure; // 0x20
	public int height; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSize = 256;
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x11EAFD0 Offset: 0x11E95D0 VA: 0x1811EAFD0 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x11EC750 Offset: 0x11EAD50 VA: 0x1811EC750 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x11EBF70 Offset: 0x11EA570 VA: 0x1811EBF70 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x11EC7D0 Offset: 0x11EADD0 VA: 0x1811EC7D0
	public void .ctor() { }

}

