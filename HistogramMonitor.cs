public sealed class HistogramMonitor : Monitor // TypeDefIndex: 11817
{	// Fields
	public int width; // 0x20
	public int height; // 0x24
	public HistogramMonitor.Channel channel; // 0x28
	private ComputeBuffer m_Data; // 0x30
	private const int k_NumBins = 256;
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x10181D0 Offset: 0x10167D0 VA: 0x1810181D0 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x1018830 Offset: 0x1016E30 VA: 0x181018830 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x1018260 Offset: 0x1016860 VA: 0x181018260 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x10188B0 Offset: 0x1016EB0 VA: 0x1810188B0
	public void .ctor() { }

}

public enum HistogramMonitor.Channel // TypeDefIndex: 11818
{	// Fields
	public int value__; // 0x0
	public const HistogramMonitor.Channel Red = 0;
	public const HistogramMonitor.Channel Green = 1;
	public const HistogramMonitor.Channel Blue = 2;
	public const HistogramMonitor.Channel Master = 3;

}

