public class ScriptableObject : Object // TypeDefIndex: 3523
{
	public void .ctor() { }

	public static ScriptableObject CreateInstance(Type type) { }

	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
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

	[NativeMethodAttribute] // RVA: 0x90660 Offset: 0x8FA60 VA: 0x180090660
	private static void CreateScriptableObject(ScriptableObject self) { }

	[FreeFunctionAttribute] // RVA: 0xC3DE0 Offset: 0xC31E0 VA: 0x1800C3DE0
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

