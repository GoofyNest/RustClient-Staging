public class ScriptableObject : Object // TypeDefIndex: 3523
{	// Methods

	// RVA: 0x199BC90 Offset: 0x199A290 VA: 0x18199BC90
	public void .ctor() { }

	// RVA: 0x19A2350 Offset: 0x19A0950 VA: 0x1819A2350
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9F10 Offset: 0x15B8510 VA: 0x1815B9F10
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
	// RVA: 0x19A23E0 Offset: 0x19A09E0 VA: 0x1819A23E0
	private static void CreateScriptableObject(ScriptableObject self) { }

	[FreeFunctionAttribute] // RVA: 0xC3B00 Offset: 0xC2F00 VA: 0x1800C3B00
	// RVA: 0x19A2390 Offset: 0x19A0990 VA: 0x1819A2390
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

