public struct LayerMask // TypeDefIndex: 3516
{	// Fields
	[NativeNameAttribute] // RVA: 0xC0E10 Offset: 0xC0210 VA: 0x1800C0E10
	private int m_Mask; // 0x0

	// Properties
	public int value { get; }

	// Methods

	// RVA: 0x18E98D0 Offset: 0x18E7ED0 VA: 0x1818E98D0
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x18E98D0 Offset: 0x18E7ED0 VA: 0x1818E98D0
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0
	public int get_value() { }

	[NativeMethodAttribute] // RVA: 0xC1070 Offset: 0xC0470 VA: 0x1800C1070
	[StaticAccessorAttribute] // RVA: 0xC1070 Offset: 0xC0470 VA: 0x1800C1070
	// RVA: 0x18E9850 Offset: 0x18E7E50 VA: 0x1818E9850
	public static string LayerToName(int layer) { }

	[NativeMethodAttribute] // RVA: 0xC11E0 Offset: 0xC05E0 VA: 0x1800C11E0
	[StaticAccessorAttribute] // RVA: 0xC11E0 Offset: 0xC05E0 VA: 0x1800C11E0
	// RVA: 0x18E9890 Offset: 0x18E7E90 VA: 0x1818E9890
	public static int NameToLayer(string layerName) { }

	// RVA: 0x18E9760 Offset: 0x18E7D60 VA: 0x1818E9760
	public static int GetMask(string[] layerNames) { }

}

