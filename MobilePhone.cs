public class MobilePhone : HeldEntity // TypeDefIndex: 8607
{	// Fields
	public PhoneController Controller; // 0x1F8

	// Methods

	// RVA: 0x76D550 Offset: 0x76BB50 VA: 0x18076D550 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x76D260 Offset: 0x76B860 VA: 0x18076D260 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x76D300 Offset: 0x76B900 VA: 0x18076D300 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x76D3E0 Offset: 0x76B9E0 VA: 0x18076D3E0 Slot: 138
	public override void OnInput() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x76F2D0 Offset: 0x76D8D0 VA: 0x18076F2D0
	public void UpdatePhoneNumber(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x76F290 Offset: 0x76D890 VA: 0x18076F290
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x76CFE0 Offset: 0x76B5E0 VA: 0x18076CFE0
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x76D060 Offset: 0x76B660 VA: 0x18076D060
	private void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x76D020 Offset: 0x76B620 VA: 0x18076D020
	private void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x76D3B0 Offset: 0x76B9B0 VA: 0x18076D3B0
	public void OnIncomingCallDuringCall() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x76D510 Offset: 0x76BB10 VA: 0x18076D510
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x76F250 Offset: 0x76D850 VA: 0x18076F250
	private void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x76D0A0 Offset: 0x76B6A0 VA: 0x18076D0A0
	private void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x76D0E0 Offset: 0x76B6E0 VA: 0x18076D0E0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x76D2B0 Offset: 0x76B8B0 VA: 0x18076D2B0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x76F310 Offset: 0x76D910 VA: 0x18076F310
	public void .ctor() { }

}

