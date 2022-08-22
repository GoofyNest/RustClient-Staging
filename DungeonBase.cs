public class DungeonNavmesh : FacepunchBehaviour, IServerComponent // TypeDefIndex: 8956
{	// Fields
	public int NavMeshAgentTypeIndex; // 0x18
	[TooltipAttribute] // RVA: 0xC6F30 Offset: 0xC6330 VA: 0x1800C6F30
	public string DefaultAreaName; // 0x20
	public float NavmeshResolutionModifier; // 0x28
	[TooltipAttribute] // RVA: 0xC6FD0 Offset: 0xC63D0 VA: 0x1800C6FD0
	public Bounds Bounds; // 0x2C
	public NavMeshData NavMeshData; // 0x48
	public NavMeshDataInstance NavMeshDataInstance; // 0x50
	public LayerMask LayerMask; // 0x54
	public NavMeshCollectGeometry NavMeshCollectGeometry; // 0x58
	public static List<DungeonNavmesh> Instances; // 0x0

	// Methods

	// RVA: 0xAB5A80 Offset: 0xAB4080 VA: 0x180AB5A80
	public void .ctor() { }

	// RVA: 0xAB5A20 Offset: 0xAB4020 VA: 0x180AB5A20
	private static void .cctor() { }

}

public class DungeonBaseInfo : LandmarkInfo // TypeDefIndex: 10336
{	// Fields
	internal List<GameObject> Links; // 0x30
	internal List<DungeonBaseFloor> Floors; // 0x38

	// Methods

	// RVA: 0xAB44E0 Offset: 0xAB2AE0 VA: 0x180AB44E0
	public float Distance(Vector3 position) { }

	// RVA: 0xAB45C0 Offset: 0xAB2BC0 VA: 0x180AB45C0
	public float SqrDistance(Vector3 position) { }

	// RVA: 0xAB40B0 Offset: 0xAB26B0 VA: 0x180AB40B0
	public void Add(DungeonBaseLink link) { }

	// RVA: 0xAB43F0 Offset: 0xAB29F0 VA: 0x180AB43F0 Slot: 5
	protected override void Awake() { }

	// RVA: 0xAB46A0 Offset: 0xAB2CA0 VA: 0x180AB46A0
	protected void Start() { }

	// RVA: 0xAB48A0 Offset: 0xAB2EA0 VA: 0x180AB48A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAB4700 Offset: 0xAB2D00 VA: 0x180AB4700
	private int <Add>b__4_0(DungeonBaseFloor l, DungeonBaseFloor r) { }

}

public class DungeonBaseFloor // TypeDefIndex: 10337
{	// Fields
	public List<DungeonBaseLink> Links; // 0x10

	// Methods

	// RVA: 0xAB3EE0 Offset: 0xAB24E0 VA: 0x180AB3EE0
	public float Distance(Vector3 position) { }

	// RVA: 0xAB3FB0 Offset: 0xAB25B0 VA: 0x180AB3FB0
	public float SignedDistance(Vector3 position) { }

	// RVA: 0xAB4040 Offset: 0xAB2640 VA: 0x180AB4040
	public void .ctor() { }

}

public class DungeonBaseLandmarkInfo : LandmarkInfo // TypeDefIndex: 10338
{	// Fields
	private DungeonBaseLink baseLink; // 0x30
	private Nullable<MapLayer> layer; // 0x38

	// Properties
	public override MapLayer MapLayer { get; }

	// Methods

	// RVA: 0xAB4940 Offset: 0xAB2F40 VA: 0x180AB4940 Slot: 5
	protected override void Awake() { }

	// RVA: 0xAB49A0 Offset: 0xAB2FA0 VA: 0x180AB49A0 Slot: 4
	public override MapLayer get_MapLayer() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

public class DungeonBaseLink : MonoBehaviour // TypeDefIndex: 10339
{	// Fields
	public DungeonBaseLinkType Type; // 0x18
	public int Cost; // 0x1C
	public int MaxFloor; // 0x20
	public int MaxCountLocal; // 0x24
	public int MaxCountGlobal; // 0x28
	[TooltipAttribute] // RVA: 0xCC530 Offset: 0xCB930 VA: 0x1800CC530
	public int MaxCountIdentifier; // 0x2C
	internal DungeonBaseInfo Dungeon; // 0x30
	public MeshRenderer[] MapRenderers; // 0x38
	private List<DungeonBaseSocket> sockets; // 0x40
	private List<DungeonVolume> volumes; // 0x48

	// Properties
	internal List<DungeonBaseSocket> Sockets { get; }
	internal List<DungeonVolume> Volumes { get; }

	// Methods

	// RVA: 0xAB4E50 Offset: 0xAB3450 VA: 0x180AB4E50
	internal List<DungeonBaseSocket> get_Sockets() { }

	// RVA: 0xAB4EE0 Offset: 0xAB34E0 VA: 0x180AB4EE0
	internal List<DungeonVolume> get_Volumes() { }

	// RVA: 0xAB4C70 Offset: 0xAB3270 VA: 0x180AB4C70
	protected void Start() { }

	// RVA: 0xAB4E30 Offset: 0xAB3430 VA: 0x180AB4E30
	public void .ctor() { }

}

public enum DungeonBaseLinkType // TypeDefIndex: 10340
{	// Fields
	public int value__; // 0x0
	public const DungeonBaseLinkType Room = 0;
	public const DungeonBaseLinkType Corridor = 1;
	public const DungeonBaseLinkType End = 2;

}

public class DungeonBaseSocket : MonoBehaviour // TypeDefIndex: 10341
{	// Fields
	public DungeonBaseSocketType Type; // 0x18
	public bool Male; // 0x1C
	public bool Female; // 0x1D

