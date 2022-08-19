public sealed class Resources // TypeDefIndex: 3490
{	// Methods

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36B50 Offset: 0x1A35150 VA: 0x181A36B50
	|-Resources.ConvertObjects<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB46F0 Offset: 0xB3AF0 VA: 0x1800B46F0
	[TypeInferenceRuleAttribute] // RVA: 0xB46F0 Offset: 0xB3AF0 VA: 0x1800B46F0
	// RVA: 0x19B3960 Offset: 0x19B1F60 VA: 0x1819B3960
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfTypeAll<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B880 Offset: 0x1A39E80 VA: 0x181A3B880
	|-Resources.FindObjectsOfTypeAll<LocalizeText>
	|-Resources.FindObjectsOfTypeAll<RustText>
	|-Resources.FindObjectsOfTypeAll<Cubemap>
	|-Resources.FindObjectsOfTypeAll<Material>
	|-Resources.FindObjectsOfTypeAll<Shader>
	|-Resources.FindObjectsOfTypeAll<object>
	*/

	// RVA: 0x19B3A40 Offset: 0x19B2040 VA: 0x1819B3A40
	public static Object Load(string path) { }

	// RVA: -1 Offset: -1
	public static T Load<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA970 Offset: 0x15B8F70 VA: 0x1815BA970
	|-Resources.Load<GameModeManifest>
	|-Resources.Load<MissionManifest>
	|-Resources.Load<TMP_ColorGradient>
	|-Resources.Load<TMP_FontAsset>
	|-Resources.Load<TMP_Settings>
	|-Resources.Load<TrainWagonLootData>
	|-Resources.Load<UnderwearManifest>
	|-Resources.Load<GUISkin>
	|-Resources.Load<GameObject>
	|-Resources.Load<Material>
	|-Resources.Load<TextAsset>
	|-Resources.Load<Texture2D>
	|-Resources.Load<WorldSplineSharedData>
	|-Resources.Load<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xB4860 Offset: 0xB3C60 VA: 0x1800B4860
	[FreeFunctionAttribute] // RVA: 0xB4860 Offset: 0xB3C60 VA: 0x1800B4860
	[NativeThrowsAttribute] // RVA: 0xB4860 Offset: 0xB3C60 VA: 0x1800B4860
	// RVA: 0x19B3AD0 Offset: 0x19B20D0 VA: 0x1819B3AD0
	public static Object Load(string path, Type systemTypeInstance) { }

	[FreeFunctionAttribute] // RVA: 0xB4A50 Offset: 0xB3E50 VA: 0x1800B4A50
	[NativeThrowsAttribute] // RVA: 0xB4A50 Offset: 0xB3E50 VA: 0x1800B4A50
	// RVA: 0x19B39F0 Offset: 0x19B1FF0 VA: 0x1819B39F0
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	// RVA: -1 Offset: -1
	public static T[] LoadAll<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B900 Offset: 0x1A39F00 VA: 0x181A3B900
	|-Resources.LoadAll<Config>
	|-Resources.LoadAll<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB4DD0 Offset: 0xB41D0 VA: 0x1800B4DD0
	[TypeInferenceRuleAttribute] // RVA: 0xB4DD0 Offset: 0xB41D0 VA: 0x1800B4DD0
	// RVA: 0x19B39A0 Offset: 0x19B1FA0 VA: 0x1819B39A0
	public static Object GetBuiltinResource(Type type, string path) { }

	// RVA: -1 Offset: -1
	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA8B0 Offset: 0x15B8EB0 VA: 0x1815BA8B0
	|-Resources.GetBuiltinResource<Font>
	|-Resources.GetBuiltinResource<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB6470 Offset: 0xB5870 VA: 0x1800B6470
	// RVA: 0x19B3B20 Offset: 0x19B2120 VA: 0x1819B3B20
	public static void UnloadAsset(Object assetToUnload) { }

	[FreeFunctionAttribute] // RVA: 0xB66D0 Offset: 0xB5AD0 VA: 0x1800B66D0
	// RVA: 0x19B3B60 Offset: 0x19B2160 VA: 0x1819B3B60
	public static AsyncOperation UnloadUnusedAssets() { }

}

