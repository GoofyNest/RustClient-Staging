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

	// RVA: 0x77B230 Offset: 0x779830 VA: 0x18077B230 Slot: 5
	protected override void Awake() { }

	// RVA: 0x77B9A0 Offset: 0x779FA0 VA: 0x18077B9A0
	public bool CheckPlacement(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x77BF70 Offset: 0x77A570 VA: 0x18077BF70
	public float Distance(Vector3 position) { }

	// RVA: 0x77CC50 Offset: 0x77B250 VA: 0x18077CC50
	public float SqrDistance(Vector3 position) { }

	// RVA: 0x77C0B0 Offset: 0x77A6B0 VA: 0x18077C0B0
	public float Distance(OBB obb) { }

	// RVA: 0x77CAF0 Offset: 0x77B0F0 VA: 0x18077CAF0
	public float SqrDistance(OBB obb) { }

	// RVA: 0x77C4A0 Offset: 0x77AAA0 VA: 0x18077C4A0
	public bool IsInBounds(Vector3 position) { }

	// RVA: 0x77BCF0 Offset: 0x77A2F0 VA: 0x18077BCF0
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x77C250 Offset: 0x77A850 VA: 0x18077C250
	public PathFinder.Point GetPathFinderPoint(int res) { }

	// RVA: 0x77C370 Offset: 0x77A970 VA: 0x18077C370
	public int GetPathFinderRadius(int res) { }

	// RVA: 0x77C6F0 Offset: 0x77ACF0 VA: 0x18077C6F0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x77CD90 Offset: 0x77B390 VA: 0x18077CD90
	public static int TierToMask(MonumentTier tier) { }

	// RVA: 0x77C940 Offset: 0x77AF40 VA: 0x18077C940 Slot: 6
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x77C210 Offset: 0x77A810 VA: 0x18077C210
	private DungeonGridInfo FindDungeonEntrance() { }

	// RVA: 0x77BE60 Offset: 0x77A460 VA: 0x18077BE60
	private bool DetermineHasDungeonLink() { }

	// RVA: 0x77BED0 Offset: 0x77A4D0 VA: 0x18077BED0
	private bool DetermineWantsDungeonLink() { }

	// RVA: 0x77C5E0 Offset: 0x77ABE0 VA: 0x18077C5E0
	public bool IsPointWithinApproximatePreventBuildingRadius(Vector3 worldPoint) { }

	// RVA: 0x77CEB0 Offset: 0x77B4B0 VA: 0x18077CEB0
	private bool get_HasApproximatePreventBuildingRadius() { }

	// RVA: 0x77B320 Offset: 0x779920 VA: 0x18077B320
	private void CalculatePreventBuildingRadius(out Vector3 localSpaceCentre, out float radius) { }

	// RVA: 0x77CDC0 Offset: 0x77B3C0 VA: 0x18077CDC0
	public void .ctor() { }

}

