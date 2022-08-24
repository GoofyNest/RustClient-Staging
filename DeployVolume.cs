public abstract class DeployVolume : PrefabAttribute // TypeDefIndex: 9844
{	public LayerMask layers; // 0x98
	[InspectorFlagsAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public ColliderInfo.Flags ignore; // 0x9C
	public DeployVolume.EntityMode entityMode; // 0xA0
	[FormerlySerializedAsAttribute] // RVA: 0x9F260 Offset: 0x9E660 VA: 0x18009F260
	public BaseEntity[] entityList; // 0xA8


	protected override Type GetIndexedType() { }

	protected abstract bool Check(Vector3 position, Quaternion rotation, int mask = -1);

	protected abstract bool Check(Vector3 position, Quaternion rotation, OBB test, int mask = -1);

	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, int mask = -1) { }

	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, OBB test, int mask = -1) { }

	public static bool CheckSphere(Vector3 pos, float radius, int layerMask, DeployVolume volume) { }

	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, DeployVolume volume) { }

	public static bool CheckOBB(OBB obb, int layerMask, DeployVolume volume) { }

	public static bool CheckBounds(Bounds bounds, int layerMask, DeployVolume volume) { }

	private static bool CheckFlags(List<Collider> list, DeployVolume volume) { }

	protected void .ctor() { }

}

public enum DeployVolume.EntityMode // TypeDefIndex: 9845
{	public int value__; // 0x0
	public const DeployVolume.EntityMode ExcludeList = 0;
	public const DeployVolume.EntityMode IncludeList = 1;

}

