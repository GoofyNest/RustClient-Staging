public class HitboxDefinition : MonoBehaviour // TypeDefIndex: 9266
{	// Fields
	public Vector3 center; // 0x18
	public Vector3 rotation; // 0x24
	public HitboxDefinition.Type type; // 0x30
	public int priority; // 0x34
	public PhysicMaterial physicMaterial; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 scale; // 0x40

	// Properties
	public Vector3 Scale { get; set; }
	public Matrix4x4 LocalMatrix { get; }

	// Methods

	// RVA: 0x73F3C0 Offset: 0x73D9C0 VA: 0x18073F3C0
	public Vector3 get_Scale() { }

	// RVA: 0x73F3E0 Offset: 0x73D9E0 VA: 0x18073F3E0
	public void set_Scale(Vector3 value) { }

	// RVA: 0x73F280 Offset: 0x73D880 VA: 0x18073F280
	public Matrix4x4 get_LocalMatrix() { }

	// RVA: 0x73F160 Offset: 0x73D760 VA: 0x18073F160
	private void OnValidate() { }

	// RVA: 0x73E4B0 Offset: 0x73CAB0 VA: 0x18073E4B0 Slot: 4
	protected virtual void OnDrawGizmosSelected() { }

	// RVA: 0x73EAD0 Offset: 0x73D0D0 VA: 0x18073EAD0 Slot: 5
	protected virtual void OnDrawGizmos() { }

	// RVA: 0x73F210 Offset: 0x73D810 VA: 0x18073F210
	public void .ctor() { }

}

public enum HitboxDefinition.Type // TypeDefIndex: 9267
{	// Fields
	public int value__; // 0x0
	public const HitboxDefinition.Type BOX = 0;
	public const HitboxDefinition.Type CAPSULE = 1;

}

