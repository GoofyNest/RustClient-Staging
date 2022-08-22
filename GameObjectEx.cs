public static class GameObjectEx // TypeDefIndex: 11701
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD7B0 Offset: 0x9FBDB0 VA: 0x1809FD7B0
	public static BaseEntity ToBaseEntity(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FDA70 Offset: 0x9FC070 VA: 0x1809FDA70
	public static BaseEntity ToBaseEntity(Collider collider) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD7E0 Offset: 0x9FBDE0 VA: 0x1809FD7E0
	public static BaseEntity ToBaseEntity(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD660 Offset: 0x9FBC60 VA: 0x1809FD660
	public static bool IsOnLayer(GameObject go, Layer rustLayer) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD660 Offset: 0x9FBC60 VA: 0x1809FD660
	public static bool IsOnLayer(GameObject go, int layer) { }

	// RVA: 0x9FD530 Offset: 0x9FBB30 VA: 0x1809FD530
	private static IEntity GetEntityFromRegistry(Transform transform) { }

	// RVA: 0x9FD430 Offset: 0x9FBA30 VA: 0x1809FD430
	private static IEntity GetEntityFromComponent(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD6F0 Offset: 0x9FBCF0 VA: 0x1809FD6F0
	public static void SetHierarchyGroup(GameObject obj, string strRoot, bool groupActive = True, bool persistant = False) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static bool HasComponent<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF27E0 Offset: 0xBF0DE0 VA: 0x180BF27E0
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

