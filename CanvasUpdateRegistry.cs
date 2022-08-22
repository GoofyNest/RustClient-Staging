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

	// RVA: 0x10B9610 Offset: 0x10B7C10 VA: 0x1810B9610
	protected void .ctor() { }

	// RVA: 0x10B96E0 Offset: 0x10B7CE0 VA: 0x1810B96E0
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x10B8870 Offset: 0x10B6E70 VA: 0x1810B8870
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x10B82F0 Offset: 0x10B68F0 VA: 0x1810B82F0
	private void CleanInvalidItems() { }

	// RVA: 0x10B8A40 Offset: 0x10B7040 VA: 0x1810B8A40
	private void PerformUpdate() { }

	// RVA: 0x10B8970 Offset: 0x10B6F70 VA: 0x1810B8970
	private static int ParentCount(Transform child) { }

	// RVA: 0x10B9200 Offset: 0x10B7800 VA: 0x1810B9200
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x10B9190 Offset: 0x10B7790 VA: 0x1810B9190
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B9320 Offset: 0x10B7920 VA: 0x1810B9320
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B8550 Offset: 0x10B6B50 VA: 0x1810B8550
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B9120 Offset: 0x10B7720 VA: 0x1810B9120
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B92B0 Offset: 0x10B78B0 VA: 0x1810B92B0
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B84A0 Offset: 0x10B6AA0 VA: 0x1810B84A0
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B9390 Offset: 0x10B7990 VA: 0x1810B9390
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x10B86C0 Offset: 0x10B6CC0 VA: 0x1810B86C0
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B85D0 Offset: 0x10B6BD0 VA: 0x1810B85D0
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B8810 Offset: 0x10B6E10 VA: 0x1810B8810
	public static bool IsRebuildingLayout() { }

	// RVA: 0x10B87B0 Offset: 0x10B6DB0 VA: 0x1810B87B0
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x10B95A0 Offset: 0x10B7BA0 VA: 0x1810B95A0
	private static void .cctor() { }

}

