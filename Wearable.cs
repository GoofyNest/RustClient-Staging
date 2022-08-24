public class Wearable : MonoBehaviour, IItemSetup, IPrefabPreProcess // TypeDefIndex: 10059
{	[InspectorFlagsAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public Wearable.RemoveSkin removeSkin; // 0x18
	[InspectorFlagsAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public Wearable.RemoveSkin removeSkinFirstPerson; // 0x1C
	[InspectorFlagsAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public Wearable.RemoveHair removeHair; // 0x20
	[InspectorFlagsAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public Wearable.DeformHair deformHair; // 0x24
	[InspectorFlagsAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public Wearable.OccupationSlots occupationUnder; // 0x28
	[InspectorFlagsAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public Wearable.OccupationSlots occupationOver; // 0x2C
	public bool showCensorshipCube; // 0x30
	public bool showCensorshipCubeBreasts; // 0x31
	public bool forceHideCensorshipBreasts; // 0x32
	public string followBone; // 0x38
	public bool disableRigStripping; // 0x40
	public bool overrideDownLimit; // 0x41
	public float downLimit; // 0x44
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public PlayerModelHair playerModelHair; // 0x48
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public PlayerModelHairCap playerModelHairCap; // 0x50
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public WearableReplacementByRace wearableReplacementByRace; // 0x58
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public WearableShadowLod wearableShadowLod; // 0x60
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public List<Renderer> renderers; // 0x68
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public List<PlayerModelSkin> playerModelSkins; // 0x70
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public List<BoneRetarget> boneRetargets; // 0x78
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public List<SkinnedMeshRenderer> skinnedRenderers; // 0x80
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public List<SkeletonSkin> skeletonSkins; // 0x88
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public List<ComponentInfo> componentInfos; // 0x90
	public bool HideInEyesView; // 0x98
	[HeaderAttribute] // RVA: 0xB2240 Offset: 0xB1640 VA: 0x1800B2240
	[TooltipAttribute] // RVA: 0xB2240 Offset: 0xB1640 VA: 0x1800B2240
	public bool HideInFirstPerson; // 0x99
	[TooltipAttribute] // RVA: 0xB25D0 Offset: 0xB19D0 VA: 0x1800B25D0
	[RangeAttribute] // RVA: 0xB25D0 Offset: 0xB19D0 VA: 0x1800B25D0
	public float ExtraLeanBack; // 0x9C
	[TooltipAttribute] // RVA: 0xB26F0 Offset: 0xB1AF0 VA: 0x1800B26F0
	public bool PreserveBones; // 0xA0
	public Renderer[] RenderersLod0; // 0xA8
	public Renderer[] RenderersLod1; // 0xB0
	public Renderer[] RenderersLod2; // 0xB8
	public Renderer[] RenderersLod3; // 0xC0
	public Renderer[] SkipInFirstPersonLegs; // 0xC8
	private static LOD[] emptyLOD; // 0x0


	public void OnItemSetup(Item item) { }

	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void CacheComponents() { }

	public void StripRig(IPrefabProcessor preProcess, SkinnedMeshRenderer skinnedMeshRenderer) { }

	public void SetupRendererCache(IPrefabProcessor preProcess) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum Wearable.RemoveSkin // TypeDefIndex: 10060
{	public int value__; // 0x0
	public const Wearable.RemoveSkin Torso = 1;
	public const Wearable.RemoveSkin Feet = 2;
	public const Wearable.RemoveSkin Hands = 4;
	public const Wearable.RemoveSkin Legs = 8;
	public const Wearable.RemoveSkin Head = 16;

}

public enum Wearable.RemoveHair // TypeDefIndex: 10061
{	public int value__; // 0x0
	public const Wearable.RemoveHair Head = 1;
	public const Wearable.RemoveHair Eyebrow = 2;
	public const Wearable.RemoveHair Facial = 4;
	public const Wearable.RemoveHair Armpit = 8;
	public const Wearable.RemoveHair Pubic = 16;

}

public enum Wearable.DeformHair // TypeDefIndex: 10062
{	public int value__; // 0x0
	public const Wearable.DeformHair None = 0;
	public const Wearable.DeformHair BaseballCap = 1;
	public const Wearable.DeformHair BoonieHat = 2;
	public const Wearable.DeformHair CandleHat = 3;
	public const Wearable.DeformHair MinersHat = 4;
	public const Wearable.DeformHair WoodHelmet = 5;

}

public enum Wearable.OccupationSlots // TypeDefIndex: 10063
{	public int value__; // 0x0
	public const Wearable.OccupationSlots HeadTop = 1;
	public const Wearable.OccupationSlots Face = 2;
	public const Wearable.OccupationSlots HeadBack = 4;
	public const Wearable.OccupationSlots TorsoFront = 8;
	public const Wearable.OccupationSlots TorsoBack = 16;
	public const Wearable.OccupationSlots LeftShoulder = 32;
	public const Wearable.OccupationSlots RightShoulder = 64;
	public const Wearable.OccupationSlots LeftArm = 128;
	public const Wearable.OccupationSlots RightArm = 256;
	public const Wearable.OccupationSlots LeftHand = 512;
	public const Wearable.OccupationSlots RightHand = 1024;
	public const Wearable.OccupationSlots Groin = 2048;
	public const Wearable.OccupationSlots Bum = 4096;
	public const Wearable.OccupationSlots LeftKnee = 8192;
	public const Wearable.OccupationSlots RightKnee = 16384;
	public const Wearable.OccupationSlots LeftLeg = 32768;
	public const Wearable.OccupationSlots RightLeg = 65536;
	public const Wearable.OccupationSlots LeftFoot = 131072;
	public const Wearable.OccupationSlots RightFoot = 262144;
	public const Wearable.OccupationSlots Mouth = 524288;
	public const Wearable.OccupationSlots Eyes = 1048576;

}

private sealed class Wearable.<>c // TypeDefIndex: 10064
{	public static readonly Wearable.<>c <>9; // 0x0
	public static Func<Renderer, bool> <>9__39_0; // 0x8
	public static Func<Renderer, bool> <>9__39_1; // 0x10
	public static Func<Renderer, bool> <>9__39_2; // 0x18
	public static Func<Renderer, bool> <>9__39_3; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <CacheComponents>b__39_0(Renderer x) { }

	internal bool <CacheComponents>b__39_1(Renderer x) { }

	internal bool <CacheComponents>b__39_2(Renderer x) { }

	internal bool <CacheComponents>b__39_3(Renderer x) { }

}

