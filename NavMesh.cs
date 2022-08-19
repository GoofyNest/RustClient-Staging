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
[NativeHeaderAttribute] // RVA: 0xB3650 Offset: 0xB2A50 VA: 0x1800B3650
[MovedFromAttribute] // RVA: 0xB3650 Offset: 0xB2A50 VA: 0x1800B3650
public sealed class NavMeshPath // TypeDefIndex: 4444
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal Vector3[] m_Corners; // 0x18

}

public static class NavMeshBuilder // TypeDefIndex: 4445
{	// Methods

	// RVA: 0x22FC3E0 Offset: 0x22FA9E0 VA: 0x1822FC3E0
	public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	// RVA: 0x22FC630 Offset: 0x22FAC30 VA: 0x1822FC630
	public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	// RVA: 0x22FC360 Offset: 0x22FA960 VA: 0x1822FC360
	private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	// RVA: 0x22FC0E0 Offset: 0x22FA6E0 VA: 0x1822FC0E0
	public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation) { }

	// RVA: 0x22FCA60 Offset: 0x22FB060 VA: 0x1822FCA60
	private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x22FC890 Offset: 0x22FAE90 VA: 0x1822FC890
	public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds) { }

	// RVA: 0x22FC820 Offset: 0x22FAE20 VA: 0x1822FC820
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x22FC2F0 Offset: 0x22FA8F0 VA: 0x1822FC2F0
	private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	// RVA: 0x22FC9F0 Offset: 0x22FAFF0 VA: 0x1822FC9F0
	private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

	// RVA: 0x22FC7B0 Offset: 0x22FADB0 VA: 0x1822FC7B0
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

}

public sealed class NavMeshAgent : Behaviour // TypeDefIndex: 4446
{	// Properties
	public bool isOnOffMeshLink { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xB3D60 Offset: 0xB3160 VA: 0x1800B3D60
	// RVA: 0x22FBDA0 Offset: 0x22FA3A0 VA: 0x1822FBDA0
	public bool get_isOnOffMeshLink() { }

}

public struct NavMeshHit // TypeDefIndex: 4448
{
// Namespace: UnityEngine.AI
[MovedFromAttribute] // RVA: 0xB3E80 Offset: 0xB3280 VA: 0x1800B3E80
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

	// RVA: 0x212C10 Offset: 0x212010 VA: 0x180212C10
	public Vector3 get_position() { }

	// RVA: 0x212C30 Offset: 0x212030 VA: 0x180212C30
	public Vector3 get_normal() { }

}

public sealed class NavMeshData : Object // TypeDefIndex: 4449
{	// Properties
	public Vector3 position { set; }
	public Quaternion rotation { set; }

	// Methods

	// RVA: 0x22FCC80 Offset: 0x22FB280 VA: 0x1822FCC80
	public void .ctor(int agentTypeID) { }

	[StaticAccessorAttribute] // RVA: 0xB4030 Offset: 0xB3430 VA: 0x1800B4030
	// RVA: 0x22FCC40 Offset: 0x22FB240 VA: 0x1822FCC40
	private static void Internal_Create(NavMeshData mono, int agentTypeID) { }

	// RVA: 0x22FCD60 Offset: 0x22FB360 VA: 0x1822FCD60
	public void set_position(Vector3 value) { }

	// RVA: 0x22FCE00 Offset: 0x22FB400 VA: 0x1822FCE00
	public void set_rotation(Quaternion value) { }

	// RVA: 0x22FCD10 Offset: 0x22FB310 VA: 0x1822FCD10
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x22FCDB0 Offset: 0x22FB3B0 VA: 0x1822FCDB0
	private void set_rotation_Injected(ref Quaternion value) { }

}

public struct NavMeshDataInstance // TypeDefIndex: 4450
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private int <id>k__BackingField; // 0x0

	// Properties
	public bool valid { get; }
	internal int id { get; set; }
	public Object owner { set; }

	// Methods

	// RVA: 0x23F010 Offset: 0x23E410 VA: 0x18023F010
	public bool get_valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	internal int get_id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	internal void set_id(int value) { }

	// RVA: 0x23EFD0 Offset: 0x23E3D0 VA: 0x18023EFD0
	public void Remove() { }

