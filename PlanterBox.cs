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

	// RVA: 0x91D960 Offset: 0x91BF60 VA: 0x18091D960 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x91D880 Offset: 0x91BE80 VA: 0x18091D880 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x91E420 Offset: 0x91CA20 VA: 0x18091E420
	public float get_soilSaturationFraction() { }

	// RVA: 0x67E0A0 Offset: 0x67C6A0 VA: 0x18067E0A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x91DDF0 Offset: 0x91C3F0 VA: 0x18091DDF0
	public void SetupMaterialBlock() { }

	// RVA: 0x91E1F0 Offset: 0x91C7F0 VA: 0x18091E1F0
	public void UpdateMaterialSettings() { }

	// RVA: 0x91DE60 Offset: 0x91C460 VA: 0x18091DE60 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x91D8F0 Offset: 0x91BEF0 VA: 0x18091D8F0 Slot: 75
	public override void LookingAtTick() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x91DDB0 Offset: 0x91C3B0 VA: 0x18091DDB0
	private void RPC_ReceiveSaturationUpdate(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 129
	public override bool SupportsChildDeployables() { }

	// RVA: 0x91E3C0 Offset: 0x91C9C0 VA: 0x18091E3C0
	public void .ctor() { }

}

