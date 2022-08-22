public class WaterPool : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6382
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fillAmount; // 0x14

	// Methods

	// RVA: 0x1E51E40 Offset: 0x1E50440 VA: 0x181E51E40
	public static void ResetToPool(WaterPool instance) { }

	// RVA: 0x1E51EC0 Offset: 0x1E504C0 VA: 0x181E51EC0
	public void ResetToPool() { }

	// RVA: 0x1E51D10 Offset: 0x1E50310 VA: 0x181E51D10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(WaterPool instance) { }

	// RVA: 0x1E511D0 Offset: 0x1E4F7D0 VA: 0x181E511D0
	public WaterPool Copy() { }

	// RVA: 0x1E51C90 Offset: 0x1E50290 VA: 0x181E51C90
	public static WaterPool Deserialize(Stream stream) { }

	// RVA: 0x1E51240 Offset: 0x1E4F840 VA: 0x181E51240
	public static WaterPool DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E51570 Offset: 0x1E4FB70 VA: 0x181E51570
	public static WaterPool DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E51A70 Offset: 0x1E50070 VA: 0x181E51A70
	public static WaterPool Deserialize(byte[] buffer) { }

	// RVA: 0x1E51E00 Offset: 0x1E50400 VA: 0x181E51E00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E52350 Offset: 0x1E50950 VA: 0x181E52350 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E52370 Offset: 0x1E50970 VA: 0x181E52370 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WaterPool previous) { }

	// RVA: 0x1E51E20 Offset: 0x1E50420 VA: 0x181E51E20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E51B90 Offset: 0x1E50190 VA: 0x181E51B90
	public static WaterPool Deserialize(byte[] buffer, WaterPool instance, bool isDelta = False) { }

	// RVA: 0x1E51890 Offset: 0x1E4FE90 VA: 0x181E51890
	public static WaterPool Deserialize(Stream stream, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E512C0 Offset: 0x1E4F8C0 VA: 0x181E512C0
	public static WaterPool DeserializeLengthDelimited(Stream stream, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E51600 Offset: 0x1E4FC00 VA: 0x181E51600
	public static WaterPool DeserializeLength(Stream stream, int length, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E51F40 Offset: 0x1E50540 VA: 0x181E51F40
	public static void SerializeDelta(Stream stream, WaterPool instance, WaterPool previous) { }

	// RVA: 0x1E52260 Offset: 0x1E50860 VA: 0x181E52260
	public static void Serialize(Stream stream, WaterPool instance) { }

	// RVA: 0x1E52340 Offset: 0x1E50940 VA: 0x181E52340
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E52350 Offset: 0x1E50950 VA: 0x181E52350
	public void ToProto(Stream stream) { }

	// RVA: 0x1E52150 Offset: 0x1E50750 VA: 0x181E52150
	public static byte[] SerializeToBytes(WaterPool instance) { }

	// RVA: 0x1E52060 Offset: 0x1E50660 VA: 0x181E52060
	public static void SerializeLengthDelimited(Stream stream, WaterPool instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

