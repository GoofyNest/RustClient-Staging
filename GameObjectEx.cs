public static class GameObjectEx // TypeDefIndex: 11701
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static BaseEntity ToBaseEntity(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static BaseEntity ToBaseEntity(Collider collider) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static BaseEntity ToBaseEntity(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool IsOnLayer(GameObject go, Layer rustLayer) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool IsOnLayer(GameObject go, int layer) { }

	private static IEntity GetEntityFromRegistry(Transform transform) { }

	private static IEntity GetEntityFromComponent(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetHierarchyGroup(GameObject obj, string strRoot, bool groupActive = True, bool persistant = False) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool HasComponent<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2CB0 Offset: 0xBF12B0 VA: 0x180BF2CB0
	|-GameObjectEx.HasComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetChildComponentsEnabled<T>(GameObject gameObject, bool enabled) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CDE90 Offset: 0x5CC490 VA: 0x1805CDE90
	|-GameObjectEx.SetChildComponentsEnabled<object>
	|-GameObjectEx.SetChildComponentsEnabled<TMP_Text>
	*/

}

