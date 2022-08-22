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

	// RVA: 0x22FC4E0 Offset: 0x22FAAE0 VA: 0x1822FC4E0
	public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	// RVA: 0x22FC730 Offset: 0x22FAD30 VA: 0x1822FC730
	public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	// RVA: 0x22FC460 Offset: 0x22FAA60 VA: 0x1822FC460
	private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	// RVA: 0x22FC1E0 Offset: 0x22FA7E0 VA: 0x1822FC1E0
	public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation) { }

	// RVA: 0x22FCB60 Offset: 0x22FB160 VA: 0x1822FCB60
	private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x22FC990 Offset: 0x22FAF90 VA: 0x1822FC990
	public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds) { }

	// RVA: 0x22FC920 Offset: 0x22FAF20 VA: 0x1822FC920
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x22FC3F0 Offset: 0x22FA9F0 VA: 0x1822FC3F0
	private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	// RVA: 0x22FCAF0 Offset: 0x22FB0F0 VA: 0x1822FCAF0
	private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

	// RVA: 0x22FC8B0 Offset: 0x22FAEB0 VA: 0x1822FC8B0
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

}

public sealed class NavMeshAgent : Behaviour // TypeDefIndex: 4446
{	// Properties
	public bool isOnOffMeshLink { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xB3DA0 Offset: 0xB31A0 VA: 0x1800B3DA0
	// RVA: 0x22FBEA0 Offset: 0x22FA4A0 VA: 0x1822FBEA0
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

	// RVA: 0x212B90 Offset: 0x211F90 VA: 0x180212B90
	public Vector3 get_position() { }

	// RVA: 0x212BB0 Offset: 0x211FB0 VA: 0x180212BB0
	public Vector3 get_normal() { }

}

public sealed class NavMeshData : Object // TypeDefIndex: 4449
{	// Properties
	public Vector3 position { set; }
	public Quaternion rotation { set; }

	// Methods

	// RVA: 0x22FCD80 Offset: 0x22FB380 VA: 0x1822FCD80
	public void .ctor(int agentTypeID) { }

	[StaticAccessorAttribute] // RVA: 0xB4070 Offset: 0xB3470 VA: 0x1800B4070
	// RVA: 0x22FCD40 Offset: 0x22FB340 VA: 0x1822FCD40
	private static void Internal_Create(NavMeshData mono, int agentTypeID) { }

	// RVA: 0x22FCE60 Offset: 0x22FB460 VA: 0x1822FCE60
	public void set_position(Vector3 value) { }

	// RVA: 0x22FCF00 Offset: 0x22FB500 VA: 0x1822FCF00
	public void set_rotation(Quaternion value) { }

	// RVA: 0x22FCE10 Offset: 0x22FB410 VA: 0x1822FCE10
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x22FCEB0 Offset: 0x22FB4B0 VA: 0x1822FCEB0
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

	// RVA: 0x204F30 Offset: 0x204330 VA: 0x180204F30
	public void set_startPosition(Vector3 value) { }

	// RVA: 0x212CC0 Offset: 0x2120C0 VA: 0x180212CC0
	public void set_endPosition(Vector3 value) { }

	// RVA: 0x2395A0 Offset: 0x2389A0 VA: 0x1802395A0
	public void set_costModifier(float value) { }

	// RVA: 0x23F0C0 Offset: 0x23E4C0 VA: 0x18023F0C0
	public void set_bidirectional(bool value) { }

	// RVA: 0x23D8F0 Offset: 0x23CCF0 VA: 0x18023D8F0
	public void set_width(float value) { }

	// RVA: 0x222820 Offset: 0x221C20 VA: 0x180222820
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
	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; // 0x135B0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FD5D0 Offset: 0x22FBBD0 VA: 0x1822FD5D0
	private static void Internal_CallOnNavMeshPreUpdate() { }

	// RVA: 0x22FD400 Offset: 0x22FBA00 VA: 0x1822FD400
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData) { }

