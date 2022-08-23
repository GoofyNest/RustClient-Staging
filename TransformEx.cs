public static class TransformEx // TypeDefIndex: 5615
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Transform FindChildRecursive(Transform transform, string name) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T GetOrAddComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D44F0 Offset: 0x5D2AF0 VA: 0x1805D44F0
	|-TransformEx.GetOrAddComponent<EntityCollisionMessage>
	|-TransformEx.GetOrAddComponent<MaterialReplacement>
	|-TransformEx.GetOrAddComponent<DDraw>
	|-TransformEx.GetOrAddComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void DestroyAllChildren(Transform transform, bool immediate = False) { }

}

public static class TransformEx // TypeDefIndex: 11708
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string GetRecursiveName(Transform transform, string strEndName = "") { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void RemoveComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D45B0 Offset: 0x5D2BB0 VA: 0x1805D45B0
	|-TransformEx.RemoveComponent<EntityCollisionMessage>
	|-TransformEx.RemoveComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void RetireAllChildren(Transform transform, GameManager gameManager) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static List<Transform> GetChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void OrderChildren(Transform tx, Func<Transform, object> selector) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static List<Transform> GetAllChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void AddAllChildren(Transform transform, List<Transform> list) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Transform[] GetChildrenWithTag(Transform transform, string strTag) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void Identity(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static GameObject CreateChild(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static GameObject InstantiateChild(GameObject go, GameObject prefab) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetLayerRecursive(GameObject go, int Layer) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool DropToGround(Transform transform, bool alignToNormal = False, float fRange = 100) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool GetGroundInfo(Transform transform, out Vector3 pos, out Vector3 normal, float range = 100) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool GetGroundInfoTerrainOnly(Transform transform, out Vector3 pos, out Vector3 normal, float range = 100) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Bounds WorkoutRenderBounds(Transform tx) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static List<T> GetSiblings<T>(Transform transform, bool includeSelf = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C3880 Offset: 0x12C1E80 VA: 0x1812C3880
	|-TransformEx.GetSiblings<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void DestroyChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetChildrenActive(Transform transform, bool b) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Transform ActiveChild(Transform transform, string name, bool bDisableOthers) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T GetComponentInChildrenIncludeDisabled<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA770 Offset: 0x15B8D70 VA: 0x1815BA770
	|-TransformEx.GetComponentInChildrenIncludeDisabled<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool HasComponentInChildrenIncludeDisabled<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4C60 Offset: 0xBF3260 VA: 0x180BF4C60
	|-TransformEx.HasComponentInChildrenIncludeDisabled<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetHierarchyGroup(Transform transform, string strRoot, bool groupActive = True, bool persistant = False) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Bounds GetBounds(Transform transform, bool includeRenderers = True, bool includeColliders = True, bool includeInactive = True) { }

}

private sealed class TransformEx.<>c__DisplayClass7_0 // TypeDefIndex: 11709
{	public string strTag; // 0x10


	public void .ctor() { }

	internal bool <GetChildrenWithTag>b__0(Transform x) { }

}

