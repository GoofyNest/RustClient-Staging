public struct ContactFilter2D // TypeDefIndex: 4081
{	[NativeNameAttribute] // RVA: 0x6FEF0 Offset: 0x6F2F0 VA: 0x18006FEF0
	public bool useTriggers; // 0x0
	[NativeNameAttribute] // RVA: 0x701B0 Offset: 0x6F5B0 VA: 0x1800701B0
	public bool useLayerMask; // 0x1
	[NativeNameAttribute] // RVA: 0x702A0 Offset: 0x6F6A0 VA: 0x1800702A0
	public bool useDepth; // 0x2
	[NativeNameAttribute] // RVA: 0x70410 Offset: 0x6F810 VA: 0x180070410
	public bool useOutsideDepth; // 0x3
	[NativeNameAttribute] // RVA: 0x70570 Offset: 0x6F970 VA: 0x180070570
	public bool useNormalAngle; // 0x4
	[NativeNameAttribute] // RVA: 0x70600 Offset: 0x6FA00 VA: 0x180070600
	public bool useOutsideNormalAngle; // 0x5
	[NativeNameAttribute] // RVA: 0x70740 Offset: 0x6FB40 VA: 0x180070740
	public LayerMask layerMask; // 0x8
	[NativeNameAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	public float minDepth; // 0xC
	[NativeNameAttribute] // RVA: 0x709A0 Offset: 0x6FDA0 VA: 0x1800709A0
	public float maxDepth; // 0x10
	[NativeNameAttribute] // RVA: 0x70A30 Offset: 0x6FE30 VA: 0x180070A30
	public float minNormalAngle; // 0x14
	[NativeNameAttribute] // RVA: 0x70B60 Offset: 0x6FF60 VA: 0x180070B60
	public float maxNormalAngle; // 0x18


	private void CheckConsistency() { }

	public void SetLayerMask(LayerMask layerMask) { }

	public void SetDepth(float minDepth, float maxDepth) { }

	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }

}

