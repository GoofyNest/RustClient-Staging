public class StaticInstrument : BaseMountable // TypeDefIndex: 8652
{	// Fields
	public AnimatorOverrideController AnimatorOverride; // 0x320
	public bool ShowDeployAnimation; // 0x328
	public InstrumentKeyController KeyController; // 0x330
	public bool ShouldSuppressHandsAnimationLayer; // 0x338
	private BasePlayer lateUpdatePlayer; // 0x340

	// Methods

	// RVA: 0xA8C6B0 Offset: 0xA8ACB0 VA: 0x180A8C6B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA8C530 Offset: 0xA8AB30 VA: 0x180A8C530 Slot: 162
	protected override AnimatorOverrideController GetAnimationOverride() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 163
	protected override float GetSpineLookAtWeight() { }

	// RVA: 0xA8D210 Offset: 0xA8B810 VA: 0x180A8D210 Slot: 161
	protected override bool SuppressHandsAnimationLayer() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0xA8C5F0 Offset: 0xA8ABF0 VA: 0x180A8C5F0 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0xA8D220 Offset: 0xA8B820 VA: 0x180A8D220 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA8C540 Offset: 0xA8AB40 VA: 0x180A8C540
	private void LateUpdate() { }

	// RVA: 0xA8C090 Offset: 0xA8A690 VA: 0x180A8C090 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0xA8BFD0 Offset: 0xA8A5D0 VA: 0x180A8BFD0 Slot: 178
	protected override void ClientOnPlayerDismounted(BasePlayer player) { }

	// RVA: 0xA8D180 Offset: 0xA8B780 VA: 0x180A8D180 Slot: 27
	public override void ResetState() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA8C190 Offset: 0xA8A790 VA: 0x180A8C190
	private void Client_PlayNote(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA8C360 Offset: 0xA8A960 VA: 0x180A8C360
	private void Client_StopNote(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 172
	public override bool IsInstrument() { }

	// RVA: 0xA8D2F0 Offset: 0xA8B8F0 VA: 0x180A8D2F0
	public void .ctor() { }

}

