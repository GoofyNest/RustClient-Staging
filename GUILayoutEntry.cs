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

	// RVA: 0x1A5A180 Offset: 0x1A58780 VA: 0x181A5A180
	public GUIStyle get_style() { }

	// RVA: 0x1A5A190 Offset: 0x1A58790 VA: 0x181A5A190
	public void set_style(GUIStyle value) { }

	// RVA: 0x1A5A0B0 Offset: 0x1A586B0 VA: 0x181A5A0B0 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x1A5A0E0 Offset: 0x1A586E0 VA: 0x181A5A0E0 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x1A5A110 Offset: 0x1A58710 VA: 0x181A5A110 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x1A5A040 Offset: 0x1A58640 VA: 0x181A5A040 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x1A5A070 Offset: 0x1A58670 VA: 0x181A5A070
	public int get_marginHorizontal() { }

	// RVA: 0x1A5A140 Offset: 0x1A58740 VA: 0x181A5A140
	public int get_marginVertical() { }

	// RVA: 0x1A59EE0 Offset: 0x1A584E0 VA: 0x181A59EE0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x1A59D90 Offset: 0x1A58390 VA: 0x181A59D90
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x1A59390 Offset: 0x1A57990 VA: 0x181A59390 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x1A593D0 Offset: 0x1A579D0 VA: 0x181A593D0 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x1A59280 Offset: 0x1A57880 VA: 0x181A59280 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1A58EE0 Offset: 0x1A574E0 VA: 0x181A58EE0 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1A59410 Offset: 0x1A57A10 VA: 0x181A59410 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A59D10 Offset: 0x1A58310 VA: 0x181A59D10
	private static void .cctor() { }

}

