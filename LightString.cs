public class LightString : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6372
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LightString.StringPoint> points; // 0x18
	public int lengthUsed; // 0x20
	public int animationStyle; // 0x24

	// Methods

	// RVA: 0x1F21710 Offset: 0x1F1FD10 VA: 0x181F21710
	public static void ResetToPool(LightString instance) { }

	// RVA: 0x1F21520 Offset: 0x1F1FB20 VA: 0x181F21520
	public void ResetToPool() { }

	// RVA: 0x1F21460 Offset: 0x1F1FA60 VA: 0x181F21460 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F20450 Offset: 0x1F1EA50 VA: 0x181F20450
	public void CopyTo(LightString instance) { }

	// RVA: 0x1F20600 Offset: 0x1F1EC00 VA: 0x181F20600
	public LightString Copy() { }

	// RVA: 0x1F212E0 Offset: 0x1F1F8E0 VA: 0x181F212E0
	public static LightString Deserialize(Stream stream) { }

	// RVA: 0x1F20800 Offset: 0x1F1EE00 VA: 0x181F20800
	public static LightString DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F20BC0 Offset: 0x1F1F1C0 VA: 0x181F20BC0
	public static LightString DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F20F60 Offset: 0x1F1F560 VA: 0x181F20F60
	public static LightString Deserialize(byte[] buffer) { }

	// RVA: 0x1F214E0 Offset: 0x1F1FAE0 VA: 0x181F214E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F21FD0 Offset: 0x1F205D0 VA: 0x181F21FD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F21FF0 Offset: 0x1F205F0 VA: 0x181F21FF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightString previous) { }

	// RVA: 0x1F21500 Offset: 0x1F1FB00 VA: 0x181F21500 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F21360 Offset: 0x1F1F960 VA: 0x181F21360
	public static LightString Deserialize(byte[] buffer, LightString instance, bool isDelta = False) { }

	// RVA: 0x1F21080 Offset: 0x1F1F680 VA: 0x181F21080
	public static LightString Deserialize(Stream stream, LightString instance, bool isDelta) { }

	// RVA: 0x1F20880 Offset: 0x1F1EE80 VA: 0x181F20880
	public static LightString DeserializeLengthDelimited(Stream stream, LightString instance, bool isDelta) { }

	// RVA: 0x1F20C50 Offset: 0x1F1F250 VA: 0x181F20C50
	public static LightString DeserializeLength(Stream stream, int length, LightString instance, bool isDelta) { }

	// RVA: 0x1F21900 Offset: 0x1F1FF00 VA: 0x181F21900
	public static void SerializeDelta(Stream stream, LightString instance, LightString previous) { }

	// RVA: 0x1F21D70 Offset: 0x1F20370 VA: 0x181F21D70
	public static void Serialize(Stream stream, LightString instance) { }

	// RVA: 0x1F21FC0 Offset: 0x1F205C0 VA: 0x181F21FC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F21FD0 Offset: 0x1F205D0 VA: 0x181F21FD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F21C60 Offset: 0x1F20260 VA: 0x181F21C60
	public static byte[] SerializeToBytes(LightString instance) { }

	// RVA: 0x1F21BB0 Offset: 0x1F201B0 VA: 0x181F21BB0
	public static void SerializeLengthDelimited(Stream stream, LightString instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class LightString.StringPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6373
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 point; // 0x14
	public Vector3 normal; // 0x20

	// Methods

	// RVA: 0x1F2DE90 Offset: 0x1F2C490 VA: 0x181F2DE90
	public static void ResetToPool(LightString.StringPoint instance) { }

	// RVA: 0x1F2DE00 Offset: 0x1F2C400 VA: 0x181F2DE00
	public void ResetToPool() { }

	// RVA: 0x1F2DBE0 Offset: 0x1F2C1E0 VA: 0x181F2DBE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F22010 Offset: 0x1F20610 VA: 0x181F22010
	public void CopyTo(LightString.StringPoint instance) { }

	// RVA: 0x1F2CE00 Offset: 0x1F2B400 VA: 0x181F2CE00
	public LightString.StringPoint Copy() { }

	// RVA: 0x1F2D410 Offset: 0x1F2BA10 VA: 0x181F2D410
	public static LightString.StringPoint Deserialize(Stream stream) { }

	// RVA: 0x1F2D0E0 Offset: 0x1F2B6E0 VA: 0x181F2D0E0
	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2D380 Offset: 0x1F2B980 VA: 0x181F2D380
	public static LightString.StringPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2D810 Offset: 0x1F2BE10 VA: 0x181F2D810
	public static LightString.StringPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F2DC60 Offset: 0x1F2C260 VA: 0x181F2DC60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2E6D0 Offset: 0x1F2CCD0 VA: 0x181F2E6D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2E6F0 Offset: 0x1F2CCF0 VA: 0x181F2E6F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightString.StringPoint previous) { }

	// RVA: 0x1F2DDE0 Offset: 0x1F2C3E0 VA: 0x181F2DDE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2D5D0 Offset: 0x1F2BBD0 VA: 0x181F2D5D0
	public static LightString.StringPoint Deserialize(byte[] buffer, LightString.StringPoint instance, bool isDelta = False) { }

	// RVA: 0x1F2DA60 Offset: 0x1F2C060 VA: 0x181F2DA60
	public static LightString.StringPoint Deserialize(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2CE90 Offset: 0x1F2B490 VA: 0x181F2CE90
	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2D160 Offset: 0x1F2B760 VA: 0x181F2D160
	public static LightString.StringPoint DeserializeLength(Stream stream, int length, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2DF20 Offset: 0x1F2C520 VA: 0x181F2DF20
	public static void SerializeDelta(Stream stream, LightString.StringPoint instance, LightString.StringPoint previous) { }

	// RVA: 0x1F2E480 Offset: 0x1F2CA80 VA: 0x181F2E480
	public static void Serialize(Stream stream, LightString.StringPoint instance) { }

	// RVA: 0x1F2E6C0 Offset: 0x1F2CCC0 VA: 0x181F2E6C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2E6D0 Offset: 0x1F2CCD0 VA: 0x181F2E6D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2E370 Offset: 0x1F2C970 VA: 0x181F2E370
	public static byte[] SerializeToBytes(LightString.StringPoint instance) { }

	// RVA: 0x1F2E2C0 Offset: 0x1F2C8C0 VA: 0x181F2E2C0
	public static void SerializeLengthDelimited(Stream stream, LightString.StringPoint instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

