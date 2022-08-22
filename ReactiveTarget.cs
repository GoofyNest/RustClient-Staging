public class ReactiveTarget : IOEntity // TypeDefIndex: 8433
{	// Fields
	private Option __menuOption_Lower_Target; // 0x288
	private Option __menuOption_Reset_target; // 0x2E0
	public Animator myAnimator; // 0x338
	public GameObjectRef bullseyeEffect; // 0x340
	public GameObjectRef knockdownEffect; // 0x348
	public float activationPowerTime; // 0x350
	public int activationPowerAmount; // 0x354
	private float lastToggleTime; // 0x358

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6A9DB0 Offset: 0x6A83B0 VA: 0x1806A9DB0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6AB040 Offset: 0x6A9640 VA: 0x1806AB040 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6AA8F0 Offset: 0x6A8EF0 VA: 0x1806AA8F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6AA800 Offset: 0x6A8E00 VA: 0x1806AA800
	public void OnHitShared(HitInfo info) { }

	// RVA: 0x50DF50 Offset: 0x50C550 VA: 0x18050DF50
	public bool IsKnockedDown() { }

	// RVA: 0x6AA5C0 Offset: 0x6A8BC0 VA: 0x1806AA5C0 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x6A9D00 Offset: 0x6A8300 VA: 0x1806A9D00 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x6A9D40 Offset: 0x6A8340 VA: 0x1806A9D40
	public bool CanToggle() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AA330 Offset: 0x6A8930 VA: 0x1806AA330
	public void HitEffect(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6A9D70 Offset: 0x6A8370 VA: 0x1806A9D70 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x6AA6C0 Offset: 0x6A8CC0 VA: 0x1806AA6C0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x6AAF10 Offset: 0x6A9510 VA: 0x1806AAF10
	private void UpdateAnimationParameters(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.Description] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.Icon] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	// RVA: 0x6AAED0 Offset: 0x6A94D0 VA: 0x1806AAED0
	public void Reset_target(BasePlayer player) { }

	// RVA: 0x6AA570 Offset: 0x6A8B70 VA: 0x1806AA570
	public bool Menu_Reset_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.Description] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.Icon] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	// RVA: 0x6AA4E0 Offset: 0x6A8AE0 VA: 0x1806AA4E0
	public void Lower_Target(BasePlayer player) { }

	// RVA: 0x6AA520 Offset: 0x6A8B20 VA: 0x1806AA520
	public bool Menu_Lower_ShowIf(BasePlayer player) { }

	// RVA: 0x6AAFD0 Offset: 0x6A95D0 VA: 0x1806AAFD0
	public void .ctor() { }

}

