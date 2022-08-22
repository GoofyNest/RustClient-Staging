public sealed class NavMeshPath // TypeDefIndex: 4444
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 // TypeDefIndex: 4438

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 // TypeDefIndex: 4439

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 4440

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 // TypeDefIndex: 4441

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 // TypeDefIndex: 4442

// Namespace: 
internal class <Module> // TypeDefIndex: 4443

// Namespace: UnityEngine.AI
[NativeHeaderAttribute] // RVA: 0xB3720 Offset: 0xB2B20 VA: 0x1800B3720
[MovedFromAttribute] // RVA: 0xB3720 Offset: 0xB2B20 VA: 0x1800B3720
public sealed class NavMeshPath // TypeDefIndex: 4444
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal Vector3[] m_Corners; // 0x18

}

public static class NavMeshBuilder // TypeDefIndex: 4445
{	// Methods

	// RVA: 0x22FCD00 Offset: 0x22FB300 VA: 0x1822FCD00
	public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	// RVA: 0x22FCF50 Offset: 0x22FB550 VA: 0x1822FCF50
	public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	// RVA: 0x22FCC80 Offset: 0x22FB280 VA: 0x1822FCC80
	private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	// RVA: 0x22FCA00 Offset: 0x22FB000 VA: 0x1822FCA00
	public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation) { }

	// RVA: 0x22FD380 Offset: 0x22FB980 VA: 0x1822FD380
	private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x22FD1B0 Offset: 0x22FB7B0 VA: 0x1822FD1B0
	public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds) { }

	// RVA: 0x22FD140 Offset: 0x22FB740 VA: 0x1822FD140
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x22FCC10 Offset: 0x22FB210 VA: 0x1822FCC10
	private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	// RVA: 0x22FD310 Offset: 0x22FB910 VA: 0x1822FD310
	private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

	// RVA: 0x22FD0D0 Offset: 0x22FB6D0 VA: 0x1822FD0D0
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

}

public sealed class NavMeshAgent : Behaviour // TypeDefIndex: 4446
{	// Properties
	public bool isOnOffMeshLink { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xB3DA0 Offset: 0xB31A0 VA: 0x1800B3DA0
	// RVA: 0x22FC6C0 Offset: 0x22FACC0 VA: 0x1822FC6C0
	public bool get_isOnOffMeshLink() { }

}

public struct NavMeshHit // TypeDefIndex: 4448
{
// Namespace: UnityEngine.AI
[MovedFromAttribute] // RVA: 0xB3F20 Offset: 0xB3320 VA: 0x1800B3F20
public struct NavMeshHit // TypeDefIndex: 4448
	// Fields
	private Vector3 m_Position; // 0x0
	private Vector3 m_Normal; // 0xC
	private float m_Distance; // 0x18
	private int m_Mask; // 0x1C
	private int m_Hit; // 0x20

	// Properties
	public Vector3 position { get; }
	public Vector3 normal { get; }

	// Methods

	// RVA: 0x211FC0 Offset: 0x2113C0 VA: 0x180211FC0
	public Vector3 get_position() { }

	// RVA: 0x211FE0 Offset: 0x2113E0 VA: 0x180211FE0
	public Vector3 get_normal() { }

}

public sealed class NavMeshData : Object // TypeDefIndex: 4449
{	// Properties
	public Vector3 position { set; }
	public Quaternion rotation { set; }

	// Methods

	// RVA: 0x22FD5A0 Offset: 0x22FBBA0 VA: 0x1822FD5A0
	public void .ctor(int agentTypeID) { }

	[StaticAccessorAttribute] // RVA: 0xB4070 Offset: 0xB3470 VA: 0x1800B4070
	// RVA: 0x22FD560 Offset: 0x22FBB60 VA: 0x1822FD560
	private static void Internal_Create(NavMeshData mono, int agentTypeID) { }

	// RVA: 0x22FD680 Offset: 0x22FBC80 VA: 0x1822FD680
	public void set_position(Vector3 value) { }

	// RVA: 0x22FD720 Offset: 0x22FBD20 VA: 0x1822FD720
	public void set_rotation(Quaternion value) { }

	// RVA: 0x22FD630 Offset: 0x22FBC30 VA: 0x1822FD630
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x22FD6D0 Offset: 0x22FBCD0 VA: 0x1822FD6D0
	private void set_rotation_Injected(ref Quaternion value) { }

}

public struct NavMeshDataInstance // TypeDefIndex: 4450
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private int <id>k__BackingField; // 0x0

