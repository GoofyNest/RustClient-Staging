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

	// RVA: 0x95C5A0 Offset: 0x95ABA0 VA: 0x18095C5A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x95BE40 Offset: 0x95A440 VA: 0x18095BE40
	public BasePlayer GetTarget() { }

	// RVA: 0x95BD70 Offset: 0x95A370 VA: 0x18095BD70
	public bool AnyPressed() { }

	// RVA: 0x95C1F0 Offset: 0x95A7F0 VA: 0x18095C1F0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x95C970 Offset: 0x95AF70 VA: 0x18095C970 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95CB80 Offset: 0x95B180 VA: 0x18095CB80
	public void Reset() { }

	// RVA: 0x95C190 Offset: 0x95A790 VA: 0x18095C190 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x95C1C0 Offset: 0x95A7C0 VA: 0x18095C1C0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x95CAC0 Offset: 0x95B0C0 VA: 0x18095CAC0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x95CBA0 Offset: 0x95B1A0 VA: 0x18095CBA0
	public void .ctor() { }

}

