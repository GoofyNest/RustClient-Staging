public class Construction : PrefabAttribute // TypeDefIndex: 9052
{	// Fields
	public static string lastPlacementError; // 0x0
	public BaseEntity.Menu.Option info; // 0x98
	public bool canBypassBuildingPermission; // 0xB8
	[FormerlySerializedAsAttribute] // RVA: 0xD0740 Offset: 0xCFB40 VA: 0x1800D0740
	public bool canRotateBeforePlacement; // 0xB9
	[FormerlySerializedAsAttribute] // RVA: 0xD0740 Offset: 0xCFB40 VA: 0x1800D0740
	public bool canRotateAfterPlacement; // 0xBA
	public bool checkVolumeOnRotate; // 0xBB
	public bool checkVolumeOnUpgrade; // 0xBC
	public bool canPlaceAtMaxDistance; // 0xBD
	public bool placeOnWater; // 0xBE
	public Vector3 rotationAmount; // 0xC0
	public Vector3 applyStartingRotation; // 0xCC
	[RangeAttribute] // RVA: 0x98320 Offset: 0x97720 VA: 0x180098320
	public float healthMultiplier; // 0xD8
	[RangeAttribute] // RVA: 0x98320 Offset: 0x97720 VA: 0x180098320
	public float costMultiplier; // 0xDC
	[RangeAttribute] // RVA: 0xD09F0 Offset: 0xCFDF0 VA: 0x1800D09F0
	public float maxplaceDistance; // 0xE0
	public Mesh guideMesh; // 0xE8
	public Socket_Base[] allSockets; // 0xF0
	public BuildingProximity[] allProximities; // 0xF8
	public ConstructionGrade defaultGrade; // 0x100
	public SocketHandle socketHandle; // 0x108
	public Bounds bounds; // 0x110
	public bool isBuildingPrivilege; // 0x128
	public ConstructionGrade[] grades; // 0x130
	public Deployable deployable; // 0x138
	public ConstructionPlaceholder placeholder; // 0x140

	// Properties
	public static bool DebugDraw { get; }

	// Methods

	// RVA: 0x6B5640 Offset: 0x6B3C40 VA: 0x1806B5640
	public bool UpdatePlacement(Transform transform, Construction common, ref Construction.Target target) { }

	// RVA: 0x6B4C60 Offset: 0x6B3260 VA: 0x1806B4C60
	private bool TestPlacingThroughRock(ref Construction.Placement placement, Construction.Target target) { }

	// RVA: 0x6B4F20 Offset: 0x6B3520 VA: 0x1806B4F20
	private static bool TestPlacingThroughWall(ref Construction.Placement placement, Transform transform, Construction common, Construction.Target target) { }

	// RVA: 0x6B47B0 Offset: 0x6B2DB0 VA: 0x1806B47B0
	private bool TestPlacingCloseToRoad(ref Construction.Placement placement, Construction.Target target) { }

	// RVA: 0x6B43C0 Offset: 0x6B29C0 VA: 0x1806B43C0 Slot: 8
	public virtual bool ShowAsNeutral(Construction.Target target) { }

	// RVA: 0x6B66B0 Offset: 0x6B4CB0 VA: 0x1806B66B0
	public static bool get_DebugDraw() { }

	// RVA: 0x6B42C0 Offset: 0x6B28C0 VA: 0x1806B42C0
	public bool HasMaleSockets(Construction.Target target) { }

	// RVA: 0x6B4100 Offset: 0x6B2700 VA: 0x1806B4100
	public void FindMaleSockets(Construction.Target target, List<Socket_Base> sockets) { }

	// RVA: 0x6B36B0 Offset: 0x6B1CB0 VA: 0x1806B36B0
	public GameObject CreateGuideSkin() { }

	// RVA: 0x6B32F0 Offset: 0x6B18F0 VA: 0x1806B32F0 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x6B4260 Offset: 0x6B2860 VA: 0x1806B4260 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x6B46C0 Offset: 0x6B2CC0 VA: 0x1806B46C0
	public void .ctor() { }

}

public struct Construction.Target // TypeDefIndex: 9053
{	// Fields
	public bool valid; // 0x0
	public Ray ray; // 0x4
	public BaseEntity entity; // 0x20
	public Socket_Base socket; // 0x28
	public bool onTerrain; // 0x30
	public Vector3 position; // 0x34
	public Vector3 normal; // 0x40
	public Vector3 rotation; // 0x4C
	public BasePlayer player; // 0x58
	public bool inBuildingPrivilege; // 0x60

	// Methods

	// RVA: 0xF3E70 Offset: 0xF3270 VA: 0x1800F3E70
	public Quaternion GetWorldRotation(bool female) { }

	// RVA: 0xF3E50 Offset: 0xF3250 VA: 0x1800F3E50
	public Vector3 GetWorldPosition() { }

}

public class Construction.Placement // TypeDefIndex: 9054
{	// Fields
	public Vector3 position; // 0x10
	public Quaternion rotation; // 0x1C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Construction.Grade // TypeDefIndex: 9055
{	// Fields
	public BuildingGrade grade; // 0x10
	public float maxHealth; // 0x18
	public List<ItemAmount> costToBuild; // 0x20

	// Properties
	public PhysicMaterial physicMaterial { get; }
	public ProtectionProperties damageProtecton { get; }

	// Methods

	// RVA: 0x6C81E0 Offset: 0x6C67E0 VA: 0x1806C81E0
	public PhysicMaterial get_physicMaterial() { }

	// RVA: 0x6C81C0 Offset: 0x6C67C0 VA: 0x1806C81C0
	public ProtectionProperties get_damageProtecton() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class Construction.<>c // TypeDefIndex: 9056
{	// Fields
	public static readonly Construction.<>c <>9; // 0x0
	public static Func<ConstructionGrade, bool> <>9__33_0; // 0x8
	public static Func<ConstructionGrade, BuildingGrade.Enum> <>9__33_1; // 0x10

	// Methods

	// RVA: 0x6C90C0 Offset: 0x6C76C0 VA: 0x1806C90C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8F40 Offset: 0x6C7540 VA: 0x1806C8F40
	internal bool <CreateGuideSkin>b__33_0(ConstructionGrade x) { }

	// RVA: 0x6C8FA0 Offset: 0x6C75A0 VA: 0x1806C8FA0
	internal BuildingGrade.Enum <CreateGuideSkin>b__33_1(ConstructionGrade x) { }

}

public class Construction_SleepingBag : Construction // TypeDefIndex: 9063
{	// Fields
	public static bool ShowSleepingBagProximityWarning; // 0x1C55

	// Methods

	// RVA: 0x6B43E0 Offset: 0x6B29E0 VA: 0x1806B43E0 Slot: 8
	public override bool ShowAsNeutral(Construction.Target target) { }

	// RVA: 0x6B46C0 Offset: 0x6B2CC0 VA: 0x1806B46C0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

