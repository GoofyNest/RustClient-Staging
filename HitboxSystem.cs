public class HitboxSystem : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9268
{	// Fields
	private float rebuildTime; // 0x18
	private const float rebuildDeltaTime = 0,03333334;
	public List<HitboxSystem.HitboxShape> hitboxes; // 0x20

	// Methods

	// RVA: 0x740570 Offset: 0x73EB70 VA: 0x180740570 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x740C40 Offset: 0x73F240 VA: 0x180740C40
	public void TraceAll(HitboxCollision collision, HitTest test, List<TraceInfo> hits) { }

	// RVA: 0x7400B0 Offset: 0x73E6B0 VA: 0x1807400B0
	private void OnDrawGizmos() { }

	// RVA: 0x741720 Offset: 0x73FD20 VA: 0x180741720
	public void UpdateTransforms(bool force = False) { }

	// RVA: 0x7418A0 Offset: 0x73FEA0 VA: 0x1807418A0
	public void .ctor() { }

}

public class HitboxSystem.HitboxShape // TypeDefIndex: 9269
{	// Fields
	public Transform bone; // 0x10
	public HitboxDefinition.Type type; // 0x18
	public Matrix4x4 localTransform; // 0x1C
	public PhysicMaterial colliderMaterial; // 0x60
	private Matrix4x4 transform; // 0x68
	private Matrix4x4 inverseTransform; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <Size>k__BackingField; // 0xE8

	// Properties
	public Matrix4x4 Transform { get; }
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Vector3 Size { get; set; }

	// Methods

	// RVA: 0x4C93B0 Offset: 0x4C79B0 VA: 0x1804C93B0
	public Matrix4x4 get_Transform() { }

	// RVA: 0x73FFA0 Offset: 0x73E5A0 VA: 0x18073FFA0
	public Vector3 get_Position() { }

	// RVA: 0x740040 Offset: 0x73E640 VA: 0x180740040
	public Quaternion get_Rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x740070 Offset: 0x73E670 VA: 0x180740070
	public Vector3 get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x740090 Offset: 0x73E690 VA: 0x180740090
	private void set_Size(Vector3 value) { }

	// RVA: 0x73FC00 Offset: 0x73E200 VA: 0x18073FC00
	public void UpdateTransform() { }

	// RVA: 0x73FBB0 Offset: 0x73E1B0 VA: 0x18073FBB0
	public Vector3 TransformPoint(Vector3 pt) { }

	// RVA: 0x73F6F0 Offset: 0x73DCF0 VA: 0x18073F6F0
	public Vector3 InverseTransformPoint(Vector3 pt) { }

	// RVA: 0x73FB60 Offset: 0x73E160 VA: 0x18073FB60
	public Vector3 TransformDirection(Vector3 pt) { }

	// RVA: 0x73F6A0 Offset: 0x73DCA0 VA: 0x18073F6A0
	public Vector3 InverseTransformDirection(Vector3 pt) { }

	// RVA: 0x73F740 Offset: 0x73DD40 VA: 0x18073F740
	public bool Trace(Ray ray, out RaycastHit hit, float forgivness = 0, float maxDistance = ∞) { }

	// RVA: 0x73F4A0 Offset: 0x73DAA0 VA: 0x18073F4A0
	public Bounds GetBounds() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class HitboxSystem.<>c // TypeDefIndex: 9270
{	// Fields
	public static readonly HitboxSystem.<>c <>9; // 0x0
	public static Func<HitboxDefinition, int> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x749380 Offset: 0x747980 VA: 0x180749380
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x749250 Offset: 0x747850 VA: 0x180749250
	internal int <PreProcess>b__4_0(HitboxDefinition x) { }

}

