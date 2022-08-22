public class MonumentInfo : LandmarkInfo, IPrefabPreProcess // TypeDefIndex: 9966
{	// Fields
	[HeaderAttribute] // RVA: 0xAB340 Offset: 0xAA740 VA: 0x1800AB340
	public MonumentType Type; // 0x30
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public MonumentTier Tier; // 0x34
	public int MinWorldSize; // 0x38
	public Bounds Bounds; // 0x3C
	public bool HasNavmesh; // 0x54
	public bool IsSafeZone; // 0x55
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool WantsDungeonLink; // 0x56
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool HasDungeonLink; // 0x57
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public DungeonGridInfo DungeonEntrance; // 0x58
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float PreventBuildingRadius; // 0x60
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 PreventBuildingOrigin; // 0x64

	// Properties
	private bool HasApproximatePreventBuildingRadius { get; }

	// Methods

	// RVA: 0x77B2E0 Offset: 0x7798E0 VA: 0x18077B2E0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x77BA50 Offset: 0x77A050 VA: 0x18077BA50
	public bool CheckPlacement(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x77C020 Offset: 0x77A620 VA: 0x18077C020
	public float Distance(Vector3 position) { }

	// RVA: 0x77CD00 Offset: 0x77B300 VA: 0x18077CD00
	public float SqrDistance(Vector3 position) { }

	// RVA: 0x77C160 Offset: 0x77A760 VA: 0x18077C160
	public float Distance(OBB obb) { }

	// RVA: 0x77CBA0 Offset: 0x77B1A0 VA: 0x18077CBA0
	public float SqrDistance(OBB obb) { }

	// RVA: 0x77C550 Offset: 0x77AB50 VA: 0x18077C550
	public bool IsInBounds(Vector3 position) { }

	// RVA: 0x77BDA0 Offset: 0x77A3A0 VA: 0x18077BDA0
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x77C300 Offset: 0x77A900 VA: 0x18077C300
	public PathFinder.Point GetPathFinderPoint(int res) { }

	// RVA: 0x77C420 Offset: 0x77AA20 VA: 0x18077C420
	public int GetPathFinderRadius(int res) { }

	// RVA: 0x77C7A0 Offset: 0x77ADA0 VA: 0x18077C7A0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x77CE40 Offset: 0x77B440 VA: 0x18077CE40
	public static int TierToMask(MonumentTier tier) { }

	// RVA: 0x77C9F0 Offset: 0x77AFF0 VA: 0x18077C9F0 Slot: 6
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x77C2C0 Offset: 0x77A8C0 VA: 0x18077C2C0
	private DungeonGridInfo FindDungeonEntrance() { }

	// RVA: 0x77BF10 Offset: 0x77A510 VA: 0x18077BF10
	private bool DetermineHasDungeonLink() { }

	// RVA: 0x77BF80 Offset: 0x77A580 VA: 0x18077BF80
	private bool DetermineWantsDungeonLink() { }

	// RVA: 0x77C690 Offset: 0x77AC90 VA: 0x18077C690
	public bool IsPointWithinApproximatePreventBuildingRadius(Vector3 worldPoint) { }

	// RVA: 0x77CF60 Offset: 0x77B560 VA: 0x18077CF60
	private bool get_HasApproximatePreventBuildingRadius() { }

	// RVA: 0x77B3D0 Offset: 0x7799D0 VA: 0x18077B3D0
	private void CalculatePreventBuildingRadius(out Vector3 localSpaceCentre, out float radius) { }

	// RVA: 0x77CE70 Offset: 0x77B470 VA: 0x18077CE70
	public void .ctor() { }

}

