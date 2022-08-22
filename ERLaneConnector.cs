public class ERLaneConnector // TypeDefIndex: 7243
{	// Fields
	public Vector3 connectorStart; // 0x10
	public Vector3 connectorEnd; // 0x1C
	public Vector3 connectorStartLocal; // 0x28
	public Vector3 connectorEndLocal; // 0x34
	public Vector3[] points; // 0x40
	public int startLaneIndex; // 0x48
	public int endLaneIndex; // 0x4C
	public int endConnectionIndex; // 0x50
	public ERLane laneType; // 0x54
	public ERDirectionType laneDirection; // 0x64
	public float startOffset; // 0x68
	public float endOffset; // 0x6C
	public float strength; // 0x70
	public bool mainConnection; // 0x74
	public bool stop; // 0x75
	public float speedLimit; // 0x78
	public float minSpeed; // 0x7C
	public float maxSpeed; // 0x80

	// Methods

	// RVA: 0x9BAA00 Offset: 0x9B9000 VA: 0x1809BAA00
	public static ERLaneConnector CreateInstance() { }

	// RVA: 0x9BAA70 Offset: 0x9B9070 VA: 0x1809BAA70
	public static List<ERLaneConnector> GetLaneConnectors(ERLaneData laneData, int index) { }

	// RVA: 0x9BAB60 Offset: 0x9B9160 VA: 0x1809BAB60
	public void .ctor() { }

}

