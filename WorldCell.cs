public class WorldCell // TypeDefIndex: 10081
{	// Fields
	public Vector3 Position; // 0x10
	public float Size; // 0x1C
	public bool Visible; // 0x20
	public float Timestamp; // 0x24
	private List<WorldCell.PrefabInfo> prefabs; // 0x28
	private List<GameObject> instances; // 0x30

	// Methods

	// RVA: 0x8FF440 Offset: 0x8FDA40 VA: 0x1808FF440
	public void .ctor(Vector3 position, float size) { }

	// RVA: 0x8FEF00 Offset: 0x8FD500 VA: 0x1808FEF00
	public bool NeedsRefresh() { }

	// RVA: 0x8FEF40 Offset: 0x8FD540 VA: 0x1808FEF40
	public void Refresh() { }

	// RVA: 0x8FF2A0 Offset: 0x8FD8A0 VA: 0x1808FF2A0
	private void Show() { }

	// RVA: 0x8FEDC0 Offset: 0x8FD3C0 VA: 0x1808FEDC0
	private void Hide() { }

	// RVA: 0x8FECD0 Offset: 0x8FD2D0 VA: 0x1808FECD0
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

	// RVA: 0x8E9490 Offset: 0x8E7A90 VA: 0x1808E9490
	public void .ctor(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x8E9420 Offset: 0x8E7A20 VA: 0x1808E9420
	public GameObject Spawn() { }

}

