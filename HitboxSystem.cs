public class HitboxSystem : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9268
{	// Fields
	private float rebuildTime; // 0x18
	private const float rebuildDeltaTime = 0,03333334;
	public List<HitboxSystem.HitboxShape> hitboxes; // 0x20

	// Methods

	// RVA: 0x740510 Offset: 0x73EB10 VA: 0x180740510 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x740BE0 Offset: 0x73F1E0 VA: 0x180740BE0
	public void TraceAll(HitboxCollision collision, HitTest test, List<TraceInfo> hits) { }

	// RVA: 0x740050 Offset: 0x73E650 VA: 0x180740050
	private void OnDrawGizmos() { }

	// RVA: 0x7416C0 Offset: 0x73FCC0 VA: 0x1807416C0
	public void UpdateTransforms(bool force = False) { }

	// RVA: 0x741840 Offset: 0x73FE40 VA: 0x180741840
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

	// RVA: 0x73FF40 Offset: 0x73E540 VA: 0x18073FF40
	public Vector3 get_Position() { }

	// RVA: 0x73FFE0 Offset: 0x73E5E0 VA: 0x18073FFE0
	public Quaternion get_Rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x740010 Offset: 0x73E610 VA: 0x180740010
	public Vector3 get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x740030 Offset: 0x73E630 VA: 0x180740030
	private void set_Size(Vector3 value) { }

	// RVA: 0x73FBA0 Offset: 0x73E1A0 VA: 0x18073FBA0
	public void UpdateTransform() { }

	// RVA: 0x73FB50 Offset: 0x73E150 VA: 0x18073FB50
	public Vector3 TransformPoint(Vector3 pt) { }

	// RVA: 0x73F690 Offset: 0x73DC90 VA: 0x18073F690
	public Vector3 InverseTransformPoint(Vector3 pt) { }

	// RVA: 0x73FB00 Offset: 0x73E100 VA: 0x18073FB00
	public Vector3 TransformDirection(Vector3 pt) { }

	// RVA: 0x73F640 Offset: 0x73DC40 VA: 0x18073F640
	public Vector3 InverseTransformDirection(Vector3 pt) { }

	// RVA: 0x73F6E0 Offset: 0x73DCE0 VA: 0x18073F6E0
	public bool Trace(Ray ray, out RaycastHit hit, float forgivness = 0, float maxDistance = ∞) { }

	// RVA: 0x73F440 Offset: 0x73DA40 VA: 0x18073F440
	public Bounds GetBounds() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class HitboxSystem.<>c // TypeDefIndex: 9270
{	// Fields
	public static readonly HitboxSystem.<>c <>9; // 0x0
	public static Func<HitboxDefinition, int> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x749320 Offset: 0x747920 VA: 0x180749320
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7491F0 Offset: 0x7477F0 VA: 0x1807491F0
	internal int <PreProcess>b__4_0(HitboxDefinition x) { }

}

