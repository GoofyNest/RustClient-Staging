public class LODCell : Pool.IPooled // TypeDefIndex: 9929
{	// Fields
	public Vector3 Position; // 0x10
	public float Size; // 0x1C
	public float Distance; // 0x20
	public float DistanceY; // 0x24
	public float Timestamp; // 0x28
	public EnvironmentType Environment; // 0x2C
	private ListHashSet<ILOD> members; // 0x30

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x6829B0 Offset: 0x680FB0 VA: 0x1806829B0
	public int get_Count() { }

	// RVA: 0x682840 Offset: 0x680E40 VA: 0x180682840
	public void Initialize(Vector3 position, float size) { }

	// RVA: 0x682860 Offset: 0x680E60 VA: 0x180682860
	public bool NeedsRefresh() { }

	// RVA: 0x682350 Offset: 0x680950 VA: 0x180682350
	public void ChangeLOD(bool force = False) { }

	// RVA: 0x6822E0 Offset: 0x6808E0 VA: 0x1806822E0
	public void Add(ILOD component, Transform transform) { }

	// RVA: 0x6828A0 Offset: 0x680EA0 VA: 0x1806828A0
	public void Remove(ILOD component, Transform transform) { }

	// RVA: 0x6827D0 Offset: 0x680DD0 VA: 0x1806827D0
	public float GetDistance(Transform transform, LODDistanceMode mode = 0) { }

	// RVA: 0x682780 Offset: 0x680D80 VA: 0x180682780
	public float GetDistance(Vector3 worldPos, LODDistanceMode mode = 0) { }

	// RVA: 0x682A00 Offset: 0x681000 VA: 0x180682A00
	public static bool op_Implicit(LODCell cell) { }

	// RVA: 0x6826F0 Offset: 0x680CF0 VA: 0x1806826F0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x682940 Offset: 0x680F40 VA: 0x180682940
	public void .ctor() { }

}

