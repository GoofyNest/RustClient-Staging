public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 5011
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Sprite m_HighlightedSprite; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Sprite m_PressedSprite; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0x7D540 Offset: 0x7C940 VA: 0x18007D540
	[SerializeField] // RVA: 0x7D540 Offset: 0x7C940 VA: 0x18007D540
	private Sprite m_SelectedSprite; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Sprite m_DisabledSprite; // 0x18

	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }


	public Sprite get_highlightedSprite() { }

	public void set_highlightedSprite(Sprite value) { }

	public Sprite get_pressedSprite() { }

	public void set_pressedSprite(Sprite value) { }

	public Sprite get_selectedSprite() { }

	public void set_selectedSprite(Sprite value) { }

	public Sprite get_disabledSprite() { }

	public void set_disabledSprite(Sprite value) { }

	public bool Equals(SpriteState other) { }

}

