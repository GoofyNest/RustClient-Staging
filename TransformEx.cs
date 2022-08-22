public static class TransformEx // TypeDefIndex: 5615
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992120 Offset: 0x1990720 VA: 0x181992120
	public static Transform FindChildRecursive(Transform transform, string name) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4420 Offset: 0x5D2A20 VA: 0x1805D4420
	|-TransformEx.GetOrAddComponent<EntityCollisionMessage>
	|-TransformEx.GetOrAddComponent<MaterialReplacement>
	|-TransformEx.GetOrAddComponent<DDraw>
	|-TransformEx.GetOrAddComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992000 Offset: 0x1990600 VA: 0x181992000
	public static void DestroyAllChildren(Transform transform, bool immediate = False) { }

}

public static class TransformEx // TypeDefIndex: 11708
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7490 Offset: 0x11E5A90 VA: 0x1811E7490
	public static string GetRecursiveName(Transform transform, string strEndName = "") { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void RemoveComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D44E0 Offset: 0x5D2AE0 VA: 0x1805D44E0
	|-TransformEx.RemoveComponent<EntityCollisionMessage>
	|-TransformEx.RemoveComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E78D0 Offset: 0x11E5ED0 VA: 0x1811E78D0
	public static void RetireAllChildren(Transform transform, GameManager gameManager) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7340 Offset: 0x11E5940 VA: 0x1811E7340
	public static List<Transform> GetChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7730 Offset: 0x11E5D30 VA: 0x1811E7730
	public static void OrderChildren(Transform tx, Func<Transform, object> selector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E6880 Offset: 0x11E4E80 VA: 0x1811E6880
	public static List<Transform> GetAllChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E64C0 Offset: 0x11E4AC0 VA: 0x1811E64C0
	public static void AddAllChildren(Transform transform, List<Transform> list) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7200 Offset: 0x11E5800 VA: 0x1811E7200
	public static Transform[] GetChildrenWithTag(Transform transform, string strTag) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7570 Offset: 0x11E5B70 VA: 0x1811E7570
	public static void Identity(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E65A0 Offset: 0x11E4BA0 VA: 0x1811E65A0
	public static GameObject CreateChild(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E76B0 Offset: 0x11E5CB0 VA: 0x1811E76B0
	public static GameObject InstantiateChild(GameObject go, GameObject prefab) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7D90 Offset: 0x11E6390 VA: 0x1811E7D90
	public static void SetLayerRecursive(GameObject go, int Layer) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E66F0 Offset: 0x11E4CF0 VA: 0x1811E66F0
	public static bool DropToGround(Transform transform, bool alignToNormal = False, float fRange = 100) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7400 Offset: 0x11E5A00 VA: 0x1811E7400
	public static bool GetGroundInfo(Transform transform, out Vector3 pos, out Vector3 normal, float range = 100) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7390 Offset: 0x11E5990 VA: 0x1811E7390
	public static bool GetGroundInfoTerrainOnly(Transform transform, out Vector3 pos, out Vector3 normal, float range = 100) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7E50 Offset: 0x11E6450 VA: 0x1811E7E50
	public static Bounds WorkoutRenderBounds(Transform tx) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static List<T> GetSiblings<T>(Transform transform, bool includeSelf = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C3840 Offset: 0x12C1E40 VA: 0x1812C3840
	|-TransformEx.GetSiblings<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E6640 Offset: 0x11E4C40 VA: 0x1811E6640
	public static void DestroyChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7C50 Offset: 0x11E6250 VA: 0x1811E7C50
	public static void SetChildrenActive(Transform transform, bool b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E63C0 Offset: 0x11E49C0 VA: 0x1811E63C0
	public static Transform ActiveChild(Transform transform, string name, bool bDisableOthers) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T GetComponentInChildrenIncludeDisabled<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA730 Offset: 0x15B8D30 VA: 0x1815BA730
	|-TransformEx.GetComponentInChildrenIncludeDisabled<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static bool HasComponentInChildrenIncludeDisabled<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4B20 Offset: 0xBF3120 VA: 0x180BF4B20
	|-TransformEx.HasComponentInChildrenIncludeDisabled<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E7CE0 Offset: 0x11E62E0 VA: 0x1811E7CE0
	public static void SetHierarchyGroup(Transform transform, string strRoot, bool groupActive = True, bool persistant = False) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11E6920 Offset: 0x11E4F20 VA: 0x1811E6920
	public static Bounds GetBounds(Transform transform, bool includeRenderers = True, bool includeColliders = True, bool includeInactive = True) { }

}

private sealed class TransformEx.<>c__DisplayClass7_0 // TypeDefIndex: 11709
{	// Fields
	public string strTag; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11E8180 Offset: 0x11E6780 VA: 0x1811E8180
	internal bool <GetChildrenWithTag>b__0(Transform x) { }

}

