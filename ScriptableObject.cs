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

	[NativeMethodAttribute] // RVA: 0x90760 Offset: 0x8FB60 VA: 0x180090760
	private static void CreateScriptableObject(ScriptableObject self) { }

	[FreeFunctionAttribute] // RVA: 0xC3BD0 Offset: 0xC2FD0 VA: 0x1800C3BD0
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

