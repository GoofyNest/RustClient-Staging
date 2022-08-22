public class WaypointSet : MonoBehaviour, IServerComponent // TypeDefIndex: 12140
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<WaypointSet.Waypoint> _points; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WaypointSet.NavModes navMode; // 0x20

	// Properties
	public List<WaypointSet.Waypoint> Points { get; set; }
	public WaypointSet.NavModes NavMode { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public List<WaypointSet.Waypoint> get_Points() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Points(List<WaypointSet.Waypoint> value) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public WaypointSet.NavModes get_NavMode() { }

	// RVA: 0x4D3200 Offset: 0x4D1800 VA: 0x1804D3200
	private void OnDrawGizmos() { }

	// RVA: 0x4D36F0 Offset: 0x4D1CF0 VA: 0x1804D36F0
	public void .ctor() { }

}

public enum WaypointSet.NavModes // TypeDefIndex: 12141
{	// Fields
	public int value__; // 0x0
	public const WaypointSet.NavModes Loop = 0;
	public const WaypointSet.NavModes PingPong = 1;

}

public struct WaypointSet.Waypoint // TypeDefIndex: 12142
{	// Fields
	public Transform Transform; // 0x0
	public float WaitTime; // 0x8
	public Transform[] LookatPoints; // 0x10
	public bool IsOccupied; // 0x18

}

