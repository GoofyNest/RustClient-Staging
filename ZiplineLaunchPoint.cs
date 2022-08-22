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

	// RVA: 0x1A8D4C0 Offset: 0x1A8BAC0 VA: 0x181A8D4C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x1A8EBB0 Offset: 0x1A8D1B0 VA: 0x181A8EBB0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x1A8DCA0 Offset: 0x1A8C2A0 VA: 0x181A8DCA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x1A8DD90 Offset: 0x1A8C390 VA: 0x181A8DD90 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A8E890 Offset: 0x1A8CE90 VA: 0x181A8E890
	private void UpdateLineRenderer(bool force = False) { }

	[BaseEntity.Menu] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	[BaseEntity.Menu.Description] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	[BaseEntity.Menu.Icon] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D470 Offset: 0x9C870 VA: 0x18009D470
	// RVA: 0x1A8DAB0 Offset: 0x1A8C0B0 VA: 0x181A8DAB0
	private void Menu_MountZipline(BasePlayer player) { }

	// RVA: 0x1A8DAF0 Offset: 0x1A8C0F0 VA: 0x181A8DAF0
	private bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x1A8D8D0 Offset: 0x1A8BED0 VA: 0x181A8D8D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A8D140 Offset: 0x1A8B740 VA: 0x181A8D140
	private void CalculateZiplinePoints(List<Vector3> targets, ref List<Vector3> points) { }

	// RVA: 0x1A8D050 Offset: 0x1A8B650 VA: 0x181A8D050
	private Vector3 CalculateLineMidPoint(Vector3 start, Vector3 endPoint) { }

	// RVA: 0x1A8E350 Offset: 0x1A8C950 VA: 0x181A8E350
	private void UpdateBuildingBlocks() { }

	// RVA: 0x1A8D7D0 Offset: 0x1A8BDD0 VA: 0x181A8D7D0
	private bool IsPlayerFacingValidDirection(BasePlayer ply) { }

	// RVA: 0x1A8D320 Offset: 0x1A8B920 VA: 0x181A8D320
	public float GetLineLength() { }

	// RVA: 0x1A8EB10 Offset: 0x1A8D110 VA: 0x181A8EB10
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A8DE40 Offset: 0x1A8C440 VA: 0x181A8DE40
	private void <UpdateBuildingBlocks>g__SetUpBuildingBlock|24_0(BoxCollider longCollider, BoxCollider pointCollider, int startIndex, int endIndex) { }

}

