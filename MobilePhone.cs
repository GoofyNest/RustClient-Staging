public class MobilePhone : HeldEntity // TypeDefIndex: 8607
{	// Fields
	public PhoneController Controller; // 0x1F8

	// Methods

	// RVA: 0x76D660 Offset: 0x76BC60 VA: 0x18076D660 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x76D370 Offset: 0x76B970 VA: 0x18076D370 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x76D410 Offset: 0x76BA10 VA: 0x18076D410 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x76D4F0 Offset: 0x76BAF0 VA: 0x18076D4F0 Slot: 138
	public override void OnInput() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76F3E0 Offset: 0x76D9E0 VA: 0x18076F3E0
	public void UpdatePhoneNumber(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D0F0 Offset: 0x76B6F0 VA: 0x18076D0F0
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D170 Offset: 0x76B770 VA: 0x18076D170
	private void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D130 Offset: 0x76B730 VA: 0x18076D130
	private void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D4C0 Offset: 0x76BAC0 VA: 0x18076D4C0
	public void OnIncomingCallDuringCall() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D620 Offset: 0x76BC20 VA: 0x18076D620
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76F360 Offset: 0x76D960 VA: 0x18076F360
	private void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76D1B0 Offset: 0x76B7B0 VA: 0x18076D1B0
	private void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x76D1F0 Offset: 0x76B7F0 VA: 0x18076D1F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x76D3C0 Offset: 0x76B9C0 VA: 0x18076D3C0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x76F420 Offset: 0x76DA20 VA: 0x18076F420
	public void .ctor() { }

}

