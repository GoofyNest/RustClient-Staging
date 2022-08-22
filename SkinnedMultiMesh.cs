public class SkinnedMultiMesh : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9236
{	// Fields
	public bool shadowOnly; // 0x18
	internal bool IsVisible; // 0x19
	public bool eyesView; // 0x1A
	public Skeleton skeleton; // 0x20
	public SkeletonSkinLod skeletonSkinLod; // 0x28
	public List<SkinnedMultiMesh.Part> parts; // 0x30
	public List<SkinnedMultiMesh.Part> createdParts; // 0x38
	public long lastBuildHash; // 0x40
	public MaterialPropertyBlock sharedPropertyBlock; // 0x48
	public MaterialPropertyBlock hairPropertyBlock; // 0x50
	public float skinNumber; // 0x58
	public float meshNumber; // 0x5C
	public float hairNumber; // 0x60
	public int skinType; // 0x64
	public SkinSetCollection SkinCollection; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly List<Renderer> <Renderers>k__BackingField; // 0x70

	// Properties
	public List<Renderer> Renderers { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public List<Renderer> get_Renderers() { }

	// RVA: 0x5A0060 Offset: 0x59E660 VA: 0x1805A0060 Slot: 4
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x59E730 Offset: 0x59CD30 VA: 0x18059E730
	public void Clear() { }

	// RVA: 0x5A1690 Offset: 0x59FC90 VA: 0x1805A1690
	public long WorkoutPartsHash() { }

	// RVA: 0x5A0120 Offset: 0x59E720 VA: 0x1805A0120
	public void RebuildModel(PlayerModel model, bool reset) { }

	// RVA: 0x59FA70 Offset: 0x59E070 VA: 0x18059FA70
	private void DoSkinSetup(PlayerModel model, Wearable wearable) { }

	// RVA: 0x59EF90 Offset: 0x59D590 VA: 0x18059EF90
	private void DoHairCapSetup(Wearable wearable, List<KeyValuePair<HairCapMask, Renderer>> wearableHairCapSkins) { }

	// RVA: 0x59F1D0 Offset: 0x59D7D0 VA: 0x18059F1D0
	private void DoHairSetup(Wearable wearable) { }

	// RVA: 0x59FBC0 Offset: 0x59E1C0 VA: 0x18059FBC0
	private void DoWearableSetup(Wearable wearable, List<WearableHairCap> wearableHairCap) { }

	// RVA: 0x59F8A0 Offset: 0x59DEA0 VA: 0x18059F8A0
	private void DoRetargeting(Wearable wearable) { }

	// RVA: 0x59EC00 Offset: 0x59D200 VA: 0x18059EC00
	private void DoBoneRetargeting(Wearable wearable, Item item) { }

	// RVA: 0x5A14C0 Offset: 0x59FAC0 VA: 0x1805A14C0
	private void UpdateRenderers(Wearable wearable) { }

	// RVA: 0x59F2B0 Offset: 0x59D8B0 VA: 0x18059F2B0
	private void DoItemSetup(SkinnedMultiMesh.Part part, List<IItemSetup> itemSetups) { }

	// RVA: 0x59F470 Offset: 0x59DA70 VA: 0x18059F470
	public void DoLODSetup() { }

	// RVA: 0x59E8E0 Offset: 0x59CEE0 VA: 0x18059E8E0
	public void DeformCreatedPart(int blendShapeIndex) { }

	// RVA: 0x59FE20 Offset: 0x59E420 VA: 0x18059FE20
	public Transform FindBone(string strName) { }

	// RVA: 0x59FF00 Offset: 0x59E500 VA: 0x18059FF00
	public Transform[] GetBones() { }

	// RVA: 0x59FE40 Offset: 0x59E440 VA: 0x18059FE40
	public SkinnedMultiMesh.Part[] FindParts(string name) { }

	// RVA: 0x59F9C0 Offset: 0x59DFC0 VA: 0x18059F9C0
	internal void DoShadowOverride(Renderer renderer, MaterialPropertyBlock block) { }

	// RVA: 0x5A1430 Offset: 0x59FA30 VA: 0x1805A1430
	private void SetupLightShadowBiasScale(Renderer renderer, MaterialPropertyBlock block, bool shadowOnly) { }

	// RVA: 0x5A12F0 Offset: 0x59F8F0 VA: 0x1805A12F0
	public void SetVisible(bool bVisible) { }

	// RVA: 0x59FF50 Offset: 0x59E550 VA: 0x18059FF50
	public bool IsCurrentlyVisible() { }

	// RVA: 0x5A1800 Offset: 0x59FE00 VA: 0x1805A1800
	public void .ctor() { }

}

public struct SkinnedMultiMesh.Part // TypeDefIndex: 9237
{	// Fields
	public Wearable wearable; // 0x0
	public GameObject gameObject; // 0x8
	public string name; // 0x10
	public Item item; // 0x18

}

private sealed class SkinnedMultiMesh.<>c // TypeDefIndex: 9238
{	// Fields
	public static readonly SkinnedMultiMesh.<>c <>9; // 0x0
	public static Func<SkinnedMultiMesh.Part, long> <>9__21_0; // 0x8
	public static Func<Renderer, bool> <>9__39_0; // 0x10

	// Methods

	// RVA: 0x5C4790 Offset: 0x5C2D90 VA: 0x1805C4790
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5C4650 Offset: 0x5C2C50 VA: 0x1805C4650
	internal long <WorkoutPartsHash>b__21_0(SkinnedMultiMesh.Part x) { }

	// RVA: 0x5C4630 Offset: 0x5C2C30 VA: 0x1805C4630
	internal bool <IsCurrentlyVisible>b__39_0(Renderer r) { }

}

private sealed class SkinnedMultiMesh.<>c__DisplayClass35_0 // TypeDefIndex: 9239
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5C4740 Offset: 0x5C2D40 VA: 0x1805C4740
	internal bool <FindParts>b__0(SkinnedMultiMesh.Part x) { }

}

