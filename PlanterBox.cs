public class PlanterBox : StorageContainer, ISplashable // TypeDefIndex: 8619
{	// Fields
	public int soilSaturation; // 0x3D0
	public int soilSaturationMax; // 0x3D4
	public MeshRenderer soilRenderer; // 0x3D8
	private MaterialPropertyBlock block; // 0x3E0
	private TimeSince saturationUpdate; // 0x3E8

	// Properties
	public float soilSaturationFraction { get; }

	// Methods

	// RVA: 0x91D850 Offset: 0x91BE50 VA: 0x18091D850 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x91D770 Offset: 0x91BD70 VA: 0x18091D770 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x91E310 Offset: 0x91C910 VA: 0x18091E310
	public float get_soilSaturationFraction() { }

	// RVA: 0x67E0A0 Offset: 0x67C6A0 VA: 0x18067E0A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x91DCE0 Offset: 0x91C2E0 VA: 0x18091DCE0
	public void SetupMaterialBlock() { }

	// RVA: 0x91E0E0 Offset: 0x91C6E0 VA: 0x18091E0E0
	public void UpdateMaterialSettings() { }

	// RVA: 0x91DD50 Offset: 0x91C350 VA: 0x18091DD50 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x91D7E0 Offset: 0x91BDE0 VA: 0x18091D7E0 Slot: 75
	public override void LookingAtTick() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x91DCA0 Offset: 0x91C2A0 VA: 0x18091DCA0
	private void RPC_ReceiveSaturationUpdate(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 129
	public override bool SupportsChildDeployables() { }

	// RVA: 0x91E2B0 Offset: 0x91C8B0 VA: 0x18091E2B0
	public void .ctor() { }

}

