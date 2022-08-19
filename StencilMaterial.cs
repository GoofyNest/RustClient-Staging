public static class StencilMaterial // TypeDefIndex: 5012
{	// Fields
	private static List<StencilMaterial.MatEntry> m_List; // 0x137AF

	// Methods

	[EditorBrowsableAttribute] // RVA: 0x7D6A0 Offset: 0x7CAA0 VA: 0x18007D6A0
	[ObsoleteAttribute] // RVA: 0x7D6A0 Offset: 0x7CAA0 VA: 0x18007D6A0
	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x2244E50 Offset: 0x2243450 VA: 0x182244E50
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x2244510 Offset: 0x2242B10 VA: 0x182244510
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x2245020 Offset: 0x2243620 VA: 0x182245020
	public static void Remove(Material customMat) { }

	// RVA: 0x2244EF0 Offset: 0x22434F0 VA: 0x182244EF0
	public static void ClearAll() { }

	// RVA: 0x22451E0 Offset: 0x22437E0 VA: 0x1822451E0
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

	// RVA: 0x2244390 Offset: 0x2242990 VA: 0x182244390
	public void .ctor() { }

}