	// Methods

	// RVA: 0xAB4F70 Offset: 0xAB3570 VA: 0x180AB4F70
	public void .ctor() { }

}

public enum DungeonBaseSocketType // TypeDefIndex: 10342
{	// Fields
	public int value__; // 0x0
	public const DungeonBaseSocketType Horizontal = 0;
	public const DungeonBaseSocketType Vertical = 1;
	public const DungeonBaseSocketType Pillar = 2;

}

public class DungeonBaseTransition : MonoBehaviour // TypeDefIndex: 10343
{	// Fields
	public DungeonBaseSocketType Type; // 0x18
	public DungeonBaseLinkType Neighbour1; // 0x1C
	public DungeonBaseLinkType Neighbour2; // 0x20

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class DungeonGridCell : MonoBehaviour // TypeDefIndex: 10344
{	// Fields
	public DungeonGridConnectionType North; // 0x18
	public DungeonGridConnectionType South; // 0x1C
	public DungeonGridConnectionType West; // 0x20
	public DungeonGridConnectionType East; // 0x24
	public DungeonGridConnectionVariant NorthVariant; // 0x28
	public DungeonGridConnectionVariant SouthVariant; // 0x2C
	public DungeonGridConnectionVariant WestVariant; // 0x30
	public DungeonGridConnectionVariant EastVariant; // 0x34
	public GameObjectRef[] AvoidNeighbours; // 0x38
	public MeshRenderer[] MapRenderers; // 0x40

	// Methods

	// RVA: 0xAB5070 Offset: 0xAB3670 VA: 0x180AB5070
	public bool ShouldAvoid(uint id) { }

	// RVA: 0xAB4F80 Offset: 0xAB3580 VA: 0x180AB4F80
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public enum DungeonGridConnectionType // TypeDefIndex: 10345
{	// Fields
	public int value__; // 0x0
	public const DungeonGridConnectionType None = 0;
	public const DungeonGridConnectionType TrainTunnel = 1;

}

public enum DungeonGridConnectionVariant // TypeDefIndex: 10346
{	// Fields
	public int value__; // 0x0
	public const DungeonGridConnectionVariant A = 0;
	public const DungeonGridConnectionVariant B = 1;

}

public struct DungeonGridConnectionHash // TypeDefIndex: 10347
{	// Fields
	public bool North; // 0x0
	public bool South; // 0x1
	public bool West; // 0x2
	public bool East; // 0x3

	// Properties
	public int Value { get; }

	// Methods

	// RVA: 0xFC5D0 Offset: 0xFB9D0 VA: 0x1800FC5D0
	public int get_Value() { }

}

public class DungeonGridInfo : LandmarkInfo // TypeDefIndex: 10348
{	// Fields
	[HeaderAttribute] // RVA: 0xCC600 Offset: 0xCBA00 VA: 0x1800CC600
	public int CellSize; // 0x30
	public float LinkHeight; // 0x34
	public float LinkRadius; // 0x38
	internal List<GameObject> Links; // 0x40

	// Methods

	// RVA: 0xAB5250 Offset: 0xAB3850 VA: 0x180AB5250
	public float Distance(Vector3 position) { }

	// RVA: 0xAB5690 Offset: 0xAB3C90 VA: 0x180AB5690
	public float SqrDistance(Vector3 position) { }

	// RVA: 0xAB5330 Offset: 0xAB3930 VA: 0x180AB5330
	public bool IsValidSpawnPosition(Vector3 position) { }

	// RVA: 0xAB5570 Offset: 0xAB3B70 VA: 0x180AB5570
	public Vector3 SnapPosition(Vector3 pos) { }

	// RVA: 0xAB5160 Offset: 0xAB3760 VA: 0x180AB5160 Slot: 5
	protected override void Awake() { }

	// RVA: 0xAB5770 Offset: 0xAB3D70 VA: 0x180AB5770
	protected void Start() { }

	// RVA: 0xAB57D0 Offset: 0xAB3DD0 VA: 0x180AB57D0
	public void .ctor() { }

}

public class DungeonGridLink : MonoBehaviour // TypeDefIndex: 10349
{	// Fields
	public Transform UpSocket; // 0x18
	public Transform DownSocket; // 0x20
	public DungeonGridLinkType UpType; // 0x28
	public DungeonGridLinkType DownType; // 0x2C
	public int Priority; // 0x30
	public int Rotation; // 0x34

	// Methods

	// RVA: 0xAB5850 Offset: 0xAB3E50 VA: 0x180AB5850
	protected void Start() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public enum DungeonGridLinkType // TypeDefIndex: 10350
{	// Fields
	public int value__; // 0x0
	public const DungeonGridLinkType Default = 0;
	public const DungeonGridLinkType Elevator = 1;
	public const DungeonGridLinkType Transition = 2;

}

public class DungeonVolume : MonoBehaviour // TypeDefIndex: 10351
{	// Fields
	public Bounds bounds; // 0x18

	// Methods

	// RVA: 0xAB5AD0 Offset: 0xAB40D0 VA: 0x180AB5AD0
	public OBB GetBounds(Vector3 position, Quaternion rotation) { }

	// RVA: 0xAB5D70 Offset: 0xAB4370 VA: 0x180AB5D70
	public OBB GetBounds(Vector3 position, Quaternion rotation, Vector3 extrude) { }

	// RVA: 0xAB6040 Offset: 0xAB4640 VA: 0x180AB6040
	public void .ctor() { }

}

