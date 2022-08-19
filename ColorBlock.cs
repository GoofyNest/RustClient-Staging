public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 4911
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xE63C0 Offset: 0xE57C0 VA: 0x1800E63C0
	[SerializeField] // RVA: 0xE63C0 Offset: 0xE57C0 VA: 0x1800E63C0
	private Color m_NormalColor; // 0x0
	[FormerlySerializedAsAttribute] // RVA: 0xE64C0 Offset: 0xE58C0 VA: 0x1800E64C0
	[SerializeField] // RVA: 0xE64C0 Offset: 0xE58C0 VA: 0x1800E64C0
	private Color m_HighlightedColor; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE6680 Offset: 0xE5A80 VA: 0x1800E6680
	[SerializeField] // RVA: 0xE6680 Offset: 0xE5A80 VA: 0x1800E6680
	private Color m_PressedColor; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE67B0 Offset: 0xE5BB0 VA: 0x1800E67B0
	[SerializeField] // RVA: 0xE67B0 Offset: 0xE5BB0 VA: 0x1800E67B0
	private Color m_SelectedColor; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0xE69F0 Offset: 0xE5DF0 VA: 0x1800E69F0
	[SerializeField] // RVA: 0xE69F0 Offset: 0xE5DF0 VA: 0x1800E69F0
	private Color m_DisabledColor; // 0x40
	[RangeAttribute] // RVA: 0xE6B30 Offset: 0xE5F30 VA: 0x1800E6B30
	[SerializeField] // RVA: 0xE6B30 Offset: 0xE5F30 VA: 0x1800E6B30
	private float m_ColorMultiplier; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xE6E70 Offset: 0xE6270 VA: 0x1800E6E70
	[SerializeField] // RVA: 0xE6E70 Offset: 0xE6270 VA: 0x1800E6E70
	private float m_FadeDuration; // 0x54

	// Properties
	public Color normalColor { get; set; }
	public Color highlightedColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledColor { get; set; }
	public float colorMultiplier { get; set; }
	public float fadeDuration { get; set; }
	public static ColorBlock defaultColorBlock { get; }

	// Methods

	// RVA: 0x14B7F0 Offset: 0x14ABF0 VA: 0x18014B7F0
	public Color get_normalColor() { }

	// RVA: 0x19E490 Offset: 0x19D890 VA: 0x18019E490
	public void set_normalColor(Color value) { }

	// RVA: 0x10ABB0 Offset: 0x109FB0 VA: 0x18010ABB0
	public Color get_highlightedColor() { }

	// RVA: 0x19E480 Offset: 0x19D880 VA: 0x18019E480
	public void set_highlightedColor(Color value) { }

	// RVA: 0x19E430 Offset: 0x19D830 VA: 0x18019E430
	public Color get_pressedColor() { }

	// RVA: 0x19E4A0 Offset: 0x19D8A0 VA: 0x18019E4A0
	public void set_pressedColor(Color value) { }

	// RVA: 0x19E440 Offset: 0x19D840 VA: 0x18019E440
	public Color get_selectedColor() { }

	// RVA: 0x19E4B0 Offset: 0x19D8B0 VA: 0x18019E4B0
	public void set_selectedColor(Color value) { }

	// RVA: 0x19E410 Offset: 0x19D810 VA: 0x18019E410
	public Color get_disabledColor() { }

	// RVA: 0x19E460 Offset: 0x19D860 VA: 0x18019E460
	public void set_disabledColor(Color value) { }

	// RVA: 0x19E400 Offset: 0x19D800 VA: 0x18019E400
	public float get_colorMultiplier() { }

	// RVA: 0x19E450 Offset: 0x19D850 VA: 0x18019E450
	public void set_colorMultiplier(float value) { }

	// RVA: 0x19E420 Offset: 0x19D820 VA: 0x18019E420
	public float get_fadeDuration() { }

	// RVA: 0x19E470 Offset: 0x19D870 VA: 0x18019E470
	public void set_fadeDuration(float value) { }

	// RVA: 0x10B9DE0 Offset: 0x10B83E0 VA: 0x1810B9DE0
	public static ColorBlock get_defaultColorBlock() { }

	// RVA: 0x19E240 Offset: 0x19D640 VA: 0x18019E240 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x19E320 Offset: 0x19D720 VA: 0x18019E320 Slot: 4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x10B9F50 Offset: 0x10B8550 VA: 0x1810B9F50
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x10B9FA0 Offset: 0x10B85A0 VA: 0x1810B9FA0
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x19E370 Offset: 0x19D770 VA: 0x18019E370 Slot: 2
	public override int GetHashCode() { }

}

