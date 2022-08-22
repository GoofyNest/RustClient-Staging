public class WaterPool : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6382
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fillAmount; // 0x14

	// Methods

	// RVA: 0x1E51620 Offset: 0x1E4FC20 VA: 0x181E51620
	public static void ResetToPool(WaterPool instance) { }

	// RVA: 0x1E516A0 Offset: 0x1E4FCA0 VA: 0x181E516A0
	public void ResetToPool() { }

	// RVA: 0x1E514F0 Offset: 0x1E4FAF0 VA: 0x181E514F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(WaterPool instance) { }

	// RVA: 0x1E509B0 Offset: 0x1E4EFB0 VA: 0x181E509B0
	public WaterPool Copy() { }

	// RVA: 0x1E51470 Offset: 0x1E4FA70 VA: 0x181E51470
	public static WaterPool Deserialize(Stream stream) { }

	// RVA: 0x1E50A20 Offset: 0x1E4F020 VA: 0x181E50A20
	public static WaterPool DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E50D50 Offset: 0x1E4F350 VA: 0x181E50D50
	public static WaterPool DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E51250 Offset: 0x1E4F850 VA: 0x181E51250
	public static WaterPool Deserialize(byte[] buffer) { }

	// RVA: 0x1E515E0 Offset: 0x1E4FBE0 VA: 0x181E515E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E51B30 Offset: 0x1E50130 VA: 0x181E51B30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E51B50 Offset: 0x1E50150 VA: 0x181E51B50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WaterPool previous) { }

	// RVA: 0x1E51600 Offset: 0x1E4FC00 VA: 0x181E51600 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E51370 Offset: 0x1E4F970 VA: 0x181E51370
	public static WaterPool Deserialize(byte[] buffer, WaterPool instance, bool isDelta = False) { }

	// RVA: 0x1E51070 Offset: 0x1E4F670 VA: 0x181E51070
	public static WaterPool Deserialize(Stream stream, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E50AA0 Offset: 0x1E4F0A0 VA: 0x181E50AA0
	public static WaterPool DeserializeLengthDelimited(Stream stream, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E50DE0 Offset: 0x1E4F3E0 VA: 0x181E50DE0
	public static WaterPool DeserializeLength(Stream stream, int length, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E51720 Offset: 0x1E4FD20 VA: 0x181E51720
	public static void SerializeDelta(Stream stream, WaterPool instance, WaterPool previous) { }

	// RVA: 0x1E51A40 Offset: 0x1E50040 VA: 0x181E51A40
	public static void Serialize(Stream stream, WaterPool instance) { }

	// RVA: 0x1E51B20 Offset: 0x1E50120 VA: 0x181E51B20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E51B30 Offset: 0x1E50130 VA: 0x181E51B30
	public void ToProto(Stream stream) { }

	// RVA: 0x1E51930 Offset: 0x1E4FF30 VA: 0x181E51930
	public static byte[] SerializeToBytes(WaterPool instance) { }

	// RVA: 0x1E51840 Offset: 0x1E4FE40 VA: 0x181E51840
	public static void SerializeLengthDelimited(Stream stream, WaterPool instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

