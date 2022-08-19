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

	// RVA: 0x9D7CD0 Offset: 0x9D62D0 VA: 0x1809D7CD0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x9D7E70 Offset: 0x9D6470 VA: 0x1809D7E70
	public void OnEnable() { }

	// RVA: 0x9D7D40 Offset: 0x9D6340 VA: 0x1809D7D40
	public void OnDisable() { }

	// RVA: 0x9D7F80 Offset: 0x9D6580 VA: 0x1809D7F80
	public void Register() { }

	// RVA: 0x9D8420 Offset: 0x9D6A20 VA: 0x1809D8420
	public void Unregister() { }

	// RVA: 0x9D7EF0 Offset: 0x9D64F0 VA: 0x1809D7EF0 Slot: 5
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x9D8540 Offset: 0x9D6B40 VA: 0x1809D8540
	public void .ctor() { }

}

