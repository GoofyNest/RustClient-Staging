public struct LayerMask // TypeDefIndex: 3516
{	[NativeNameAttribute] // RVA: 0xC0EE0 Offset: 0xC02E0 VA: 0x1800C0EE0
	private int m_Mask; // 0x0

	public int value { get; }


	public static int op_Implicit(LayerMask mask) { }

	public static LayerMask op_Implicit(int intVal) { }

	public int get_value() { }

	[NativeMethodAttribute] // RVA: 0xC1140 Offset: 0xC0540 VA: 0x1800C1140
	[StaticAccessorAttribute] // RVA: 0xC1140 Offset: 0xC0540 VA: 0x1800C1140
	public static string LayerToName(int layer) { }

	[NativeMethodAttribute] // RVA: 0xC1310 Offset: 0xC0710 VA: 0x1800C1310
	[StaticAccessorAttribute] // RVA: 0xC1310 Offset: 0xC0710 VA: 0x1800C1310
	public static int NameToLayer(string layerName) { }

	public static int GetMask(string[] layerNames) { }

}

