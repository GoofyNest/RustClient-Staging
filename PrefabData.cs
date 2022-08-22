public class PrefabData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6509
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string category; // 0x18
	public uint id; // 0x20
	public VectorData position; // 0x24
	public VectorData rotation; // 0x30
	public VectorData scale; // 0x3C

	// Methods

	// RVA: 0x2047CC0 Offset: 0x20462C0 VA: 0x182047CC0
	public static void ResetToPool(PrefabData instance) { }

	// RVA: 0x2047DA0 Offset: 0x20463A0 VA: 0x182047DA0
	public void ResetToPool() { }

	// RVA: 0x2047900 Offset: 0x2045F00 VA: 0x182047900 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20465A0 Offset: 0x2044BA0 VA: 0x1820465A0
	public void CopyTo(PrefabData instance) { }

	// RVA: 0x2046610 Offset: 0x2044C10 VA: 0x182046610
	public PrefabData Copy() { }

	// RVA: 0x2047350 Offset: 0x2045950 VA: 0x182047350
	public static PrefabData Deserialize(Stream stream) { }

	// RVA: 0x20466D0 Offset: 0x2044CD0 VA: 0x1820466D0
	public static PrefabData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2046A70 Offset: 0x2045070 VA: 0x182046A70
	public static PrefabData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20475D0 Offset: 0x2045BD0 VA: 0x1820475D0
	public static PrefabData Deserialize(byte[] buffer) { }

	// RVA: 0x2047A60 Offset: 0x2046060 VA: 0x182047A60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2048860 Offset: 0x2046E60 VA: 0x182048860 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2048880 Offset: 0x2046E80 VA: 0x182048880 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PrefabData previous) { }

	// RVA: 0x2047CA0 Offset: 0x20462A0 VA: 0x182047CA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2047040 Offset: 0x2045640 VA: 0x182047040
	public static PrefabData Deserialize(byte[] buffer, PrefabData instance, bool isDelta = False) { }

	// RVA: 0x2046E00 Offset: 0x2045400 VA: 0x182046E00
	public static PrefabData Deserialize(Stream stream, PrefabData instance, bool isDelta) { }

	// RVA: 0x2046750 Offset: 0x2044D50 VA: 0x182046750
	public static PrefabData DeserializeLengthDelimited(Stream stream, PrefabData instance, bool isDelta) { }

	// RVA: 0x2046B00 Offset: 0x2045100 VA: 0x182046B00
	public static PrefabData DeserializeLength(Stream stream, int length, PrefabData instance, bool isDelta) { }

	// RVA: 0x2047E80 Offset: 0x2046480 VA: 0x182047E80
	public static void SerializeDelta(Stream stream, PrefabData instance, PrefabData previous) { }

	// RVA: 0x20484A0 Offset: 0x2046AA0 VA: 0x1820484A0
	public static void Serialize(Stream stream, PrefabData instance) { }

	// RVA: 0x2048850 Offset: 0x2046E50 VA: 0x182048850
	public byte[] ToProtoBytes() { }

	// RVA: 0x2048860 Offset: 0x2046E60 VA: 0x182048860
	public void ToProto(Stream stream) { }

	// RVA: 0x2048390 Offset: 0x2046990 VA: 0x182048390
	public static byte[] SerializeToBytes(PrefabData instance) { }

	// RVA: 0x20482E0 Offset: 0x20468E0 VA: 0x1820482E0
	public static void SerializeLengthDelimited(Stream stream, PrefabData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

