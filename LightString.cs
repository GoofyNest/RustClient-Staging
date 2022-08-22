public class LightString : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6372
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LightString.StringPoint> points; // 0x18
	public int lengthUsed; // 0x20
	public int animationStyle; // 0x24

	// Methods

	// RVA: 0x1F21F30 Offset: 0x1F20530 VA: 0x181F21F30
	public static void ResetToPool(LightString instance) { }

	// RVA: 0x1F21D40 Offset: 0x1F20340 VA: 0x181F21D40
	public void ResetToPool() { }

	// RVA: 0x1F21C80 Offset: 0x1F20280 VA: 0x181F21C80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F20C70 Offset: 0x1F1F270 VA: 0x181F20C70
	public void CopyTo(LightString instance) { }

	// RVA: 0x1F20E20 Offset: 0x1F1F420 VA: 0x181F20E20
	public LightString Copy() { }

	// RVA: 0x1F21B00 Offset: 0x1F20100 VA: 0x181F21B00
	public static LightString Deserialize(Stream stream) { }

	// RVA: 0x1F21020 Offset: 0x1F1F620 VA: 0x181F21020
	public static LightString DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F213E0 Offset: 0x1F1F9E0 VA: 0x181F213E0
	public static LightString DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F21780 Offset: 0x1F1FD80 VA: 0x181F21780
	public static LightString Deserialize(byte[] buffer) { }

	// RVA: 0x1F21D00 Offset: 0x1F20300 VA: 0x181F21D00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F227F0 Offset: 0x1F20DF0 VA: 0x181F227F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F22810 Offset: 0x1F20E10 VA: 0x181F22810 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightString previous) { }

	// RVA: 0x1F21D20 Offset: 0x1F20320 VA: 0x181F21D20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F21B80 Offset: 0x1F20180 VA: 0x181F21B80
	public static LightString Deserialize(byte[] buffer, LightString instance, bool isDelta = False) { }

	// RVA: 0x1F218A0 Offset: 0x1F1FEA0 VA: 0x181F218A0
	public static LightString Deserialize(Stream stream, LightString instance, bool isDelta) { }

	// RVA: 0x1F210A0 Offset: 0x1F1F6A0 VA: 0x181F210A0
	public static LightString DeserializeLengthDelimited(Stream stream, LightString instance, bool isDelta) { }

	// RVA: 0x1F21470 Offset: 0x1F1FA70 VA: 0x181F21470
	public static LightString DeserializeLength(Stream stream, int length, LightString instance, bool isDelta) { }

	// RVA: 0x1F22120 Offset: 0x1F20720 VA: 0x181F22120
	public static void SerializeDelta(Stream stream, LightString instance, LightString previous) { }

	// RVA: 0x1F22590 Offset: 0x1F20B90 VA: 0x181F22590
	public static void Serialize(Stream stream, LightString instance) { }

	// RVA: 0x1F227E0 Offset: 0x1F20DE0 VA: 0x181F227E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F227F0 Offset: 0x1F20DF0 VA: 0x181F227F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F22480 Offset: 0x1F20A80 VA: 0x181F22480
	public static byte[] SerializeToBytes(LightString instance) { }

	// RVA: 0x1F223D0 Offset: 0x1F209D0 VA: 0x181F223D0
	public static void SerializeLengthDelimited(Stream stream, LightString instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class LightString.StringPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6373
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 point; // 0x14
	public Vector3 normal; // 0x20

	// Methods

	// RVA: 0x1F2E6B0 Offset: 0x1F2CCB0 VA: 0x181F2E6B0
	public static void ResetToPool(LightString.StringPoint instance) { }

	// RVA: 0x1F2E620 Offset: 0x1F2CC20 VA: 0x181F2E620
	public void ResetToPool() { }

	// RVA: 0x1F2E400 Offset: 0x1F2CA00 VA: 0x181F2E400 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F22830 Offset: 0x1F20E30 VA: 0x181F22830
	public void CopyTo(LightString.StringPoint instance) { }

	// RVA: 0x1F2D620 Offset: 0x1F2BC20 VA: 0x181F2D620
	public LightString.StringPoint Copy() { }

	// RVA: 0x1F2DC30 Offset: 0x1F2C230 VA: 0x181F2DC30
	public static LightString.StringPoint Deserialize(Stream stream) { }

	// RVA: 0x1F2D900 Offset: 0x1F2BF00 VA: 0x181F2D900
	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2DBA0 Offset: 0x1F2C1A0 VA: 0x181F2DBA0
	public static LightString.StringPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2E030 Offset: 0x1F2C630 VA: 0x181F2E030
	public static LightString.StringPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F2E480 Offset: 0x1F2CA80 VA: 0x181F2E480
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2EEF0 Offset: 0x1F2D4F0 VA: 0x181F2EEF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2EF10 Offset: 0x1F2D510 VA: 0x181F2EF10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightString.StringPoint previous) { }

	// RVA: 0x1F2E600 Offset: 0x1F2CC00 VA: 0x181F2E600 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2DDF0 Offset: 0x1F2C3F0 VA: 0x181F2DDF0
	public static LightString.StringPoint Deserialize(byte[] buffer, LightString.StringPoint instance, bool isDelta = False) { }

	// RVA: 0x1F2E280 Offset: 0x1F2C880 VA: 0x181F2E280
	public static LightString.StringPoint Deserialize(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2D6B0 Offset: 0x1F2BCB0 VA: 0x181F2D6B0
	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2D980 Offset: 0x1F2BF80 VA: 0x181F2D980
	public static LightString.StringPoint DeserializeLength(Stream stream, int length, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F2E740 Offset: 0x1F2CD40 VA: 0x181F2E740
	public static void SerializeDelta(Stream stream, LightString.StringPoint instance, LightString.StringPoint previous) { }

	// RVA: 0x1F2ECA0 Offset: 0x1F2D2A0 VA: 0x181F2ECA0
	public static void Serialize(Stream stream, LightString.StringPoint instance) { }

	// RVA: 0x1F2EEE0 Offset: 0x1F2D4E0 VA: 0x181F2EEE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2EEF0 Offset: 0x1F2D4F0 VA: 0x181F2EEF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2EB90 Offset: 0x1F2D190 VA: 0x181F2EB90
	public static byte[] SerializeToBytes(LightString.StringPoint instance) { }

	// RVA: 0x1F2EAE0 Offset: 0x1F2D0E0 VA: 0x181F2EAE0
	public static void SerializeLengthDelimited(Stream stream, LightString.StringPoint instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

