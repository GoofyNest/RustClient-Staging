public class MedicalTool : AttackEntity // TypeDefIndex: 8603
{	// Fields
	public float healDurationSelf; // 0x280
	public float healDurationOther; // 0x284
	public float healDurationOtherWounded; // 0x288
	public float maxDistanceOther; // 0x28C
	public bool canUseOnOther; // 0x290
	public bool canRevive; // 0x291
	private BasePlayer useTarget; // 0x298
	private float resetTime; // 0x2A0

	// Methods

	// RVA: 0x95C490 Offset: 0x95AA90 VA: 0x18095C490 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x95BD30 Offset: 0x95A330 VA: 0x18095BD30
	public BasePlayer GetTarget() { }

	// RVA: 0x95BC60 Offset: 0x95A260 VA: 0x18095BC60
	public bool AnyPressed() { }

	// RVA: 0x95C0E0 Offset: 0x95A6E0 VA: 0x18095C0E0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x95C860 Offset: 0x95AE60 VA: 0x18095C860 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95CA70 Offset: 0x95B070 VA: 0x18095CA70
	public void Reset() { }

	// RVA: 0x95C080 Offset: 0x95A680 VA: 0x18095C080 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x95C0B0 Offset: 0x95A6B0 VA: 0x18095C0B0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x95C9B0 Offset: 0x95AFB0 VA: 0x18095C9B0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x95CA90 Offset: 0x95B090 VA: 0x18095CA90
	public void .ctor() { }

}

