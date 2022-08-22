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

	// RVA: 0x1A6DC50 Offset: 0x1A6C250 VA: 0x181A6DC50
	public GUIStyle get_style() { }

	// RVA: 0x1A6DC60 Offset: 0x1A6C260 VA: 0x181A6DC60
	public void set_style(GUIStyle value) { }

	// RVA: 0x1A6DB80 Offset: 0x1A6C180 VA: 0x181A6DB80 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x1A6DBB0 Offset: 0x1A6C1B0 VA: 0x181A6DBB0 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x1A6DBE0 Offset: 0x1A6C1E0 VA: 0x181A6DBE0 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x1A6DB10 Offset: 0x1A6C110 VA: 0x181A6DB10 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x1A6DB40 Offset: 0x1A6C140 VA: 0x181A6DB40
	public int get_marginHorizontal() { }

	// RVA: 0x1A6DC10 Offset: 0x1A6C210 VA: 0x181A6DC10
	public int get_marginVertical() { }

	// RVA: 0x1A6D9B0 Offset: 0x1A6BFB0 VA: 0x181A6D9B0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x1A6D860 Offset: 0x1A6BE60 VA: 0x181A6D860
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x1A6CE60 Offset: 0x1A6B460 VA: 0x181A6CE60 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x1A6CEA0 Offset: 0x1A6B4A0 VA: 0x181A6CEA0 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x1A6CD50 Offset: 0x1A6B350 VA: 0x181A6CD50 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1A6C9B0 Offset: 0x1A6AFB0 VA: 0x181A6C9B0 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1A6CEE0 Offset: 0x1A6B4E0 VA: 0x181A6CEE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A6D7E0 Offset: 0x1A6BDE0 VA: 0x181A6D7E0
	private static void .cctor() { }

}

