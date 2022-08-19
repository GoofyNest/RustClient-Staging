public class LightString : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6372
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LightString.StringPoint> points; // 0x18
	public int lengthUsed; // 0x20
	public int animationStyle; // 0x24

	// Methods

	// RVA: 0x1F21610 Offset: 0x1F1FC10 VA: 0x181F21610
	public static void ResetToPool(LightString instance) { }

	// RVA: 0x1F21420 Offset: 0x1F1FA20 VA: 0x181F21420
	public void ResetToPool() { }

	// RVA: 0x1F21360 Offset: 0x1F1F960 VA: 0x181F21360 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F20350 Offset: 0x1F1E950 VA: 0x181F20350
	public void CopyTo(LightString instance) { }

	// RVA: 0x1F20500 Offset: 0x1F1EB00 VA: 0x181F20500
	public LightString Copy() { }

	// RVA: 0x1F211E0 Offset: 0x1F1F7E0 VA: 0x181F211E0
	public static LightString Deserialize(Stream stream) { }

	// RVA: 0x1F20700 Offset: 0x1F1ED00 VA: 0x181F20700
	public static LightString DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F20AC0 Offset: 0x1F1F0C0 VA: 0x181F20AC0
	public static LightString DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F20E60 Offset: 0x1F1F460 VA: 0x181F20E60
	public static LightString Deserialize(byte[] buffer) { }

	// RVA: 0x1F213E0 Offset: 0x1F1F9E0 VA: 0x181F213E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F21ED0 Offset: 0x1F204D0 VA: 0x181F21ED0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F21EF0 Offset: 0x1F204F0 VA: 0x181F21EF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightString previous) { }

	// RVA: 0x1F21400 Offset: 0x1F1FA00 VA: 0x181F21400 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F21260 Offset: 0x1F1F860 VA: 0x181F21260
	public static LightString Deserialize(byte[] buffer, LightString instance, bool isDelta = False) { }

	// RVA: 0x1F20F80 Offset: 0x1F1F580 VA: 0x181F20F80
	public static LightString Deserialize(Stream stream, LightString instance, bool isDelta) { }

	// RVA: 0x1F20780 Offset: 0x1F1ED80 VA: 0x181F20780
	public static LightString DeserializeLengthDelimited(Stream stream, LightString instance, bool isDelta) { }

	// RVA: 0x1F20B50 Offset: 0x1F1F150 VA: 0x181F20B50
	public static LightString DeserializeLength(Stream stream, int length, LightString instance, bool isDelta) { }

	// RVA: 0x1F21800 Offset: 0x1F1FE00 VA: 0x181F21800
	public static void SerializeDelta(Stream stream, LightString instance, LightString previous) { }

	// RVA: 0x1F21C70 Offset: 0x1F20270 VA: 0x181F21C70
	public static void Serialize(Stream stream, LightString instance) { }

	// RVA: 0x1F21EC0 Offset: 0x1F204C0 VA: 0x181F21EC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F21ED0 Offset: 0x1F204D0 VA: 0x181F21ED0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F21B60 Offset: 0x1F20160 VA: 0x181F21B60
	public static byte[] SerializeToBytes(LightString instance) { }

	// RVA: 0x1F21AB0 Offset: 0x1F200B0 VA: 0x181F21AB0
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

	// RVA: 0x1F2DD90 Offset: 0x1F2C390 VA: 0x181F2DD90
	public static void ResetToPool(LightString.StringPoint instance) { }

	// RVA: 0x1F2DD00 Offset: 0x1F2C300 VA: 0x181F2DD00
	public void ResetToPool() { }

	// RVA: 0x1F2DAE0 Offset: 0x1F2C0E0 VA: 0x181F2DAE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F21F10 Offset: 0x1F20510 VA: 0x181F21F10
	public void CopyTo(LightString.StringPoint instance) { }

	// RVA: 0x1F2CD00 Offset: 0x1F2B300 VA: 0x181F2CD00
	public LightString.StringPoint Copy() { }

	// RVA: 0x1F2D310 Offset: 0x1F2B910 VA: 0x181F2D310
	public static LightString.StringPoint Deserialize(Stream stream) { }

	// RVA: 0x1F2CFE0 Offset: 0x1F2B5E0 VA: 0x181F2CFE0
	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2D280 Offset: 0x1F2B880 VA: 0x181F2D280
	public static LightString.StringPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2D710 Offset: 0x1F2BD10 VA: 0x181F2D710
	public static LightString.StringPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F2DB60 Offset: 0x1F2C160 VA: 0x181F2DB60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2E5D0 Offset: 0x1F2CBD0 VA: 0x181F2E5D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2E5F0 Offset: 0x1F2CBF0 VA: 0x181F2E5F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightString.StringPoint previous) { }

	// RVA: 0x1F2DCE0 Offset: 0x1F2C2E0 VA: 0x181F2DCE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2D4D0 Offset: 0x1F2BAD0 VA: 0x181F2D4D0
	public static LightString.StringPoint Deserialize(byte[] buffer, LightString.StringPoint instance, bool isDelta = False) { }

	// RVA: 0x1F2D960 Offset: 0x1F2BF60 VA: 0x181F2D960
	public static LightString.StringPoint Deserialize(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2CD90 Offset: 0x1F2B390 VA: 0x181F2CD90
	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2D060 Offset: 0x1F2B660 VA: 0x181F2D060
	public static LightString.StringPoint DeserializeLength(Stream stream, int length, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2DE20 Offset: 0x1F2C420 VA: 0x181F2DE20
	public static void SerializeDelta(Stream stream, LightString.StringPoint instance, LightString.StringPoint previous) { }

	// RVA: 0x1F2E380 Offset: 0x1F2C980 VA: 0x181F2E380
	public static void Serialize(Stream stream, LightString.StringPoint instance) { }

	// RVA: 0x1F2E5C0 Offset: 0x1F2CBC0 VA: 0x181F2E5C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2E5D0 Offset: 0x1F2CBD0 VA: 0x181F2E5D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2E270 Offset: 0x1F2C870 VA: 0x181F2E270
	public static byte[] SerializeToBytes(LightString.StringPoint instance) { }

	// RVA: 0x1F2E1C0 Offset: 0x1F2C7C0 VA: 0x181F2E1C0
	public static void SerializeLengthDelimited(Stream stream, LightString.StringPoint instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

