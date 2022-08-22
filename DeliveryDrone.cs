public class DeliveryDrone : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6398
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint marketplaceId; // 0x14
	public uint terminalId; // 0x18
	public uint vendingMachineId; // 0x1C
	public int state; // 0x20

	// Methods

	// RVA: 0x20BC340 Offset: 0x20BA940 VA: 0x1820BC340
	public static void ResetToPool(DeliveryDrone instance) { }

	// RVA: 0x20BC3E0 Offset: 0x20BA9E0 VA: 0x1820BC3E0
	public void ResetToPool() { }

	// RVA: 0x20BBFF0 Offset: 0x20BA5F0 VA: 0x1820BBFF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C07020 Offset: 0x1C05620 VA: 0x181C07020
	public void CopyTo(DeliveryDrone instance) { }

	// RVA: 0x20BAE60 Offset: 0x20B9460 VA: 0x1820BAE60
	public DeliveryDrone Copy() { }

	// RVA: 0x20BB590 Offset: 0x20B9B90 VA: 0x1820BB590
	public static DeliveryDrone Deserialize(Stream stream) { }

	// RVA: 0x20BB1C0 Offset: 0x20B97C0 VA: 0x1820BB1C0
	public static DeliveryDrone DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BB240 Offset: 0x20B9840 VA: 0x1820BB240
	public static DeliveryDrone DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BB7E0 Offset: 0x20B9DE0 VA: 0x1820BB7E0
	public static DeliveryDrone Deserialize(byte[] buffer) { }

	// RVA: 0x20BC110 Offset: 0x20BA710 VA: 0x1820BC110
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BC9A0 Offset: 0x20BAFA0 VA: 0x1820BC9A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BC9C0 Offset: 0x20BAFC0 VA: 0x1820BC9C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DeliveryDrone previous) { }

	// RVA: 0x20BC320 Offset: 0x20BA920 VA: 0x1820BC320 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BBAF0 Offset: 0x20BA0F0 VA: 0x1820BBAF0
	public static DeliveryDrone Deserialize(byte[] buffer, DeliveryDrone instance, bool isDelta = False) { }

	// RVA: 0x20BBDE0 Offset: 0x20BA3E0 VA: 0x1820BBDE0
	public static DeliveryDrone Deserialize(Stream stream, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BAEE0 Offset: 0x20B94E0 VA: 0x1820BAEE0
	public static DeliveryDrone DeserializeLengthDelimited(Stream stream, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BB2D0 Offset: 0x20B98D0 VA: 0x1820BB2D0
	public static DeliveryDrone DeserializeLength(Stream stream, int length, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BC480 Offset: 0x20BAA80 VA: 0x1820BC480
	public static void SerializeDelta(Stream stream, DeliveryDrone instance, DeliveryDrone previous) { }

	// RVA: 0x20BC850 Offset: 0x20BAE50 VA: 0x1820BC850
	public static void Serialize(Stream stream, DeliveryDrone instance) { }

	// RVA: 0x20BC990 Offset: 0x20BAF90 VA: 0x1820BC990
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BC9A0 Offset: 0x20BAFA0 VA: 0x1820BC9A0
	public void ToProto(Stream stream) { }

	// RVA: 0x20BC740 Offset: 0x20BAD40 VA: 0x1820BC740
	public static byte[] SerializeToBytes(DeliveryDrone instance) { }

	// RVA: 0x20BC690 Offset: 0x20BAC90 VA: 0x1820BC690
	public static void SerializeLengthDelimited(Stream stream, DeliveryDrone instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class DeliveryDrone : Drone // TypeDefIndex: 8799
{	// Fields
	[HeaderAttribute] // RVA: 0xBE8D0 Offset: 0xBDCD0 VA: 0x1800BE8D0
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

