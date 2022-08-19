internal class GUILayoutEntry // TypeDefIndex: 4053
{	// Fields
	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

	// Properties
	public GUIStyle style { get; set; }
	public virtual int marginLeft { get; }
	public virtual int marginRight { get; }
	public virtual int marginTop { get; }
	public virtual int marginBottom { get; }
	public int marginHorizontal { get; }
	public int marginVertical { get; }

	// Methods

	// RVA: 0x1A6D9D0 Offset: 0x1A6BFD0 VA: 0x181A6D9D0
	public GUIStyle get_style() { }

	// RVA: 0x1A6D9E0 Offset: 0x1A6BFE0 VA: 0x181A6D9E0
	public void set_style(GUIStyle value) { }

	// RVA: 0x1A6D900 Offset: 0x1A6BF00 VA: 0x181A6D900 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x1A6D930 Offset: 0x1A6BF30 VA: 0x181A6D930 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x1A6D960 Offset: 0x1A6BF60 VA: 0x181A6D960 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x1A6D890 Offset: 0x1A6BE90 VA: 0x181A6D890 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x1A6D8C0 Offset: 0x1A6BEC0 VA: 0x181A6D8C0
	public int get_marginHorizontal() { }

	// RVA: 0x1A6D990 Offset: 0x1A6BF90 VA: 0x181A6D990
	public int get_marginVertical() { }

	// RVA: 0x1A6D730 Offset: 0x1A6BD30 VA: 0x181A6D730
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x1A6D5E0 Offset: 0x1A6BBE0 VA: 0x181A6D5E0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x1A6CBE0 Offset: 0x1A6B1E0 VA: 0x181A6CBE0 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x1A6CC20 Offset: 0x1A6B220 VA: 0x181A6CC20 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x1A6CAD0 Offset: 0x1A6B0D0 VA: 0x181A6CAD0 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1A6C730 Offset: 0x1A6AD30 VA: 0x181A6C730 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1A6CC60 Offset: 0x1A6B260 VA: 0x181A6CC60 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A6D560 Offset: 0x1A6BB60 VA: 0x181A6D560
	private static void .cctor() { }

}

