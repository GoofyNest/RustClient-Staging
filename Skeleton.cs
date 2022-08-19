public class Skeleton : MonoBehaviour // TypeDefIndex: 7344
{	// Fields
	public SkeletonDefinition Source; // 0x18
	public GameObject[] Bones; // 0x20

	// Methods

	// RVA: 0x22FF710 Offset: 0x22FDD10 VA: 0x1822FF710
	public Transform GetTransform(int id) { }

	// RVA: 0x22FF510 Offset: 0x22FDB10 VA: 0x1822FF510
	public Transform GetTransformSlow(string name) { }

	// RVA: 0x22FF3E0 Offset: 0x22FD9E0 VA: 0x1822FF3E0
	public int GetBoneId(string boneName) { }

	// RVA: 0x22FF800 Offset: 0x22FDE00 VA: 0x1822FF800
	public IEnumerable<Transform> GetTransforms() { }

	// RVA: 0x22FF4D0 Offset: 0x22FDAD0 VA: 0x1822FF4D0
	public GameObject GetGameObject(int id) { }

	// RVA: 0x22FEB10 Offset: 0x22FD110 VA: 0x1822FEB10
	public void CopyPositions(Skeleton to) { }

	// RVA: 0x22FEF40 Offset: 0x22FD540 VA: 0x1822FEF40
	public void CopySkeletonSkins(SkeletonSkin[] renderers, LODGroup lodGroup) { }

	// RVA: 0x22FE8C0 Offset: 0x22FCEC0 VA: 0x1822FE8C0
	private void CopyLodGroup(LODGroup lodGroup, SkeletonSkin[] renderers, SkinnedMeshRenderer[] created) { }

	// RVA: 0x22FF890 Offset: 0x22FDE90 VA: 0x1822FF890
	private int LookupRendererIndex(SkeletonSkin[] renderers, Renderer renderer) { }

	// RVA: 0x22FF0B0 Offset: 0x22FD6B0 VA: 0x1822FF0B0
	private SkinnedMeshRenderer CopySkin(SkeletonSkin renderer) { }

	// RVA: 0x22FEED0 Offset: 0x22FD4D0 VA: 0x1822FEED0
	public void CopySkeletonAttachments(SkeletonAttachment[] attachments) { }

	// RVA: 0x22FE6B0 Offset: 0x22FCCB0 VA: 0x1822FE6B0
	private void CopyAttachment(SkeletonAttachment skeletonAttachment) { }

	// RVA: 0x22FFA60 Offset: 0x22FE060 VA: 0x1822FFA60
	private int ReverseLookupBone(GameObject bone) { }

	// RVA: 0x22FF960 Offset: 0x22FDF60 VA: 0x1822FF960
	public void Rebuild() { }

	// RVA: 0x22FF290 Offset: 0x22FD890 VA: 0x1822FF290
	private GameObject FindBoneImpl(in SkeletonDefinition.Bone bone, Transform[] allChildren) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22FFAB0 Offset: 0x22FE0B0 VA: 0x1822FFAB0
	private Transform <GetTransforms>b__5_0(SkeletonDefinition.Bone x) { }

}

private sealed class Skeleton.<>c__DisplayClass15_0 // TypeDefIndex: 7345
{	// Fields
	public Skeleton <>4__this; // 0x10
	public Transform[] allChildren; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22FFAC0 Offset: 0x22FE0C0 VA: 0x1822FFAC0
	internal GameObject <Rebuild>b__0(SkeletonDefinition.Bone bone) { }

}

