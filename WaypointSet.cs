public class WaypointSet : MonoBehaviour, IServerComponent // TypeDefIndex: 12144
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private List<WaypointSet.Waypoint> _points; // 0x18
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private WaypointSet.NavModes navMode; // 0x20

	public List<WaypointSet.Waypoint> Points { get; set; }
	public WaypointSet.NavModes NavMode { get; }


	public List<WaypointSet.Waypoint> get_Points() { }

	public void set_Points(List<WaypointSet.Waypoint> value) { }

	public WaypointSet.NavModes get_NavMode() { }

	private void OnDrawGizmos() { }

	public void .ctor() { }

}

public enum WaypointSet.NavModes // TypeDefIndex: 12145
{	public int value__; // 0x0
	public const WaypointSet.NavModes Loop = 0;
	public const WaypointSet.NavModes PingPong = 1;

}

public struct WaypointSet.Waypoint // TypeDefIndex: 12146
{	public Transform Transform; // 0x0
	public float WaitTime; // 0x8
	public Transform[] LookatPoints; // 0x10
	public bool IsOccupied; // 0x18

}

