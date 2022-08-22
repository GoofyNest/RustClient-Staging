public static class TransformUtil // TypeDefIndex: 11409
{	// Methods

	// RVA: 0xA17B10 Offset: 0xA16110 VA: 0x180A17B10
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hit, Transform ignoreTransform) { }

	// RVA: 0xA17A90 Offset: 0xA16090 VA: 0x180A17A90
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hit, float range, Transform ignoreTransform) { }

	// RVA: 0xA17220 Offset: 0xA15820 VA: 0x180A17220
	public static bool GetGroundInfo(Vector3 startPos, out RaycastHit hitOut, float range, LayerMask mask, Transform ignoreTransform) { }

	// RVA: 0xA17B80 Offset: 0xA16180 VA: 0x180A17B80
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, Transform ignoreTransform) { }

	// RVA: 0xA17A10 Offset: 0xA16010 VA: 0x180A17A10
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, Transform ignoreTransform) { }

	// RVA: 0xA17520 Offset: 0xA15B20 VA: 0x180A17520
	public static bool GetGroundInfo(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, LayerMask mask, Transform ignoreTransform) { }

	// RVA: 0xA16FA0 Offset: 0xA155A0 VA: 0x180A16FA0
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal) { }

	// RVA: 0xA16F30 Offset: 0xA15530 VA: 0x180A16F30
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range) { }

	// RVA: 0xA17010 Offset: 0xA15610 VA: 0x180A17010
	public static bool GetGroundInfoTerrainOnly(Vector3 startPos, out Vector3 pos, out Vector3 normal, float range, LayerMask mask) { }

	// RVA: 0xA17C00 Offset: 0xA16200 VA: 0x180A17C00
	public static Transform[] GetRootObjects() { }

}

private sealed class TransformUtil.<>c // TypeDefIndex: 11410
{	// Fields
	public static readonly TransformUtil.<>c <>9; // 0x0
	public static Func<Transform, bool> <>9__9_0; // 0x8

	// Methods

	// RVA: 0xA23480 Offset: 0xA21A80 VA: 0x180A23480
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA23340 Offset: 0xA21940 VA: 0x180A23340
	internal bool <GetRootObjects>b__9_0(Transform x) { }

}

