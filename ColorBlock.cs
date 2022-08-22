public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 4911
{	[FormerlySerializedAsAttribute] // RVA: 0xE6480 Offset: 0xE5880 VA: 0x1800E6480
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

