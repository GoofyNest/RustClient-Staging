public class WaterPool : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6382
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fillAmount; // 0x14

	// Methods

	// RVA: 0x1E51520 Offset: 0x1E4FB20 VA: 0x181E51520
	public static void ResetToPool(WaterPool instance) { }

	// RVA: 0x1E515A0 Offset: 0x1E4FBA0 VA: 0x181E515A0
	public void ResetToPool() { }

	// RVA: 0x1E513F0 Offset: 0x1E4F9F0 VA: 0x181E513F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(WaterPool instance) { }

	// RVA: 0x1E508B0 Offset: 0x1E4EEB0 VA: 0x181E508B0
	public WaterPool Copy() { }

	// RVA: 0x1E51370 Offset: 0x1E4F970 VA: 0x181E51370
	public static WaterPool Deserialize(Stream stream) { }

	// RVA: 0x1E50920 Offset: 0x1E4EF20 VA: 0x181E50920
	public static WaterPool DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E50C50 Offset: 0x1E4F250 VA: 0x181E50C50
	public static WaterPool DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E51150 Offset: 0x1E4F750 VA: 0x181E51150
	public static WaterPool Deserialize(byte[] buffer) { }

	// RVA: 0x1E514E0 Offset: 0x1E4FAE0 VA: 0x181E514E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E51A30 Offset: 0x1E50030 VA: 0x181E51A30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E51A50 Offset: 0x1E50050 VA: 0x181E51A50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WaterPool previous) { }

	// RVA: 0x1E51500 Offset: 0x1E4FB00 VA: 0x181E51500 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E51270 Offset: 0x1E4F870 VA: 0x181E51270
	public static WaterPool Deserialize(byte[] buffer, WaterPool instance, bool isDelta = False) { }

	// RVA: 0x1E50F70 Offset: 0x1E4F570 VA: 0x181E50F70
	public static WaterPool Deserialize(Stream stream, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E509A0 Offset: 0x1E4EFA0 VA: 0x181E509A0
	public static WaterPool DeserializeLengthDelimited(Stream stream, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E50CE0 Offset: 0x1E4F2E0 VA: 0x181E50CE0
	public static WaterPool DeserializeLength(Stream stream, int length, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E51620 Offset: 0x1E4FC20 VA: 0x181E51620
	public static void SerializeDelta(Stream stream, WaterPool instance, WaterPool previous) { }

	// RVA: 0x1E51940 Offset: 0x1E4FF40 VA: 0x181E51940
	public static void Serialize(Stream stream, WaterPool instance) { }

	// RVA: 0x1E51A20 Offset: 0x1E50020 VA: 0x181E51A20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E51A30 Offset: 0x1E50030 VA: 0x181E51A30
	public void ToProto(Stream stream) { }

	// RVA: 0x1E51830 Offset: 0x1E4FE30 VA: 0x181E51830
	public static byte[] SerializeToBytes(WaterPool instance) { }

	// RVA: 0x1E51740 Offset: 0x1E4FD40 VA: 0x181E51740
	public static void SerializeLengthDelimited(Stream stream, WaterPool instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