	// RVA: 0x22FD310 Offset: 0x22FB910 VA: 0x1822FD310
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] // RVA: 0xB4C40 Offset: 0xB4040 VA: 0x1800B4C40
	[NativeNameAttribute] // RVA: 0xB4C40 Offset: 0xB4040 VA: 0x1800B4C40
	// RVA: 0x22FD660 Offset: 0x22FBC60 VA: 0x1822FD660
	internal static bool IsValidNavMeshDataHandle(int handle) { }

	[StaticAccessorAttribute] // RVA: 0xB4EC0 Offset: 0xB42C0 VA: 0x1800B4EC0
	// RVA: 0x22FD620 Offset: 0x22FBC20 VA: 0x1822FD620
	internal static bool IsValidLinkHandle(int handle) { }

	[StaticAccessorAttribute] // RVA: 0xB6320 Offset: 0xB5720 VA: 0x1800B6320
	[NativeNameAttribute] // RVA: 0xB6320 Offset: 0xB5720 VA: 0x1800B6320
	// RVA: 0x22FD590 Offset: 0x22FBB90 VA: 0x1822FD590
	internal static bool InternalSetOwner(int dataID, int ownerID) { }

	[StaticAccessorAttribute] // RVA: 0xB6560 Offset: 0xB5960 VA: 0x1800B6560
	[NativeNameAttribute] // RVA: 0xB6560 Offset: 0xB5960 VA: 0x1800B6560
	// RVA: 0x22FD550 Offset: 0x22FBB50 VA: 0x1822FD550
	internal static bool InternalSetLinkOwner(int linkID, int ownerID) { }

	[StaticAccessorAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	[NativeNameAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	// RVA: 0x22FD210 Offset: 0x22FB810 VA: 0x1822FD210
	internal static int AddNavMeshDataInternal(NavMeshData navMeshData) { }

	[StaticAccessorAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	[NativeNameAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	// RVA: 0x22FD2B0 Offset: 0x22FB8B0 VA: 0x1822FD2B0
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0xB6A50 Offset: 0xB5E50 VA: 0x1800B6A50
	[StaticAccessorAttribute] // RVA: 0xB6A50 Offset: 0xB5E50 VA: 0x1800B6A50
	// RVA: 0x22FD6E0 Offset: 0x22FBCE0 VA: 0x1822FD6E0
	internal static void RemoveNavMeshDataInternal(int handle) { }

	// RVA: 0x22FD190 Offset: 0x22FB790 VA: 0x1822FD190
	public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0xB6B40 Offset: 0xB5F40 VA: 0x1800B6B40
	[StaticAccessorAttribute] // RVA: 0xB6B40 Offset: 0xB5F40 VA: 0x1800B6B40
	// RVA: 0x22FD130 Offset: 0x22FB730 VA: 0x1822FD130
	internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] // RVA: 0xB6CC0 Offset: 0xB60C0 VA: 0x1800B6CC0
	[NativeNameAttribute] // RVA: 0xB6CC0 Offset: 0xB60C0 VA: 0x1800B6CC0
	// RVA: 0x22FD6A0 Offset: 0x22FBCA0 VA: 0x1822FD6A0
	internal static void RemoveLinkInternal(int handle) { }

	// RVA: 0x22FD4F0 Offset: 0x22FBAF0 VA: 0x1822FD4F0
	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) { }

	// RVA: 0x22FD250 Offset: 0x22FB850 VA: 0x1822FD250
	private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x22FD0D0 Offset: 0x22FB6D0 VA: 0x1822FD0D0
	private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x22FD4B0 Offset: 0x22FBAB0 VA: 0x1822FD4B0
	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) { }

}

