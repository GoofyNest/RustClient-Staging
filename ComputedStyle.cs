internal struct ComputedStyle // TypeDefIndex: 4706
{	private VisualElement m_Element; // 0x0

	private VisualElementStylesData stylesData { get; }
	private InheritedStylesData inheritedStylesData { get; }
	public StyleEnum<Overflow> overflow { get; }
	public StyleEnum<DisplayStyle> display { get; }
	public StyleEnum<Visibility> visibility { get; }


	private VisualElementStylesData get_stylesData() { }

	private InheritedStylesData get_inheritedStylesData() { }

	public StyleEnum<Overflow> get_overflow() { }

	public StyleEnum<DisplayStyle> get_display() { }

	public StyleEnum<Visibility> get_visibility() { }

}

