public class ScriptableObject : Object // TypeDefIndex: 3523
{	// Methods

	// RVA: 0x19AE5D0 Offset: 0x19ACBD0 VA: 0x1819AE5D0
	public void .ctor() { }

	// RVA: 0x19B4C90 Offset: 0x19B3290 VA: 0x1819B4C90
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAB80 Offset: 0x15B9180 VA: 0x1815BAB80
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
	// RVA: 0x19B4D20 Offset: 0x19B3320 VA: 0x1819B4D20
	private static void CreateScriptableObject(ScriptableObject self) { }

	[FreeFunctionAttribute] // RVA: 0xC3B00 Offset: 0xC2F00 VA: 0x1800C3B00
	// RVA: 0x19B4CD0 Offset: 0x19B32D0 VA: 0x1819B4CD0
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

