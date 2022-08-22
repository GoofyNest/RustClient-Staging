public abstract class DeployVolume : PrefabAttribute // TypeDefIndex: 9844
{	// Fields
	public LayerMask layers; // 0x98
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public ColliderInfo.Flags ignore; // 0x9C
	public DeployVolume.EntityMode entityMode; // 0xA0
	[FormerlySerializedAsAttribute] // RVA: 0x9F5E0 Offset: 0x9E9E0 VA: 0x18009F5E0
	public BaseEntity[] entityList; // 0xA8

	// Methods

	// RVA: 0x9769D0 Offset: 0x974FD0 VA: 0x1809769D0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract bool Check(Vector3 position, Quaternion rotation, int mask = -1);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract bool Check(Vector3 position, Quaternion rotation, OBB test, int mask = -1);

	// RVA: 0x976900 Offset: 0x974F00 VA: 0x180976900
	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, int mask = -1) { }

	// RVA: 0x9767D0 Offset: 0x974DD0 VA: 0x1809767D0
	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, OBB test, int mask = -1) { }

	// RVA: 0x9766C0 Offset: 0x974CC0 VA: 0x1809766C0
	public static bool CheckSphere(Vector3 pos, float radius, int layerMask, DeployVolume volume) { }

	// RVA: 0x976250 Offset: 0x974850 VA: 0x180976250
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, DeployVolume volume) { }

	// RVA: 0x9765A0 Offset: 0x974BA0 VA: 0x1809765A0
	public static bool CheckOBB(OBB obb, int layerMask, DeployVolume volume) { }

	// RVA: 0x976150 Offset: 0x974750 VA: 0x180976150
	public static bool CheckBounds(Bounds bounds, int layerMask, DeployVolume volume) { }

	// RVA: 0x976380 Offset: 0x974980 VA: 0x180976380
	private static bool CheckFlags(List<Collider> list, DeployVolume volume) { }

	// RVA: 0x976A30 Offset: 0x975030 VA: 0x180976A30
	protected void .ctor() { }

}

public enum DeployVolume.EntityMode // TypeDefIndex: 9845
{	// Fields
	public int value__; // 0x0
	public const DeployVolume.EntityMode ExcludeList = 0;
	public const DeployVolume.EntityMode IncludeList = 1;

}

