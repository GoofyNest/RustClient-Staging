public class HairSet : ScriptableObject // TypeDefIndex: 10737
{	public HairSet.MeshReplace[] MeshReplacements; // 0x18


	public void Process(PlayerModelHair playerModelHair, HairDyeCollection dyeCollection, HairDye dye, MaterialPropertyBlock block) { }

	public void ProcessMorphs(GameObject obj, int blendShapeIndex = -1) { }

	public void .ctor() { }

}

public class HairSet.MeshReplace // TypeDefIndex: 10738
{	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public string FindName; // 0x10
	public Mesh Find; // 0x18
	public Mesh[] ReplaceShapes; // 0x20


	public bool Test(string materialName) { }

	public void .ctor() { }

}

