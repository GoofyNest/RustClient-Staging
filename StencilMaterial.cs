public static class StencilMaterial // TypeDefIndex: 5012
{	// Fields
	private static List<StencilMaterial.MatEntry> m_List; // 0x137AF

	// Methods

	[EditorBrowsableAttribute] // RVA: 0x7D770 Offset: 0x7CB70 VA: 0x18007D770
	[ObsoleteAttribute] // RVA: 0x7D770 Offset: 0x7CB70 VA: 0x18007D770
	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x2244C90 Offset: 0x2243290 VA: 0x182244C90
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x2244350 Offset: 0x2242950 VA: 0x182244350
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x2244E60 Offset: 0x2243460 VA: 0x182244E60
	public static void Remove(Material customMat) { }

	// RVA: 0x2244D30 Offset: 0x2243330 VA: 0x182244D30
	public static void ClearAll() { }

	// RVA: 0x2245020 Offset: 0x2243620 VA: 0x182245020
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

	// RVA: 0x22441D0 Offset: 0x22427D0 VA: 0x1822441D0
	public void .ctor() { }

}

