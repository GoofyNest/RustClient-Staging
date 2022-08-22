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

	// RVA: 0x15EC860 Offset: 0x15EAE60 VA: 0x1815EC860 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x15EC800 Offset: 0x15EAE00 VA: 0x1815EC800 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	// RVA: 0x7D0C60 Offset: 0x7CF260 VA: 0x1807D0C60
	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	// RVA: 0x15EC580 Offset: 0x15EAB80 VA: 0x1815EC580
	protected void .ctor() { }

	// RVA: 0x15EC600 Offset: 0x15EAC00 VA: 0x1815EC600
	private Canvas get_canvas() { }

	// RVA: 0x15EAE30 Offset: 0x15E9430 VA: 0x1815EAE30 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x15EC6A0 Offset: 0x15EACA0 VA: 0x1815EC6A0 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x15EC060 Offset: 0x15EA660 VA: 0x1815EC060
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	// RVA: 0x15EC520 Offset: 0x15EAB20 VA: 0x1815EC520
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

	// RVA: 0x1604D70 Offset: 0x1603370 VA: 0x181604D70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1604CF0 Offset: 0x16032F0 VA: 0x181604CF0
	internal int <Raycast>b__24_0(Graphic g1, Graphic g2) { }

}

