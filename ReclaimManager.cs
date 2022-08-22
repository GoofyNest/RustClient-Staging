public class ReclaimManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6403
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ReclaimManager.ReclaimInfo> reclaimEntries; // 0x18
	public int lastReclaimID; // 0x20

	// Methods

	// RVA: 0x1DFEF40 Offset: 0x1DFD540 VA: 0x181DFEF40
	public static void ResetToPool(ReclaimManager instance) { }

	// RVA: 0x1DFED60 Offset: 0x1DFD360 VA: 0x181DFED60
	public void ResetToPool() { }

	// RVA: 0x1DFECA0 Offset: 0x1DFD2A0 VA: 0x181DFECA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFDE40 Offset: 0x1DFC440 VA: 0x181DFDE40
	public void CopyTo(ReclaimManager instance) { }

	// RVA: 0x1DFE050 Offset: 0x1DFC650 VA: 0x181DFE050
	public ReclaimManager Copy() { }

	// RVA: 0x1DFE8F0 Offset: 0x1DFCEF0 VA: 0x181DFE8F0
	public static ReclaimManager Deserialize(Stream stream) { }

	// RVA: 0x1DFE3E0 Offset: 0x1DFC9E0 VA: 0x181DFE3E0
	public static ReclaimManager DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFE740 Offset: 0x1DFCD40 VA: 0x181DFE740
	public static ReclaimManager DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFE7D0 Offset: 0x1DFCDD0 VA: 0x181DFE7D0
	public static ReclaimManager Deserialize(byte[] buffer) { }

	// RVA: 0x1DFED20 Offset: 0x1DFD320 VA: 0x181DFED20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFF770 Offset: 0x1DFDD70 VA: 0x181DFF770 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFF790 Offset: 0x1DFDD90 VA: 0x181DFF790 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager previous) { }

	// RVA: 0x1DFED40 Offset: 0x1DFD340 VA: 0x181DFED40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFEBA0 Offset: 0x1DFD1A0 VA: 0x181DFEBA0
	public static ReclaimManager Deserialize(byte[] buffer, ReclaimManager instance, bool isDelta = False) { }

	// RVA: 0x1DFE970 Offset: 0x1DFCF70 VA: 0x181DFE970
	public static ReclaimManager Deserialize(Stream stream, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFE0D0 Offset: 0x1DFC6D0 VA: 0x181DFE0D0
	public static ReclaimManager DeserializeLengthDelimited(Stream stream, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFE460 Offset: 0x1DFCA60 VA: 0x181DFE460
	public static ReclaimManager DeserializeLength(Stream stream, int length, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DFF120 Offset: 0x1DFD720 VA: 0x181DFF120
	public static void SerializeDelta(Stream stream, ReclaimManager instance, ReclaimManager previous) { }

	// RVA: 0x1DFF530 Offset: 0x1DFDB30 VA: 0x181DFF530
	public static void Serialize(Stream stream, ReclaimManager instance) { }

	// RVA: 0x1DFF760 Offset: 0x1DFDD60 VA: 0x181DFF760
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFF770 Offset: 0x1DFDD70 VA: 0x181DFF770
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFF420 Offset: 0x1DFDA20 VA: 0x181DFF420
	public static byte[] SerializeToBytes(ReclaimManager instance) { }

	// RVA: 0x1DFF370 Offset: 0x1DFD970 VA: 0x181DFF370
	public static void SerializeLengthDelimited(Stream stream, ReclaimManager instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1DFD430 Offset: 0x1DFBA30 VA: 0x181DFD430
	public static void ResetToPool(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFD530 Offset: 0x1DFBB30 VA: 0x181DFD530
	public void ResetToPool() { }

	// RVA: 0x1DFD160 Offset: 0x1DFB760 VA: 0x181DFD160 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFBE20 Offset: 0x1DFA420 VA: 0x181DFBE20
	public void CopyTo(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFBEB0 Offset: 0x1DFA4B0 VA: 0x181DFBEB0
	public ReclaimManager.ReclaimInfo Copy() { }

	// RVA: 0x1DFCEF0 Offset: 0x1DFB4F0 VA: 0x181DFCEF0
	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream) { }

	// RVA: 0x1DFC2A0 Offset: 0x1DFA8A0 VA: 0x181DFC2A0
	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFC320 Offset: 0x1DFA920 VA: 0x181DFC320
	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFC9A0 Offset: 0x1DFAFA0 VA: 0x181DFC9A0
	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1DFD1E0 Offset: 0x1DFB7E0 VA: 0x181DFD1E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFDE00 Offset: 0x1DFC400 VA: 0x181DFDE00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFDE20 Offset: 0x1DFC420 VA: 0x181DFDE20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager.ReclaimInfo previous) { }

	// RVA: 0x1DFD410 Offset: 0x1DFBA10 VA: 0x181DFD410 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFC6A0 Offset: 0x1DFACA0 VA: 0x181DFC6A0
	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer, ReclaimManager.ReclaimInfo instance, bool isDelta = False) { }

	// RVA: 0x1DFCCC0 Offset: 0x1DFB2C0 VA: 0x181DFCCC0
	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFBF90 Offset: 0x1DFA590 VA: 0x181DFBF90
	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFC3B0 Offset: 0x1DFA9B0 VA: 0x181DFC3B0
	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DFD630 Offset: 0x1DFBC30 VA: 0x181DFD630
	public static void SerializeDelta(Stream stream, ReclaimManager.ReclaimInfo instance, ReclaimManager.ReclaimInfo previous) { }

	// RVA: 0x1DFDB30 Offset: 0x1DFC130 VA: 0x181DFDB30
	public static void Serialize(Stream stream, ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFDDF0 Offset: 0x1DFC3F0 VA: 0x181DFDDF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFDE00 Offset: 0x1DFC400 VA: 0x181DFDE00
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFDA20 Offset: 0x1DFC020 VA: 0x181DFDA20
	public static byte[] SerializeToBytes(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DFD970 Offset: 0x1DFBF70 VA: 0x181DFD970
	public static void SerializeLengthDelimited(Stream stream, ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ReclaimManager : BaseEntity // TypeDefIndex: 9887
{	// Fields
	private const int defaultReclaims = 128;
	private const int reclaimSlotCount = 40;

	// Methods

	// RVA: 0x6AC600 Offset: 0x6AAC00 VA: 0x1806AC600
	public void .ctor() { }

}

