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

	// RVA: 0x1A63060 Offset: 0x1A61660 VA: 0x181A63060
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x1A63150 Offset: 0x1A61750 VA: 0x181A63150
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x1A63170 Offset: 0x1A61770 VA: 0x181A63170
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x1A63100 Offset: 0x1A61700 VA: 0x181A63100
	public Color get_cursorColor() { }

	// RVA: 0x1A63110 Offset: 0x1A61710 VA: 0x181A63110
	public float get_cursorFlashSpeed() { }

	// RVA: 0x1A63160 Offset: 0x1A61760 VA: 0x181A63160
	public Color get_selectionColor() { }

	// RVA: 0x1A63090 Offset: 0x1A61690 VA: 0x181A63090
	public void .ctor() { }

}

