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

	// RVA: 0x9D8480 Offset: 0x9D6A80 VA: 0x1809D8480 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x9D8620 Offset: 0x9D6C20 VA: 0x1809D8620
	public void OnEnable() { }

	// RVA: 0x9D84F0 Offset: 0x9D6AF0 VA: 0x1809D84F0
	public void OnDisable() { }

	// RVA: 0x9D8730 Offset: 0x9D6D30 VA: 0x1809D8730
	public void Register() { }

	// RVA: 0x9D8BD0 Offset: 0x9D71D0 VA: 0x1809D8BD0
	public void Unregister() { }

	// RVA: 0x9D86A0 Offset: 0x9D6CA0 VA: 0x1809D86A0 Slot: 5
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x9D8CF0 Offset: 0x9D72F0 VA: 0x1809D8CF0
	public void .ctor() { }

}

