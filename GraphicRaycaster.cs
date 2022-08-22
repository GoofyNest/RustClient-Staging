public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 4931
{	// Fields
	protected const int kNoEventMaskSet = -1;
	[FormerlySerializedAsAttribute] // RVA: 0xEC170 Offset: 0xEB570 VA: 0x1800EC170
	[SerializeField] // RVA: 0xEC170 Offset: 0xEB570 VA: 0x1800EC170
	private bool m_IgnoreReversedGraphics; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xEC290 Offset: 0xEB690 VA: 0x1800EC290
	[SerializeField] // RVA: 0xEC290 Offset: 0xEB690 VA: 0x1800EC290
	private GraphicRaycaster.BlockingObjects m_BlockingObjects; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected LayerMask m_BlockingMask; // 0x28
	private Canvas m_Canvas; // 0x30
	private List<Graphic> m_RaycastResults; // 0x38
	private static readonly List<Graphic> s_SortedGraphics; // 0x0

	// Properties
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public bool ignoreReversedGraphics { get; set; }
	public GraphicRaycaster.BlockingObjects blockingObjects { get; set; }
	private Canvas canvas { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x15D9E40 Offset: 0x15D8440 VA: 0x1815D9E40 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x15D9DE0 Offset: 0x15D83E0 VA: 0x1815D9DE0 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	// RVA: 0x79C690 Offset: 0x79AC90 VA: 0x18079C690
	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	// RVA: 0x15D9B60 Offset: 0x15D8160 VA: 0x1815D9B60
	protected void .ctor() { }

	// RVA: 0x15D9BE0 Offset: 0x15D81E0 VA: 0x1815D9BE0
	private Canvas get_canvas() { }

	// RVA: 0x15D8410 Offset: 0x15D6A10 VA: 0x1815D8410 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x15D9C80 Offset: 0x15D8280 VA: 0x1815D9C80 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x15D9640 Offset: 0x15D7C40 VA: 0x1815D9640
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	// RVA: 0x15D9B00 Offset: 0x15D8100 VA: 0x1815D9B00
	private static void .cctor() { }

}

public enum GraphicRaycaster.BlockingObjects // TypeDefIndex: 4932
{	// Fields
	public int value__; // 0x0
	public const GraphicRaycaster.BlockingObjects None = 0;
	public const GraphicRaycaster.BlockingObjects TwoD = 1;
	public const GraphicRaycaster.BlockingObjects ThreeD = 2;
	public const GraphicRaycaster.BlockingObjects All = 3;

}

private sealed class GraphicRaycaster.<>c // TypeDefIndex: 4933
{	// Fields
	public static readonly GraphicRaycaster.<>c <>9; // 0x0
	public static Comparison<Graphic> <>9__24_0; // 0x8

	// Methods

	// RVA: 0x15F2350 Offset: 0x15F0950 VA: 0x1815F2350
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x15F22D0 Offset: 0x15F08D0 VA: 0x1815F22D0
	internal int <Raycast>b__24_0(Graphic g1, Graphic g2) { }

}