	// Properties
	public bool valid { get; }
	internal int id { get; set; }
	public Object owner { set; }

	// Methods

	// RVA: 0x23EF90 Offset: 0x23E390 VA: 0x18023EF90
	public bool get_valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	internal int get_id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	internal void set_id(int value) { }

	// RVA: 0x23EF50 Offset: 0x23E350 VA: 0x18023EF50
	public void Remove() { }

	// RVA: 0x23EFE0 Offset: 0x23E3E0 VA: 0x18023EFE0
	public void set_owner(Object value) { }

}

public struct NavMeshLinkData // TypeDefIndex: 4451
{	// Fields
	private Vector3 m_StartPosition; // 0x0
	private Vector3 m_EndPosition; // 0xC
	private float m_CostModifier; // 0x18
	private int m_Bidirectional; // 0x1C
	private float m_Width; // 0x20
	private int m_Area; // 0x24
	private int m_AgentTypeID; // 0x28

	// Properties
	public Vector3 startPosition { set; }
	public Vector3 endPosition { set; }
	public float costModifier { set; }
	public bool bidirectional { set; }
	public float width { set; }
	public int area { set; }
	public int agentTypeID { set; }

	// Methods

	// RVA: 0x204B60 Offset: 0x203F60 VA: 0x180204B60
	public void set_startPosition(Vector3 value) { }

	// RVA: 0x2120F0 Offset: 0x2114F0 VA: 0x1802120F0
	public void set_endPosition(Vector3 value) { }

	// RVA: 0x2395A0 Offset: 0x2389A0 VA: 0x1802395A0
	public void set_costModifier(float value) { }

	// RVA: 0x23F0C0 Offset: 0x23E4C0 VA: 0x18023F0C0
	public void set_bidirectional(bool value) { }

	// RVA: 0x23D8F0 Offset: 0x23CCF0 VA: 0x18023D8F0
	public void set_width(float value) { }

	// RVA: 0x21DDA0 Offset: 0x21D1A0 VA: 0x18021DDA0
	public void set_area(int value) { }

	// RVA: 0xF3F00 Offset: 0xF3300 VA: 0x1800F3F00
	public void set_agentTypeID(int value) { }

}

public struct NavMeshLinkInstance // TypeDefIndex: 4452
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private int <id>k__BackingField; // 0x0

	// Properties
	public bool valid { get; }
	internal int id { get; set; }
	public Object owner { set; }

	// Methods

	// RVA: 0x23F110 Offset: 0x23E510 VA: 0x18023F110
	public bool get_valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	internal int get_id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	internal void set_id(int value) { }

	// RVA: 0x23F0D0 Offset: 0x23E4D0 VA: 0x18023F0D0
	public void Remove() { }

	// RVA: 0x23F160 Offset: 0x23E560 VA: 0x18023F160
	public void set_owner(Object value) { }

}

public struct NavMeshQueryFilter // TypeDefIndex: 4453
{	// Fields
	private const int k_AreaCostElementCount = 32;
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private float[] <costs>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private int <areaMask>k__BackingField; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private int <agentTypeID>k__BackingField; // 0xC

}

public static class NavMesh // TypeDefIndex: 4454
{	// Fields
	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; // 0x2B10510

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FDDF0 Offset: 0x22FC3F0 VA: 0x1822FDDF0
	private static void Internal_CallOnNavMeshPreUpdate() { }

