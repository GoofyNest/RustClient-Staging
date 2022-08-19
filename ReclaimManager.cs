public class ReclaimManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6403
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ReclaimManager.ReclaimInfo> reclaimEntries; // 0x18
	public int lastReclaimID; // 0x20

	// Methods

	// RVA: 0x1DFE620 Offset: 0x1DFCC20 VA: 0x181DFE620
	public static void ResetToPool(ReclaimManager instance) { }

	// RVA: 0x1DFE440 Offset: 0x1DFCA40 VA: 0x181DFE440
	public void ResetToPool() { }

	// RVA: 0x1DFE380 Offset: 0x1DFC980 VA: 0x181DFE380 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFD520 Offset: 0x1DFBB20 VA: 0x181DFD520
	public void CopyTo(ReclaimManager instance) { }

	// RVA: 0x1DFD730 Offset: 0x1DFBD30 VA: 0x181DFD730
	public ReclaimManager Copy() { }

	// RVA: 0x1DFDFD0 Offset: 0x1DFC5D0 VA: 0x181DFDFD0
	public static ReclaimManager Deserialize(Stream stream) { }

	// RVA: 0x1DFDAC0 Offset: 0x1DFC0C0 VA: 0x181DFDAC0
	public static ReclaimManager DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFDE20 Offset: 0x1DFC420 VA: 0x181DFDE20
	public static ReclaimManager DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFDEB0 Offset: 0x1DFC4B0 VA: 0x181DFDEB0
	public static ReclaimManager Deserialize(byte[] buffer) { }

	// RVA: 0x1DFE400 Offset: 0x1DFCA00 VA: 0x181DFE400
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFEE50 Offset: 0x1DFD450 VA: 0x181DFEE50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFEE70 Offset: 0x1DFD470 VA: 0x181DFEE70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager previous) { }

	// RVA: 0x1DFE420 Offset: 0x1DFCA20 VA: 0x181DFE420 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFE280 Offset: 0x1DFC880 VA: 0x181DFE280
	public static ReclaimManager Deserialize(byte[] buffer, ReclaimManager instance, bool isDelta = False) { }

	// RVA: 0x1DFE050 Offset: 0x1DFC650 VA: 0x181DFE050
	public static ReclaimManager Deserialize(Stream stream, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFD7B0 Offset: 0x1DFBDB0 VA: 0x181DFD7B0
	public static ReclaimManager DeserializeLengthDelimited(Stream stream, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFDB40 Offset: 0x1DFC140 VA: 0x181DFDB40
	public static ReclaimManager DeserializeLength(Stream stream, int length, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFE800 Offset: 0x1DFCE00 VA: 0x181DFE800
	public static void SerializeDelta(Stream stream, ReclaimManager instance, ReclaimManager previous) { }

	// RVA: 0x1DFEC10 Offset: 0x1DFD210 VA: 0x181DFEC10
	public static void Serialize(Stream stream, ReclaimManager instance) { }

	// RVA: 0x1DFEE40 Offset: 0x1DFD440 VA: 0x181DFEE40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFEE50 Offset: 0x1DFD450 VA: 0x181DFEE50
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFEB00 Offset: 0x1DFD100 VA: 0x181DFEB00
	public static byte[] SerializeToBytes(ReclaimManager instance) { }

	// RVA: 0x1DFEA50 Offset: 0x1DFD050 VA: 0x181DFEA50
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

	// RVA: 0x1DFCB10 Offset: 0x1DFB110 VA: 0x181DFCB10
	public static void ResetToPool(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFCC10 Offset: 0x1DFB210 VA: 0x181DFCC10
	public void ResetToPool() { }

	// RVA: 0x1DFC840 Offset: 0x1DFAE40 VA: 0x181DFC840 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFB500 Offset: 0x1DF9B00 VA: 0x181DFB500
	public void CopyTo(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFB590 Offset: 0x1DF9B90 VA: 0x181DFB590
	public ReclaimManager.ReclaimInfo Copy() { }

	// RVA: 0x1DFC5D0 Offset: 0x1DFABD0 VA: 0x181DFC5D0
	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream) { }

	// RVA: 0x1DFB980 Offset: 0x1DF9F80 VA: 0x181DFB980
	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFBA00 Offset: 0x1DFA000 VA: 0x181DFBA00
	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFC080 Offset: 0x1DFA680 VA: 0x181DFC080
	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1DFC8C0 Offset: 0x1DFAEC0 VA: 0x181DFC8C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFD4E0 Offset: 0x1DFBAE0 VA: 0x181DFD4E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFD500 Offset: 0x1DFBB00 VA: 0x181DFD500 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager.ReclaimInfo previous) { }

	// RVA: 0x1DFCAF0 Offset: 0x1DFB0F0 VA: 0x181DFCAF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFBD80 Offset: 0x1DFA380 VA: 0x181DFBD80
	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer, ReclaimManager.ReclaimInfo instance, bool isDelta = False) { }

	// RVA: 0x1DFC3A0 Offset: 0x1DFA9A0 VA: 0x181DFC3A0
	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFB670 Offset: 0x1DF9C70 VA: 0x181DFB670
	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFBA90 Offset: 0x1DFA090 VA: 0x181DFBA90
	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFCD10 Offset: 0x1DFB310 VA: 0x181DFCD10
	public static void SerializeDelta(Stream stream, ReclaimManager.ReclaimInfo instance, ReclaimManager.ReclaimInfo previous) { }

	// RVA: 0x1DFD210 Offset: 0x1DFB810 VA: 0x181DFD210
	public static void Serialize(Stream stream, ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFD4D0 Offset: 0x1DFBAD0 VA: 0x181DFD4D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFD4E0 Offset: 0x1DFBAE0 VA: 0x181DFD4E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFD100 Offset: 0x1DFB700 VA: 0x181DFD100
	public static byte[] SerializeToBytes(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFD050 Offset: 0x1DFB650 VA: 0x181DFD050
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

