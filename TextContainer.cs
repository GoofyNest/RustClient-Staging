public class TextContainer : UIBehaviour // TypeDefIndex: 6869
{	// Fields
	private bool m_hasChanged; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 m_pivot; // 0x1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TextContainerAnchors m_anchorPosition; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Rect m_rect; // 0x28
	private bool m_isDefaultWidth; // 0x38
	private bool m_isDefaultHeight; // 0x39
	private bool m_isAutoFitting; // 0x3A
	private Vector3[] m_corners; // 0x40
	private Vector3[] m_worldCorners; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector4 m_margins; // 0x50
	private RectTransform m_rectTransform; // 0x60
	private static Vector2 k_defaultSize; // 0x0
	private TextMeshPro m_textMeshPro; // 0x68

	// Properties
	public bool hasChanged { get; set; }
	public Vector2 pivot { get; set; }
	public TextContainerAnchors anchorPosition { get; set; }
	public Rect rect { get; set; }
	public Vector2 size { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public bool isDefaultWidth { get; }
	public bool isDefaultHeight { get; }
	public bool isAutoFitting { get; set; }
	public Vector3[] corners { get; }
	public Vector3[] worldCorners { get; }
	public Vector4 margins { get; set; }
	public RectTransform rectTransform { get; }
	public TextMeshPro textMeshPro { get; }

	// Methods

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_hasChanged() { }

	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10
	public void set_hasChanged(bool value) { }

	// RVA: 0x1160600 Offset: 0x115EC00 VA: 0x181160600
	public Vector2 get_pivot() { }

	// RVA: 0x1160AB0 Offset: 0x115F0B0 VA: 0x181160AB0
	public void set_pivot(Vector2 value) { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public TextContainerAnchors get_anchorPosition() { }

	// RVA: 0x11607D0 Offset: 0x115EDD0 VA: 0x1811607D0
	public void set_anchorPosition(TextContainerAnchors value) { }

	// RVA: 0xB114E0 Offset: 0xB0FAE0 VA: 0x180B114E0
	public Rect get_rect() { }

	// RVA: 0x1160B70 Offset: 0x115F170 VA: 0x181160B70
	public void set_rect(Rect value) { }

	// RVA: 0x11606C0 Offset: 0x115ECC0 VA: 0x1811606C0
	public Vector2 get_size() { }

	// RVA: 0x1160BD0 Offset: 0x115F1D0 VA: 0x181160BD0
	public void set_size(Vector2 value) { }

	// RVA: 0x11607C0 Offset: 0x115EDC0 VA: 0x1811607C0
	public float get_width() { }

	// RVA: 0x1160D00 Offset: 0x115F300 VA: 0x181160D00
	public void set_width(float value) { }

	// RVA: 0x11605E0 Offset: 0x115EBE0 VA: 0x1811605E0
	public float get_height() { }

	// RVA: 0x1160920 Offset: 0x115EF20 VA: 0x181160920
	public void set_height(float value) { }

	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_isDefaultWidth() { }

	// RVA: 0x8C1160 Offset: 0x8BF760 VA: 0x1808C1160
	public bool get_isDefaultHeight() { }

	// RVA: 0x11605F0 Offset: 0x115EBF0 VA: 0x1811605F0
	public bool get_isAutoFitting() { }

	// RVA: 0x1160A00 Offset: 0x115F000 VA: 0x181160A00
	public void set_isAutoFitting(bool value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Vector3[] get_corners() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public Vector3[] get_worldCorners() { }

	// RVA: 0x105E060 Offset: 0x105C660 VA: 0x18105E060
	public Vector4 get_margins() { }

	// RVA: 0x1160A10 Offset: 0x115F010 VA: 0x181160A10
	public void set_margins(Vector4 value) { }

	// RVA: 0x1160620 Offset: 0x115EC20 VA: 0x181160620
	public RectTransform get_rectTransform() { }

	// RVA: 0x1160720 Offset: 0x115ED20 VA: 0x181160720
	public TextMeshPro get_textMeshPro() { }

	// RVA: 0x115F680 Offset: 0x115DC80 VA: 0x18115F680 Slot: 4
	protected override void Awake() { }

	// RVA: 0x115FD70 Offset: 0x115E370 VA: 0x18115FD70 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x115FB90 Offset: 0x115E190 VA: 0x18115FB90
	private void OnContainerChanged() { }

	// RVA: 0x115FD80 Offset: 0x115E380 VA: 0x18115FD80 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1160130 Offset: 0x115E730 VA: 0x181160130
	private void SetRect(Vector2 size) { }

	// RVA: 0x11601B0 Offset: 0x115E7B0 VA: 0x1811601B0
	private void UpdateCorners() { }

	// RVA: 0x115FA70 Offset: 0x115E070 VA: 0x18115FA70
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	// RVA: 0x115F720 Offset: 0x115DD20 VA: 0x18115F720
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	// RVA: 0x1160560 Offset: 0x115EB60 VA: 0x181160560
	public void .ctor() { }

	// RVA: 0x11604F0 Offset: 0x115EAF0 VA: 0x1811604F0
	private static void .cctor() { }

}

