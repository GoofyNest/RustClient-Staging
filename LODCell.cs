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

	// RVA: 0x682940 Offset: 0x680F40 VA: 0x180682940
	public int get_Count() { }

	// RVA: 0x6827D0 Offset: 0x680DD0 VA: 0x1806827D0
	public void Initialize(Vector3 position, float size) { }

	// RVA: 0x6827F0 Offset: 0x680DF0 VA: 0x1806827F0
	public bool NeedsRefresh() { }

	// RVA: 0x6822E0 Offset: 0x6808E0 VA: 0x1806822E0
	public void ChangeLOD(bool force = False) { }

	// RVA: 0x682270 Offset: 0x680870 VA: 0x180682270
	public void Add(ILOD component, Transform transform) { }

	// RVA: 0x682830 Offset: 0x680E30 VA: 0x180682830
	public void Remove(ILOD component, Transform transform) { }

	// RVA: 0x682760 Offset: 0x680D60 VA: 0x180682760
	public float GetDistance(Transform transform, LODDistanceMode mode = 0) { }

	// RVA: 0x682710 Offset: 0x680D10 VA: 0x180682710
	public float GetDistance(Vector3 worldPos, LODDistanceMode mode = 0) { }

	// RVA: 0x682990 Offset: 0x680F90 VA: 0x180682990
	public static bool op_Implicit(LODCell cell) { }

	// RVA: 0x682680 Offset: 0x680C80 VA: 0x180682680 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x6828D0 Offset: 0x680ED0 VA: 0x1806828D0
	public void .ctor() { }

}

