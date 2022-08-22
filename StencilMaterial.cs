public static class StencilMaterial // TypeDefIndex: 5012
{	// Fields
	private static List<StencilMaterial.MatEntry> m_List; // 0x13550

	// Methods

	[EditorBrowsableAttribute] // RVA: 0x7D770 Offset: 0x7CB70 VA: 0x18007D770
	[ObsoleteAttribute] // RVA: 0x7D770 Offset: 0x7CB70 VA: 0x18007D770
	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x2245770 Offset: 0x2243D70 VA: 0x182245770
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x2244E30 Offset: 0x2243430 VA: 0x182244E30
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x2245940 Offset: 0x2243F40 VA: 0x182245940
	public static void Remove(Material customMat) { }

	// RVA: 0x2245810 Offset: 0x2243E10 VA: 0x182245810
	public static void ClearAll() { }

	// RVA: 0x2245B00 Offset: 0x2244100 VA: 0x182245B00
	private static void .cctor() { }

}

private class StencilMaterial.MatEntry // TypeDefIndex: 5013
{	// Fields
	public Material baseMat; // 0x10
	public Material customMat; // 0x18
	public int count; // 0x20
	public int stencilId; // 0x24
	public StencilOp operation; // 0x28
	public CompareFunction compareFunction; // 0x2C
	public int readMask; // 0x30
	public int writeMask; // 0x34
	public bool useAlphaClip; // 0x38
	public ColorWriteMask colorMask; // 0x3C

	// Methods

	// RVA: 0x2244CB0 Offset: 0x22432B0 VA: 0x182244CB0
	public void .ctor() { }

}

