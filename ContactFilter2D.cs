public struct ContactFilter2D // TypeDefIndex: 4081
{	[NativeNameAttribute] // RVA: 0x6FFC0 Offset: 0x6F3C0 VA: 0x18006FFC0
	public bool useTriggers; // 0x0
	[NativeNameAttribute] // RVA: 0x70280 Offset: 0x6F680 VA: 0x180070280
	public bool useLayerMask; // 0x1
	[NativeNameAttribute] // RVA: 0x70360 Offset: 0x6F760 VA: 0x180070360
	public bool useDepth; // 0x2
	[NativeNameAttribute] // RVA: 0x704D0 Offset: 0x6F8D0 VA: 0x1800704D0
	public bool useOutsideDepth; // 0x3
	[NativeNameAttribute] // RVA: 0x70690 Offset: 0x6FA90 VA: 0x180070690
	public bool useNormalAngle; // 0x4
	[NativeNameAttribute] // RVA: 0x70720 Offset: 0x6FB20 VA: 0x180070720
	public bool useOutsideNormalAngle; // 0x5
	[NativeNameAttribute] // RVA: 0x70800 Offset: 0x6FC00 VA: 0x180070800
	public LayerMask layerMask; // 0x8
	[NativeNameAttribute] // RVA: 0x708C0 Offset: 0x6FCC0 VA: 0x1800708C0
	public float minDepth; // 0xC
	[NativeNameAttribute] // RVA: 0x70A90 Offset: 0x6FE90 VA: 0x180070A90
	public float maxDepth; // 0x10
	[NativeNameAttribute] // RVA: 0x70B20 Offset: 0x6FF20 VA: 0x180070B20
	public float minNormalAngle; // 0x14
	[NativeNameAttribute] // RVA: 0x70C20 Offset: 0x70020 VA: 0x180070C20
	public float maxNormalAngle; // 0x18


	private void CheckConsistency() { }

	public void SetLayerMask(LayerMask layerMask) { }

	public void SetDepth(float minDepth, float maxDepth) { }

	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }

}

