public class DungeonNavmesh : FacepunchBehaviour, IServerComponent // TypeDefIndex: 8956
{	public int NavMeshAgentTypeIndex; // 0x18
	[TooltipAttribute] // RVA: 0xC7070 Offset: 0xC6470 VA: 0x1800C7070
	public string DefaultAreaName; // 0x20
	public float NavmeshResolutionModifier; // 0x28
	[TooltipAttribute] // RVA: 0xC7110 Offset: 0xC6510 VA: 0x1800C7110
	public Bounds Bounds; // 0x2C
	public NavMeshData NavMeshData; // 0x48
	public NavMeshDataInstance NavMeshDataInstance; // 0x50
	public LayerMask LayerMask; // 0x54
	public NavMeshCollectGeometry NavMeshCollectGeometry; // 0x58
	public static List<DungeonNavmesh> Instances; // 0x0


	public void .ctor() { }

	private static void .cctor() { }

}

public class DungeonBaseInfo : LandmarkInfo // TypeDefIndex: 10340
{	internal List<GameObject> Links; // 0x30
	internal List<DungeonBaseFloor> Floors; // 0x38


	public float Distance(Vector3 position) { }

	public float SqrDistance(Vector3 position) { }

	public void Add(DungeonBaseLink link) { }

	protected override void Awake() { }

	protected void Start() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int <Add>b__4_0(DungeonBaseFloor l, DungeonBaseFloor r) { }

}

public class DungeonBaseFloor // TypeDefIndex: 10341
{	public List<DungeonBaseLink> Links; // 0x10


	public float Distance(Vector3 position) { }

	public float SignedDistance(Vector3 position) { }

	public void .ctor() { }

}

public class DungeonBaseLandmarkInfo : LandmarkInfo // TypeDefIndex: 10342
{	private DungeonBaseLink baseLink; // 0x30
	private Nullable<MapLayer> layer; // 0x38

	public override MapLayer MapLayer { get; }


	protected override void Awake() { }

	public override MapLayer get_MapLayer() { }

	public void .ctor() { }

}

public class DungeonBaseLink : MonoBehaviour // TypeDefIndex: 10343
{	public DungeonBaseLinkType Type; // 0x18
	public int Cost; // 0x1C
	public int MaxFloor; // 0x20
	public int MaxCountLocal; // 0x24
	public int MaxCountGlobal; // 0x28
	[TooltipAttribute] // RVA: 0xCC830 Offset: 0xCBC30 VA: 0x1800CC830
	public int MaxCountIdentifier; // 0x2C
	internal DungeonBaseInfo Dungeon; // 0x30
	public MeshRenderer[] MapRenderers; // 0x38
	private List<DungeonBaseSocket> sockets; // 0x40
	private List<DungeonVolume> volumes; // 0x48

	internal List<DungeonBaseSocket> Sockets { get; }
	internal List<DungeonVolume> Volumes { get; }


	internal List<DungeonBaseSocket> get_Sockets() { }

	internal List<DungeonVolume> get_Volumes() { }

	protected void Start() { }

	public void .ctor() { }

}

public enum DungeonBaseLinkType // TypeDefIndex: 10344
{	public int value__; // 0x0
	public const DungeonBaseLinkType Room = 0;
	public const DungeonBaseLinkType Corridor = 1;
	public const DungeonBaseLinkType End = 2;

}

public class DungeonBaseSocket : MonoBehaviour // TypeDefIndex: 10345
{	public DungeonBaseSocketType Type; // 0x18
	public bool Male; // 0x1C
	public bool Female; // 0x1D


	public void .ctor() { }

}

public enum DungeonBaseSocketType // TypeDefIndex: 10346
{	public int value__; // 0x0
	public const DungeonBaseSocketType Horizontal = 0;
	public const DungeonBaseSocketType Vertical = 1;
	public const DungeonBaseSocketType Pillar = 2;

}

public class DungeonBaseTransition : MonoBehaviour // TypeDefIndex: 10347
{	public DungeonBaseSocketType Type; // 0x18
	public DungeonBaseLinkType Neighbour1; // 0x1C
	public DungeonBaseLinkType Neighbour2; // 0x20


	public void .ctor() { }

}

public class DungeonGridCell : MonoBehaviour // TypeDefIndex: 10348
{	public DungeonGridConnectionType North; // 0x18
	public DungeonGridConnectionType South; // 0x1C
	public DungeonGridConnectionType West; // 0x20
	public DungeonGridConnectionType East; // 0x24
	public DungeonGridConnectionVariant NorthVariant; // 0x28
	public DungeonGridConnectionVariant SouthVariant; // 0x2C
	public DungeonGridConnectionVariant WestVariant; // 0x30
	public DungeonGridConnectionVariant EastVariant; // 0x34
	public GameObjectRef[] AvoidNeighbours; // 0x38
	public MeshRenderer[] MapRenderers; // 0x40


	public bool ShouldAvoid(uint id) { }

	protected void Awake() { }

	public void .ctor() { }

}

public enum DungeonGridConnectionType // TypeDefIndex: 10349
{	public int value__; // 0x0
	public const DungeonGridConnectionType None = 0;
	public const DungeonGridConnectionType TrainTunnel = 1;

}

public enum DungeonGridConnectionVariant // TypeDefIndex: 10350
{	public int value__; // 0x0
	public const DungeonGridConnectionVariant A = 0;
	public const DungeonGridConnectionVariant B = 1;

}

public struct DungeonGridConnectionHash // TypeDefIndex: 10351
{	public bool North; // 0x0
	public bool South; // 0x1
	public bool West; // 0x2
	public bool East; // 0x3

	public int Value { get; }


	public int get_Value() { }

}

public class DungeonGridInfo : LandmarkInfo // TypeDefIndex: 10352
{	[HeaderAttribute] // RVA: 0xCC950 Offset: 0xCBD50 VA: 0x1800CC950
	public int CellSize; // 0x30
	public float LinkHeight; // 0x34
	public float LinkRadius; // 0x38
	internal List<GameObject> Links; // 0x40


	public float Distance(Vector3 position) { }

	public float SqrDistance(Vector3 position) { }

	public bool IsValidSpawnPosition(Vector3 position) { }

	public Vector3 SnapPosition(Vector3 pos) { }

	protected override void Awake() { }

	protected void Start() { }

	public void .ctor() { }

}

public class DungeonGridLink : MonoBehaviour // TypeDefIndex: 10353
{	public Transform UpSocket; // 0x18
	public Transform DownSocket; // 0x20
	public DungeonGridLinkType UpType; // 0x28
	public DungeonGridLinkType DownType; // 0x2C
	public int Priority; // 0x30
	public int Rotation; // 0x34


	protected void Start() { }

	public void .ctor() { }

}

public enum DungeonGridLinkType // TypeDefIndex: 10354
{	public int value__; // 0x0
	public const DungeonGridLinkType Default = 0;
	public const DungeonGridLinkType Elevator = 1;
	public const DungeonGridLinkType Transition = 2;

}

public class DungeonVolume : MonoBehaviour // TypeDefIndex: 10355
{	public Bounds bounds; // 0x18


	public OBB GetBounds(Vector3 position, Quaternion rotation) { }

	public OBB GetBounds(Vector3 position, Quaternion rotation, Vector3 extrude) { }

	public void .ctor() { }

}

