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
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public List<Renderer> get_Renderers() { }

	// RVA: 0x59FFF0 Offset: 0x59E5F0 VA: 0x18059FFF0 Slot: 4
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x59E6C0 Offset: 0x59CCC0 VA: 0x18059E6C0
	public void Clear() { }

	// RVA: 0x5A1620 Offset: 0x59FC20 VA: 0x1805A1620
	public long WorkoutPartsHash() { }

	// RVA: 0x5A00B0 Offset: 0x59E6B0 VA: 0x1805A00B0
	public void RebuildModel(PlayerModel model, bool reset) { }

	// RVA: 0x59FA00 Offset: 0x59E000 VA: 0x18059FA00
	private void DoSkinSetup(PlayerModel model, Wearable wearable) { }

	// RVA: 0x59EF20 Offset: 0x59D520 VA: 0x18059EF20
	private void DoHairCapSetup(Wearable wearable, List<KeyValuePair<HairCapMask, Renderer>> wearableHairCapSkins) { }

	// RVA: 0x59F160 Offset: 0x59D760 VA: 0x18059F160
	private void DoHairSetup(Wearable wearable) { }

	// RVA: 0x59FB50 Offset: 0x59E150 VA: 0x18059FB50
	private void DoWearableSetup(Wearable wearable, List<WearableHairCap> wearableHairCap) { }

	// RVA: 0x59F830 Offset: 0x59DE30 VA: 0x18059F830
	private void DoRetargeting(Wearable wearable) { }

	// RVA: 0x59EB90 Offset: 0x59D190 VA: 0x18059EB90
	private void DoBoneRetargeting(Wearable wearable, Item item) { }

	// RVA: 0x5A1450 Offset: 0x59FA50 VA: 0x1805A1450
	private void UpdateRenderers(Wearable wearable) { }

	// RVA: 0x59F240 Offset: 0x59D840 VA: 0x18059F240
	private void DoItemSetup(SkinnedMultiMesh.Part part, List<IItemSetup> itemSetups) { }

	// RVA: 0x59F400 Offset: 0x59DA00 VA: 0x18059F400
	public void DoLODSetup() { }

	// RVA: 0x59E870 Offset: 0x59CE70 VA: 0x18059E870
	public void DeformCreatedPart(int blendShapeIndex) { }

	// RVA: 0x59FDB0 Offset: 0x59E3B0 VA: 0x18059FDB0
	public Transform FindBone(string strName) { }

	// RVA: 0x59FE90 Offset: 0x59E490 VA: 0x18059FE90
	public Transform[] GetBones() { }

	// RVA: 0x59FDD0 Offset: 0x59E3D0 VA: 0x18059FDD0
	public SkinnedMultiMesh.Part[] FindParts(string name) { }

	// RVA: 0x59F950 Offset: 0x59DF50 VA: 0x18059F950
	internal void DoShadowOverride(Renderer renderer, MaterialPropertyBlock block) { }

	// RVA: 0x5A13C0 Offset: 0x59F9C0 VA: 0x1805A13C0
	private void SetupLightShadowBiasScale(Renderer renderer, MaterialPropertyBlock block, bool shadowOnly) { }

	// RVA: 0x5A1280 Offset: 0x59F880 VA: 0x1805A1280
	public void SetVisible(bool bVisible) { }

	// RVA: 0x59FEE0 Offset: 0x59E4E0 VA: 0x18059FEE0
	public bool IsCurrentlyVisible() { }

	// RVA: 0x5A1790 Offset: 0x59FD90 VA: 0x1805A1790
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

	// RVA: 0x5C4720 Offset: 0x5C2D20 VA: 0x1805C4720
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5C45E0 Offset: 0x5C2BE0 VA: 0x1805C45E0
	internal long <WorkoutPartsHash>b__21_0(SkinnedMultiMesh.Part x) { }

	// RVA: 0x5C45C0 Offset: 0x5C2BC0 VA: 0x1805C45C0
	internal bool <IsCurrentlyVisible>b__39_0(Renderer r) { }

}

private sealed class SkinnedMultiMesh.<>c__DisplayClass35_0 // TypeDefIndex: 9239
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5C46D0 Offset: 0x5C2CD0 VA: 0x1805C46D0
	internal bool <FindParts>b__0(SkinnedMultiMesh.Part x) { }

}

