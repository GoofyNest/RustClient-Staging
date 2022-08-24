public sealed class Resources // TypeDefIndex: 3490
{
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-Resources.ConvertObjects<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB47E0 Offset: 0xB3BE0 VA: 0x1800B47E0
	[TypeInferenceRuleAttribute] // RVA: 0xB47E0 Offset: 0xB3BE0 VA: 0x1800B47E0
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	public static T[] FindObjectsOfTypeAll<T>() { }
	/* GenericInstMethod :
	|
	|-Resources.FindObjectsOfTypeAll<LocalizeText>
	|-Resources.FindObjectsOfTypeAll<RustText>
	|-Resources.FindObjectsOfTypeAll<Cubemap>
	|-Resources.FindObjectsOfTypeAll<Material>
	|-Resources.FindObjectsOfTypeAll<Shader>
	|-Resources.FindObjectsOfTypeAll<object>
	*/

	public static Object Load(string path) { }

	public static T Load<T>(string path) { }
	/* GenericInstMethod :
	|
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

	[TypeInferenceRuleAttribute] // RVA: 0xB49C0 Offset: 0xB3DC0 VA: 0x1800B49C0
	[FreeFunctionAttribute] // RVA: 0xB49C0 Offset: 0xB3DC0 VA: 0x1800B49C0
	[NativeThrowsAttribute] // RVA: 0xB49C0 Offset: 0xB3DC0 VA: 0x1800B49C0
	public static Object Load(string path, Type systemTypeInstance) { }

	[FreeFunctionAttribute] // RVA: 0xB4C00 Offset: 0xB4000 VA: 0x1800B4C00
	[NativeThrowsAttribute] // RVA: 0xB4C00 Offset: 0xB4000 VA: 0x1800B4C00
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	public static T[] LoadAll<T>(string path) { }
	/* GenericInstMethod :
	|
	|-Resources.LoadAll<Config>
	|-Resources.LoadAll<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xB4EE0 Offset: 0xB42E0 VA: 0x1800B4EE0
	[FreeFunctionAttribute] // RVA: 0xB4EE0 Offset: 0xB42E0 VA: 0x1800B4EE0
	public static Object GetBuiltinResource(Type type, string path) { }

	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-Resources.GetBuiltinResource<Font>
	|-Resources.GetBuiltinResource<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB65C0 Offset: 0xB59C0 VA: 0x1800B65C0
	public static void UnloadAsset(Object assetToUnload) { }

	[FreeFunctionAttribute] // RVA: 0xB6750 Offset: 0xB5B50 VA: 0x1800B6750
	public static AsyncOperation UnloadUnusedAssets() { }

}

