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

	// RVA: 0x568380 Offset: 0x566980 VA: 0x180568380
	public static void Init() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 131
	public virtual void SetupUIMarker(GameObject marker) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 132
	public virtual MapMarker.ClusterType get_ShouldCluster() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 133
	public virtual GameObjectRef get_GetClusterUIMarker() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 134
	public virtual float get_GetClusterRadius() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 135
	public virtual void SetupUIMarkerCluster(GameObject marker, List<MapMarker> markers) { }

	// RVA: 0x568540 Offset: 0x566B40 VA: 0x180568540
	public static void UpdateInterface() { }

	// RVA: 0x5683F0 Offset: 0x5669F0 VA: 0x1805683F0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x568290 Offset: 0x566890 VA: 0x180568290 Slot: 28
	public override void InitShared() { }

	// RVA: 0x5681F0 Offset: 0x5667F0 VA: 0x1805681F0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x568680 Offset: 0x566C80 VA: 0x180568680
	public void .ctor() { }

	// RVA: 0x568620 Offset: 0x566C20 VA: 0x180568620
	private static void .cctor() { }

}

public enum MapMarker.ClusterType // TypeDefIndex: 9596
{	// Fields
	public int value__; // 0x0
	public const MapMarker.ClusterType None = 0;
	public const MapMarker.ClusterType Vending = 1;

}

