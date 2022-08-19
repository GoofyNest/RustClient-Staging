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

	// RVA: 0x22CA320 Offset: 0x22C8920 VA: 0x1822CA320
	public TimeSpan get_TotalLength() { }

	// RVA: 0x8D8F10 Offset: 0x8D7510 VA: 0x1808D8F10
	public long get_Interval() { }

	// RVA: 0x22C9F80 Offset: 0x22C8580 VA: 0x1822C9F80
	internal void .ctor(Reader reader) { }

	// RVA: 0x22C9960 Offset: 0x22C7F60 VA: 0x1822C9960
	private void ProcessPacket(Packet packet) { }

	// RVA: 0x22C94F0 Offset: 0x22C7AF0 VA: 0x1822C94F0
	private void EntityUpdated(uint ent) { }

	// RVA: 0x22C92E0 Offset: 0x22C78E0 VA: 0x1822C92E0
	private void EntityPosition(BinaryReader reader) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void RpcMessage(BinaryReader reader) { }

	// RVA: 0x22C98D0 Offset: 0x22C7ED0 VA: 0x1822C98D0
	internal Indexer.Keyframe LookupKeyframeForTime(long time) { }

	// RVA: 0x22C9830 Offset: 0x22C7E30 VA: 0x1822C9830
	internal Indexer.Keyframe GetKeyframe(int index) { }

	// RVA: 0x22C9560 Offset: 0x22C7B60 VA: 0x1822C9560
	internal HashSet<uint> GetChangedEntities(long from, long to) { }

	// RVA: 0x22C9220 Offset: 0x22C7820 VA: 0x1822C9220
	private void EntityDestroy(BinaryReader reader) { }

	// RVA: 0x22C9070 Offset: 0x22C7670 VA: 0x1822C9070
	private void Entities(BinaryReader reader) { }

	// RVA: 0x22C9C10 Offset: 0x22C8210 VA: 0x1822C9C10
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

	// RVA: 0x22C9040 Offset: 0x22C7640 VA: 0x1822C9040
	public uint get_UId() { }

	// RVA: 0x22C8FA0 Offset: 0x22C75A0 VA: 0x1822C8FA0
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

	// RVA: 0x22CA3E0 Offset: 0x22C89E0 VA: 0x1822CA3E0
	public void Init() { }

	// RVA: 0x22CA380 Offset: 0x22C8980 VA: 0x1822CA380
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

	// RVA: 0x22CB3C0 Offset: 0x22C99C0 VA: 0x1822CB3C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22CB2C0 Offset: 0x22C98C0 VA: 0x1822CB2C0
	internal uint <Init>b__4_0(Indexer.Entity x) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
	internal Indexer.Entity <Init>b__4_1(Indexer.Entity x) { }

}

private sealed class Indexer.<>c // TypeDefIndex: 6645
{	// Fields
	public static readonly Indexer.<>c <>9; // 0x0
	public static Func<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity> <>9__21_0; // 0x8

	// Methods

	// RVA: 0x22CB420 Offset: 0x22C9A20 VA: 0x1822CB420
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22CB2F0 Offset: 0x22C98F0 VA: 0x1822CB2F0
	internal Indexer.Entity <TryCreateKeyframe>b__21_0(KeyValuePair<uint, Indexer.Entity> x) { }

}

