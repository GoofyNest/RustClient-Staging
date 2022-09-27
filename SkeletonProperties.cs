public class SkeletonProperties : ScriptableObject // TypeDefIndex: 11691
{
	public GameObject boneReference; 
	[BonePropertyAttribute] 
	public SkeletonProperties.BoneProperty[] bones; 
	private Dictionary<uint, SkeletonProperties.BoneProperty> quickLookup; 


	public void OnValidate() { }

	private void BuildDictionary() { }

	public SkeletonProperties.BoneProperty FindBone(uint id) { }

	public void .ctor() { }

}

public class SkeletonProperties.BoneProperty // TypeDefIndex: 11692
{
	public GameObject bone; 
	public Translate.Phrase name; 
	public HitArea area; 


	public void .ctor() { }

}

private sealed class SkeletonProperties.<>c__DisplayClass3_0 // TypeDefIndex: 11693
{
	public Transform child; 


	public void .ctor() { }

	internal bool <OnValidate>b__0(SkeletonProperties.BoneProperty x) { }

}

