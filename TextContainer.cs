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

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_hasChanged() { }

	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00
	public void set_hasChanged(bool value) { }

	// RVA: 0x1160340 Offset: 0x115E940 VA: 0x181160340
	public Vector2 get_pivot() { }

	// RVA: 0x11607F0 Offset: 0x115EDF0 VA: 0x1811607F0
	public void set_pivot(Vector2 value) { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public TextContainerAnchors get_anchorPosition() { }

	// RVA: 0x1160510 Offset: 0x115EB10 VA: 0x181160510
	public void set_anchorPosition(TextContainerAnchors value) { }

	// RVA: 0xB11220 Offset: 0xB0F820 VA: 0x180B11220
	public Rect get_rect() { }

	// RVA: 0x11608B0 Offset: 0x115EEB0 VA: 0x1811608B0
	public void set_rect(Rect value) { }

	// RVA: 0x1160400 Offset: 0x115EA00 VA: 0x181160400
	public Vector2 get_size() { }

	// RVA: 0x1160910 Offset: 0x115EF10 VA: 0x181160910
	public void set_size(Vector2 value) { }

	// RVA: 0x1160500 Offset: 0x115EB00 VA: 0x181160500
	public float get_width() { }

	// RVA: 0x1160A40 Offset: 0x115F040 VA: 0x181160A40
	public void set_width(float value) { }

	// RVA: 0x1160320 Offset: 0x115E920 VA: 0x181160320
	public float get_height() { }

	// RVA: 0x1160660 Offset: 0x115EC60 VA: 0x181160660
	public void set_height(float value) { }

	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_isDefaultWidth() { }

	// RVA: 0x8C1050 Offset: 0x8BF650 VA: 0x1808C1050
	public bool get_isDefaultHeight() { }

	// RVA: 0x1160330 Offset: 0x115E930 VA: 0x181160330
	public bool get_isAutoFitting() { }

	// RVA: 0x1160740 Offset: 0x115ED40 VA: 0x181160740
	public void set_isAutoFitting(bool value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Vector3[] get_corners() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public Vector3[] get_worldCorners() { }

	// RVA: 0x105DDA0 Offset: 0x105C3A0 VA: 0x18105DDA0
	public Vector4 get_margins() { }

	// RVA: 0x1160750 Offset: 0x115ED50 VA: 0x181160750
	public void set_margins(Vector4 value) { }

	// RVA: 0x1160360 Offset: 0x115E960 VA: 0x181160360
	public RectTransform get_rectTransform() { }

	// RVA: 0x1160460 Offset: 0x115EA60 VA: 0x181160460
	public TextMeshPro get_textMeshPro() { }

	// RVA: 0x115F3C0 Offset: 0x115D9C0 VA: 0x18115F3C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x115FAB0 Offset: 0x115E0B0 VA: 0x18115FAB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x115F8D0 Offset: 0x115DED0 VA: 0x18115F8D0
	private void OnContainerChanged() { }

	// RVA: 0x115FAC0 Offset: 0x115E0C0 VA: 0x18115FAC0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x115FE70 Offset: 0x115E470 VA: 0x18115FE70
	private void SetRect(Vector2 size) { }

	// RVA: 0x115FEF0 Offset: 0x115E4F0 VA: 0x18115FEF0
	private void UpdateCorners() { }

	// RVA: 0x115F7B0 Offset: 0x115DDB0 VA: 0x18115F7B0
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	// RVA: 0x115F460 Offset: 0x115DA60 VA: 0x18115F460
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	// RVA: 0x11602A0 Offset: 0x115E8A0 VA: 0x1811602A0
	public void .ctor() { }

	// RVA: 0x1160230 Offset: 0x115E830 VA: 0x181160230
	private static void .cctor() { }

}

