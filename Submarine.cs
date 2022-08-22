public class Submarine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6418
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float throttle; // 0x14
	public float upDown; // 0x18
	public float rudder; // 0x1C
	public uint fuelStorageID; // 0x20
	public float fuelAmount; // 0x24
	public uint torpedoStorageID; // 0x28
	public float oxygen; // 0x2C
	public uint itemStorageID; // 0x30

	// Methods

	// RVA: 0x1DC5300 Offset: 0x1DC3900 VA: 0x181DC5300
	public static void ResetToPool(Submarine instance) { }

	// RVA: 0x1DC53E0 Offset: 0x1DC39E0 VA: 0x181DC53E0
	public void ResetToPool() { }

	// RVA: 0x1DC4E40 Offset: 0x1DC3440 VA: 0x181DC4E40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC3560 Offset: 0x1DC1B60 VA: 0x181DC3560
	public void CopyTo(Submarine instance) { }

	// RVA: 0x1DC35B0 Offset: 0x1DC1BB0 VA: 0x181DC35B0
	public Submarine Copy() { }

	// RVA: 0x1DC46B0 Offset: 0x1DC2CB0 VA: 0x181DC46B0
	public static Submarine Deserialize(Stream stream) { }

	// RVA: 0x1DC3A50 Offset: 0x1DC2050 VA: 0x181DC3A50
	public static Submarine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC3AD0 Offset: 0x1DC20D0 VA: 0x181DC3AD0
	public static Submarine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC4270 Offset: 0x1DC2870 VA: 0x181DC4270
	public static Submarine Deserialize(byte[] buffer) { }

	// RVA: 0x1DC4FB0 Offset: 0x1DC35B0 VA: 0x181DC4FB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC5C00 Offset: 0x1DC4200 VA: 0x181DC5C00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC5C20 Offset: 0x1DC4220 VA: 0x181DC5C20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Submarine previous) { }

	// RVA: 0x1DC52E0 Offset: 0x1DC38E0 VA: 0x181DC52E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC4A20 Offset: 0x1DC3020 VA: 0x181DC4A20
	public static Submarine Deserialize(byte[] buffer, Submarine instance, bool isDelta = False) { }

	// RVA: 0x1DC3F40 Offset: 0x1DC2540 VA: 0x181DC3F40
	public static Submarine Deserialize(Stream stream, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC3650 Offset: 0x1DC1C50 VA: 0x181DC3650
	public static Submarine DeserializeLengthDelimited(Stream stream, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC3B60 Offset: 0x1DC2160 VA: 0x181DC3B60
	public static Submarine DeserializeLength(Stream stream, int length, Submarine instance, bool isDelta) { }

	// RVA: 0x1DC54C0 Offset: 0x1DC3AC0 VA: 0x181DC54C0
	public static void SerializeDelta(Stream stream, Submarine instance, Submarine previous) { }

	// RVA: 0x1DC5A10 Offset: 0x1DC4010 VA: 0x181DC5A10
	public static void Serialize(Stream stream, Submarine instance) { }

	// RVA: 0x1DC5BF0 Offset: 0x1DC41F0 VA: 0x181DC5BF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC5C00 Offset: 0x1DC4200 VA: 0x181DC5C00
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC5900 Offset: 0x1DC3F00 VA: 0x181DC5900
	public static byte[] SerializeToBytes(Submarine instance) { }

	// RVA: 0x1DC5850 Offset: 0x1DC3E50 VA: 0x181DC5850
	public static void SerializeLengthDelimited(Stream stream, Submarine instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

