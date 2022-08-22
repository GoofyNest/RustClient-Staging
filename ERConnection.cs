public class ERConnection // TypeDefIndex: 7257
{	// Fields
	public string name; // 0x10
	public ERCrossingPrefabs prefabScript; // 0x18
	public GameObject gameObject; // 0x20
	public ERConnectionData[] connectionData; // 0x28
	public static string str; // 0x0

	// Methods

	// RVA: 0xB80FC0 Offset: 0xB7F5C0 VA: 0x180B80FC0
	public void .ctor(GameObject go, string g_name) { }

	// RVA: 0xB7E6F0 Offset: 0xB7CCF0 VA: 0x180B7E6F0
	public static ERConnection Create(GameObject go) { }

	// RVA: 0xB805F0 Offset: 0xB7EBF0 VA: 0x180B805F0
	public void SetPosition(Vector3 pos) { }

	// RVA: 0xB7FD50 Offset: 0xB7E350 VA: 0x180B7FD50
	public string GetName() { }

	// RVA: 0xB80560 Offset: 0xB7EB60 VA: 0x180B80560
	public void SetName(string name) { }

	// RVA: 0xB808B0 Offset: 0xB7EEB0 VA: 0x180B808B0
	public void SetRotation(Vector3 euler) { }

	// RVA: 0xB7E810 Offset: 0xB7CE10 VA: 0x180B7E810
	public void Destroy() { }

	// RVA: 0xB80DE0 Offset: 0xB7F3E0 VA: 0x180B80DE0
	public void UnConnect(int connectionIndex) { }

	// RVA: 0xB7EE60 Offset: 0xB7D460 VA: 0x180B7EE60
	public ERConnectionData[] GetConnectionData() { }

	// RVA: 0xB7F900 Offset: 0xB7DF00 VA: 0x180B7F900
	public Vector3 GetLocalConnectionPosition(int connectionIndex) { }

	// RVA: 0xB7FB00 Offset: 0xB7E100 VA: 0x180B7FB00
	public Vector3[] GetLocalConnectionPositions() { }

	// RVA: 0xB7F270 Offset: 0xB7D870 VA: 0x180B7F270
	public Vector3[] GetConnectionWorldPositions() { }

	// RVA: 0xB7F130 Offset: 0xB7D730 VA: 0x180B7F130
	public Vector3 GetConnectionWorldPosition(int connectionIndex) { }

	// RVA: 0xB7E900 Offset: 0xB7CF00 VA: 0x180B7E900
	public int FindNearestConnectionIndex(Vector3 position) { }

	// RVA: 0xB80B70 Offset: 0xB7F170 VA: 0x180B80B70
	public bool SwapTurn() { }

	// RVA: 0xB80440 Offset: 0xB7EA40 VA: 0x180B80440
	public bool RotateConnections() { }

	// RVA: 0xB7EA40 Offset: 0xB7D040 VA: 0x180B7EA40
	public ERRoad GetConnectedRoad(int index, out ConnectedTo connectedTo) { }

	// RVA: 0xB7F4B0 Offset: 0xB7DAB0 VA: 0x180B7F4B0
	public ERLaneConnector[] GetLaneData(int connectionIndex) { }

	// RVA: 0xB7F5A0 Offset: 0xB7DBA0 VA: 0x180B7F5A0
	public ERLaneConnector[] GetLaneData(int connectionIndex, int lane) { }

	// RVA: 0xB7EE10 Offset: 0xB7D410 VA: 0x180B7EE10
	public int GetConnectionCount() { }

	// RVA: 0xB7E6D0 Offset: 0xB7CCD0 VA: 0x180B7E6D0
	public void AverageNormals(bool flag) { }

	// RVA: 0xB7FFA0 Offset: 0xB7E5A0 VA: 0x180B7FFA0
	public bool RecalculateNormals() { }

	// RVA: 0xB800A0 Offset: 0xB7E6A0 VA: 0x180B800A0
	public bool RecalculateTangents() { }

	// RVA: 0xB801A0 Offset: 0xB7E7A0 VA: 0x180B801A0
	public void Refresh() { }

	// RVA: 0xB7FDE0 Offset: 0xB7E3E0 VA: 0x180B7FDE0
	public bool IsFlexConnector() { }

	// RVA: 0xB80F80 Offset: 0xB7F580 VA: 0x180B80F80
	private static void .cctor() { }

}

