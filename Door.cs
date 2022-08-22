public class Door : AnimatedBuildingBlock, INotifyTrigger // TypeDefIndex: 8381
{	// Fields
	private Option __menuOption_Menu_CloseDoor; // 0x270
	private Option __menuOption_Menu_KnockDoor; // 0x2C8
	private Option __menuOption_Menu_OpenDoor; // 0x320
	private Option __menuOption_Menu_ToggleHatch; // 0x378
	public GameObjectRef knockEffect; // 0x3D0
	public bool canTakeLock; // 0x3D8
	public bool hasHatch; // 0x3D9
	public bool canTakeCloser; // 0x3DA
	public bool canTakeKnocker; // 0x3DB
	public bool canNpcOpen; // 0x3DC
	public bool canHandOpen; // 0x3DD
	public bool isSecurityDoor; // 0x3DE
	public TriggerNotify[] vehiclePhysBoxes; // 0x3E0
	public bool checkPhysBoxesOnOpen; // 0x3E8
	public SoundDefinition vehicleCollisionSfx; // 0x3F0
	public GameObject[] ClosedColliderRoots; // 0x3F8
	private static int openHash; // 0x0
	private static int closeHash; // 0x4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAADCF0 Offset: 0xAAC2F0 VA: 0x180AADCF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAAF7D0 Offset: 0xAADDD0 VA: 0x180AAF7D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAAF120 Offset: 0xAAD720 VA: 0x180AAF120 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAAF570 Offset: 0xAADB70 VA: 0x180AAF570 Slot: 27
	public override void ResetState() { }

	// RVA: 0xAAE8E0 Offset: 0xAACEE0 VA: 0x180AAE8E0 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0xAADB80 Offset: 0xAAC180 VA: 0x180AADB80 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.Description] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.Icon] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	// RVA: 0xAAECD0 Offset: 0xAAD2D0 VA: 0x180AAECD0
	public void Menu_OpenDoor(BasePlayer player) { }

	// RVA: 0xAAEBB0 Offset: 0xAAD1B0 VA: 0x180AAEBB0
	public void Menu_OpenDoor_Proxy(ref Option option) { }

	// RVA: 0xAAEB70 Offset: 0xAAD170 VA: 0x180AAEB70
	public void Menu_OpenDoorStart() { }

	// RVA: 0xAAEC90 Offset: 0xAAD290 VA: 0x180AAEC90
	public bool Menu_OpenDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.Description] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.Icon] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	// RVA: 0xAAEA80 Offset: 0xAAD080 VA: 0x180AAEA80
	public void Menu_CloseDoor(BasePlayer player) { }

	// RVA: 0xAAE960 Offset: 0xAACF60 VA: 0x180AAE960
	public void Menu_CloseDoor_Proxy(ref Option option) { }

	// RVA: 0xAAE920 Offset: 0xAACF20 VA: 0x180AAE920
	public void Menu_CloseDoorStart() { }

	// RVA: 0xAAEA40 Offset: 0xAAD040 VA: 0x180AAEA40
	public bool Menu_CloseDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.Description] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.Icon] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	// RVA: 0xAAEB30 Offset: 0xAAD130 VA: 0x180AAEB30
	public void Menu_KnockDoor(BasePlayer player) { }

	// RVA: 0xAAEAC0 Offset: 0xAAD0C0 VA: 0x180AAEAC0
	public bool Menu_KnockDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	[BaseEntity.Menu.Description] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	[BaseEntity.Menu.Icon] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	// RVA: 0xAAED20 Offset: 0xAAD320 VA: 0x180AAED20
	public void Menu_ToggleHatch(BasePlayer player) { }

	// RVA: 0xAAED10 Offset: 0xAAD310 VA: 0x180AAED10
	public bool Menu_ToggleHatch_ShowIf(BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 72
	public override bool NeedsCrosshair() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAAED60 Offset: 0xAAD360 VA: 0x180AAED60
	private void OnDoorInterrupted(BaseEntity.RPCMessage msg) { }

	// RVA: 0xAAF580 Offset: 0xAADB80 VA: 0x180AAF580
	private void ReverseDoorAnimation(bool wasOpening) { }

	// RVA: 0x7C4280 Offset: 0x7C2880 VA: 0x1807C4280 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 146
	public void OnObjects(TriggerNotify trigger) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 147
	public void OnEmpty() { }

	// RVA: 0xAAEFF0 Offset: 0xAAD5F0 VA: 0x180AAEFF0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xAAF7B0 Offset: 0xAADDB0 VA: 0x180AAF7B0
	public void .ctor() { }

	// RVA: 0xAAF740 Offset: 0xAADD40 VA: 0x180AAF740
	private static void .cctor() { }

}

