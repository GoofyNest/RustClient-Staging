public class HairSet : ScriptableObject // TypeDefIndex: 10733
{	// Fields
	public HairSet.MeshReplace[] MeshReplacements; // 0x18

	// Methods

	// RVA: 0x734EA0 Offset: 0x7334A0 VA: 0x180734EA0
	public void Process(PlayerModelHair playerModelHair, HairDyeCollection dyeCollection, HairDye dye, MaterialPropertyBlock block) { }

	// RVA: 0x734CF0 Offset: 0x7332F0 VA: 0x180734CF0
	public void ProcessMorphs(GameObject obj, int blendShapeIndex = -1) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class HairSet.MeshReplace // TypeDefIndex: 10734
{	// Fields
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public string FindName; // 0x10
	public Mesh Find; // 0x18
	public Mesh[] ReplaceShapes; // 0x20

	// Methods

	// RVA: 0x7491E0 Offset: 0x7477E0 VA: 0x1807491E0
	public bool Test(string materialName) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

