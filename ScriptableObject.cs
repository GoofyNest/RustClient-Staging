public class ScriptableObject : Object // TypeDefIndex: 3523
{
	public void .ctor() { }

	public static ScriptableObject CreateInstance(Type type) { }

	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BA050 Offset: 0x15B8650 VA: 0x1815BA050
	|-ScriptableObject.CreateInstance<EZSoftBoneMaterial>
	|-ScriptableObject.CreateInstance<ERDecal>
	|-ScriptableObject.CreateInstance<ERLocalGrid>
	|-ScriptableObject.CreateInstance<ERMarkerExt>
	|-ScriptableObject.CreateInstance<ERMaterial>
	|-ScriptableObject.CreateInstance<ERSOMarkerExt>
	|-ScriptableObject.CreateInstance<ERSORoadExt>
	|-ScriptableObject.CreateInstance<SelectedObject>
	|-ScriptableObject.CreateInstance<BurstClothMaterial>
	|-ScriptableObject.CreateInstance<ProtectionProperties>
	|-ScriptableObject.CreateInstance<TMP_FontAsset>
	|-ScriptableObject.CreateInstance<PostProcessProfile>
	|-ScriptableObject.CreateInstance<object>
	|-ScriptableObject.CreateInstance<PlayerConnection>
	*/

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	private static void CreateScriptableObject(ScriptableObject self) { }

	[FreeFunctionAttribute] // RVA: 0xC3B00 Offset: 0xC2F00 VA: 0x1800C3B00
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

