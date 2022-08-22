public class BaseVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6327
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<BaseVehicle.MountPoint> mountPoints; // 0x18

	// Methods

	// RVA: 0x1F6B050 Offset: 0x1F69650 VA: 0x181F6B050
	public static void ResetToPool(BaseVehicle instance) { }

	// RVA: 0x1F6AEA0 Offset: 0x1F694A0 VA: 0x181F6AEA0
	public void ResetToPool() { }

	// RVA: 0x1F6AC20 Offset: 0x1F69220 VA: 0x181F6AC20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F69DA0 Offset: 0x1F683A0 VA: 0x181F69DA0
	public void CopyTo(BaseVehicle instance) { }

	// RVA: 0x1F69F30 Offset: 0x1F68530 VA: 0x181F69F30
	public BaseVehicle Copy() { }

	// RVA: 0x1F6A9B0 Offset: 0x1F68FB0 VA: 0x181F6A9B0
	public static BaseVehicle Deserialize(Stream stream) { }

	// RVA: 0x1F6A3E0 Offset: 0x1F689E0 VA: 0x181F6A3E0
	public static BaseVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F6A460 Offset: 0x1F68A60 VA: 0x181F6A460
	public static BaseVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F6A890 Offset: 0x1F68E90 VA: 0x181F6A890
	public static BaseVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1F6AE60 Offset: 0x1F69460 VA: 0x181F6AE60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F6B790 Offset: 0x1F69D90 VA: 0x181F6B790 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F6B7B0 Offset: 0x1F69DB0 VA: 0x181F6B7B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseVehicle previous) { }

	// RVA: 0x1F6AE80 Offset: 0x1F69480 VA: 0x181F6AE80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F6A790 Offset: 0x1F68D90 VA: 0x181F6A790
	public static BaseVehicle Deserialize(byte[] buffer, BaseVehicle instance, bool isDelta = False) { }

	// RVA: 0x1F6AA30 Offset: 0x1F69030 VA: 0x181F6AA30
	public static BaseVehicle Deserialize(Stream stream, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F6A110 Offset: 0x1F68710 VA: 0x181F6A110
	public static BaseVehicle DeserializeLengthDelimited(Stream stream, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F6A4F0 Offset: 0x1F68AF0 VA: 0x181F6A4F0
	public static BaseVehicle DeserializeLength(Stream stream, int length, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F6B200 Offset: 0x1F69800 VA: 0x181F6B200
	public static void SerializeDelta(Stream stream, BaseVehicle instance, BaseVehicle previous) { }

	// RVA: 0x1F6B5A0 Offset: 0x1F69BA0 VA: 0x181F6B5A0
	public static void Serialize(Stream stream, BaseVehicle instance) { }

	// RVA: 0x1F6B780 Offset: 0x1F69D80 VA: 0x181F6B780
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F6B790 Offset: 0x1F69D90 VA: 0x181F6B790
	public void ToProto(Stream stream) { }

	// RVA: 0x1F6B490 Offset: 0x1F69A90 VA: 0x181F6B490
	public static byte[] SerializeToBytes(BaseVehicle instance) { }

	// RVA: 0x1F6B3E0 Offset: 0x1F699E0 VA: 0x181F6B3E0
	public static void SerializeLengthDelimited(Stream stream, BaseVehicle instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class BaseVehicle.MountPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6328
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int index; // 0x14
	public uint mountableId; // 0x18

	// Methods

	// RVA: 0x1F7D0B0 Offset: 0x1F7B6B0 VA: 0x181F7D0B0
	public static void ResetToPool(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7D030 Offset: 0x1F7B630 VA: 0x181F7D030
	public void ResetToPool() { }

	// RVA: 0x1F7CE10 Offset: 0x1F7B410 VA: 0x181F7CE10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7C010 Offset: 0x1F7A610 VA: 0x181F7C010
	public BaseVehicle.MountPoint Copy() { }

	// RVA: 0x1F7C790 Offset: 0x1F7AD90 VA: 0x181F7C790
	public static BaseVehicle.MountPoint Deserialize(Stream stream) { }

	// RVA: 0x1F7C2D0 Offset: 0x1F7A8D0 VA: 0x181F7C2D0
	public static BaseVehicle.MountPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7C350 Offset: 0x1F7A950 VA: 0x181F7C350
	public static BaseVehicle.MountPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7C950 Offset: 0x1F7AF50 VA: 0x181F7C950
	public static BaseVehicle.MountPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F7CE90 Offset: 0x1F7B490 VA: 0x181F7CE90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7D570 Offset: 0x1F7BB70 VA: 0x181F7D570 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7D590 Offset: 0x1F7BB90 VA: 0x181F7D590 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseVehicle.MountPoint previous) { }

	// RVA: 0x1F7D010 Offset: 0x1F7B610 VA: 0x181F7D010 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7CBC0 Offset: 0x1F7B1C0 VA: 0x181F7CBC0
	public static BaseVehicle.MountPoint Deserialize(byte[] buffer, BaseVehicle.MountPoint instance, bool isDelta = False) { }

	// RVA: 0x1F7C610 Offset: 0x1F7AC10 VA: 0x181F7C610
	public static BaseVehicle.MountPoint Deserialize(Stream stream, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F7C080 Offset: 0x1F7A680 VA: 0x181F7C080
	public static BaseVehicle.MountPoint DeserializeLengthDelimited(Stream stream, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F7C3E0 Offset: 0x1F7A9E0 VA: 0x181F7C3E0
	public static BaseVehicle.MountPoint DeserializeLength(Stream stream, int length, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F7D130 Offset: 0x1F7B730 VA: 0x181F7D130
	public static void SerializeDelta(Stream stream, BaseVehicle.MountPoint instance, BaseVehicle.MountPoint previous) { }

	// RVA: 0x1F7D460 Offset: 0x1F7BA60 VA: 0x181F7D460
	public static void Serialize(Stream stream, BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7D560 Offset: 0x1F7BB60 VA: 0x181F7D560
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7D570 Offset: 0x1F7BB70 VA: 0x181F7D570
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7D350 Offset: 0x1F7B950 VA: 0x181F7D350
	public static byte[] SerializeToBytes(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7D2A0 Offset: 0x1F7B8A0 VA: 0x181F7D2A0
	public static void SerializeLengthDelimited(Stream stream, BaseVehicle.MountPoint instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class Motorboat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6346
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint storageid; // 0x14
	public uint fuelStorageID; // 0x18

	// Methods

	// RVA: 0x1F8B530 Offset: 0x1F89B30 VA: 0x181F8B530
	public static void ResetToPool(Motorboat instance) { }

	// RVA: 0x1F8B4B0 Offset: 0x1F89AB0 VA: 0x181F8B4B0
	public void ResetToPool() { }

	// RVA: 0x1F8B210 Offset: 0x1F89810 VA: 0x181F8B210 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(Motorboat instance) { }

	// RVA: 0x1F8A410 Offset: 0x1F88A10 VA: 0x181F8A410
	public Motorboat Copy() { }

	// RVA: 0x1F8B050 Offset: 0x1F89650 VA: 0x181F8B050
	public static Motorboat Deserialize(Stream stream) { }

	// RVA: 0x1F8A480 Offset: 0x1F88A80 VA: 0x181F8A480
	public static Motorboat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8A980 Offset: 0x1F88F80 VA: 0x181F8A980
	public static Motorboat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8AA10 Offset: 0x1F89010 VA: 0x181F8AA10
	public static Motorboat Deserialize(byte[] buffer) { }

	// RVA: 0x1F8B310 Offset: 0x1F89910 VA: 0x181F8B310
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8B9F0 Offset: 0x1F89FF0 VA: 0x181F8B9F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8BA10 Offset: 0x1F8A010 VA: 0x181F8BA10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Motorboat previous) { }

	// RVA: 0x1F8B490 Offset: 0x1F89A90 VA: 0x181F8B490 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8AE00 Offset: 0x1F89400 VA: 0x181F8AE00
	public static Motorboat Deserialize(byte[] buffer, Motorboat instance, bool isDelta = False) { }

	// RVA: 0x1F8AC80 Offset: 0x1F89280 VA: 0x181F8AC80
	public static Motorboat Deserialize(Stream stream, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F8A500 Offset: 0x1F88B00 VA: 0x181F8A500
	public static Motorboat DeserializeLengthDelimited(Stream stream, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F8A750 Offset: 0x1F88D50 VA: 0x181F8A750
	public static Motorboat DeserializeLength(Stream stream, int length, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F8B5B0 Offset: 0x1F89BB0 VA: 0x181F8B5B0
	public static void SerializeDelta(Stream stream, Motorboat instance, Motorboat previous) { }

	// RVA: 0x1F8B8E0 Offset: 0x1F89EE0 VA: 0x181F8B8E0
	public static void Serialize(Stream stream, Motorboat instance) { }

	// RVA: 0x1F8B9E0 Offset: 0x1F89FE0 VA: 0x181F8B9E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8B9F0 Offset: 0x1F89FF0 VA: 0x181F8B9F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8B7D0 Offset: 0x1F89DD0 VA: 0x181F8B7D0
	public static byte[] SerializeToBytes(Motorboat instance) { }

	// RVA: 0x1F8B720 Offset: 0x1F89D20 VA: 0x181F8B720
	public static void SerializeLengthDelimited(Stream stream, Motorboat instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ModularVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6348
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool editable; // 0x12

	// Methods

	// RVA: 0x1F87FA0 Offset: 0x1F865A0 VA: 0x181F87FA0
	public static void ResetToPool(ModularVehicle instance) { }

	// RVA: 0x1F87F20 Offset: 0x1F86520 VA: 0x181F87F20
	public void ResetToPool() { }

	// RVA: 0x1F87DF0 Offset: 0x1F863F0 VA: 0x181F87DF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E19440 Offset: 0x1E17A40 VA: 0x181E19440
	public void CopyTo(ModularVehicle instance) { }

	// RVA: 0x1F87470 Offset: 0x1F85A70 VA: 0x181F87470
	public ModularVehicle Copy() { }

	// RVA: 0x1F87D70 Offset: 0x1F86370 VA: 0x181F87D70
	public static ModularVehicle Deserialize(Stream stream) { }

	// RVA: 0x1F874E0 Offset: 0x1F85AE0 VA: 0x181F874E0
	public static ModularVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F87780 Offset: 0x1F85D80 VA: 0x181F87780
	public static ModularVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F87C50 Offset: 0x1F86250 VA: 0x181F87C50
	public static ModularVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1F87EE0 Offset: 0x1F864E0 VA: 0x181F87EE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F88430 Offset: 0x1F86A30 VA: 0x181F88430 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F88500 Offset: 0x1F86B00 VA: 0x181F88500 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModularVehicle previous) { }

	// RVA: 0x1F87F00 Offset: 0x1F86500 VA: 0x181F87F00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F87A10 Offset: 0x1F86010 VA: 0x181F87A10
	public static ModularVehicle Deserialize(byte[] buffer, ModularVehicle instance, bool isDelta = False) { }

	// RVA: 0x1F87B10 Offset: 0x1F86110 VA: 0x181F87B10
	public static ModularVehicle Deserialize(Stream stream, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F87560 Offset: 0x1F85B60 VA: 0x181F87560
	public static ModularVehicle DeserializeLengthDelimited(Stream stream, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F87810 Offset: 0x1F85E10 VA: 0x181F87810
	public static ModularVehicle DeserializeLength(Stream stream, int length, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F88020 Offset: 0x1F86620 VA: 0x181F88020
	public static void SerializeDelta(Stream stream, ModularVehicle instance, ModularVehicle previous) { }

	// RVA: 0x1F88350 Offset: 0x1F86950 VA: 0x181F88350
	public static void Serialize(Stream stream, ModularVehicle instance) { }

	// RVA: 0x1F88420 Offset: 0x1F86A20 VA: 0x181F88420
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F88430 Offset: 0x1F86A30 VA: 0x181F88430
	public void ToProto(Stream stream) { }

	// RVA: 0x1F881A0 Offset: 0x1F867A0 VA: 0x181F881A0
	public static byte[] SerializeToBytes(ModularVehicle instance) { }

	// RVA: 0x1F880F0 Offset: 0x1F866F0 VA: 0x181F880F0
	public static void SerializeLengthDelimited(Stream stream, ModularVehicle instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ModularCar : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6349
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float steerAngle; // 0x14
	public float driveWheelVel; // 0x18
	public float throttleInput; // 0x1C
	public float brakeInput; // 0x20
	public uint fuelStorageID; // 0x24
	public float fuelFraction; // 0x28
	public int lockID; // 0x2C

	// Methods

	// RVA: 0x1F86C90 Offset: 0x1F85290 VA: 0x181F86C90
	public static void ResetToPool(ModularCar instance) { }

	// RVA: 0x1F86BC0 Offset: 0x1F851C0 VA: 0x181F86BC0
	public void ResetToPool() { }

	// RVA: 0x1F86400 Offset: 0x1F84A00 VA: 0x181F86400 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB3600 Offset: 0x1DB1C00 VA: 0x181DB3600
	public void CopyTo(ModularCar instance) { }

	// RVA: 0x1F849F0 Offset: 0x1F82FF0 VA: 0x181F849F0
	public ModularCar Copy() { }

	// RVA: 0x1F85E00 Offset: 0x1F84400 VA: 0x181F85E00
	public static ModularCar Deserialize(Stream stream) { }

	// RVA: 0x1F84E40 Offset: 0x1F83440 VA: 0x181F84E40
	public static ModularCar DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F85260 Offset: 0x1F83860 VA: 0x181F85260
	public static ModularCar DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F85A10 Offset: 0x1F84010 VA: 0x181F85A10
	public static ModularCar Deserialize(byte[] buffer) { }

	// RVA: 0x1F86550 Offset: 0x1F84B50 VA: 0x181F86550
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F87430 Offset: 0x1F85A30 VA: 0x181F87430 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F87450 Offset: 0x1F85A50 VA: 0x181F87450 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModularCar previous) { }

	// RVA: 0x1F86830 Offset: 0x1F84E30 VA: 0x181F86830 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F85640 Offset: 0x1F83C40 VA: 0x181F85640
	public static ModularCar Deserialize(byte[] buffer, ModularCar instance, bool isDelta = False) { }

	// RVA: 0x1F86120 Offset: 0x1F84720 VA: 0x181F86120
	public static ModularCar Deserialize(Stream stream, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F84A80 Offset: 0x1F83080 VA: 0x181F84A80
	public static ModularCar DeserializeLengthDelimited(Stream stream, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F84EC0 Offset: 0x1F834C0 VA: 0x181F84EC0
	public static ModularCar DeserializeLength(Stream stream, int length, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F86D60 Offset: 0x1F85360 VA: 0x181F86D60
	public static void SerializeDelta(Stream stream, ModularCar instance, ModularCar previous) { }

	// RVA: 0x1F87260 Offset: 0x1F85860 VA: 0x181F87260
	public static void Serialize(Stream stream, ModularCar instance) { }

	// RVA: 0x1F87420 Offset: 0x1F85A20 VA: 0x181F87420
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F87430 Offset: 0x1F85A30 VA: 0x181F87430
	public void ToProto(Stream stream) { }

	// RVA: 0x1F87150 Offset: 0x1F85750 VA: 0x181F87150
	public static byte[] SerializeToBytes(ModularCar instance) { }

	// RVA: 0x1F870A0 Offset: 0x1F856A0 VA: 0x181F870A0
	public static void SerializeLengthDelimited(Stream stream, ModularCar instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class VehicleLift : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6352
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool platformIsOccupied; // 0x12
	public bool editableOccupant; // 0x13
	public bool driveableOccupant; // 0x14
	public int occupantLockState; // 0x18
	public int occupantLockID; // 0x1C

	// Methods

	// RVA: 0x1EFB310 Offset: 0x1EF9910 VA: 0x181EFB310
	public static void ResetToPool(VehicleLift instance) { }

	// RVA: 0x1EFB3C0 Offset: 0x1EF99C0 VA: 0x181EFB3C0
	public void ResetToPool() { }

	// RVA: 0x1EFAF60 Offset: 0x1EF9560 VA: 0x181EFAF60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF9C10 Offset: 0x1EF8210 VA: 0x181EF9C10
	public void CopyTo(VehicleLift instance) { }

	// RVA: 0x1EF9C50 Offset: 0x1EF8250 VA: 0x181EF9C50
	public VehicleLift Copy() { }

	// RVA: 0x1EFA730 Offset: 0x1EF8D30 VA: 0x181EFA730
	public static VehicleLift Deserialize(Stream stream) { }

	// RVA: 0x1EF9CD0 Offset: 0x1EF82D0 VA: 0x181EF9CD0
	public static VehicleLift DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFA370 Offset: 0x1EF8970 VA: 0x181EFA370
	public static VehicleLift DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFAC10 Offset: 0x1EF9210 VA: 0x181EFAC10
	public static VehicleLift Deserialize(byte[] buffer) { }

	// RVA: 0x1EFB0A0 Offset: 0x1EF96A0 VA: 0x181EFB0A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EFB9A0 Offset: 0x1EF9FA0 VA: 0x181EFB9A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EFB9C0 Offset: 0x1EF9FC0 VA: 0x181EFB9C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleLift previous) { }

	// RVA: 0x1EFB2F0 Offset: 0x1EF98F0 VA: 0x181EFB2F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFA400 Offset: 0x1EF8A00 VA: 0x181EFA400
	public static VehicleLift Deserialize(byte[] buffer, VehicleLift instance, bool isDelta = False) { }

	// RVA: 0x1EFA9C0 Offset: 0x1EF8FC0 VA: 0x181EFA9C0
	public static VehicleLift Deserialize(Stream stream, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EF9D50 Offset: 0x1EF8350 VA: 0x181EF9D50
	public static VehicleLift DeserializeLengthDelimited(Stream stream, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EFA070 Offset: 0x1EF8670 VA: 0x181EFA070
	public static VehicleLift DeserializeLength(Stream stream, int length, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EFB470 Offset: 0x1EF9A70 VA: 0x181EFB470
	public static void SerializeDelta(Stream stream, VehicleLift instance, VehicleLift previous) { }

	// RVA: 0x1EFB820 Offset: 0x1EF9E20 VA: 0x181EFB820
	public static void Serialize(Stream stream, VehicleLift instance) { }

	// RVA: 0x1EFB990 Offset: 0x1EF9F90 VA: 0x181EFB990
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EFB9A0 Offset: 0x1EF9FA0 VA: 0x181EFB9A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EFB710 Offset: 0x1EF9D10 VA: 0x181EFB710
	public static byte[] SerializeToBytes(VehicleLift instance) { }

	// RVA: 0x1EFB660 Offset: 0x1EF9C60 VA: 0x181EFB660
	public static void SerializeLengthDelimited(Stream stream, VehicleLift instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class EngineStorage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6353
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool isUsable; // 0x12
	public float accelerationBoost; // 0x14
	public float topSpeedBoost; // 0x18
	public float fuelEconomyBoost; // 0x1C

	// Methods

	// RVA: 0x1E75490 Offset: 0x1E73A90 VA: 0x181E75490
	public static void ResetToPool(EngineStorage instance) { }

	// RVA: 0x1E75530 Offset: 0x1E73B30 VA: 0x181E75530
	public void ResetToPool() { }

	// RVA: 0x1E75130 Offset: 0x1E73730 VA: 0x181E75130 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E73F30 Offset: 0x1E72530 VA: 0x181E73F30
	public void CopyTo(EngineStorage instance) { }

	// RVA: 0x1E73F60 Offset: 0x1E72560 VA: 0x181E73F60
	public EngineStorage Copy() { }

	// RVA: 0x1E746B0 Offset: 0x1E72CB0 VA: 0x181E746B0
	public static EngineStorage Deserialize(Stream stream) { }

	// RVA: 0x1E742D0 Offset: 0x1E728D0 VA: 0x181E742D0
	public static EngineStorage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E74350 Offset: 0x1E72950 VA: 0x181E74350
	public static EngineStorage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E74C00 Offset: 0x1E73200 VA: 0x181E74C00
	public static EngineStorage Deserialize(byte[] buffer) { }

	// RVA: 0x1E75250 Offset: 0x1E73850 VA: 0x181E75250
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E75B00 Offset: 0x1E74100 VA: 0x181E75B00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E75B20 Offset: 0x1E74120 VA: 0x181E75B20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EngineStorage previous) { }

	// RVA: 0x1E75470 Offset: 0x1E73A70 VA: 0x181E75470 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E74910 Offset: 0x1E72F10 VA: 0x181E74910
	public static EngineStorage Deserialize(byte[] buffer, EngineStorage instance, bool isDelta = False) { }

	// RVA: 0x1E74F10 Offset: 0x1E73510 VA: 0x181E74F10
	public static EngineStorage Deserialize(Stream stream, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E73FE0 Offset: 0x1E725E0 VA: 0x181E73FE0
	public static EngineStorage DeserializeLengthDelimited(Stream stream, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E743E0 Offset: 0x1E729E0 VA: 0x181E743E0
	public static EngineStorage DeserializeLength(Stream stream, int length, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E755D0 Offset: 0x1E73BD0 VA: 0x181E755D0
	public static void SerializeDelta(Stream stream, EngineStorage instance, EngineStorage previous) { }

	// RVA: 0x1E759A0 Offset: 0x1E73FA0 VA: 0x181E759A0
	public static void Serialize(Stream stream, EngineStorage instance) { }

	// RVA: 0x1E75AF0 Offset: 0x1E740F0 VA: 0x181E75AF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E75B00 Offset: 0x1E74100 VA: 0x181E75B00
	public void ToProto(Stream stream) { }

	// RVA: 0x1E75890 Offset: 0x1E73E90 VA: 0x181E75890
	public static byte[] SerializeToBytes(EngineStorage instance) { }

	// RVA: 0x1E757E0 Offset: 0x1E73DE0 VA: 0x181E757E0
	public static void SerializeLengthDelimited(Stream stream, EngineStorage instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class VehicleVendor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6378
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VehicleVendor.PlayerStorage> playerStorage; // 0x18
	public uint spawnerRef; // 0x20

	// Methods

	// RVA: 0x1EFDC80 Offset: 0x1EFC280 VA: 0x181EFDC80
	public static void ResetToPool(VehicleVendor instance) { }

	// RVA: 0x1EFDE60 Offset: 0x1EFC460 VA: 0x181EFDE60
	public void ResetToPool() { }

	// RVA: 0x1EFDBC0 Offset: 0x1EFC1C0 VA: 0x181EFDBC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EFCC60 Offset: 0x1EFB260 VA: 0x181EFCC60
	public void CopyTo(VehicleVendor instance) { }

	// RVA: 0x1EFCE00 Offset: 0x1EFB400 VA: 0x181EFCE00
	public VehicleVendor Copy() { }

	// RVA: 0x1EFDA40 Offset: 0x1EFC040 VA: 0x181EFDA40
	public static VehicleVendor Deserialize(Stream stream) { }

	// RVA: 0x1EFD300 Offset: 0x1EFB900 VA: 0x181EFD300
	public static VehicleVendor DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFD660 Offset: 0x1EFBC60 VA: 0x181EFD660
	public static VehicleVendor DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFD6F0 Offset: 0x1EFBCF0 VA: 0x181EFD6F0
	public static VehicleVendor Deserialize(byte[] buffer) { }

	// RVA: 0x1EFDC40 Offset: 0x1EFC240 VA: 0x181EFDC40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EFE690 Offset: 0x1EFCC90 VA: 0x181EFE690 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EFE6B0 Offset: 0x1EFCCB0 VA: 0x181EFE6B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor previous) { }

	// RVA: 0x1EFDC60 Offset: 0x1EFC260 VA: 0x181EFDC60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFDAC0 Offset: 0x1EFC0C0 VA: 0x181EFDAC0
	public static VehicleVendor Deserialize(byte[] buffer, VehicleVendor instance, bool isDelta = False) { }

	// RVA: 0x1EFD810 Offset: 0x1EFBE10 VA: 0x181EFD810
	public static VehicleVendor Deserialize(Stream stream, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EFCFF0 Offset: 0x1EFB5F0 VA: 0x181EFCFF0
	public static VehicleVendor DeserializeLengthDelimited(Stream stream, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EFD380 Offset: 0x1EFB980 VA: 0x181EFD380
	public static VehicleVendor DeserializeLength(Stream stream, int length, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EFE040 Offset: 0x1EFC640 VA: 0x181EFE040
	public static void SerializeDelta(Stream stream, VehicleVendor instance, VehicleVendor previous) { }

	// RVA: 0x1EFE450 Offset: 0x1EFCA50 VA: 0x181EFE450
	public static void Serialize(Stream stream, VehicleVendor instance) { }

	// RVA: 0x1EFE680 Offset: 0x1EFCC80 VA: 0x181EFE680
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EFE690 Offset: 0x1EFCC90 VA: 0x181EFE690
	public void ToProto(Stream stream) { }

	// RVA: 0x1EFE340 Offset: 0x1EFC940 VA: 0x181EFE340
	public static byte[] SerializeToBytes(VehicleVendor instance) { }

	// RVA: 0x1EFE290 Offset: 0x1EFC890 VA: 0x181EFE290
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class VehicleVendor.PlayerStorage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6379
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong userid; // 0x18
	public List<VehicleVendor.PlayerStorage.PlayerStoredVehicle> storedVehicles; // 0x20

	// Methods

	// RVA: 0x1EE6F60 Offset: 0x1EE5560 VA: 0x181EE6F60
	public static void ResetToPool(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE7120 Offset: 0x1EE5720 VA: 0x181EE7120
	public void ResetToPool() { }

	// RVA: 0x1EE6EA0 Offset: 0x1EE54A0 VA: 0x181EE6EA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE60A0 Offset: 0x1EE46A0 VA: 0x181EE60A0
	public void CopyTo(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE6250 Offset: 0x1EE4850 VA: 0x181EE6250
	public VehicleVendor.PlayerStorage Copy() { }

	// RVA: 0x1EE6C00 Offset: 0x1EE5200 VA: 0x181EE6C00
	public static VehicleVendor.PlayerStorage Deserialize(Stream stream) { }

	// RVA: 0x1EE65E0 Offset: 0x1EE4BE0 VA: 0x181EE65E0
	public static VehicleVendor.PlayerStorage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE6660 Offset: 0x1EE4C60 VA: 0x181EE6660
	public static VehicleVendor.PlayerStorage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE6C80 Offset: 0x1EE5280 VA: 0x181EE6C80
	public static VehicleVendor.PlayerStorage Deserialize(byte[] buffer) { }

	// RVA: 0x1EE6F20 Offset: 0x1EE5520 VA: 0x181EE6F20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EE7910 Offset: 0x1EE5F10 VA: 0x181EE7910 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EE7930 Offset: 0x1EE5F30 VA: 0x181EE7930 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor.PlayerStorage previous) { }

	// RVA: 0x1EE6F40 Offset: 0x1EE5540 VA: 0x181EE6F40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE6DA0 Offset: 0x1EE53A0 VA: 0x181EE6DA0
	public static VehicleVendor.PlayerStorage Deserialize(byte[] buffer, VehicleVendor.PlayerStorage instance, bool isDelta = False) { }

	// RVA: 0x1EE69D0 Offset: 0x1EE4FD0 VA: 0x181EE69D0
	public static VehicleVendor.PlayerStorage Deserialize(Stream stream, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE62D0 Offset: 0x1EE48D0 VA: 0x181EE62D0
	public static VehicleVendor.PlayerStorage DeserializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE66F0 Offset: 0x1EE4CF0 VA: 0x181EE66F0
	public static VehicleVendor.PlayerStorage DeserializeLength(Stream stream, int length, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE72E0 Offset: 0x1EE58E0 VA: 0x181EE72E0
	public static void SerializeDelta(Stream stream, VehicleVendor.PlayerStorage instance, VehicleVendor.PlayerStorage previous) { }

	// RVA: 0x1EE76E0 Offset: 0x1EE5CE0 VA: 0x181EE76E0
	public static void Serialize(Stream stream, VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE7900 Offset: 0x1EE5F00 VA: 0x181EE7900
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EE7910 Offset: 0x1EE5F10 VA: 0x181EE7910
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE75D0 Offset: 0x1EE5BD0 VA: 0x181EE75D0
	public static byte[] SerializeToBytes(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE7520 Offset: 0x1EE5B20 VA: 0x181EE7520
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class VehicleVendor.PlayerStorage.PlayerStoredVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6380
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string shortname; // 0x18
	public string resourcePath; // 0x20
	public float health; // 0x28

	// Methods

	// RVA: 0x1EE8CF0 Offset: 0x1EE72F0 VA: 0x181EE8CF0
	public static void ResetToPool(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE8C20 Offset: 0x1EE7220 VA: 0x181EE8C20
	public void ResetToPool() { }

	// RVA: 0x1EE89B0 Offset: 0x1EE6FB0 VA: 0x181EE89B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE7950 Offset: 0x1EE5F50 VA: 0x181EE7950
	public void CopyTo(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE79A0 Offset: 0x1EE5FA0 VA: 0x181EE79A0
	public VehicleVendor.PlayerStorage.PlayerStoredVehicle Copy() { }

	// RVA: 0x1EE84E0 Offset: 0x1EE6AE0 VA: 0x181EE84E0
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(Stream stream) { }

	// RVA: 0x1EE7CE0 Offset: 0x1EE62E0 VA: 0x181EE7CE0
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE7FE0 Offset: 0x1EE65E0 VA: 0x181EE7FE0
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE86F0 Offset: 0x1EE6CF0 VA: 0x181EE86F0
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1EE8A30 Offset: 0x1EE7030 VA: 0x181EE8A30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EE9350 Offset: 0x1EE7950 VA: 0x181EE9350 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EE9370 Offset: 0x1EE7970 VA: 0x181EE9370 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle previous) { }

	// RVA: 0x1EE8C00 Offset: 0x1EE7200 VA: 0x181EE8C00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE8070 Offset: 0x1EE6670 VA: 0x181EE8070
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(byte[] buffer, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta = False) { }

	// RVA: 0x1EE8310 Offset: 0x1EE6910 VA: 0x181EE8310
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE7A40 Offset: 0x1EE6040 VA: 0x181EE7A40
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE7D60 Offset: 0x1EE6360 VA: 0x181EE7D60
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLength(Stream stream, int length, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE8DC0 Offset: 0x1EE73C0 VA: 0x181EE8DC0
	public static void SerializeDelta(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, VehicleVendor.PlayerStorage.PlayerStoredVehicle previous) { }

	// RVA: 0x1EE9190 Offset: 0x1EE7790 VA: 0x181EE9190
	public static void Serialize(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE9340 Offset: 0x1EE7940 VA: 0x181EE9340
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EE9350 Offset: 0x1EE7950 VA: 0x181EE9350
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE9080 Offset: 0x1EE7680 VA: 0x181EE9080
	public static byte[] SerializeToBytes(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE8FD0 Offset: 0x1EE75D0 VA: 0x181EE8FD0
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class VehicleModule : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6385
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int socketIndex; // 0x14

	// Methods

	// RVA: 0x1EFC490 Offset: 0x1EFAA90 VA: 0x181EFC490
	public static void ResetToPool(VehicleModule instance) { }

	// RVA: 0x1EFC510 Offset: 0x1EFAB10 VA: 0x181EFC510
	public void ResetToPool() { }

	// RVA: 0x1EFC360 Offset: 0x1EFA960 VA: 0x181EFC360 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(VehicleModule instance) { }

	// RVA: 0x1EFB9E0 Offset: 0x1EF9FE0 VA: 0x181EFB9E0
	public VehicleModule Copy() { }

	// RVA: 0x1EFC2E0 Offset: 0x1EFA8E0 VA: 0x181EFC2E0
	public static VehicleModule Deserialize(Stream stream) { }

	// RVA: 0x1EFBA50 Offset: 0x1EFA050 VA: 0x181EFBA50
	public static VehicleModule DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFBEF0 Offset: 0x1EFA4F0 VA: 0x181EFBEF0
	public static VehicleModule DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFC1C0 Offset: 0x1EFA7C0 VA: 0x181EFC1C0
	public static VehicleModule Deserialize(byte[] buffer) { }

	// RVA: 0x1EFC450 Offset: 0x1EFAA50 VA: 0x181EFC450
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EFC9E0 Offset: 0x1EFAFE0 VA: 0x181EFC9E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EFCAB0 Offset: 0x1EFB0B0 VA: 0x181EFCAB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleModule previous) { }

	// RVA: 0x1EFC470 Offset: 0x1EFAA70 VA: 0x181EFC470 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFBF80 Offset: 0x1EFA580 VA: 0x181EFBF80
	public static VehicleModule Deserialize(byte[] buffer, VehicleModule instance, bool isDelta = False) { }

	// RVA: 0x1EFC080 Offset: 0x1EFA680 VA: 0x181EFC080
	public static VehicleModule Deserialize(Stream stream, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EFBAD0 Offset: 0x1EFA0D0 VA: 0x181EFBAD0
	public static VehicleModule DeserializeLengthDelimited(Stream stream, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EFBCF0 Offset: 0x1EFA2F0 VA: 0x181EFBCF0
	public static VehicleModule DeserializeLength(Stream stream, int length, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EFC590 Offset: 0x1EFAB90 VA: 0x181EFC590
	public static void SerializeDelta(Stream stream, VehicleModule instance, VehicleModule previous) { }

	// RVA: 0x1EFC900 Offset: 0x1EFAF00 VA: 0x181EFC900
	public static void Serialize(Stream stream, VehicleModule instance) { }

	// RVA: 0x1EFC9D0 Offset: 0x1EFAFD0 VA: 0x181EFC9D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EFC9E0 Offset: 0x1EFAFE0 VA: 0x181EFC9E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EFC750 Offset: 0x1EFAD50 VA: 0x181EFC750
	public static byte[] SerializeToBytes(VehicleModule instance) { }

	// RVA: 0x1EFC6A0 Offset: 0x1EFACA0 VA: 0x181EFC6A0
	public static void SerializeLengthDelimited(Stream stream, VehicleModule instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class CamperModule : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6420
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint bbqId; // 0x14
	public uint lockerId; // 0x18
	public uint storageID; // 0x1C

	// Methods

	// RVA: 0x1F75200 Offset: 0x1F73800 VA: 0x181F75200
	public static void ResetToPool(CamperModule instance) { }

	// RVA: 0x1F75290 Offset: 0x1F73890 VA: 0x181F75290
	public void ResetToPool() { }

	// RVA: 0x1F74F20 Offset: 0x1F73520 VA: 0x181F74F20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28720 Offset: 0x1E26D20 VA: 0x181E28720
	public void CopyTo(CamperModule instance) { }

	// RVA: 0x1F73FF0 Offset: 0x1F725F0 VA: 0x181F73FF0
	public CamperModule Copy() { }

	// RVA: 0x1F74810 Offset: 0x1F72E10 VA: 0x181F74810
	public static CamperModule Deserialize(Stream stream) { }

	// RVA: 0x1F74070 Offset: 0x1F72670 VA: 0x181F74070
	public static CamperModule DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F74370 Offset: 0x1F72970 VA: 0x181F74370
	public static CamperModule DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F74A00 Offset: 0x1F73000 VA: 0x181F74A00
	public static CamperModule Deserialize(byte[] buffer) { }

	// RVA: 0x1F75030 Offset: 0x1F73630 VA: 0x181F75030
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F757D0 Offset: 0x1F73DD0 VA: 0x181F757D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F757F0 Offset: 0x1F73DF0 VA: 0x181F757F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CamperModule previous) { }

	// RVA: 0x1F751E0 Offset: 0x1F737E0 VA: 0x181F751E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F74CA0 Offset: 0x1F732A0 VA: 0x181F74CA0
	public static CamperModule Deserialize(byte[] buffer, CamperModule instance, bool isDelta = False) { }

	// RVA: 0x1F74660 Offset: 0x1F72C60 VA: 0x181F74660
	public static CamperModule Deserialize(Stream stream, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F740F0 Offset: 0x1F726F0 VA: 0x181F740F0
	public static CamperModule DeserializeLengthDelimited(Stream stream, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F74400 Offset: 0x1F72A00 VA: 0x181F74400
	public static CamperModule DeserializeLength(Stream stream, int length, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F75320 Offset: 0x1F73920 VA: 0x181F75320
	public static void SerializeDelta(Stream stream, CamperModule instance, CamperModule previous) { }

	// RVA: 0x1F756A0 Offset: 0x1F73CA0 VA: 0x181F756A0
	public static void Serialize(Stream stream, CamperModule instance) { }

	// RVA: 0x1F757C0 Offset: 0x1F73DC0 VA: 0x181F757C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F757D0 Offset: 0x1F73DD0 VA: 0x181F757D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F75590 Offset: 0x1F73B90 VA: 0x181F75590
	public static byte[] SerializeToBytes(CamperModule instance) { }

	// RVA: 0x1F754E0 Offset: 0x1F73AE0 VA: 0x181F754E0
	public static void SerializeLengthDelimited(Stream stream, CamperModule instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class BaseVehicle : BaseMountable // TypeDefIndex: 8351
{	// Fields
	private Option __menuOption_Menu_Occupied; // 0x320
	[TooltipAttribute] // RVA: 0xCB2E0 Offset: 0xCA6E0 VA: 0x1800CB2E0
	public bool mountChaining; // 0x378
	public BaseVehicle.ClippingCheckMode clippingChecks; // 0x37C
	public bool shouldShowHudHealth; // 0x380
	public bool ignoreDamageFromOutside; // 0x381
	[HeaderAttribute] // RVA: 0xCB390 Offset: 0xCA790 VA: 0x1800CB390
	public Rigidbody rigidBody; // 0x388
	[HeaderAttribute] // RVA: 0xCB4E0 Offset: 0xCA8E0 VA: 0x1800CB4E0
	public List<BaseVehicle.MountPointInfo> mountPoints; // 0x390
	public bool doClippingAndVisChecks; // 0x398
	[HeaderAttribute] // RVA: 0xCB6A0 Offset: 0xCAAA0 VA: 0x1800CB6A0
	public DamageRenderer damageRenderer; // 0x3A0
	[FormerlySerializedAsAttribute] // RVA: 0xCB8C0 Offset: 0xCACC0 VA: 0x1800CB8C0
	public float explosionForceMultiplier; // 0x3A8
	public float explosionForceMax; // 0x3AC
	public const BaseEntity.Flags Flag_OnlyOwnerEntry = 16;
	public const BaseEntity.Flags Flag_Headlights = 2048;
	public const BaseEntity.Flags Flag_Stationary = 32768;
	public const BaseEntity.Flags Flag_SeatsFull = 524288;
	private readonly List<BaseVehicle> childVehicles; // 0x3B0

	// Properties
	public override bool HasMenuOptions { get; }
	public bool IsMovingOrOn { get; }
	public override float RealisticMass { get; }
	public BaseVehicle.Enumerable allMountPoints { get; }

	// Methods

	// RVA: 0x935AE0 Offset: 0x9340E0 VA: 0x180935AE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x936D50 Offset: 0x935350 VA: 0x180936D50 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x936870 Offset: 0x934E70 VA: 0x180936870 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x936A90 Offset: 0x935090 VA: 0x180936A90 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x935A70 Offset: 0x934070 VA: 0x180935A70 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x936A00 Offset: 0x935000 VA: 0x180936A00 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 186
	public virtual void InitializeClientEffects() { }

	// RVA: 0x935AC0 Offset: 0x9340C0 VA: 0x180935AC0 Slot: 187
	public virtual float GetHUDHealth() { }

	// RVA: 0x934FA0 Offset: 0x9335A0 VA: 0x180934FA0 Slot: 188
	public virtual float GetHUDMaxHealth() { }

	// RVA: 0x936430 Offset: 0x934A30 VA: 0x180936430 Slot: 169
	public override bool LocalPlayerIsMounted() { }

	// RVA: 0x936670 Offset: 0x934C70 VA: 0x180936670 Slot: 189
	public virtual bool Menu_Push_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	[BaseEntity.Menu.Description] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	[BaseEntity.Menu.Icon] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	[BaseEntity.Menu.ShowIf] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x936580 Offset: 0x934B80 VA: 0x180936580 Slot: 190
	protected virtual bool Menu_Occupied_ShowIf(BasePlayer player) { }

	// RVA: 0x9364F0 Offset: 0x934AF0 VA: 0x1809364F0 Slot: 183
	public override bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x936C80 Offset: 0x935280 VA: 0x180936C80 Slot: 191
	protected virtual void WorkshopMode() { }

	// RVA: 0x8CE710 Offset: 0x8CCD10 VA: 0x1808CE710
	public bool IsStationary() { }

	// RVA: 0x936410 Offset: 0x934A10 VA: 0x180936410
	public bool IsMoving() { }

	// RVA: 0x936E20 Offset: 0x935420 VA: 0x180936E20
	public bool get_IsMovingOrOn() { }

	// RVA: 0x936E60 Offset: 0x935460 VA: 0x180936E60 Slot: 76
	public override float get_RealisticMass() { }

	// RVA: 0x936960 Offset: 0x934F60 VA: 0x180936960 Slot: 157
	public override bool PlayerIsMounted(BasePlayer player) { }

	// RVA: 0x6FDD30 Offset: 0x6FC330 VA: 0x1806FDD30 Slot: 192
	protected virtual bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x936120 Offset: 0x934720 VA: 0x180936120
	public bool HasMountPoints() { }

	// RVA: 0x9363B0 Offset: 0x9349B0 VA: 0x1809363B0 Slot: 153
	public override bool IsMounted() { }

	// RVA: 0x9359E0 Offset: 0x933FE0 VA: 0x1809359E0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x9362E0 Offset: 0x9348E0 VA: 0x1809362E0
	public bool IsFlipped() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 193
	public virtual bool IsVehicleRoot() { }

	// RVA: 0x935AA0 Offset: 0x9340A0 VA: 0x180935AA0 Slot: 147
	public override bool DirectlyMountable() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 170
	public override BaseVehicle VehicleParent() { }

	// RVA: 0x936690 Offset: 0x934C90 VA: 0x180936690 Slot: 22
	protected override void OnChildAdded(BaseEntity child) { }

	// RVA: 0x9367A0 Offset: 0x934DA0 VA: 0x1809367A0 Slot: 23
	protected override void OnChildRemoved(BaseEntity child) { }

	// RVA: 0x936F00 Offset: 0x935500 VA: 0x180936F00
	public BaseVehicle.Enumerable get_allMountPoints() { }

	// RVA: 0x935DF0 Offset: 0x9343F0 VA: 0x180935DF0
	public BaseVehicle.MountPointInfo GetMountPoint(int index) { }

	// RVA: 0x936CA0 Offset: 0x9352A0 VA: 0x180936CA0
	public void .ctor() { }

}

public enum BaseVehicle.ClippingCheckMode // TypeDefIndex: 8352
{	// Fields
	public int value__; // 0x0
	public const BaseVehicle.ClippingCheckMode OnMountOnly = 0;
	public const BaseVehicle.ClippingCheckMode Always = 1;
	public const BaseVehicle.ClippingCheckMode AlwaysHeadOnly = 2;

}

public class BaseVehicle.MountPointInfo // TypeDefIndex: 8353
{	// Fields
	public bool isDriver; // 0x10
	public Vector3 pos; // 0x14
	public Vector3 rot; // 0x20
	public string bone; // 0x30
	public GameObjectRef prefab; // 0x38

	// Methods

	// RVA: 0x93A900 Offset: 0x938F00 VA: 0x18093A900
	public void .ctor() { }

}

public struct BaseVehicle.Enumerable : IEnumerable<BaseVehicle.MountPointInfo>, IEnumerable // TypeDefIndex: 8354
{	// Fields
	private readonly BaseVehicle _vehicle; // 0x0

	// Methods

	// RVA: 0xFA2F0 Offset: 0xF96F0 VA: 0x1800FA2F0
	public void .ctor(BaseVehicle vehicle) { }

	// RVA: 0xFA1C0 Offset: 0xF95C0 VA: 0x1800FA1C0
	public BaseVehicle.Enumerator GetEnumerator() { }

	// RVA: 0xFA1F0 Offset: 0xF95F0 VA: 0x1800FA1F0 Slot: 4
	private IEnumerator<BaseVehicle.MountPointInfo> System.Collections.Generic.IEnumerable<BaseVehicle.MountPointInfo>.GetEnumerator() { }

	// RVA: 0xFA270 Offset: 0xF9670 VA: 0x1800FA270 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public struct BaseVehicle.Enumerator : IEnumerator<BaseVehicle.MountPointInfo>, IEnumerator, IDisposable // TypeDefIndex: 8355
{	// Fields
	private readonly BaseVehicle _vehicle; // 0x0
	private BaseVehicle.Enumerator.State _state; // 0x8
	private int _index; // 0xC
	private int _childIndex; // 0x10
	private BaseVehicle.Enumerator.Box _enumerator; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseVehicle.MountPointInfo <Current>k__BackingField; // 0x20

	// Properties
	public BaseVehicle.MountPointInfo Current { get; set; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3730 Offset: 0xF2B30 VA: 0x1800F3730 Slot: 4
	public BaseVehicle.MountPointInfo get_Current() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF14E0 Offset: 0xF08E0 VA: 0x1800F14E0
	private void set_Current(BaseVehicle.MountPointInfo value) { }

	// RVA: 0xFA350 Offset: 0xF9750 VA: 0x1800FA350
	public void .ctor(BaseVehicle vehicle) { }

	// RVA: 0xFA330 Offset: 0xF9730 VA: 0x1800FA330 Slot: 6
	public bool MoveNext() { }

	// RVA: 0xF3730 Offset: 0xF2B30 VA: 0x1800F3730 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xFA320 Offset: 0xF9720 VA: 0x1800FA320 Slot: 5
	public void Dispose() { }

	// RVA: 0xFA340 Offset: 0xF9740 VA: 0x1800FA340 Slot: 8
	public void Reset() { }

}

private enum BaseVehicle.Enumerator.State // TypeDefIndex: 8356
{	// Fields
	public int value__; // 0x0
	public const BaseVehicle.Enumerator.State Direct = 0;
	public const BaseVehicle.Enumerator.State EnterChild = 1;
	public const BaseVehicle.Enumerator.State EnumerateChild = 2;
	public const BaseVehicle.Enumerator.State Finished = 3;

}

private class BaseVehicle.Enumerator.Box : Pool.IPooled // TypeDefIndex: 8357
{	// Fields
	public BaseVehicle.Enumerator Value; // 0x10

	// Methods

	// RVA: 0x93A1B0 Offset: 0x9387B0 VA: 0x18093A1B0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x93A1B0 Offset: 0x9387B0 VA: 0x18093A1B0 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class BaseVehicleModule : BaseVehicle, IPrefabPreProcess // TypeDefIndex: 8358
{	// Fields
	private Option __menuOption_Menu_Locked; // 0x3B8
	private Option __menuOption_Menu_Push; // 0x410
	private Option __menuOption_Menu_Use; // 0x468
	public const string CAR_LOCKED_ACTION_NAME = "car_locked";
	[HeaderAttribute] // RVA: 0xCC240 Offset: 0xCB640 VA: 0x1800CC240
	[SerializeField] // RVA: 0xCC240 Offset: 0xCB640 VA: 0x1800CC240
	private Transform centreOfMassTransform; // 0x4C0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float mass; // 0x4C8
	public BaseVehicleModule.VisualGroup visualGroup; // 0x4CC
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private VehicleLight[] lights; // 0x4D0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseModularVehicle <Vehicle>k__BackingField; // 0x4D8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <FirstSocketIndex>k__BackingField; // 0x4E0
	public BaseVehicleModule.LODLevel[] lodRenderers; // 0x4E8
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private List<ConditionalObject> conditionals; // 0x4F0
	[HeaderAttribute] // RVA: 0xCCB00 Offset: 0xCBF00 VA: 0x1800CCB00
	[SerializeField] // RVA: 0xCCB00 Offset: 0xCBF00 VA: 0x1800CCB00
	private TriggerParent[] triggerParents; // 0x4F8
	[HeaderAttribute] // RVA: 0xCCD30 Offset: 0xCC130 VA: 0x1800CCD30
	[SerializeField] // RVA: 0xCCD30 Offset: 0xCC130 VA: 0x1800CCD30
	private VehicleModuleSlidingComponent[] slidingComponents; // 0x500
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleModuleButtonComponent[] buttonComponents; // 0x508
	private TimeSince TimeSinceAddedToVehicle; // 0x510
	private float prevRefreshHealth; // 0x514
	private bool prevRefreshVehicleIsDead; // 0x518
	private bool prevRefreshVehicleIsLockable; // 0x519

	// Properties
	public override bool HasMenuOptions { get; }
	public BaseModularVehicle Vehicle { get; set; }
	public int FirstSocketIndex { get; set; }
	public Vector3 CentreOfMass { get; }
	public float Mass { get; }
	public uint ID { get; }
	public bool IsOnAVehicle { get; }
	public ItemDefinition AssociatedItemDef { get; }
	public virtual bool HasSeating { get; }
	public virtual bool HasAnEngine { get; }

	// Methods

	// RVA: 0x932AE0 Offset: 0x9310E0 VA: 0x180932AE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x935250 Offset: 0x933850 VA: 0x180935250 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x933E10 Offset: 0x932410 VA: 0x180933E10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x932390 Offset: 0x930990 VA: 0x180932390 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x932640 Offset: 0x930C40 VA: 0x180932640 Slot: 194
	public virtual void ClientVehicleTick() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 195
	public virtual void OnClientTickStopped() { }

	// RVA: 0x932410 Offset: 0x930A10 VA: 0x180932410 Slot: 196
	public virtual void ClientOnLoad() { }

	// RVA: 0x9327A0 Offset: 0x930DA0 VA: 0x1809327A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x934F20 Offset: 0x933520 VA: 0x180934F20
	public void SetLightState(bool headlightsOn, bool brakesOn) { }

	// RVA: 0x9321A0 Offset: 0x9307A0 VA: 0x1809321A0
	public void ClearDecals(BaseVehicleModule.DecalType decalType) { }

	// RVA: 0x932810 Offset: 0x930E10 VA: 0x180932810
	public void DrawHighlight() { }

	// RVA: 0x933690 Offset: 0x931C90 VA: 0x180933690 Slot: 183
	public override bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Description] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Icon] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	// RVA: 0x933810 Offset: 0x931E10 VA: 0x180933810
	public void Menu_Push(BasePlayer player) { }

	// RVA: 0x933760 Offset: 0x931D60 VA: 0x180933760 Slot: 189
	public override bool Menu_Push_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	[BaseEntity.Menu.Description] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	[BaseEntity.Menu.Icon] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	[BaseEntity.Menu.ShowIf] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	// RVA: 0x933BB0 Offset: 0x9321B0 VA: 0x180933BB0
	public void Menu_Use(BasePlayer player) { }

	// RVA: 0x9338B0 Offset: 0x931EB0 VA: 0x1809338B0
	public bool Menu_Use_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	[BaseEntity.Menu.Description] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	[BaseEntity.Menu.Icon] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	[BaseEntity.Menu.ShowIf] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Locked(BasePlayer player) { }

	// RVA: 0x933540 Offset: 0x931B40 VA: 0x180933540 Slot: 197
	public virtual bool Menu_Locked_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935450 Offset: 0x933A50 VA: 0x180935450
	public BaseModularVehicle get_Vehicle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935470 Offset: 0x933A70 VA: 0x180935470
	private void set_Vehicle(BaseModularVehicle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935240 Offset: 0x933840 VA: 0x180935240
	public int get_FirstSocketIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935460 Offset: 0x933A60 VA: 0x180935460
	private void set_FirstSocketIndex(int value) { }

	// RVA: 0x935200 Offset: 0x933800 VA: 0x180935200
	public Vector3 get_CentreOfMass() { }

	// RVA: 0x935440 Offset: 0x933A40 VA: 0x180935440
	public float get_Mass() { }

	// RVA: 0x52EEF0 Offset: 0x52D4F0 VA: 0x18052EEF0
	public uint get_ID() { }

	// RVA: 0x9353E0 Offset: 0x9339E0 VA: 0x1809353E0
	public bool get_IsOnAVehicle() { }

	// RVA: 0x77AB40 Offset: 0x779140 VA: 0x18077AB40
	public ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 198
	public virtual bool get_HasSeating() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 199
	public virtual bool get_HasAnEngine() { }

	// RVA: 0x933F40 Offset: 0x932540 VA: 0x180933F40 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x934D20 Offset: 0x933320 VA: 0x180934D20
	public void RefreshParameters() { }

	// RVA: 0x933D50 Offset: 0x932350 VA: 0x180933D50 Slot: 200
	public virtual void ModuleAdded(BaseModularVehicle vehicle, int firstSocketIndex) { }

	// RVA: 0x933DE0 Offset: 0x9323E0 VA: 0x180933DE0 Slot: 201
	public virtual void ModuleRemoved() { }

	// RVA: 0x933F00 Offset: 0x932500 VA: 0x180933F00
	public void OtherVehicleModulesChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 202
	public virtual void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState) { }

	// RVA: 0x9334A0 Offset: 0x931AA0 VA: 0x1809334A0 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x934FA0 Offset: 0x9335A0 VA: 0x180934FA0 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x933290 Offset: 0x931890 VA: 0x180933290
	public int GetNumSocketsTaken() { }

	// RVA: 0x932940 Offset: 0x930F40 VA: 0x180932940
	public List<ConditionalObject> GetConditionals() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 203
	public virtual float GetMaxDriveForce() { }

	// RVA: 0x934B00 Offset: 0x933100 VA: 0x180934B00
	public void RefreshConditionals(bool canGib) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 204
	protected virtual void PostConditionalRefresh() { }

	// RVA: 0x934020 Offset: 0x932620 VA: 0x180934020
	private void RefreshConditional(ConditionalObject conditional, bool canGib) { }

	// RVA: 0x935110 Offset: 0x933710 VA: 0x180935110
	private bool TryGetAdjacentModuleInFront(out BaseVehicleModule result) { }

	// RVA: 0x934FC0 Offset: 0x9335C0 VA: 0x180934FC0
	private bool TryGetAdjacentModuleBehind(out BaseVehicleModule result) { }

	// RVA: 0x933330 Offset: 0x931930 VA: 0x180933330
	private bool InSameVisualGroupAs(BaseVehicleModule moduleEntity, ConditionalObject.AdjacentMatchType matchType) { }

	// RVA: 0x932040 Offset: 0x930640 VA: 0x180932040
	private bool CanBeUsedNowBy(BasePlayer player) { }

	// RVA: 0x933F10 Offset: 0x932510 VA: 0x180933F10
	public bool PlayerIsLookingAtUsable(string lookingAtColldierName, string usableColliderName) { }

	// RVA: 0x933430 Offset: 0x931A30 VA: 0x180933430 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 193
	public override bool IsVehicleRoot() { }

	// RVA: 0x9351D0 Offset: 0x9337D0 VA: 0x1809351D0
	public void .ctor() { }

}

public enum BaseVehicleModule.DecalType // TypeDefIndex: 8359
{	// Fields
	public int value__; // 0x0
	public const BaseVehicleModule.DecalType All = 0;
	public const BaseVehicleModule.DecalType Glass = 1;

}

public enum BaseVehicleModule.VisualGroup // TypeDefIndex: 8360
{	// Fields
	public int value__; // 0x0
	public const BaseVehicleModule.VisualGroup None = 0;
	public const BaseVehicleModule.VisualGroup Engine = 1;
	public const BaseVehicleModule.VisualGroup Cabin = 2;
	public const BaseVehicleModule.VisualGroup Flatbed = 3;

}

public class BaseVehicleModule.LODLevel // TypeDefIndex: 8361
{	// Fields
	public Renderer[] renderers; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class EngineSwitch : BaseEntity // TypeDefIndex: 8389
{	// Fields
	private Option __menuOption_Menu_StartEngine; // 0x168
	private Option __menuOption_Menu_StopEngine; // 0x1C0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x8C35F0 Offset: 0x8C1BF0 VA: 0x1808C35F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8C3CF0 Offset: 0x8C22F0 VA: 0x1808C3CF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8C3BA0 Offset: 0x8C21A0 VA: 0x1808C3BA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	[BaseEntity.Menu.Description] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	[BaseEntity.Menu.Icon] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	[BaseEntity.Menu.ShowIf] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	// RVA: 0x8C3B20 Offset: 0x8C2120 VA: 0x1808C3B20
	public void Menu_StartEngine(BasePlayer player) { }

	// RVA: 0x50DF50 Offset: 0x50C550 VA: 0x18050DF50
	public bool Menu_EngineOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	[BaseEntity.Menu.Description] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	[BaseEntity.Menu.Icon] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	[BaseEntity.Menu.ShowIf] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	// RVA: 0x8C3B60 Offset: 0x8C2160 VA: 0x1808C3B60
	public void Menu_StopEngine(BasePlayer player) { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool Menu_EngineOff_ShowIf(BasePlayer player) { }

	// RVA: 0x8C3C90 Offset: 0x8C2290 VA: 0x1808C3C90
	public void .ctor() { }

}

public class ModularCar : BaseModularVehicle, IVehicleLockUser, VehicleChassisVisuals.IClientWheelUser<ModularCar> // TypeDefIndex: 8415
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x4C0
	private Option __menuOption_Menu_Locked; // 0x518
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataFL>k__BackingField; // 0x570
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataFR>k__BackingField; // 0x578
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataRL>k__BackingField; // 0x580
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataRR>k__BackingField; // 0x588
	public TimeSince timeSinceLastUpdate; // 0x590
	public TimeSince timeSinceFailedStartAttempt; // 0x594
	private float clientSteerAngle; // 0x598
	private float clientDriveWheelVelocity; // 0x59C
	private float clientDriveWheelSlip; // 0x5A0
	private float clientThrottle; // 0x5A4
	private float clientBrake; // 0x5A8
	private bool cachedEngineLowPerf; // 0x5AC
	private TimeSince timeSinceEnginePerfCheck; // 0x5B0
	private bool failedStartWasEngineProblem; // 0x5B4
	private bool wasBraking; // 0x5B5
	private const float FAILED_START_LIGHT_TIME = 1;
	private static int detailColorID; // 0x0
	[HeaderAttribute] // RVA: 0x71520 Offset: 0x70920 VA: 0x180071520
	public ModularCarChassisVisuals chassisVisuals; // 0x5B8
	public VisualCarWheel wheelFL; // 0x5C0
	public VisualCarWheel wheelFR; // 0x5C8
	public VisualCarWheel wheelRL; // 0x5D0
	public VisualCarWheel wheelRR; // 0x5D8
	public ItemDefinition carKeyDefinition; // 0x5E0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CarSettings carSettings; // 0x5E8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float hurtTriggerMinSpeed; // 0x5F0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TriggerHurtNotChild hurtTriggerFront; // 0x5F8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TriggerHurtNotChild hurtTriggerRear; // 0x600
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ProtectionProperties immortalProtection; // 0x608
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ProtectionProperties mortalProtection; // 0x610
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ModularCar.SpawnSettings spawnSettings; // 0x618
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private MeshRenderer[] damageShowingRenderers; // 0x620
	[ServerVar] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public static float population; // 0x4
	[ServerVar] // RVA: 0x72140 Offset: 0x71540 VA: 0x180072140
	public static float outsidedecayminutes; // 0x8
	public const BUTTON RapidSteerButton = 128;
	public ModularCarLock carLock; // 0x628
	private VehicleEngineController.EngineState<GroundVehicle> lastSetEngineState; // 0x630
	private float cachedFuelFraction; // 0x634

	// Properties
	public override bool HasMenuOptions { get; }
	public VehicleChassisVisuals.ClientWheelData<ModularCar> WheelDataFL { get; set; }
	public VehicleChassisVisuals.ClientWheelData<ModularCar> WheelDataFR { get; set; }
	public VehicleChassisVisuals.ClientWheelData<ModularCar> WheelDataRL { get; set; }
	public VehicleChassisVisuals.ClientWheelData<ModularCar> WheelDataRR { get; set; }
	public override float DriveWheelVelocity { get; }
	public float DriveWheelSlip { get; }
	public float SteerAngle { get; }
	public ItemDefinition AssociatedItemDef { get; }
	public float MaxSteerAngle { get; }
	public override bool IsLockable { get; }

	// Methods

	// RVA: 0x7785C0 Offset: 0x776BC0 VA: 0x1807785C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x77AB70 Offset: 0x779170 VA: 0x18077AB70 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x779AF0 Offset: 0x7780F0 VA: 0x180779AF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AD20 Offset: 0x779320 VA: 0x18077AD20
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFL() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AD60 Offset: 0x779360 VA: 0x18077AD60
	private void set_WheelDataFL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AD30 Offset: 0x779330 VA: 0x18077AD30
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFR() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AD70 Offset: 0x779370 VA: 0x18077AD70
	private void set_WheelDataFR(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AD40 Offset: 0x779340 VA: 0x18077AD40
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRL() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AD80 Offset: 0x779380 VA: 0x18077AD80
	private void set_WheelDataRL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AD50 Offset: 0x779350 VA: 0x18077AD50
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRR() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AD90 Offset: 0x779390 VA: 0x18077AD90
	private void set_WheelDataRR(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	// RVA: 0x777C70 Offset: 0x776270 VA: 0x180777C70 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7799A0 Offset: 0x777FA0 VA: 0x1807799A0 Slot: 132
	protected override void OnLifeStateChanged() { }

	// RVA: 0x778080 Offset: 0x776680 VA: 0x180778080 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x778C70 Offset: 0x777270 VA: 0x180778C70
	public bool HasAnEngineAtLowPerformance() { }

	// RVA: 0x778E80 Offset: 0x777480 VA: 0x180778E80
	public bool HasLowFuel() { }

	// RVA: 0x778C30 Offset: 0x777230 VA: 0x180778C30
	public bool HadRecentFailedEngineStart() { }

	// RVA: 0x77A7B0 Offset: 0x778DB0 VA: 0x18077A7B0 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0x778B50 Offset: 0x777150 VA: 0x180778B50 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0x7798E0 Offset: 0x777EE0 VA: 0x1807798E0 Slot: 201
	protected override void OnClientTickStopped() { }

	// RVA: 0x778F30 Offset: 0x777530 VA: 0x180778F30 Slot: 204
	protected override bool IsBraking() { }

	[BaseEntity.Menu] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Description] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Icon] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	// RVA: 0x779250 Offset: 0x777850 VA: 0x180779250
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x779180 Offset: 0x777780 VA: 0x180779180
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	[BaseEntity.Menu.Description] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	[BaseEntity.Menu.Icon] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	[BaseEntity.Menu.ShowIf] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Locked(BasePlayer player) { }

	// RVA: 0x779290 Offset: 0x777890 VA: 0x180779290
	public bool Menu_Locked_ShowIf(BasePlayer player) { }

	// RVA: 0x7796F0 Offset: 0x777CF0 VA: 0x1807796F0 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x778170 Offset: 0x776770 VA: 0x180778170 Slot: 187
	public override float GetHUDHealth() { }

	// RVA: 0x778240 Offset: 0x776840 VA: 0x180778240 Slot: 188
	public override float GetHUDMaxHealth() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x779370 Offset: 0x777970 VA: 0x180779370
	private void ModularCarUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7780B0 Offset: 0x7766B0 VA: 0x1807780B0
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x77AB60 Offset: 0x779160 VA: 0x18077AB60 Slot: 196
	public override float get_DriveWheelVelocity() { }

	// RVA: 0x77AB50 Offset: 0x779150 VA: 0x18077AB50
	public float get_DriveWheelSlip() { }

	// RVA: 0x77AD10 Offset: 0x779310 VA: 0x18077AD10 Slot: 215
	public float get_SteerAngle() { }

	// RVA: 0x77AB40 Offset: 0x779140 VA: 0x18077AB40
	public ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0x77ACF0 Offset: 0x7792F0 VA: 0x18077ACF0 Slot: 216
	public float get_MaxSteerAngle() { }

	// RVA: 0x77ACC0 Offset: 0x7792C0 VA: 0x18077ACC0 Slot: 206
	public override bool get_IsLockable() { }

	// RVA: 0x77A470 Offset: 0x778A70 VA: 0x18077A470 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x778EA0 Offset: 0x7774A0 VA: 0x180778EA0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x779150 Offset: 0x777750 VA: 0x180779150 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x779150 Offset: 0x777750 VA: 0x180779150 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x778170 Offset: 0x776770 VA: 0x180778170
	public float TotalHealth() { }

	// RVA: 0x778240 Offset: 0x776840 VA: 0x180778240
	public float TotalMaxHealth() { }

	// RVA: 0x778430 Offset: 0x776A30 VA: 0x180778430 Slot: 197
	public override float GetMaxForwardSpeed() { }

	// RVA: 0x778F60 Offset: 0x777560 VA: 0x180778F60 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x779960 Offset: 0x777F60 VA: 0x180779960 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x778B20 Offset: 0x777120 VA: 0x180778B20 Slot: 198
	public override float GetThrottleInput() { }

	// RVA: 0x778130 Offset: 0x776730 VA: 0x180778130 Slot: 199
	public override float GetBrakeInput() { }

	// RVA: 0x778310 Offset: 0x776910 VA: 0x180778310
	public float GetMaxDriveForce() { }

	// RVA: 0x778160 Offset: 0x776760 VA: 0x180778160
	public float GetFuelFraction() { }

	// RVA: 0x77A440 Offset: 0x778A40 VA: 0x18077A440 Slot: 210
	public bool PlayerHasUnlockPermission(BasePlayer player) { }

	// RVA: 0x77A3E0 Offset: 0x7789E0 VA: 0x18077A3E0 Slot: 207
	public override bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0x77A390 Offset: 0x778990 VA: 0x18077A390 Slot: 212
	public bool PlayerCanDestroyLock(BasePlayer player, BaseVehicleModule viaModule) { }

	// RVA: 0x777AF0 Offset: 0x7760F0 VA: 0x180777AF0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x777C00 Offset: 0x776200 VA: 0x180777C00 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x77A570 Offset: 0x778B70 VA: 0x18077A570
	protected bool RefreshEngineState() { }

	// RVA: 0x77A740 Offset: 0x778D40 VA: 0x18077A740
	private float RollOffDriveForce(float driveForce) { }

	// RVA: 0x77A520 Offset: 0x778B20 VA: 0x18077A520
	private void RefreshChassisProtectionState() { }

	// RVA: 0x779490 Offset: 0x777A90 VA: 0x180779490 Slot: 208
	protected override void ModuleEntityAdded(BaseVehicleModule addedModule) { }

	// RVA: 0x7795C0 Offset: 0x777BC0 VA: 0x1807795C0 Slot: 209
	protected override void ModuleEntityRemoved(BaseVehicleModule removedModule) { }

	// RVA: 0x77AB20 Offset: 0x779120 VA: 0x18077AB20
	public void .ctor() { }

	// RVA: 0x77AAB0 Offset: 0x7790B0 VA: 0x18077AAB0
	private static void .cctor() { }

}

public class ModularCar.SpawnSettings // TypeDefIndex: 8416
{	// Fields
	[TooltipAttribute] // RVA: 0x759A0 Offset: 0x74DA0 VA: 0x1800759A0
	public bool useSpawnSettings; // 0x10
	[TooltipAttribute] // RVA: 0x75AC0 Offset: 0x74EC0 VA: 0x180075AC0
	public ModularCarPresetConfig[] configurationOptions; // 0x18
	[TooltipAttribute] // RVA: 0x75D60 Offset: 0x75160 VA: 0x180075D60
	public float minStartHealthPercent; // 0x20
	[TooltipAttribute] // RVA: 0x75E60 Offset: 0x75260 VA: 0x180075E60
	public float maxStartHealthPercent; // 0x24
	public ModularCar.SpawnSettings.AdminBonus adminBonus; // 0x28

	// Methods

	// RVA: 0x77EBB0 Offset: 0x77D1B0 VA: 0x18077EBB0
	public void .ctor() { }

}

public enum ModularCar.SpawnSettings.AdminBonus // TypeDefIndex: 8417
{	// Fields
	public int value__; // 0x0
	public const ModularCar.SpawnSettings.AdminBonus None = 0;
	public const ModularCar.SpawnSettings.AdminBonus T1PlusFuel = 1;
	public const ModularCar.SpawnSettings.AdminBonus T2PlusFuel = 2;
	public const ModularCar.SpawnSettings.AdminBonus T3PlusFuel = 3;

}

public class ModularCarGarage : ContainerIOEntity // TypeDefIndex: 8418
{	// Fields
	private Option __menuOption_Menu_EditVehicle; // 0x378
	private Option __menuOption_Menu_InsufficientPower; // 0x3D0
	private TimeSince lastChassisDestroyTime; // 0x428
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform vehicleLift; // 0x430
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Animation vehicleLiftAnim; // 0x438
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string animName; // 0x440
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleLiftOccupantTrigger occupantTrigger; // 0x448
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float liftMoveTime; // 0x450
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EmissionToggle poweredLight; // 0x458
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EmissionToggle inUseLight; // 0x460
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform vehicleLiftPos; // 0x468
	[SerializeField] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	[RangeAttribute] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	private float recycleEfficiency; // 0x470
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform recycleDropPos; // 0x478
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool needsElectricity; // 0x480
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition liftStartSoundDef; // 0x488
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition liftStopSoundDef; // 0x490
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition liftStopDownSoundDef; // 0x498
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition liftLoopSoundDef; // 0x4A0
	public ModularCarGarage.ChassisBuildOption[] chassisBuildOptions; // 0x4A8
	public ItemAmount lockResourceCost; // 0x4B0
	public ItemDefinition carKeyDefinition; // 0x4B8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <PlatformIsOccupied>k__BackingField; // 0x4C0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <HasEditableOccupant>k__BackingField; // 0x4C1
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <HasDriveableOccupant>k__BackingField; // 0x4C2
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ModularCarGarage.OccupantLock <OccupantLockState>k__BackingField; // 0x4C4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <OccupantLockID>k__BackingField; // 0x4C8
	private ModularCarGarage.VehicleLiftState vehicleLiftState; // 0x4CC
	private Sound liftLoopSound; // 0x4D0
	private Vector3 downPos; // 0x4D8
	public const BaseEntity.Flags DestroyingChassis = 16384;
	public const float TimeToDestroyChassis = 10;

	// Properties
	public override bool HasMenuOptions { get; }
	public float TimeLeftToCancelChassisDestroy { get; }
	public bool PlatformIsOccupied { get; set; }
	public bool HasEditableOccupant { get; set; }
	public bool HasDriveableOccupant { get; set; }
	public ModularCarGarage.OccupantLock OccupantLockState { get; set; }
	public int OccupantLockID { get; set; }
	private bool LiftIsUp { get; }
	private bool LiftIsMoving { get; }
	private bool LiftIsDown { get; }
	public bool IsDestroyingChassis { get; }

	// Methods

	// RVA: 0x775710 Offset: 0x773D10 VA: 0x180775710 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x776DD0 Offset: 0x7753D0 VA: 0x180776DD0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7764C0 Offset: 0x774AC0 VA: 0x1807764C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x775570 Offset: 0x773B70 VA: 0x180775570 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x776B70 Offset: 0x775170 VA: 0x180776B70
	public void TryRepair(uint itemUID) { }

	// RVA: 0x775C60 Offset: 0x774260 VA: 0x180775C60 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7756A0 Offset: 0x773CA0 VA: 0x1807756A0
	public void ClientSelectedLootItem(Item item) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 165
	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x7765B0 Offset: 0x774BB0 VA: 0x1807765B0
	private bool PlayerHasInternalModuleLoot() { }

	// RVA: 0x7755E0 Offset: 0x773BE0 VA: 0x1807755E0
	public void ClientRequestAddLock() { }

	// RVA: 0x775660 Offset: 0x773C60 VA: 0x180775660
	public void ClientRequestRemoveLock() { }

	// RVA: 0x775620 Offset: 0x773C20 VA: 0x180775620
	public void ClientRequestNewKey() { }

	// RVA: 0x776870 Offset: 0x774E70 VA: 0x180776870
	private void RefreshPoweredLightState() { }

	// RVA: 0x7767E0 Offset: 0x774DE0 VA: 0x1807767E0
	private void RefreshInUseLightState() { }

	[BaseEntity.Menu] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	[BaseEntity.Menu.Description] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	[BaseEntity.Menu.Icon] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	[BaseEntity.Menu.ShowIf] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	// RVA: 0x775F90 Offset: 0x774590 VA: 0x180775F90
	public void Menu_EditVehicle(BasePlayer player) { }

	// RVA: 0x775E90 Offset: 0x774490 VA: 0x180775E90
	public bool Menu_EditVehicle_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	[BaseEntity.Menu.Description] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	[BaseEntity.Menu.Icon] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	[BaseEntity.Menu.ShowIf] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_InsufficientPower(BasePlayer player) { }

	// RVA: 0x775FD0 Offset: 0x7745D0 VA: 0x180775FD0
	public bool Menu_InsufficientPower_ShowIf(BasePlayer player) { }

	// RVA: 0x776970 Offset: 0x774F70 VA: 0x180776970
	public void StartChassisDestroy() { }

	// RVA: 0x775510 Offset: 0x773B10 VA: 0x180775510
	public void CancelChassisDestroy() { }

	// RVA: 0x776FA0 Offset: 0x7755A0 VA: 0x180776FA0
	public float get_TimeLeftToCancelChassisDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776F90 Offset: 0x775590 VA: 0x180776F90
	public bool get_PlatformIsOccupied() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x777080 Offset: 0x775680 VA: 0x180777080
	private void set_PlatformIsOccupied(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776DC0 Offset: 0x7753C0 VA: 0x180776DC0
	public bool get_HasEditableOccupant() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x777050 Offset: 0x775650 VA: 0x180777050
	private void set_HasEditableOccupant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776DB0 Offset: 0x7753B0 VA: 0x180776DB0
	public bool get_HasDriveableOccupant() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x777040 Offset: 0x775640 VA: 0x180777040
	private void set_HasDriveableOccupant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776F80 Offset: 0x775580 VA: 0x180776F80
	public ModularCarGarage.OccupantLock get_OccupantLockState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x777070 Offset: 0x775670 VA: 0x180777070
	private void set_OccupantLockState(ModularCarGarage.OccupantLock value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776F70 Offset: 0x775570 VA: 0x180776F70
	public int get_OccupantLockID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x777060 Offset: 0x775660 VA: 0x180777060
	private void set_OccupantLockID(int value) { }

	// RVA: 0x776F60 Offset: 0x775560 VA: 0x180776F60
	private bool get_LiftIsUp() { }

	// RVA: 0x776F30 Offset: 0x775530 VA: 0x180776F30
	private bool get_LiftIsMoving() { }

	// RVA: 0x776F20 Offset: 0x775520 VA: 0x180776F20
	private bool get_LiftIsDown() { }

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool get_IsDestroyingChassis() { }

	// RVA: 0x776780 Offset: 0x774D80 VA: 0x180776780 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x776460 Offset: 0x774A60 VA: 0x180776460 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5B0430 Offset: 0x5AEA30 VA: 0x1805B0430 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x6F3610 Offset: 0x6F1C10 VA: 0x1806F3610 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x7768B0 Offset: 0x774EB0 VA: 0x1807768B0
	private void SetOccupantState(bool hasOccupant, bool editableOccupant, bool driveableOccupant, ModularCarGarage.OccupantLock occupantLockState, int occupantLockID, bool forced = False) { }

	// RVA: 0x776810 Offset: 0x774E10 VA: 0x180776810
	private void RefreshLiftState(bool forced = False) { }

	// RVA: 0x7762C0 Offset: 0x7748C0 VA: 0x1807762C0
	private void MoveLift(ModularCarGarage.VehicleLiftState desiredLiftState, float startDelay = 0, bool forced = False) { }

	// RVA: 0x776240 Offset: 0x774840 VA: 0x180776240
	private void MoveLiftUp() { }

	// RVA: 0x776090 Offset: 0x774690 VA: 0x180776090
	private void MoveLiftDown() { }

	// RVA: 0x7769C0 Offset: 0x774FC0 VA: 0x1807769C0
	private void StartLiftSounds() { }

	// RVA: 0x776BC0 Offset: 0x7751C0 VA: 0x180776BC0
	private void UpdateLiftSounds() { }

	// RVA: 0x776D50 Offset: 0x775350 VA: 0x180776D50
	public void .ctor() { }

}

public class ModularCarGarage.ChassisBuildOption // TypeDefIndex: 8419
{	// Fields
	public GameObjectRef prefab; // 0x10
	public ItemDefinition itemDef; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum ModularCarGarage.OccupantLock // TypeDefIndex: 8420
{	// Fields
	public int value__; // 0x0
	public const ModularCarGarage.OccupantLock CannotHaveLock = 0;
	public const ModularCarGarage.OccupantLock NoLock = 1;
	public const ModularCarGarage.OccupantLock HasLock = 2;

}

private enum ModularCarGarage.VehicleLiftState // TypeDefIndex: 8421
{	// Fields
	public int value__; // 0x0
	public const ModularCarGarage.VehicleLiftState Down = 0;
	public const ModularCarGarage.VehicleLiftState Up = 1;

}

public class MotorRowboat : BaseBoat // TypeDefIndex: 8422
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x438
	private Option __menuOption_Menu_StartEngine; // 0x490
	private Option __menuOption_Menu_StopEngine; // 0x4E8
	[HeaderAttribute] // RVA: 0x720C0 Offset: 0x714C0 VA: 0x1800720C0
	public BlendedSoundLoops engineLoops; // 0x540
	public BlendedSoundLoops waterLoops; // 0x548
	public SoundDefinition engineStartSoundDef; // 0x550
	public SoundDefinition engineStopSoundDef; // 0x558
	public SoundDefinition movementSplashAccentSoundDef; // 0x560
	public SoundDefinition engineSteerSoundDef; // 0x568
	public GameObjectRef pushLandEffect; // 0x570
	public GameObjectRef pushWaterEffect; // 0x578
	public float waterSpeedDivisor; // 0x580
	public float turnPitchModScale; // 0x584
	public float tiltPitchModScale; // 0x588
	public float splashAccentFrequencyMin; // 0x58C
	public float splashAccentFrequencyMax; // 0x590
	private float directionalPitchModScale; // 0x594
	private float vol; // 0x598
	private float pitch; // 0x59C
	private float speed; // 0x5A0
	private bool wasEngineOn; // 0x5A4
	private float nextSplashAccent; // 0x5A8
	private int prevSteering; // 0x5AC
	protected const BaseEntity.Flags Flag_EngineOn = 128;
	protected const BaseEntity.Flags Flag_ThrottleOn = 256;
	protected const BaseEntity.Flags Flag_TurnLeft = 512;
	protected const BaseEntity.Flags Flag_TurnRight = 1024;
	protected const BaseEntity.Flags Flag_Submerged = 2048;
	protected const BaseEntity.Flags Flag_HasFuel = 16384;
	protected const BaseEntity.Flags Flag_RecentlyPushed = 65536;
	private const float submergeFractionMinimum = 0,85;
	[HeaderAttribute] // RVA: 0x78540 Offset: 0x77940 VA: 0x180078540
	public GameObjectRef fuelStoragePrefab; // 0x5B0
	public float fuelPerSec; // 0x5B8
	[HeaderAttribute] // RVA: 0x786B0 Offset: 0x77AB0 VA: 0x1800786B0
	public GameObjectRef storageUnitPrefab; // 0x5C0
	public EntityRef<StorageContainer> storageUnitInstance; // 0x5C8
	[HeaderAttribute] // RVA: 0x787C0 Offset: 0x77BC0 VA: 0x1800787C0
	public Transform boatRear; // 0x5D8
	public ParticleSystemContainer wakeEffect; // 0x5E0
	public ParticleSystemContainer engineEffectIdle; // 0x5E8
	public ParticleSystemContainer engineEffectThrottle; // 0x5F0
	public Projector causticsProjector; // 0x5F8
	public Transform causticsDepthTest; // 0x600
	public Transform engineLeftHandPosition; // 0x608
	public Transform engineRotate; // 0x610
	public Transform propellerRotate; // 0x618
	[ServerVar] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public static float population; // 0x0
	[ServerVar] // RVA: 0x79E60 Offset: 0x79260 VA: 0x180079E60
	public static float outsidedecayminutes; // 0x4
	[ServerVar] // RVA: 0x79F70 Offset: 0x79370 VA: 0x180079F70
	public static float deepwaterdecayminutes; // 0x8
	protected EntityFuelSystem fuelSystem; // 0x620
	public Transform[] stationaryDismounts; // 0x628
	public Collider mainCollider; // 0x630
	public float angularDragBase; // 0x638
	public float angularDragVelocity; // 0x63C
	public float landDrag; // 0x640
	public float waterDrag; // 0x644
	public float offAxisDrag; // 0x648
	public float offAxisDot; // 0x64C
	private AverageVelocity averageVelocity; // 0x650
	private bool wasWakeOn; // 0x658
	private bool wasEngineSprayOn; // 0x659
	private bool wasEngineIdleOn; // 0x65A
	private Material causticsMaterial; // 0x660
	private Color causticsColor; // 0x668
	private float causticsAlpha; // 0x678
	protected float currentEngineRotation; // 0x67C
	protected float propellerRotationSpeed; // 0x680

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7B70F0 Offset: 0x7B56F0 VA: 0x1807B70F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7B98B0 Offset: 0x7B7EB0 VA: 0x1807B98B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7B7FA0 Offset: 0x7B65A0 VA: 0x1807B7FA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7B8AE0 Offset: 0x7B70E0 VA: 0x1807B8AE0
	public void UpdateSounds() { }

	// RVA: 0x7B79A0 Offset: 0x7B5FA0 VA: 0x1807B79A0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x7B89C0 Offset: 0x7B6FC0 VA: 0x1807B89C0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x7B96A0 Offset: 0x7B7CA0 VA: 0x1807B96A0
	public void Update() { }

	// RVA: 0x7B9180 Offset: 0x7B7780 VA: 0x1807B9180
	public void UpdateWake() { }

	// RVA: 0x7B8280 Offset: 0x7B6880 VA: 0x1807B8280
	public void UpdateEffects() { }

	// RVA: 0x7B7A50 Offset: 0x7B6050 VA: 0x1807B7A50 Slot: 186
	public override void InitializeClientEffects() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 196
	public virtual void ShutdownClientEffects() { }

	// RVA: 0x7B86E0 Offset: 0x7B6CE0 VA: 0x1807B86E0 Slot: 197
	public virtual void UpdateEngineRotation() { }

	// RVA: 0x7B8170 Offset: 0x7B6770 VA: 0x1807B8170 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x7B7F30 Offset: 0x7B6530 VA: 0x1807B7F30 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x67E0A0 Offset: 0x67C6A0 VA: 0x18067E0A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x7B7BE0 Offset: 0x7B61E0 VA: 0x1807B7BE0 Slot: 198
	public virtual bool LookingAtEngine(BasePlayer player) { }

	// RVA: 0x6A18E0 Offset: 0x69FEE0 VA: 0x1806A18E0 Slot: 199
	public virtual bool LookingAtFuelArea(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	[BaseEntity.Menu.Description] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	[BaseEntity.Menu.Icon] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	// RVA: 0x7B7E10 Offset: 0x7B6410 VA: 0x1807B7E10
	public void Menu_StartEngine(BasePlayer player) { }

	// RVA: 0x7B7D70 Offset: 0x7B6370 VA: 0x1807B7D70
	public bool Menu_StartEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	[BaseEntity.Menu.Description] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	[BaseEntity.Menu.Icon] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	// RVA: 0x7B7EE0 Offset: 0x7B64E0 VA: 0x1807B7EE0
	public void Menu_StopEngine(BasePlayer player) { }

	// RVA: 0x7B7E60 Offset: 0x7B6460 VA: 0x1807B7E60
	public bool Menu_StopEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	[BaseEntity.Menu.Description] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	[BaseEntity.Menu.Icon] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	// RVA: 0x7B7D30 Offset: 0x7B6330 VA: 0x1807B7D30
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x7B7CC0 Offset: 0x7B62C0 VA: 0x1807B7CC0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x7B8090 Offset: 0x7B6690 VA: 0x1807B8090 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x7B6EA0 Offset: 0x7B54A0 VA: 0x1807B6EA0 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x7B81E0 Offset: 0x7B67E0 VA: 0x1807B81E0
	private bool ShowPushMenu(BasePlayer player) { }

	// RVA: 0x7B7B30 Offset: 0x7B6130 VA: 0x1807B7B30 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7B9700 Offset: 0x7B7D00 VA: 0x1807B9700 Slot: 191
	protected override void WorkshopMode() { }

	// RVA: 0x7B97C0 Offset: 0x7B7DC0 VA: 0x1807B97C0
	public void .ctor() { }

	// RVA: 0x7B9760 Offset: 0x7B7D60 VA: 0x1807B9760
	private static void .cctor() { }

}

public class VehicleModuleCamper : VehicleModuleSeating // TypeDefIndex: 8477
{	// Fields
	private Option __menuOption_Menu_AssignToFriend; // 0x608
	private Option __menuOption_Menu_ClearBedOwner; // 0x660
	private Option __menuOption_Menu_MakeBed; // 0x6B8
	private Option __menuOption_Menu_OpenLocker; // 0x710
	private Option __menuOption_Menu_OpenStorage; // 0x768
	private Option __menuOption_Menu_Rename; // 0x7C0
	public GameObjectRef SleepingBagEntity; // 0x818
	public Transform[] SleepingBagPoints; // 0x820
	public GameObjectRef LockerEntity; // 0x828
	public Transform LockerPoint; // 0x830
	public GameObjectRef BbqEntity; // 0x838
	public Transform BbqPoint; // 0x840
	public GameObjectRef StorageEntity; // 0x848
	public Transform StoragePoint; // 0x850
	private EntityRef<BaseOven> activeBbq; // 0x858
	private EntityRef<Locker> activeLocker; // 0x868
	private EntityRef<StorageContainer> activeStorage; // 0x878

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAD1580 Offset: 0xACFB80 VA: 0x180AD1580 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD31C0 Offset: 0xAD17C0 VA: 0x180AD31C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD3070 Offset: 0xAD1670 VA: 0x180AD3070 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD1470 Offset: 0xACFA70 VA: 0x180AD1470 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0xAD2720 Offset: 0xAD0D20 VA: 0x180AD2720 Slot: 205
	public override bool IsOnThisModule(BasePlayer player) { }

	// RVA: 0xAD28E0 Offset: 0xAD0EE0 VA: 0x180AD28E0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.Icon] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.Description] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	// RVA: 0xAD2D10 Offset: 0xAD1310 VA: 0x180AD2D10
	public void Menu_MakeBed(BasePlayer player) { }

	// RVA: 0xAD2C50 Offset: 0xAD1250 VA: 0x180AD2C50 Slot: 206
	public virtual bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	[BaseEntity.Menu.Icon] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	[BaseEntity.Menu.Description] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	[BaseEntity.Menu.ShowIf] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	// RVA: 0xAD2BC0 Offset: 0xAD11C0 VA: 0x180AD2BC0
	public void Menu_ClearBedOwner(BasePlayer player) { }

	// RVA: 0xAD2B00 Offset: 0xAD1100 VA: 0x180AD2B00 Slot: 207
	public virtual bool Menu_ClearBedOwner_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.Icon] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.Description] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.ShowIf] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	// RVA: 0xAD2A70 Offset: 0xAD1070 VA: 0x180AD2A70
	public void Menu_AssignToFriend(BasePlayer player) { }

	// RVA: 0xAD29B0 Offset: 0xAD0FB0 VA: 0x180AD29B0 Slot: 208
	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.Icon] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.Description] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.ShowIf] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	// RVA: 0xAD2FE0 Offset: 0xAD15E0 VA: 0x180AD2FE0
	public void Menu_Rename(BasePlayer player) { }

	// RVA: 0xAD14C0 Offset: 0xACFAC0 VA: 0x180AD14C0 Slot: 209
	protected virtual bool CanRename_Test(BasePlayer player) { }

	// RVA: 0xAD2340 Offset: 0xAD0940 VA: 0x180AD2340
	private SleepingBagCamper GetSleepingBagForPlayer(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	[BaseEntity.Menu.Description] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	[BaseEntity.Menu.Icon] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	[BaseEntity.Menu.ShowIf] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	// RVA: 0xAD2E70 Offset: 0xAD1470 VA: 0x180AD2E70
	public void Menu_OpenLocker(BasePlayer player) { }

	// RVA: 0xAD2DA0 Offset: 0xAD13A0 VA: 0x180AD2DA0
	public bool Menu_OpenLocker_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	[BaseEntity.Menu.Description] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	[BaseEntity.Menu.Icon] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	[BaseEntity.Menu.ShowIf] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	// RVA: 0xAD2FA0 Offset: 0xAD15A0 VA: 0x180AD2FA0
	public void Menu_OpenStorage(BasePlayer player) { }

	// RVA: 0xAD2EB0 Offset: 0xAD14B0 VA: 0x180AD2EB0
	public bool Menu_OpenStorage_ShowIf(BasePlayer player) { }

	// RVA: 0xAD3160 Offset: 0xAD1760 VA: 0x180AD3160
	public void .ctor() { }

}

public class VehicleModuleSeating : BaseVehicleModule, IPrefabPreProcess // TypeDefIndex: 8478
{	// Fields
	private Option __menuOption_Menu_DestroyLock; // 0x520
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ProtectionProperties passengerProtection; // 0x578
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleModuleSeating.Seating seating; // 0x580
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private Vector3 steerAngle; // 0x588
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private Vector3 accelAngle; // 0x594
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private Vector3 brakeAngle; // 0x5A0
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private Vector3 speedometerAngle; // 0x5AC
	[SerializeField] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[HideInInspector] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	private Vector3 fuelAngle; // 0x5B8
	[HeaderAttribute] // RVA: 0x96880 Offset: 0x95C80 VA: 0x180096880
	[SerializeField] // RVA: 0x96880 Offset: 0x95C80 VA: 0x180096880
	private SoundDefinition hornLoop; // 0x5C8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition hornStart; // 0x5D0
	private Sound activeHorn; // 0x5D8
	private const BaseEntity.Flags FLAG_HORN = 65536;
	private float steerPercent; // 0x5E0
	private float throttlePercent; // 0x5E4
	private float brakePercent; // 0x5E8
	private Nullable<bool> checkEngineLightOn; // 0x5EC
	private Nullable<bool> fuelLightOn; // 0x5EE
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ModularCar <Car>k__BackingField; // 0x5F0
	protected IVehicleLockUser VehicleLockUser; // 0x5F8
	private MaterialPropertyBlock dashboardLightPB; // 0x600
	private static int emissionColorID; // 0x0

	// Properties
	public override bool HasMenuOptions { get; }
	public override bool HasSeating { get; }
	protected ModularCar Car { get; set; }
	protected bool IsOnACar { get; }
	protected bool IsOnAVehicleLockUser { get; }
	public bool DoorsAreLockable { get; }

	// Methods

	// RVA: 0xAD4E00 Offset: 0xAD3400 VA: 0x180AD4E00 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD6FD0 Offset: 0xAD55D0 VA: 0x180AD6FD0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD5D90 Offset: 0xAD4390 VA: 0x180AD5D90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD7090 Offset: 0xAD5690 VA: 0x180AD7090 Slot: 198
	public override bool get_HasSeating() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD6FA0 Offset: 0xAD55A0 VA: 0x180AD6FA0
	protected ModularCar get_Car() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD7150 Offset: 0xAD5750 VA: 0x180AD7150
	private void set_Car(ModularCar value) { }

	// RVA: 0xAD70E0 Offset: 0xAD56E0 VA: 0x180AD70E0
	protected bool get_IsOnACar() { }

	// RVA: 0xAD7140 Offset: 0xAD5740 VA: 0x180AD7140
	protected bool get_IsOnAVehicleLockUser() { }

	// RVA: 0xAD6FB0 Offset: 0xAD55B0 VA: 0x180AD6FB0
	public bool get_DoorsAreLockable() { }

	// RVA: 0xAD6090 Offset: 0xAD4690 VA: 0x180AD6090 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xAD46E0 Offset: 0xAD2CE0 VA: 0x180AD46E0 Slot: 194
	public override void ClientVehicleTick() { }

	// RVA: 0xAD5960 Offset: 0xAD3F60 VA: 0x180AD5960 Slot: 195
	public override void OnClientTickStopped() { }

	// RVA: 0xAD6700 Offset: 0xAD4D00 VA: 0x180AD6700 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xAD63B0 Offset: 0xAD49B0 VA: 0x180AD63B0
	private void SetCheckEngineLightState(bool isOn) { }

	// RVA: 0xAD6470 Offset: 0xAD4A70 VA: 0x180AD6470
	private void SetFuelLightState(bool isOn) { }

	// RVA: 0xAD6540 Offset: 0xAD4B40 VA: 0x180AD6540
	private void SetLightState(bool isOn, int lightMatIndex, Color lightEmission) { }

	// RVA: 0xAD5A30 Offset: 0xAD4030 VA: 0x180AD5A30 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xAD6E80 Offset: 0xAD5480 VA: 0x180AD6E80
	public bool ValidMountRay(BasePlayer player) { }

	// RVA: 0xAD56F0 Offset: 0xAD3CF0 VA: 0x180AD56F0 Slot: 197
	public override bool Menu_Locked_ShowIf(BasePlayer player) { }

	// RVA: 0xAD5390 Offset: 0xAD3990 VA: 0x180AD5390
	private bool LookingAtAMountHotSpot(BasePlayer localPlayer) { }

	[BaseEntity.Menu] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	[BaseEntity.Menu.Description] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	[BaseEntity.Menu.Icon] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	[BaseEntity.Menu.ShowIf] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	// RVA: 0xAD56B0 Offset: 0xAD3CB0 VA: 0x180AD56B0
	public void Menu_DestroyLock(BasePlayer player) { }

	// RVA: 0xAD56A0 Offset: 0xAD3CA0 VA: 0x180AD56A0
	public bool Menu_DestroyLock_ShowIf(BasePlayer player) { }

	// RVA: 0xAD5270 Offset: 0xAD3870 VA: 0x180AD5270 Slot: 205
	public virtual bool IsOnThisModule(BasePlayer player) { }

	// RVA: 0xAD5110 Offset: 0xAD3710 VA: 0x180AD5110
	public bool HasADriverSeat() { }

	// RVA: 0xAD5850 Offset: 0xAD3E50 VA: 0x180AD5850 Slot: 200
	public override void ModuleAdded(BaseModularVehicle vehicle, int firstSocketIndex) { }

	// RVA: 0xAD5920 Offset: 0xAD3F20 VA: 0x180AD5920 Slot: 201
	public override void ModuleRemoved() { }

	// RVA: 0xAD5E80 Offset: 0xAD4480 VA: 0x180AD5E80
	public bool PlayerCanDestroyLock(BasePlayer player) { }

	// RVA: 0xAD6F90 Offset: 0xAD5590 VA: 0x180AD6F90
	public void .ctor() { }

	// RVA: 0xAD6F40 Offset: 0xAD5540 VA: 0x180AD6F40
	private static void .cctor() { }

}

public class VehicleModuleSeating.MountHotSpot // TypeDefIndex: 8479
{	// Fields
	public Transform transform; // 0x10
	public Vector2 size; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class VehicleModuleSeating.Seating // TypeDefIndex: 8480
{	// Fields
	[HeaderAttribute] // RVA: 0x98D60 Offset: 0x98160 VA: 0x180098D60
	public bool doorsAreLockable; // 0x10
	[ObsoleteAttribute] // RVA: 0x98E30 Offset: 0x98230 VA: 0x180098E30
	[HideInInspector] // RVA: 0x98E30 Offset: 0x98230 VA: 0x180098E30
	public BaseVehicle.MountPointInfo[] mountPoints; // 0x18
	public Transform steeringWheel; // 0x20
	public Transform accelPedal; // 0x28
	public Transform brakePedal; // 0x30
	public Transform steeringWheelLeftGrip; // 0x38
	public Transform steeringWheelRightGrip; // 0x40
	public Transform accelPedalGrip; // 0x48
	public Transform brakePedalGrip; // 0x50
	public VehicleModuleSeating.MountHotSpot[] mountHotSpots; // 0x58
	[HeaderAttribute] // RVA: 0x990A0 Offset: 0x984A0 VA: 0x1800990A0
	public Transform speedometer; // 0x60
	public Transform fuelGauge; // 0x68
	public Renderer dashboardRenderer; // 0x70
	[RangeAttribute] // RVA: 0x84500 Offset: 0x83900 VA: 0x180084500
	public int checkEngineLightMatIndex; // 0x78
	[ColorUsageAttribute] // RVA: 0x85B30 Offset: 0x84F30 VA: 0x180085B30
	public Color checkEngineLightEmission; // 0x7C
	[RangeAttribute] // RVA: 0x84500 Offset: 0x83900 VA: 0x180084500
	public int fuelLightMatIndex; // 0x8C
	[ColorUsageAttribute] // RVA: 0x85B30 Offset: 0x84F30 VA: 0x180085B30
	public Color fuelLightEmission; // 0x90

	// Methods

	// RVA: 0xAC9BF0 Offset: 0xAC81F0 VA: 0x180AC9BF0
	public void .ctor() { }

}

public class VehicleModuleStorage : VehicleModuleSeating // TypeDefIndex: 8481
{	// Fields
	private Option __menuOption_Menu_Open; // 0x608
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleModuleStorage.Storage storage; // 0x660
	private EntityRef storageUnitInstance; // 0x668

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAD7260 Offset: 0xAD5860 VA: 0x180AD7260 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD77D0 Offset: 0xAD5DD0 VA: 0x180AD77D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD76E0 Offset: 0xAD5CE0 VA: 0x180AD76E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD71C0 Offset: 0xAD57C0 VA: 0x180AD71C0
	public IItemContainerEntity GetContainer() { }

	// RVA: 0xAD7570 Offset: 0xAD5B70 VA: 0x180AD7570 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD7160 Offset: 0xAD5760 VA: 0x180AD7160 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Description] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Icon] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	// RVA: 0xAD76A0 Offset: 0xAD5CA0 VA: 0x180AD76A0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0xAD75D0 Offset: 0xAD5BD0 VA: 0x180AD75D0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0xAD42E0 Offset: 0xAD28E0 VA: 0x180AD42E0
	public void .ctor() { }

}

public class VehicleModuleStorage.Storage // TypeDefIndex: 8482
{	// Fields
	public GameObjectRef storageUnitPrefab; // 0x10
	public Transform storageUnitPoint; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class VehicleModuleTaxi : VehicleModuleStorage // TypeDefIndex: 8483
{	// Fields
	private Option __menuOption_Menu_Kick_Passengers; // 0x678
	[HeaderAttribute] // RVA: 0x99EB0 Offset: 0x992B0 VA: 0x180099EB0
	[SerializeField] // RVA: 0x99EB0 Offset: 0x992B0 VA: 0x180099EB0
	private SoundDefinition kickButtonSound; // 0x6D0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SphereCollider kickButtonCollider; // 0x6D8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxKickVelocity; // 0x6E0

	// Properties
	public override bool HasMenuOptions { get; }
	private Vector3 KickButtonPos { get; }

	// Methods

	// RVA: 0xAD7C00 Offset: 0xAD6200 VA: 0x180AD7C00 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD81B0 Offset: 0xAD67B0 VA: 0x180AD81B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD8060 Offset: 0xAD6660 VA: 0x180AD8060 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD8320 Offset: 0xAD6920 VA: 0x180AD8320
	private Vector3 get_KickButtonPos() { }

	// RVA: 0xAD7890 Offset: 0xAD5E90 VA: 0x180AD7890
	private bool CanKickPassengers(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	[BaseEntity.Menu.Description] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	[BaseEntity.Menu.Icon] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	// RVA: 0xAD7FD0 Offset: 0xAD65D0 VA: 0x180AD7FD0
	public void Menu_Kick_Passengers(BasePlayer player) { }

	// RVA: 0xAD7F10 Offset: 0xAD6510 VA: 0x180AD7F10
	public bool Menu_Kick_Passengers_ShowIf(BasePlayer player) { }

	// RVA: 0xAD8150 Offset: 0xAD6750 VA: 0x180AD8150
	public void .ctor() { }

}

public class ModularCarOven : BaseOven // TypeDefIndex: 8608
{	// Fields
	private BaseVehicleModule moduleParent; // 0x4E8

	// Properties
	private BaseVehicleModule ModuleParent { get; }

	// Methods

	// RVA: 0x7774B0 Offset: 0x775AB0 VA: 0x1807774B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7777C0 Offset: 0x775DC0 VA: 0x1807777C0
	private BaseVehicleModule get_ModuleParent() { }

	// RVA: 0x7775A0 Offset: 0x775BA0 VA: 0x1807775A0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x7775D0 Offset: 0x775BD0 VA: 0x1807775D0 Slot: 156
	protected override bool SwitchOff_ShowIf(BasePlayer player) { }

	// RVA: 0x7776A0 Offset: 0x775CA0 VA: 0x1807776A0 Slot: 155
	protected override bool SwitchOn_ShowIf(BasePlayer player) { }

	// RVA: 0x7773E0 Offset: 0x7759E0 VA: 0x1807773E0 Slot: 154
	protected override bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x52ED00 Offset: 0x52D300 VA: 0x18052ED00
	public void .ctor() { }

}

public class VehicleVendor : NPCTalking // TypeDefIndex: 8851
{	// Fields
	public EntityRef spawnerRef; // 0x858
	public VehicleSpawner vehicleSpawner; // 0x868

	// Methods

	// RVA: 0xAD8710 Offset: 0xAD6D10 VA: 0x180AD8710 Slot: 158
	public override string GetConversationStartSpeech(BasePlayer player) { }

	// RVA: 0xAD8760 Offset: 0xAD6D60 VA: 0x180AD8760
	public VehicleSpawner GetVehicleSpawner() { }

	// RVA: 0xAD8800 Offset: 0xAD6E00 VA: 0x180AD8800 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7C47B0 Offset: 0x7C2DB0 VA: 0x1807C47B0 Slot: 159
	public override ConversationData GetConversationFor(BasePlayer player) { }

	// RVA: 0xAD8860 Offset: 0xAD6E60 VA: 0x180AD8860
	public void .ctor() { }

}

public class VehicleSpawner : BaseEntity // TypeDefIndex: 8852
{	// Fields
	public float spawnNudgeRadius; // 0x168
	public float cleanupRadius; // 0x16C
	public float occupyRadius; // 0x170
	public VehicleSpawner.SpawnPair[] objectsToSpawn; // 0x178
	public Transform spawnOffset; // 0x180
	public float safeRadius; // 0x188

	// Methods

	// RVA: 0xAD84E0 Offset: 0xAD6AE0 VA: 0x180AD84E0 Slot: 131
	public virtual int GetOccupyLayer() { }

	// RVA: 0xAD84F0 Offset: 0xAD6AF0 VA: 0x180AD84F0
	public BaseVehicle GetVehicleOccupying() { }

	// RVA: 0xAD8690 Offset: 0xAD6C90 VA: 0x180AD8690
	public void .ctor() { }

}

public class VehicleSpawner.SpawnPair // TypeDefIndex: 8853
{	// Fields
	public string message; // 0x10
	public GameObjectRef prefabToSpawn; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class EngineAudioClip : MonoBehaviour, IClientComponent // TypeDefIndex: 8987
{	// Fields
	public AudioClip granularClip; // 0x18
	public AudioClip accelerationClip; // 0x20
	public TextAsset accelerationCyclesJson; // 0x28
	public List<EngineAudioClip.EngineCycle> accelerationCycles; // 0x30
	public List<EngineAudioClip.EngineCycleBucket> cycleBuckets; // 0x38
	public Dictionary<int, EngineAudioClip.EngineCycleBucket> accelerationCyclesByRPM; // 0x40
	public Dictionary<int, int> rpmBucketLookup; // 0x48
	public int sampleRate; // 0x50
	public int samplesUntilNextGrain; // 0x54
	public int lastCycleId; // 0x58
	public List<EngineAudioClip.Grain> grains; // 0x60
	public int currentRPM; // 0x68
	public int targetRPM; // 0x6C
	public int minRPM; // 0x70
	public int maxRPM; // 0x74
	public int cyclePadding; // 0x78
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float RPMControl; // 0x7C
	public AudioSource source; // 0x80
	public float rpmLerpSpeed; // 0x88
	public float rpmLerpSpeedDown; // 0x8C
	private Random random; // 0x90
	private float[] accelerationAudioData; // 0x98
	private EngineAudioClip.EngineCycle currentCycle; // 0xA0
	private bool audioDataLoaded; // 0xA8

	// Methods

	// RVA: 0x8C1CA0 Offset: 0x8C02A0 VA: 0x1808C1CA0
	private int GetBucketRPM(int RPM) { }

	// RVA: 0x8C1B10 Offset: 0x8C0110 VA: 0x1808C1B10
	private void Awake() { }

	// RVA: 0x8C2740 Offset: 0x8C0D40 VA: 0x1808C2740
	private void Update() { }

	// RVA: 0x8C2620 Offset: 0x8C0C20 VA: 0x1808C2620
	private void UpdateRPM() { }

	// RVA: 0x8C1D10 Offset: 0x8C0310 VA: 0x1808C1D10
	private void InitAudioClip() { }

	// RVA: 0x8C1E40 Offset: 0x8C0440 VA: 0x1808C1E40
	private void OnAudioRead(float[] data) { }

	// RVA: 0x8C22B0 Offset: 0x8C08B0 VA: 0x1808C22B0
	private void SpawnGrain() { }

	// RVA: 0x8C1B90 Offset: 0x8C0190 VA: 0x1808C1B90
	private void CleanupFinishedGrains() { }

	// RVA: 0x8C2000 Offset: 0x8C0600 VA: 0x1808C2000
	private void SetupRPMBuckets() { }

	// RVA: 0x8C2B10 Offset: 0x8C1110 VA: 0x1808C2B10
	public void .ctor() { }

}

public class EngineAudioClip.EngineCycle // TypeDefIndex: 8988
{	// Fields
	public int RPM; // 0x10
	public int startSample; // 0x14
	public int endSample; // 0x18
	public float period; // 0x1C
	public int id; // 0x20

	// Methods

	// RVA: 0x8C3020 Offset: 0x8C1620 VA: 0x1808C3020
	public void .ctor(int RPM, int startSample, int endSample, float period, int id) { }

}

public class EngineAudioClip.EngineCycleBucket // TypeDefIndex: 8989
{	// Fields
	public int RPM; // 0x10
	public List<EngineAudioClip.EngineCycle> cycles; // 0x18
	public List<int> remainingCycles; // 0x20

	// Methods

	// RVA: 0x8C2F70 Offset: 0x8C1570 VA: 0x1808C2F70
	public void .ctor(int RPM) { }

	// RVA: 0x8C2DA0 Offset: 0x8C13A0 VA: 0x1808C2DA0
	public EngineAudioClip.EngineCycle GetCycle(Random random, int lastCycleId) { }

	// RVA: 0x8C2EB0 Offset: 0x8C14B0 VA: 0x1808C2EB0
	private void ResetRemainingCycles(Random random) { }

	// RVA: 0x8C2D30 Offset: 0x8C1330 VA: 0x1808C2D30
	public void Add(EngineAudioClip.EngineCycle cycle) { }

}

public class EngineAudioClip.Grain // TypeDefIndex: 8990
{	// Fields
	private float[] sourceData; // 0x10
	private int startSample; // 0x18
	private int currentSample; // 0x1C
	private int attackTimeSamples; // 0x20
	private int sustainTimeSamples; // 0x24
	private int releaseTimeSamples; // 0x28
	private float gain; // 0x2C
	private float gainPerSampleAttack; // 0x30
	private float gainPerSampleRelease; // 0x34
	private int attackEndSample; // 0x38
	private int releaseStartSample; // 0x3C
	private int endSample; // 0x40

	// Properties
	public bool finished { get; }

	// Methods

	// RVA: 0x5A4ED0 Offset: 0x5A34D0 VA: 0x1805A4ED0
	public bool get_finished() { }

	// RVA: 0x8D6850 Offset: 0x8D4E50 VA: 0x1808D6850
	public void Init(float[] source, EngineAudioClip.EngineCycle cycle, int cyclePadding) { }

	// RVA: 0x8D6790 Offset: 0x8D4D90 VA: 0x1808D6790
	public float GetSample() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class BaseVehicleMountPoint : BaseMountable // TypeDefIndex: 9697
{	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 147
	public override bool DirectlyMountable() { }

	// RVA: 0x9355D0 Offset: 0x933BD0 VA: 0x1809355D0 Slot: 170
	public override BaseVehicle VehicleParent() { }

	// RVA: 0x935520 Offset: 0x933B20 VA: 0x180935520 Slot: 109
	public override bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x935740 Offset: 0x933D40 VA: 0x180935740 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x935480 Offset: 0x933A80 VA: 0x180935480 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x9357F0 Offset: 0x933DF0 VA: 0x1809357F0
	public void .ctor() { }

}

public class BaseVehicleSeat : BaseVehicleMountPoint // TypeDefIndex: 9698
{	// Fields
	public float mountedAnimationSpeed; // 0x320
	public bool sendClientInputToVehicleParent; // 0x324
	public bool forcePlayerModelUpdate; // 0x325

	// Methods

	// RVA: 0x935870 Offset: 0x933E70 VA: 0x180935870 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x935930 Offset: 0x933F30 VA: 0x180935930 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x935860 Offset: 0x933E60 VA: 0x180935860 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0x935850 Offset: 0x933E50 VA: 0x180935850 Slot: 159
	public override bool ForceUpdatePlayerModel(BasePlayer p) { }

	// RVA: 0x9357F0 Offset: 0x933DF0 VA: 0x1809357F0
	public void .ctor() { }

}

public class EngineAudioSet : ScriptableObject // TypeDefIndex: 9735
{	// Fields
	public BlendedEngineLoopDefinition[] engineAudioLoops; // 0x18
	public int priority; // 0x20
	public float idleVolume; // 0x24
	public float maxVolume; // 0x28
	public float volumeChangeRateUp; // 0x2C
	public float volumeChangeRateDown; // 0x30
	public float idlePitch; // 0x34
	public float maxPitch; // 0x38
	public float idleRpm; // 0x3C
	public float gearUpRpm; // 0x40
	public float gearDownRpm; // 0x44
	public int numGears; // 0x48
	public float maxRpm; // 0x4C
	public float gearUpRpmRate; // 0x50
	public float gearDownRpmRate; // 0x54
	public SoundDefinition badPerformanceLoop; // 0x58

	// Methods

	// RVA: 0x8C2C80 Offset: 0x8C1280 VA: 0x1808C2C80
	public BlendedEngineLoopDefinition GetEngineLoopDef(int numEngines) { }

	// RVA: 0x8C2CC0 Offset: 0x8C12C0 VA: 0x1808C2CC0
	public void .ctor() { }

}

public class ModularCarCentralLockingSwitch : VehicleModuleButtonComponent // TypeDefIndex: 9738
{	// Fields
	public Transform centralLockingSwitch; // 0x28
	public Vector3 switchOffPos; // 0x30
	public Vector3 switchOnPos; // 0x3C

	// Methods

	// RVA: 0x774990 Offset: 0x772F90 VA: 0x180774990 Slot: 4
	public override void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	// RVA: 0x774810 Offset: 0x772E10 VA: 0x180774810 Slot: 5
	public override void ClientUpdateTick(BaseVehicleModule parentModule) { }

	// RVA: 0x774AA0 Offset: 0x7730A0 VA: 0x180774AA0
	public void .ctor() { }

}

public class ModularCarChassisVisuals : VehicleChassisVisuals<ModularCar>, IClientComponent // TypeDefIndex: 9739
{	// Fields
	public Transform frontAxle; // 0x30
	public Transform rearAxle; // 0x38
	public ModularCarChassisVisuals.Steering steering; // 0x40
	public ModularCarChassisVisuals.LookAtTarget transmission; // 0x48
	private ModularCar modularCar; // 0x50

	// Methods

	// RVA: 0x774AB0 Offset: 0x7730B0 VA: 0x180774AB0 Slot: 4
	public override void Init(ModularCar owner, VehicleChassisVisuals.ClientWheelData<ModularCar>[] clientWheelData) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected override void PreWheelUpdateTick() { }

	// RVA: 0x774D10 Offset: 0x773310 VA: 0x180774D10 Slot: 7
	protected override void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt) { }

	// RVA: 0x775230 Offset: 0x773830 VA: 0x180775230 Slot: 6
	protected override void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, bool isOn, float steer, float dt) { }

	// RVA: 0x774EA0 Offset: 0x7734A0 VA: 0x180774EA0
	private void UpdateAxle(Transform axle, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataL, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataR, float dt, bool instant) { }

	// RVA: 0x774B20 Offset: 0x773120 VA: 0x180774B20
	private void LookAt(ModularCarChassisVisuals.LookAtTarget lookAt) { }

	// RVA: 0x7754D0 Offset: 0x773AD0 VA: 0x1807754D0
	public void .ctor() { }

}

public class ModularCarChassisVisuals.Steering // TypeDefIndex: 9740
{	// Fields
	public Transform steerL; // 0x10
	public Transform steerR; // 0x18
	public ModularCarChassisVisuals.LookAtTarget steerRodL; // 0x20
	public ModularCarChassisVisuals.LookAtTarget steerRodR; // 0x28
	public ModularCarChassisVisuals.LookAtTarget steeringArm; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class ModularCarChassisVisuals.LookAtTarget // TypeDefIndex: 9741
{	// Fields
	public Transform aim; // 0x10
	public Transform target; // 0x18
	public Vector3 angleAdjust; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class VehicleLiftOccupantTrigger : TriggerBase // TypeDefIndex: 9742
{	// Methods

	// RVA: 0x4D38B0 Offset: 0x4D1EB0 VA: 0x1804D38B0
	public void .ctor() { }

}

public class ModularCarLock // TypeDefIndex: 9744
{	// Fields
	private readonly bool isServer; // 0x10
	private readonly ModularCar owner; // 0x18
	public int LockID; // 0x20
	public const BaseEntity.Flags FLAG_CENTRAL_LOCKING = 256;
	public const float LOCK_DESTROY_HEALTH = 0,15;

	// Properties
	public bool HasALock { get; }
	public bool IsLocked { get; }
	public bool CentralLockingIsOn { get; }

	// Methods

	// RVA: 0x777340 Offset: 0x775940 VA: 0x180777340
	public bool get_HasALock() { }

	// RVA: 0x777350 Offset: 0x775950 VA: 0x180777350
	public bool get_IsLocked() { }

	// RVA: 0x7772B0 Offset: 0x7758B0 VA: 0x1807772B0
	public bool get_CentralLockingIsOn() { }

	// RVA: 0x777260 Offset: 0x775860 VA: 0x180777260
	public void .ctor(ModularCar owner, bool isServer) { }

	// RVA: 0x777160 Offset: 0x775760 VA: 0x180777160
	public bool PlayerHasUnlockPermission(BasePlayer player) { }

	// RVA: 0x777110 Offset: 0x775710 VA: 0x180777110
	public bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0x7770D0 Offset: 0x7756D0 VA: 0x1807770D0
	public bool PlayerCanDestroyLock(BaseVehicleModule viaModule) { }

	// RVA: 0x777090 Offset: 0x775690 VA: 0x180777090
	private bool KeyCanUnlockThis(Item key) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x777090 Offset: 0x775690 VA: 0x180777090
	private bool <PlayerHasUnlockPermission>b__13_0(Item key) { }

}

public enum ModularCarLock.LockType // TypeDefIndex: 9745
{	// Fields
	public int value__; // 0x0
	public const ModularCarLock.LockType Door = 0;
	public const ModularCarLock.LockType General = 1;

}

public class ModularCarPresetConfig : ScriptableObject // TypeDefIndex: 9746
{	// Fields
	public ItemModVehicleModule[] socketItemDefs; // 0x18

	// Methods

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class ModularCarSeat : MouseSteerableSeat // TypeDefIndex: 9747
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 leftFootIKPos; // 0x330
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 rightFootIKPos; // 0x33C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 leftHandIKPos; // 0x348
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 rightHandIKPos; // 0x354
	public float providesComfort; // 0x360

	// Properties
	public bool HasLeftFootIK { get; }
	public bool HasRightFootIK { get; }
	public Vector3 LeftFootIKPos { get; }
	public Vector3 RightFootIKPos { get; }
	public bool HasLeftHandIK { get; }
	public bool HasRightHandIK { get; }
	public Vector3 LeftHandIKPos { get; }
	public Vector3 RightHandIKPos { get; }

	// Methods

	// RVA: 0x7778B0 Offset: 0x775EB0 VA: 0x1807778B0
	public bool get_HasLeftFootIK() { }

	// RVA: 0x7778F0 Offset: 0x775EF0 VA: 0x1807778F0
	public bool get_HasRightFootIK() { }

	// RVA: 0x777930 Offset: 0x775F30 VA: 0x180777930
	public Vector3 get_LeftFootIKPos() { }

	// RVA: 0x777A10 Offset: 0x776010 VA: 0x180777A10
	public Vector3 get_RightFootIKPos() { }

	// RVA: 0x7778D0 Offset: 0x775ED0 VA: 0x1807778D0
	public bool get_HasLeftHandIK() { }

	// RVA: 0x777910 Offset: 0x775F10 VA: 0x180777910
	public bool get_HasRightHandIK() { }

	// RVA: 0x7779A0 Offset: 0x775FA0 VA: 0x1807779A0
	public Vector3 get_LeftHandIKPos() { }

	// RVA: 0x777A80 Offset: 0x776080 VA: 0x180777A80
	public Vector3 get_RightHandIKPos() { }

	// RVA: 0x7778A0 Offset: 0x775EA0 VA: 0x1807778A0
	public void .ctor() { }

}

public class ModularVehicleShopFront : ShopFront // TypeDefIndex: 9748
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxUseDistance; // 0x3F0

	// Methods

	// RVA: 0x77ADA0 Offset: 0x7793A0 VA: 0x18077ADA0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x77AE30 Offset: 0x779430 VA: 0x18077AE30 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x77AF40 Offset: 0x779540 VA: 0x18077AF40
	private bool WithinUseDistance(BasePlayer player) { }

	// RVA: 0x77AFB0 Offset: 0x7795B0 VA: 0x18077AFB0
	public void .ctor() { }

}

public class CamperSeatConfig : MonoBehaviour // TypeDefIndex: 9749
{	// Fields
	public Transform[] SeatPositions; // 0x18
	public Transform StovePosition; // 0x20
	public Transform StoragePosition; // 0x28

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public abstract class VehicleModuleButtonComponent : MonoBehaviour // TypeDefIndex: 9750
{	// Fields
	public string interactionColliderName; // 0x18
	public SoundDefinition pressSoundDef; // 0x20

	// Methods

	// RVA: 0xAD1360 Offset: 0xACF960 VA: 0x180AD1360 Slot: 4
	public virtual void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void ClientUpdateTick(BaseVehicleModule parentModule) { }

	// RVA: 0xAD1420 Offset: 0xACFA20 VA: 0x180AD1420
	protected void .ctor() { }

}

public class VehicleModuleEngine : VehicleModuleStorage // TypeDefIndex: 9751
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleModuleEngine.Engine engine; // 0x678
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsUsable>k__BackingField; // 0x680
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <PerformanceFractionAcceleration>k__BackingField; // 0x684
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <PerformanceFractionTopSpeed>k__BackingField; // 0x688
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <PerformanceFractionFuelEconomy>k__BackingField; // 0x68C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <OverallPerformanceFraction>k__BackingField; // 0x690
	private const float FORCE_MULTIPLIER = 12,75;
	private const float HEALTH_PERFORMANCE_FRACTION = 0,25;
	private const float LOW_PERFORMANCE_THRESHOLD = 0,5;
	private Sound badPerformanceLoop; // 0x698
	private SoundModulation.Modulator badPerformancePitchModulator; // 0x6A0
	private float prevSmokePercent; // 0x6A8

	// Properties
	public override bool HasAnEngine { get; }
	public bool IsUsable { get; set; }
	public float PerformanceFractionAcceleration { get; set; }
	public float PerformanceFractionTopSpeed { get; set; }
	public float PerformanceFractionFuelEconomy { get; set; }
	public float OverallPerformanceFraction { get; set; }
	public bool AtLowPerformance { get; }
	public bool AtPeakPerformance { get; }
	public int KW { get; }
	public EngineAudioSet AudioSet { get; }
	private bool EngineIsOn { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 199
	public override bool get_HasAnEngine() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4490 Offset: 0xAD2A90 VA: 0x180AD4490
	public bool get_IsUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4500 Offset: 0xAD2B00 VA: 0x180AD4500
	private void set_IsUsable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD44D0 Offset: 0xAD2AD0 VA: 0x180AD44D0
	public float get_PerformanceFractionAcceleration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4520 Offset: 0xAD2B20 VA: 0x180AD4520
	private void set_PerformanceFractionAcceleration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD44F0 Offset: 0xAD2AF0 VA: 0x180AD44F0
	public float get_PerformanceFractionTopSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4540 Offset: 0xAD2B40 VA: 0x180AD4540
	private void set_PerformanceFractionTopSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD44E0 Offset: 0xAD2AE0 VA: 0x180AD44E0
	public float get_PerformanceFractionFuelEconomy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4530 Offset: 0xAD2B30 VA: 0x180AD4530
	private void set_PerformanceFractionFuelEconomy(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD44C0 Offset: 0xAD2AC0 VA: 0x180AD44C0
	public float get_OverallPerformanceFraction() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4510 Offset: 0xAD2B10 VA: 0x180AD4510
	private void set_OverallPerformanceFraction(float value) { }

	// RVA: 0xAD4340 Offset: 0xAD2940 VA: 0x180AD4340
	public bool get_AtLowPerformance() { }

	// RVA: 0xAD4360 Offset: 0xAD2960 VA: 0x180AD4360
	public bool get_AtPeakPerformance() { }

	// RVA: 0xAD44A0 Offset: 0xAD2AA0 VA: 0x180AD44A0
	public int get_KW() { }

	// RVA: 0xAD43D0 Offset: 0xAD29D0 VA: 0x180AD43D0
	public EngineAudioSet get_AudioSet() { }

	// RVA: 0xAD43F0 Offset: 0xAD29F0 VA: 0x180AD43F0
	private bool get_EngineIsOn() { }

	// RVA: 0xAD3CD0 Offset: 0xAD22D0 VA: 0x180AD3CD0 Slot: 28
	public override void InitShared() { }

	// RVA: 0xAD3E40 Offset: 0xAD2440 VA: 0x180AD3E40 Slot: 202
	public override void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState) { }

	// RVA: 0xAD3BA0 Offset: 0xAD21A0 VA: 0x180AD3BA0 Slot: 203
	public override float GetMaxDriveForce() { }

	// RVA: 0xAD4080 Offset: 0xAD2680 VA: 0x180AD4080
	public void RefreshPerformanceStats(EngineStorage engineStorage) { }

	// RVA: 0xAD3BF0 Offset: 0xAD21F0 VA: 0x180AD3BF0
	private float GetPerformanceFraction(float statBoostPercent) { }

	// RVA: 0xAD3D70 Offset: 0xAD2370 VA: 0x180AD3D70 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD3420 Offset: 0xAD1A20 VA: 0x180AD3420 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xAD34C0 Offset: 0xAD1AC0 VA: 0x180AD34C0 Slot: 194
	public override void ClientVehicleTick() { }

	// RVA: 0xAD3F20 Offset: 0xAD2520 VA: 0x180AD3F20
	private void PlayBadPerformanceSound() { }

	// RVA: 0xAD4220 Offset: 0xAD2820 VA: 0x180AD4220
	private void StopBadPerformanceSound() { }

	// RVA: 0xAD4190 Offset: 0xAD2790 VA: 0x180AD4190
	private void SetFXState(bool isOn) { }

	// RVA: 0xAD42E0 Offset: 0xAD28E0 VA: 0x180AD42E0
	public void .ctor() { }

}

public class VehicleModuleEngine.Engine // TypeDefIndex: 9752
{	// Fields
	[HeaderAttribute] // RVA: 0x8EE00 Offset: 0x8E200 VA: 0x18008EE00
	public int engineKW; // 0x10
	public float idleFuelPerSec; // 0x14
	public float maxFuelPerSec; // 0x18
	[HeaderAttribute] // RVA: 0x8EE70 Offset: 0x8E270 VA: 0x18008EE70
	public EngineAudioSet audioSet; // 0x20
	[HeaderAttribute] // RVA: 0x8EFA0 Offset: 0x8E3A0 VA: 0x18008EFA0
	public ParticleSystemContainer[] engineParticles; // 0x28
	public ParticleSystem[] exhaustSmoke; // 0x30
	public ParticleSystem[] exhaustBackfire; // 0x38
	public float exhaustSmokeMinOpacity; // 0x40
	public float exhaustSmokeMaxOpacity; // 0x44
	public float exhaustSmokeChangeRate; // 0x48

	// Methods

	// RVA: 0xAC7AA0 Offset: 0xAC60A0 VA: 0x180AC7AA0
	public void .ctor() { }

}

public class VehicleLight : MonoBehaviour, IClientComponent // TypeDefIndex: 9754
{	// Fields
	public bool IsBrake; // 0x18
	public GameObject toggleObject; // 0x20
	public VehicleLight.LightRenderer[] renderers; // 0x28
	[ColorUsageAttribute] // RVA: 0x85B30 Offset: 0x84F30 VA: 0x180085B30
	public Color lightOnColour; // 0x30
	[ColorUsageAttribute] // RVA: 0x85B30 Offset: 0x84F30 VA: 0x180085B30
	public Color brakesOnColour; // 0x40
	private static MaterialPropertyBlock materialPB; // 0x0
	private static int emissionColorID; // 0x8

	// Methods

	// RVA: 0xAD10A0 Offset: 0xACF6A0 VA: 0x180AD10A0
	public void SetLightVisuals(bool headlightsOn, bool brakesOn) { }

	// RVA: 0xAD0E30 Offset: 0xACF430 VA: 0x180AD0E30
	public static void SetLightVisuals(IReadOnlyList<VehicleLight> lights, bool headlightsOn, bool brakesOn) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xAD1310 Offset: 0xACF910 VA: 0x180AD1310
	private static void .cctor() { }

}

public class VehicleLight.LightRenderer // TypeDefIndex: 9755
{	// Fields
	public Renderer renderer; // 0x10
	public int matIndex; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class EngineDamageOverTime // TypeDefIndex: 9762
{	// Fields
	private readonly List<EngineDamageOverTime.RecentDamage> recentDamage; // 0x10
	private readonly float maxSeconds; // 0x18
	private readonly float triggerDamage; // 0x1C
	private readonly Action trigger; // 0x20

	// Methods

	// RVA: 0x8C3300 Offset: 0x8C1900 VA: 0x1808C3300
	public void .ctor(float triggerDamage, float maxSeconds, Action trigger) { }

	// RVA: 0x8C3190 Offset: 0x8C1790 VA: 0x1808C3190
	public void TakeDamage(float amount) { }

	// RVA: 0x8C3080 Offset: 0x8C1680 VA: 0x1808C3080
	private float GetRecentDamage() { }

}

private struct EngineDamageOverTime.RecentDamage // TypeDefIndex: 9763
{	// Fields
	public readonly float time; // 0x0
	public readonly float amount; // 0x4

	// Methods

	// RVA: 0xF2370 Offset: 0xF1770 VA: 0x1800F2370
	public void .ctor(float time, float amount) { }

}

public abstract class VehicleChassisVisuals<T> : MonoBehaviour // TypeDefIndex: 9781
{	// Fields
	protected T owner; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleChassisVisuals.ClientWheelData<T>[] <clientWheelData>k__BackingField; // 0x0
	private float prevSteer; // 0x0
	private bool isStopped; // 0x0

	// Properties
	public VehicleChassisVisuals.ClientWheelData<T>[] clientWheelData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public VehicleChassisVisuals.ClientWheelData<T>[] get_clientWheelData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-VehicleChassisVisuals<object>.get_clientWheelData
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	protected void set_clientWheelData(VehicleChassisVisuals.ClientWheelData<T>[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	|-VehicleChassisVisuals<object>.set_clientWheelData
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual void Init(T owner, VehicleChassisVisuals.ClientWheelData<T>[] clientWheelData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE210 Offset: 0x19CC810 VA: 0x1819CE210
	|-VehicleChassisVisuals<ModularCar>.Init
	|-VehicleChassisVisuals<Snowmobile>.Init
	|-VehicleChassisVisuals<object>.Init
	*/

	// RVA: -1 Offset: -1
	public void UpdateTick(float dt, bool instantForced = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CEC90 Offset: 0x19CD290 VA: 0x1819CEC90
	|-VehicleChassisVisuals<ModularCar>.UpdateTick
	|-VehicleChassisVisuals<Snowmobile>.UpdateTick
	|-VehicleChassisVisuals<object>.UpdateTick
	*/

	// RVA: -1 Offset: -1
	public bool IsGrounded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE280 Offset: 0x19CC880 VA: 0x1819CE280
	|-VehicleChassisVisuals<Snowmobile>.IsGrounded
	|-VehicleChassisVisuals<object>.IsGrounded
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void PreWheelUpdateTick();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals<object>.PreWheelUpdateTick
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOn, float steer, float dt);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals<object>.UpdateWheelVisuals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals<object>.PostWheelUpdateTick
	*/

	// RVA: -1 Offset: -1
	public float CalculateWheelSlip() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CDB50 Offset: 0x19CC150 VA: 0x1819CDB50
	|-VehicleChassisVisuals<ModularCar>.CalculateWheelSlip
	|-VehicleChassisVisuals<Snowmobile>.CalculateWheelSlip
	|-VehicleChassisVisuals<object>.CalculateWheelSlip
	*/

	// RVA: -1 Offset: -1
	protected void UpdateWheelSuspensionData(VehicleChassisVisuals.ClientWheelData<T> wheelData, Vector3 traceSource, Nullable<Vector3> traceSource2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF0A0 Offset: 0x19CD6A0 VA: 0x1819CF0A0
	|-VehicleChassisVisuals<ModularCar>.UpdateWheelSuspensionData
	|-VehicleChassisVisuals<Snowmobile>.UpdateWheelSuspensionData
	|-VehicleChassisVisuals<object>.UpdateWheelSuspensionData
	*/

	// RVA: -1 Offset: -1
	protected float GetWheelRotation(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool receivingDriveWheelVels, float dt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CDF90 Offset: 0x19CC590 VA: 0x1819CDF90
	|-VehicleChassisVisuals<ModularCar>.GetWheelRotation
	|-VehicleChassisVisuals<Snowmobile>.GetWheelRotation
	|-VehicleChassisVisuals<object>.GetWheelRotation
	*/

	// RVA: -1 Offset: -1
	protected static void UpdateSteerRotation(Transform t, float steer, int axis) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CEBA0 Offset: 0x19CD1A0 VA: 0x1819CEBA0
	|-VehicleChassisVisuals<ModularCar>.UpdateSteerRotation
	|-VehicleChassisVisuals<object>.UpdateSteerRotation
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, float throttleInput) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE350 Offset: 0x19CC950 VA: 0x1819CE350
	|-VehicleChassisVisuals<ModularCar>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, float throttleInput, float speed, float minSpeed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE7B0 Offset: 0x19CCDB0 VA: 0x1819CE7B0
	|-VehicleChassisVisuals<Snowmobile>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOnWater, float spinSlip, TerrainConfig.GroundType groundType, float throttleInput) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE440 Offset: 0x19CCA40 VA: 0x1819CE440
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOnWater, float spinSlip, TerrainConfig.GroundType groundType, float throttleInput, float speed, float minSpeed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE510 Offset: 0x19CCB10 VA: 0x1819CE510
	|-VehicleChassisVisuals<Snowmobile>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	public void UpdateTickStopped() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CEC40 Offset: 0x19CD240 VA: 0x1819CEC40
	|-VehicleChassisVisuals<ModularCar>.UpdateTickStopped
	|-VehicleChassisVisuals<Snowmobile>.UpdateTickStopped
	|-VehicleChassisVisuals<object>.UpdateTickStopped
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void StopAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE8D0 Offset: 0x19CCED0 VA: 0x1819CE8D0
	|-VehicleChassisVisuals<ModularCar>.StopAll
	|-VehicleChassisVisuals<Snowmobile>.StopAll
	|-VehicleChassisVisuals<object>.StopAll
	*/

	// RVA: -1 Offset: -1
	protected static void StopTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE980 Offset: 0x19CCF80 VA: 0x1819CE980
	|-VehicleChassisVisuals<object>.StopTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x847220 Offset: 0x845820 VA: 0x180847220
	|-VehicleChassisVisuals<ModularCar>..ctor
	|-VehicleChassisVisuals<Snowmobile>..ctor
	|-VehicleChassisVisuals<object>..ctor
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static bool <UpdateWheelSuspensionData>g__GetSuspensionHit|17_0(Vector3 ts, out RaycastHit hit, ref VehicleChassisVisuals.<>c__DisplayClass17_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CEA80 Offset: 0x19CD080 VA: 0x1819CEA80
	|-VehicleChassisVisuals<object>.<UpdateWheelSuspensionData>g__GetSuspensionHit|17_0
	*/

}

public class VehicleChassisVisuals.ClientWheelData<T> // TypeDefIndex: 9783
{	// Fields
	public VisualCarWheel wheel; // 0x0
	public Vector3 vehicleLocalPos; // 0x0
	public Vector3 restingLocalPos; // 0x0
	public RaycastHit hit; // 0x0
	public bool isGrounded; // 0x0
	public bool isOnWater; // 0x0
	public float spinSlip; // 0x0
	public TerrainConfig.GroundType groundType; // 0x0
	public Vector3 latestWorldPos; // 0x0
	public float extension; // 0x0
	public float prevExtension; // 0x0
	public float extensionPercent; // 0x0
	public Sound sound; // 0x0
	public SoundModulation.Modulator gainModulator; // 0x0

	// Properties
	public bool isOnHardGround { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_isOnHardGround() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BBB20 Offset: 0x19BA120 VA: 0x1819BBB20
	|-VehicleChassisVisuals.ClientWheelData<ModularCar>.get_isOnHardGround
	|-VehicleChassisVisuals.ClientWheelData<object>.get_isOnHardGround
	*/

	// RVA: -1 Offset: -1
	public void .ctor(VisualCarWheel wheel, Transform vehicleTransform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BBA50 Offset: 0x19BA050 VA: 0x1819BBA50
	|-VehicleChassisVisuals.ClientWheelData<ModularCar>..ctor
	|-VehicleChassisVisuals.ClientWheelData<Snowmobile>..ctor
	|-VehicleChassisVisuals.ClientWheelData<object>..ctor
	*/

}

private struct VehicleChassisVisuals.<>c__DisplayClass17_0<T> // TypeDefIndex: 9785
{	// Fields
	public Vector3 vehicleDown; // 0x0
	public float wheelRadius; // 0x0
	public float suspensionDistance; // 0x0

}

public class VehicleEngineController<TOwner> // TypeDefIndex: 9787
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EntityFuelSystem <FuelSystem>k__BackingField; // 0x0
	private readonly TOwner owner; // 0x0
	private readonly bool isServer; // 0x0
	private readonly float engineStartupTime; // 0x0
	private readonly Transform waterloggedPoint; // 0x0
	private readonly BaseEntity.Flags engineStartingFlag; // 0x0

	// Properties
	public VehicleEngineController.EngineState<TOwner> CurEngineState { get; }
	public bool IsOn { get; }
	public bool IsOff { get; }
	public bool IsStarting { get; }
	public bool IsStartingOrOn { get; }
	public EntityFuelSystem FuelSystem { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public VehicleEngineController.EngineState<TOwner> get_CurEngineState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF770 Offset: 0x19CDD70 VA: 0x1819CF770
	|-VehicleEngineController<BaseSubmarine>.get_CurEngineState
	|-VehicleEngineController<GroundVehicle>.get_CurEngineState
	|-VehicleEngineController<MiniCopter>.get_CurEngineState
	|-VehicleEngineController<object>.get_CurEngineState
	|-VehicleEngineController<TrainEngine>.get_CurEngineState
	*/

	// RVA: -1 Offset: -1
	public bool get_IsOn() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF7D0 Offset: 0x19CDDD0 VA: 0x1819CF7D0
	|-VehicleEngineController<BaseSubmarine>.get_IsOn
	|-VehicleEngineController<GroundVehicle>.get_IsOn
	|-VehicleEngineController<object>.get_IsOn
	*/

	// RVA: -1 Offset: -1
	public bool get_IsOff() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E6A10 Offset: 0x15E5010 VA: 0x1815E6A10
	|-VehicleEngineController<object>.get_IsOff
	|-VehicleEngineController<TrainEngine>.get_IsOff
	*/

	// RVA: -1 Offset: -1
	public bool get_IsStarting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF830 Offset: 0x19CDE30 VA: 0x1819CF830
	|-VehicleEngineController<MiniCopter>.get_IsStarting
	|-VehicleEngineController<object>.get_IsStarting
	*/

	// RVA: -1 Offset: -1
	public bool get_IsStartingOrOn() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF800 Offset: 0x19CDE00 VA: 0x1819CF800
	|-VehicleEngineController<GroundVehicle>.get_IsStartingOrOn
	|-VehicleEngineController<object>.get_IsStartingOrOn
	|-VehicleEngineController<TrainEngine>.get_IsStartingOrOn
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public EntityFuelSystem get_FuelSystem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	|-VehicleEngineController<BaseSubmarine>.get_FuelSystem
	|-VehicleEngineController<GroundVehicle>.get_FuelSystem
	|-VehicleEngineController<MiniCopter>.get_FuelSystem
	|-VehicleEngineController<object>.get_FuelSystem
	|-VehicleEngineController<TrainEngine>.get_FuelSystem
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private void set_FuelSystem(EntityFuelSystem value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	|-VehicleEngineController<object>.set_FuelSystem
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TOwner owner, bool isServer, float engineStartupTime, GameObjectRef fuelStoragePrefab, Transform waterloggedPoint, BaseEntity.Flags engineStartingFlag = 128) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF650 Offset: 0x19CDC50 VA: 0x1819CF650
	|-VehicleEngineController<BaseSubmarine>..ctor
	|-VehicleEngineController<GroundVehicle>..ctor
	|-VehicleEngineController<MiniCopter>..ctor
	|-VehicleEngineController<object>..ctor
	|-VehicleEngineController<TrainEngine>..ctor
	*/

	// RVA: -1 Offset: -1
	public VehicleEngineController.EngineState<TOwner> EngineStateFrom(BaseEntity.Flags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF550 Offset: 0x19CDB50 VA: 0x1819CF550
	|-VehicleEngineController<object>.EngineStateFrom
	|-VehicleEngineController<TrainEngine>.EngineStateFrom
	*/

}

public enum VehicleEngineController.EngineState<TOwner> // TypeDefIndex: 9788
{	// Fields
	public int value__; // 0x0
	public const VehicleEngineController.EngineState<TOwner> Off = 0;
	public const VehicleEngineController.EngineState<TOwner> Starting = 1;
	public const VehicleEngineController.EngineState<TOwner> On = 2;

}

public class VehicleSpawnPoint : SpaceCheckingSpawnPoint // TypeDefIndex: 10011
{	// Methods

	// RVA: 0xAD84D0 Offset: 0xAD6AD0 VA: 0x180AD84D0
	public void .ctor() { }

}

public class EngineItemInformationPanel : ItemInformationPanel // TypeDefIndex: 11002
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Text tier; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase low; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase medium; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase high; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject accelerationRoot; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject topSpeedRoot; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject fuelEconomyRoot; // 0x48

	// Methods

	// RVA: 0x8C33B0 Offset: 0x8C19B0 VA: 0x1808C33B0 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x8C3430 Offset: 0x8C1A30 VA: 0x1808C3430 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

public class VehicleEditingItemIcon : MonoBehaviour, IInventoryChanged // TypeDefIndex: 11061
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image foregroundImage; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image linkImage; // 0x20
	private ItemIcon itemIcon; // 0x28

	// Methods

	// RVA: 0xACDAE0 Offset: 0xACC0E0 VA: 0x180ACDAE0
	protected void Awake() { }

	// RVA: 0xACDD80 Offset: 0xACC380 VA: 0x180ACDD80
	protected void OnEnable() { }

	// RVA: 0xACDD00 Offset: 0xACC300 VA: 0x180ACDD00
	protected void OnDisable() { }

	// RVA: 0xACDE40 Offset: 0xACC440 VA: 0x180ACDE40 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0xACDB70 Offset: 0xACC170 VA: 0x180ACDB70
	private void InventoryChangeRefresh() { }

	// RVA: 0xACDE50 Offset: 0xACC450 VA: 0x180ACDE50
	private void SetLinkSprite(Sprite sprite) { }

	// RVA: 0xACDB30 Offset: 0xACC130 VA: 0x180ACDB30
	private void ClearLinkSprite() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class VehicleEditingPanel : LootPanel // TypeDefIndex: 11062
{	// Fields
	[SerializeField] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	[RangeAttribute] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	private float disabledAlpha; // 0x38
	[HeaderAttribute] // RVA: 0x91AC0 Offset: 0x90EC0 VA: 0x180091AC0
	[SerializeField] // RVA: 0x91AC0 Offset: 0x90EC0 VA: 0x180091AC0
	private CanvasGroup editGroup; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject moduleInternalItemsGroup; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject moduleInternalLiquidsGroup; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject destroyChassisGroup; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Button itemTakeButton; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Button liquidTakeButton; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject liquidHelp; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject liquidButton; // 0x78
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color gotColor; // 0x80
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color notGotColor; // 0x90
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Text generalInfoText; // 0xA0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Text generalWarningText; // 0xA8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image generalWarningImage; // 0xB0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Text repairInfoText; // 0xB8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Button repairButton; // 0xC0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Text destroyChassisButtonText; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Text destroyChassisCountdown; // 0xD0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseEditingInfo; // 0xD8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseNoOccupant; // 0xE0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseBadOccupant; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseNotDriveable; // 0xF0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseNotRepairable; // 0xF8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseRepairNotNeeded; // 0x100
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseRepairSelectInfo; // 0x108
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseRepairEnactInfo; // 0x110
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseHasLock; // 0x118
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseHasNoLock; // 0x120
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseAddLock; // 0x128
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseAddKey; // 0x130
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseAddLockButton; // 0x138
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseCraftKeyButton; // 0x140
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Text carLockInfoText; // 0x148
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Text carLockButtonText; // 0x150
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Button actionLockButton; // 0x158
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Button removeLockButton; // 0x160
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Translate.Phrase phraseEmptyStorage; // 0x168
	[HeaderAttribute] // RVA: 0x94520 Offset: 0x93920 VA: 0x180094520
	[SerializeField] // RVA: 0x94520 Offset: 0x93920 VA: 0x180094520
	private VehicleEditingPanel.CreateChassisEntry[] chassisOptions; // 0x170
	private uint prevSelectedUID; // 0x178
	private bool platformWasOccupied; // 0x17C
	private bool hadEditableOccupant; // 0x17D
	private bool hasDriveableOccupant; // 0x17E
	private ModularCarGarage.OccupantLock occupantLockState; // 0x180
	private int occupantLockID; // 0x184

	// Properties
	private Item CurSelectedItem { get; }
	private ItemContainer ModulesContainer { get; }
	private ItemContainer ChassisContainer { get; }
	private ItemContainer ModuleInternalItemContainer { get; }

	// Methods

	// RVA: 0xAD0D70 Offset: 0xACF370 VA: 0x180AD0D70
	private Item get_CurSelectedItem() { }

	// RVA: 0xAD0E20 Offset: 0xACF420 VA: 0x180AD0E20
	private ItemContainer get_ModulesContainer() { }

	// RVA: 0xAD0D60 Offset: 0xACF360 VA: 0x180AD0D60
	private ItemContainer get_ChassisContainer() { }

	// RVA: 0xAD0E10 Offset: 0xACF410 VA: 0x180AD0E10
	private ItemContainer get_ModuleInternalItemContainer() { }

	// RVA: 0xACE680 Offset: 0xACCC80 VA: 0x180ACE680
	protected void OnEnable() { }

	// RVA: 0xAD0B40 Offset: 0xACF140 VA: 0x180AD0B40 Slot: 5
	public override void Update() { }

	// RVA: 0xAD0390 Offset: 0xACE990 VA: 0x180AD0390
	public void RepairClicked() { }

	// RVA: 0xACE0D0 Offset: 0xACC6D0 VA: 0x180ACE0D0
	public void CraftLockClicked() { }

	// RVA: 0xAD0310 Offset: 0xACE910 VA: 0x180AD0310
	public void RemoveLockClicked() { }

	// RVA: 0xACE180 Offset: 0xACC780 VA: 0x180ACE180
	public void DestroyChassisClicked() { }

	// RVA: 0xAD04E0 Offset: 0xACEAE0 VA: 0x180AD04E0
	public void TakeInternalItemsClicked() { }

	// RVA: 0xACE410 Offset: 0xACCA10 VA: 0x180ACE410
	public void OnCopyFromLiquidDown() { }

	// RVA: 0xACE490 Offset: 0xACCA90 VA: 0x180ACE490
	public void OnCopyFromLiquidUp() { }

	// RVA: 0xAD0440 Offset: 0xACEA40 VA: 0x180AD0440
	private bool SelectedValidLiquidTarget() { }

	// RVA: 0xACE2B0 Offset: 0xACC8B0 VA: 0x180ACE2B0
	private void LiquidCopyFrom() { }

	// RVA: 0xACDEA0 Offset: 0xACC4A0 VA: 0x180ACDEA0
	private bool CanTakeLiquid() { }

	// RVA: 0xACE220 Offset: 0xACC820 VA: 0x180ACE220
	private ModularCarGarage GetGarage() { }

	// RVA: 0xACEB40 Offset: 0xACD140 VA: 0x180ACEB40
	private void RefreshEditUI() { }

	// RVA: 0xACEDA0 Offset: 0xACD3A0 VA: 0x180ACEDA0
	private void RefreshHasVehicle(ModularCarGarage garage, bool forced = False) { }

	// RVA: 0xACEF10 Offset: 0xACD510 VA: 0x180ACEF10
	private void RefreshInfoText() { }

	// RVA: 0xACFEC0 Offset: 0xACE4C0 VA: 0x180ACFEC0
	private void RefreshWarningText() { }

	// RVA: 0xACE830 Offset: 0xACCE30 VA: 0x180ACE830
	private void OnSelectedItemChanged(Item newSelectedItem) { }

	// RVA: 0xACE8C0 Offset: 0xACCEC0 VA: 0x180ACE8C0
	private void RefreshDestroyGroup(ModularCarGarage garage) { }

	// RVA: 0xACF200 Offset: 0xACD800 VA: 0x180ACF200
	private void RefreshLockCreation(ModularCarGarage garage) { }

	// RVA: 0xACF860 Offset: 0xACDE60 VA: 0x180ACF860
	private void RefreshRepair() { }

	// RVA: 0xAD0D50 Offset: 0xACF350 VA: 0x180AD0D50
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD07A0 Offset: 0xACEDA0 VA: 0x180AD07A0
	private bool <RefreshLockCreation>g__AddResourceInfo|72_0(string prefixText, ItemAmount ingredient, ref VehicleEditingPanel.<>c__DisplayClass72_0 ) { }

}

private class VehicleEditingPanel.CreateChassisEntry // TypeDefIndex: 11063
{	// Fields
	public byte garageChassisIndex; // 0x10
	public Button craftButton; // 0x18
	public Text craftButtonText; // 0x20
	public Text requirementsText; // 0x28

	// Methods

	// RVA: 0xAC7A50 Offset: 0xAC6050 VA: 0x180AC7A50
	public ItemDefinition GetChassisItemDef(ModularCarGarage garage) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private struct VehicleEditingPanel.<>c__DisplayClass72_0 // TypeDefIndex: 11064
{	// Fields
	public VehicleEditingPanel <>4__this; // 0x0
	public string infoText; // 0x8

}

public class VehicleModuleInformationPanel : ItemInformationPanel // TypeDefIndex: 11065
{	// Fields
	public ItemStatValue socketsDisplay; // 0x18
	public ItemStatValue hpDisplay; // 0x20

	// Methods

	// RVA: 0xAD4550 Offset: 0xAD2B50 VA: 0x180AD4550 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0xAD45A0 Offset: 0xAD2BA0 VA: 0x180AD45A0 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

public class vehicle : ConsoleSystem // TypeDefIndex: 11972
{	// Methods

	// RVA: 0x375F30 Offset: 0x374530 VA: 0x180375F30
	public void .ctor() { }

}

public static class EngineItemTypeEx // TypeDefIndex: 12102
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BCCA0 Offset: 0x4BB2A0 VA: 0x1804BCCA0
	public static bool BoostsAcceleration(EngineStorage.EngineItemTypes engineItemType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BCCC0 Offset: 0x4BB2C0 VA: 0x1804BCCC0
	public static bool BoostsTopSpeed(EngineStorage.EngineItemTypes engineItemType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BCCB0 Offset: 0x4BB2B0 VA: 0x1804BCCB0
	public static bool BoostsFuelEconomy(EngineStorage.EngineItemTypes engineItemType) { }

}

public class EngineStorage : StorageContainer // TypeDefIndex: 12103
{	// Fields
	[HeaderAttribute] // RVA: 0xD9690 Offset: 0xD8A90 VA: 0x1800D9690
	public Sprite engineIcon; // 0x3D0
	public float internalDamageMultiplier; // 0x3D8
	public EngineStorage.EngineItemTypes[] slotTypes; // 0x3E0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleModuleEngineItems allEngineItems; // 0x3E8
	[SerializeField] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	[ReadOnlyAttribute] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	private int accelerationBoostSlots; // 0x3F0
	[SerializeField] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	[ReadOnlyAttribute] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	private int topSpeedBoostSlots; // 0x3F4
	[SerializeField] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	[ReadOnlyAttribute] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	private int fuelEconomyBoostSlots; // 0x3F8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <isUsable>k__BackingField; // 0x3FC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <accelerationBoostPercent>k__BackingField; // 0x400
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <topSpeedBoostPercent>k__BackingField; // 0x404
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <fuelEconomyBoostPercent>k__BackingField; // 0x408

	// Properties
	public bool isUsable { get; set; }
	public float accelerationBoostPercent { get; set; }
	public float topSpeedBoostPercent { get; set; }
	public float fuelEconomyBoostPercent { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD150 Offset: 0x4BB750 VA: 0x1804BD150
	public bool get_isUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD190 Offset: 0x4BB790 VA: 0x1804BD190
	private void set_isUsable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD130 Offset: 0x4BB730 VA: 0x1804BD130
	public float get_accelerationBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD170 Offset: 0x4BB770 VA: 0x1804BD170
	private void set_accelerationBoostPercent(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD160 Offset: 0x4BB760 VA: 0x1804BD160
	public float get_topSpeedBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD1A0 Offset: 0x4BB7A0 VA: 0x1804BD1A0
	private void set_topSpeedBoostPercent(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD140 Offset: 0x4BB740 VA: 0x1804BD140
	public float get_fuelEconomyBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD180 Offset: 0x4BB780 VA: 0x1804BD180
	private void set_fuelEconomyBoostPercent(float value) { }

	// RVA: 0x4BCDA0 Offset: 0x4BB3A0 VA: 0x1804BCDA0
	public VehicleModuleEngine GetEngineModule() { }

	// RVA: 0x4BCD70 Offset: 0x4BB370 VA: 0x1804BCD70
	public float GetAveragedLoadoutPercent() { }

	// RVA: 0x4BD020 Offset: 0x4BB620 VA: 0x1804BD020 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4BCCD0 Offset: 0x4BB2D0 VA: 0x1804BCCD0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x4BCE40 Offset: 0x4BB440 VA: 0x1804BCE40
	private int GetValidSlot(Item item) { }

	// RVA: 0x4BCE30 Offset: 0x4BB430 VA: 0x1804BCE30 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x4BD0D0 Offset: 0x4BB6D0 VA: 0x1804BD0D0
	public void .ctor() { }

}

public enum EngineStorage.EngineItemTypes // TypeDefIndex: 12104
{	// Fields
	public int value__; // 0x0
	public const EngineStorage.EngineItemTypes Crankshaft = 0;
	public const EngineStorage.EngineItemTypes Carburetor = 1;
	public const EngineStorage.EngineItemTypes SparkPlug = 2;
	public const EngineStorage.EngineItemTypes Piston = 3;
	public const EngineStorage.EngineItemTypes Valve = 4;

}

public class ModularCarAudio : GroundVehicleAudio // TypeDefIndex: 12105
{	// Fields
	public bool showDebug; // 0x98
	[HeaderAttribute] // RVA: 0xDA5C0 Offset: 0xD99C0 VA: 0x1800DA5C0
	[SerializeField] // RVA: 0xDA5C0 Offset: 0xD99C0 VA: 0x1800DA5C0
	private SoundDefinition skidSoundLoop; // 0xA0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition skidSoundDirtLoop; // 0xA8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition skidSoundSnowLoop; // 0xB0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float skidMinSlip; // 0xB8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float skidMaxSlip; // 0xBC
	[HeaderAttribute] // RVA: 0xDA9D0 Offset: 0xD9DD0 VA: 0x1800DA9D0
	[SerializeField] // RVA: 0xDA9D0 Offset: 0xD9DD0 VA: 0x1800DA9D0
	private SoundDefinition movementStartOneshot; // 0xC0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition movementStopOneshot; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float movementStartStopMinTimeBetweenSounds; // 0xD0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition movementRattleLoop; // 0xD8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float movementRattleMaxSpeed; // 0xE0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float movementRattleMaxAngSpeed; // 0xE4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float movementRattleIdleGain; // 0xE8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suspensionLurchSound; // 0xF0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float suspensionLurchMinExtensionDelta; // 0xF8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float suspensionLurchMinTimeBetweenSounds; // 0xFC
	[HeaderAttribute] // RVA: 0xDB390 Offset: 0xDA790 VA: 0x1800DB390
	[SerializeField] // RVA: 0xDB390 Offset: 0xDA790 VA: 0x1800DB390
	private SoundDefinition tyreRollingSoundDef; // 0x100
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition tyreRollingWaterSoundDef; // 0x108
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition tyreRollingGrassSoundDef; // 0x110
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition tyreRollingSnowSoundDef; // 0x118
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve tyreRollGainCurve; // 0x120
	private EngineAudioSet currentEngineAudioSet; // 0x128
	private ModularCar modularCar; // 0x130
	private float skidRatio; // 0x138
	private Sound skidSound; // 0x140
	private SoundModulation.Modulator skidGain; // 0x148
	private const float SKID_RATIO_CHANGE_RATE = 12;
	private Dictionary<VehicleChassisVisuals.ClientWheelData<ModularCar>, float> prevWheelExtensionPercent; // 0x150
	private Dictionary<VehicleChassisVisuals.ClientWheelData<ModularCar>, bool> wheelWasGrounded; // 0x158
	private Dictionary<VehicleChassisVisuals.ClientWheelData<ModularCar>, float> lastSuspensionSoundPlayed; // 0x160
	private Dictionary<EngineAudioSet, byte> attachedEngineCounts; // 0x168
	private Sound movementRattleSound; // 0x170
	private SoundModulation.Modulator rattleGain; // 0x178
	private Quaternion prevRotation; // 0x180
	private bool wasStationary; // 0x190
	private float lastMovementStartSoundPlayed; // 0x194
	private float lastMovementStopSoundPlayed; // 0x198
	private float noMovementCount; // 0x19C

	// Properties
	protected override EngineAudioSet EngineAudioSet { get; set; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataFL { get; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataFR { get; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataRL { get; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataRR { get; }

	// Methods

	// RVA: 0x4C12E0 Offset: 0x4BF8E0 VA: 0x1804C12E0 Slot: 4
	protected override EngineAudioSet get_EngineAudioSet() { }

	// RVA: 0x4C13B0 Offset: 0x4BF9B0 VA: 0x1804C13B0 Slot: 5
	protected override void set_EngineAudioSet(EngineAudioSet value) { }

	// RVA: 0x4C12F0 Offset: 0x4BF8F0 VA: 0x1804C12F0
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataFL() { }

	// RVA: 0x4C1320 Offset: 0x4BF920 VA: 0x1804C1320
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataFR() { }

	// RVA: 0x4C1350 Offset: 0x4BF950 VA: 0x1804C1350
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataRL() { }

	// RVA: 0x4C1380 Offset: 0x4BF980 VA: 0x1804C1380
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataRR() { }

	// RVA: 0x4BF320 Offset: 0x4BD920 VA: 0x1804BF320 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4BF3C0 Offset: 0x4BD9C0 VA: 0x1804BF3C0 Slot: 7
	public override void ClientTick() { }

	// RVA: 0x4BF770 Offset: 0x4BDD70 VA: 0x1804BF770 Slot: 8
	public override void OnClientTickStopped() { }

	// RVA: 0x4BF7B0 Offset: 0x4BDDB0 VA: 0x1804BF7B0
	internal void OnModuleAdded(BaseVehicleModule addedModule) { }

	// RVA: 0x4BF960 Offset: 0x4BDF60 VA: 0x1804BF960
	internal void OnModuleRemoved(BaseVehicleModule removedModule) { }

	// RVA: 0x4BF700 Offset: 0x4BDD00 VA: 0x1804BF700 Slot: 9
	protected override int GetNumEngines() { }

	// RVA: 0x4BFCA0 Offset: 0x4BE2A0 VA: 0x1804BFCA0
	private void PlayTyreAudio() { }

	// RVA: 0x4BFF80 Offset: 0x4BE580 VA: 0x1804BFF80
	private void StopTyreAudio() { }

	// RVA: 0x4BFEC0 Offset: 0x4BE4C0 VA: 0x1804BFEC0
	private void StopSkidSound() { }

	// RVA: 0x4C00E0 Offset: 0x4BE6E0 VA: 0x1804C00E0
	private void UpdateMovementRattleSound() { }

	// RVA: 0x4BFE00 Offset: 0x4BE400 VA: 0x1804BFE00
	private void StopMovementRattleSound() { }

	// RVA: 0x4C0A10 Offset: 0x4BF010 VA: 0x1804C0A10
	private void UpdateSuspensionSounds() { }

	// RVA: 0x4C0600 Offset: 0x4BEC00 VA: 0x1804C0600
	private void UpdateSkidSound(float dt, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData) { }

	// RVA: 0x4C0010 Offset: 0x4BE610 VA: 0x1804C0010
	private void StopTyreSound(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData) { }

	// RVA: 0x4C0DB0 Offset: 0x4BF3B0 VA: 0x1804C0DB0
	private void UpdateTyreSound(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, float speedRatio) { }

	// RVA: 0x4C1180 Offset: 0x4BF780 VA: 0x1804C1180
	public void .ctor() { }

}

public class ModularVehicleSocket // TypeDefIndex: 12106
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform socketTransform; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ModularVehicleSocket.SocketWheelType wheelType; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ModularVehicleSocket.SocketLocationType locationType; // 0x1C

	// Properties
	public Vector3 WorldPosition { get; }
	public Quaternion WorldRotation { get; }
	public ModularVehicleSocket.SocketWheelType WheelType { get; }
	public ModularVehicleSocket.SocketLocationType LocationType { get; }

	// Methods

	// RVA: 0x4C1480 Offset: 0x4BFA80 VA: 0x1804C1480
	public Vector3 get_WorldPosition() { }

	// RVA: 0x4C14C0 Offset: 0x4BFAC0 VA: 0x1804C14C0
	public Quaternion get_WorldRotation() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public ModularVehicleSocket.SocketWheelType get_WheelType() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public ModularVehicleSocket.SocketLocationType get_LocationType() { }

	// RVA: 0x4C13C0 Offset: 0x4BF9C0 VA: 0x1804C13C0
	public bool ShouldBeActive(ConditionalSocketSettings modelSettings) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum ModularVehicleSocket.SocketWheelType // TypeDefIndex: 12107
{	// Fields
	public int value__; // 0x0
	public const ModularVehicleSocket.SocketWheelType NoWheel = 0;
	public const ModularVehicleSocket.SocketWheelType ForwardWheel = 1;
	public const ModularVehicleSocket.SocketWheelType BackWheel = 2;

}

public enum ModularVehicleSocket.SocketLocationType // TypeDefIndex: 12108
{	// Fields
	public int value__; // 0x0
	public const ModularVehicleSocket.SocketLocationType Middle = 0;
	public const ModularVehicleSocket.SocketLocationType Front = 1;
	public const ModularVehicleSocket.SocketLocationType Back = 2;

}

public class VehicleModuleEngineItems : ScriptableObject // TypeDefIndex: 12109
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ItemModEngineItem[] engineItems; // 0x18

	// Methods

	// RVA: 0x4D2BB0 Offset: 0x4D11B0 VA: 0x1804D2BB0
	public bool TryGetItem(int tier, EngineStorage.EngineItemTypes type, out ItemModEngineItem output) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class VehicleModuleSlidingComponent // TypeDefIndex: 12110
{	// Fields
	public string interactionColliderName; // 0x10
	public BaseEntity.Flags flag_SliderOpen; // 0x18
	public float moveTime; // 0x1C
	public VehicleModuleSlidingComponent.SlidingPart[] slidingParts; // 0x20
	public SoundDefinition openSoundDef; // 0x28
	public SoundDefinition closeSoundDef; // 0x30
	private float positionPercent; // 0x38

	// Methods

	// RVA: 0x4D31E0 Offset: 0x4D17E0 VA: 0x1804D31E0
	public bool WantsOpenPos(BaseEntity parentEntity) { }

	// RVA: 0x4D2FB0 Offset: 0x4D15B0 VA: 0x1804D2FB0
	public void ClientUpdateTick(BaseVehicleModule parentModule) { }

	// RVA: 0x4D2FF0 Offset: 0x4D15F0 VA: 0x1804D2FF0
	private void PlaySounds(bool wantsOpenPos) { }

	// RVA: 0x4D2D20 Offset: 0x4D1320 VA: 0x1804D2D20
	private void CheckPosition(BaseEntity parentEntity, float dt) { }

	// RVA: 0x4D3210 Offset: 0x4D1810 VA: 0x1804D3210
	public void .ctor() { }

}

public class VehicleModuleSlidingComponent.SlidingPart // TypeDefIndex: 12111
{	// Fields
	public Transform transform; // 0x10
	public Vector3 openPosition; // 0x18
	public Vector3 closedPosition; // 0x24

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

