public static class GameObjectEx // TypeDefIndex: 11701
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FDCA0 Offset: 0x9FC2A0 VA: 0x1809FDCA0
	public static BaseEntity ToBaseEntity(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FDF60 Offset: 0x9FC560 VA: 0x1809FDF60
	public static BaseEntity ToBaseEntity(Collider collider) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FDCD0 Offset: 0x9FC2D0 VA: 0x1809FDCD0
	public static BaseEntity ToBaseEntity(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FDB50 Offset: 0x9FC150 VA: 0x1809FDB50
	public static bool IsOnLayer(GameObject go, Layer rustLayer) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FDB50 Offset: 0x9FC150 VA: 0x1809FDB50
	public static bool IsOnLayer(GameObject go, int layer) { }

	// RVA: 0x9FDA20 Offset: 0x9FC020 VA: 0x1809FDA20
	private static IEntity GetEntityFromRegistry(Transform transform) { }

	// RVA: 0x9FD920 Offset: 0x9FBF20 VA: 0x1809FD920
	private static IEntity GetEntityFromComponent(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FDBE0 Offset: 0x9FC1E0 VA: 0x1809FDBE0
	public static void SetHierarchyGroup(GameObject obj, string strRoot, bool groupActive = True, bool persistant = False) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static bool HasComponent<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2CB0 Offset: 0xBF12B0 VA: 0x180BF2CB0
	|-GameObjectEx.HasComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void SetChildComponentsEnabled<T>(GameObject gameObject, bool enabled) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CDE90 Offset: 0x5CC490 VA: 0x1805CDE90
	|-GameObjectEx.SetChildComponentsEnabled<object>
	|-GameObjectEx.SetChildComponentsEnabled<TMP_Text>
	*/

}

