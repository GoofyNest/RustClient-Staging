public class DeliveryDrone : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6398
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint marketplaceId; // 0x14
	public uint terminalId; // 0x18
	public uint vendingMachineId; // 0x1C
	public int state; // 0x20

	// Methods

	// RVA: 0x20BC600 Offset: 0x20BAC00 VA: 0x1820BC600
	public static void ResetToPool(DeliveryDrone instance) { }

	// RVA: 0x20BC6A0 Offset: 0x20BACA0 VA: 0x1820BC6A0
	public void ResetToPool() { }

	// RVA: 0x20BC2B0 Offset: 0x20BA8B0 VA: 0x1820BC2B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C072E0 Offset: 0x1C058E0 VA: 0x181C072E0
	public void CopyTo(DeliveryDrone instance) { }

	// RVA: 0x20BB120 Offset: 0x20B9720 VA: 0x1820BB120
	public DeliveryDrone Copy() { }

	// RVA: 0x20BB850 Offset: 0x20B9E50 VA: 0x1820BB850
	public static DeliveryDrone Deserialize(Stream stream) { }

	// RVA: 0x20BB480 Offset: 0x20B9A80 VA: 0x1820BB480
	public static DeliveryDrone DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BB500 Offset: 0x20B9B00 VA: 0x1820BB500
	public static DeliveryDrone DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BBAA0 Offset: 0x20BA0A0 VA: 0x1820BBAA0
	public static DeliveryDrone Deserialize(byte[] buffer) { }

	// RVA: 0x20BC3D0 Offset: 0x20BA9D0 VA: 0x1820BC3D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BCC60 Offset: 0x20BB260 VA: 0x1820BCC60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BCC80 Offset: 0x20BB280 VA: 0x1820BCC80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DeliveryDrone previous) { }

	// RVA: 0x20BC5E0 Offset: 0x20BABE0 VA: 0x1820BC5E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BBDB0 Offset: 0x20BA3B0 VA: 0x1820BBDB0
	public static DeliveryDrone Deserialize(byte[] buffer, DeliveryDrone instance, bool isDelta = False) { }

	// RVA: 0x20BC0A0 Offset: 0x20BA6A0 VA: 0x1820BC0A0
	public static DeliveryDrone Deserialize(Stream stream, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BB1A0 Offset: 0x20B97A0 VA: 0x1820BB1A0
	public static DeliveryDrone DeserializeLengthDelimited(Stream stream, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BB590 Offset: 0x20B9B90 VA: 0x1820BB590
	public static DeliveryDrone DeserializeLength(Stream stream, int length, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BC740 Offset: 0x20BAD40 VA: 0x1820BC740
	public static void SerializeDelta(Stream stream, DeliveryDrone instance, DeliveryDrone previous) { }

	// RVA: 0x20BCB10 Offset: 0x20BB110 VA: 0x1820BCB10
	public static void Serialize(Stream stream, DeliveryDrone instance) { }

	// RVA: 0x20BCC50 Offset: 0x20BB250 VA: 0x1820BCC50
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BCC60 Offset: 0x20BB260 VA: 0x1820BCC60
	public void ToProto(Stream stream) { }

	// RVA: 0x20BCA00 Offset: 0x20BB000 VA: 0x1820BCA00
	public static byte[] SerializeToBytes(DeliveryDrone instance) { }

	// RVA: 0x20BC950 Offset: 0x20BAF50 VA: 0x1820BC950
	public static void SerializeLengthDelimited(Stream stream, DeliveryDrone instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x84CA40 Offset: 0x84B040 VA: 0x18084CA40
	public void .ctor() { }

}

