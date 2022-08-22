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

	// RVA: 0x6F35B0 Offset: 0x6F1BB0 VA: 0x1806F35B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6F3EA0 Offset: 0x6F24A0 VA: 0x1806F3EA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6F3A70 Offset: 0x6F2070 VA: 0x1806F3A70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6F35A0 Offset: 0x6F1BA0 VA: 0x1806F35A0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x6F3B60 Offset: 0x6F2160 VA: 0x1806F3B60
	public void UpdateRotation(float delta) { }

	// RVA: 0x6F3930 Offset: 0x6F1F30 VA: 0x1806F3930 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6F3570 Offset: 0x6F1B70 VA: 0x1806F3570 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6F3DB0 Offset: 0x6F23B0 VA: 0x1806F3DB0
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xD28A0 Offset: 0xD1CA0 VA: 0x1800D28A0
	[BaseEntity.Menu.Description] // RVA: 0xD28A0 Offset: 0xD1CA0 VA: 0x1800D28A0
	[BaseEntity.Menu.Icon] // RVA: 0xD28A0 Offset: 0xD1CA0 VA: 0x1800D28A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD28A0 Offset: 0xD1CA0 VA: 0x1800D28A0
	// RVA: 0x6F3A30 Offset: 0x6F2030 VA: 0x1806F3A30
	public void Menu_SetDir(BasePlayer player) { }

	// RVA: 0x6F39A0 Offset: 0x6F1FA0 VA: 0x1806F39A0
	public bool Menu_SetDir_ShowIf(BasePlayer player) { }

	// RVA: 0x6F3DF0 Offset: 0x6F23F0 VA: 0x1806F3DF0
	public void .ctor() { }

}

