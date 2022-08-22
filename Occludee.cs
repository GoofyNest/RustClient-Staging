public class Occludee : MonoBehaviour // TypeDefIndex: 11511
{	// Fields
	public float minTimeVisible; // 0x18
	public bool isStatic; // 0x1C
	public bool autoRegister; // 0x1D
	public bool stickyGizmos; // 0x1E
	public OccludeeState state; // 0x20
	protected int occludeeId; // 0x28
	protected Vector3 center; // 0x2C
	protected float radius; // 0x38
	protected Renderer renderer; // 0x40
	protected Collider collider; // 0x48

	// Methods

	// RVA: 0x9D7F90 Offset: 0x9D6590 VA: 0x1809D7F90 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x9D8130 Offset: 0x9D6730 VA: 0x1809D8130
	public void OnEnable() { }

	// RVA: 0x9D8000 Offset: 0x9D6600 VA: 0x1809D8000
	public void OnDisable() { }

	// RVA: 0x9D8240 Offset: 0x9D6840 VA: 0x1809D8240
	public void Register() { }

	// RVA: 0x9D86E0 Offset: 0x9D6CE0 VA: 0x1809D86E0
	public void Unregister() { }

	// RVA: 0x9D81B0 Offset: 0x9D67B0 VA: 0x1809D81B0 Slot: 5
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x9D8800 Offset: 0x9D6E00 VA: 0x1809D8800
	public void .ctor() { }

}

