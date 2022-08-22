public class ReclaimManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6403
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ReclaimManager.ReclaimInfo> reclaimEntries; // 0x18
	public int lastReclaimID; // 0x20

	// Methods

	// RVA: 0x1DFE720 Offset: 0x1DFCD20 VA: 0x181DFE720
	public static void ResetToPool(ReclaimManager instance) { }

	// RVA: 0x1DFE540 Offset: 0x1DFCB40 VA: 0x181DFE540
	public void ResetToPool() { }

	// RVA: 0x1DFE480 Offset: 0x1DFCA80 VA: 0x181DFE480 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFD620 Offset: 0x1DFBC20 VA: 0x181DFD620
	public void CopyTo(ReclaimManager instance) { }

	// RVA: 0x1DFD830 Offset: 0x1DFBE30 VA: 0x181DFD830
	public ReclaimManager Copy() { }

	// RVA: 0x1DFE0D0 Offset: 0x1DFC6D0 VA: 0x181DFE0D0
	public static ReclaimManager Deserialize(Stream stream) { }

	// RVA: 0x1DFDBC0 Offset: 0x1DFC1C0 VA: 0x181DFDBC0
	public static ReclaimManager DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFDF20 Offset: 0x1DFC520 VA: 0x181DFDF20
	public static ReclaimManager DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFDFB0 Offset: 0x1DFC5B0 VA: 0x181DFDFB0
	public static ReclaimManager Deserialize(byte[] buffer) { }

	// RVA: 0x1DFE500 Offset: 0x1DFCB00 VA: 0x181DFE500
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFEF50 Offset: 0x1DFD550 VA: 0x181DFEF50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFEF70 Offset: 0x1DFD570 VA: 0x181DFEF70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager previous) { }

	// RVA: 0x1DFE520 Offset: 0x1DFCB20 VA: 0x181DFE520 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFE380 Offset: 0x1DFC980 VA: 0x181DFE380
	public static ReclaimManager Deserialize(byte[] buffer, ReclaimManager instance, bool isDelta = False) { }

	// RVA: 0x1DFE150 Offset: 0x1DFC750 VA: 0x181DFE150
	public static ReclaimManager Deserialize(Stream stream, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFD8B0 Offset: 0x1DFBEB0 VA: 0x181DFD8B0
	public static ReclaimManager DeserializeLengthDelimited(Stream stream, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFDC40 Offset: 0x1DFC240 VA: 0x181DFDC40
	public static ReclaimManager DeserializeLength(Stream stream, int length, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFE900 Offset: 0x1DFCF00 VA: 0x181DFE900
	public static void SerializeDelta(Stream stream, ReclaimManager instance, ReclaimManager previous) { }

	// RVA: 0x1DFED10 Offset: 0x1DFD310 VA: 0x181DFED10
	public static void Serialize(Stream stream, ReclaimManager instance) { }

	// RVA: 0x1DFEF40 Offset: 0x1DFD540 VA: 0x181DFEF40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFEF50 Offset: 0x1DFD550 VA: 0x181DFEF50
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFEC00 Offset: 0x1DFD200 VA: 0x181DFEC00
	public static byte[] SerializeToBytes(ReclaimManager instance) { }

	// RVA: 0x1DFEB50 Offset: 0x1DFD150 VA: 0x181DFEB50
	public static void SerializeLengthDelimited(Stream stream, ReclaimManager instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ReclaimManager.ReclaimInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6404
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong victimID; // 0x18
	public ulong killerID; // 0x20
	public string killerString; // 0x28
	public ItemContainer inventory; // 0x30

	// Methods

	// RVA: 0x1DFCC10 Offset: 0x1DFB210 VA: 0x181DFCC10
	public static void ResetToPool(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFCD10 Offset: 0x1DFB310 VA: 0x181DFCD10
	public void ResetToPool() { }

	// RVA: 0x1DFC940 Offset: 0x1DFAF40 VA: 0x181DFC940 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFB600 Offset: 0x1DF9C00 VA: 0x181DFB600
	public void CopyTo(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFB690 Offset: 0x1DF9C90 VA: 0x181DFB690
	public ReclaimManager.ReclaimInfo Copy() { }

	// RVA: 0x1DFC6D0 Offset: 0x1DFACD0 VA: 0x181DFC6D0
	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream) { }

	// RVA: 0x1DFBA80 Offset: 0x1DFA080 VA: 0x181DFBA80
	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFBB00 Offset: 0x1DFA100 VA: 0x181DFBB00
	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFC180 Offset: 0x1DFA780 VA: 0x181DFC180
	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1DFC9C0 Offset: 0x1DFAFC0 VA: 0x181DFC9C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFD5E0 Offset: 0x1DFBBE0 VA: 0x181DFD5E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFD600 Offset: 0x1DFBC00 VA: 0x181DFD600 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager.ReclaimInfo previous) { }

	// RVA: 0x1DFCBF0 Offset: 0x1DFB1F0 VA: 0x181DFCBF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFBE80 Offset: 0x1DFA480 VA: 0x181DFBE80
	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer, ReclaimManager.ReclaimInfo instance, bool isDelta = False) { }

	// RVA: 0x1DFC4A0 Offset: 0x1DFAAA0 VA: 0x181DFC4A0
	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFB770 Offset: 0x1DF9D70 VA: 0x181DFB770
	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFBB90 Offset: 0x1DFA190 VA: 0x181DFBB90
	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFCE10 Offset: 0x1DFB410 VA: 0x181DFCE10
	public static void SerializeDelta(Stream stream, ReclaimManager.ReclaimInfo instance, ReclaimManager.ReclaimInfo previous) { }

	// RVA: 0x1DFD310 Offset: 0x1DFB910 VA: 0x181DFD310
	public static void Serialize(Stream stream, ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFD5D0 Offset: 0x1DFBBD0 VA: 0x181DFD5D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFD5E0 Offset: 0x1DFBBE0 VA: 0x181DFD5E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFD200 Offset: 0x1DFB800 VA: 0x181DFD200
	public static byte[] SerializeToBytes(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFD150 Offset: 0x1DFB750 VA: 0x181DFD150
	public static void SerializeLengthDelimited(Stream stream, ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ReclaimManager : BaseEntity // TypeDefIndex: 9887
{	// Fields
	private const int defaultReclaims = 128;
	private const int reclaimSlotCount = 40;

	// Methods

	// RVA: 0x6AC670 Offset: 0x6AAC70 VA: 0x1806AC670
	public void .ctor() { }

}