	// RVA: 0x23F060 Offset: 0x23E460 VA: 0x18023F060
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

	// RVA: 0x204FB0 Offset: 0x2043B0 VA: 0x180204FB0
	public void set_startPosition(Vector3 value) { }

	// RVA: 0x212D40 Offset: 0x212140 VA: 0x180212D40
	public void set_endPosition(Vector3 value) { }

	// RVA: 0x239620 Offset: 0x238A20 VA: 0x180239620
	public void set_costModifier(float value) { }

	// RVA: 0x23F140 Offset: 0x23E540 VA: 0x18023F140
	public void set_bidirectional(bool value) { }

	// RVA: 0x23D970 Offset: 0x23CD70 VA: 0x18023D970
	public void set_width(float value) { }

	// RVA: 0x2228A0 Offset: 0x221CA0 VA: 0x1802228A0
	public void set_area(int value) { }

	// RVA: 0xF3F80 Offset: 0xF3380 VA: 0x1800F3F80
	public void set_agentTypeID(int value) { }

}

public struct NavMeshLinkInstance // TypeDefIndex: 4452
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private int <id>k__BackingField; // 0x0

	// Properties
	public bool valid { get; }
	internal int id { get; set; }
	public Object owner { set; }

	// Methods

	// RVA: 0x23F190 Offset: 0x23E590 VA: 0x18023F190
	public bool get_valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	internal int get_id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	internal void set_id(int value) { }

	// RVA: 0x23F150 Offset: 0x23E550 VA: 0x18023F150
	public void Remove() { }

	// RVA: 0x23F1E0 Offset: 0x23E5E0 VA: 0x18023F1E0
	public void set_owner(Object value) { }

}

public struct NavMeshQueryFilter // TypeDefIndex: 4453
{	// Fields
	private const int k_AreaCostElementCount = 32;
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private float[] <costs>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private int <areaMask>k__BackingField; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private int <agentTypeID>k__BackingField; // 0xC

}

public static class NavMesh // TypeDefIndex: 4454
{	// Fields
	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; // 0x135B0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22FD4D0 Offset: 0x22FBAD0 VA: 0x1822FD4D0
	private static void Internal_CallOnNavMeshPreUpdate() { }

