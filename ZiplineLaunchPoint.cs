public class ZiplineLaunchPoint : BaseEntity // TypeDefIndex: 8489
{	private Option __menuOption_Menu_MountZipline; // 0x168
	public Transform LineDeparturePoint; // 0x1C0
	public LineRenderer ZiplineRenderer; // 0x1C8
	public Collider MountCollider; // 0x1D0
	public BoxCollider[] BuildingBlocks; // 0x1D8
	public BoxCollider[] PointBuildingBlocks; // 0x1E0
	public SpawnableBoundsBlocker[] SpawnableBoundsBlockers; // 0x1E8
	public GameObjectRef MountableRef; // 0x1F0
	public float LineSlackAmount; // 0x1F8
	public bool RegenLine; // 0x1FC
	private List<Vector3> ziplineTargets; // 0x200
	private List<Vector3> linePoints; // 0x208
	public GameObjectRef ArrivalPointRef; // 0x210
	private bool hasSetupLineRenderer; // 0x218

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	private void UpdateLineRenderer(bool force = False) { }

	[BaseEntity.Menu] // RVA: 0x9D4B0 Offset: 0x9C8B0 VA: 0x18009D4B0
	[BaseEntity.Menu.Description] // RVA: 0x9D4B0 Offset: 0x9C8B0 VA: 0x18009D4B0
	[BaseEntity.Menu.Icon] // RVA: 0x9D4B0 Offset: 0x9C8B0 VA: 0x18009D4B0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D4B0 Offset: 0x9C8B0 VA: 0x18009D4B0
	private void Menu_MountZipline(BasePlayer player) { }

	private bool Menu_Mount_ShowIf(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private void CalculateZiplinePoints(List<Vector3> targets, ref List<Vector3> points) { }

	private Vector3 CalculateLineMidPoint(Vector3 start, Vector3 endPoint) { }

	private void UpdateBuildingBlocks() { }

	private bool IsPlayerFacingValidDirection(BasePlayer ply) { }

	public float GetLineLength() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void <UpdateBuildingBlocks>g__SetUpBuildingBlock|25_0(BoxCollider longCollider, BoxCollider pointCollider, SpawnableBoundsBlocker spawnBlocker, int startIndex, int endIndex) { }

}

