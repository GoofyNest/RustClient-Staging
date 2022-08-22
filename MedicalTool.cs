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

	// RVA: 0x95CAA0 Offset: 0x95B0A0 VA: 0x18095CAA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x95C340 Offset: 0x95A940 VA: 0x18095C340
	public BasePlayer GetTarget() { }

	// RVA: 0x95C270 Offset: 0x95A870 VA: 0x18095C270
	public bool AnyPressed() { }

	// RVA: 0x95C6F0 Offset: 0x95ACF0 VA: 0x18095C6F0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x95CE70 Offset: 0x95B470 VA: 0x18095CE70 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95D080 Offset: 0x95B680 VA: 0x18095D080
	public void Reset() { }

	// RVA: 0x95C690 Offset: 0x95AC90 VA: 0x18095C690 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x95C6C0 Offset: 0x95ACC0 VA: 0x18095C6C0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x95CFC0 Offset: 0x95B5C0 VA: 0x18095CFC0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x95D0A0 Offset: 0x95B6A0 VA: 0x18095D0A0
	public void .ctor() { }

}

