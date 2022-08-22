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

	// RVA: 0x1A8D200 Offset: 0x1A8B800 VA: 0x181A8D200 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x1A8E8F0 Offset: 0x1A8CEF0 VA: 0x181A8E8F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x1A8D9E0 Offset: 0x1A8BFE0 VA: 0x181A8D9E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x1A8DAD0 Offset: 0x1A8C0D0 VA: 0x181A8DAD0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A8E5D0 Offset: 0x1A8CBD0 VA: 0x181A8E5D0
	private void UpdateLineRenderer(bool force = False) { }

	[BaseEntity.Menu] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	[BaseEntity.Menu.Description] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	[BaseEntity.Menu.Icon] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	// RVA: 0x1A8D7F0 Offset: 0x1A8BDF0 VA: 0x181A8D7F0
	private void Menu_MountZipline(BasePlayer player) { }

	// RVA: 0x1A8D830 Offset: 0x1A8BE30 VA: 0x181A8D830
	private bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x1A8D610 Offset: 0x1A8BC10 VA: 0x181A8D610 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A8CE80 Offset: 0x1A8B480 VA: 0x181A8CE80
	private void CalculateZiplinePoints(List<Vector3> targets, ref List<Vector3> points) { }

	// RVA: 0x1A8CD90 Offset: 0x1A8B390 VA: 0x181A8CD90
	private Vector3 CalculateLineMidPoint(Vector3 start, Vector3 endPoint) { }

	// RVA: 0x1A8E090 Offset: 0x1A8C690 VA: 0x181A8E090
	private void UpdateBuildingBlocks() { }

	// RVA: 0x1A8D510 Offset: 0x1A8BB10 VA: 0x181A8D510
	private bool IsPlayerFacingValidDirection(BasePlayer ply) { }

	// RVA: 0x1A8D060 Offset: 0x1A8B660 VA: 0x181A8D060
	public float GetLineLength() { }

	// RVA: 0x1A8E850 Offset: 0x1A8CE50 VA: 0x181A8E850
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A8DB80 Offset: 0x1A8C180 VA: 0x181A8DB80
	private void <UpdateBuildingBlocks>g__SetUpBuildingBlock|24_0(BoxCollider longCollider, BoxCollider pointCollider, int startIndex, int endIndex) { }

}

