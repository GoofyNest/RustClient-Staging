public class Crane : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6413
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float yaw; // 0x14
	public float arm1; // 0x18
	public float arm2; // 0x1C
	public float magnet; // 0x20
	public float time; // 0x24
	public int treadInput; // 0x28

	// Methods

	// RVA: 0x20B5900 Offset: 0x20B3F00 VA: 0x1820B5900
	public static void ResetToPool(Crane instance) { }

	// RVA: 0x20B59C0 Offset: 0x20B3FC0 VA: 0x1820B59C0
	public void ResetToPool() { }

	// RVA: 0x20B5500 Offset: 0x20B3B00 VA: 0x1820B5500 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFB230 Offset: 0x1BF9830 VA: 0x181BFB230
	public void CopyTo(Crane instance) { }

	// RVA: 0x20B4000 Offset: 0x20B2600 VA: 0x1820B4000
	public Crane Copy() { }

	// RVA: 0x20B4860 Offset: 0x20B2E60 VA: 0x1820B4860
	public static Crane Deserialize(Stream stream) { }

	// RVA: 0x20B4090 Offset: 0x20B2690 VA: 0x1820B4090
	public static Crane DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B4480 Offset: 0x20B2A80 VA: 0x1820B4480
	public static Crane DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B5160 Offset: 0x20B3760 VA: 0x1820B5160
	public static Crane Deserialize(byte[] buffer) { }

	// RVA: 0x20B5640 Offset: 0x20B3C40 VA: 0x1820B5640
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B60D0 Offset: 0x20B46D0 VA: 0x1820B60D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B60F0 Offset: 0x20B46F0 VA: 0x1820B60F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Crane previous) { }

	// RVA: 0x20B58E0 Offset: 0x20B3EE0 VA: 0x1820B58E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B4DE0 Offset: 0x20B33E0 VA: 0x1820B4DE0
	public static Crane Deserialize(byte[] buffer, Crane instance, bool isDelta = False) { }

	// RVA: 0x20B4B40 Offset: 0x20B3140 VA: 0x1820B4B40
	public static Crane Deserialize(Stream stream, Crane instance, bool isDelta) { }

	// RVA: 0x20B4110 Offset: 0x20B2710 VA: 0x1820B4110
	public static Crane DeserializeLengthDelimited(Stream stream, Crane instance, bool isDelta) { }

	// RVA: 0x20B4510 Offset: 0x20B2B10 VA: 0x1820B4510
	public static Crane DeserializeLength(Stream stream, int length, Crane instance, bool isDelta) { }

	// RVA: 0x20B5A80 Offset: 0x20B4080 VA: 0x1820B5A80
	public static void SerializeDelta(Stream stream, Crane instance, Crane previous) { }

	// RVA: 0x20B5F20 Offset: 0x20B4520 VA: 0x1820B5F20
	public static void Serialize(Stream stream, Crane instance) { }

	// RVA: 0x20B60C0 Offset: 0x20B46C0 VA: 0x1820B60C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B60D0 Offset: 0x20B46D0 VA: 0x1820B60D0
	public void ToProto(Stream stream) { }

	// RVA: 0x20B5E10 Offset: 0x20B4410 VA: 0x1820B5E10
	public static byte[] SerializeToBytes(Crane instance) { }

	// RVA: 0x20B5D60 Offset: 0x20B4360 VA: 0x1820B5D60
	public static void SerializeLengthDelimited(Stream stream, Crane instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

