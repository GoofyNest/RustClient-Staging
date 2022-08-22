public class Skeleton : MonoBehaviour // TypeDefIndex: 7344
{	// Fields
	public SkeletonDefinition Source; // 0x18
	public GameObject[] Bones; // 0x20

	// Methods

	// RVA: 0x22FF550 Offset: 0x22FDB50 VA: 0x1822FF550
	public Transform GetTransform(int id) { }

	// RVA: 0x22FF350 Offset: 0x22FD950 VA: 0x1822FF350
	public Transform GetTransformSlow(string name) { }

	// RVA: 0x22FF220 Offset: 0x22FD820 VA: 0x1822FF220
	public int GetBoneId(string boneName) { }

	// RVA: 0x22FF640 Offset: 0x22FDC40 VA: 0x1822FF640
	public IEnumerable<Transform> GetTransforms() { }

	// RVA: 0x22FF310 Offset: 0x22FD910 VA: 0x1822FF310
	public GameObject GetGameObject(int id) { }

	// RVA: 0x22FE950 Offset: 0x22FCF50 VA: 0x1822FE950
	public void CopyPositions(Skeleton to) { }

	// RVA: 0x22FED80 Offset: 0x22FD380 VA: 0x1822FED80
	public void CopySkeletonSkins(SkeletonSkin[] renderers, LODGroup lodGroup) { }

	// RVA: 0x22FE700 Offset: 0x22FCD00 VA: 0x1822FE700
	private void CopyLodGroup(LODGroup lodGroup, SkeletonSkin[] renderers, SkinnedMeshRenderer[] created) { }

	// RVA: 0x22FF6D0 Offset: 0x22FDCD0 VA: 0x1822FF6D0
	private int LookupRendererIndex(SkeletonSkin[] renderers, Renderer renderer) { }

	// RVA: 0x22FEEF0 Offset: 0x22FD4F0 VA: 0x1822FEEF0
	private SkinnedMeshRenderer CopySkin(SkeletonSkin renderer) { }

	// RVA: 0x22FED10 Offset: 0x22FD310 VA: 0x1822FED10
	public void CopySkeletonAttachments(SkeletonAttachment[] attachments) { }

	// RVA: 0x22FE4F0 Offset: 0x22FCAF0 VA: 0x1822FE4F0
	private void CopyAttachment(SkeletonAttachment skeletonAttachment) { }

	// RVA: 0x22FF8A0 Offset: 0x22FDEA0 VA: 0x1822FF8A0
	private int ReverseLookupBone(GameObject bone) { }

	// RVA: 0x22FF7A0 Offset: 0x22FDDA0 VA: 0x1822FF7A0
	public void Rebuild() { }

	// RVA: 0x22FF0D0 Offset: 0x22FD6D0 VA: 0x1822FF0D0
	private GameObject FindBoneImpl(in SkeletonDefinition.Bone bone, Transform[] allChildren) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FF8F0 Offset: 0x22FDEF0 VA: 0x1822FF8F0
	private Transform <GetTransforms>b__5_0(SkeletonDefinition.Bone x) { }

}

private sealed class Skeleton.<>c__DisplayClass15_0 // TypeDefIndex: 7345
{	// Fields
	public Skeleton <>4__this; // 0x10
	public Transform[] allChildren; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22FF900 Offset: 0x22FDF00 VA: 0x1822FF900
	internal GameObject <Rebuild>b__0(SkeletonDefinition.Bone bone) { }

}

