public class CCTV_RC : PoweredRemoteControlEntity // TypeDefIndex: 8372
{	// Fields
	private Option __menuOption_Menu_SetDir; // 0x300
	public Transform pivotOrigin; // 0x358
	public Transform yaw; // 0x360
	public Transform pitch; // 0x368
	public Vector2 pitchClamp; // 0x370
	public Vector2 yawClamp; // 0x378
	public float turnSpeed; // 0x380
	public float serverLerpSpeed; // 0x384
	public float clientLerpSpeed; // 0x388
	private float pitchAmount; // 0x38C
	private float yawAmount; // 0x390
	public bool hasPTZ; // 0x394
	public const BaseEntity.Flags Flag_HasViewer = 2048;

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6F3510 Offset: 0x6F1B10 VA: 0x1806F3510 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6F3E00 Offset: 0x6F2400 VA: 0x1806F3E00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6F39D0 Offset: 0x6F1FD0 VA: 0x1806F39D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6F3500 Offset: 0x6F1B00 VA: 0x1806F3500 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x6F3AC0 Offset: 0x6F20C0 VA: 0x1806F3AC0
	public void UpdateRotation(float delta) { }

	// RVA: 0x6F3890 Offset: 0x6F1E90 VA: 0x1806F3890 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6F34D0 Offset: 0x6F1AD0 VA: 0x1806F34D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6F3D10 Offset: 0x6F2310 VA: 0x1806F3D10
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xD27E0 Offset: 0xD1BE0 VA: 0x1800D27E0
	[BaseEntity.Menu.Description] // RVA: 0xD27E0 Offset: 0xD1BE0 VA: 0x1800D27E0
	[BaseEntity.Menu.Icon] // RVA: 0xD27E0 Offset: 0xD1BE0 VA: 0x1800D27E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD27E0 Offset: 0xD1BE0 VA: 0x1800D27E0
	// RVA: 0x6F3990 Offset: 0x6F1F90 VA: 0x1806F3990
	public void Menu_SetDir(BasePlayer player) { }

	// RVA: 0x6F3900 Offset: 0x6F1F00 VA: 0x1806F3900
	public bool Menu_SetDir_ShowIf(BasePlayer player) { }

	// RVA: 0x6F3D50 Offset: 0x6F2350 VA: 0x1806F3D50
	public void .ctor() { }

}

