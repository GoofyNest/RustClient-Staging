public class WaterPool : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6382
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fillAmount; // 0x14

	// Methods

	// RVA: 0x1E51360 Offset: 0x1E4F960 VA: 0x181E51360
	public static void ResetToPool(WaterPool instance) { }

	// RVA: 0x1E513E0 Offset: 0x1E4F9E0 VA: 0x181E513E0
	public void ResetToPool() { }

	// RVA: 0x1E51230 Offset: 0x1E4F830 VA: 0x181E51230 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(WaterPool instance) { }

	// RVA: 0x1E506F0 Offset: 0x1E4ECF0 VA: 0x181E506F0
	public WaterPool Copy() { }

	// RVA: 0x1E511B0 Offset: 0x1E4F7B0 VA: 0x181E511B0
	public static WaterPool Deserialize(Stream stream) { }

	// RVA: 0x1E50760 Offset: 0x1E4ED60 VA: 0x181E50760
	public static WaterPool DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E50A90 Offset: 0x1E4F090 VA: 0x181E50A90
	public static WaterPool DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E50F90 Offset: 0x1E4F590 VA: 0x181E50F90
	public static WaterPool Deserialize(byte[] buffer) { }

	// RVA: 0x1E51320 Offset: 0x1E4F920 VA: 0x181E51320
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E51870 Offset: 0x1E4FE70 VA: 0x181E51870 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E51890 Offset: 0x1E4FE90 VA: 0x181E51890 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WaterPool previous) { }

	// RVA: 0x1E51340 Offset: 0x1E4F940 VA: 0x181E51340 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E510B0 Offset: 0x1E4F6B0 VA: 0x181E510B0
	public static WaterPool Deserialize(byte[] buffer, WaterPool instance, bool isDelta = False) { }

	// RVA: 0x1E50DB0 Offset: 0x1E4F3B0 VA: 0x181E50DB0
	public static WaterPool Deserialize(Stream stream, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E507E0 Offset: 0x1E4EDE0 VA: 0x181E507E0
	public static WaterPool DeserializeLengthDelimited(Stream stream, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E50B20 Offset: 0x1E4F120 VA: 0x181E50B20
	public static WaterPool DeserializeLength(Stream stream, int length, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E51460 Offset: 0x1E4FA60 VA: 0x181E51460
	public static void SerializeDelta(Stream stream, WaterPool instance, WaterPool previous) { }

	// RVA: 0x1E51780 Offset: 0x1E4FD80 VA: 0x181E51780
	public static void Serialize(Stream stream, WaterPool instance) { }

	// RVA: 0x1E51860 Offset: 0x1E4FE60 VA: 0x181E51860
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E51870 Offset: 0x1E4FE70 VA: 0x181E51870
	public void ToProto(Stream stream) { }

	// RVA: 0x1E51670 Offset: 0x1E4FC70 VA: 0x181E51670
	public static byte[] SerializeToBytes(WaterPool instance) { }

	// RVA: 0x1E51580 Offset: 0x1E4FB80 VA: 0x181E51580
	public static void SerializeLengthDelimited(Stream stream, WaterPool instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

