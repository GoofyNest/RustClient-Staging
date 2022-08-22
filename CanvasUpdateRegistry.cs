public class CanvasUpdateRegistry // TypeDefIndex: 4910
{	// Fields
	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x18
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x8

	// Properties
	public static CanvasUpdateRegistry instance { get; }

	// Methods

	// RVA: 0x10BA080 Offset: 0x10B8680 VA: 0x1810BA080
	protected void .ctor() { }

	// RVA: 0x10BA150 Offset: 0x10B8750 VA: 0x1810BA150
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x10B92E0 Offset: 0x10B78E0 VA: 0x1810B92E0
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x10B8D60 Offset: 0x10B7360 VA: 0x1810B8D60
	private void CleanInvalidItems() { }

	// RVA: 0x10B94B0 Offset: 0x10B7AB0 VA: 0x1810B94B0
	private void PerformUpdate() { }

	// RVA: 0x10B93E0 Offset: 0x10B79E0 VA: 0x1810B93E0
	private static int ParentCount(Transform child) { }

	// RVA: 0x10B9C70 Offset: 0x10B8270 VA: 0x1810B9C70
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x10B9C00 Offset: 0x10B8200 VA: 0x1810B9C00
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B9D90 Offset: 0x10B8390 VA: 0x1810B9D90
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B8FC0 Offset: 0x10B75C0 VA: 0x1810B8FC0
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B9B90 Offset: 0x10B8190 VA: 0x1810B9B90
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B9D20 Offset: 0x10B8320 VA: 0x1810B9D20
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B8F10 Offset: 0x10B7510 VA: 0x1810B8F10
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B9E00 Offset: 0x10B8400 VA: 0x1810B9E00
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x10B9130 Offset: 0x10B7730 VA: 0x1810B9130
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B9040 Offset: 0x10B7640 VA: 0x1810B9040
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B9280 Offset: 0x10B7880 VA: 0x1810B9280
	public static bool IsRebuildingLayout() { }

	// RVA: 0x10B9220 Offset: 0x10B7820 VA: 0x1810B9220
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x10BA010 Offset: 0x10B8610 VA: 0x1810BA010
	private static void .cctor() { }

}

