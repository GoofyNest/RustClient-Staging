public class VendingMachineMapMarker : MapMarker // TypeDefIndex: 9614
{	// Fields
	public string markerShopName; // 0x178
	public VendingMachine server_vendingMachine; // 0x180
	public VendingMachine client_vendingMachine; // 0x188
	public uint client_vendingMachineNetworkID; // 0x190
	public GameObjectRef clusterMarkerObj; // 0x198

	// Properties
	public override MapMarker.ClusterType ShouldCluster { get; }
	public override float GetClusterRadius { get; }
	public override GameObjectRef GetClusterUIMarker { get; }

	// Methods

	// RVA: 0xAD85F0 Offset: 0xAD6BF0 VA: 0x180AD85F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD85B0 Offset: 0xAD6BB0 VA: 0x180AD85B0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xAD89D0 Offset: 0xAD6FD0 VA: 0x180AD89D0 Slot: 131
	public override void SetupUIMarker(GameObject marker) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 132
	public override MapMarker.ClusterType get_ShouldCluster() { }

	// RVA: 0xAD8B20 Offset: 0xAD7120 VA: 0x180AD8B20 Slot: 134
	public override float get_GetClusterRadius() { }

	// RVA: 0xAD8B30 Offset: 0xAD7130 VA: 0x180AD8B30 Slot: 133
	public override GameObjectRef get_GetClusterUIMarker() { }

	// RVA: 0xAD8740 Offset: 0xAD6D40 VA: 0x180AD8740 Slot: 135
	public override void SetupUIMarkerCluster(GameObject marker, List<MapMarker> markers) { }

	// RVA: 0xAD8AC0 Offset: 0xAD70C0 VA: 0x180AD8AC0
	public void .ctor() { }

}

