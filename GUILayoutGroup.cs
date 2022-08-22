internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 4055
{	// Fields
	public List<GUILayoutEntry> entries; // 0x48
	public bool isVertical; // 0x50
	public bool resetCoords; // 0x51
	public float spacing; // 0x54
	public bool sameSize; // 0x58
	public bool isWindow; // 0x59
	public int windowID; // 0x5C
	private int m_Cursor; // 0x60
	protected int m_StretchableCountX; // 0x64
	protected int m_StretchableCountY; // 0x68
	protected bool m_UserSpecifiedWidth; // 0x6C
	protected bool m_UserSpecifiedHeight; // 0x6D
	protected float m_ChildMinWidth; // 0x70
	protected float m_ChildMaxWidth; // 0x74
	protected float m_ChildMinHeight; // 0x78
	protected float m_ChildMaxHeight; // 0x7C
	protected int m_MarginLeft; // 0x80
	protected int m_MarginRight; // 0x84
	protected int m_MarginTop; // 0x88
	protected int m_MarginBottom; // 0x8C

	// Properties
	public override int marginLeft { get; }
	public override int marginRight { get; }
	public override int marginTop { get; }
	public override int marginBottom { get; }

	// Methods

	// RVA: 0x5828D0 Offset: 0x580ED0 VA: 0x1805828D0 Slot: 4
	public override int get_marginLeft() { }

	// RVA: 0x79BE30 Offset: 0x79A430 VA: 0x18079BE30 Slot: 5
	public override int get_marginRight() { }

	// RVA: 0x58AC00 Offset: 0x589200 VA: 0x18058AC00 Slot: 6
	public override int get_marginTop() { }

	// RVA: 0x107ABC0 Offset: 0x10791C0 VA: 0x18107ABC0 Slot: 7
	public override int get_marginBottom() { }

	// RVA: 0x1A5CE00 Offset: 0x1A5B400 VA: 0x181A5CE00
	public void .ctor() { }

	// RVA: 0x1A5A230 Offset: 0x1A58830 VA: 0x181A5A230 Slot: 13
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1A5A350 Offset: 0x1A58950 VA: 0x181A5A350 Slot: 12
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1A5B720 Offset: 0x1A59D20 VA: 0x181A5B720
	public void ResetCursor() { }

	// RVA: 0x1A5B4C0 Offset: 0x1A59AC0 VA: 0x181A5B4C0
	public GUILayoutEntry GetNext() { }

	// RVA: 0x1A5A1D0 Offset: 0x1A587D0 VA: 0x181A5A1D0
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x1A5AC80 Offset: 0x1A59280 VA: 0x181A5AC80 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x1A5B730 Offset: 0x1A59D30 VA: 0x181A5B730 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1A5A4C0 Offset: 0x1A58AC0 VA: 0x181A5A4C0 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x1A5C040 Offset: 0x1A5A640 VA: 0x181A5C040 Slot: 11
	public override void SetVertical(float y, float height) { }

	// RVA: 0x1A5C970 Offset: 0x1A5AF70 VA: 0x181A5C970 Slot: 3
	public override string ToString() { }

}

