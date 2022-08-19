internal struct StyleValue // TypeDefIndex: 4726
{	// Fields
	public StylePropertyID id; // 0x0
	public StyleKeyword keyword; // 0x4
	public float number; // 0x8
	public Length length; // 0x8
	public Color color; // 0x8
	public GCHandle resource; // 0x8

	// Methods

	// RVA: 0xEBC4A0 Offset: 0xEBAAA0 VA: 0x180EBC4A0
	public static StyleValue Create(StylePropertyID id) { }

	// RVA: 0xEBC430 Offset: 0xEBAA30 VA: 0x180EBC430
	public static StyleValue Create(StylePropertyID id, StyleKeyword keyword) { }

	// RVA: 0xEBC460 Offset: 0xEBAA60 VA: 0x180EBC460
	public static StyleValue Create(StylePropertyID id, float number) { }

	// RVA: 0xEBC500 Offset: 0xEBAB00 VA: 0x180EBC500
	public static StyleValue Create(StylePropertyID id, int number) { }

	// RVA: 0xEBC4D0 Offset: 0xEBAAD0 VA: 0x180EBC4D0
	public static StyleValue Create(StylePropertyID id, Color color) { }

}

