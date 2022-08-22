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

	// RVA: 0x73F470 Offset: 0x73DA70 VA: 0x18073F470
	public Vector3 get_Scale() { }

	// RVA: 0x73F490 Offset: 0x73DA90 VA: 0x18073F490
	public void set_Scale(Vector3 value) { }

	// RVA: 0x73F330 Offset: 0x73D930 VA: 0x18073F330
	public Matrix4x4 get_LocalMatrix() { }

	// RVA: 0x73F210 Offset: 0x73D810 VA: 0x18073F210
	private void OnValidate() { }

	// RVA: 0x73E560 Offset: 0x73CB60 VA: 0x18073E560 Slot: 4
	protected virtual void OnDrawGizmosSelected() { }

	// RVA: 0x73EB80 Offset: 0x73D180 VA: 0x18073EB80 Slot: 5
	protected virtual void OnDrawGizmos() { }

	// RVA: 0x73F2C0 Offset: 0x73D8C0 VA: 0x18073F2C0
	public void .ctor() { }

}

public enum HitboxDefinition.Type // TypeDefIndex: 9267
{	// Fields
	public int value__; // 0x0
	public const HitboxDefinition.Type BOX = 0;
	public const HitboxDefinition.Type CAPSULE = 1;

}

