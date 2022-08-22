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

	// RVA: 0xAAD560 Offset: 0xAABB60 VA: 0x180AAD560 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAAF040 Offset: 0xAAD640 VA: 0x180AAF040 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAAE990 Offset: 0xAACF90 VA: 0x180AAE990 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAAEDE0 Offset: 0xAAD3E0 VA: 0x180AAEDE0 Slot: 27
	public override void ResetState() { }

	// RVA: 0xAAE150 Offset: 0xAAC750 VA: 0x180AAE150 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0xAAD3F0 Offset: 0xAAB9F0 VA: 0x180AAD3F0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.Description] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.Icon] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	// RVA: 0xAAE540 Offset: 0xAACB40 VA: 0x180AAE540
	public void Menu_OpenDoor(BasePlayer player) { }

	// RVA: 0xAAE420 Offset: 0xAACA20 VA: 0x180AAE420
	public void Menu_OpenDoor_Proxy(ref Option option) { }

	// RVA: 0xAAE3E0 Offset: 0xAAC9E0 VA: 0x180AAE3E0
	public void Menu_OpenDoorStart() { }

	// RVA: 0xAAE500 Offset: 0xAACB00 VA: 0x180AAE500
	public bool Menu_OpenDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.Description] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.Icon] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	// RVA: 0xAAE2F0 Offset: 0xAAC8F0 VA: 0x180AAE2F0
	public void Menu_CloseDoor(BasePlayer player) { }

	// RVA: 0xAAE1D0 Offset: 0xAAC7D0 VA: 0x180AAE1D0
	public void Menu_CloseDoor_Proxy(ref Option option) { }

	// RVA: 0xAAE190 Offset: 0xAAC790 VA: 0x180AAE190
	public void Menu_CloseDoorStart() { }

	// RVA: 0xAAE2B0 Offset: 0xAAC8B0 VA: 0x180AAE2B0
	public bool Menu_CloseDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.Description] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.Icon] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	// RVA: 0xAAE3A0 Offset: 0xAAC9A0 VA: 0x180AAE3A0
	public void Menu_KnockDoor(BasePlayer player) { }

	// RVA: 0xAAE330 Offset: 0xAAC930 VA: 0x180AAE330
	public bool Menu_KnockDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	[BaseEntity.Menu.Description] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	[BaseEntity.Menu.Icon] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	// RVA: 0xAAE590 Offset: 0xAACB90 VA: 0x180AAE590
	public void Menu_ToggleHatch(BasePlayer player) { }

	// RVA: 0xAAE580 Offset: 0xAACB80 VA: 0x180AAE580
	public bool Menu_ToggleHatch_ShowIf(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 72
	public override bool NeedsCrosshair() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAAE5D0 Offset: 0xAACBD0 VA: 0x180AAE5D0
	private void OnDoorInterrupted(BaseEntity.RPCMessage msg) { }

	// RVA: 0xAAEDF0 Offset: 0xAAD3F0 VA: 0x180AAEDF0
	private void ReverseDoorAnimation(bool wasOpening) { }

	// RVA: 0x7A5D70 Offset: 0x7A4370 VA: 0x1807A5D70 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 146
	public void OnObjects(TriggerNotify trigger) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 147
	public void OnEmpty() { }

	// RVA: 0xAAE860 Offset: 0xAACE60 VA: 0x180AAE860 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xAAF020 Offset: 0xAAD620 VA: 0x180AAF020
	public void .ctor() { }

	// RVA: 0xAAEFB0 Offset: 0xAAD5B0 VA: 0x180AAEFB0
	private static void .cctor() { }

}

