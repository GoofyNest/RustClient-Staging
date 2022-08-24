public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 4911
{	[FormerlySerializedAsAttribute] // RVA: 0xE6470 Offset: 0xE5870 VA: 0x1800E6470
	[SerializeField] // RVA: 0xE6470 Offset: 0xE5870 VA: 0x1800E6470
	private Color m_NormalColor; // 0x0
	[FormerlySerializedAsAttribute] // RVA: 0xE6550 Offset: 0xE5950 VA: 0x1800E6550
	[SerializeField] // RVA: 0xE6550 Offset: 0xE5950 VA: 0x1800E6550
	private Color m_HighlightedColor; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE6710 Offset: 0xE5B10 VA: 0x1800E6710
	[SerializeField] // RVA: 0xE6710 Offset: 0xE5B10 VA: 0x1800E6710
	private Color m_PressedColor; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE68B0 Offset: 0xE5CB0 VA: 0x1800E68B0
	[SerializeField] // RVA: 0xE68B0 Offset: 0xE5CB0 VA: 0x1800E68B0
	private Color m_SelectedColor; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0xE6A80 Offset: 0xE5E80 VA: 0x1800E6A80
	[SerializeField] // RVA: 0xE6A80 Offset: 0xE5E80 VA: 0x1800E6A80
	private Color m_DisabledColor; // 0x40
	[RangeAttribute] // RVA: 0xE6BE0 Offset: 0xE5FE0 VA: 0x1800E6BE0
	[SerializeField] // RVA: 0xE6BE0 Offset: 0xE5FE0 VA: 0x1800E6BE0
	private float m_ColorMultiplier; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xE7040 Offset: 0xE6440 VA: 0x1800E7040
	[SerializeField] // RVA: 0xE7040 Offset: 0xE6440 VA: 0x1800E7040
	private float m_FadeDuration; // 0x54

	public Color normalColor { get; set; }
	public Color highlightedColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledColor { get; set; }
	public float colorMultiplier { get; set; }
	public float fadeDuration { get; set; }
	public static ColorBlock defaultColorBlock { get; }


	public Color get_normalColor() { }

	public void set_normalColor(Color value) { }

	public Color get_highlightedColor() { }

	public void set_highlightedColor(Color value) { }

	public Color get_pressedColor() { }

	public void set_pressedColor(Color value) { }

	public Color get_selectedColor() { }

	public void set_selectedColor(Color value) { }

	public Color get_disabledColor() { }

	public void set_disabledColor(Color value) { }

	public float get_colorMultiplier() { }

	public void set_colorMultiplier(float value) { }

	public float get_fadeDuration() { }

	public void set_fadeDuration(float value) { }

	public static ColorBlock get_defaultColorBlock() { }

	public override bool Equals(object obj) { }

	public bool Equals(ColorBlock other) { }

	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	public override int GetHashCode() { }

}

