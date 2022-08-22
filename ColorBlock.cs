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

	// RVA: 0x14B590 Offset: 0x14A990 VA: 0x18014B590
	public Color get_normalColor() { }

	// RVA: 0x19E100 Offset: 0x19D500 VA: 0x18019E100
	public void set_normalColor(Color value) { }

	// RVA: 0x10AB30 Offset: 0x109F30 VA: 0x18010AB30
	public Color get_highlightedColor() { }

	// RVA: 0x19E0F0 Offset: 0x19D4F0 VA: 0x18019E0F0
	public void set_highlightedColor(Color value) { }

	// RVA: 0x19E0A0 Offset: 0x19D4A0 VA: 0x18019E0A0
	public Color get_pressedColor() { }

	// RVA: 0x19E110 Offset: 0x19D510 VA: 0x18019E110
	public void set_pressedColor(Color value) { }

	// RVA: 0x19E0B0 Offset: 0x19D4B0 VA: 0x18019E0B0
	public Color get_selectedColor() { }

	// RVA: 0x19E120 Offset: 0x19D520 VA: 0x18019E120
	public void set_selectedColor(Color value) { }

	// RVA: 0x19E080 Offset: 0x19D480 VA: 0x18019E080
	public Color get_disabledColor() { }

	// RVA: 0x19E0D0 Offset: 0x19D4D0 VA: 0x18019E0D0
	public void set_disabledColor(Color value) { }

	// RVA: 0x19E070 Offset: 0x19D470 VA: 0x18019E070
	public float get_colorMultiplier() { }

	// RVA: 0x19E0C0 Offset: 0x19D4C0 VA: 0x18019E0C0
	public void set_colorMultiplier(float value) { }

	// RVA: 0x19E090 Offset: 0x19D490 VA: 0x18019E090
	public float get_fadeDuration() { }

	// RVA: 0x19E0E0 Offset: 0x19D4E0 VA: 0x18019E0E0
	public void set_fadeDuration(float value) { }

	// RVA: 0x10BAB10 Offset: 0x10B9110 VA: 0x1810BAB10
	public static ColorBlock get_defaultColorBlock() { }

	// RVA: 0x19DEB0 Offset: 0x19D2B0 VA: 0x18019DEB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x19DF90 Offset: 0x19D390 VA: 0x18019DF90 Slot: 4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x10BAC80 Offset: 0x10B9280 VA: 0x1810BAC80
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x10BACD0 Offset: 0x10B92D0 VA: 0x1810BACD0
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x19DFE0 Offset: 0x19D3E0 VA: 0x18019DFE0 Slot: 2
	public override int GetHashCode() { }

}

