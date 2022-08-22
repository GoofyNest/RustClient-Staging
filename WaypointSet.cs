public class WaypointSet : MonoBehaviour, IServerComponent // TypeDefIndex: 12140
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<WaypointSet.Waypoint> _points; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WaypointSet.NavModes navMode; // 0x20

	public List<WaypointSet.Waypoint> Points { get; set; }
	public WaypointSet.NavModes NavMode { get; }


	public List<WaypointSet.Waypoint> get_Points() { }

	public void set_Points(List<WaypointSet.Waypoint> value) { }

	public WaypointSet.NavModes get_NavMode() { }

	private void OnDrawGizmos() { }

	public void .ctor() { }

}

public enum WaypointSet.NavModes // TypeDefIndex: 12141
{	public int value__; // 0x0
	public const WaypointSet.NavModes Loop = 0;
	public const WaypointSet.NavModes PingPong = 1;

}

public struct WaypointSet.Waypoint // TypeDefIndex: 12142
{	public Transform Transform; // 0x0
	public float WaitTime; // 0x8
	public Transform[] LookatPoints; // 0x10
	public bool IsOccupied; // 0x18

}

