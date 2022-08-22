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

	// RVA: 0x6A9CA0 Offset: 0x6A82A0 VA: 0x1806A9CA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6AAF30 Offset: 0x6A9530 VA: 0x1806AAF30 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6AA7E0 Offset: 0x6A8DE0 VA: 0x1806AA7E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6AA6F0 Offset: 0x6A8CF0 VA: 0x1806AA6F0
	public void OnHitShared(HitInfo info) { }

	// RVA: 0x50DF50 Offset: 0x50C550 VA: 0x18050DF50
	public bool IsKnockedDown() { }

	// RVA: 0x6AA4B0 Offset: 0x6A8AB0 VA: 0x1806AA4B0 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x6A9BF0 Offset: 0x6A81F0 VA: 0x1806A9BF0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x6A9C30 Offset: 0x6A8230 VA: 0x1806A9C30
	public bool CanToggle() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AA220 Offset: 0x6A8820 VA: 0x1806AA220
	public void HitEffect(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6A9C60 Offset: 0x6A8260 VA: 0x1806A9C60 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x6AA5B0 Offset: 0x6A8BB0 VA: 0x1806AA5B0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x6AAE00 Offset: 0x6A9400 VA: 0x1806AAE00
	private void UpdateAnimationParameters(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.Description] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.Icon] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	// RVA: 0x6AADC0 Offset: 0x6A93C0 VA: 0x1806AADC0
	public void Reset_target(BasePlayer player) { }

	// RVA: 0x6AA460 Offset: 0x6A8A60 VA: 0x1806AA460
	public bool Menu_Reset_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.Description] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.Icon] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	// RVA: 0x6AA3D0 Offset: 0x6A89D0 VA: 0x1806AA3D0
	public void Lower_Target(BasePlayer player) { }

	// RVA: 0x6AA410 Offset: 0x6A8A10 VA: 0x1806AA410
	public bool Menu_Lower_ShowIf(BasePlayer player) { }

	// RVA: 0x6AAEC0 Offset: 0x6A94C0 VA: 0x1806AAEC0
	public void .ctor() { }

}

