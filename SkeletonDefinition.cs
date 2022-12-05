public class SkeletonDefinition : ScriptableObject // TypeDefIndex: 7363
{
	public GameObject SourceObject;
	public SkeletonDefinition.Bone[] Bones;
	public SkeletonDefinition.RagdollSettings Ragdoll;


	public SkeletonDefinition.Bone FindBone(string name) { }

	public void .ctor() { }

}

public struct SkeletonDefinition.Bone // TypeDefIndex: 7364
{
	public int Id;
	public int Depth;
	public int Parent;
	public string Name;
	public GameObject Target;
	public BoneFlag Flags;

}

public struct SkeletonDefinition.RagdollSettings // TypeDefIndex: 7365
{
	public int Pelvis;
	public int Head;
	public int Spine;
	public SkeletonDefinition.RagdollSettings.BodySide Left;
	public SkeletonDefinition.RagdollSettings.BodySide Right;
	public float Mass;
	public float ArmGirth;
	public float LegGirth;
	public float HeadSize;
	public PhysicMaterial Material;

}

public struct SkeletonDefinition.RagdollSettings.BodySide // TypeDefIndex: 7366
{
	public int Hip;
	public int Knee;
	public int Foot;
	public int Arm;
	public int Elbow;

}

private sealed class SkeletonDefinition.<>c__DisplayClass3_0 // TypeDefIndex: 7367
{
	public string name;


	public void .ctor() { }

	internal bool <FindBone>

}

