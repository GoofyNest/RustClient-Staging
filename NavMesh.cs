public sealed class NavMeshPath // TypeDefIndex: 4444
{
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 // TypeDefIndex: 4438

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 // TypeDefIndex: 4439

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 4440

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 // TypeDefIndex: 4441

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 // TypeDefIndex: 4442

internal class <Module> // TypeDefIndex: 4443

[NativeHeaderAttribute] // RVA: 0xB3720 Offset: 0xB2B20 VA: 0x1800B3720
[MovedFromAttribute] // RVA: 0xB3720 Offset: 0xB2B20 VA: 0x1800B3720
public sealed class NavMeshPath // TypeDefIndex: 4444
	internal IntPtr m_Ptr; // 0x10
	internal Vector3[] m_Corners; // 0x18

}

public static class NavMeshBuilder // TypeDefIndex: 4445
{
	public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation) { }

	private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds) { }

	private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

	private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

}

public sealed class NavMeshAgent : Behaviour // TypeDefIndex: 4446
{	public bool isOnOffMeshLink { get; }


	[NativeNameAttribute] // RVA: 0xB3DA0 Offset: 0xB31A0 VA: 0x1800B3DA0
	public bool get_isOnOffMeshLink() { }

}

public struct NavMeshHit // TypeDefIndex: 4448
{
[MovedFromAttribute] // RVA: 0xB3F20 Offset: 0xB3320 VA: 0x1800B3F20
public struct NavMeshHit // TypeDefIndex: 4448
	private Vector3 m_Position; // 0x0
	private Vector3 m_Normal; // 0xC
	private float m_Distance; // 0x18
	private int m_Mask; // 0x1C
	private int m_Hit; // 0x20

	public Vector3 position { get; }
	public Vector3 normal { get; }


	public Vector3 get_position() { }

	public Vector3 get_normal() { }

}

public sealed class NavMeshData : Object // TypeDefIndex: 4449
{	public Vector3 position { set; }
	public Quaternion rotation { set; }


	public void .ctor(int agentTypeID) { }

	[StaticAccessorAttribute] // RVA: 0xB4070 Offset: 0xB3470 VA: 0x1800B4070
	private static void Internal_Create(NavMeshData mono, int agentTypeID) { }

	public void set_position(Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private void set_position_Injected(ref Vector3 value) { }

	private void set_rotation_Injected(ref Quaternion value) { }

}

public struct NavMeshDataInstance // TypeDefIndex: 4450
{	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private int <id>k__BackingField; // 0x0

	public bool valid { get; }
	internal int id { get; set; }
	public Object owner { set; }


	public bool get_valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal int get_id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal void set_id(int value) { }

	public void Remove() { }

	public void set_owner(Object value) { }

}

public struct NavMeshLinkData // TypeDefIndex: 4451
{	private Vector3 m_StartPosition; // 0x0
	private Vector3 m_EndPosition; // 0xC
	private float m_CostModifier; // 0x18
	private int m_Bidirectional; // 0x1C
	private float m_Width; // 0x20
	private int m_Area; // 0x24
	private int m_AgentTypeID; // 0x28

	public Vector3 startPosition { set; }
	public Vector3 endPosition { set; }
	public float costModifier { set; }
	public bool bidirectional { set; }
	public float width { set; }
	public int area { set; }
	public int agentTypeID { set; }


	public void set_startPosition(Vector3 value) { }

	public void set_endPosition(Vector3 value) { }

	public void set_costModifier(float value) { }

	public void set_bidirectional(bool value) { }

	public void set_width(float value) { }

	public void set_area(int value) { }

	public void set_agentTypeID(int value) { }

}

public struct NavMeshLinkInstance // TypeDefIndex: 4452
{	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private int <id>k__BackingField; // 0x0

	public bool valid { get; }
	internal int id { get; set; }
	public Object owner { set; }


	public bool get_valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal int get_id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal void set_id(int value) { }

	public void Remove() { }