	// RVA: 0x22FD300 Offset: 0x22FB900 VA: 0x1822FD300
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData) { }

	// RVA: 0x22FD210 Offset: 0x22FB810 VA: 0x1822FD210
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] // RVA: 0xB4BA0 Offset: 0xB3FA0 VA: 0x1800B4BA0
	[NativeNameAttribute] // RVA: 0xB4BA0 Offset: 0xB3FA0 VA: 0x1800B4BA0
	// RVA: 0x22FD560 Offset: 0x22FBB60 VA: 0x1822FD560
	internal static bool IsValidNavMeshDataHandle(int handle) { }

	[StaticAccessorAttribute] // RVA: 0xB4E20 Offset: 0xB4220 VA: 0x1800B4E20
	// RVA: 0x22FD520 Offset: 0x22FBB20 VA: 0x1822FD520
	internal static bool IsValidLinkHandle(int handle) { }

	[StaticAccessorAttribute] // RVA: 0xB6280 Offset: 0xB5680 VA: 0x1800B6280
	[NativeNameAttribute] // RVA: 0xB6280 Offset: 0xB5680 VA: 0x1800B6280
	// RVA: 0x22FD490 Offset: 0x22FBA90 VA: 0x1822FD490
	internal static bool InternalSetOwner(int dataID, int ownerID) { }

	[StaticAccessorAttribute] // RVA: 0xB64A0 Offset: 0xB58A0 VA: 0x1800B64A0
	[NativeNameAttribute] // RVA: 0xB64A0 Offset: 0xB58A0 VA: 0x1800B64A0
	// RVA: 0x22FD450 Offset: 0x22FBA50 VA: 0x1822FD450
	internal static bool InternalSetLinkOwner(int linkID, int ownerID) { }

	[StaticAccessorAttribute] // RVA: 0xB6700 Offset: 0xB5B00 VA: 0x1800B6700
	[NativeNameAttribute] // RVA: 0xB6700 Offset: 0xB5B00 VA: 0x1800B6700
	// RVA: 0x22FD110 Offset: 0x22FB710 VA: 0x1822FD110
	internal static int AddNavMeshDataInternal(NavMeshData navMeshData) { }

	[StaticAccessorAttribute] // RVA: 0xB6700 Offset: 0xB5B00 VA: 0x1800B6700
	[NativeNameAttribute] // RVA: 0xB6700 Offset: 0xB5B00 VA: 0x1800B6700
	// RVA: 0x22FD1B0 Offset: 0x22FB7B0 VA: 0x1822FD1B0
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0xB69B0 Offset: 0xB5DB0 VA: 0x1800B69B0
	[StaticAccessorAttribute] // RVA: 0xB69B0 Offset: 0xB5DB0 VA: 0x1800B69B0
	// RVA: 0x22FD5E0 Offset: 0x22FBBE0 VA: 0x1822FD5E0
	internal static void RemoveNavMeshDataInternal(int handle) { }

	// RVA: 0x22FD090 Offset: 0x22FB690 VA: 0x1822FD090
	public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0xB6AE0 Offset: 0xB5EE0 VA: 0x1800B6AE0
	[StaticAccessorAttribute] // RVA: 0xB6AE0 Offset: 0xB5EE0 VA: 0x1800B6AE0
	// RVA: 0x22FD030 Offset: 0x22FB630 VA: 0x1822FD030
	internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] // RVA: 0xB6C80 Offset: 0xB6080 VA: 0x1800B6C80
	[NativeNameAttribute] // RVA: 0xB6C80 Offset: 0xB6080 VA: 0x1800B6C80
	// RVA: 0x22FD5A0 Offset: 0x22FBBA0 VA: 0x1822FD5A0
	internal static void RemoveLinkInternal(int handle) { }

	// RVA: 0x22FD3F0 Offset: 0x22FB9F0 VA: 0x1822FD3F0
	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) { }

	// RVA: 0x22FD150 Offset: 0x22FB750 VA: 0x1822FD150
	private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x22FCFD0 Offset: 0x22FB5D0 VA: 0x1822FCFD0
	private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x22FD3B0 Offset: 0x22FB9B0 VA: 0x1822FD3B0
	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) { }

}

public sealed class NavMesh.OnNavMeshPreUpdate : MulticastDelegate // TypeDefIndex: 4455
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A85B00 Offset: 0x1A84100 VA: 0x181A85B00 Slot: 12
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

	// RVA: 0x23EED0 Offset: 0x23E2D0 VA: 0x18023EED0
	public Matrix4x4 get_transform() { }

	// RVA: 0x23EFB0 Offset: 0x23E3B0 VA: 0x18023EFB0
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x23EE70 Offset: 0x23E270 VA: 0x18023EE70
	public Vector3 get_size() { }

	// RVA: 0x23EF10 Offset: 0x23E310 VA: 0x18023EF10
	public void set_size(Vector3 value) { }

	// RVA: 0x23EE60 Offset: 0x23E260 VA: 0x18023EE60
	public NavMeshBuildSourceShape get_shape() { }

	// RVA: 0x23EF00 Offset: 0x23E300 VA: 0x18023EF00
	public void set_shape(NavMeshBuildSourceShape value) { }

	// RVA: 0x1D2820 Offset: 0x1D1C20 VA: 0x1801D2820
	public void set_area(int value) { }

	// RVA: 0x23EE90 Offset: 0x23E290 VA: 0x18023EE90
	public Object get_sourceObject() { }

	// RVA: 0x23EF20 Offset: 0x23E320 VA: 0x18023EF20
	public void set_sourceObject(Object value) { }

	// RVA: 0x23EE20 Offset: 0x23E220 VA: 0x18023EE20
	public Component get_component() { }

	[StaticAccessorAttribute] // RVA: 0xB6F90 Offset: 0xB6390 VA: 0x1800B6F90
	// RVA: 0x22FBEC0 Offset: 0x22FA4C0 VA: 0x1822FBEC0
	private static Component InternalGetComponent(int instanceID) { }

	[StaticAccessorAttribute] // RVA: 0xB6F90 Offset: 0xB6390 VA: 0x1800B6F90
	// RVA: 0x22FBF00 Offset: 0x22FA500 VA: 0x1822FBF00
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

	// RVA: 0x23ED60 Offset: 0x23E160 VA: 0x18023ED60
	public void set_overrideArea(bool value) { }

	// RVA: 0x19DFE0 Offset: 0x19D3E0 VA: 0x18019DFE0
	public void set_area(int value) { }

	// RVA: 0x23ED50 Offset: 0x23E150 VA: 0x18023ED50
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x23ED70 Offset: 0x23E170 VA: 0x18023ED70
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

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	public int get_agentTypeID() { }

	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_agentTypeID(int value) { }

	// RVA: 0x23EE10 Offset: 0x23E210 VA: 0x18023EE10
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0x23D980 Offset: 0x23CD80 VA: 0x18023D980
	public void set_voxelSize(float value) { }

	// RVA: 0x23EE00 Offset: 0x23E200 VA: 0x18023EE00
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x1D8730 Offset: 0x1D7B30 VA: 0x1801D8730
	public void set_tileSize(int value) { }

}

