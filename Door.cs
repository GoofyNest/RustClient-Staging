public class Door : AnimatedBuildingBlock, INotifyTrigger // TypeDefIndex: 8381
{	private Option __menuOption_Menu_CloseDoor; // 0x270
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

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	public override bool HasSlot(BaseEntity.Slot slot) { }

	public override bool CanPickup(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD90F0 Offset: 0xD84F0 VA: 0x1800D90F0
	[BaseEntity.Menu.Description] // RVA: 0xD90F0 Offset: 0xD84F0 VA: 0x1800D90F0
	[BaseEntity.Menu.Icon] // RVA: 0xD90F0 Offset: 0xD84F0 VA: 0x1800D90F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD90F0 Offset: 0xD84F0 VA: 0x1800D90F0
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD90F0 Offset: 0xD84F0 VA: 0x1800D90F0
	public void Menu_OpenDoor(BasePlayer player) { }

	public void Menu_OpenDoor_Proxy(ref Option option) { }

	public void Menu_OpenDoorStart() { }

	public bool Menu_OpenDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9590 Offset: 0xD8990 VA: 0x1800D9590
	[BaseEntity.Menu.Description] // RVA: 0xD9590 Offset: 0xD8990 VA: 0x1800D9590
	[BaseEntity.Menu.Icon] // RVA: 0xD9590 Offset: 0xD8990 VA: 0x1800D9590
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9590 Offset: 0xD8990 VA: 0x1800D9590
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9590 Offset: 0xD8990 VA: 0x1800D9590
	public void Menu_CloseDoor(BasePlayer player) { }

	public void Menu_CloseDoor_Proxy(ref Option option) { }

	public void Menu_CloseDoorStart() { }

	public bool Menu_CloseDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9AB0 Offset: 0xD8EB0 VA: 0x1800D9AB0
	[BaseEntity.Menu.Description] // RVA: 0xD9AB0 Offset: 0xD8EB0 VA: 0x1800D9AB0
	[BaseEntity.Menu.Icon] // RVA: 0xD9AB0 Offset: 0xD8EB0 VA: 0x1800D9AB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9AB0 Offset: 0xD8EB0 VA: 0x1800D9AB0
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9AB0 Offset: 0xD8EB0 VA: 0x1800D9AB0
	public void Menu_KnockDoor(BasePlayer player) { }

	public bool Menu_KnockDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9D20 Offset: 0xD9120 VA: 0x1800D9D20
	[BaseEntity.Menu.Description] // RVA: 0xD9D20 Offset: 0xD9120 VA: 0x1800D9D20
	[BaseEntity.Menu.Icon] // RVA: 0xD9D20 Offset: 0xD9120 VA: 0x1800D9D20
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9D20 Offset: 0xD9120 VA: 0x1800D9D20
	public void Menu_ToggleHatch(BasePlayer player) { }

	public bool Menu_ToggleHatch_ShowIf(BasePlayer player) { }

	public override bool NeedsCrosshair() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnDoorInterrupted(BaseEntity.RPCMessage msg) { }

	private void ReverseDoorAnimation(bool wasOpening) { }

	public override float BoundsPadding() { }

	public void OnObjects(TriggerNotify trigger) { }

	public void OnEmpty() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

	private static void .cctor() { }

}

