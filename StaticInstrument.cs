public class StaticInstrument : BaseMountable // TypeDefIndex: 8652
{	// Fields
	public AnimatorOverrideController AnimatorOverride; // 0x320
	public bool ShowDeployAnimation; // 0x328
	public InstrumentKeyController KeyController; // 0x330
	public bool ShouldSuppressHandsAnimationLayer; // 0x338
	private BasePlayer lateUpdatePlayer; // 0x340

	// Methods

	// RVA: 0xA8C970 Offset: 0xA8AF70 VA: 0x180A8C970 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA8C7F0 Offset: 0xA8ADF0 VA: 0x180A8C7F0 Slot: 162
	protected override AnimatorOverrideController GetAnimationOverride() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 163
	protected override float GetSpineLookAtWeight() { }

	// RVA: 0xA8D4D0 Offset: 0xA8BAD0 VA: 0x180A8D4D0 Slot: 161
	protected override bool SuppressHandsAnimationLayer() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0xA8C8B0 Offset: 0xA8AEB0 VA: 0x180A8C8B0 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0xA8D4E0 Offset: 0xA8BAE0 VA: 0x180A8D4E0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA8C800 Offset: 0xA8AE00 VA: 0x180A8C800
	private void LateUpdate() { }

	// RVA: 0xA8C350 Offset: 0xA8A950 VA: 0x180A8C350 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0xA8C290 Offset: 0xA8A890 VA: 0x180A8C290 Slot: 178
	protected override void ClientOnPlayerDismounted(BasePlayer player) { }

	// RVA: 0xA8D440 Offset: 0xA8BA40 VA: 0x180A8D440 Slot: 27
	public override void ResetState() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA8C450 Offset: 0xA8AA50 VA: 0x180A8C450
	private void Client_PlayNote(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA8C620 Offset: 0xA8AC20 VA: 0x180A8C620
	private void Client_StopNote(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 172
	public override bool IsInstrument() { }

	// RVA: 0xA8D5B0 Offset: 0xA8BBB0 VA: 0x180A8D5B0
	public void .ctor() { }

}

