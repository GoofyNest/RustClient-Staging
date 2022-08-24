public struct ContactFilter2D // TypeDefIndex: 4081
{	[NativeNameAttribute] // RVA: 0x6FF40 Offset: 0x6F340 VA: 0x18006FF40
	public bool useTriggers; // 0x0
	[NativeNameAttribute] // RVA: 0x70210 Offset: 0x6F610 VA: 0x180070210
	public bool useLayerMask; // 0x1
	[NativeNameAttribute] // RVA: 0x702D0 Offset: 0x6F6D0 VA: 0x1800702D0
	public bool useDepth; // 0x2
	[NativeNameAttribute] // RVA: 0x70440 Offset: 0x6F840 VA: 0x180070440
	public bool useOutsideDepth; // 0x3
	[NativeNameAttribute] // RVA: 0x705D0 Offset: 0x6F9D0 VA: 0x1800705D0
	public bool useNormalAngle; // 0x4
	[NativeNameAttribute] // RVA: 0x70690 Offset: 0x6FA90 VA: 0x180070690
	public bool useOutsideNormalAngle; // 0x5
	[NativeNameAttribute] // RVA: 0x707E0 Offset: 0x6FBE0 VA: 0x1800707E0
	public LayerMask layerMask; // 0x8
	[NativeNameAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	public float minDepth; // 0xC
	[NativeNameAttribute] // RVA: 0x70A90 Offset: 0x6FE90 VA: 0x180070A90
	public float maxDepth; // 0x10
	[NativeNameAttribute] // RVA: 0x70B40 Offset: 0x6FF40 VA: 0x180070B40
	public float minNormalAngle; // 0x14
	[NativeNameAttribute] // RVA: 0x70CE0 Offset: 0x700E0 VA: 0x180070CE0
	public float maxNormalAngle; // 0x18


	private void CheckConsistency() { }

	public void SetLayerMask(LayerMask layerMask) { }

	public void SetDepth(float minDepth, float maxDepth) { }

	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }

}

