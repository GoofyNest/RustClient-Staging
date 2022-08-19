public static class TransformUtil // TypeDefIndex: 11409
{	// Methods

	// RVA: 0xA17850 Offset: 0xA15E50 VA: 0x180A17850
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hit, Transform ignoreTransform) { }

	// RVA: 0xA177D0 Offset: 0xA15DD0 VA: 0x180A177D0
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hit, float range, Transform ignoreTransform) { }

	// RVA: 0xA16F60 Offset: 0xA15560 VA: 0x180A16F60
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hitOut, float range, LayerMask mask, Transform ignoreTransform) { }

	// RVA: 0xA178C0 Offset: 0xA15EC0 VA: 0x180A178C0
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, Transform ignoreTransform) { }

	// RVA: 0xA17750 Offset: 0xA15D50 VA: 0x180A17750
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, Transform ignoreTransform) { }

	// RVA: 0xA17260 Offset: 0xA15860 VA: 0x180A17260
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, LayerMask mask, Transform ignoreTransform) { }

	// RVA: 0xA16CE0 Offset: 0xA152E0 VA: 0x180A16CE0
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal) { }

	// RVA: 0xA16C70 Offset: 0xA15270 VA: 0x180A16C70
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range) { }

	// RVA: 0xA16D50 Offset: 0xA15350 VA: 0x180A16D50
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, LayerMask mask) { }

	// RVA: 0xA17940 Offset: 0xA15F40 VA: 0x180A17940
	public static Transform[] GetRootObjects() { }

}

private sealed class TransformUtil.<>c // TypeDefIndex: 11410
{	// Fields
	public static readonly TransformUtil.<>c <>9; // 0x0
	public static Func<Transform, bool> <>9__9_0; // 0x8

	// Methods

	// RVA: 0xA231C0 Offset: 0xA217C0 VA: 0x180A231C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA23080 Offset: 0xA21680 VA: 0x180A23080
	internal bool <GetRootObjects>b__9_0(Transform x) { }

}

