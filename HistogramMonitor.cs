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

	// RVA: 0x1017730 Offset: 0x1015D30 VA: 0x181017730 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x1017D90 Offset: 0x1016390 VA: 0x181017D90 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x10177C0 Offset: 0x1015DC0 VA: 0x1810177C0 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x1017E10 Offset: 0x1016410 VA: 0x181017E10
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