public sealed class NavMesh.OnNavMeshPreUpdate : MulticastDelegate // TypeDefIndex: 4455
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A85D80 Offset: 0x1A84380 VA: 0x181A85D80 Slot: 12
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

	// RVA: 0x1D27A0 Offset: 0x1D1BA0 VA: 0x1801D27A0
	public void set_area(int value) { }

	// RVA: 0x23EE10 Offset: 0x23E210 VA: 0x18023EE10
	public Object get_sourceObject() { }

	// RVA: 0x23EEA0 Offset: 0x23E2A0 VA: 0x18023EEA0
	public void set_sourceObject(Object value) { }

	// RVA: 0x23EDA0 Offset: 0x23E1A0 VA: 0x18023EDA0
	public Component get_component() { }

	[StaticAccessorAttribute] // RVA: 0xB7030 Offset: 0xB6430 VA: 0x1800B7030
	// RVA: 0x22FBFC0 Offset: 0x22FA5C0 VA: 0x1822FBFC0
	private static Component InternalGetComponent(int instanceID) { }

	[StaticAccessorAttribute] // RVA: 0xB7030 Offset: 0xB6430 VA: 0x1800B7030
	// RVA: 0x22FC000 Offset: 0x22FA600 VA: 0x1822FC000
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

	// RVA: 0x19DF60 Offset: 0x19D360 VA: 0x18019DF60
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

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0
	public int get_agentTypeID() { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_agentTypeID(int value) { }

	// RVA: 0x23ED90 Offset: 0x23E190 VA: 0x18023ED90
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0x23D900 Offset: 0x23CD00 VA: 0x18023D900
	public void set_voxelSize(float value) { }

	// RVA: 0x23ED80 Offset: 0x23E180 VA: 0x18023ED80
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x1D86B0 Offset: 0x1D7AB0 VA: 0x1801D86B0
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
	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10
	public void set_UpdateOnTransformChanged(bool value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_agentTypeID() { }

	// RVA: 0x12CD0B0 Offset: 0x12CB6B0 VA: 0x1812CD0B0
	public void set_agentTypeID(int value) { }

	// RVA: 0x12CD090 Offset: 0x12CB690 VA: 0x1812CD090
	public Vector3 get_startPoint() { }

	// RVA: 0x12CD1B0 Offset: 0x12CB7B0 VA: 0x1812CD1B0
	public void set_startPoint(Vector3 value) { }

	// RVA: 0x12CD070 Offset: 0x12CB670 VA: 0x1812CD070
	public Vector3 get_endPoint() { }

	// RVA: 0x12CD170 Offset: 0x12CB770 VA: 0x1812CD170
	public void set_endPoint(Vector3 value) { }

	// RVA: 0x10B80E0 Offset: 0x10B66E0 VA: 0x1810B80E0
	public float get_width() { }

	// RVA: 0x12CD1F0 Offset: 0x12CB7F0 VA: 0x1812CD1F0
	public void set_width(float value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public int get_costModifier() { }

	// RVA: 0x12CD140 Offset: 0x12CB740 VA: 0x1812CD140
	public void set_costModifier(int value) { }

	// RVA: 0x805600 Offset: 0x803C00 VA: 0x180805600
	public bool get_bidirectional() { }

	// RVA: 0x12CD110 Offset: 0x12CB710 VA: 0x1812CD110
	public void set_bidirectional(bool value) { }

	// RVA: 0xEE7150 Offset: 0xEE5750 VA: 0x180EE7150
	public bool get_autoUpdate() { }

	// RVA: 0x12CCCF0 Offset: 0x12CB2F0 VA: 0x1812CCCF0
	public void set_autoUpdate(bool value) { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_area() { }

	// RVA: 0x12CD0E0 Offset: 0x12CB6E0 VA: 0x1812CD0E0
	public void set_area(int value) { }

	// RVA: 0x12CCB40 Offset: 0x12CB140 VA: 0x1812CCB40
	private void OnEnable() { }

	// RVA: 0x12CCAE0 Offset: 0x12CB0E0 VA: 0x1812CCAE0
	private void OnDisable() { }

	// RVA: 0x12CCAB0 Offset: 0x12CB0B0 VA: 0x1812CCAB0
	public void UpdateLink() { }

	// RVA: 0x12CC820 Offset: 0x12CAE20 VA: 0x1812CC820
	private static void AddTracking(NavMeshLink link) { }

	// RVA: 0x12CCBC0 Offset: 0x12CB1C0 VA: 0x1812CCBC0
	private static void RemoveTracking(NavMeshLink link) { }

	// RVA: 0x12CCCF0 Offset: 0x12CB2F0 VA: 0x1812CCCF0
	private void SetAutoUpdate(bool value) { }

	// RVA: 0x12CC610 Offset: 0x12CAC10 VA: 0x1812CC610
	private void AddLink() { }

	// RVA: 0x12CC970 Offset: 0x12CAF70 VA: 0x1812CC970
	private bool HasTransformChanged() { }

	// RVA: 0x12CCAB0 Offset: 0x12CB0B0 VA: 0x1812CCAB0
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x12CCD90 Offset: 0x12CB390 VA: 0x1812CCD90
	private static void UpdateTrackedInstances() { }

	// RVA: 0x12CCF50 Offset: 0x12CB550 VA: 0x1812CCF50
	public void .ctor() { }

	// RVA: 0x12CCEF0 Offset: 0x12CB4F0 VA: 0x1812CCEF0
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

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_overrideArea() { }

	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10
	public void set_overrideArea(bool value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_area() { }

	// RVA: 0x95FB00 Offset: 0x95E100 VA: 0x18095FB00
	public void set_area(int value) { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public bool get_ignoreFromBuild() { }

	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x12CD9C0 Offset: 0x12CBFC0 VA: 0x1812CD9C0
	public static List<NavMeshModifier> get_activeModifiers() { }

	// RVA: 0x12CD7D0 Offset: 0x12CBDD0 VA: 0x1812CD7D0
	private void OnEnable() { }

	// RVA: 0x12CD750 Offset: 0x12CBD50 VA: 0x1812CD750
	private void OnDisable() { }

	// RVA: 0x12CD6B0 Offset: 0x12CBCB0 VA: 0x1812CD6B0
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x12CD900 Offset: 0x12CBF00 VA: 0x1812CD900
	public void .ctor() { }

	// RVA: 0x12CD8A0 Offset: 0x12CBEA0 VA: 0x1812CD8A0
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

	// RVA: 0x12CD680 Offset: 0x12CBC80 VA: 0x1812CD680
	public Vector3 get_size() { }

	// RVA: 0x12CD6A0 Offset: 0x12CBCA0 VA: 0x1812CD6A0
	public void set_size(Vector3 value) { }

	// RVA: 0x10748A0 Offset: 0x1072EA0 VA: 0x1810748A0
	public Vector3 get_center() { }

	// RVA: 0x1074A80 Offset: 0x1073080 VA: 0x181074A80
	public void set_center(Vector3 value) { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	public int get_area() { }

	// RVA: 0xA39560 Offset: 0xA37B60 VA: 0x180A39560
	public void set_area(int value) { }

	// RVA: 0x12CD620 Offset: 0x12CBC20 VA: 0x1812CD620
	public static List<NavMeshModifierVolume> get_activeModifiers() { }

	// RVA: 0x12CD400 Offset: 0x12CBA00 VA: 0x1812CD400
	private void OnEnable() { }

	// RVA: 0x12CD380 Offset: 0x12CB980 VA: 0x1812CD380
	private void OnDisable() { }

	// RVA: 0x12CD290 Offset: 0x12CB890 VA: 0x1812CD290
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x12CD220 Offset: 0x12CB820 VA: 0x1812CD220
	public void AddAgentType(int agentTypeID) { }

	// RVA: 0x12CD330 Offset: 0x12CB930 VA: 0x1812CD330
	public void ClearAgentTypes() { }

	// RVA: 0x12CD530 Offset: 0x12CBB30 VA: 0x1812CD530
	public void .ctor() { }

	// RVA: 0x12CD4D0 Offset: 0x12CBAD0 VA: 0x1812CD4D0
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
	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10
	public void set_UpdateOnTransformChanged(bool value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_agentTypeID() { }

	// RVA: 0x95FB00 Offset: 0x95E100 VA: 0x18095FB00
	public void set_agentTypeID(int value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public CollectObjects get_collectObjects() { }

	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	public void set_collectObjects(CollectObjects value) { }

	// RVA: 0x10748A0 Offset: 0x1072EA0 VA: 0x1810748A0
	public Vector3 get_size() { }

	// RVA: 0x1074A80 Offset: 0x1073080 VA: 0x181074A80
	public void set_size(Vector3 value) { }

	// RVA: 0x12D0F80 Offset: 0x12CF580 VA: 0x1812D0F80
	public Vector3 get_center() { }

	// RVA: 0x12D0FA0 Offset: 0x12CF5A0 VA: 0x1812D0FA0
	public void set_center(Vector3 value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public LayerMask get_layerMask() { }

	// RVA: 0x8C1180 Offset: 0x8BF780 VA: 0x1808C1180
	public void set_layerMask(LayerMask value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public NavMeshCollectGeometry get_useGeometry() { }

	// RVA: 0x684160 Offset: 0x682760 VA: 0x180684160
	public void set_useGeometry(NavMeshCollectGeometry value) { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_defaultArea() { }

	// RVA: 0x8C0E10 Offset: 0x8BF410 VA: 0x1808C0E10
	public void set_defaultArea(int value) { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_ignoreNavMeshAgent() { }

	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	public void set_ignoreNavMeshAgent(bool value) { }

	// RVA: 0xBA1D60 Offset: 0xBA0360 VA: 0x180BA1D60
	public bool get_ignoreNavMeshObstacle() { }

	// RVA: 0x82D900 Offset: 0x82BF00 VA: 0x18082D900
	public void set_ignoreNavMeshObstacle(bool value) { }

	// RVA: 0xBA1D50 Offset: 0xBA0350 VA: 0x180BA1D50
	public bool get_overrideTileSize() { }

	// RVA: 0x1238AA0 Offset: 0x12370A0 VA: 0x181238AA0
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40
	public int get_tileSize() { }

	// RVA: 0x59A0F0 Offset: 0x5986F0 VA: 0x18059A0F0
	public void set_tileSize(int value) { }

	// RVA: 0x77B1F0 Offset: 0x7797F0 VA: 0x18077B1F0
	public bool get_overrideVoxelSize() { }

	// RVA: 0xE690B0 Offset: 0xE676B0 VA: 0x180E690B0
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0xFCF610 Offset: 0xFCDC10 VA: 0x180FCF610
	public float get_voxelSize() { }

	// RVA: 0x12D0FB0 Offset: 0x12CF5B0 VA: 0x1812D0FB0
	public void set_voxelSize(float value) { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_buildHeightMesh() { }

	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	public void set_buildHeightMesh(bool value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public NavMeshData get_navMeshData() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_navMeshData(NavMeshData value) { }

	// RVA: 0x12D0F20 Offset: 0x12CF520 VA: 0x1812D0F20
	public static List<NavMeshSurface> get_activeSurfaces() { }

	// RVA: 0x12D0100 Offset: 0x12CE700 VA: 0x1812D0100
	private void OnEnable() { }

	// RVA: 0x12CFF80 Offset: 0x12CE580 VA: 0x1812CFF80
	private void OnDisable() { }

	// RVA: 0x12CDAD0 Offset: 0x12CC0D0 VA: 0x1812CDAD0
	public void AddData() { }

	// RVA: 0x12D0480 Offset: 0x12CEA80 VA: 0x1812D0480
	public void RemoveData() { }

	// RVA: 0x12CF8C0 Offset: 0x12CDEC0 VA: 0x1812CF8C0
	public NavMeshBuildSettings GetBuildSettings() { }

	// RVA: 0x12CE2E0 Offset: 0x12CC8E0 VA: 0x1812CE2E0
	public void BuildNavMesh() { }

	// RVA: 0x12CE360 Offset: 0x12CC960 VA: 0x1812CE360
	public void BuildNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds, NavMeshBuildSettings buildSettings) { }

	// RVA: 0x12D0800 Offset: 0x12CEE00 VA: 0x1812D0800
	public AsyncOperation UpdateNavMesh() { }

	// RVA: 0x12D0A30 Offset: 0x12CF030 VA: 0x1812D0A30
	public AsyncOperation UpdateNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds) { }

	// RVA: 0x12D0830 Offset: 0x12CEE30 VA: 0x1812D0830
	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

	// RVA: 0x12D02E0 Offset: 0x12CE8E0 VA: 0x1812D02E0
	private static void Register(NavMeshSurface surface) { }

	// RVA: 0x12D04A0 Offset: 0x12CEAA0 VA: 0x1812D04A0
	private static void Unregister(NavMeshSurface surface) { }

	// RVA: 0x12D05D0 Offset: 0x12CEBD0 VA: 0x1812D05D0
	private static void UpdateActive() { }

	// RVA: 0x12CDC60 Offset: 0x12CC260 VA: 0x1812CDC60
	private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources) { }

	// RVA: 0x12CF0C0 Offset: 0x12CD6C0 VA: 0x1812CF0C0
	private List<NavMeshBuildSource> CollectSources() { }

	// RVA: 0x12CDA20 Offset: 0x12CC020 VA: 0x1812CDA20
	private static Vector3 Abs(Vector3 v) { }

	// RVA: 0x12CFA10 Offset: 0x12CE010 VA: 0x1812CFA10
	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	// RVA: 0x12CE670 Offset: 0x12CCC70 VA: 0x1812CE670
	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) { }

	// RVA: 0x12CFE40 Offset: 0x12CE440 VA: 0x1812CFE40
	private bool HasTransformChanged() { }

	// RVA: 0x12D06A0 Offset: 0x12CECA0 VA: 0x1812D06A0
	private void UpdateDataIfTransformChanged() { }

	// RVA: 0x12D0DF0 Offset: 0x12CF3F0 VA: 0x1812D0DF0
	public void .ctor() { }

	// RVA: 0x12D0D90 Offset: 0x12CF390 VA: 0x1812D0D90
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

	// RVA: 0x12DD640 Offset: 0x12DBC40 VA: 0x1812DD640
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x12DD450 Offset: 0x12DBA50 VA: 0x1812DD450
	internal bool <AppendModifierVolumes>b__83_0(NavMeshModifierVolume x) { }

	// RVA: 0x12DD450 Offset: 0x12DBA50 VA: 0x1812DD450
	internal bool <CollectSources>b__84_0(NavMeshModifier x) { }

	// RVA: 0x12DD480 Offset: 0x12DBA80 VA: 0x1812DD480
	internal bool <CollectSources>b__84_1(NavMeshBuildSource x) { }

	// RVA: 0x12DD560 Offset: 0x12DBB60 VA: 0x1812DD560
	internal bool <CollectSources>b__84_2(NavMeshBuildSource x) { }

}

public class NavMeshTester : MonoBehaviour // TypeDefIndex: 8962
{	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

