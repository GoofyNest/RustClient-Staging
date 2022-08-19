public struct LayerMask // TypeDefIndex: 3516
{	// Fields
	[NativeNameAttribute] // RVA: 0xC0D70 Offset: 0xC0170 VA: 0x1800C0D70
	private int m_Mask; // 0x0

	// Properties
	public int value { get; }

	// Methods

	// RVA: 0x18E9F30 Offset: 0x18E8530 VA: 0x1818E9F30
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x18E9F30 Offset: 0x18E8530 VA: 0x1818E9F30
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	public int get_value() { }

	[NativeMethodAttribute] // RVA: 0xC0F80 Offset: 0xC0380 VA: 0x1800C0F80
	[StaticAccessorAttribute] // RVA: 0xC0F80 Offset: 0xC0380 VA: 0x1800C0F80
	// RVA: 0x18E9EB0 Offset: 0x18E84B0 VA: 0x1818E9EB0
	public static string LayerToName(int layer) { }

	[NativeMethodAttribute] // RVA: 0xC1140 Offset: 0xC0540 VA: 0x1800C1140
	[StaticAccessorAttribute] // RVA: 0xC1140 Offset: 0xC0540 VA: 0x1800C1140
	// RVA: 0x18E9EF0 Offset: 0x18E84F0 VA: 0x1818E9EF0
	public static int NameToLayer(string layerName) { }

	// RVA: 0x18E9DC0 Offset: 0x18E83C0 VA: 0x1818E9DC0
	public static int GetMask(string[] layerNames) { }

}

