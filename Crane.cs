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

	// RVA: 0x20B5740 Offset: 0x20B3D40 VA: 0x1820B5740
	public static void ResetToPool(Crane instance) { }

	// RVA: 0x20B5800 Offset: 0x20B3E00 VA: 0x1820B5800
	public void ResetToPool() { }

	// RVA: 0x20B5340 Offset: 0x20B3940 VA: 0x1820B5340 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFB070 Offset: 0x1BF9670 VA: 0x181BFB070
	public void CopyTo(Crane instance) { }

	// RVA: 0x20B3E40 Offset: 0x20B2440 VA: 0x1820B3E40
	public Crane Copy() { }

	// RVA: 0x20B46A0 Offset: 0x20B2CA0 VA: 0x1820B46A0
	public static Crane Deserialize(Stream stream) { }

	// RVA: 0x20B3ED0 Offset: 0x20B24D0 VA: 0x1820B3ED0
	public static Crane DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B42C0 Offset: 0x20B28C0 VA: 0x1820B42C0
	public static Crane DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B4FA0 Offset: 0x20B35A0 VA: 0x1820B4FA0
	public static Crane Deserialize(byte[] buffer) { }

	// RVA: 0x20B5480 Offset: 0x20B3A80 VA: 0x1820B5480
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B5F10 Offset: 0x20B4510 VA: 0x1820B5F10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B5F30 Offset: 0x20B4530 VA: 0x1820B5F30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Crane previous) { }

	// RVA: 0x20B5720 Offset: 0x20B3D20 VA: 0x1820B5720 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B4C20 Offset: 0x20B3220 VA: 0x1820B4C20
	public static Crane Deserialize(byte[] buffer, Crane instance, bool isDelta = False) { }

	// RVA: 0x20B4980 Offset: 0x20B2F80 VA: 0x1820B4980
	public static Crane Deserialize(Stream stream, Crane instance, bool isDelta) { }

	// RVA: 0x20B3F50 Offset: 0x20B2550 VA: 0x1820B3F50
	public static Crane DeserializeLengthDelimited(Stream stream, Crane instance, bool isDelta) { }

	// RVA: 0x20B4350 Offset: 0x20B2950 VA: 0x1820B4350
	public static Crane DeserializeLength(Stream stream, int length, Crane instance, bool isDelta) { }

	// RVA: 0x20B58C0 Offset: 0x20B3EC0 VA: 0x1820B58C0
	public static void SerializeDelta(Stream stream, Crane instance, Crane previous) { }

	// RVA: 0x20B5D60 Offset: 0x20B4360 VA: 0x1820B5D60
	public static void Serialize(Stream stream, Crane instance) { }

	// RVA: 0x20B5F00 Offset: 0x20B4500 VA: 0x1820B5F00
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B5F10 Offset: 0x20B4510 VA: 0x1820B5F10
	public void ToProto(Stream stream) { }

	// RVA: 0x20B5C50 Offset: 0x20B4250 VA: 0x1820B5C50
	public static byte[] SerializeToBytes(Crane instance) { }

	// RVA: 0x20B5BA0 Offset: 0x20B41A0 VA: 0x1820B5BA0
	public static void SerializeLengthDelimited(Stream stream, Crane instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

