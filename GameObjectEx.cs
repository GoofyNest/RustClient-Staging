public static class GameObjectEx // TypeDefIndex: 11701
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD4F0 Offset: 0x9FBAF0 VA: 0x1809FD4F0
	public static BaseEntity ToBaseEntity(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD7B0 Offset: 0x9FBDB0 VA: 0x1809FD7B0
	public static BaseEntity ToBaseEntity(Collider collider) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD520 Offset: 0x9FBB20 VA: 0x1809FD520
	public static BaseEntity ToBaseEntity(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD3A0 Offset: 0x9FB9A0 VA: 0x1809FD3A0
	public static bool IsOnLayer(GameObject go, Layer rustLayer) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD3A0 Offset: 0x9FB9A0 VA: 0x1809FD3A0
	public static bool IsOnLayer(GameObject go, int layer) { }

	// RVA: 0x9FD270 Offset: 0x9FB870 VA: 0x1809FD270
	private static IEntity GetEntityFromRegistry(Transform transform) { }

	// RVA: 0x9FD170 Offset: 0x9FB770 VA: 0x1809FD170
	private static IEntity GetEntityFromComponent(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD430 Offset: 0x9FBA30 VA: 0x1809FD430
	public static void SetHierarchyGroup(GameObject obj, string strRoot, bool groupActive = True, bool persistant = False) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static bool HasComponent<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2520 Offset: 0xBF0B20 VA: 0x180BF2520
	|-GameObjectEx.HasComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void SetChildComponentsEnabled<T>(GameObject gameObject, bool enabled) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CDF00 Offset: 0x5CC500 VA: 0x1805CDF00
	|-GameObjectEx.SetChildComponentsEnabled<object>
	|-GameObjectEx.SetChildComponentsEnabled<TMP_Text>
	*/

}

