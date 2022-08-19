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

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public GameObject get_gameObject() { }

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	public void set_gameObject(GameObject value) { }

	// RVA: 0x19E830 Offset: 0x19DC30 VA: 0x18019E830
	public bool get_isValid() { }

	// RVA: 0x19E730 Offset: 0x19DB30 VA: 0x18019E730
	public void Clear() { }

	// RVA: 0x19E820 Offset: 0x19DC20 VA: 0x18019E820 Slot: 3
	public override string ToString() { }

}