	public void set_owner(Object value) { }

}

public struct NavMeshQueryFilter // TypeDefIndex: 4453
{	private const int k_AreaCostElementCount = 32;
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
{	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; // 0x2B10510


	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void Internal_CallOnNavMeshPreUpdate() { }

	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData) { }

	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] // RVA: 0xB4C40 Offset: 0xB4040 VA: 0x1800B4C40
	[NativeNameAttribute] // RVA: 0xB4C40 Offset: 0xB4040 VA: 0x1800B4C40
	internal static bool IsValidNavMeshDataHandle(int handle) { }

	[StaticAccessorAttribute] // RVA: 0xB4EC0 Offset: 0xB42C0 VA: 0x1800B4EC0
	internal static bool IsValidLinkHandle(int handle) { }

	[StaticAccessorAttribute] // RVA: 0xB6320 Offset: 0xB5720 VA: 0x1800B6320
	[NativeNameAttribute] // RVA: 0xB6320 Offset: 0xB5720 VA: 0x1800B6320
	internal static bool InternalSetOwner(int dataID, int ownerID) { }

	[StaticAccessorAttribute] // RVA: 0xB6560 Offset: 0xB5960 VA: 0x1800B6560
	[NativeNameAttribute] // RVA: 0xB6560 Offset: 0xB5960 VA: 0x1800B6560
	internal static bool InternalSetLinkOwner(int linkID, int ownerID) { }

	[StaticAccessorAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	[NativeNameAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	internal static int AddNavMeshDataInternal(NavMeshData navMeshData) { }

	[StaticAccessorAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	[NativeNameAttribute] // RVA: 0xB67D0 Offset: 0xB5BD0 VA: 0x1800B67D0
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0xB6A50 Offset: 0xB5E50 VA: 0x1800B6A50
	[StaticAccessorAttribute] // RVA: 0xB6A50 Offset: 0xB5E50 VA: 0x1800B6A50
	internal static void RemoveNavMeshDataInternal(int handle) { }

	public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0xB6B40 Offset: 0xB5F40 VA: 0x1800B6B40
	[StaticAccessorAttribute] // RVA: 0xB6B40 Offset: 0xB5F40 VA: 0x1800B6B40
	internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] // RVA: 0xB6CC0 Offset: 0xB60C0 VA: 0x1800B6CC0
	[NativeNameAttribute] // RVA: 0xB6CC0 Offset: 0xB60C0 VA: 0x1800B6CC0
	internal static void RemoveLinkInternal(int handle) { }

	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) { }

	private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) { }

	private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) { }

	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) { }

}

public sealed class NavMesh.OnNavMeshPreUpdate : MulticastDelegate // TypeDefIndex: 4455
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum NavMeshBuildSourceShape // TypeDefIndex: 4456
{	public int value__; // 0x0
	public const NavMeshBuildSourceShape Mesh = 0;
	public const NavMeshBuildSourceShape Terrain = 1;
	public const NavMeshBuildSourceShape Box = 2;
	public const NavMeshBuildSourceShape Sphere = 3;
	public const NavMeshBuildSourceShape Capsule = 4;
	public const NavMeshBuildSourceShape ModifierBox = 5;

}

public enum NavMeshCollectGeometry // TypeDefIndex: 4457
{	public int value__; // 0x0
	public const NavMeshCollectGeometry RenderMeshes = 0;
	public const NavMeshCollectGeometry PhysicsColliders = 1;

}

public struct NavMeshBuildSource // TypeDefIndex: 4458
{	private Matrix4x4 m_Transform; // 0x0
	private Vector3 m_Size; // 0x40
	private NavMeshBuildSourceShape m_Shape; // 0x4C
	private int m_Area; // 0x50
	private int m_InstanceID; // 0x54
	private int m_ComponentID; // 0x58

	public Matrix4x4 transform { get; set; }
	public Vector3 size { get; set; }
	public NavMeshBuildSourceShape shape { get; set; }
	public int area { set; }
	public Object sourceObject { get; set; }
	public Component component { get; }


	public Matrix4x4 get_transform() { }

	public void set_transform(Matrix4x4 value) { }

