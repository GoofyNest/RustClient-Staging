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

	// RVA: 0xAD88B0 Offset: 0xAD6EB0 VA: 0x180AD88B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD8870 Offset: 0xAD6E70 VA: 0x180AD8870 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xAD8C90 Offset: 0xAD7290 VA: 0x180AD8C90 Slot: 131
	public override void SetupUIMarker(GameObject marker) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 132
	public override MapMarker.ClusterType get_ShouldCluster() { }

	// RVA: 0xAD8DE0 Offset: 0xAD73E0 VA: 0x180AD8DE0 Slot: 134
	public override float get_GetClusterRadius() { }

	// RVA: 0xAD8DF0 Offset: 0xAD73F0 VA: 0x180AD8DF0 Slot: 133
	public override GameObjectRef get_GetClusterUIMarker() { }

	// RVA: 0xAD8A00 Offset: 0xAD7000 VA: 0x180AD8A00 Slot: 135
	public override void SetupUIMarkerCluster(GameObject marker, List<MapMarker> markers) { }

	// RVA: 0xAD8D80 Offset: 0xAD7380 VA: 0x180AD8D80
	public void .ctor() { }

}

