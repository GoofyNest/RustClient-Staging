public class Skeleton : MonoBehaviour // TypeDefIndex: 7344
{	// Fields
	public SkeletonDefinition Source; // 0x18
	public GameObject[] Bones; // 0x20

	// Methods

	// RVA: 0x22FF810 Offset: 0x22FDE10 VA: 0x1822FF810
	public Transform GetTransform(int id) { }

	// RVA: 0x22FF610 Offset: 0x22FDC10 VA: 0x1822FF610
	public Transform GetTransformSlow(string name) { }

	// RVA: 0x22FF4E0 Offset: 0x22FDAE0 VA: 0x1822FF4E0
	public int GetBoneId(string boneName) { }

	// RVA: 0x22FF900 Offset: 0x22FDF00 VA: 0x1822FF900
	public IEnumerable<Transform> GetTransforms() { }

	// RVA: 0x22FF5D0 Offset: 0x22FDBD0 VA: 0x1822FF5D0
	public GameObject GetGameObject(int id) { }

	// RVA: 0x22FEC10 Offset: 0x22FD210 VA: 0x1822FEC10
	public void CopyPositions(Skeleton to) { }

	// RVA: 0x22FF040 Offset: 0x22FD640 VA: 0x1822FF040
	public void CopySkeletonSkins(SkeletonSkin[] renderers, LODGroup lodGroup) { }

	// RVA: 0x22FE9C0 Offset: 0x22FCFC0 VA: 0x1822FE9C0
	private void CopyLodGroup(LODGroup lodGroup, SkeletonSkin[] renderers, SkinnedMeshRenderer[] created) { }

	// RVA: 0x22FF990 Offset: 0x22FDF90 VA: 0x1822FF990
	private int LookupRendererIndex(SkeletonSkin[] renderers, Renderer renderer) { }

	// RVA: 0x22FF1B0 Offset: 0x22FD7B0 VA: 0x1822FF1B0
	private SkinnedMeshRenderer CopySkin(SkeletonSkin renderer) { }

	// RVA: 0x22FEFD0 Offset: 0x22FD5D0 VA: 0x1822FEFD0
	public void CopySkeletonAttachments(SkeletonAttachment[] attachments) { }

	// RVA: 0x22FE7B0 Offset: 0x22FCDB0 VA: 0x1822FE7B0
	private void CopyAttachment(SkeletonAttachment skeletonAttachment) { }

	// RVA: 0x22FFB60 Offset: 0x22FE160 VA: 0x1822FFB60
	private int ReverseLookupBone(GameObject bone) { }

	// RVA: 0x22FFA60 Offset: 0x22FE060 VA: 0x1822FFA60
	public void Rebuild() { }

	// RVA: 0x22FF390 Offset: 0x22FD990 VA: 0x1822FF390
	private GameObject FindBoneImpl(in SkeletonDefinition.Bone bone, Transform[] allChildren) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FFBB0 Offset: 0x22FE1B0 VA: 0x1822FFBB0
	private Transform <GetTransforms>b__5_0(SkeletonDefinition.Bone x) { }

}

private sealed class Skeleton.<>c__DisplayClass15_0 // TypeDefIndex: 7345
{	// Fields
	public Skeleton <>4__this; // 0x10
	public Transform[] allChildren; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22FFBC0 Offset: 0x22FE1C0 VA: 0x1822FFBC0
	internal GameObject <Rebuild>b__0(SkeletonDefinition.Bone bone) { }

}

