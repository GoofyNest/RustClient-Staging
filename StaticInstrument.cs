public class StaticInstrument : BaseMountable // TypeDefIndex: 8652
{	// Fields
	public AnimatorOverrideController AnimatorOverride; // 0x320
	public bool ShowDeployAnimation; // 0x328
	public InstrumentKeyController KeyController; // 0x330
	public bool ShouldSuppressHandsAnimationLayer; // 0x338
	private BasePlayer lateUpdatePlayer; // 0x340

	// Methods

	// RVA: 0xA8CE40 Offset: 0xA8B440 VA: 0x180A8CE40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA8CCC0 Offset: 0xA8B2C0 VA: 0x180A8CCC0 Slot: 162
	protected override AnimatorOverrideController GetAnimationOverride() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 163
	protected override float GetSpineLookAtWeight() { }

	// RVA: 0xA8D9A0 Offset: 0xA8BFA0 VA: 0x180A8D9A0 Slot: 161
	protected override bool SuppressHandsAnimationLayer() { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0xA8CD80 Offset: 0xA8B380 VA: 0x180A8CD80 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0xA8D9B0 Offset: 0xA8BFB0 VA: 0x180A8D9B0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA8CCD0 Offset: 0xA8B2D0 VA: 0x180A8CCD0
	private void LateUpdate() { }

	// RVA: 0xA8C820 Offset: 0xA8AE20 VA: 0x180A8C820 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0xA8C760 Offset: 0xA8AD60 VA: 0x180A8C760 Slot: 178
	protected override void ClientOnPlayerDismounted(BasePlayer player) { }

	// RVA: 0xA8D910 Offset: 0xA8BF10 VA: 0x180A8D910 Slot: 27
	public override void ResetState() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA8C920 Offset: 0xA8AF20 VA: 0x180A8C920
	private void Client_PlayNote(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA8CAF0 Offset: 0xA8B0F0 VA: 0x180A8CAF0
	private void Client_StopNote(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 172
	public override bool IsInstrument() { }

	// RVA: 0xA8DA80 Offset: 0xA8C080 VA: 0x180A8DA80
	public void .ctor() { }

}

