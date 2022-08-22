public struct LayerMask // TypeDefIndex: 3516
{	// Fields
	[NativeNameAttribute] // RVA: 0xC0E10 Offset: 0xC0210 VA: 0x1800C0E10
	private int m_Mask; // 0x0

	// Properties
	public int value { get; }

	// Methods

	// RVA: 0x18E9EF0 Offset: 0x18E84F0 VA: 0x1818E9EF0
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x18E9EF0 Offset: 0x18E84F0 VA: 0x1818E9EF0
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0
	public int get_value() { }

	[NativeMethodAttribute] // RVA: 0xC1070 Offset: 0xC0470 VA: 0x1800C1070
	[StaticAccessorAttribute] // RVA: 0xC1070 Offset: 0xC0470 VA: 0x1800C1070
	// RVA: 0x18E9E70 Offset: 0x18E8470 VA: 0x1818E9E70
	public static string LayerToName(int layer) { }

	[NativeMethodAttribute] // RVA: 0xC11E0 Offset: 0xC05E0 VA: 0x1800C11E0
	[StaticAccessorAttribute] // RVA: 0xC11E0 Offset: 0xC05E0 VA: 0x1800C11E0
	// RVA: 0x18E9EB0 Offset: 0x18E84B0 VA: 0x1818E9EB0
	public static int NameToLayer(string layerName) { }

	// RVA: 0x18E9D80 Offset: 0x18E8380 VA: 0x1818E9D80
	public static int GetMask(string[] layerNames) { }

}

