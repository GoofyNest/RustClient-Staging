public class DeliveryDrone : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6398
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint marketplaceId; // 0x14
	public uint terminalId; // 0x18
	public uint vendingMachineId; // 0x1C
	public int state; // 0x20

	// Methods

	// RVA: 0x20BC500 Offset: 0x20BAB00 VA: 0x1820BC500
	public static void ResetToPool(DeliveryDrone instance) { }

	// RVA: 0x20BC5A0 Offset: 0x20BABA0 VA: 0x1820BC5A0
	public void ResetToPool() { }

	// RVA: 0x20BC1B0 Offset: 0x20BA7B0 VA: 0x1820BC1B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C071E0 Offset: 0x1C057E0 VA: 0x181C071E0
	public void CopyTo(DeliveryDrone instance) { }

	// RVA: 0x20BB020 Offset: 0x20B9620 VA: 0x1820BB020
	public DeliveryDrone Copy() { }

	// RVA: 0x20BB750 Offset: 0x20B9D50 VA: 0x1820BB750
	public static DeliveryDrone Deserialize(Stream stream) { }

	// RVA: 0x20BB380 Offset: 0x20B9980 VA: 0x1820BB380
	public static DeliveryDrone DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BB400 Offset: 0x20B9A00 VA: 0x1820BB400
	public static DeliveryDrone DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BB9A0 Offset: 0x20B9FA0 VA: 0x1820BB9A0
	public static DeliveryDrone Deserialize(byte[] buffer) { }

	// RVA: 0x20BC2D0 Offset: 0x20BA8D0 VA: 0x1820BC2D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BCB60 Offset: 0x20BB160 VA: 0x1820BCB60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BCB80 Offset: 0x20BB180 VA: 0x1820BCB80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DeliveryDrone previous) { }

	// RVA: 0x20BC4E0 Offset: 0x20BAAE0 VA: 0x1820BC4E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BBCB0 Offset: 0x20BA2B0 VA: 0x1820BBCB0
	public static DeliveryDrone Deserialize(byte[] buffer, DeliveryDrone instance, bool isDelta = False) { }

	// RVA: 0x20BBFA0 Offset: 0x20BA5A0 VA: 0x1820BBFA0
	public static DeliveryDrone Deserialize(Stream stream, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BB0A0 Offset: 0x20B96A0 VA: 0x1820BB0A0
	public static DeliveryDrone DeserializeLengthDelimited(Stream stream, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BB490 Offset: 0x20B9A90 VA: 0x1820BB490
	public static DeliveryDrone DeserializeLength(Stream stream, int length, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BC640 Offset: 0x20BAC40 VA: 0x1820BC640
	public static void SerializeDelta(Stream stream, DeliveryDrone instance, DeliveryDrone previous) { }

	// RVA: 0x20BCA10 Offset: 0x20BB010 VA: 0x1820BCA10
	public static void Serialize(Stream stream, DeliveryDrone instance) { }

	// RVA: 0x20BCB50 Offset: 0x20BB150 VA: 0x1820BCB50
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BCB60 Offset: 0x20BB160 VA: 0x1820BCB60
	public void ToProto(Stream stream) { }

	// RVA: 0x20BC900 Offset: 0x20BAF00 VA: 0x1820BC900
	public static byte[] SerializeToBytes(DeliveryDrone instance) { }

	// RVA: 0x20BC850 Offset: 0x20BAE50 VA: 0x1820BC850
	public static void SerializeLengthDelimited(Stream stream, DeliveryDrone instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class DeliveryDrone : Drone // TypeDefIndex: 8799
{	// Fields
	[HeaderAttribute] // RVA: 0xBE830 Offset: 0xBDC30 VA: 0x1800BE830
	public float stateTimeout; // 0x320
	public float targetPositionTolerance; // 0x324
	public float preferredCruiseHeight; // 0x328
	public float preferredHeightAboveObstacle; // 0x32C
	public float marginAbovePreferredHeight; // 0x330
	public float obstacleHeightLockDuration; // 0x334
	public int pickUpDelayInTicks; // 0x338
	public DeliveryDroneConfig config; // 0x340
	public GameObjectRef mapMarkerPrefab; // 0x348

	// Methods

	// RVA: 0x84C930 Offset: 0x84AF30 VA: 0x18084C930
	public void .ctor() { }

}

