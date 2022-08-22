public sealed class Resources // TypeDefIndex: 3490
{	// Methods

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36B10 Offset: 0x1A35110 VA: 0x181A36B10
	|-Resources.ConvertObjects<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB4790 Offset: 0xB3B90 VA: 0x1800B4790
	[TypeInferenceRuleAttribute] // RVA: 0xB4790 Offset: 0xB3B90 VA: 0x1800B4790
	// RVA: 0x19B3920 Offset: 0x19B1F20 VA: 0x1819B3920
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfTypeAll<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B840 Offset: 0x1A39E40 VA: 0x181A3B840
	|-Resources.FindObjectsOfTypeAll<LocalizeText>
	|-Resources.FindObjectsOfTypeAll<RustText>
	|-Resources.FindObjectsOfTypeAll<Cubemap>
	|-Resources.FindObjectsOfTypeAll<Material>
	|-Resources.FindObjectsOfTypeAll<Shader>
	|-Resources.FindObjectsOfTypeAll<object>
	*/

	// RVA: 0x19B3A00 Offset: 0x19B2000 VA: 0x1819B3A00
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

	[TypeInferenceRuleAttribute] // RVA: 0xB4900 Offset: 0xB3D00 VA: 0x1800B4900
	[FreeFunctionAttribute] // RVA: 0xB4900 Offset: 0xB3D00 VA: 0x1800B4900
	[NativeThrowsAttribute] // RVA: 0xB4900 Offset: 0xB3D00 VA: 0x1800B4900
	// RVA: 0x19B3A90 Offset: 0x19B2090 VA: 0x1819B3A90
	public static Object Load(string path, Type systemTypeInstance) { }

	[FreeFunctionAttribute] // RVA: 0xB4AF0 Offset: 0xB3EF0 VA: 0x1800B4AF0
	[NativeThrowsAttribute] // RVA: 0xB4AF0 Offset: 0xB3EF0 VA: 0x1800B4AF0
	// RVA: 0x19B39B0 Offset: 0x19B1FB0 VA: 0x1819B39B0
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	// RVA: -1 Offset: -1
	public static T[] LoadAll<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B8C0 Offset: 0x1A39EC0 VA: 0x181A3B8C0
	|-Resources.LoadAll<Config>
	|-Resources.LoadAll<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xB4DD0 Offset: 0xB41D0 VA: 0x1800B4DD0
	[FreeFunctionAttribute] // RVA: 0xB4DD0 Offset: 0xB41D0 VA: 0x1800B4DD0
	// RVA: 0x19B3960 Offset: 0x19B1F60 VA: 0x1819B3960
	public static Object GetBuiltinResource(Type type, string path) { }

	// RVA: -1 Offset: -1
	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA8B0 Offset: 0x15B8EB0 VA: 0x1815BA8B0
	|-Resources.GetBuiltinResource<Font>
	|-Resources.GetBuiltinResource<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB64E0 Offset: 0xB58E0 VA: 0x1800B64E0
	// RVA: 0x19B3AE0 Offset: 0x19B20E0 VA: 0x1819B3AE0
	public static void UnloadAsset(Object assetToUnload) { }

	[FreeFunctionAttribute] // RVA: 0xB6710 Offset: 0xB5B10 VA: 0x1800B6710
	// RVA: 0x19B3B20 Offset: 0x19B2120 VA: 0x1819B3B20
	public static AsyncOperation UnloadUnusedAssets() { }

}

