public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 5011
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Sprite m_HighlightedSprite; // 0x0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Sprite m_PressedSprite; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0x7D470 Offset: 0x7C870 VA: 0x18007D470
	[SerializeField] // RVA: 0x7D470 Offset: 0x7C870 VA: 0x18007D470
	private Sprite m_SelectedSprite; // 0x10
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Sprite m_DisabledSprite; // 0x18

	// Properties
	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }

	// Methods

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public Sprite get_highlightedSprite() { }

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0xF3F40 Offset: 0xF3340 VA: 0x1800F3F40
	public Sprite get_pressedSprite() { }

	// RVA: 0xF1520 Offset: 0xF0920 VA: 0x1800F1520
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0xF3F60 Offset: 0xF3360 VA: 0x1800F3F60
	public Sprite get_selectedSprite() { }

	// RVA: 0xF14F0 Offset: 0xF08F0 VA: 0x1800F14F0
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0xF3F70 Offset: 0xF3370 VA: 0x1800F3F70
	public Sprite get_disabledSprite() { }

	// RVA: 0xF1500 Offset: 0xF0900 VA: 0x1800F1500
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x2382F0 Offset: 0x2376F0 VA: 0x1802382F0 Slot: 4
	public bool Equals(SpriteState other) { }

}