	// RVA: 0x22FDC20 Offset: 0x22FC220 VA: 0x1822FDC20
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData) { }

	// RVA: 0x22FDB30 Offset: 0x22FC130 VA: 0x1822FDB30
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] // RVA: 0xB4C40 Offset: 0xB4040 VA: 0x1800B4C40
	[NativeNameAttribute] // RVA: 0xB4C40 Offset: 0xB4040 VA: 0x1800B4C40
	// RVA: 0x22FDE80 Offset: 0x22FC480 VA: 0x1822FDE80
	internal static bool IsValidNavMeshDataHandle(int handle) { }

	[StaticAccessorAttribute] // RVA: 0xB4EC0 Offset: 0xB42C0 VA: 0x1800B4EC0
	// RVA: 0x22FDE40 Offset: 0x22FC440 VA: 0x1822FDE40
	internal static bool IsValidLinkHandle(int handle) { }

	[StaticAccessorAttribute] // RVA: 0xB6320 Offset: 0xB5720 VA: 0x1800B6320
	[NativeNameAttribute] // RVA: 0xB6320 Offset: 0xB5720 VA: 0x1800B6320
	// RVA: 0x22FDDB0 Offset: 0x22FC3B0 VA: 0x1822FDDB0
	internal static bool InternalSetOwner(int dataID, int ownerID) { }

	[StaticAccessorAttribute] // RVA: 0xB6560 Offset: 0xB5960 VA: 0x1800B6560
	[NativeNameAttribute] // RVA: 0xB6560 Offset: 0xB5960 VA: 0x1800B6560
	// RVA: 0x22FDD70 Offset: 0x22FC370 VA: 0x1822FDD70
	internal static bool InternalSetLinkOwner(int linkID, int ownerID) { }

	[StaticAccessorAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	[NativeNameAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	// RVA: 0x22FDA30 Offset: 0x22FC030 VA: 0x1822FDA30
	internal static int AddNavMeshDataInternal(NavMeshData navMeshData) { }

	[StaticAccessorAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	[NativeNameAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	// RVA: 0x22FDAD0 Offset: 0x22FC0D0 VA: 0x1822FDAD0
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0xB6A50 Offset: 0xB5E50 VA: 0x1800B6A50
	[StaticAccessorAttribute] // RVA: 0xB6A50 Offset: 0xB5E50 VA: 0x1800B6A50
	// RVA: 0x22FDF00 Offset: 0x22FC500 VA: 0x1822FDF00
	internal static void RemoveNavMeshDataInternal(int handle) { }

	// RVA: 0x22FD9B0 Offset: 0x22FBFB0 VA: 0x1822FD9B0
	public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0xB6B40 Offset: 0xB5F40 VA: 0x1800B6B40
	[StaticAccessorAttribute] // RVA: 0xB6B40 Offset: 0xB5F40 VA: 0x1800B6B40
	// RVA: 0x22FD950 Offset: 0x22FBF50 VA: 0x1822FD950
	internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] // RVA: 0xB6CC0 Offset: 0xB60C0 VA: 0x1800B6CC0
	[NativeNameAttribute] // RVA: 0xB6CC0 Offset: 0xB60C0 VA: 0x1800B6CC0
	// RVA: 0x22FDEC0 Offset: 0x22FC4C0 VA: 0x1822FDEC0
	internal static void RemoveLinkInternal(int handle) { }

	// RVA: 0x22FDD10 Offset: 0x22FC310 VA: 0x1822FDD10
	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) { }

	// RVA: 0x22FDA70 Offset: 0x22FC070 VA: 0x1822FDA70
	private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x22FD8F0 Offset: 0x22FBEF0 VA: 0x1822FD8F0
	private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x22FDCD0 Offset: 0x22FC2D0 VA: 0x1822FDCD0
	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) { }

}

public sealed class NavMesh.OnNavMeshPreUpdate : MulticastDelegate // TypeDefIndex: 4455
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A722B0 Offset: 0x1A708B0 VA: 0x181A722B0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum NavMeshBuildSourceShape // TypeDefIndex: 4456
{	// Fields
	public int value__; // 0x0
	public const NavMeshBuildSourceShape Mesh = 0;
	public const NavMeshBuildSourceShape Terrain = 1;
	public const NavMeshBuildSourceShape Box = 2;
	public const NavMeshBuildSourceShape Sphere = 3;
	public const NavMeshBuildSourceShape Capsule = 4;
	public const NavMeshBuildSourceShape ModifierBox = 5;

}

public enum NavMeshCollectGeometry // TypeDefIndex: 4457
{	// Fields
	public int value__; // 0x0
	public const NavMeshCollectGeometry RenderMeshes = 0;
	public const NavMeshCollectGeometry PhysicsColliders = 1;

}

public struct NavMeshBuildSource // TypeDefIndex: 4458
{	// Fields
	private Matrix4x4 m_Transform; // 0x0
	private Vector3 m_Size; // 0x40
	private NavMeshBuildSourceShape m_Shape; // 0x4C
	private int m_Area; // 0x50
	private int m_InstanceID; // 0x54
	private int m_ComponentID; // 0x58

	// Properties
	public Matrix4x4 transform { get; set; }
	public Vector3 size { get; set; }
	public NavMeshBuildSourceShape shape { get; set; }
	public int area { set; }
	public Object sourceObject { get; set; }
	public Component component { get; }

	// Methods

	// RVA: 0x23EE50 Offset: 0x23E250 VA: 0x18023EE50
	public Matrix4x4 get_transform() { }

