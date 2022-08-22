public class HitboxSystem : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9268
{	// Fields
	private float rebuildTime; // 0x18
	private const float rebuildDeltaTime = 0,03333334;
	public List<HitboxSystem.HitboxShape> hitboxes; // 0x20

	// Methods

	// RVA: 0x740620 Offset: 0x73EC20 VA: 0x180740620 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x740CF0 Offset: 0x73F2F0 VA: 0x180740CF0
	public void TraceAll(HitboxCollision collision, HitTest test, List<TraceInfo> hits) { }

	// RVA: 0x740160 Offset: 0x73E760 VA: 0x180740160
	private void OnDrawGizmos() { }

	// RVA: 0x7417D0 Offset: 0x73FDD0 VA: 0x1807417D0
	public void UpdateTransforms(bool force = False) { }

	// RVA: 0x741950 Offset: 0x73FF50 VA: 0x180741950
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

	// RVA: 0x4C9420 Offset: 0x4C7A20 VA: 0x1804C9420
	public Matrix4x4 get_Transform() { }

	// RVA: 0x740050 Offset: 0x73E650 VA: 0x180740050
	public Vector3 get_Position() { }

	// RVA: 0x7400F0 Offset: 0x73E6F0 VA: 0x1807400F0
	public Quaternion get_Rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x740120 Offset: 0x73E720 VA: 0x180740120
	public Vector3 get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x740140 Offset: 0x73E740 VA: 0x180740140
	private void set_Size(Vector3 value) { }

	// RVA: 0x73FCB0 Offset: 0x73E2B0 VA: 0x18073FCB0
	public void UpdateTransform() { }

	// RVA: 0x73FC60 Offset: 0x73E260 VA: 0x18073FC60
	public Vector3 TransformPoint(Vector3 pt) { }

	// RVA: 0x73F7A0 Offset: 0x73DDA0 VA: 0x18073F7A0
	public Vector3 InverseTransformPoint(Vector3 pt) { }

	// RVA: 0x73FC10 Offset: 0x73E210 VA: 0x18073FC10
	public Vector3 TransformDirection(Vector3 pt) { }

	// RVA: 0x73F750 Offset: 0x73DD50 VA: 0x18073F750
	public Vector3 InverseTransformDirection(Vector3 pt) { }

	// RVA: 0x73F7F0 Offset: 0x73DDF0 VA: 0x18073F7F0
	public bool Trace(Ray ray, out RaycastHit hit, float forgivness = 0, float maxDistance = ∞) { }

	// RVA: 0x73F550 Offset: 0x73DB50 VA: 0x18073F550
	public Bounds GetBounds() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class HitboxSystem.<>c // TypeDefIndex: 9270
{	// Fields
	public static readonly HitboxSystem.<>c <>9; // 0x0
	public static Func<HitboxDefinition, int> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x749430 Offset: 0x747A30 VA: 0x180749430
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x749300 Offset: 0x747900 VA: 0x180749300
	internal int <PreProcess>b__4_0(HitboxDefinition x) { }

}

