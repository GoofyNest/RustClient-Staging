public class MonumentInfo : LandmarkInfo, IPrefabPreProcess // TypeDefIndex: 9966
{	[HeaderAttribute] // RVA: 0xAB410 Offset: 0xAA810 VA: 0x1800AB410
	public MonumentType Type; // 0x30
	[InspectorFlagsAttribute] // RVA: 0x70C90 Offset: 0x70090 VA: 0x180070C90
	public MonumentTier Tier; // 0x34
	public int MinWorldSize; // 0x38
	public Bounds Bounds; // 0x3C
	public bool HasNavmesh; // 0x54
	public bool IsSafeZone; // 0x55
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool WantsDungeonLink; // 0x56
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool HasDungeonLink; // 0x57
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public DungeonGridInfo DungeonEntrance; // 0x58
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float PreventBuildingRadius; // 0x60
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Vector3 PreventBuildingOrigin; // 0x64

	private bool HasApproximatePreventBuildingRadius { get; }


	protected override void Awake() { }

	public bool CheckPlacement(Vector3 pos, Quaternion rot, Vector3 scale) { }

	public float Distance(Vector3 position) { }

	public float SqrDistance(Vector3 position) { }

	public float Distance(OBB obb) { }

	public float SqrDistance(OBB obb) { }

	public bool IsInBounds(Vector3 position) { }

	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	public PathFinder.Point GetPathFinderPoint(int res) { }

	public int GetPathFinderRadius(int res) { }

	protected void OnDrawGizmosSelected() { }

	public static int TierToMask(MonumentTier tier) { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	private DungeonGridInfo FindDungeonEntrance() { }

	private bool DetermineHasDungeonLink() { }

	private bool DetermineWantsDungeonLink() { }

	public bool IsPointWithinApproximatePreventBuildingRadius(Vector3 worldPoint) { }

	private bool get_HasApproximatePreventBuildingRadius() { }

	private void CalculatePreventBuildingRadius(out Vector3 localSpaceCentre, out float radius) { }

	public void .ctor() { }

}

