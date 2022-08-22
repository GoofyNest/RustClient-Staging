public class WorldCell // TypeDefIndex: 10081
{	// Fields
	public Vector3 Position; // 0x10
	public float Size; // 0x1C
	public bool Visible; // 0x20
	public float Timestamp; // 0x24
	private List<WorldCell.PrefabInfo> prefabs; // 0x28
	private List<GameObject> instances; // 0x30

	// Methods

	// RVA: 0x8FF950 Offset: 0x8FDF50 VA: 0x1808FF950
	public void .ctor(Vector3 position, float size) { }

	// RVA: 0x8FF410 Offset: 0x8FDA10 VA: 0x1808FF410
	public bool NeedsRefresh() { }

	// RVA: 0x8FF450 Offset: 0x8FDA50 VA: 0x1808FF450
	public void Refresh() { }

	// RVA: 0x8FF7B0 Offset: 0x8FDDB0 VA: 0x1808FF7B0
	private void Show() { }

	// RVA: 0x8FF2D0 Offset: 0x8FD8D0 VA: 0x1808FF2D0
	private void Hide() { }

	// RVA: 0x8FF1E0 Offset: 0x8FD7E0 VA: 0x1808FF1E0
	public WorldCell.PrefabInfo Add(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x682990 Offset: 0x680F90 VA: 0x180682990
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

	// RVA: 0x8E99A0 Offset: 0x8E7FA0 VA: 0x1808E99A0
	public void .ctor(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x8E9930 Offset: 0x8E7F30 VA: 0x1808E9930
	public GameObject Spawn() { }

}

