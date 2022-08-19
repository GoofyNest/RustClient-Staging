public class HitboxDefinition : MonoBehaviour // TypeDefIndex: 9266
{	// Fields
	public Vector3 center; // 0x18
	public Vector3 rotation; // 0x24
	public HitboxDefinition.Type type; // 0x30
	public int priority; // 0x34
	public PhysicMaterial physicMaterial; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 scale; // 0x40

	// Properties
	public Vector3 Scale { get; set; }
	public Matrix4x4 LocalMatrix { get; }

	// Methods

	// RVA: 0x73F360 Offset: 0x73D960 VA: 0x18073F360
	public Vector3 get_Scale() { }

	// RVA: 0x73F380 Offset: 0x73D980 VA: 0x18073F380
	public void set_Scale(Vector3 value) { }

	// RVA: 0x73F220 Offset: 0x73D820 VA: 0x18073F220
	public Matrix4x4 get_LocalMatrix() { }

	// RVA: 0x73F100 Offset: 0x73D700 VA: 0x18073F100
	private void OnValidate() { }

	// RVA: 0x73E450 Offset: 0x73CA50 VA: 0x18073E450 Slot: 4
	protected virtual void OnDrawGizmosSelected() { }

	// RVA: 0x73EA70 Offset: 0x73D070 VA: 0x18073EA70 Slot: 5
	protected virtual void OnDrawGizmos() { }

	// RVA: 0x73F1B0 Offset: 0x73D7B0 VA: 0x18073F1B0
	public void .ctor() { }

}

public enum HitboxDefinition.Type // TypeDefIndex: 9267
{	// Fields
	public int value__; // 0x0
	public const HitboxDefinition.Type BOX = 0;
	public const HitboxDefinition.Type CAPSULE = 1;

}

