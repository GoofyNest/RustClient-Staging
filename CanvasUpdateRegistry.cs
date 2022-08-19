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

	// RVA: 0x10B9350 Offset: 0x10B7950 VA: 0x1810B9350
	protected void .ctor() { }

	// RVA: 0x10B9420 Offset: 0x10B7A20 VA: 0x1810B9420
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x10B85B0 Offset: 0x10B6BB0 VA: 0x1810B85B0
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x10B8030 Offset: 0x10B6630 VA: 0x1810B8030
	private void CleanInvalidItems() { }

	// RVA: 0x10B8780 Offset: 0x10B6D80 VA: 0x1810B8780
	private void PerformUpdate() { }

	// RVA: 0x10B86B0 Offset: 0x10B6CB0 VA: 0x1810B86B0
	private static int ParentCount(Transform child) { }

	// RVA: 0x10B8F40 Offset: 0x10B7540 VA: 0x1810B8F40
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x10B8ED0 Offset: 0x10B74D0 VA: 0x1810B8ED0
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B9060 Offset: 0x10B7660 VA: 0x1810B9060
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B8290 Offset: 0x10B6890 VA: 0x1810B8290
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B8E60 Offset: 0x10B7460 VA: 0x1810B8E60
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B8FF0 Offset: 0x10B75F0 VA: 0x1810B8FF0
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B81E0 Offset: 0x10B67E0 VA: 0x1810B81E0
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B90D0 Offset: 0x10B76D0 VA: 0x1810B90D0
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x10B8400 Offset: 0x10B6A00 VA: 0x1810B8400
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B8310 Offset: 0x10B6910 VA: 0x1810B8310
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B8550 Offset: 0x10B6B50 VA: 0x1810B8550
	public static bool IsRebuildingLayout() { }

	// RVA: 0x10B84F0 Offset: 0x10B6AF0 VA: 0x1810B84F0
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x10B92E0 Offset: 0x10B78E0 VA: 0x1810B92E0
	private static void .cctor() { }

}