	public Vector3 get_size() { }

	public void set_size(Vector3 value) { }

	public NavMeshBuildSourceShape get_shape() { }

	public void set_shape(NavMeshBuildSourceShape value) { }

	public void set_area(int value) { }

	public Object get_sourceObject() { }

	public void set_sourceObject(Object value) { }

	public Component get_component() { }

	[StaticAccessorAttribute] // RVA: 0xB7030 Offset: 0xB6430 VA: 0x1800B7030
	private static Component InternalGetComponent(int instanceID) { }

	[StaticAccessorAttribute] // RVA: 0xB7030 Offset: 0xB6430 VA: 0x1800B7030
	private static Object InternalGetObject(int instanceID) { }

}

public struct NavMeshBuildMarkup // TypeDefIndex: 4459
{	private int m_OverrideArea; // 0x0
	private int m_Area; // 0x4
	private int m_IgnoreFromBuild; // 0x8
	private int m_InstanceID; // 0xC

	public bool overrideArea { set; }
	public int area { set; }
	public bool ignoreFromBuild { set; }
	public Transform root { set; }


	public void set_overrideArea(bool value) { }

	public void set_area(int value) { }

	public void set_ignoreFromBuild(bool value) { }

	public void set_root(Transform value) { }

}

public struct NavMeshBuildSettings // TypeDefIndex: 4460
{	private int m_AgentTypeID; // 0x0
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

	public int agentTypeID { get; set; }
	public bool overrideVoxelSize { set; }
	public float voxelSize { set; }
	public bool overrideTileSize { set; }
	public int tileSize { set; }


	public int get_agentTypeID() { }

	public void set_agentTypeID(int value) { }

	public void set_overrideVoxelSize(bool value) { }

	public void set_voxelSize(float value) { }

	public void set_overrideTileSize(bool value) { }

	public void set_tileSize(int value) { }

}

public struct NavMeshBuildDebugSettings // TypeDefIndex: 4461
{	private byte m_Flags; // 0x0

}

