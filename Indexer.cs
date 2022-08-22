public class Indexer // TypeDefIndex: 6641
{	// Fields
	private List<Indexer.Keyframe> keyframes; // 0x10
	private long LastPacketTime; // 0x18
	private long PacketCount; // 0x20
	private Dictionary<uint, Indexer.Entity> currentEnts; // 0x28
	private long NextKeyframe; // 0x30
	private List<uint> Updated; // 0x38

	// Properties
	public TimeSpan TotalLength { get; }
	public long Interval { get; }

	// Methods

	// RVA: 0x22CAC40 Offset: 0x22C9240 VA: 0x1822CAC40
	public TimeSpan get_TotalLength() { }

	// RVA: 0x8D9530 Offset: 0x8D7B30 VA: 0x1808D9530
	public long get_Interval() { }

	// RVA: 0x22CA8A0 Offset: 0x22C8EA0 VA: 0x1822CA8A0
	internal void .ctor(Reader reader) { }

	// RVA: 0x22CA280 Offset: 0x22C8880 VA: 0x1822CA280
	private void ProcessPacket(Packet packet) { }

	// RVA: 0x22C9E10 Offset: 0x22C8410 VA: 0x1822C9E10
	private void EntityUpdated(uint ent) { }

	// RVA: 0x22C9C00 Offset: 0x22C8200 VA: 0x1822C9C00
	private void EntityPosition(BinaryReader reader) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void RpcMessage(BinaryReader reader) { }

	// RVA: 0x22CA1F0 Offset: 0x22C87F0 VA: 0x1822CA1F0
	internal Indexer.Keyframe LookupKeyframeForTime(long time) { }

	// RVA: 0x22CA150 Offset: 0x22C8750 VA: 0x1822CA150
	internal Indexer.Keyframe GetKeyframe(int index) { }

	// RVA: 0x22C9E80 Offset: 0x22C8480 VA: 0x1822C9E80
	internal HashSet<uint> GetChangedEntities(long from, long to) { }

	// RVA: 0x22C9B40 Offset: 0x22C8140 VA: 0x1822C9B40
	private void EntityDestroy(BinaryReader reader) { }

	// RVA: 0x22C9990 Offset: 0x22C7F90 VA: 0x1822C9990
	private void Entities(BinaryReader reader) { }

	// RVA: 0x22CA530 Offset: 0x22C8B30 VA: 0x1822CA530
	private void TryCreateKeyframe(Packet packet) { }

}

public class Indexer.Entity // TypeDefIndex: 6642
{	// Fields
	public Entity Init; // 0x10
	public Entity Data; // 0x18
	public Vector3 Position; // 0x20
	public Vector3 Rotation; // 0x2C

	// Properties
	public uint UId { get; }

	// Methods

	// RVA: 0x22C9960 Offset: 0x22C7F60 VA: 0x1822C9960
	public uint get_UId() { }

	// RVA: 0x22C98C0 Offset: 0x22C7EC0 VA: 0x1822C98C0
	public Indexer.Entity Copy() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Indexer.Keyframe // TypeDefIndex: 6643
{	// Fields
	public long Position; // 0x10
	public Indexer.Entity[] Entities; // 0x18
	public uint[] Updated; // 0x20
	public Dictionary<uint, Indexer.Entity> EntityDict; // 0x28

	// Methods

	// RVA: 0x22CAD00 Offset: 0x22C9300 VA: 0x1822CAD00
	public void Init() { }

	// RVA: 0x22CACA0 Offset: 0x22C92A0 VA: 0x1822CACA0
	public bool HasEntity(uint iD) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class Indexer.Keyframe.<>c // TypeDefIndex: 6644
{	// Fields
	public static readonly Indexer.Keyframe.<>c <>9; // 0x0
	public static Func<Indexer.Entity, uint> <>9__4_0; // 0x8
	public static Func<Indexer.Entity, Indexer.Entity> <>9__4_1; // 0x10

	// Methods

	// RVA: 0x22CBCE0 Offset: 0x22CA2E0 VA: 0x1822CBCE0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22CBBE0 Offset: 0x22CA1E0 VA: 0x1822CBBE0
	internal uint <Init>b__4_0(Indexer.Entity x) { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
	internal Indexer.Entity <Init>b__4_1(Indexer.Entity x) { }

}

private sealed class Indexer.<>c // TypeDefIndex: 6645
{	// Fields
	public static readonly Indexer.<>c <>9; // 0x0
	public static Func<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity> <>9__21_0; // 0x8

	// Methods

	// RVA: 0x22CBD40 Offset: 0x22CA340 VA: 0x1822CBD40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22CBC10 Offset: 0x22CA210 VA: 0x1822CBC10
	internal Indexer.Entity <TryCreateKeyframe>b__21_0(KeyValuePair<uint, Indexer.Entity> x) { }

}

