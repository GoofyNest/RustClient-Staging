internal struct StyleValue // TypeDefIndex: 4726
{	// Fields
	public StylePropertyID id; // 0x0
	public StyleKeyword keyword; // 0x4
	public float number; // 0x8
	public Length length; // 0x8
	public Color color; // 0x8
	public GCHandle resource; // 0x8

	// Methods

	// RVA: 0xEBC760 Offset: 0xEBAD60 VA: 0x180EBC760
	public static StyleValue Create(StylePropertyID id) { }

	// RVA: 0xEBC6F0 Offset: 0xEBACF0 VA: 0x180EBC6F0
	public static StyleValue Create(StylePropertyID id, StyleKeyword keyword) { }

	// RVA: 0xEBC720 Offset: 0xEBAD20 VA: 0x180EBC720
	public static StyleValue Create(StylePropertyID id, float number) { }

	// RVA: 0xEBC7C0 Offset: 0xEBADC0 VA: 0x180EBC7C0
	public static StyleValue Create(StylePropertyID id, int number) { }

	// RVA: 0xEBC790 Offset: 0xEBAD90 VA: 0x180EBC790
	public static StyleValue Create(StylePropertyID id, Color color) { }

}

