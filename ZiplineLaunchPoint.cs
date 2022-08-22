public class ZiplineLaunchPoint : BaseEntity // TypeDefIndex: 8489
{	// Fields
	private Option __menuOption_Menu_MountZipline; // 0x168
	public Transform LineDeparturePoint; // 0x1C0
	public LineRenderer ZiplineRenderer; // 0x1C8
	public Collider MountCollider; // 0x1D0
	public BoxCollider[] BuildingBlocks; // 0x1D8
	public BoxCollider[] PointBuildingBlocks; // 0x1E0
	public GameObjectRef MountableRef; // 0x1E8
	public float LineSlackAmount; // 0x1F0
	public bool RegenLine; // 0x1F4
	private List<Vector3> ziplineTargets; // 0x1F8
	private List<Vector3> linePoints; // 0x200
	public GameObjectRef ArrivalPointRef; // 0x208
	private bool hasSetupLineRenderer; // 0x210

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x1A79CD0 Offset: 0x1A782D0 VA: 0x181A79CD0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x1A7B3C0 Offset: 0x1A799C0 VA: 0x181A7B3C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x1A7A4B0 Offset: 0x1A78AB0 VA: 0x181A7A4B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x1A7A5A0 Offset: 0x1A78BA0 VA: 0x181A7A5A0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A7B0A0 Offset: 0x1A796A0 VA: 0x181A7B0A0
	private void UpdateLineRenderer(bool force = False) { }

	[BaseEntity.Menu] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	[BaseEntity.Menu.Description] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	[BaseEntity.Menu.Icon] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	// RVA: 0x1A7A2C0 Offset: 0x1A788C0 VA: 0x181A7A2C0
	private void Menu_MountZipline(BasePlayer player) { }

	// RVA: 0x1A7A300 Offset: 0x1A78900 VA: 0x181A7A300
	private bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x1A7A0E0 Offset: 0x1A786E0 VA: 0x181A7A0E0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A79950 Offset: 0x1A77F50 VA: 0x181A79950
	private void CalculateZiplinePoints(List<Vector3> targets, ref List<Vector3> points) { }

	// RVA: 0x1A79860 Offset: 0x1A77E60 VA: 0x181A79860
	private Vector3 CalculateLineMidPoint(Vector3 start, Vector3 endPoint) { }

	// RVA: 0x1A7AB60 Offset: 0x1A79160 VA: 0x181A7AB60
	private void UpdateBuildingBlocks() { }

	// RVA: 0x1A79FE0 Offset: 0x1A785E0 VA: 0x181A79FE0
	private bool IsPlayerFacingValidDirection(BasePlayer ply) { }

	// RVA: 0x1A79B30 Offset: 0x1A78130 VA: 0x181A79B30
	public float GetLineLength() { }

	// RVA: 0x1A7B320 Offset: 0x1A79920 VA: 0x181A7B320
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7A650 Offset: 0x1A78C50 VA: 0x181A7A650
	private void <UpdateBuildingBlocks>g__SetUpBuildingBlock|24_0(BoxCollider longCollider, BoxCollider pointCollider, int startIndex, int endIndex) { }

}

