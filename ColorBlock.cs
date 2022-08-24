public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 4911
{	[FormerlySerializedAsAttribute] // RVA: 0xE65A0 Offset: 0xE59A0 VA: 0x1800E65A0
	[SerializeField] // RVA: 0xE65A0 Offset: 0xE59A0 VA: 0x1800E65A0
	private Color m_NormalColor; // 0x0
	[FormerlySerializedAsAttribute] // RVA: 0xE6680 Offset: 0xE5A80 VA: 0x1800E6680
	[SerializeField] // RVA: 0xE6680 Offset: 0xE5A80 VA: 0x1800E6680
	private Color m_HighlightedColor; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE6840 Offset: 0xE5C40 VA: 0x1800E6840
	[SerializeField] // RVA: 0xE6840 Offset: 0xE5C40 VA: 0x1800E6840
	private Color m_PressedColor; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE69E0 Offset: 0xE5DE0 VA: 0x1800E69E0
	[SerializeField] // RVA: 0xE69E0 Offset: 0xE5DE0 VA: 0x1800E69E0
	private Color m_SelectedColor; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0xE6BB0 Offset: 0xE5FB0 VA: 0x1800E6BB0
	[SerializeField] // RVA: 0xE6BB0 Offset: 0xE5FB0 VA: 0x1800E6BB0
	private Color m_DisabledColor; // 0x40
	[RangeAttribute] // RVA: 0xE6CF0 Offset: 0xE60F0 VA: 0x1800E6CF0
	[SerializeField] // RVA: 0xE6CF0 Offset: 0xE60F0 VA: 0x1800E6CF0
	private float m_ColorMultiplier; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xE7130 Offset: 0xE6530 VA: 0x1800E7130
	[SerializeField] // RVA: 0xE7130 Offset: 0xE6530 VA: 0x1800E7130
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

