public sealed class GUISettings // TypeDefIndex: 4043
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_DoubleClickSelectsWord; // 0x10
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_TripleClickSelectsLine; // 0x11
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color m_CursorColor; // 0x14
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_CursorFlashSpeed; // 0x24
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color m_SelectionColor; // 0x28

	// Properties
	public bool doubleClickSelectsWord { get; }
	public bool tripleClickSelectsLine { get; }
	public Color cursorColor { get; }
	public float cursorFlashSpeed { get; }
	public Color selectionColor { get; }

	// Methods

	// RVA: 0x1A768B0 Offset: 0x1A74EB0 VA: 0x181A768B0
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x1A769A0 Offset: 0x1A74FA0 VA: 0x181A769A0
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x1A769C0 Offset: 0x1A74FC0 VA: 0x181A769C0
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x1A76950 Offset: 0x1A74F50 VA: 0x181A76950
	public Color get_cursorColor() { }

	// RVA: 0x1A76960 Offset: 0x1A74F60 VA: 0x181A76960
	public float get_cursorFlashSpeed() { }

	// RVA: 0x1A769B0 Offset: 0x1A74FB0 VA: 0x181A769B0
	public Color get_selectionColor() { }

	// RVA: 0x1A768E0 Offset: 0x1A74EE0 VA: 0x181A768E0
	public void .ctor() { }

}

