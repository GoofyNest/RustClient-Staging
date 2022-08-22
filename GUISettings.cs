public sealed class GUISettings // TypeDefIndex: 4043
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_DoubleClickSelectsWord; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_TripleClickSelectsLine; // 0x11
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_CursorColor; // 0x14
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_CursorFlashSpeed; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_SelectionColor; // 0x28

	// Properties
	public bool doubleClickSelectsWord { get; }
	public bool tripleClickSelectsLine { get; }
	public Color cursorColor { get; }
	public float cursorFlashSpeed { get; }
	public Color selectionColor { get; }

	// Methods

	// RVA: 0x1A76870 Offset: 0x1A74E70 VA: 0x181A76870
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x1A76960 Offset: 0x1A74F60 VA: 0x181A76960
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x1A76980 Offset: 0x1A74F80 VA: 0x181A76980
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x1A76910 Offset: 0x1A74F10 VA: 0x181A76910
	public Color get_cursorColor() { }

	// RVA: 0x1A76920 Offset: 0x1A74F20 VA: 0x181A76920
	public float get_cursorFlashSpeed() { }

	// RVA: 0x1A76970 Offset: 0x1A74F70 VA: 0x181A76970
	public Color get_selectionColor() { }

	// RVA: 0x1A768A0 Offset: 0x1A74EA0 VA: 0x181A768A0
	public void .ctor() { }

}

