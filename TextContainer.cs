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

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_hasChanged() { }

	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010
	public void set_hasChanged(bool value) { }

	// RVA: 0x1161070 Offset: 0x115F670 VA: 0x181161070
	public Vector2 get_pivot() { }

	// RVA: 0x1161520 Offset: 0x115FB20 VA: 0x181161520
	public void set_pivot(Vector2 value) { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public TextContainerAnchors get_anchorPosition() { }

	// RVA: 0x1161240 Offset: 0x115F840 VA: 0x181161240
	public void set_anchorPosition(TextContainerAnchors value) { }

	// RVA: 0xB119B0 Offset: 0xB0FFB0 VA: 0x180B119B0
	public Rect get_rect() { }

	// RVA: 0x11615E0 Offset: 0x115FBE0 VA: 0x1811615E0
	public void set_rect(Rect value) { }

	// RVA: 0x1161130 Offset: 0x115F730 VA: 0x181161130
	public Vector2 get_size() { }

	// RVA: 0x1161640 Offset: 0x115FC40 VA: 0x181161640
	public void set_size(Vector2 value) { }

	// RVA: 0x1161230 Offset: 0x115F830 VA: 0x181161230
	public float get_width() { }

	// RVA: 0x1161770 Offset: 0x115FD70 VA: 0x181161770
	public void set_width(float value) { }

	// RVA: 0x1161050 Offset: 0x115F650 VA: 0x181161050
	public float get_height() { }

	// RVA: 0x1161390 Offset: 0x115F990 VA: 0x181161390
	public void set_height(float value) { }

	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_isDefaultWidth() { }

	// RVA: 0x8C1670 Offset: 0x8BFC70 VA: 0x1808C1670
	public bool get_isDefaultHeight() { }

	// RVA: 0x1161060 Offset: 0x115F660 VA: 0x181161060
	public bool get_isAutoFitting() { }

	// RVA: 0x1161470 Offset: 0x115FA70 VA: 0x181161470
	public void set_isAutoFitting(bool value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public Vector3[] get_corners() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public Vector3[] get_worldCorners() { }

	// RVA: 0x105EAD0 Offset: 0x105D0D0 VA: 0x18105EAD0
	public Vector4 get_margins() { }

	// RVA: 0x1161480 Offset: 0x115FA80 VA: 0x181161480
	public void set_margins(Vector4 value) { }

	// RVA: 0x1161090 Offset: 0x115F690 VA: 0x181161090
	public RectTransform get_rectTransform() { }

	// RVA: 0x1161190 Offset: 0x115F790 VA: 0x181161190
	public TextMeshPro get_textMeshPro() { }

	// RVA: 0x11600F0 Offset: 0x115E6F0 VA: 0x1811600F0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x11607E0 Offset: 0x115EDE0 VA: 0x1811607E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1160600 Offset: 0x115EC00 VA: 0x181160600
	private void OnContainerChanged() { }

	// RVA: 0x11607F0 Offset: 0x115EDF0 VA: 0x1811607F0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1160BA0 Offset: 0x115F1A0 VA: 0x181160BA0
	private void SetRect(Vector2 size) { }

	// RVA: 0x1160C20 Offset: 0x115F220 VA: 0x181160C20
	private void UpdateCorners() { }

	// RVA: 0x11604E0 Offset: 0x115EAE0 VA: 0x1811604E0
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	// RVA: 0x1160190 Offset: 0x115E790 VA: 0x181160190
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	// RVA: 0x1160FD0 Offset: 0x115F5D0 VA: 0x181160FD0
	public void .ctor() { }

	// RVA: 0x1160F60 Offset: 0x115F560 VA: 0x181160F60
	private static void .cctor() { }

}

