public abstract class DeployVolume : PrefabAttribute // TypeDefIndex: 9844
{	// Fields
	public LayerMask layers; // 0x98
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public ColliderInfo.Flags ignore; // 0x9C
	public DeployVolume.EntityMode entityMode; // 0xA0
	[FormerlySerializedAsAttribute] // RVA: 0x9F5E0 Offset: 0x9E9E0 VA: 0x18009F5E0
	public BaseEntity[] entityList; // 0xA8

	// Methods

	// RVA: 0x9763C0 Offset: 0x9749C0 VA: 0x1809763C0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract bool Check(Vector3 position, Quaternion rotation, int mask = -1);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract bool Check(Vector3 position, Quaternion rotation, OBB test, int mask = -1);

	// RVA: 0x9762F0 Offset: 0x9748F0 VA: 0x1809762F0
	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, int mask = -1) { }

	// RVA: 0x9761C0 Offset: 0x9747C0 VA: 0x1809761C0
	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, OBB test, int mask = -1) { }

	// RVA: 0x9760B0 Offset: 0x9746B0 VA: 0x1809760B0
	public static bool CheckSphere(Vector3 pos, float radius, int layerMask, DeployVolume volume) { }

	// RVA: 0x975C40 Offset: 0x974240 VA: 0x180975C40
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, DeployVolume volume) { }

	// RVA: 0x975F90 Offset: 0x974590 VA: 0x180975F90
	public static bool CheckOBB(OBB obb, int layerMask, DeployVolume volume) { }

	// RVA: 0x975B40 Offset: 0x974140 VA: 0x180975B40
	public static bool CheckBounds(Bounds bounds, int layerMask, DeployVolume volume) { }

	// RVA: 0x975D70 Offset: 0x974370 VA: 0x180975D70
	private static bool CheckFlags(List<Collider> list, DeployVolume volume) { }

	// RVA: 0x976420 Offset: 0x974A20 VA: 0x180976420
	protected void .ctor() { }

}

public enum DeployVolume.EntityMode // TypeDefIndex: 9845
{	// Fields
	public int value__; // 0x0
	public const DeployVolume.EntityMode ExcludeList = 0;
	public const DeployVolume.EntityMode IncludeList = 1;

}

