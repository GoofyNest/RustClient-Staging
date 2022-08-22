public struct RaycastResult // TypeDefIndex: 5089
{	// Fields
	private GameObject m_GameObject; // 0x0
	public BaseRaycaster module; // 0x8
	public float distance; // 0x10
	public float index; // 0x14
	public int depth; // 0x18
	public int sortingLayer; // 0x1C
	public int sortingOrder; // 0x20
	public Vector3 worldPosition; // 0x24
	public Vector3 worldNormal; // 0x30
	public Vector2 screenPosition; // 0x3C

	// Properties
	public GameObject gameObject { get; set; }
	public bool isValid { get; }

	// Methods

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public GameObject get_gameObject() { }

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	public void set_gameObject(GameObject value) { }

	// RVA: 0x19E7B0 Offset: 0x19DBB0 VA: 0x18019E7B0
	public bool get_isValid() { }

	// RVA: 0x19E6B0 Offset: 0x19DAB0 VA: 0x18019E6B0
	public void Clear() { }

	// RVA: 0x19E7A0 Offset: 0x19DBA0 VA: 0x18019E7A0 Slot: 3
	public override string ToString() { }

}

