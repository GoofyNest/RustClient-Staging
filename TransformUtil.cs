public static class TransformUtil // TypeDefIndex: 11409
{	// Methods

	// RVA: 0xA18000 Offset: 0xA16600 VA: 0x180A18000
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hit, Transform ignoreTransform) { }

	// RVA: 0xA17F80 Offset: 0xA16580 VA: 0x180A17F80
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hit, float range, Transform ignoreTransform) { }

	// RVA: 0xA17710 Offset: 0xA15D10 VA: 0x180A17710
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hitOut, float range, LayerMask mask, Transform ignoreTransform) { }

	// RVA: 0xA18070 Offset: 0xA16670 VA: 0x180A18070
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, Transform ignoreTransform) { }

	// RVA: 0xA17F00 Offset: 0xA16500 VA: 0x180A17F00
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, Transform ignoreTransform) { }

	// RVA: 0xA17A10 Offset: 0xA16010 VA: 0x180A17A10
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, LayerMask mask, Transform ignoreTransform) { }

	// RVA: 0xA17490 Offset: 0xA15A90 VA: 0x180A17490
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal) { }

	// RVA: 0xA17420 Offset: 0xA15A20 VA: 0x180A17420
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range) { }

	// RVA: 0xA17500 Offset: 0xA15B00 VA: 0x180A17500
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, LayerMask mask) { }

	// RVA: 0xA180F0 Offset: 0xA166F0 VA: 0x180A180F0
	public static Transform[] GetRootObjects() { }

}

private sealed class TransformUtil.<>c // TypeDefIndex: 11410
{	// Fields
	public static readonly TransformUtil.<>c <>9; // 0x0
	public static Func<Transform, bool> <>9__9_0; // 0x8

	// Methods

	// RVA: 0xA23970 Offset: 0xA21F70 VA: 0x180A23970
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA23830 Offset: 0xA21E30 VA: 0x180A23830
	internal bool <GetRootObjects>b__9_0(Transform x) { }

}

