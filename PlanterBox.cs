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

	// RVA: 0x91DE70 Offset: 0x91C470 VA: 0x18091DE70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x91DD90 Offset: 0x91C390 VA: 0x18091DD90 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x91E930 Offset: 0x91CF30 VA: 0x18091E930
	public float get_soilSaturationFraction() { }

	// RVA: 0x67E030 Offset: 0x67C630 VA: 0x18067E030 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x91E300 Offset: 0x91C900 VA: 0x18091E300
	public void SetupMaterialBlock() { }

	// RVA: 0x91E700 Offset: 0x91CD00 VA: 0x18091E700
	public void UpdateMaterialSettings() { }

	// RVA: 0x91E370 Offset: 0x91C970 VA: 0x18091E370 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x91DE00 Offset: 0x91C400 VA: 0x18091DE00 Slot: 75
	public override void LookingAtTick() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x91E2C0 Offset: 0x91C8C0 VA: 0x18091E2C0
	private void RPC_ReceiveSaturationUpdate(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 129
	public override bool SupportsChildDeployables() { }

	// RVA: 0x91E8D0 Offset: 0x91CED0 VA: 0x18091E8D0
	public void .ctor() { }

}

