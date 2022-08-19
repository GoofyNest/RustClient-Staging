public class WorldCell // TypeDefIndex: 10081
{	// Fields
	public Vector3 Position; // 0x10
	public float Size; // 0x1C
	public bool Visible; // 0x20
	public float Timestamp; // 0x24
	private List<WorldCell.PrefabInfo> prefabs; // 0x28
	private List<GameObject> instances; // 0x30

	// Methods

	// RVA: 0x8FF330 Offset: 0x8FD930 VA: 0x1808FF330
	public void .ctor(Vector3 position, float size) { }

	// RVA: 0x8FEDF0 Offset: 0x8FD3F0 VA: 0x1808FEDF0
	public bool NeedsRefresh() { }

	// RVA: 0x8FEE30 Offset: 0x8FD430 VA: 0x1808FEE30
	public void Refresh() { }

	// RVA: 0x8FF190 Offset: 0x8FD790 VA: 0x1808FF190
	private void Show() { }

	// RVA: 0x8FECB0 Offset: 0x8FD2B0 VA: 0x1808FECB0
	private void Hide() { }

	// RVA: 0x8FEBC0 Offset: 0x8FD1C0 VA: 0x1808FEBC0
	public WorldCell.PrefabInfo Add(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x682A00 Offset: 0x681000 VA: 0x180682A00
	public static bool op_Implicit(WorldCell cell) { }

}

public class WorldCell.PrefabInfo // TypeDefIndex: 10082
{	// Fields
	public string category; // 0x10
	public Prefab prefab; // 0x18
	public Vector3 position; // 0x20
	public Quaternion rotation; // 0x2C
	public Vector3 scale; // 0x3C

	// Methods

	// RVA: 0x8E9380 Offset: 0x8E7980 VA: 0x1808E9380
	public void .ctor(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x8E9310 Offset: 0x8E7910 VA: 0x1808E9310
	public GameObject Spawn() { }

}

