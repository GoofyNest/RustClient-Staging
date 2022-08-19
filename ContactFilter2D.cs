public struct ContactFilter2D // TypeDefIndex: 4081
{	// Fields
	[NativeNameAttribute] // RVA: 0x6FE70 Offset: 0x6F270 VA: 0x18006FE70
	public bool useTriggers; // 0x0
	[NativeNameAttribute] // RVA: 0x700A0 Offset: 0x6F4A0 VA: 0x1800700A0
	public bool useLayerMask; // 0x1
	[NativeNameAttribute] // RVA: 0x701D0 Offset: 0x6F5D0 VA: 0x1800701D0
	public bool useDepth; // 0x2
	[NativeNameAttribute] // RVA: 0x70340 Offset: 0x6F740 VA: 0x180070340
	public bool useOutsideDepth; // 0x3
	[NativeNameAttribute] // RVA: 0x704A0 Offset: 0x6F8A0 VA: 0x1800704A0
	public bool useNormalAngle; // 0x4
	[NativeNameAttribute] // RVA: 0x70530 Offset: 0x6F930 VA: 0x180070530
	public bool useOutsideNormalAngle; // 0x5
	[NativeNameAttribute] // RVA: 0x70670 Offset: 0x6FA70 VA: 0x180070670
	public LayerMask layerMask; // 0x8
	[NativeNameAttribute] // RVA: 0x70730 Offset: 0x6FB30 VA: 0x180070730
	public float minDepth; // 0xC
	[NativeNameAttribute] // RVA: 0x708A0 Offset: 0x6FCA0 VA: 0x1800708A0
	public float maxDepth; // 0x10
	[NativeNameAttribute] // RVA: 0x70960 Offset: 0x6FD60 VA: 0x180070960
	public float minNormalAngle; // 0x14
	[NativeNameAttribute] // RVA: 0x70A90 Offset: 0x6FE90 VA: 0x180070A90
	public float maxNormalAngle; // 0x18

	// Methods

	// RVA: 0x240070 Offset: 0x23F470 VA: 0x180240070
	private void CheckConsistency() { }

	// RVA: 0x240100 Offset: 0x23F500 VA: 0x180240100
	public void SetLayerMask(LayerMask layerMask) { }

	// RVA: 0x2400B0 Offset: 0x23F4B0 VA: 0x1802400B0
	public void SetDepth(float minDepth, float maxDepth) { }

	// RVA: 0x230F900 Offset: 0x230DF00 VA: 0x18230F900
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	// RVA: 0x230F8C0 Offset: 0x230DEC0 VA: 0x18230F8C0
	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }

}

