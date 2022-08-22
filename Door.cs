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

	// RVA: 0xAAD820 Offset: 0xAABE20 VA: 0x180AAD820 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAAF300 Offset: 0xAAD900 VA: 0x180AAF300 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAAEC50 Offset: 0xAAD250 VA: 0x180AAEC50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAAF0A0 Offset: 0xAAD6A0 VA: 0x180AAF0A0 Slot: 27
	public override void ResetState() { }

	// RVA: 0xAAE410 Offset: 0xAACA10 VA: 0x180AAE410 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0xAAD6B0 Offset: 0xAABCB0 VA: 0x180AAD6B0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.Description] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.Icon] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9060 Offset: 0xD8460 VA: 0x1800D9060
	// RVA: 0xAAE800 Offset: 0xAACE00 VA: 0x180AAE800
	public void Menu_OpenDoor(BasePlayer player) { }

	// RVA: 0xAAE6E0 Offset: 0xAACCE0 VA: 0x180AAE6E0
	public void Menu_OpenDoor_Proxy(ref Option option) { }

	// RVA: 0xAAE6A0 Offset: 0xAACCA0 VA: 0x180AAE6A0
	public void Menu_OpenDoorStart() { }

	// RVA: 0xAAE7C0 Offset: 0xAACDC0 VA: 0x180AAE7C0
	public bool Menu_OpenDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.Description] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.Icon] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	// RVA: 0xAAE5B0 Offset: 0xAACBB0 VA: 0x180AAE5B0
	public void Menu_CloseDoor(BasePlayer player) { }

	// RVA: 0xAAE490 Offset: 0xAACA90 VA: 0x180AAE490
	public void Menu_CloseDoor_Proxy(ref Option option) { }

	// RVA: 0xAAE450 Offset: 0xAACA50 VA: 0x180AAE450
	public void Menu_CloseDoorStart() { }

	// RVA: 0xAAE570 Offset: 0xAACB70 VA: 0x180AAE570
	public bool Menu_CloseDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.Description] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.Icon] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9930 Offset: 0xD8D30 VA: 0x1800D9930
	// RVA: 0xAAE660 Offset: 0xAACC60 VA: 0x180AAE660
	public void Menu_KnockDoor(BasePlayer player) { }

	// RVA: 0xAAE5F0 Offset: 0xAACBF0 VA: 0x180AAE5F0
	public bool Menu_KnockDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	[BaseEntity.Menu.Description] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	[BaseEntity.Menu.Icon] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9C00 Offset: 0xD9000 VA: 0x1800D9C00
	// RVA: 0xAAE850 Offset: 0xAACE50 VA: 0x180AAE850
	public void Menu_ToggleHatch(BasePlayer player) { }

	// RVA: 0xAAE840 Offset: 0xAACE40 VA: 0x180AAE840
	public bool Menu_ToggleHatch_ShowIf(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 72
	public override bool NeedsCrosshair() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAAE890 Offset: 0xAACE90 VA: 0x180AAE890
	private void OnDoorInterrupted(BaseEntity.RPCMessage msg) { }

	// RVA: 0xAAF0B0 Offset: 0xAAD6B0 VA: 0x180AAF0B0
	private void ReverseDoorAnimation(bool wasOpening) { }

	// RVA: 0x7A5E80 Offset: 0x7A4480 VA: 0x1807A5E80 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 146
	public void OnObjects(TriggerNotify trigger) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 147
	public void OnEmpty() { }

	// RVA: 0xAAEB20 Offset: 0xAAD120 VA: 0x180AAEB20 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xAAF2E0 Offset: 0xAAD8E0 VA: 0x180AAF2E0
	public void .ctor() { }

	// RVA: 0xAAF270 Offset: 0xAAD870 VA: 0x180AAF270
	private static void .cctor() { }

}

