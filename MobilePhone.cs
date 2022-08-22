public class MobilePhone : HeldEntity // TypeDefIndex: 8607
{	// Fields
	public PhoneController Controller; // 0x1F8

	// Methods

	// RVA: 0x76D5B0 Offset: 0x76BBB0 VA: 0x18076D5B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x76D2C0 Offset: 0x76B8C0 VA: 0x18076D2C0 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x76D360 Offset: 0x76B960 VA: 0x18076D360 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x76D440 Offset: 0x76BA40 VA: 0x18076D440 Slot: 138
	public override void OnInput() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76F330 Offset: 0x76D930 VA: 0x18076F330
	public void UpdatePhoneNumber(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76F2F0 Offset: 0x76D8F0 VA: 0x18076F2F0
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D040 Offset: 0x76B640 VA: 0x18076D040
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D0C0 Offset: 0x76B6C0 VA: 0x18076D0C0
	private void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D080 Offset: 0x76B680 VA: 0x18076D080
	private void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D410 Offset: 0x76BA10 VA: 0x18076D410
	public void OnIncomingCallDuringCall() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D570 Offset: 0x76BB70 VA: 0x18076D570
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76F2B0 Offset: 0x76D8B0 VA: 0x18076F2B0
	private void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D100 Offset: 0x76B700 VA: 0x18076D100
	private void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x76D140 Offset: 0x76B740 VA: 0x18076D140 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x76D310 Offset: 0x76B910 VA: 0x18076D310 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x76F370 Offset: 0x76D970 VA: 0x18076F370
	public void .ctor() { }

}

