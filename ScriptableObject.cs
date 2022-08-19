public class ScriptableObject : Object // TypeDefIndex: 3523
{	// Methods

	// RVA: 0x19AE610 Offset: 0x19ACC10 VA: 0x1819AE610
	public void .ctor() { }

	// RVA: 0x19B4CD0 Offset: 0x19B32D0 VA: 0x1819B4CD0
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

	[NativeMethodAttribute] // RVA: 0x90510 Offset: 0x8F910 VA: 0x180090510
	// RVA: 0x19B4D60 Offset: 0x19B3360 VA: 0x1819B4D60
	private static void CreateScriptableObject(ScriptableObject self) { }

	[FreeFunctionAttribute] // RVA: 0xC3A70 Offset: 0xC2E70 VA: 0x1800C3A70
	// RVA: 0x19B4D10 Offset: 0x19B3310 VA: 0x1819B4D10
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

