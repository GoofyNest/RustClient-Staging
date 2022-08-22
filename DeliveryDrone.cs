public class DeliveryDrone : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6398
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint marketplaceId; // 0x14
	public uint terminalId; // 0x18
	public uint vendingMachineId; // 0x1C
	public int state; // 0x20

	// Methods

	// RVA: 0x20BCE20 Offset: 0x20BB420 VA: 0x1820BCE20
	public static void ResetToPool(DeliveryDrone instance) { }

	// RVA: 0x20BCEC0 Offset: 0x20BB4C0 VA: 0x1820BCEC0
	public void ResetToPool() { }

	// RVA: 0x20BCAD0 Offset: 0x20BB0D0 VA: 0x1820BCAD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C07AD0 Offset: 0x1C060D0 VA: 0x181C07AD0
	public void CopyTo(DeliveryDrone instance) { }

	// RVA: 0x20BB940 Offset: 0x20B9F40 VA: 0x1820BB940
	public DeliveryDrone Copy() { }

	// RVA: 0x20BC070 Offset: 0x20BA670 VA: 0x1820BC070
	public static DeliveryDrone Deserialize(Stream stream) { }

	// RVA: 0x20BBCA0 Offset: 0x20BA2A0 VA: 0x1820BBCA0
	public static DeliveryDrone DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BBD20 Offset: 0x20BA320 VA: 0x1820BBD20
	public static DeliveryDrone DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BC2C0 Offset: 0x20BA8C0 VA: 0x1820BC2C0
	public static DeliveryDrone Deserialize(byte[] buffer) { }

	// RVA: 0x20BCBF0 Offset: 0x20BB1F0 VA: 0x1820BCBF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BD480 Offset: 0x20BBA80 VA: 0x1820BD480 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BD4A0 Offset: 0x20BBAA0 VA: 0x1820BD4A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DeliveryDrone previous) { }

	// RVA: 0x20BCE00 Offset: 0x20BB400 VA: 0x1820BCE00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BC5D0 Offset: 0x20BABD0 VA: 0x1820BC5D0
	public static DeliveryDrone Deserialize(byte[] buffer, DeliveryDrone instance, bool isDelta = False) { }

	// RVA: 0x20BC8C0 Offset: 0x20BAEC0 VA: 0x1820BC8C0
	public static DeliveryDrone Deserialize(Stream stream, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BB9C0 Offset: 0x20B9FC0 VA: 0x1820BB9C0
	public static DeliveryDrone DeserializeLengthDelimited(Stream stream, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BBDB0 Offset: 0x20BA3B0 VA: 0x1820BBDB0
	public static DeliveryDrone DeserializeLength(Stream stream, int length, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20BCF60 Offset: 0x20BB560 VA: 0x1820BCF60
	public static void SerializeDelta(Stream stream, DeliveryDrone instance, DeliveryDrone previous) { }

	// RVA: 0x20BD330 Offset: 0x20BB930 VA: 0x1820BD330
	public static void Serialize(Stream stream, DeliveryDrone instance) { }

	// RVA: 0x20BD470 Offset: 0x20BBA70 VA: 0x1820BD470
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BD480 Offset: 0x20BBA80 VA: 0x1820BD480
	public void ToProto(Stream stream) { }

	// RVA: 0x20BD220 Offset: 0x20BB820 VA: 0x1820BD220
	public static byte[] SerializeToBytes(DeliveryDrone instance) { }

	// RVA: 0x20BD170 Offset: 0x20BB770 VA: 0x1820BD170
	public static void SerializeLengthDelimited(Stream stream, DeliveryDrone instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x84CF90 Offset: 0x84B590 VA: 0x18084CF90
	public void .ctor() { }

}