	// RVA: 0x23EF30 Offset: 0x23E330 VA: 0x18023EF30
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x23EDF0 Offset: 0x23E1F0 VA: 0x18023EDF0
	public Vector3 get_size() { }

	// RVA: 0x23EE90 Offset: 0x23E290 VA: 0x18023EE90
	public void set_size(Vector3 value) { }

	// RVA: 0x23EDE0 Offset: 0x23E1E0 VA: 0x18023EDE0
	public NavMeshBuildSourceShape get_shape() { }

	// RVA: 0x23EE80 Offset: 0x23E280 VA: 0x18023EE80
	public void set_shape(NavMeshBuildSourceShape value) { }

	// RVA: 0x1D2E10 Offset: 0x1D2210 VA: 0x1801D2E10
	public void set_area(int value) { }

	// RVA: 0x23EE10 Offset: 0x23E210 VA: 0x18023EE10
	public Object get_sourceObject() { }

	// RVA: 0x23EEA0 Offset: 0x23E2A0 VA: 0x18023EEA0
	public void set_sourceObject(Object value) { }

	// RVA: 0x23EDA0 Offset: 0x23E1A0 VA: 0x18023EDA0
	public Component get_component() { }

	[StaticAccessorAttribute] // RVA: 0xB7030 Offset: 0xB6430 VA: 0x1800B7030
	// RVA: 0x22FC7E0 Offset: 0x22FADE0 VA: 0x1822FC7E0
	private static Component InternalGetComponent(int instanceID) { }

	[StaticAccessorAttribute] // RVA: 0xB7030 Offset: 0xB6430 VA: 0x1800B7030
	// RVA: 0x22FC820 Offset: 0x22FAE20 VA: 0x1822FC820
	private static Object InternalGetObject(int instanceID) { }

}

public struct NavMeshBuildMarkup // TypeDefIndex: 4459
{	// Fields
	private int m_OverrideArea; // 0x0
	private int m_Area; // 0x4
	private int m_IgnoreFromBuild; // 0x8
	private int m_InstanceID; // 0xC

	// Properties
	public bool overrideArea { set; }
	public int area { set; }
	public bool ignoreFromBuild { set; }
	public Transform root { set; }

	// Methods

	// RVA: 0x23ECE0 Offset: 0x23E0E0 VA: 0x18023ECE0
	public void set_overrideArea(bool value) { }

	// RVA: 0x19DC50 Offset: 0x19D050 VA: 0x18019DC50
	public void set_area(int value) { }

	// RVA: 0x23ECD0 Offset: 0x23E0D0 VA: 0x18023ECD0
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x23ECF0 Offset: 0x23E0F0 VA: 0x18023ECF0
	public void set_root(Transform value) { }

}

public struct NavMeshBuildSettings // TypeDefIndex: 4460
{	// Fields
	private int m_AgentTypeID; // 0x0
	private float m_AgentRadius; // 0x4
	private float m_AgentHeight; // 0x8
	private float m_AgentSlope; // 0xC
	private float m_AgentClimb; // 0x10
	private float m_LedgeDropHeight; // 0x14
	private float m_MaxJumpAcrossDistance; // 0x18
	private float m_MinRegionArea; // 0x1C
	private int m_OverrideVoxelSize; // 0x20
	private float m_VoxelSize; // 0x24
	private int m_OverrideTileSize; // 0x28
	private int m_TileSize; // 0x2C
	private int m_AccuratePlacement; // 0x30
	private NavMeshBuildDebugSettings m_Debug; // 0x34

	// Properties
	public int agentTypeID { get; set; }
	public bool overrideVoxelSize { set; }
	public float voxelSize { set; }
	public bool overrideTileSize { set; }
	public int tileSize { set; }

	// Methods

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0
	public int get_agentTypeID() { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_agentTypeID(int value) { }

	// RVA: 0x23ED90 Offset: 0x23E190 VA: 0x18023ED90
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0x23D900 Offset: 0x23CD00 VA: 0x18023D900
	public void set_voxelSize(float value) { }

	// RVA: 0x23ED80 Offset: 0x23E180 VA: 0x18023ED80
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x1D8D20 Offset: 0x1D8120 VA: 0x1801D8D20
	public void set_tileSize(int value) { }

}

public struct NavMeshBuildDebugSettings // TypeDefIndex: 4461
{	// Fields
	private byte m_Flags; // 0x0

}

public class NavMeshLink : MonoBehaviour // TypeDefIndex: 8143
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <UpdateOnTransformChanged>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_AgentTypeID; // 0x1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 m_StartPoint; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 m_EndPoint; // 0x2C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_Width; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_CostModifier; // 0x3C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_Bidirectional; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_AutoUpdatePosition; // 0x41
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_Area; // 0x44
	private NavMeshLinkInstance m_LinkInstance; // 0x48
	private Vector3 m_LastPosition; // 0x4C
	private Quaternion m_LastRotation; // 0x58
	private static readonly List<NavMeshLink> s_Tracked; // 0x0

