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

	// RVA: 0xAD8D80 Offset: 0xAD7380 VA: 0x180AD8D80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD8D40 Offset: 0xAD7340 VA: 0x180AD8D40 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xAD9160 Offset: 0xAD7760 VA: 0x180AD9160 Slot: 131
	public override void SetupUIMarker(GameObject marker) { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 132
	public override MapMarker.ClusterType get_ShouldCluster() { }

	// RVA: 0xAD92B0 Offset: 0xAD78B0 VA: 0x180AD92B0 Slot: 134
	public override float get_GetClusterRadius() { }

	// RVA: 0xAD92C0 Offset: 0xAD78C0 VA: 0x180AD92C0 Slot: 133
	public override GameObjectRef get_GetClusterUIMarker() { }

	// RVA: 0xAD8ED0 Offset: 0xAD74D0 VA: 0x180AD8ED0 Slot: 135
	public override void SetupUIMarkerCluster(GameObject marker, List<MapMarker> markers) { }

	// RVA: 0xAD9250 Offset: 0xAD7850 VA: 0x180AD9250
	public void .ctor() { }

}

