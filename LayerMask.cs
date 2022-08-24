public struct LayerMask // TypeDefIndex: 3516
{	[NativeNameAttribute] // RVA: 0xC1050 Offset: 0xC0450 VA: 0x1800C1050
	private int m_Mask; // 0x0

	public int value { get; }


	public static int op_Implicit(LayerMask mask) { }

	public static LayerMask op_Implicit(int intVal) { }

	public int get_value() { }

	[NativeMethodAttribute] // RVA: 0xC1230 Offset: 0xC0630 VA: 0x1800C1230
	[StaticAccessorAttribute] // RVA: 0xC1230 Offset: 0xC0630 VA: 0x1800C1230
	public static string LayerToName(int layer) { }

	[NativeMethodAttribute] // RVA: 0xC13B0 Offset: 0xC07B0 VA: 0x1800C13B0
	[StaticAccessorAttribute] // RVA: 0xC13B0 Offset: 0xC07B0 VA: 0x1800C13B0
	public static int NameToLayer(string layerName) { }

	public static int GetMask(string[] layerNames) { }

}

