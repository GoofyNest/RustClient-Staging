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

	// RVA: 0x20487A0 Offset: 0x2046DA0 VA: 0x1820487A0
	public static void ResetToPool(PrefabData instance) { }

	// RVA: 0x2048880 Offset: 0x2046E80 VA: 0x182048880
	public void ResetToPool() { }

	// RVA: 0x20483E0 Offset: 0x20469E0 VA: 0x1820483E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2047080 Offset: 0x2045680 VA: 0x182047080
	public void CopyTo(PrefabData instance) { }

	// RVA: 0x20470F0 Offset: 0x20456F0 VA: 0x1820470F0
	public PrefabData Copy() { }

	// RVA: 0x2047E30 Offset: 0x2046430 VA: 0x182047E30
	public static PrefabData Deserialize(Stream stream) { }

	// RVA: 0x20471B0 Offset: 0x20457B0 VA: 0x1820471B0
	public static PrefabData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2047550 Offset: 0x2045B50 VA: 0x182047550
	public static PrefabData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20480B0 Offset: 0x20466B0 VA: 0x1820480B0
	public static PrefabData Deserialize(byte[] buffer) { }

	// RVA: 0x2048540 Offset: 0x2046B40 VA: 0x182048540
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2049340 Offset: 0x2047940 VA: 0x182049340 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2049360 Offset: 0x2047960 VA: 0x182049360 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PrefabData previous) { }

	// RVA: 0x2048780 Offset: 0x2046D80 VA: 0x182048780 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2047B20 Offset: 0x2046120 VA: 0x182047B20
	public static PrefabData Deserialize(byte[] buffer, PrefabData instance, bool isDelta = False) { }

	// RVA: 0x20478E0 Offset: 0x2045EE0 VA: 0x1820478E0
	public static PrefabData Deserialize(Stream stream, PrefabData instance, bool isDelta) { }

	// RVA: 0x2047230 Offset: 0x2045830 VA: 0x182047230
	public static PrefabData DeserializeLengthDelimited(Stream stream, PrefabData instance, bool isDelta) { }

	// RVA: 0x20475E0 Offset: 0x2045BE0 VA: 0x1820475E0
	public static PrefabData DeserializeLength(Stream stream, int length, PrefabData instance, bool isDelta) { }

	// RVA: 0x2048960 Offset: 0x2046F60 VA: 0x182048960
	public static void SerializeDelta(Stream stream, PrefabData instance, PrefabData previous) { }

	// RVA: 0x2048F80 Offset: 0x2047580 VA: 0x182048F80
	public static void Serialize(Stream stream, PrefabData instance) { }

	// RVA: 0x2049330 Offset: 0x2047930 VA: 0x182049330
	public byte[] ToProtoBytes() { }

	// RVA: 0x2049340 Offset: 0x2047940 VA: 0x182049340
	public void ToProto(Stream stream) { }

	// RVA: 0x2048E70 Offset: 0x2047470 VA: 0x182048E70
	public static byte[] SerializeToBytes(PrefabData instance) { }

	// RVA: 0x2048DC0 Offset: 0x20473C0 VA: 0x182048DC0
	public static void SerializeLengthDelimited(Stream stream, PrefabData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

