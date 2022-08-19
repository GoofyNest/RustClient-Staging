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

	// RVA: 0x1AA3590 Offset: 0x1AA1B90 VA: 0x181AA3590 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x1AA4C80 Offset: 0x1AA3280 VA: 0x181AA4C80 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x1AA3D70 Offset: 0x1AA2370 VA: 0x181AA3D70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x1AA3E60 Offset: 0x1AA2460 VA: 0x181AA3E60 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1AA4960 Offset: 0x1AA2F60 VA: 0x181AA4960
	private void UpdateLineRenderer(bool force = False) { }

	[BaseEntity.Menu] // RVA: 0x9D3E0 Offset: 0x9C7E0 VA: 0x18009D3E0
	[BaseEntity.Menu.Description] // RVA: 0x9D3E0 Offset: 0x9C7E0 VA: 0x18009D3E0
	[BaseEntity.Menu.Icon] // RVA: 0x9D3E0 Offset: 0x9C7E0 VA: 0x18009D3E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D3E0 Offset: 0x9C7E0 VA: 0x18009D3E0
	// RVA: 0x1AA3B80 Offset: 0x1AA2180 VA: 0x181AA3B80
	private void Menu_MountZipline(BasePlayer player) { }

	// RVA: 0x1AA3BC0 Offset: 0x1AA21C0 VA: 0x181AA3BC0
	private bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x1AA39A0 Offset: 0x1AA1FA0 VA: 0x181AA39A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1AA3210 Offset: 0x1AA1810 VA: 0x181AA3210
	private void CalculateZiplinePoints(List<Vector3> targets, ref List<Vector3> points) { }

	// RVA: 0x1AA3120 Offset: 0x1AA1720 VA: 0x181AA3120
	private Vector3 CalculateLineMidPoint(Vector3 start, Vector3 endPoint) { }

	// RVA: 0x1AA4420 Offset: 0x1AA2A20 VA: 0x181AA4420
	private void UpdateBuildingBlocks() { }

	// RVA: 0x1AA38A0 Offset: 0x1AA1EA0 VA: 0x181AA38A0
	private bool IsPlayerFacingValidDirection(BasePlayer ply) { }

	// RVA: 0x1AA33F0 Offset: 0x1AA19F0 VA: 0x181AA33F0
	public float GetLineLength() { }

	// RVA: 0x1AA4BE0 Offset: 0x1AA31E0 VA: 0x181AA4BE0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1AA3F10 Offset: 0x1AA2510 VA: 0x181AA3F10
	private void <UpdateBuildingBlocks>g__SetUpBuildingBlock|24_0(BoxCollider longCollider, BoxCollider pointCollider, int startIndex, int endIndex) { }

}

