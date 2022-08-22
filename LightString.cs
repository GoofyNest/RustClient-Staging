public class LightString : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6372
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LightString.StringPoint> points; // 0x18
	public int lengthUsed; // 0x20
	public int animationStyle; // 0x24

	// Methods

	// RVA: 0x1F21450 Offset: 0x1F1FA50 VA: 0x181F21450
	public static void ResetToPool(LightString instance) { }

	// RVA: 0x1F21260 Offset: 0x1F1F860 VA: 0x181F21260
	public void ResetToPool() { }

	// RVA: 0x1F211A0 Offset: 0x1F1F7A0 VA: 0x181F211A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F20190 Offset: 0x1F1E790 VA: 0x181F20190
	public void CopyTo(LightString instance) { }

	// RVA: 0x1F20340 Offset: 0x1F1E940 VA: 0x181F20340
	public LightString Copy() { }

	// RVA: 0x1F21020 Offset: 0x1F1F620 VA: 0x181F21020
	public static LightString Deserialize(Stream stream) { }

	// RVA: 0x1F20540 Offset: 0x1F1EB40 VA: 0x181F20540
	public static LightString DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F20900 Offset: 0x1F1EF00 VA: 0x181F20900
	public static LightString DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F20CA0 Offset: 0x1F1F2A0 VA: 0x181F20CA0
	public static LightString Deserialize(byte[] buffer) { }

	// RVA: 0x1F21220 Offset: 0x1F1F820 VA: 0x181F21220
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F21D10 Offset: 0x1F20310 VA: 0x181F21D10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F21D30 Offset: 0x1F20330 VA: 0x181F21D30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightString previous) { }

	// RVA: 0x1F21240 Offset: 0x1F1F840 VA: 0x181F21240 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F210A0 Offset: 0x1F1F6A0 VA: 0x181F210A0
	public static LightString Deserialize(byte[] buffer, LightString instance, bool isDelta = False) { }

	// RVA: 0x1F20DC0 Offset: 0x1F1F3C0 VA: 0x181F20DC0
	public static LightString Deserialize(Stream stream, LightString instance, bool isDelta) { }

	// RVA: 0x1F205C0 Offset: 0x1F1EBC0 VA: 0x181F205C0
	public static LightString DeserializeLengthDelimited(Stream stream, LightString instance, bool isDelta) { }

	// RVA: 0x1F20990 Offset: 0x1F1EF90 VA: 0x181F20990
	public static LightString DeserializeLength(Stream stream, int length, LightString instance, bool isDelta) { }

	// RVA: 0x1F21640 Offset: 0x1F1FC40 VA: 0x181F21640
	public static void SerializeDelta(Stream stream, LightString instance, LightString previous) { }

	// RVA: 0x1F21AB0 Offset: 0x1F200B0 VA: 0x181F21AB0
	public static void Serialize(Stream stream, LightString instance) { }

	// RVA: 0x1F21D00 Offset: 0x1F20300 VA: 0x181F21D00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F21D10 Offset: 0x1F20310 VA: 0x181F21D10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F219A0 Offset: 0x1F1FFA0 VA: 0x181F219A0
	public static byte[] SerializeToBytes(LightString instance) { }

	// RVA: 0x1F218F0 Offset: 0x1F1FEF0 VA: 0x181F218F0
	public static void SerializeLengthDelimited(Stream stream, LightString instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class LightString.StringPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6373
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 point; // 0x14
	public Vector3 normal; // 0x20

	// Methods

	// RVA: 0x1F2DBD0 Offset: 0x1F2C1D0 VA: 0x181F2DBD0
	public static void ResetToPool(LightString.StringPoint instance) { }

	// RVA: 0x1F2DB40 Offset: 0x1F2C140 VA: 0x181F2DB40
	public void ResetToPool() { }

	// RVA: 0x1F2D920 Offset: 0x1F2BF20 VA: 0x181F2D920 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F21D50 Offset: 0x1F20350 VA: 0x181F21D50
	public void CopyTo(LightString.StringPoint instance) { }

	// RVA: 0x1F2CB40 Offset: 0x1F2B140 VA: 0x181F2CB40
	public LightString.StringPoint Copy() { }

	// RVA: 0x1F2D150 Offset: 0x1F2B750 VA: 0x181F2D150
	public static LightString.StringPoint Deserialize(Stream stream) { }

	// RVA: 0x1F2CE20 Offset: 0x1F2B420 VA: 0x181F2CE20
	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2D0C0 Offset: 0x1F2B6C0 VA: 0x181F2D0C0
	public static LightString.StringPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2D550 Offset: 0x1F2BB50 VA: 0x181F2D550
	public static LightString.StringPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F2D9A0 Offset: 0x1F2BFA0 VA: 0x181F2D9A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2E410 Offset: 0x1F2CA10 VA: 0x181F2E410 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2E430 Offset: 0x1F2CA30 VA: 0x181F2E430 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightString.StringPoint previous) { }

	// RVA: 0x1F2DB20 Offset: 0x1F2C120 VA: 0x181F2DB20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2D310 Offset: 0x1F2B910 VA: 0x181F2D310
	public static LightString.StringPoint Deserialize(byte[] buffer, LightString.StringPoint instance, bool isDelta = False) { }

	// RVA: 0x1F2D7A0 Offset: 0x1F2BDA0 VA: 0x181F2D7A0
	public static LightString.StringPoint Deserialize(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2CBD0 Offset: 0x1F2B1D0 VA: 0x181F2CBD0
	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2CEA0 Offset: 0x1F2B4A0 VA: 0x181F2CEA0
	public static LightString.StringPoint DeserializeLength(Stream stream, int length, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2DC60 Offset: 0x1F2C260 VA: 0x181F2DC60
	public static void SerializeDelta(Stream stream, LightString.StringPoint instance, LightString.StringPoint previous) { }

	// RVA: 0x1F2E1C0 Offset: 0x1F2C7C0 VA: 0x181F2E1C0
	public static void Serialize(Stream stream, LightString.StringPoint instance) { }

	// RVA: 0x1F2E400 Offset: 0x1F2CA00 VA: 0x181F2E400
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2E410 Offset: 0x1F2CA10 VA: 0x181F2E410
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2E0B0 Offset: 0x1F2C6B0 VA: 0x181F2E0B0
	public static byte[] SerializeToBytes(LightString.StringPoint instance) { }

	// RVA: 0x1F2E000 Offset: 0x1F2C600 VA: 0x181F2E000
	public static void SerializeLengthDelimited(Stream stream, LightString.StringPoint instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

