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

	// RVA: 0x22CA420 Offset: 0x22C8A20 VA: 0x1822CA420
	public TimeSpan get_TotalLength() { }

	// RVA: 0x8D9020 Offset: 0x8D7620 VA: 0x1808D9020
	public long get_Interval() { }

	// RVA: 0x22CA080 Offset: 0x22C8680 VA: 0x1822CA080
	internal void .ctor(Reader reader) { }

	// RVA: 0x22C9A60 Offset: 0x22C8060 VA: 0x1822C9A60
	private void ProcessPacket(Packet packet) { }

	// RVA: 0x22C95F0 Offset: 0x22C7BF0 VA: 0x1822C95F0
	private void EntityUpdated(uint ent) { }

	// RVA: 0x22C93E0 Offset: 0x22C79E0 VA: 0x1822C93E0
	private void EntityPosition(BinaryReader reader) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void RpcMessage(BinaryReader reader) { }

	// RVA: 0x22C99D0 Offset: 0x22C7FD0 VA: 0x1822C99D0
	internal Indexer.Keyframe LookupKeyframeForTime(long time) { }

	// RVA: 0x22C9930 Offset: 0x22C7F30 VA: 0x1822C9930
	internal Indexer.Keyframe GetKeyframe(int index) { }

	// RVA: 0x22C9660 Offset: 0x22C7C60 VA: 0x1822C9660
	internal HashSet<uint> GetChangedEntities(long from, long to) { }

	// RVA: 0x22C9320 Offset: 0x22C7920 VA: 0x1822C9320
	private void EntityDestroy(BinaryReader reader) { }

	// RVA: 0x22C9170 Offset: 0x22C7770 VA: 0x1822C9170
	private void Entities(BinaryReader reader) { }

	// RVA: 0x22C9D10 Offset: 0x22C8310 VA: 0x1822C9D10
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

	// RVA: 0x22C9140 Offset: 0x22C7740 VA: 0x1822C9140
	public uint get_UId() { }

	// RVA: 0x22C90A0 Offset: 0x22C76A0 VA: 0x1822C90A0
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

	// RVA: 0x22CA4E0 Offset: 0x22C8AE0 VA: 0x1822CA4E0
	public void Init() { }

	// RVA: 0x22CA480 Offset: 0x22C8A80 VA: 0x1822CA480
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

	// RVA: 0x22CB4C0 Offset: 0x22C9AC0 VA: 0x1822CB4C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22CB3C0 Offset: 0x22C99C0 VA: 0x1822CB3C0
	internal uint <Init>b__4_0(Indexer.Entity x) { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90
	internal Indexer.Entity <Init>b__4_1(Indexer.Entity x) { }

}

private sealed class Indexer.<>c // TypeDefIndex: 6645
{	// Fields
	public static readonly Indexer.<>c <>9; // 0x0
	public static Func<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity> <>9__21_0; // 0x8

	// Methods

	// RVA: 0x22CB520 Offset: 0x22C9B20 VA: 0x1822CB520
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22CB3F0 Offset: 0x22C99F0 VA: 0x1822CB3F0
	internal Indexer.Entity <TryCreateKeyframe>b__21_0(KeyValuePair<uint, Indexer.Entity> x) { }

}

