public class ReactiveTarget : IOEntity // TypeDefIndex: 8433
{	private Option __menuOption_Lower_Target; // 0x288
	private Option __menuOption_Reset_target; // 0x2E0
	public Animator myAnimator; // 0x338
	public GameObjectRef bullseyeEffect; // 0x340
	public GameObjectRef knockdownEffect; // 0x348
	public float activationPowerTime; // 0x350
	public int activationPowerAmount; // 0x354
	private float lastToggleTime; // 0x358

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void OnHitShared(HitInfo info) { }

	public bool IsKnockedDown() { }

	public override void OnAttacked(HitInfo info) { }

	public override bool CanPickup(BasePlayer player) { }

	public bool CanToggle() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void HitEffect(BaseEntity.RPCMessage msg) { }

	public override void ClientOnEnable() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void UpdateAnimationParameters(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.Description] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.Icon] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F300 Offset: 0x7E700 VA: 0x18007F300
	public void Reset_target(BasePlayer player) { }

	public bool Menu_Reset_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.Description] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.Icon] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	public void Lower_Target(BasePlayer player) { }

	public bool Menu_Lower_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

