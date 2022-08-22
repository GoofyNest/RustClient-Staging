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

	// RVA: 0x1A6D990 Offset: 0x1A6BF90 VA: 0x181A6D990
	public GUIStyle get_style() { }

	// RVA: 0x1A6D9A0 Offset: 0x1A6BFA0 VA: 0x181A6D9A0
	public void set_style(GUIStyle value) { }

	// RVA: 0x1A6D8C0 Offset: 0x1A6BEC0 VA: 0x181A6D8C0 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x1A6D8F0 Offset: 0x1A6BEF0 VA: 0x181A6D8F0 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x1A6D920 Offset: 0x1A6BF20 VA: 0x181A6D920 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x1A6D850 Offset: 0x1A6BE50 VA: 0x181A6D850 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x1A6D880 Offset: 0x1A6BE80 VA: 0x181A6D880
	public int get_marginHorizontal() { }

	// RVA: 0x1A6D950 Offset: 0x1A6BF50 VA: 0x181A6D950
	public int get_marginVertical() { }

	// RVA: 0x1A6D6F0 Offset: 0x1A6BCF0 VA: 0x181A6D6F0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x1A6D5A0 Offset: 0x1A6BBA0 VA: 0x181A6D5A0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x1A6CBA0 Offset: 0x1A6B1A0 VA: 0x181A6CBA0 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x1A6CBE0 Offset: 0x1A6B1E0 VA: 0x181A6CBE0 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x1A6CA90 Offset: 0x1A6B090 VA: 0x181A6CA90 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1A6C6F0 Offset: 0x1A6ACF0 VA: 0x181A6C6F0 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1A6CC20 Offset: 0x1A6B220 VA: 0x181A6CC20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A6D520 Offset: 0x1A6BB20 VA: 0x181A6D520
	private static void .cctor() { }

}

