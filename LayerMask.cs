public struct LayerMask // TypeDefIndex: 3516
{	// Fields
	[NativeNameAttribute] // RVA: 0xC0E10 Offset: 0xC0210 VA: 0x1800C0E10
	private int m_Mask; // 0x0

	// Properties
	public int value { get; }

	// Methods

	// RVA: 0x18EA1B0 Offset: 0x18E87B0 VA: 0x1818EA1B0
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x18EA1B0 Offset: 0x18E87B0 VA: 0x1818EA1B0
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0
	public int get_value() { }

	[NativeMethodAttribute] // RVA: 0xC1070 Offset: 0xC0470 VA: 0x1800C1070
	[StaticAccessorAttribute] // RVA: 0xC1070 Offset: 0xC0470 VA: 0x1800C1070
	// RVA: 0x18EA130 Offset: 0x18E8730 VA: 0x1818EA130
	public static string LayerToName(int layer) { }

	[NativeMethodAttribute] // RVA: 0xC11E0 Offset: 0xC05E0 VA: 0x1800C11E0
	[StaticAccessorAttribute] // RVA: 0xC11E0 Offset: 0xC05E0 VA: 0x1800C11E0
	// RVA: 0x18EA170 Offset: 0x18E8770 VA: 0x1818EA170
	public static int NameToLayer(string layerName) { }

	// RVA: 0x18EA040 Offset: 0x18E8640 VA: 0x1818EA040
	public static int GetMask(string[] layerNames) { }

}

