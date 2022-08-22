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

	// RVA: 0x6A9D40 Offset: 0x6A8340 VA: 0x1806A9D40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6AAFD0 Offset: 0x6A95D0 VA: 0x1806AAFD0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6AA880 Offset: 0x6A8E80 VA: 0x1806AA880 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6AA790 Offset: 0x6A8D90 VA: 0x1806AA790
	public void OnHitShared(HitInfo info) { }

	// RVA: 0x50DEE0 Offset: 0x50C4E0 VA: 0x18050DEE0
	public bool IsKnockedDown() { }

	// RVA: 0x6AA550 Offset: 0x6A8B50 VA: 0x1806AA550 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x6A9C90 Offset: 0x6A8290 VA: 0x1806A9C90 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x6A9CD0 Offset: 0x6A82D0 VA: 0x1806A9CD0
	public bool CanToggle() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AA2C0 Offset: 0x6A88C0 VA: 0x1806AA2C0
	public void HitEffect(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6A9D00 Offset: 0x6A8300 VA: 0x1806A9D00 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x6AA650 Offset: 0x6A8C50 VA: 0x1806AA650 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x6AAEA0 Offset: 0x6A94A0 VA: 0x1806AAEA0
	private void UpdateAnimationParameters(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.Description] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.Icon] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	// RVA: 0x6AAE60 Offset: 0x6A9460 VA: 0x1806AAE60
	public void Reset_target(BasePlayer player) { }

	// RVA: 0x6AA500 Offset: 0x6A8B00 VA: 0x1806AA500
	public bool Menu_Reset_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.Description] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.Icon] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	// RVA: 0x6AA470 Offset: 0x6A8A70 VA: 0x1806AA470
	public void Lower_Target(BasePlayer player) { }

	// RVA: 0x6AA4B0 Offset: 0x6A8AB0 VA: 0x1806AA4B0
	public bool Menu_Lower_ShowIf(BasePlayer player) { }

	// RVA: 0x6AAF60 Offset: 0x6A9560 VA: 0x1806AAF60
	public void .ctor() { }

}

