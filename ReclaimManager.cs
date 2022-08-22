public class ReclaimManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6403
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ReclaimManager.ReclaimInfo> reclaimEntries; // 0x18
	public int lastReclaimID; // 0x20

	// Methods

	// RVA: 0x1DFE460 Offset: 0x1DFCA60 VA: 0x181DFE460
	public static void ResetToPool(ReclaimManager instance) { }

	// RVA: 0x1DFE280 Offset: 0x1DFC880 VA: 0x181DFE280
	public void ResetToPool() { }

	// RVA: 0x1DFE1C0 Offset: 0x1DFC7C0 VA: 0x181DFE1C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFD360 Offset: 0x1DFB960 VA: 0x181DFD360
	public void CopyTo(ReclaimManager instance) { }

	// RVA: 0x1DFD570 Offset: 0x1DFBB70 VA: 0x181DFD570
	public ReclaimManager Copy() { }

	// RVA: 0x1DFDE10 Offset: 0x1DFC410 VA: 0x181DFDE10
	public static ReclaimManager Deserialize(Stream stream) { }

	// RVA: 0x1DFD900 Offset: 0x1DFBF00 VA: 0x181DFD900
	public static ReclaimManager DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFDC60 Offset: 0x1DFC260 VA: 0x181DFDC60
	public static ReclaimManager DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFDCF0 Offset: 0x1DFC2F0 VA: 0x181DFDCF0
	public static ReclaimManager Deserialize(byte[] buffer) { }

	// RVA: 0x1DFE240 Offset: 0x1DFC840 VA: 0x181DFE240
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFEC90 Offset: 0x1DFD290 VA: 0x181DFEC90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFECB0 Offset: 0x1DFD2B0 VA: 0x181DFECB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager previous) { }

	// RVA: 0x1DFE260 Offset: 0x1DFC860 VA: 0x181DFE260 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFE0C0 Offset: 0x1DFC6C0 VA: 0x181DFE0C0
	public static ReclaimManager Deserialize(byte[] buffer, ReclaimManager instance, bool isDelta = False) { }

	// RVA: 0x1DFDE90 Offset: 0x1DFC490 VA: 0x181DFDE90
	public static ReclaimManager Deserialize(Stream stream, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFD5F0 Offset: 0x1DFBBF0 VA: 0x181DFD5F0
	public static ReclaimManager DeserializeLengthDelimited(Stream stream, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFD980 Offset: 0x1DFBF80 VA: 0x181DFD980
	public static ReclaimManager DeserializeLength(Stream stream, int length, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFE640 Offset: 0x1DFCC40 VA: 0x181DFE640
	public static void SerializeDelta(Stream stream, ReclaimManager instance, ReclaimManager previous) { }

	// RVA: 0x1DFEA50 Offset: 0x1DFD050 VA: 0x181DFEA50
	public static void Serialize(Stream stream, ReclaimManager instance) { }

	// RVA: 0x1DFEC80 Offset: 0x1DFD280 VA: 0x181DFEC80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFEC90 Offset: 0x1DFD290 VA: 0x181DFEC90
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFE940 Offset: 0x1DFCF40 VA: 0x181DFE940
	public static byte[] SerializeToBytes(ReclaimManager instance) { }

	// RVA: 0x1DFE890 Offset: 0x1DFCE90 VA: 0x181DFE890
	public static void SerializeLengthDelimited(Stream stream, ReclaimManager instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1DFC950 Offset: 0x1DFAF50 VA: 0x181DFC950
	public static void ResetToPool(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFCA50 Offset: 0x1DFB050 VA: 0x181DFCA50
	public void ResetToPool() { }

	// RVA: 0x1DFC680 Offset: 0x1DFAC80 VA: 0x181DFC680 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFB340 Offset: 0x1DF9940 VA: 0x181DFB340
	public void CopyTo(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFB3D0 Offset: 0x1DF99D0 VA: 0x181DFB3D0
	public ReclaimManager.ReclaimInfo Copy() { }

	// RVA: 0x1DFC410 Offset: 0x1DFAA10 VA: 0x181DFC410
	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream) { }

	// RVA: 0x1DFB7C0 Offset: 0x1DF9DC0 VA: 0x181DFB7C0
	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFB840 Offset: 0x1DF9E40 VA: 0x181DFB840
	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFBEC0 Offset: 0x1DFA4C0 VA: 0x181DFBEC0
	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1DFC700 Offset: 0x1DFAD00 VA: 0x181DFC700
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFD320 Offset: 0x1DFB920 VA: 0x181DFD320 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFD340 Offset: 0x1DFB940 VA: 0x181DFD340 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager.ReclaimInfo previous) { }

	// RVA: 0x1DFC930 Offset: 0x1DFAF30 VA: 0x181DFC930 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFBBC0 Offset: 0x1DFA1C0 VA: 0x181DFBBC0
	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer, ReclaimManager.ReclaimInfo instance, bool isDelta = False) { }

	// RVA: 0x1DFC1E0 Offset: 0x1DFA7E0 VA: 0x181DFC1E0
	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFB4B0 Offset: 0x1DF9AB0 VA: 0x181DFB4B0
	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFB8D0 Offset: 0x1DF9ED0 VA: 0x181DFB8D0
	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFCB50 Offset: 0x1DFB150 VA: 0x181DFCB50
	public static void SerializeDelta(Stream stream, ReclaimManager.ReclaimInfo instance, ReclaimManager.ReclaimInfo previous) { }

	// RVA: 0x1DFD050 Offset: 0x1DFB650 VA: 0x181DFD050
	public static void Serialize(Stream stream, ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFD310 Offset: 0x1DFB910 VA: 0x181DFD310
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFD320 Offset: 0x1DFB920 VA: 0x181DFD320
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFCF40 Offset: 0x1DFB540 VA: 0x181DFCF40
	public static byte[] SerializeToBytes(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFCE90 Offset: 0x1DFB490 VA: 0x181DFCE90
	public static void SerializeLengthDelimited(Stream stream, ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class ReclaimManager : BaseEntity // TypeDefIndex: 9887
{	// Fields
	private const int defaultReclaims = 128;
	private const int reclaimSlotCount = 40;

	// Methods

	// RVA: 0x6AC560 Offset: 0x6AAB60 VA: 0x1806AC560
	public void .ctor() { }

}

