public class MapMarker : BaseEntity // TypeDefIndex: 9595
{	// Fields
	public AppMarkerType appType; // 0x168
	public GameObjectRef markerObj; // 0x170
	public static readonly List<MapMarker> mapMarkers; // 0x0

	// Properties
	public virtual MapMarker.ClusterType ShouldCluster { get; }
	public virtual GameObjectRef GetClusterUIMarker { get; }
	public virtual float GetClusterRadius { get; }

	// Methods

	// RVA: 0x568310 Offset: 0x566910 VA: 0x180568310
	public static void Init() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 131
	public virtual void SetupUIMarker(GameObject marker) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 132
	public virtual MapMarker.ClusterType get_ShouldCluster() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 133
	public virtual GameObjectRef get_GetClusterUIMarker() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 134
	public virtual float get_GetClusterRadius() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 135
	public virtual void SetupUIMarkerCluster(GameObject marker, List<MapMarker> markers) { }

	// RVA: 0x5684D0 Offset: 0x566AD0 VA: 0x1805684D0
	public static void UpdateInterface() { }

	// RVA: 0x568380 Offset: 0x566980 VA: 0x180568380 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x568220 Offset: 0x566820 VA: 0x180568220 Slot: 28
	public override void InitShared() { }

	// RVA: 0x568180 Offset: 0x566780 VA: 0x180568180 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x568610 Offset: 0x566C10 VA: 0x180568610
	public void .ctor() { }

	// RVA: 0x5685B0 Offset: 0x566BB0 VA: 0x1805685B0
	private static void .cctor() { }

}

public enum MapMarker.ClusterType // TypeDefIndex: 9596
{	// Fields
	public int value__; // 0x0
	public const MapMarker.ClusterType None = 0;
	public const MapMarker.ClusterType Vending = 1;

}

