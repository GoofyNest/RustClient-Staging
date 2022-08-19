public class SkeletonSkin : MonoBehaviour // TypeDefIndex: 7353
{	// Fields
	public SkinnedMeshRenderer SkinnedMeshRenderer; // 0x18
	public SkeletonDefinition SkeletonDefinition; // 0x20
	public int LOD; // 0x28
	public int RootBone; // 0x2C
	public int[] TargetBones; // 0x30
	public Transform[] BoneTransforms; // 0x38

	// Methods

	// RVA: 0x22FE330 Offset: 0x22FC930 VA: 0x1822FE330
	public void Retarget(Skeleton target) { }

	// RVA: 0x22FE060 Offset: 0x22FC660 VA: 0x1822FE060
	public SkinnedMeshRenderer DuplicateAndRetarget(GameObject host, Skeleton target) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

