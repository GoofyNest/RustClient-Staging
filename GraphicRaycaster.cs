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

	// RVA: 0x15ECB20 Offset: 0x15EB120 VA: 0x1815ECB20 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x15ECAC0 Offset: 0x15EB0C0 VA: 0x1815ECAC0 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	// RVA: 0x7D0D70 Offset: 0x7CF370 VA: 0x1807D0D70
	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	// RVA: 0x15EC840 Offset: 0x15EAE40 VA: 0x1815EC840
	protected void .ctor() { }

	// RVA: 0x15EC8C0 Offset: 0x15EAEC0 VA: 0x1815EC8C0
	private Canvas get_canvas() { }

	// RVA: 0x15EB0F0 Offset: 0x15E96F0 VA: 0x1815EB0F0 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x15EC960 Offset: 0x15EAF60 VA: 0x1815EC960 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x15EC320 Offset: 0x15EA920 VA: 0x1815EC320
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	// RVA: 0x15EC7E0 Offset: 0x15EADE0 VA: 0x1815EC7E0
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

	// RVA: 0x1605030 Offset: 0x1603630 VA: 0x181605030
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1604FB0 Offset: 0x16035B0 VA: 0x181604FB0
	internal int <Raycast>b__24_0(Graphic g1, Graphic g2) { }

}

