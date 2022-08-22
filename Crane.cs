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

	// RVA: 0x20B6220 Offset: 0x20B4820 VA: 0x1820B6220
	public static void ResetToPool(Crane instance) { }

	// RVA: 0x20B62E0 Offset: 0x20B48E0 VA: 0x1820B62E0
	public void ResetToPool() { }

	// RVA: 0x20B5E20 Offset: 0x20B4420 VA: 0x1820B5E20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFBB20 Offset: 0x1BFA120 VA: 0x181BFBB20
	public void CopyTo(Crane instance) { }

	// RVA: 0x20B4920 Offset: 0x20B2F20 VA: 0x1820B4920
	public Crane Copy() { }

	// RVA: 0x20B5180 Offset: 0x20B3780 VA: 0x1820B5180
	public static Crane Deserialize(Stream stream) { }

	// RVA: 0x20B49B0 Offset: 0x20B2FB0 VA: 0x1820B49B0
	public static Crane DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B4DA0 Offset: 0x20B33A0 VA: 0x1820B4DA0
	public static Crane DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B5A80 Offset: 0x20B4080 VA: 0x1820B5A80
	public static Crane Deserialize(byte[] buffer) { }

	// RVA: 0x20B5F60 Offset: 0x20B4560 VA: 0x1820B5F60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B69F0 Offset: 0x20B4FF0 VA: 0x1820B69F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B6A10 Offset: 0x20B5010 VA: 0x1820B6A10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Crane previous) { }

	// RVA: 0x20B6200 Offset: 0x20B4800 VA: 0x1820B6200 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B5700 Offset: 0x20B3D00 VA: 0x1820B5700
	public static Crane Deserialize(byte[] buffer, Crane instance, bool isDelta = False) { }

	// RVA: 0x20B5460 Offset: 0x20B3A60 VA: 0x1820B5460
	public static Crane Deserialize(Stream stream, Crane instance, bool isDelta) { }

	// RVA: 0x20B4A30 Offset: 0x20B3030 VA: 0x1820B4A30
	public static Crane DeserializeLengthDelimited(Stream stream, Crane instance, bool isDelta) { }

	// RVA: 0x20B4E30 Offset: 0x20B3430 VA: 0x1820B4E30
	public static Crane DeserializeLength(Stream stream, int length, Crane instance, bool isDelta) { }

	// RVA: 0x20B63A0 Offset: 0x20B49A0 VA: 0x1820B63A0
	public static void SerializeDelta(Stream stream, Crane instance, Crane previous) { }

	// RVA: 0x20B6840 Offset: 0x20B4E40 VA: 0x1820B6840
	public static void Serialize(Stream stream, Crane instance) { }

	// RVA: 0x20B69E0 Offset: 0x20B4FE0 VA: 0x1820B69E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B69F0 Offset: 0x20B4FF0 VA: 0x1820B69F0
	public void ToProto(Stream stream) { }

	// RVA: 0x20B6730 Offset: 0x20B4D30 VA: 0x1820B6730
	public static byte[] SerializeToBytes(Crane instance) { }

	// RVA: 0x20B6680 Offset: 0x20B4C80 VA: 0x1820B6680
	public static void SerializeLengthDelimited(Stream stream, Crane instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