public struct NavMeshBuildDebugSettings // TypeDefIndex: 4461
{	// Fields
	private byte m_Flags; // 0x0

}

public class NavMeshLink : MonoBehaviour // TypeDefIndex: 8143
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <UpdateOnTransformChanged>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_AgentTypeID; // 0x1C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 m_StartPoint; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 m_EndPoint; // 0x2C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_Width; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_CostModifier; // 0x3C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_Bidirectional; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_AutoUpdatePosition; // 0x41
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00
	public void set_UpdateOnTransformChanged(bool value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_agentTypeID() { }

	// RVA: 0x12CCDF0 Offset: 0x12CB3F0 VA: 0x1812CCDF0
	public void set_agentTypeID(int value) { }

	// RVA: 0x12CCDD0 Offset: 0x12CB3D0 VA: 0x1812CCDD0
	public Vector3 get_startPoint() { }

	// RVA: 0x12CCEF0 Offset: 0x12CB4F0 VA: 0x1812CCEF0
	public void set_startPoint(Vector3 value) { }

	// RVA: 0x12CCDB0 Offset: 0x12CB3B0 VA: 0x1812CCDB0
	public Vector3 get_endPoint() { }

	// RVA: 0x12CCEB0 Offset: 0x12CB4B0 VA: 0x1812CCEB0
	public void set_endPoint(Vector3 value) { }

	// RVA: 0x10B7E20 Offset: 0x10B6420 VA: 0x1810B7E20
	public float get_width() { }

	// RVA: 0x12CCF30 Offset: 0x12CB530 VA: 0x1812CCF30
	public void set_width(float value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public int get_costModifier() { }

	// RVA: 0x12CCE80 Offset: 0x12CB480 VA: 0x1812CCE80
	public void set_costModifier(int value) { }

	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0
	public bool get_bidirectional() { }

	// RVA: 0x12CCE50 Offset: 0x12CB450 VA: 0x1812CCE50
	public void set_bidirectional(bool value) { }

	// RVA: 0xEE6E90 Offset: 0xEE5490 VA: 0x180EE6E90
	public bool get_autoUpdate() { }

	// RVA: 0x12CCA30 Offset: 0x12CB030 VA: 0x1812CCA30
	public void set_autoUpdate(bool value) { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_area() { }

	// RVA: 0x12CCE20 Offset: 0x12CB420 VA: 0x1812CCE20
	public void set_area(int value) { }

	// RVA: 0x12CC880 Offset: 0x12CAE80 VA: 0x1812CC880
	private void OnEnable() { }

	// RVA: 0x12CC820 Offset: 0x12CAE20 VA: 0x1812CC820
	private void OnDisable() { }

	// RVA: 0x12CC7F0 Offset: 0x12CADF0 VA: 0x1812CC7F0
	public void UpdateLink() { }

	// RVA: 0x12CC560 Offset: 0x12CAB60 VA: 0x1812CC560
	private static void AddTracking(NavMeshLink link) { }

	// RVA: 0x12CC900 Offset: 0x12CAF00 VA: 0x1812CC900
	private static void RemoveTracking(NavMeshLink link) { }

	// RVA: 0x12CCA30 Offset: 0x12CB030 VA: 0x1812CCA30
	private void SetAutoUpdate(bool value) { }

	// RVA: 0x12CC350 Offset: 0x12CA950 VA: 0x1812CC350
	private void AddLink() { }

	// RVA: 0x12CC6B0 Offset: 0x12CACB0 VA: 0x1812CC6B0
	private bool HasTransformChanged() { }

	// RVA: 0x12CC7F0 Offset: 0x12CADF0 VA: 0x1812CC7F0
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x12CCAD0 Offset: 0x12CB0D0 VA: 0x1812CCAD0
	private static void UpdateTrackedInstances() { }

	// RVA: 0x12CCC90 Offset: 0x12CB290 VA: 0x1812CCC90
	public void .ctor() { }

	// RVA: 0x12CCC30 Offset: 0x12CB230 VA: 0x1812CCC30
	private static void .cctor() { }

}

public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 8144
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_OverrideArea; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_Area; // 0x1C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_IgnoreFromBuild; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private List<int> m_AffectedAgents; // 0x28
	private static readonly List<NavMeshModifier> s_NavMeshModifiers; // 0x0

	// Properties
	public bool overrideArea { get; set; }
	public int area { get; set; }
	public bool ignoreFromBuild { get; set; }
	public static List<NavMeshModifier> activeModifiers { get; }

	// Methods

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_overrideArea() { }

	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00
	public void set_overrideArea(bool value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_area() { }

	// RVA: 0x95F9F0 Offset: 0x95DFF0 VA: 0x18095F9F0
	public void set_area(int value) { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public bool get_ignoreFromBuild() { }

	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x12CD700 Offset: 0x12CBD00 VA: 0x1812CD700
	public static List<NavMeshModifier> get_activeModifiers() { }

	// RVA: 0x12CD510 Offset: 0x12CBB10 VA: 0x1812CD510
	private void OnEnable() { }

	// RVA: 0x12CD490 Offset: 0x12CBA90 VA: 0x1812CD490
	private void OnDisable() { }

	// RVA: 0x12CD3F0 Offset: 0x12CB9F0 VA: 0x1812CD3F0
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x12CD640 Offset: 0x12CBC40 VA: 0x1812CD640
	public void .ctor() { }

	// RVA: 0x12CD5E0 Offset: 0x12CBBE0 VA: 0x1812CD5E0
	private static void .cctor() { }

}

public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 8145
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 m_Size; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 m_Center; // 0x24
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_Area; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private List<int> m_AffectedAgents; // 0x38
	private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; // 0x0

	// Properties
	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public int area { get; set; }
	public static List<NavMeshModifierVolume> activeModifiers { get; }

	// Methods

	// RVA: 0x12CD3C0 Offset: 0x12CB9C0 VA: 0x1812CD3C0
	public Vector3 get_size() { }

	// RVA: 0x12CD3E0 Offset: 0x12CB9E0 VA: 0x1812CD3E0
	public void set_size(Vector3 value) { }

	// RVA: 0x10745E0 Offset: 0x1072BE0 VA: 0x1810745E0
	public Vector3 get_center() { }

	// RVA: 0x10747C0 Offset: 0x1072DC0 VA: 0x1810747C0
	public void set_center(Vector3 value) { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	public int get_area() { }

	// RVA: 0xA392A0 Offset: 0xA378A0 VA: 0x180A392A0
	public void set_area(int value) { }

	// RVA: 0x12CD360 Offset: 0x12CB960 VA: 0x1812CD360
	public static List<NavMeshModifierVolume> get_activeModifiers() { }

	// RVA: 0x12CD140 Offset: 0x12CB740 VA: 0x1812CD140
	private void OnEnable() { }

	// RVA: 0x12CD0C0 Offset: 0x12CB6C0 VA: 0x1812CD0C0
	private void OnDisable() { }

	// RVA: 0x12CCFD0 Offset: 0x12CB5D0 VA: 0x1812CCFD0
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x12CCF60 Offset: 0x12CB560 VA: 0x1812CCF60
	public void AddAgentType(int agentTypeID) { }

	// RVA: 0x12CD070 Offset: 0x12CB670 VA: 0x1812CD070
	public void ClearAgentTypes() { }

	// RVA: 0x12CD270 Offset: 0x12CB870 VA: 0x1812CD270
	public void .ctor() { }

	// RVA: 0x12CD210 Offset: 0x12CB810 VA: 0x1812CD210
	private static void .cctor() { }

}

public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 8147
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <UpdateOnTransformChanged>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_AgentTypeID; // 0x1C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private CollectObjects m_CollectObjects; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 m_Size; // 0x24
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 m_Center; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private LayerMask m_LayerMask; // 0x3C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private NavMeshCollectGeometry m_UseGeometry; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_DefaultArea; // 0x44
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_IgnoreNavMeshAgent; // 0x48
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_IgnoreNavMeshObstacle; // 0x49
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_OverrideTileSize; // 0x4A
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int m_TileSize; // 0x4C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_OverrideVoxelSize; // 0x50
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_VoxelSize; // 0x54
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_BuildHeightMesh; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0x968E0 Offset: 0x95CE0 VA: 0x1800968E0
	[SerializeField] // RVA: 0x968E0 Offset: 0x95CE0 VA: 0x1800968E0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00
	public void set_UpdateOnTransformChanged(bool value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_agentTypeID() { }

	// RVA: 0x95F9F0 Offset: 0x95DFF0 VA: 0x18095F9F0
	public void set_agentTypeID(int value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public CollectObjects get_collectObjects() { }

	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	public void set_collectObjects(CollectObjects value) { }

	// RVA: 0x10745E0 Offset: 0x1072BE0 VA: 0x1810745E0
	public Vector3 get_size() { }

	// RVA: 0x10747C0 Offset: 0x1072DC0 VA: 0x1810747C0
	public void set_size(Vector3 value) { }

	// RVA: 0x12D0CC0 Offset: 0x12CF2C0 VA: 0x1812D0CC0
	public Vector3 get_center() { }

	// RVA: 0x12D0CE0 Offset: 0x12CF2E0 VA: 0x1812D0CE0
	public void set_center(Vector3 value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public LayerMask get_layerMask() { }

	// RVA: 0x8C1070 Offset: 0x8BF670 VA: 0x1808C1070
	public void set_layerMask(LayerMask value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public NavMeshCollectGeometry get_useGeometry() { }

	// RVA: 0x684160 Offset: 0x682760 VA: 0x180684160
	public void set_useGeometry(NavMeshCollectGeometry value) { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_defaultArea() { }

	// RVA: 0x8C0D00 Offset: 0x8BF300 VA: 0x1808C0D00
	public void set_defaultArea(int value) { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_ignoreNavMeshAgent() { }

	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	public void set_ignoreNavMeshAgent(bool value) { }

	// RVA: 0xBA1AA0 Offset: 0xBA00A0 VA: 0x180BA1AA0
	public bool get_ignoreNavMeshObstacle() { }

	// RVA: 0x82D7F0 Offset: 0x82BDF0 VA: 0x18082D7F0
	public void set_ignoreNavMeshObstacle(bool value) { }

	// RVA: 0xBA1A90 Offset: 0xBA0090 VA: 0x180BA1A90
	public bool get_overrideTileSize() { }

	// RVA: 0x12387E0 Offset: 0x1236DE0 VA: 0x1812387E0
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40
	public int get_tileSize() { }

	// RVA: 0x59A0F0 Offset: 0x5986F0 VA: 0x18059A0F0
	public void set_tileSize(int value) { }

	// RVA: 0x77B0E0 Offset: 0x7796E0 VA: 0x18077B0E0
	public bool get_overrideVoxelSize() { }

	// RVA: 0xE68DF0 Offset: 0xE673F0 VA: 0x180E68DF0
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0xFCF350 Offset: 0xFCD950 VA: 0x180FCF350
	public float get_voxelSize() { }

	// RVA: 0x12D0CF0 Offset: 0x12CF2F0 VA: 0x1812D0CF0
	public void set_voxelSize(float value) { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_buildHeightMesh() { }

	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	public void set_buildHeightMesh(bool value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public NavMeshData get_navMeshData() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_navMeshData(NavMeshData value) { }

	// RVA: 0x12D0C60 Offset: 0x12CF260 VA: 0x1812D0C60
	public static List<NavMeshSurface> get_activeSurfaces() { }

	// RVA: 0x12CFE40 Offset: 0x12CE440 VA: 0x1812CFE40
	private void OnEnable() { }

	// RVA: 0x12CFCC0 Offset: 0x12CE2C0 VA: 0x1812CFCC0
	private void OnDisable() { }

	// RVA: 0x12CD810 Offset: 0x12CBE10 VA: 0x1812CD810
	public void AddData() { }

	// RVA: 0x12D01C0 Offset: 0x12CE7C0 VA: 0x1812D01C0
	public void RemoveData() { }

	// RVA: 0x12CF600 Offset: 0x12CDC00 VA: 0x1812CF600
	public NavMeshBuildSettings GetBuildSettings() { }

	// RVA: 0x12CE020 Offset: 0x12CC620 VA: 0x1812CE020
	public void BuildNavMesh() { }

	// RVA: 0x12CE0A0 Offset: 0x12CC6A0 VA: 0x1812CE0A0
	public void BuildNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds, NavMeshBuildSettings buildSettings) { }

	// RVA: 0x12D0540 Offset: 0x12CEB40 VA: 0x1812D0540
	public AsyncOperation UpdateNavMesh() { }

	// RVA: 0x12D0770 Offset: 0x12CED70 VA: 0x1812D0770
	public AsyncOperation UpdateNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds) { }

	// RVA: 0x12D0570 Offset: 0x12CEB70 VA: 0x1812D0570
	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

	// RVA: 0x12D0020 Offset: 0x12CE620 VA: 0x1812D0020
	private static void Register(NavMeshSurface surface) { }

	// RVA: 0x12D01E0 Offset: 0x12CE7E0 VA: 0x1812D01E0
	private static void Unregister(NavMeshSurface surface) { }

	// RVA: 0x12D0310 Offset: 0x12CE910 VA: 0x1812D0310
	private static void UpdateActive() { }

	// RVA: 0x12CD9A0 Offset: 0x12CBFA0 VA: 0x1812CD9A0
	private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources) { }

	// RVA: 0x12CEE00 Offset: 0x12CD400 VA: 0x1812CEE00
	private List<NavMeshBuildSource> CollectSources() { }

	// RVA: 0x12CD760 Offset: 0x12CBD60 VA: 0x1812CD760
	private static Vector3 Abs(Vector3 v) { }

	// RVA: 0x12CF750 Offset: 0x12CDD50 VA: 0x1812CF750
	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	// RVA: 0x12CE3B0 Offset: 0x12CC9B0 VA: 0x1812CE3B0
	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) { }

	// RVA: 0x12CFB80 Offset: 0x12CE180 VA: 0x1812CFB80
	private bool HasTransformChanged() { }

	// RVA: 0x12D03E0 Offset: 0x12CE9E0 VA: 0x1812D03E0
	private void UpdateDataIfTransformChanged() { }

	// RVA: 0x12D0B30 Offset: 0x12CF130 VA: 0x1812D0B30
	public void .ctor() { }

	// RVA: 0x12D0AD0 Offset: 0x12CF0D0 VA: 0x1812D0AD0
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

	// RVA: 0x12DD380 Offset: 0x12DB980 VA: 0x1812DD380
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x12DD190 Offset: 0x12DB790 VA: 0x1812DD190
	internal bool <AppendModifierVolumes>b__83_0(NavMeshModifierVolume x) { }

	// RVA: 0x12DD190 Offset: 0x12DB790 VA: 0x1812DD190
	internal bool <CollectSources>b__84_0(NavMeshModifier x) { }

	// RVA: 0x12DD1C0 Offset: 0x12DB7C0 VA: 0x1812DD1C0
	internal bool <CollectSources>b__84_1(NavMeshBuildSource x) { }

	// RVA: 0x12DD2A0 Offset: 0x12DB8A0 VA: 0x1812DD2A0
	internal bool <CollectSources>b__84_2(NavMeshBuildSource x) { }

}

public class NavMeshTester : MonoBehaviour // TypeDefIndex: 8962
{	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