public class NavMeshLink : MonoBehaviour // TypeDefIndex: 8143
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	public bool UpdateOnTransformChanged { get; set; }
	public int agentTypeID { get; set; }
	public Vector3 startPoint { get; set; }
	public Vector3 endPoint { get; set; }
	public float width { get; set; }
	public int costModifier { get; set; }
	public bool bidirectional { get; set; }
	public bool autoUpdate { get; set; }
	public int area { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_UpdateOnTransformChanged(bool value) { }

	public int get_agentTypeID() { }

	public void set_agentTypeID(int value) { }

	public Vector3 get_startPoint() { }

	public void set_startPoint(Vector3 value) { }

	public Vector3 get_endPoint() { }

	public void set_endPoint(Vector3 value) { }

	public float get_width() { }

	public void set_width(float value) { }

	public int get_costModifier() { }

	public void set_costModifier(int value) { }

	public bool get_bidirectional() { }

	public void set_bidirectional(bool value) { }

	public bool get_autoUpdate() { }

	public void set_autoUpdate(bool value) { }

	public int get_area() { }

	public void set_area(int value) { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void UpdateLink() { }

	private static void AddTracking(NavMeshLink link) { }

	private static void RemoveTracking(NavMeshLink link) { }

	private void SetAutoUpdate(bool value) { }

	private void AddLink() { }

	private bool HasTransformChanged() { }

	private void OnDidApplyAnimationProperties() { }

	private static void UpdateTrackedInstances() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 8144
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_OverrideArea; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_Area; // 0x1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_IgnoreFromBuild; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<int> m_AffectedAgents; // 0x28
	private static readonly List<NavMeshModifier> s_NavMeshModifiers; // 0x0

	public bool overrideArea { get; set; }
	public int area { get; set; }
	public bool ignoreFromBuild { get; set; }
	public static List<NavMeshModifier> activeModifiers { get; }


	public bool get_overrideArea() { }

	public void set_overrideArea(bool value) { }

	public int get_area() { }

	public void set_area(int value) { }

	public bool get_ignoreFromBuild() { }

	public void set_ignoreFromBuild(bool value) { }

	public static List<NavMeshModifier> get_activeModifiers() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public bool AffectsAgentType(int agentTypeID) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 8145
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 m_Size; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 m_Center; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_Area; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private List<int> m_AffectedAgents; // 0x38
	private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; // 0x0

	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public int area { get; set; }
	public static List<NavMeshModifierVolume> activeModifiers { get; }


	public Vector3 get_size() { }

	public void set_size(Vector3 value) { }

	public Vector3 get_center() { }

	public void set_center(Vector3 value) { }

	public int get_area() { }

	public void set_area(int value) { }

	public static List<NavMeshModifierVolume> get_activeModifiers() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public bool AffectsAgentType(int agentTypeID) { }

	public void AddAgentType(int agentTypeID) { }

	public void ClearAgentTypes() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 8147
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_UpdateOnTransformChanged(bool value) { }

	public int get_agentTypeID() { }

	public void set_agentTypeID(int value) { }

	public CollectObjects get_collectObjects() { }

	public void set_collectObjects(CollectObjects value) { }

	public Vector3 get_size() { }

	public void set_size(Vector3 value) { }

	public Vector3 get_center() { }

	public void set_center(Vector3 value) { }

	public LayerMask get_layerMask() { }

	public void set_layerMask(LayerMask value) { }

	public NavMeshCollectGeometry get_useGeometry() { }

	public void set_useGeometry(NavMeshCollectGeometry value) { }

	public int get_defaultArea() { }

	public void set_defaultArea(int value) { }

	public bool get_ignoreNavMeshAgent() { }

	public void set_ignoreNavMeshAgent(bool value) { }

	public bool get_ignoreNavMeshObstacle() { }

	public void set_ignoreNavMeshObstacle(bool value) { }

	public bool get_overrideTileSize() { }

	public void set_overrideTileSize(bool value) { }

	public int get_tileSize() { }

	public void set_tileSize(int value) { }

	public bool get_overrideVoxelSize() { }

	public void set_overrideVoxelSize(bool value) { }

	public float get_voxelSize() { }

	public void set_voxelSize(float value) { }

	public bool get_buildHeightMesh() { }

	public void set_buildHeightMesh(bool value) { }

	public NavMeshData get_navMeshData() { }

	public void set_navMeshData(NavMeshData value) { }

	public static List<NavMeshSurface> get_activeSurfaces() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void AddData() { }

	public void RemoveData() { }

	public NavMeshBuildSettings GetBuildSettings() { }

	public void BuildNavMesh() { }

	public void BuildNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds, NavMeshBuildSettings buildSettings) { }

	public AsyncOperation UpdateNavMesh() { }

	public AsyncOperation UpdateNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds) { }

	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

	private static void Register(NavMeshSurface surface) { }

	private static void Unregister(NavMeshSurface surface) { }

	private static void UpdateActive() { }

	private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources) { }

	private List<NavMeshBuildSource> CollectSources() { }

	private static Vector3 Abs(Vector3 v) { }

	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) { }

	private bool HasTransformChanged() { }

	private void UpdateDataIfTransformChanged() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class NavMeshSurface.<>c // TypeDefIndex: 8148
{	public static readonly NavMeshSurface.<>c <>9; // 0x0
	public static Predicate<NavMeshModifierVolume> <>9__83_0; // 0x8
	public static Predicate<NavMeshModifier> <>9__84_0; // 0x10
	public static Predicate<NavMeshBuildSource> <>9__84_1; // 0x18
	public static Predicate<NavMeshBuildSource> <>9__84_2; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <AppendModifierVolumes>b__83_0(NavMeshModifierVolume x) { }

	internal bool <CollectSources>b__84_0(NavMeshModifier x) { }

	internal bool <CollectSources>b__84_1(NavMeshBuildSource x) { }

	internal bool <CollectSources>b__84_2(NavMeshBuildSource x) { }

}

public class NavMeshTester : MonoBehaviour // TypeDefIndex: 8962
{
	public void .ctor() { }

}

