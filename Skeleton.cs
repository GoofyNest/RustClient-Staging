public class Skeleton : MonoBehaviour // TypeDefIndex: 7344
{	// Fields
	public SkeletonDefinition Source; // 0x18
	public GameObject[] Bones; // 0x20

	// Methods

	// RVA: 0x2300030 Offset: 0x22FE630 VA: 0x182300030
	public Transform GetTransform(int id) { }

	// RVA: 0x22FFE30 Offset: 0x22FE430 VA: 0x1822FFE30
	public Transform GetTransformSlow(string name) { }

	// RVA: 0x22FFD00 Offset: 0x22FE300 VA: 0x1822FFD00
	public int GetBoneId(string boneName) { }

	// RVA: 0x2300120 Offset: 0x22FE720 VA: 0x182300120
	public IEnumerable<Transform> GetTransforms() { }

	// RVA: 0x22FFDF0 Offset: 0x22FE3F0 VA: 0x1822FFDF0
	public GameObject GetGameObject(int id) { }

	// RVA: 0x22FF430 Offset: 0x22FDA30 VA: 0x1822FF430
	public void CopyPositions(Skeleton to) { }

	// RVA: 0x22FF860 Offset: 0x22FDE60 VA: 0x1822FF860
	public void CopySkeletonSkins(SkeletonSkin[] renderers, LODGroup lodGroup) { }

	// RVA: 0x22FF1E0 Offset: 0x22FD7E0 VA: 0x1822FF1E0
	private void CopyLodGroup(LODGroup lodGroup, SkeletonSkin[] renderers, SkinnedMeshRenderer[] created) { }

	// RVA: 0x23001B0 Offset: 0x22FE7B0 VA: 0x1823001B0
	private int LookupRendererIndex(SkeletonSkin[] renderers, Renderer renderer) { }

	// RVA: 0x22FF9D0 Offset: 0x22FDFD0 VA: 0x1822FF9D0
	private SkinnedMeshRenderer CopySkin(SkeletonSkin renderer) { }

	// RVA: 0x22FF7F0 Offset: 0x22FDDF0 VA: 0x1822FF7F0
	public void CopySkeletonAttachments(SkeletonAttachment[] attachments) { }

	// RVA: 0x22FEFD0 Offset: 0x22FD5D0 VA: 0x1822FEFD0
	private void CopyAttachment(SkeletonAttachment skeletonAttachment) { }

	// RVA: 0x2300380 Offset: 0x22FE980 VA: 0x182300380
	private int ReverseLookupBone(GameObject bone) { }

	// RVA: 0x2300280 Offset: 0x22FE880 VA: 0x182300280
	public void Rebuild() { }

	// RVA: 0x22FFBB0 Offset: 0x22FE1B0 VA: 0x1822FFBB0
	private GameObject FindBoneImpl(in SkeletonDefinition.Bone bone, Transform[] allChildren) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23003D0 Offset: 0x22FE9D0 VA: 0x1823003D0
	private Transform <GetTransforms>b__5_0(SkeletonDefinition.Bone x) { }

}

private sealed class Skeleton.<>c__DisplayClass15_0 // TypeDefIndex: 7345
{	// Fields
	public Skeleton <>4__this; // 0x10
	public Transform[] allChildren; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x23003E0 Offset: 0x22FE9E0 VA: 0x1823003E0
	internal GameObject <Rebuild>b__0(SkeletonDefinition.Bone bone) { }

}

