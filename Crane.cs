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

	// RVA: 0x20B5A00 Offset: 0x20B4000 VA: 0x1820B5A00
	public static void ResetToPool(Crane instance) { }

	// RVA: 0x20B5AC0 Offset: 0x20B40C0 VA: 0x1820B5AC0
	public void ResetToPool() { }

	// RVA: 0x20B5600 Offset: 0x20B3C00 VA: 0x1820B5600 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFB330 Offset: 0x1BF9930 VA: 0x181BFB330
	public void CopyTo(Crane instance) { }

	// RVA: 0x20B4100 Offset: 0x20B2700 VA: 0x1820B4100
	public Crane Copy() { }

	// RVA: 0x20B4960 Offset: 0x20B2F60 VA: 0x1820B4960
	public static Crane Deserialize(Stream stream) { }

	// RVA: 0x20B4190 Offset: 0x20B2790 VA: 0x1820B4190
	public static Crane DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B4580 Offset: 0x20B2B80 VA: 0x1820B4580
	public static Crane DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B5260 Offset: 0x20B3860 VA: 0x1820B5260
	public static Crane Deserialize(byte[] buffer) { }

	// RVA: 0x20B5740 Offset: 0x20B3D40 VA: 0x1820B5740
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B61D0 Offset: 0x20B47D0 VA: 0x1820B61D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B61F0 Offset: 0x20B47F0 VA: 0x1820B61F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Crane previous) { }

	// RVA: 0x20B59E0 Offset: 0x20B3FE0 VA: 0x1820B59E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B4EE0 Offset: 0x20B34E0 VA: 0x1820B4EE0
	public static Crane Deserialize(byte[] buffer, Crane instance, bool isDelta = False) { }

	// RVA: 0x20B4C40 Offset: 0x20B3240 VA: 0x1820B4C40
	public static Crane Deserialize(Stream stream, Crane instance, bool isDelta) { }

	// RVA: 0x20B4210 Offset: 0x20B2810 VA: 0x1820B4210
	public static Crane DeserializeLengthDelimited(Stream stream, Crane instance, bool isDelta) { }

	// RVA: 0x20B4610 Offset: 0x20B2C10 VA: 0x1820B4610
	public static Crane DeserializeLength(Stream stream, int length, Crane instance, bool isDelta) { }

	// RVA: 0x20B5B80 Offset: 0x20B4180 VA: 0x1820B5B80
	public static void SerializeDelta(Stream stream, Crane instance, Crane previous) { }

	// RVA: 0x20B6020 Offset: 0x20B4620 VA: 0x1820B6020
	public static void Serialize(Stream stream, Crane instance) { }

	// RVA: 0x20B61C0 Offset: 0x20B47C0 VA: 0x1820B61C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B61D0 Offset: 0x20B47D0 VA: 0x1820B61D0
	public void ToProto(Stream stream) { }

	// RVA: 0x20B5F10 Offset: 0x20B4510 VA: 0x1820B5F10
	public static byte[] SerializeToBytes(Crane instance) { }

	// RVA: 0x20B5E60 Offset: 0x20B4460 VA: 0x1820B5E60
	public static void SerializeLengthDelimited(Stream stream, Crane instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

