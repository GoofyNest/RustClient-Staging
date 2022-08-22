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

	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940 Slot: 4
	public override int get_marginLeft() { }

	// RVA: 0x10507D0 Offset: 0x104EDD0 VA: 0x1810507D0 Slot: 5
	public override int get_marginRight() { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70 Slot: 6
	public override int get_marginTop() { }

	// RVA: 0x107A150 Offset: 0x1078750 VA: 0x18107A150 Slot: 7
	public override int get_marginBottom() { }

	// RVA: 0x1A708D0 Offset: 0x1A6EED0 VA: 0x181A708D0
	public void .ctor() { }

	// RVA: 0x1A6DD00 Offset: 0x1A6C300 VA: 0x181A6DD00 Slot: 13
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1A6DE20 Offset: 0x1A6C420 VA: 0x181A6DE20 Slot: 12
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1A6F1F0 Offset: 0x1A6D7F0 VA: 0x181A6F1F0
	public void ResetCursor() { }

	// RVA: 0x1A6EF90 Offset: 0x1A6D590 VA: 0x181A6EF90
	public GUILayoutEntry GetNext() { }

	// RVA: 0x1A6DCA0 Offset: 0x1A6C2A0 VA: 0x181A6DCA0
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x1A6E750 Offset: 0x1A6CD50 VA: 0x181A6E750 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x1A6F200 Offset: 0x1A6D800 VA: 0x181A6F200 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1A6DF90 Offset: 0x1A6C590 VA: 0x181A6DF90 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x1A6FB10 Offset: 0x1A6E110 VA: 0x181A6FB10 Slot: 11
	public override void SetVertical(float y, float height) { }

	// RVA: 0x1A70440 Offset: 0x1A6EA40 VA: 0x181A70440 Slot: 3
	public override string ToString() { }

}

