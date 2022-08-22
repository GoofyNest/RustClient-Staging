internal struct StyleValue // TypeDefIndex: 4726
{	// Fields
	public StylePropertyID id; // 0x0
	public StyleKeyword keyword; // 0x4
	public float number; // 0x8
	public Length length; // 0x8
	public Color color; // 0x8
	public GCHandle resource; // 0x8

	// Methods

	// RVA: 0xEBD210 Offset: 0xEBB810 VA: 0x180EBD210
	public static StyleValue Create(StylePropertyID id) { }

	// RVA: 0xEBD1A0 Offset: 0xEBB7A0 VA: 0x180EBD1A0
	public static StyleValue Create(StylePropertyID id, StyleKeyword keyword) { }

	// RVA: 0xEBD1D0 Offset: 0xEBB7D0 VA: 0x180EBD1D0
	public static StyleValue Create(StylePropertyID id, float number) { }

	// RVA: 0xEBD270 Offset: 0xEBB870 VA: 0x180EBD270
	public static StyleValue Create(StylePropertyID id, int number) { }

	// RVA: 0xEBD240 Offset: 0xEBB840 VA: 0x180EBD240
	public static StyleValue Create(StylePropertyID id, Color color) { }

}

