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

	// RVA: 0x22CA160 Offset: 0x22C8760 VA: 0x1822CA160
	public TimeSpan get_TotalLength() { }

	// RVA: 0x8D8F10 Offset: 0x8D7510 VA: 0x1808D8F10
	public long get_Interval() { }

	// RVA: 0x22C9DC0 Offset: 0x22C83C0 VA: 0x1822C9DC0
	internal void .ctor(Reader reader) { }

	// RVA: 0x22C97A0 Offset: 0x22C7DA0 VA: 0x1822C97A0
	private void ProcessPacket(Packet packet) { }

	// RVA: 0x22C9330 Offset: 0x22C7930 VA: 0x1822C9330
	private void EntityUpdated(uint ent) { }

	// RVA: 0x22C9120 Offset: 0x22C7720 VA: 0x1822C9120
	private void EntityPosition(BinaryReader reader) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void RpcMessage(BinaryReader reader) { }

	// RVA: 0x22C9710 Offset: 0x22C7D10 VA: 0x1822C9710
	internal Indexer.Keyframe LookupKeyframeForTime(long time) { }

	// RVA: 0x22C9670 Offset: 0x22C7C70 VA: 0x1822C9670
	internal Indexer.Keyframe GetKeyframe(int index) { }

	// RVA: 0x22C93A0 Offset: 0x22C79A0 VA: 0x1822C93A0
	internal HashSet<uint> GetChangedEntities(long from, long to) { }

	// RVA: 0x22C9060 Offset: 0x22C7660 VA: 0x1822C9060
	private void EntityDestroy(BinaryReader reader) { }

	// RVA: 0x22C8EB0 Offset: 0x22C74B0 VA: 0x1822C8EB0
	private void Entities(BinaryReader reader) { }

	// RVA: 0x22C9A50 Offset: 0x22C8050 VA: 0x1822C9A50
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

	// RVA: 0x22C8E80 Offset: 0x22C7480 VA: 0x1822C8E80
	public uint get_UId() { }

	// RVA: 0x22C8DE0 Offset: 0x22C73E0 VA: 0x1822C8DE0
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

	// RVA: 0x22CA220 Offset: 0x22C8820 VA: 0x1822CA220
	public void Init() { }

	// RVA: 0x22CA1C0 Offset: 0x22C87C0 VA: 0x1822CA1C0
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

	// RVA: 0x22CB200 Offset: 0x22C9800 VA: 0x1822CB200
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22CB100 Offset: 0x22C9700 VA: 0x1822CB100
	internal uint <Init>b__4_0(Indexer.Entity x) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
	internal Indexer.Entity <Init>b__4_1(Indexer.Entity x) { }

}

private sealed class Indexer.<>c // TypeDefIndex: 6645
{	// Fields
	public static readonly Indexer.<>c <>9; // 0x0
	public static Func<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity> <>9__21_0; // 0x8

	// Methods

	// RVA: 0x22CB260 Offset: 0x22C9860 VA: 0x1822CB260
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22CB130 Offset: 0x22C9730 VA: 0x1822CB130
	internal Indexer.Entity <TryCreateKeyframe>b__21_0(KeyValuePair<uint, Indexer.Entity> x) { }

}

