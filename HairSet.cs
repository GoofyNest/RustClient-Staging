public class HairSet : ScriptableObject // TypeDefIndex: 10733
{	// Fields
	public HairSet.MeshReplace[] MeshReplacements; // 0x18

	// Methods

	// RVA: 0x734FB0 Offset: 0x7335B0 VA: 0x180734FB0
	public void Process(PlayerModelHair playerModelHair, HairDyeCollection dyeCollection, HairDye dye, MaterialPropertyBlock block) { }

	// RVA: 0x734E00 Offset: 0x733400 VA: 0x180734E00
	public void ProcessMorphs(GameObject obj, int blendShapeIndex = -1) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class HairSet.MeshReplace // TypeDefIndex: 10734
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string FindName; // 0x10
	public Mesh Find; // 0x18
	public Mesh[] ReplaceShapes; // 0x20

	// Methods

	// RVA: 0x7492F0 Offset: 0x7478F0 VA: 0x1807492F0
	public bool Test(string materialName) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

