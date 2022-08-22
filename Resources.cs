public sealed class Resources // TypeDefIndex: 3490
{	// Methods

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A364F0 Offset: 0x1A34AF0 VA: 0x181A364F0
	|-Resources.ConvertObjects<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB4790 Offset: 0xB3B90 VA: 0x1800B4790
	[TypeInferenceRuleAttribute] // RVA: 0xB4790 Offset: 0xB3B90 VA: 0x1800B4790
	// RVA: 0x19A0FE0 Offset: 0x199F5E0 VA: 0x1819A0FE0
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfTypeAll<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B220 Offset: 0x1A39820 VA: 0x181A3B220
	|-Resources.FindObjectsOfTypeAll<LocalizeText>
	|-Resources.FindObjectsOfTypeAll<RustText>
	|-Resources.FindObjectsOfTypeAll<Cubemap>
	|-Resources.FindObjectsOfTypeAll<Material>
	|-Resources.FindObjectsOfTypeAll<Shader>
	|-Resources.FindObjectsOfTypeAll<object>
	*/

	// RVA: 0x19A10C0 Offset: 0x199F6C0 VA: 0x1819A10C0
	public static Object Load(string path) { }

	// RVA: -1 Offset: -1
	public static T Load<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9D00 Offset: 0x15B8300 VA: 0x1815B9D00
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
	// RVA: 0x19A1150 Offset: 0x199F750 VA: 0x1819A1150
	public static Object Load(string path, Type systemTypeInstance) { }

	[FreeFunctionAttribute] // RVA: 0xB4AF0 Offset: 0xB3EF0 VA: 0x1800B4AF0
	[NativeThrowsAttribute] // RVA: 0xB4AF0 Offset: 0xB3EF0 VA: 0x1800B4AF0
	// RVA: 0x19A1070 Offset: 0x199F670 VA: 0x1819A1070
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	// RVA: -1 Offset: -1
	public static T[] LoadAll<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B2A0 Offset: 0x1A398A0 VA: 0x181A3B2A0
	|-Resources.LoadAll<Config>
	|-Resources.LoadAll<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xB4DD0 Offset: 0xB41D0 VA: 0x1800B4DD0
	[FreeFunctionAttribute] // RVA: 0xB4DD0 Offset: 0xB41D0 VA: 0x1800B4DD0
	// RVA: 0x19A1020 Offset: 0x199F620 VA: 0x1819A1020
	public static Object GetBuiltinResource(Type type, string path) { }

	// RVA: -1 Offset: -1
	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9C40 Offset: 0x15B8240 VA: 0x1815B9C40
	|-Resources.GetBuiltinResource<Font>
	|-Resources.GetBuiltinResource<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB64E0 Offset: 0xB58E0 VA: 0x1800B64E0
	// RVA: 0x19A11A0 Offset: 0x199F7A0 VA: 0x1819A11A0
	public static void UnloadAsset(Object assetToUnload) { }

	[FreeFunctionAttribute] // RVA: 0xB6710 Offset: 0xB5B10 VA: 0x1800B6710
	// RVA: 0x19A11E0 Offset: 0x199F7E0 VA: 0x1819A11E0
	public static AsyncOperation UnloadUnusedAssets() { }

}

