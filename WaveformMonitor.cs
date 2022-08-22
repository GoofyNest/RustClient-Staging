public sealed class WaveformMonitor : Monitor // TypeDefIndex: 11823
{	// Fields
	public float exposure; // 0x20
	public int height; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSize = 256;
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x11EA930 Offset: 0x11E8F30 VA: 0x1811EA930 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x11EC0B0 Offset: 0x11EA6B0 VA: 0x1811EC0B0 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x11EB8D0 Offset: 0x11E9ED0 VA: 0x1811EB8D0 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x11EC130 Offset: 0x11EA730 VA: 0x1811EC130
	public void .ctor() { }

}

