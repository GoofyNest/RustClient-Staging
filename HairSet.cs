public class HairSet : ScriptableObject // TypeDefIndex: 10742
{
	public HairSet.MeshReplace[] MeshReplacements; 


	public void Process(PlayerModelHair playerModelHair, HairDyeCollection dyeCollection, HairDye dye, MaterialPropertyBlock block) { }

	public void ProcessMorphs(GameObject obj, int blendShapeIndex = -1) { }

	public void .ctor() { }

}

public class HairSet.MeshReplace // TypeDefIndex: 10743
{
	[HideInInspector] 
	public string FindName; 
	public Mesh Find; 
	public Mesh[] ReplaceShapes; 


	public bool Test(string materialName) { }

	public void .ctor() { }

}

