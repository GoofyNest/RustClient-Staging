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

	// RVA: 0x1A76B30 Offset: 0x1A75130 VA: 0x181A76B30
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x1A76C20 Offset: 0x1A75220 VA: 0x181A76C20
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x1A76C40 Offset: 0x1A75240 VA: 0x181A76C40
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x1A76BD0 Offset: 0x1A751D0 VA: 0x181A76BD0
	public Color get_cursorColor() { }

	// RVA: 0x1A76BE0 Offset: 0x1A751E0 VA: 0x181A76BE0
	public float get_cursorFlashSpeed() { }

	// RVA: 0x1A76C30 Offset: 0x1A75230 VA: 0x181A76C30
	public Color get_selectionColor() { }

	// RVA: 0x1A76B60 Offset: 0x1A75160 VA: 0x181A76B60
	public void .ctor() { }

}

