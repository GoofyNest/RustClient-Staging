public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 4911
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xE6480 Offset: 0xE5880 VA: 0x1800E6480
	[SerializeField] // RVA: 0xE6480 Offset: 0xE5880 VA: 0x1800E6480
	private Color m_NormalColor; // 0x0
	[FormerlySerializedAsAttribute] // RVA: 0xE6510 Offset: 0xE5910 VA: 0x1800E6510
	[SerializeField] // RVA: 0xE6510 Offset: 0xE5910 VA: 0x1800E6510
	private Color m_HighlightedColor; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE6720 Offset: 0xE5B20 VA: 0x1800E6720
	[SerializeField] // RVA: 0xE6720 Offset: 0xE5B20 VA: 0x1800E6720
	private Color m_PressedColor; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE68C0 Offset: 0xE5CC0 VA: 0x1800E68C0
	[SerializeField] // RVA: 0xE68C0 Offset: 0xE5CC0 VA: 0x1800E68C0
	private Color m_SelectedColor; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0xE6A90 Offset: 0xE5E90 VA: 0x1800E6A90
	[SerializeField] // RVA: 0xE6A90 Offset: 0xE5E90 VA: 0x1800E6A90
	private Color m_DisabledColor; // 0x40
	[RangeAttribute] // RVA: 0xE6BD0 Offset: 0xE5FD0 VA: 0x1800E6BD0
	[SerializeField] // RVA: 0xE6BD0 Offset: 0xE5FD0 VA: 0x1800E6BD0
	private float m_ColorMultiplier; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xE7010 Offset: 0xE6410 VA: 0x1800E7010
	[SerializeField] // RVA: 0xE7010 Offset: 0xE6410 VA: 0x1800E7010
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

	// RVA: 0x14B770 Offset: 0x14AB70 VA: 0x18014B770
	public Color get_normalColor() { }

	// RVA: 0x19E410 Offset: 0x19D810 VA: 0x18019E410
	public void set_normalColor(Color value) { }

	// RVA: 0x10AB30 Offset: 0x109F30 VA: 0x18010AB30
	public Color get_highlightedColor() { }

	// RVA: 0x19E400 Offset: 0x19D800 VA: 0x18019E400
	public void set_highlightedColor(Color value) { }

	// RVA: 0x19E3B0 Offset: 0x19D7B0 VA: 0x18019E3B0
	public Color get_pressedColor() { }

	// RVA: 0x19E420 Offset: 0x19D820 VA: 0x18019E420
	public void set_pressedColor(Color value) { }

	// RVA: 0x19E3C0 Offset: 0x19D7C0 VA: 0x18019E3C0
	public Color get_selectedColor() { }

	// RVA: 0x19E430 Offset: 0x19D830 VA: 0x18019E430
	public void set_selectedColor(Color value) { }

	// RVA: 0x19E390 Offset: 0x19D790 VA: 0x18019E390
	public Color get_disabledColor() { }

	// RVA: 0x19E3E0 Offset: 0x19D7E0 VA: 0x18019E3E0
	public void set_disabledColor(Color value) { }

	// RVA: 0x19E380 Offset: 0x19D780 VA: 0x18019E380
	public float get_colorMultiplier() { }

	// RVA: 0x19E3D0 Offset: 0x19D7D0 VA: 0x18019E3D0
	public void set_colorMultiplier(float value) { }

	// RVA: 0x19E3A0 Offset: 0x19D7A0 VA: 0x18019E3A0
	public float get_fadeDuration() { }

	// RVA: 0x19E3F0 Offset: 0x19D7F0 VA: 0x18019E3F0
	public void set_fadeDuration(float value) { }

	// RVA: 0x10B9DE0 Offset: 0x10B83E0 VA: 0x1810B9DE0
	public static ColorBlock get_defaultColorBlock() { }

	// RVA: 0x19E1C0 Offset: 0x19D5C0 VA: 0x18019E1C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x19E2A0 Offset: 0x19D6A0 VA: 0x18019E2A0 Slot: 4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x10B9F50 Offset: 0x10B8550 VA: 0x1810B9F50
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x10B9FA0 Offset: 0x10B85A0 VA: 0x1810B9FA0
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x19E2F0 Offset: 0x19D6F0 VA: 0x18019E2F0 Slot: 2
	public override int GetHashCode() { }

}

