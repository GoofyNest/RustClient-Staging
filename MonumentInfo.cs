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

	// RVA: 0x77B1D0 Offset: 0x7797D0 VA: 0x18077B1D0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x77B940 Offset: 0x779F40 VA: 0x18077B940
	public bool CheckPlacement(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x77BF10 Offset: 0x77A510 VA: 0x18077BF10
	public float Distance(Vector3 position) { }

	// RVA: 0x77CBF0 Offset: 0x77B1F0 VA: 0x18077CBF0
	public float SqrDistance(Vector3 position) { }

	// RVA: 0x77C050 Offset: 0x77A650 VA: 0x18077C050
	public float Distance(OBB obb) { }

	// RVA: 0x77CA90 Offset: 0x77B090 VA: 0x18077CA90
	public float SqrDistance(OBB obb) { }

	// RVA: 0x77C440 Offset: 0x77AA40 VA: 0x18077C440
	public bool IsInBounds(Vector3 position) { }

	// RVA: 0x77BC90 Offset: 0x77A290 VA: 0x18077BC90
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x77C1F0 Offset: 0x77A7F0 VA: 0x18077C1F0
	public PathFinder.Point GetPathFinderPoint(int res) { }

	// RVA: 0x77C310 Offset: 0x77A910 VA: 0x18077C310
	public int GetPathFinderRadius(int res) { }

	// RVA: 0x77C690 Offset: 0x77AC90 VA: 0x18077C690
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x77CD30 Offset: 0x77B330 VA: 0x18077CD30
	public static int TierToMask(MonumentTier tier) { }

	// RVA: 0x77C8E0 Offset: 0x77AEE0 VA: 0x18077C8E0 Slot: 6
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x77C1B0 Offset: 0x77A7B0 VA: 0x18077C1B0
	private DungeonGridInfo FindDungeonEntrance() { }

	// RVA: 0x77BE00 Offset: 0x77A400 VA: 0x18077BE00
	private bool DetermineHasDungeonLink() { }

	// RVA: 0x77BE70 Offset: 0x77A470 VA: 0x18077BE70
	private bool DetermineWantsDungeonLink() { }

	// RVA: 0x77C580 Offset: 0x77AB80 VA: 0x18077C580
	public bool IsPointWithinApproximatePreventBuildingRadius(Vector3 worldPoint) { }

	// RVA: 0x77CE50 Offset: 0x77B450 VA: 0x18077CE50
	private bool get_HasApproximatePreventBuildingRadius() { }

	// RVA: 0x77B2C0 Offset: 0x7798C0 VA: 0x18077B2C0
	private void CalculatePreventBuildingRadius(out Vector3 localSpaceCentre, out float radius) { }

	// RVA: 0x77CD60 Offset: 0x77B360 VA: 0x18077CD60
	public void .ctor() { }

}