	// Properties
	public bool UpdateOnTransformChanged { get; set; }
	public int agentTypeID { get; set; }
	public Vector3 startPoint { get; set; }
	public Vector3 endPoint { get; set; }
	public float width { get; set; }
	public int costModifier { get; set; }
	public bool bidirectional { get; set; }
	public bool autoUpdate { get; set; }
	public int area { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010
	public void set_UpdateOnTransformChanged(bool value) { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public int get_agentTypeID() { }

	// RVA: 0x12D3560 Offset: 0x12D1B60 VA: 0x1812D3560
	public void set_agentTypeID(int value) { }

	// RVA: 0x12D3540 Offset: 0x12D1B40 VA: 0x1812D3540
	public Vector3 get_startPoint() { }

	// RVA: 0x12D3660 Offset: 0x12D1C60 VA: 0x1812D3660
	public void set_startPoint(Vector3 value) { }

	// RVA: 0x12D3520 Offset: 0x12D1B20 VA: 0x1812D3520
	public Vector3 get_endPoint() { }

	// RVA: 0x12D3620 Offset: 0x12D1C20 VA: 0x1812D3620
	public void set_endPoint(Vector3 value) { }

	// RVA: 0x10B8B50 Offset: 0x10B7150 VA: 0x1810B8B50
	public float get_width() { }

	// RVA: 0x12D36A0 Offset: 0x12D1CA0 VA: 0x1812D36A0
	public void set_width(float value) { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0
	public int get_costModifier() { }

	// RVA: 0x12D35F0 Offset: 0x12D1BF0 VA: 0x1812D35F0
	public void set_costModifier(int value) { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90
	public bool get_bidirectional() { }

	// RVA: 0x12D35C0 Offset: 0x12D1BC0 VA: 0x1812D35C0
	public void set_bidirectional(bool value) { }

	// RVA: 0xEE7C00 Offset: 0xEE6200 VA: 0x180EE7C00
	public bool get_autoUpdate() { }

	// RVA: 0x12D31A0 Offset: 0x12D17A0 VA: 0x1812D31A0
	public void set_autoUpdate(bool value) { }

	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	public int get_area() { }

	// RVA: 0x12D3590 Offset: 0x12D1B90 VA: 0x1812D3590
	public void set_area(int value) { }

	// RVA: 0x12D2FF0 Offset: 0x12D15F0 VA: 0x1812D2FF0
	private void OnEnable() { }

	// RVA: 0x12D2F90 Offset: 0x12D1590 VA: 0x1812D2F90
	private void OnDisable() { }

	// RVA: 0x12D2F60 Offset: 0x12D1560 VA: 0x1812D2F60
	public void UpdateLink() { }

	// RVA: 0x12D2CD0 Offset: 0x12D12D0 VA: 0x1812D2CD0
	private static void AddTracking(NavMeshLink link) { }

	// RVA: 0x12D3070 Offset: 0x12D1670 VA: 0x1812D3070
	private static void RemoveTracking(NavMeshLink link) { }

	// RVA: 0x12D31A0 Offset: 0x12D17A0 VA: 0x1812D31A0
	private void SetAutoUpdate(bool value) { }

	// RVA: 0x12D2AC0 Offset: 0x12D10C0 VA: 0x1812D2AC0
	private void AddLink() { }

	// RVA: 0x12D2E20 Offset: 0x12D1420 VA: 0x1812D2E20
	private bool HasTransformChanged() { }

	// RVA: 0x12D2F60 Offset: 0x12D1560 VA: 0x1812D2F60
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x12D3240 Offset: 0x12D1840 VA: 0x1812D3240
	private static void UpdateTrackedInstances() { }

	// RVA: 0x12D3400 Offset: 0x12D1A00 VA: 0x1812D3400
	public void .ctor() { }

	// RVA: 0x12D33A0 Offset: 0x12D19A0 VA: 0x1812D33A0
	private static void .cctor() { }

}

public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 8144
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_OverrideArea; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_Area; // 0x1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_IgnoreFromBuild; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<int> m_AffectedAgents; // 0x28
	private static readonly List<NavMeshModifier> s_NavMeshModifiers; // 0x0

	// Properties
	public bool overrideArea { get; set; }
	public int area { get; set; }
	public bool ignoreFromBuild { get; set; }
	public static List<NavMeshModifier> activeModifiers { get; }

	// Methods

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_overrideArea() { }

	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010
	public void set_overrideArea(bool value) { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public int get_area() { }

	// RVA: 0x960000 Offset: 0x95E600 VA: 0x180960000
	public void set_area(int value) { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public bool get_ignoreFromBuild() { }

	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x12D3E70 Offset: 0x12D2470 VA: 0x1812D3E70
	public static List<NavMeshModifier> get_activeModifiers() { }

	// RVA: 0x12D3C80 Offset: 0x12D2280 VA: 0x1812D3C80
	private void OnEnable() { }

	// RVA: 0x12D3C00 Offset: 0x12D2200 VA: 0x1812D3C00
	private void OnDisable() { }

	// RVA: 0x12D3B60 Offset: 0x12D2160 VA: 0x1812D3B60
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x12D3DB0 Offset: 0x12D23B0 VA: 0x1812D3DB0
	public void .ctor() { }

	// RVA: 0x12D3D50 Offset: 0x12D2350 VA: 0x1812D3D50
	private static void .cctor() { }

}

public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 8145
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 m_Size; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 m_Center; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_Area; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<int> m_AffectedAgents; // 0x38
	private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; // 0x0

	// Properties
	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public int area { get; set; }
	public static List<NavMeshModifierVolume> activeModifiers { get; }

	// Methods

	// RVA: 0x12D3B30 Offset: 0x12D2130 VA: 0x1812D3B30
	public Vector3 get_size() { }

	// RVA: 0x12D3B50 Offset: 0x12D2150 VA: 0x1812D3B50
	public void set_size(Vector3 value) { }

	// RVA: 0x1075310 Offset: 0x1073910 VA: 0x181075310
	public Vector3 get_center() { }

	// RVA: 0x10754F0 Offset: 0x1073AF0 VA: 0x1810754F0
	public void set_center(Vector3 value) { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public int get_area() { }

	// RVA: 0xA39A50 Offset: 0xA38050 VA: 0x180A39A50
	public void set_area(int value) { }

	// RVA: 0x12D3AD0 Offset: 0x12D20D0 VA: 0x1812D3AD0
	public static List<NavMeshModifierVolume> get_activeModifiers() { }

	// RVA: 0x12D38B0 Offset: 0x12D1EB0 VA: 0x1812D38B0
	private void OnEnable() { }

	// RVA: 0x12D3830 Offset: 0x12D1E30 VA: 0x1812D3830
	private void OnDisable() { }

	// RVA: 0x12D3740 Offset: 0x12D1D40 VA: 0x1812D3740
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x12D36D0 Offset: 0x12D1CD0 VA: 0x1812D36D0
	public void AddAgentType(int agentTypeID) { }

	// RVA: 0x12D37E0 Offset: 0x12D1DE0 VA: 0x1812D37E0
	public void ClearAgentTypes() { }

	// RVA: 0x12D39E0 Offset: 0x12D1FE0 VA: 0x1812D39E0
	public void .ctor() { }

	// RVA: 0x12D3980 Offset: 0x12D1F80 VA: 0x1812D3980
	private static void .cctor() { }

}

public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 8147
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <UpdateOnTransformChanged>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_AgentTypeID; // 0x1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CollectObjects m_CollectObjects; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 m_Size; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 m_Center; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private LayerMask m_LayerMask; // 0x3C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private NavMeshCollectGeometry m_UseGeometry; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_DefaultArea; // 0x44
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_IgnoreNavMeshAgent; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_IgnoreNavMeshObstacle; // 0x49
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_OverrideTileSize; // 0x4A
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_TileSize; // 0x4C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_OverrideVoxelSize; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_VoxelSize; // 0x54
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_BuildHeightMesh; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0x96960 Offset: 0x95D60 VA: 0x180096960
	[SerializeField] // RVA: 0x96960 Offset: 0x95D60 VA: 0x180096960
	private NavMeshData m_NavMeshData; // 0x60
	private NavMeshDataInstance m_NavMeshDataInstance; // 0x68
	private Vector3 m_LastPosition; // 0x6C
	private Quaternion m_LastRotation; // 0x78
	private static readonly List<NavMeshSurface> s_NavMeshSurfaces; // 0x0

	// Properties
	public bool UpdateOnTransformChanged { get; set; }
	public int agentTypeID { get; set; }
	public CollectObjects collectObjects { get; set; }
	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public LayerMask layerMask { get; set; }
	public NavMeshCollectGeometry useGeometry { get; set; }
	public int defaultArea { get; set; }
	public bool ignoreNavMeshAgent { get; set; }
	public bool ignoreNavMeshObstacle { get; set; }
	public bool overrideTileSize { get; set; }
	public int tileSize { get; set; }
	public bool overrideVoxelSize { get; set; }
	public float voxelSize { get; set; }
	public bool buildHeightMesh { get; set; }
	public NavMeshData navMeshData { get; set; }
	public static List<NavMeshSurface> activeSurfaces { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010
	public void set_UpdateOnTransformChanged(bool value) { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public int get_agentTypeID() { }

	// RVA: 0x960000 Offset: 0x95E600 VA: 0x180960000
	public void set_agentTypeID(int value) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public CollectObjects get_collectObjects() { }

	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	public void set_collectObjects(CollectObjects value) { }

	// RVA: 0x1075310 Offset: 0x1073910 VA: 0x181075310
	public Vector3 get_size() { }

	// RVA: 0x10754F0 Offset: 0x1073AF0 VA: 0x1810754F0
	public void set_size(Vector3 value) { }

	// RVA: 0x12D7430 Offset: 0x12D5A30 VA: 0x1812D7430
	public Vector3 get_center() { }

	// RVA: 0x12D7450 Offset: 0x12D5A50 VA: 0x1812D7450
	public void set_center(Vector3 value) { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0
	public LayerMask get_layerMask() { }

	// RVA: 0x8C1690 Offset: 0x8BFC90 VA: 0x1808C1690
	public void set_layerMask(LayerMask value) { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	public NavMeshCollectGeometry get_useGeometry() { }

	// RVA: 0x6840F0 Offset: 0x6826F0 VA: 0x1806840F0
	public void set_useGeometry(NavMeshCollectGeometry value) { }

	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	public int get_defaultArea() { }

	// RVA: 0x8C1320 Offset: 0x8BF920 VA: 0x1808C1320
	public void set_defaultArea(int value) { }

	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	public bool get_ignoreNavMeshAgent() { }

	// RVA: 0x4BC570 Offset: 0x4BAB70 VA: 0x1804BC570
	public void set_ignoreNavMeshAgent(bool value) { }

	// RVA: 0xBA2230 Offset: 0xBA0830 VA: 0x180BA2230
	public bool get_ignoreNavMeshObstacle() { }

	// RVA: 0x82DE50 Offset: 0x82C450 VA: 0x18082DE50
	public void set_ignoreNavMeshObstacle(bool value) { }

	// RVA: 0xBA2220 Offset: 0xBA0820 VA: 0x180BA2220
	public bool get_overrideTileSize() { }

	// RVA: 0x1239140 Offset: 0x1237740 VA: 0x181239140
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x599CD0 Offset: 0x5982D0 VA: 0x180599CD0
	public int get_tileSize() { }

	// RVA: 0x59A080 Offset: 0x598680 VA: 0x18059A080
	public void set_tileSize(int value) { }

	// RVA: 0x77B140 Offset: 0x779740 VA: 0x18077B140
	public bool get_overrideVoxelSize() { }

	// RVA: 0xE69B60 Offset: 0xE68160 VA: 0x180E69B60
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0xFD00B0 Offset: 0xFCE6B0 VA: 0x180FD00B0
	public float get_voxelSize() { }

	// RVA: 0x12D7460 Offset: 0x12D5A60 VA: 0x1812D7460
	public void set_voxelSize(float value) { }

	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	public bool get_buildHeightMesh() { }

	// RVA: 0x5925D0 Offset: 0x590BD0 VA: 0x1805925D0
	public void set_buildHeightMesh(bool value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public NavMeshData get_navMeshData() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_navMeshData(NavMeshData value) { }

	// RVA: 0x12D73D0 Offset: 0x12D59D0 VA: 0x1812D73D0
	public static List<NavMeshSurface> get_activeSurfaces() { }

	// RVA: 0x12D65B0 Offset: 0x12D4BB0 VA: 0x1812D65B0
	private void OnEnable() { }

	// RVA: 0x12D6430 Offset: 0x12D4A30 VA: 0x1812D6430
	private void OnDisable() { }

	// RVA: 0x12D3F80 Offset: 0x12D2580 VA: 0x1812D3F80
	public void AddData() { }

	// RVA: 0x12D6930 Offset: 0x12D4F30 VA: 0x1812D6930
	public void RemoveData() { }

	// RVA: 0x12D5D70 Offset: 0x12D4370 VA: 0x1812D5D70
	public NavMeshBuildSettings GetBuildSettings() { }

	// RVA: 0x12D4790 Offset: 0x12D2D90 VA: 0x1812D4790
	public void BuildNavMesh() { }

	// RVA: 0x12D4810 Offset: 0x12D2E10 VA: 0x1812D4810
	public void BuildNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds, NavMeshBuildSettings buildSettings) { }

	// RVA: 0x12D6CB0 Offset: 0x12D52B0 VA: 0x1812D6CB0
	public AsyncOperation UpdateNavMesh() { }

	// RVA: 0x12D6EE0 Offset: 0x12D54E0 VA: 0x1812D6EE0
	public AsyncOperation UpdateNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds) { }

	// RVA: 0x12D6CE0 Offset: 0x12D52E0 VA: 0x1812D6CE0
	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

	// RVA: 0x12D6790 Offset: 0x12D4D90 VA: 0x1812D6790
	private static void Register(NavMeshSurface surface) { }

	// RVA: 0x12D6950 Offset: 0x12D4F50 VA: 0x1812D6950
	private static void Unregister(NavMeshSurface surface) { }

	// RVA: 0x12D6A80 Offset: 0x12D5080 VA: 0x1812D6A80
	private static void UpdateActive() { }

	// RVA: 0x12D4110 Offset: 0x12D2710 VA: 0x1812D4110
	private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources) { }

	// RVA: 0x12D5570 Offset: 0x12D3B70 VA: 0x1812D5570
	private List<NavMeshBuildSource> CollectSources() { }

	// RVA: 0x12D3ED0 Offset: 0x12D24D0 VA: 0x1812D3ED0
	private static Vector3 Abs(Vector3 v) { }

	// RVA: 0x12D5EC0 Offset: 0x12D44C0 VA: 0x1812D5EC0
	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	// RVA: 0x12D4B20 Offset: 0x12D3120 VA: 0x1812D4B20
	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) { }

	// RVA: 0x12D62F0 Offset: 0x12D48F0 VA: 0x1812D62F0
	private bool HasTransformChanged() { }

	// RVA: 0x12D6B50 Offset: 0x12D5150 VA: 0x1812D6B50
	private void UpdateDataIfTransformChanged() { }

	// RVA: 0x12D72A0 Offset: 0x12D58A0 VA: 0x1812D72A0
	public void .ctor() { }

	// RVA: 0x12D7240 Offset: 0x12D5840 VA: 0x1812D7240
	private static void .cctor() { }

}

private sealed class NavMeshSurface.<>c // TypeDefIndex: 8148
{	// Fields
	public static readonly NavMeshSurface.<>c <>9; // 0x0
	public static Predicate<NavMeshModifierVolume> <>9__83_0; // 0x8
	public static Predicate<NavMeshModifier> <>9__84_0; // 0x10
	public static Predicate<NavMeshBuildSource> <>9__84_1; // 0x18
	public static Predicate<NavMeshBuildSource> <>9__84_2; // 0x20

	// Methods

	// RVA: 0x12E3AF0 Offset: 0x12E20F0 VA: 0x1812E3AF0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x12E3900 Offset: 0x12E1F00 VA: 0x1812E3900
	internal bool <AppendModifierVolumes>b__83_0(NavMeshModifierVolume x) { }

	// RVA: 0x12E3900 Offset: 0x12E1F00 VA: 0x1812E3900
	internal bool <CollectSources>b__84_0(NavMeshModifier x) { }

	// RVA: 0x12E3930 Offset: 0x12E1F30 VA: 0x1812E3930
	internal bool <CollectSources>b__84_1(NavMeshBuildSource x) { }

	// RVA: 0x12E3A10 Offset: 0x12E2010 VA: 0x1812E3A10
	internal bool <CollectSources>b__84_2(NavMeshBuildSource x) { }

}

public class NavMeshTester : MonoBehaviour // TypeDefIndex: 8962
{	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

