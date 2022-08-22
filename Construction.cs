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

	// RVA: 0x6B55D0 Offset: 0x6B3BD0 VA: 0x1806B55D0
	public bool UpdatePlacement(Transform transform, Construction common, ref Construction.Target target) { }

	// RVA: 0x6B4BF0 Offset: 0x6B31F0 VA: 0x1806B4BF0
	private bool TestPlacingThroughRock(ref Construction.Placement placement, Construction.Target target) { }

	// RVA: 0x6B4EB0 Offset: 0x6B34B0 VA: 0x1806B4EB0
	private static bool TestPlacingThroughWall(ref Construction.Placement placement, Transform transform, Construction common, Construction.Target target) { }

	// RVA: 0x6B4740 Offset: 0x6B2D40 VA: 0x1806B4740
	private bool TestPlacingCloseToRoad(ref Construction.Placement placement, Construction.Target target) { }

	// RVA: 0x6B4350 Offset: 0x6B2950 VA: 0x1806B4350 Slot: 8
	public virtual bool ShowAsNeutral(Construction.Target target) { }

	// RVA: 0x6B6640 Offset: 0x6B4C40 VA: 0x1806B6640
	public static bool get_DebugDraw() { }

	// RVA: 0x6B4250 Offset: 0x6B2850 VA: 0x1806B4250
	public bool HasMaleSockets(Construction.Target target) { }

	// RVA: 0x6B4090 Offset: 0x6B2690 VA: 0x1806B4090
	public void FindMaleSockets(Construction.Target target, List<Socket_Base> sockets) { }

	// RVA: 0x6B3640 Offset: 0x6B1C40 VA: 0x1806B3640
	public GameObject CreateGuideSkin() { }

	// RVA: 0x6B3280 Offset: 0x6B1880 VA: 0x1806B3280 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x6B41F0 Offset: 0x6B27F0 VA: 0x1806B41F0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x6B4650 Offset: 0x6B2C50 VA: 0x1806B4650
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

	// RVA: 0x6C8170 Offset: 0x6C6770 VA: 0x1806C8170
	public PhysicMaterial get_physicMaterial() { }

	// RVA: 0x6C8150 Offset: 0x6C6750 VA: 0x1806C8150
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

	// RVA: 0x6C9050 Offset: 0x6C7650 VA: 0x1806C9050
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8ED0 Offset: 0x6C74D0 VA: 0x1806C8ED0
	internal bool <CreateGuideSkin>b__33_0(ConstructionGrade x) { }

	// RVA: 0x6C8F30 Offset: 0x6C7530 VA: 0x1806C8F30
	internal BuildingGrade.Enum <CreateGuideSkin>b__33_1(ConstructionGrade x) { }

}

public class Construction_SleepingBag : Construction // TypeDefIndex: 9063
{	// Fields
	public static bool ShowSleepingBagProximityWarning; // 0x1B70

	// Methods

	// RVA: 0x6B4370 Offset: 0x6B2970 VA: 0x1806B4370 Slot: 8
	public override bool ShowAsNeutral(Construction.Target target) { }

	// RVA: 0x6B4650 Offset: 0x6B2C50 VA: 0x1806B4650
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

