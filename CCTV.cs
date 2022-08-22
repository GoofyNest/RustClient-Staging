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

	// RVA: 0x6F3620 Offset: 0x6F1C20 VA: 0x1806F3620 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6F3F10 Offset: 0x6F2510 VA: 0x1806F3F10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6F3AE0 Offset: 0x6F20E0 VA: 0x1806F3AE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6F3610 Offset: 0x6F1C10 VA: 0x1806F3610 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x6F3BD0 Offset: 0x6F21D0 VA: 0x1806F3BD0
	public void UpdateRotation(float delta) { }

	// RVA: 0x6F39A0 Offset: 0x6F1FA0 VA: 0x1806F39A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6F35E0 Offset: 0x6F1BE0 VA: 0x1806F35E0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6F3E20 Offset: 0x6F2420 VA: 0x1806F3E20
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xD28A0 Offset: 0xD1CA0 VA: 0x1800D28A0
	[BaseEntity.Menu.Description] // RVA: 0xD28A0 Offset: 0xD1CA0 VA: 0x1800D28A0
	[BaseEntity.Menu.Icon] // RVA: 0xD28A0 Offset: 0xD1CA0 VA: 0x1800D28A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD28A0 Offset: 0xD1CA0 VA: 0x1800D28A0
	// RVA: 0x6F3AA0 Offset: 0x6F20A0 VA: 0x1806F3AA0
	public void Menu_SetDir(BasePlayer player) { }

	// RVA: 0x6F3A10 Offset: 0x6F2010 VA: 0x1806F3A10
	public bool Menu_SetDir_ShowIf(BasePlayer player) { }

	// RVA: 0x6F3E60 Offset: 0x6F2460 VA: 0x1806F3E60
	public void .ctor() { }

}

