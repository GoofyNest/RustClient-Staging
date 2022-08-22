public struct LayerMask // TypeDefIndex: 3516
{	[NativeNameAttribute] // RVA: 0xC0E10 Offset: 0xC0210 VA: 0x1800C0E10
	private int m_Mask; // 0x0

	public int value { get; }


	public static int op_Implicit(LayerMask mask) { }

	public static LayerMask op_Implicit(int intVal) { }

	public int get_value() { }

	[NativeMethodAttribute] // RVA: 0xC1070 Offset: 0xC0470 VA: 0x1800C1070
	[StaticAccessorAttribute] // RVA: 0xC1070 Offset: 0xC0470 VA: 0x1800C1070
	public static string LayerToName(int layer) { }

	[NativeMethodAttribute] // RVA: 0xC11E0 Offset: 0xC05E0 VA: 0x1800C11E0
	[StaticAccessorAttribute] // RVA: 0xC11E0 Offset: 0xC05E0 VA: 0x1800C11E0
	public static int NameToLayer(string layerName) { }

	public static int GetMask(string[] layerNames) { }

}

