public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 5011
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Sprite m_HighlightedSprite; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Sprite m_PressedSprite; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0x7D540 Offset: 0x7C940 VA: 0x18007D540
	[SerializeField] // RVA: 0x7D540 Offset: 0x7C940 VA: 0x18007D540
	private Sprite m_SelectedSprite; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Sprite m_DisabledSprite; // 0x18

	// Properties
	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }

	// Methods

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public Sprite get_highlightedSprite() { }

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public Sprite get_pressedSprite() { }

	// RVA: 0xF14A0 Offset: 0xF08A0 VA: 0x1800F14A0
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0xF3EE0 Offset: 0xF32E0 VA: 0x1800F3EE0
	public Sprite get_selectedSprite() { }

	// RVA: 0xF1470 Offset: 0xF0870 VA: 0x1800F1470
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	public Sprite get_disabledSprite() { }

	// RVA: 0xF1480 Offset: 0xF0880 VA: 0x1800F1480
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x238270 Offset: 0x237670 VA: 0x180238270 Slot: 4
	public bool Equals(SpriteState other) { }

}

