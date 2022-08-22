public class HairSet : ScriptableObject // TypeDefIndex: 10733
{	// Fields
	public HairSet.MeshReplace[] MeshReplacements; // 0x18

	// Methods

	// RVA: 0x734F00 Offset: 0x733500 VA: 0x180734F00
	public void Process(PlayerModelHair playerModelHair, HairDyeCollection dyeCollection, HairDye dye, MaterialPropertyBlock block) { }

	// RVA: 0x734D50 Offset: 0x733350 VA: 0x180734D50
	public void ProcessMorphs(GameObject obj, int blendShapeIndex = -1) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public class HairSet.MeshReplace // TypeDefIndex: 10734
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string FindName; // 0x10
	public Mesh Find; // 0x18
	public Mesh[] ReplaceShapes; // 0x20

	// Methods

	// RVA: 0x749240 Offset: 0x747840 VA: 0x180749240
	public bool Test(string materialName) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

