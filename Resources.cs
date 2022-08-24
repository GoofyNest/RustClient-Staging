public sealed class Resources // TypeDefIndex: 3490
{
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-Resources.ConvertObjects<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB47C0 Offset: 0xB3BC0 VA: 0x1800B47C0
	[TypeInferenceRuleAttribute] // RVA: 0xB47C0 Offset: 0xB3BC0 VA: 0x1800B47C0
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

	[TypeInferenceRuleAttribute] // RVA: 0xB4910 Offset: 0xB3D10 VA: 0x1800B4910
	[FreeFunctionAttribute] // RVA: 0xB4910 Offset: 0xB3D10 VA: 0x1800B4910
	[NativeThrowsAttribute] // RVA: 0xB4910 Offset: 0xB3D10 VA: 0x1800B4910
	public static Object Load(string path, Type systemTypeInstance) { }

	[FreeFunctionAttribute] // RVA: 0xB4C60 Offset: 0xB4060 VA: 0x1800B4C60
	[NativeThrowsAttribute] // RVA: 0xB4C60 Offset: 0xB4060 VA: 0x1800B4C60
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	public static T[] LoadAll<T>(string path) { }
	/* GenericInstMethod :
	|
	|-Resources.LoadAll<Config>
	|-Resources.LoadAll<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xB5060 Offset: 0xB4460 VA: 0x1800B5060
	[FreeFunctionAttribute] // RVA: 0xB5060 Offset: 0xB4460 VA: 0x1800B5060
	public static Object GetBuiltinResource(Type type, string path) { }

	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-Resources.GetBuiltinResource<Font>
	|-Resources.GetBuiltinResource<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB66D0 Offset: 0xB5AD0 VA: 0x1800B66D0
	public static void UnloadAsset(Object assetToUnload) { }

	[FreeFunctionAttribute] // RVA: 0xB68D0 Offset: 0xB5CD0 VA: 0x1800B68D0
	public static AsyncOperation UnloadUnusedAssets() { }

}

