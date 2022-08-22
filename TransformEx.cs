public static class TransformEx // TypeDefIndex: 5615
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A4D20 Offset: 0x19A3320 VA: 0x1819A4D20
	public static Transform FindChildRecursive(Transform transform, string name) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4490 Offset: 0x5D2A90 VA: 0x1805D4490
	|-TransformEx.GetOrAddComponent<EntityCollisionMessage>
	|-TransformEx.GetOrAddComponent<MaterialReplacement>
	|-TransformEx.GetOrAddComponent<DDraw>
	|-TransformEx.GetOrAddComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A4C00 Offset: 0x19A3200 VA: 0x1819A4C00
	public static void DestroyAllChildren(Transform transform, bool immediate = False) { }

}

public static class TransformEx // TypeDefIndex: 11708
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E6DF0 Offset: 0x11E53F0 VA: 0x1811E6DF0
	public static string GetRecursiveName(Transform transform, string strEndName = "") { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void RemoveComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4550 Offset: 0x5D2B50 VA: 0x1805D4550
	|-TransformEx.RemoveComponent<EntityCollisionMessage>
	|-TransformEx.RemoveComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7230 Offset: 0x11E5830 VA: 0x1811E7230
	public static void RetireAllChildren(Transform transform, GameManager gameManager) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E6CA0 Offset: 0x11E52A0 VA: 0x1811E6CA0
	public static List<Transform> GetChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7090 Offset: 0x11E5690 VA: 0x1811E7090
	public static void OrderChildren(Transform tx, Func<Transform, object> selector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E61E0 Offset: 0x11E47E0 VA: 0x1811E61E0
	public static List<Transform> GetAllChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E5E20 Offset: 0x11E4420 VA: 0x1811E5E20
	public static void AddAllChildren(Transform transform, List<Transform> list) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E6B60 Offset: 0x11E5160 VA: 0x1811E6B60
	public static Transform[] GetChildrenWithTag(Transform transform, string strTag) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E6ED0 Offset: 0x11E54D0 VA: 0x1811E6ED0
	public static void Identity(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E5F00 Offset: 0x11E4500 VA: 0x1811E5F00
	public static GameObject CreateChild(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7010 Offset: 0x11E5610 VA: 0x1811E7010
	public static GameObject InstantiateChild(GameObject go, GameObject prefab) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E76F0 Offset: 0x11E5CF0 VA: 0x1811E76F0
	public static void SetLayerRecursive(GameObject go, int Layer) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E6050 Offset: 0x11E4650 VA: 0x1811E6050
	public static bool DropToGround(Transform transform, bool alignToNormal = False, float fRange = 100) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E6D60 Offset: 0x11E5360 VA: 0x1811E6D60
	public static bool GetGroundInfo(Transform transform, out Vector3 pos, out Vector3 normal, float range = 100) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E6CF0 Offset: 0x11E52F0 VA: 0x1811E6CF0
	public static bool GetGroundInfoTerrainOnly(Transform transform, out Vector3 pos, out Vector3 normal, float range = 100) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E77B0 Offset: 0x11E5DB0 VA: 0x1811E77B0
	public static Bounds WorkoutRenderBounds(Transform tx) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static List<T> GetSiblings<T>(Transform transform, bool includeSelf = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C31A0 Offset: 0x12C17A0 VA: 0x1812C31A0
	|-TransformEx.GetSiblings<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E5FA0 Offset: 0x11E45A0 VA: 0x1811E5FA0
	public static void DestroyChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E75B0 Offset: 0x11E5BB0 VA: 0x1811E75B0
	public static void SetChildrenActive(Transform transform, bool b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E5D20 Offset: 0x11E4320 VA: 0x1811E5D20
	public static Transform ActiveChild(Transform transform, string name, bool bDisableOthers) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T GetComponentInChildrenIncludeDisabled<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BB660 Offset: 0x15B9C60 VA: 0x1815BB660
	|-TransformEx.GetComponentInChildrenIncludeDisabled<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static bool HasComponentInChildrenIncludeDisabled<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4650 Offset: 0xBF2C50 VA: 0x180BF4650
	|-TransformEx.HasComponentInChildrenIncludeDisabled<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7640 Offset: 0x11E5C40 VA: 0x1811E7640
	public static void SetHierarchyGroup(Transform transform, string strRoot, bool groupActive = True, bool persistant = False) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E6280 Offset: 0x11E4880 VA: 0x1811E6280
	public static Bounds GetBounds(Transform transform, bool includeRenderers = True, bool includeColliders = True, bool includeInactive = True) { }

}

private sealed class TransformEx.<>c__DisplayClass7_0 // TypeDefIndex: 11709
{	// Fields
	public string strTag; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11E7AE0 Offset: 0x11E60E0 VA: 0x1811E7AE0
	internal bool <GetChildrenWithTag>b__0(Transform x) { }

}

