public class BaseVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6327
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<BaseVehicle.MountPoint> mountPoints; // 0x18

	// Methods

	// RVA: 0x1F6AD90 Offset: 0x1F69390 VA: 0x181F6AD90
	public static void ResetToPool(BaseVehicle instance) { }

	// RVA: 0x1F6ABE0 Offset: 0x1F691E0 VA: 0x181F6ABE0
	public void ResetToPool() { }

	// RVA: 0x1F6A960 Offset: 0x1F68F60 VA: 0x181F6A960 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F69AE0 Offset: 0x1F680E0 VA: 0x181F69AE0
	public void CopyTo(BaseVehicle instance) { }

	// RVA: 0x1F69C70 Offset: 0x1F68270 VA: 0x181F69C70
	public BaseVehicle Copy() { }

	// RVA: 0x1F6A6F0 Offset: 0x1F68CF0 VA: 0x181F6A6F0
	public static BaseVehicle Deserialize(Stream stream) { }

	// RVA: 0x1F6A120 Offset: 0x1F68720 VA: 0x181F6A120
	public static BaseVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F6A1A0 Offset: 0x1F687A0 VA: 0x181F6A1A0
	public static BaseVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F6A5D0 Offset: 0x1F68BD0 VA: 0x181F6A5D0
	public static BaseVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1F6ABA0 Offset: 0x1F691A0 VA: 0x181F6ABA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F6B4D0 Offset: 0x1F69AD0 VA: 0x181F6B4D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F6B4F0 Offset: 0x1F69AF0 VA: 0x181F6B4F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseVehicle previous) { }

	// RVA: 0x1F6ABC0 Offset: 0x1F691C0 VA: 0x181F6ABC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F6A4D0 Offset: 0x1F68AD0 VA: 0x181F6A4D0
	public static BaseVehicle Deserialize(byte[] buffer, BaseVehicle instance, bool isDelta = False) { }

	// RVA: 0x1F6A770 Offset: 0x1F68D70 VA: 0x181F6A770
	public static BaseVehicle Deserialize(Stream stream, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F69E50 Offset: 0x1F68450 VA: 0x181F69E50
	public static BaseVehicle DeserializeLengthDelimited(Stream stream, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F6A230 Offset: 0x1F68830 VA: 0x181F6A230
	public static BaseVehicle DeserializeLength(Stream stream, int length, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F6AF40 Offset: 0x1F69540 VA: 0x181F6AF40
	public static void SerializeDelta(Stream stream, BaseVehicle instance, BaseVehicle previous) { }

	// RVA: 0x1F6B2E0 Offset: 0x1F698E0 VA: 0x181F6B2E0
	public static void Serialize(Stream stream, BaseVehicle instance) { }

	// RVA: 0x1F6B4C0 Offset: 0x1F69AC0 VA: 0x181F6B4C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F6B4D0 Offset: 0x1F69AD0 VA: 0x181F6B4D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F6B1D0 Offset: 0x1F697D0 VA: 0x181F6B1D0
	public static byte[] SerializeToBytes(BaseVehicle instance) { }

	// RVA: 0x1F6B120 Offset: 0x1F69720 VA: 0x181F6B120
	public static void SerializeLengthDelimited(Stream stream, BaseVehicle instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class BaseVehicle.MountPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6328
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int index; // 0x14
	public uint mountableId; // 0x18

	// Methods

	// RVA: 0x1F7CDF0 Offset: 0x1F7B3F0 VA: 0x181F7CDF0
	public static void ResetToPool(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7CD70 Offset: 0x1F7B370 VA: 0x181F7CD70
	public void ResetToPool() { }

	// RVA: 0x1F7CB50 Offset: 0x1F7B150 VA: 0x181F7CB50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBE8E0 Offset: 0x1DBCEE0 VA: 0x181DBE8E0
	public void CopyTo(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7BD50 Offset: 0x1F7A350 VA: 0x181F7BD50
	public BaseVehicle.MountPoint Copy() { }

	// RVA: 0x1F7C4D0 Offset: 0x1F7AAD0 VA: 0x181F7C4D0
	public static BaseVehicle.MountPoint Deserialize(Stream stream) { }

	// RVA: 0x1F7C010 Offset: 0x1F7A610 VA: 0x181F7C010
	public static BaseVehicle.MountPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7C090 Offset: 0x1F7A690 VA: 0x181F7C090
	public static BaseVehicle.MountPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7C690 Offset: 0x1F7AC90 VA: 0x181F7C690
	public static BaseVehicle.MountPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F7CBD0 Offset: 0x1F7B1D0 VA: 0x181F7CBD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7D2B0 Offset: 0x1F7B8B0 VA: 0x181F7D2B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7D2D0 Offset: 0x1F7B8D0 VA: 0x181F7D2D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseVehicle.MountPoint previous) { }

	// RVA: 0x1F7CD50 Offset: 0x1F7B350 VA: 0x181F7CD50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7C900 Offset: 0x1F7AF00 VA: 0x181F7C900
	public static BaseVehicle.MountPoint Deserialize(byte[] buffer, BaseVehicle.MountPoint instance, bool isDelta = False) { }

	// RVA: 0x1F7C350 Offset: 0x1F7A950 VA: 0x181F7C350
	public static BaseVehicle.MountPoint Deserialize(Stream stream, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F7BDC0 Offset: 0x1F7A3C0 VA: 0x181F7BDC0
	public static BaseVehicle.MountPoint DeserializeLengthDelimited(Stream stream, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F7C120 Offset: 0x1F7A720 VA: 0x181F7C120
	public static BaseVehicle.MountPoint DeserializeLength(Stream stream, int length, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F7CE70 Offset: 0x1F7B470 VA: 0x181F7CE70
	public static void SerializeDelta(Stream stream, BaseVehicle.MountPoint instance, BaseVehicle.MountPoint previous) { }

	// RVA: 0x1F7D1A0 Offset: 0x1F7B7A0 VA: 0x181F7D1A0
	public static void Serialize(Stream stream, BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7D2A0 Offset: 0x1F7B8A0 VA: 0x181F7D2A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7D2B0 Offset: 0x1F7B8B0 VA: 0x181F7D2B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7D090 Offset: 0x1F7B690 VA: 0x181F7D090
	public static byte[] SerializeToBytes(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7CFE0 Offset: 0x1F7B5E0 VA: 0x181F7CFE0
	public static void SerializeLengthDelimited(Stream stream, BaseVehicle.MountPoint instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class Motorboat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6346
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint storageid; // 0x14
	public uint fuelStorageID; // 0x18

	// Methods

	// RVA: 0x1F8B270 Offset: 0x1F89870 VA: 0x181F8B270
	public static void ResetToPool(Motorboat instance) { }

	// RVA: 0x1F8B1F0 Offset: 0x1F897F0 VA: 0x181F8B1F0
	public void ResetToPool() { }

	// RVA: 0x1F8AF50 Offset: 0x1F89550 VA: 0x181F8AF50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBE8E0 Offset: 0x1DBCEE0 VA: 0x181DBE8E0
	public void CopyTo(Motorboat instance) { }

	// RVA: 0x1F8A150 Offset: 0x1F88750 VA: 0x181F8A150
	public Motorboat Copy() { }

	// RVA: 0x1F8AD90 Offset: 0x1F89390 VA: 0x181F8AD90
	public static Motorboat Deserialize(Stream stream) { }

	// RVA: 0x1F8A1C0 Offset: 0x1F887C0 VA: 0x181F8A1C0
	public static Motorboat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8A6C0 Offset: 0x1F88CC0 VA: 0x181F8A6C0
	public static Motorboat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8A750 Offset: 0x1F88D50 VA: 0x181F8A750
	public static Motorboat Deserialize(byte[] buffer) { }

	// RVA: 0x1F8B050 Offset: 0x1F89650 VA: 0x181F8B050
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8B730 Offset: 0x1F89D30 VA: 0x181F8B730 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8B750 Offset: 0x1F89D50 VA: 0x181F8B750 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Motorboat previous) { }

	// RVA: 0x1F8B1D0 Offset: 0x1F897D0 VA: 0x181F8B1D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8AB40 Offset: 0x1F89140 VA: 0x181F8AB40
	public static Motorboat Deserialize(byte[] buffer, Motorboat instance, bool isDelta = False) { }

	// RVA: 0x1F8A9C0 Offset: 0x1F88FC0 VA: 0x181F8A9C0
	public static Motorboat Deserialize(Stream stream, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F8A240 Offset: 0x1F88840 VA: 0x181F8A240
	public static Motorboat DeserializeLengthDelimited(Stream stream, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F8A490 Offset: 0x1F88A90 VA: 0x181F8A490
	public static Motorboat DeserializeLength(Stream stream, int length, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F8B2F0 Offset: 0x1F898F0 VA: 0x181F8B2F0
	public static void SerializeDelta(Stream stream, Motorboat instance, Motorboat previous) { }

	// RVA: 0x1F8B620 Offset: 0x1F89C20 VA: 0x181F8B620
	public static void Serialize(Stream stream, Motorboat instance) { }

	// RVA: 0x1F8B720 Offset: 0x1F89D20 VA: 0x181F8B720
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8B730 Offset: 0x1F89D30 VA: 0x181F8B730
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8B510 Offset: 0x1F89B10 VA: 0x181F8B510
	public static byte[] SerializeToBytes(Motorboat instance) { }

	// RVA: 0x1F8B460 Offset: 0x1F89A60 VA: 0x181F8B460
	public static void SerializeLengthDelimited(Stream stream, Motorboat instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class ModularVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6348
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool editable; // 0x12

	// Methods

	// RVA: 0x1F87CE0 Offset: 0x1F862E0 VA: 0x181F87CE0
	public static void ResetToPool(ModularVehicle instance) { }

	// RVA: 0x1F87C60 Offset: 0x1F86260 VA: 0x181F87C60
	public void ResetToPool() { }

	// RVA: 0x1F87B30 Offset: 0x1F86130 VA: 0x181F87B30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E19180 Offset: 0x1E17780 VA: 0x181E19180
	public void CopyTo(ModularVehicle instance) { }

	// RVA: 0x1F871B0 Offset: 0x1F857B0 VA: 0x181F871B0
	public ModularVehicle Copy() { }

	// RVA: 0x1F87AB0 Offset: 0x1F860B0 VA: 0x181F87AB0
	public static ModularVehicle Deserialize(Stream stream) { }

	// RVA: 0x1F87220 Offset: 0x1F85820 VA: 0x181F87220
	public static ModularVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F874C0 Offset: 0x1F85AC0 VA: 0x181F874C0
	public static ModularVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F87990 Offset: 0x1F85F90 VA: 0x181F87990
	public static ModularVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1F87C20 Offset: 0x1F86220 VA: 0x181F87C20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F88170 Offset: 0x1F86770 VA: 0x181F88170 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F88240 Offset: 0x1F86840 VA: 0x181F88240 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModularVehicle previous) { }

	// RVA: 0x1F87C40 Offset: 0x1F86240 VA: 0x181F87C40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F87750 Offset: 0x1F85D50 VA: 0x181F87750
	public static ModularVehicle Deserialize(byte[] buffer, ModularVehicle instance, bool isDelta = False) { }

	// RVA: 0x1F87850 Offset: 0x1F85E50 VA: 0x181F87850
	public static ModularVehicle Deserialize(Stream stream, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F872A0 Offset: 0x1F858A0 VA: 0x181F872A0
	public static ModularVehicle DeserializeLengthDelimited(Stream stream, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F87550 Offset: 0x1F85B50 VA: 0x181F87550
	public static ModularVehicle DeserializeLength(Stream stream, int length, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F87D60 Offset: 0x1F86360 VA: 0x181F87D60
	public static void SerializeDelta(Stream stream, ModularVehicle instance, ModularVehicle previous) { }

	// RVA: 0x1F88090 Offset: 0x1F86690 VA: 0x181F88090
	public static void Serialize(Stream stream, ModularVehicle instance) { }

	// RVA: 0x1F88160 Offset: 0x1F86760 VA: 0x181F88160
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F88170 Offset: 0x1F86770 VA: 0x181F88170
	public void ToProto(Stream stream) { }

	// RVA: 0x1F87EE0 Offset: 0x1F864E0 VA: 0x181F87EE0
	public static byte[] SerializeToBytes(ModularVehicle instance) { }

	// RVA: 0x1F87E30 Offset: 0x1F86430 VA: 0x181F87E30
	public static void SerializeLengthDelimited(Stream stream, ModularVehicle instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1F869D0 Offset: 0x1F84FD0 VA: 0x181F869D0
	public static void ResetToPool(ModularCar instance) { }

	// RVA: 0x1F86900 Offset: 0x1F84F00 VA: 0x181F86900
	public void ResetToPool() { }

	// RVA: 0x1F86140 Offset: 0x1F84740 VA: 0x181F86140 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB3340 Offset: 0x1DB1940 VA: 0x181DB3340
	public void CopyTo(ModularCar instance) { }

	// RVA: 0x1F84730 Offset: 0x1F82D30 VA: 0x181F84730
	public ModularCar Copy() { }

	// RVA: 0x1F85B40 Offset: 0x1F84140 VA: 0x181F85B40
	public static ModularCar Deserialize(Stream stream) { }

	// RVA: 0x1F84B80 Offset: 0x1F83180 VA: 0x181F84B80
	public static ModularCar DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F84FA0 Offset: 0x1F835A0 VA: 0x181F84FA0
	public static ModularCar DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F85750 Offset: 0x1F83D50 VA: 0x181F85750
	public static ModularCar Deserialize(byte[] buffer) { }

	// RVA: 0x1F86290 Offset: 0x1F84890 VA: 0x181F86290
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F87170 Offset: 0x1F85770 VA: 0x181F87170 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F87190 Offset: 0x1F85790 VA: 0x181F87190 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModularCar previous) { }

	// RVA: 0x1F86570 Offset: 0x1F84B70 VA: 0x181F86570 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F85380 Offset: 0x1F83980 VA: 0x181F85380
	public static ModularCar Deserialize(byte[] buffer, ModularCar instance, bool isDelta = False) { }

	// RVA: 0x1F85E60 Offset: 0x1F84460 VA: 0x181F85E60
	public static ModularCar Deserialize(Stream stream, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F847C0 Offset: 0x1F82DC0 VA: 0x181F847C0
	public static ModularCar DeserializeLengthDelimited(Stream stream, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F84C00 Offset: 0x1F83200 VA: 0x181F84C00
	public static ModularCar DeserializeLength(Stream stream, int length, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F86AA0 Offset: 0x1F850A0 VA: 0x181F86AA0
	public static void SerializeDelta(Stream stream, ModularCar instance, ModularCar previous) { }

	// RVA: 0x1F86FA0 Offset: 0x1F855A0 VA: 0x181F86FA0
	public static void Serialize(Stream stream, ModularCar instance) { }

	// RVA: 0x1F87160 Offset: 0x1F85760 VA: 0x181F87160
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F87170 Offset: 0x1F85770 VA: 0x181F87170
	public void ToProto(Stream stream) { }

	// RVA: 0x1F86E90 Offset: 0x1F85490 VA: 0x181F86E90
	public static byte[] SerializeToBytes(ModularCar instance) { }

	// RVA: 0x1F86DE0 Offset: 0x1F853E0 VA: 0x181F86DE0
	public static void SerializeLengthDelimited(Stream stream, ModularCar instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1EFB050 Offset: 0x1EF9650 VA: 0x181EFB050
	public static void ResetToPool(VehicleLift instance) { }

	// RVA: 0x1EFB100 Offset: 0x1EF9700 VA: 0x181EFB100
	public void ResetToPool() { }

	// RVA: 0x1EFACA0 Offset: 0x1EF92A0 VA: 0x181EFACA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF9950 Offset: 0x1EF7F50 VA: 0x181EF9950
	public void CopyTo(VehicleLift instance) { }

	// RVA: 0x1EF9990 Offset: 0x1EF7F90 VA: 0x181EF9990
	public VehicleLift Copy() { }

	// RVA: 0x1EFA470 Offset: 0x1EF8A70 VA: 0x181EFA470
	public static VehicleLift Deserialize(Stream stream) { }

	// RVA: 0x1EF9A10 Offset: 0x1EF8010 VA: 0x181EF9A10
	public static VehicleLift DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFA0B0 Offset: 0x1EF86B0 VA: 0x181EFA0B0
	public static VehicleLift DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFA950 Offset: 0x1EF8F50 VA: 0x181EFA950
	public static VehicleLift Deserialize(byte[] buffer) { }

	// RVA: 0x1EFADE0 Offset: 0x1EF93E0 VA: 0x181EFADE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EFB6E0 Offset: 0x1EF9CE0 VA: 0x181EFB6E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EFB700 Offset: 0x1EF9D00 VA: 0x181EFB700 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleLift previous) { }

	// RVA: 0x1EFB030 Offset: 0x1EF9630 VA: 0x181EFB030 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFA140 Offset: 0x1EF8740 VA: 0x181EFA140
	public static VehicleLift Deserialize(byte[] buffer, VehicleLift instance, bool isDelta = False) { }

	// RVA: 0x1EFA700 Offset: 0x1EF8D00 VA: 0x181EFA700
	public static VehicleLift Deserialize(Stream stream, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EF9A90 Offset: 0x1EF8090 VA: 0x181EF9A90
	public static VehicleLift DeserializeLengthDelimited(Stream stream, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EF9DB0 Offset: 0x1EF83B0 VA: 0x181EF9DB0
	public static VehicleLift DeserializeLength(Stream stream, int length, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EFB1B0 Offset: 0x1EF97B0 VA: 0x181EFB1B0
	public static void SerializeDelta(Stream stream, VehicleLift instance, VehicleLift previous) { }

	// RVA: 0x1EFB560 Offset: 0x1EF9B60 VA: 0x181EFB560
	public static void Serialize(Stream stream, VehicleLift instance) { }

	// RVA: 0x1EFB6D0 Offset: 0x1EF9CD0 VA: 0x181EFB6D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EFB6E0 Offset: 0x1EF9CE0 VA: 0x181EFB6E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EFB450 Offset: 0x1EF9A50 VA: 0x181EFB450
	public static byte[] SerializeToBytes(VehicleLift instance) { }

	// RVA: 0x1EFB3A0 Offset: 0x1EF99A0 VA: 0x181EFB3A0
	public static void SerializeLengthDelimited(Stream stream, VehicleLift instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1E751D0 Offset: 0x1E737D0 VA: 0x181E751D0
	public static void ResetToPool(EngineStorage instance) { }

	// RVA: 0x1E75270 Offset: 0x1E73870 VA: 0x181E75270
	public void ResetToPool() { }

	// RVA: 0x1E74E70 Offset: 0x1E73470 VA: 0x181E74E70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E73C70 Offset: 0x1E72270 VA: 0x181E73C70
	public void CopyTo(EngineStorage instance) { }

	// RVA: 0x1E73CA0 Offset: 0x1E722A0 VA: 0x181E73CA0
	public EngineStorage Copy() { }

	// RVA: 0x1E743F0 Offset: 0x1E729F0 VA: 0x181E743F0
	public static EngineStorage Deserialize(Stream stream) { }

	// RVA: 0x1E74010 Offset: 0x1E72610 VA: 0x181E74010
	public static EngineStorage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E74090 Offset: 0x1E72690 VA: 0x181E74090
	public static EngineStorage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E74940 Offset: 0x1E72F40 VA: 0x181E74940
	public static EngineStorage Deserialize(byte[] buffer) { }

	// RVA: 0x1E74F90 Offset: 0x1E73590 VA: 0x181E74F90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E75840 Offset: 0x1E73E40 VA: 0x181E75840 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E75860 Offset: 0x1E73E60 VA: 0x181E75860 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EngineStorage previous) { }

	// RVA: 0x1E751B0 Offset: 0x1E737B0 VA: 0x181E751B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E74650 Offset: 0x1E72C50 VA: 0x181E74650
	public static EngineStorage Deserialize(byte[] buffer, EngineStorage instance, bool isDelta = False) { }

	// RVA: 0x1E74C50 Offset: 0x1E73250 VA: 0x181E74C50
	public static EngineStorage Deserialize(Stream stream, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E73D20 Offset: 0x1E72320 VA: 0x181E73D20
	public static EngineStorage DeserializeLengthDelimited(Stream stream, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E74120 Offset: 0x1E72720 VA: 0x181E74120
	public static EngineStorage DeserializeLength(Stream stream, int length, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E75310 Offset: 0x1E73910 VA: 0x181E75310
	public static void SerializeDelta(Stream stream, EngineStorage instance, EngineStorage previous) { }

	// RVA: 0x1E756E0 Offset: 0x1E73CE0 VA: 0x181E756E0
	public static void Serialize(Stream stream, EngineStorage instance) { }

	// RVA: 0x1E75830 Offset: 0x1E73E30 VA: 0x181E75830
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E75840 Offset: 0x1E73E40 VA: 0x181E75840
	public void ToProto(Stream stream) { }

	// RVA: 0x1E755D0 Offset: 0x1E73BD0 VA: 0x181E755D0
	public static byte[] SerializeToBytes(EngineStorage instance) { }

	// RVA: 0x1E75520 Offset: 0x1E73B20 VA: 0x181E75520
	public static void SerializeLengthDelimited(Stream stream, EngineStorage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class VehicleVendor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6378
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VehicleVendor.PlayerStorage> playerStorage; // 0x18
	public uint spawnerRef; // 0x20

	// Methods

	// RVA: 0x1EFD9C0 Offset: 0x1EFBFC0 VA: 0x181EFD9C0
	public static void ResetToPool(VehicleVendor instance) { }

	// RVA: 0x1EFDBA0 Offset: 0x1EFC1A0 VA: 0x181EFDBA0
	public void ResetToPool() { }

	// RVA: 0x1EFD900 Offset: 0x1EFBF00 VA: 0x181EFD900 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EFC9A0 Offset: 0x1EFAFA0 VA: 0x181EFC9A0
	public void CopyTo(VehicleVendor instance) { }

	// RVA: 0x1EFCB40 Offset: 0x1EFB140 VA: 0x181EFCB40
	public VehicleVendor Copy() { }

	// RVA: 0x1EFD780 Offset: 0x1EFBD80 VA: 0x181EFD780
	public static VehicleVendor Deserialize(Stream stream) { }

	// RVA: 0x1EFD040 Offset: 0x1EFB640 VA: 0x181EFD040
	public static VehicleVendor DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFD3A0 Offset: 0x1EFB9A0 VA: 0x181EFD3A0
	public static VehicleVendor DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFD430 Offset: 0x1EFBA30 VA: 0x181EFD430
	public static VehicleVendor Deserialize(byte[] buffer) { }

	// RVA: 0x1EFD980 Offset: 0x1EFBF80 VA: 0x181EFD980
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EFE3D0 Offset: 0x1EFC9D0 VA: 0x181EFE3D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EFE3F0 Offset: 0x1EFC9F0 VA: 0x181EFE3F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor previous) { }

	// RVA: 0x1EFD9A0 Offset: 0x1EFBFA0 VA: 0x181EFD9A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFD800 Offset: 0x1EFBE00 VA: 0x181EFD800
	public static VehicleVendor Deserialize(byte[] buffer, VehicleVendor instance, bool isDelta = False) { }

	// RVA: 0x1EFD550 Offset: 0x1EFBB50 VA: 0x181EFD550
	public static VehicleVendor Deserialize(Stream stream, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EFCD30 Offset: 0x1EFB330 VA: 0x181EFCD30
	public static VehicleVendor DeserializeLengthDelimited(Stream stream, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EFD0C0 Offset: 0x1EFB6C0 VA: 0x181EFD0C0
	public static VehicleVendor DeserializeLength(Stream stream, int length, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EFDD80 Offset: 0x1EFC380 VA: 0x181EFDD80
	public static void SerializeDelta(Stream stream, VehicleVendor instance, VehicleVendor previous) { }

	// RVA: 0x1EFE190 Offset: 0x1EFC790 VA: 0x181EFE190
	public static void Serialize(Stream stream, VehicleVendor instance) { }

	// RVA: 0x1EFE3C0 Offset: 0x1EFC9C0 VA: 0x181EFE3C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EFE3D0 Offset: 0x1EFC9D0 VA: 0x181EFE3D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EFE080 Offset: 0x1EFC680 VA: 0x181EFE080
	public static byte[] SerializeToBytes(VehicleVendor instance) { }

	// RVA: 0x1EFDFD0 Offset: 0x1EFC5D0 VA: 0x181EFDFD0
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class VehicleVendor.PlayerStorage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6379
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong userid; // 0x18
	public List<VehicleVendor.PlayerStorage.PlayerStoredVehicle> storedVehicles; // 0x20

	// Methods

	// RVA: 0x1EE6CA0 Offset: 0x1EE52A0 VA: 0x181EE6CA0
	public static void ResetToPool(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE6E60 Offset: 0x1EE5460 VA: 0x181EE6E60
	public void ResetToPool() { }

	// RVA: 0x1EE6BE0 Offset: 0x1EE51E0 VA: 0x181EE6BE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE5DE0 Offset: 0x1EE43E0 VA: 0x181EE5DE0
	public void CopyTo(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE5F90 Offset: 0x1EE4590 VA: 0x181EE5F90
	public VehicleVendor.PlayerStorage Copy() { }

	// RVA: 0x1EE6940 Offset: 0x1EE4F40 VA: 0x181EE6940
	public static VehicleVendor.PlayerStorage Deserialize(Stream stream) { }

	// RVA: 0x1EE6320 Offset: 0x1EE4920 VA: 0x181EE6320
	public static VehicleVendor.PlayerStorage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE63A0 Offset: 0x1EE49A0 VA: 0x181EE63A0
	public static VehicleVendor.PlayerStorage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE69C0 Offset: 0x1EE4FC0 VA: 0x181EE69C0
	public static VehicleVendor.PlayerStorage Deserialize(byte[] buffer) { }

	// RVA: 0x1EE6C60 Offset: 0x1EE5260 VA: 0x181EE6C60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EE7650 Offset: 0x1EE5C50 VA: 0x181EE7650 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EE7670 Offset: 0x1EE5C70 VA: 0x181EE7670 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor.PlayerStorage previous) { }

	// RVA: 0x1EE6C80 Offset: 0x1EE5280 VA: 0x181EE6C80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE6AE0 Offset: 0x1EE50E0 VA: 0x181EE6AE0
	public static VehicleVendor.PlayerStorage Deserialize(byte[] buffer, VehicleVendor.PlayerStorage instance, bool isDelta = False) { }

	// RVA: 0x1EE6710 Offset: 0x1EE4D10 VA: 0x181EE6710
	public static VehicleVendor.PlayerStorage Deserialize(Stream stream, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE6010 Offset: 0x1EE4610 VA: 0x181EE6010
	public static VehicleVendor.PlayerStorage DeserializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE6430 Offset: 0x1EE4A30 VA: 0x181EE6430
	public static VehicleVendor.PlayerStorage DeserializeLength(Stream stream, int length, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE7020 Offset: 0x1EE5620 VA: 0x181EE7020
	public static void SerializeDelta(Stream stream, VehicleVendor.PlayerStorage instance, VehicleVendor.PlayerStorage previous) { }

	// RVA: 0x1EE7420 Offset: 0x1EE5A20 VA: 0x181EE7420
	public static void Serialize(Stream stream, VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE7640 Offset: 0x1EE5C40 VA: 0x181EE7640
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EE7650 Offset: 0x1EE5C50 VA: 0x181EE7650
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE7310 Offset: 0x1EE5910 VA: 0x181EE7310
	public static byte[] SerializeToBytes(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE7260 Offset: 0x1EE5860 VA: 0x181EE7260
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1EE8A30 Offset: 0x1EE7030 VA: 0x181EE8A30
	public static void ResetToPool(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE8960 Offset: 0x1EE6F60 VA: 0x181EE8960
	public void ResetToPool() { }

	// RVA: 0x1EE86F0 Offset: 0x1EE6CF0 VA: 0x181EE86F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE7690 Offset: 0x1EE5C90 VA: 0x181EE7690
	public void CopyTo(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE76E0 Offset: 0x1EE5CE0 VA: 0x181EE76E0
	public VehicleVendor.PlayerStorage.PlayerStoredVehicle Copy() { }

	// RVA: 0x1EE8220 Offset: 0x1EE6820 VA: 0x181EE8220
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(Stream stream) { }

	// RVA: 0x1EE7A20 Offset: 0x1EE6020 VA: 0x181EE7A20
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE7D20 Offset: 0x1EE6320 VA: 0x181EE7D20
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE8430 Offset: 0x1EE6A30 VA: 0x181EE8430
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1EE8770 Offset: 0x1EE6D70 VA: 0x181EE8770
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EE9090 Offset: 0x1EE7690 VA: 0x181EE9090 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EE90B0 Offset: 0x1EE76B0 VA: 0x181EE90B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle previous) { }

	// RVA: 0x1EE8940 Offset: 0x1EE6F40 VA: 0x181EE8940 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE7DB0 Offset: 0x1EE63B0 VA: 0x181EE7DB0
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(byte[] buffer, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta = False) { }

	// RVA: 0x1EE8050 Offset: 0x1EE6650 VA: 0x181EE8050
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE7780 Offset: 0x1EE5D80 VA: 0x181EE7780
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE7AA0 Offset: 0x1EE60A0 VA: 0x181EE7AA0
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLength(Stream stream, int length, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE8B00 Offset: 0x1EE7100 VA: 0x181EE8B00
	public static void SerializeDelta(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, VehicleVendor.PlayerStorage.PlayerStoredVehicle previous) { }

	// RVA: 0x1EE8ED0 Offset: 0x1EE74D0 VA: 0x181EE8ED0
	public static void Serialize(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE9080 Offset: 0x1EE7680 VA: 0x181EE9080
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EE9090 Offset: 0x1EE7690 VA: 0x181EE9090
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE8DC0 Offset: 0x1EE73C0 VA: 0x181EE8DC0
	public static byte[] SerializeToBytes(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE8D10 Offset: 0x1EE7310 VA: 0x181EE8D10
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class VehicleModule : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6385
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int socketIndex; // 0x14

	// Methods

	// RVA: 0x1EFC1D0 Offset: 0x1EFA7D0 VA: 0x181EFC1D0
	public static void ResetToPool(VehicleModule instance) { }

	// RVA: 0x1EFC250 Offset: 0x1EFA850 VA: 0x181EFC250
	public void ResetToPool() { }

	// RVA: 0x1EFC0A0 Offset: 0x1EFA6A0 VA: 0x181EFC0A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(VehicleModule instance) { }

	// RVA: 0x1EFB720 Offset: 0x1EF9D20 VA: 0x181EFB720
	public VehicleModule Copy() { }

	// RVA: 0x1EFC020 Offset: 0x1EFA620 VA: 0x181EFC020
	public static VehicleModule Deserialize(Stream stream) { }

	// RVA: 0x1EFB790 Offset: 0x1EF9D90 VA: 0x181EFB790
	public static VehicleModule DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFBC30 Offset: 0x1EFA230 VA: 0x181EFBC30
	public static VehicleModule DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFBF00 Offset: 0x1EFA500 VA: 0x181EFBF00
	public static VehicleModule Deserialize(byte[] buffer) { }

	// RVA: 0x1EFC190 Offset: 0x1EFA790 VA: 0x181EFC190
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EFC720 Offset: 0x1EFAD20 VA: 0x181EFC720 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EFC7F0 Offset: 0x1EFADF0 VA: 0x181EFC7F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleModule previous) { }

	// RVA: 0x1EFC1B0 Offset: 0x1EFA7B0 VA: 0x181EFC1B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFBCC0 Offset: 0x1EFA2C0 VA: 0x181EFBCC0
	public static VehicleModule Deserialize(byte[] buffer, VehicleModule instance, bool isDelta = False) { }

	// RVA: 0x1EFBDC0 Offset: 0x1EFA3C0 VA: 0x181EFBDC0
	public static VehicleModule Deserialize(Stream stream, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EFB810 Offset: 0x1EF9E10 VA: 0x181EFB810
	public static VehicleModule DeserializeLengthDelimited(Stream stream, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EFBA30 Offset: 0x1EFA030 VA: 0x181EFBA30
	public static VehicleModule DeserializeLength(Stream stream, int length, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EFC2D0 Offset: 0x1EFA8D0 VA: 0x181EFC2D0
	public static void SerializeDelta(Stream stream, VehicleModule instance, VehicleModule previous) { }

	// RVA: 0x1EFC640 Offset: 0x1EFAC40 VA: 0x181EFC640
	public static void Serialize(Stream stream, VehicleModule instance) { }

	// RVA: 0x1EFC710 Offset: 0x1EFAD10 VA: 0x181EFC710
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EFC720 Offset: 0x1EFAD20 VA: 0x181EFC720
	public void ToProto(Stream stream) { }

	// RVA: 0x1EFC490 Offset: 0x1EFAA90 VA: 0x181EFC490
	public static byte[] SerializeToBytes(VehicleModule instance) { }

	// RVA: 0x1EFC3E0 Offset: 0x1EFA9E0 VA: 0x181EFC3E0
	public static void SerializeLengthDelimited(Stream stream, VehicleModule instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1F74F40 Offset: 0x1F73540 VA: 0x181F74F40
	public static void ResetToPool(CamperModule instance) { }

	// RVA: 0x1F74FD0 Offset: 0x1F735D0 VA: 0x181F74FD0
	public void ResetToPool() { }

	// RVA: 0x1F74C60 Offset: 0x1F73260 VA: 0x181F74C60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28460 Offset: 0x1E26A60 VA: 0x181E28460
	public void CopyTo(CamperModule instance) { }

	// RVA: 0x1F73D30 Offset: 0x1F72330 VA: 0x181F73D30
	public CamperModule Copy() { }

	// RVA: 0x1F74550 Offset: 0x1F72B50 VA: 0x181F74550
	public static CamperModule Deserialize(Stream stream) { }

	// RVA: 0x1F73DB0 Offset: 0x1F723B0 VA: 0x181F73DB0
	public static CamperModule DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F740B0 Offset: 0x1F726B0 VA: 0x181F740B0
	public static CamperModule DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F74740 Offset: 0x1F72D40 VA: 0x181F74740
	public static CamperModule Deserialize(byte[] buffer) { }

	// RVA: 0x1F74D70 Offset: 0x1F73370 VA: 0x181F74D70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F75510 Offset: 0x1F73B10 VA: 0x181F75510 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F75530 Offset: 0x1F73B30 VA: 0x181F75530 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CamperModule previous) { }

	// RVA: 0x1F74F20 Offset: 0x1F73520 VA: 0x181F74F20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F749E0 Offset: 0x1F72FE0 VA: 0x181F749E0
	public static CamperModule Deserialize(byte[] buffer, CamperModule instance, bool isDelta = False) { }

	// RVA: 0x1F743A0 Offset: 0x1F729A0 VA: 0x181F743A0
	public static CamperModule Deserialize(Stream stream, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F73E30 Offset: 0x1F72430 VA: 0x181F73E30
	public static CamperModule DeserializeLengthDelimited(Stream stream, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F74140 Offset: 0x1F72740 VA: 0x181F74140
	public static CamperModule DeserializeLength(Stream stream, int length, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F75060 Offset: 0x1F73660 VA: 0x181F75060
	public static void SerializeDelta(Stream stream, CamperModule instance, CamperModule previous) { }

	// RVA: 0x1F753E0 Offset: 0x1F739E0 VA: 0x181F753E0
	public static void Serialize(Stream stream, CamperModule instance) { }

	// RVA: 0x1F75500 Offset: 0x1F73B00 VA: 0x181F75500
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F75510 Offset: 0x1F73B10 VA: 0x181F75510
	public void ToProto(Stream stream) { }

	// RVA: 0x1F752D0 Offset: 0x1F738D0 VA: 0x181F752D0
	public static byte[] SerializeToBytes(CamperModule instance) { }

	// RVA: 0x1F75220 Offset: 0x1F73820 VA: 0x181F75220
	public static void SerializeLengthDelimited(Stream stream, CamperModule instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x9359D0 Offset: 0x933FD0 VA: 0x1809359D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x936C40 Offset: 0x935240 VA: 0x180936C40 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x936760 Offset: 0x934D60 VA: 0x180936760 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x936980 Offset: 0x934F80 VA: 0x180936980 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x935960 Offset: 0x933F60 VA: 0x180935960 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9368F0 Offset: 0x934EF0 VA: 0x1809368F0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 186
	public virtual void InitializeClientEffects() { }

	// RVA: 0x9359B0 Offset: 0x933FB0 VA: 0x1809359B0 Slot: 187
	public virtual float GetHUDHealth() { }

	// RVA: 0x934E90 Offset: 0x933490 VA: 0x180934E90 Slot: 188
	public virtual float GetHUDMaxHealth() { }

	// RVA: 0x936320 Offset: 0x934920 VA: 0x180936320 Slot: 169
	public override bool LocalPlayerIsMounted() { }

	// RVA: 0x936560 Offset: 0x934B60 VA: 0x180936560 Slot: 189
	public virtual bool Menu_Push_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	[BaseEntity.Menu.Description] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	[BaseEntity.Menu.Icon] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	[BaseEntity.Menu.ShowIf] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x936470 Offset: 0x934A70 VA: 0x180936470 Slot: 190
	protected virtual bool Menu_Occupied_ShowIf(BasePlayer player) { }

	// RVA: 0x9363E0 Offset: 0x9349E0 VA: 0x1809363E0 Slot: 183
	public override bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x936B70 Offset: 0x935170 VA: 0x180936B70 Slot: 191
	protected virtual void WorkshopMode() { }

	// RVA: 0x8CE600 Offset: 0x8CCC00 VA: 0x1808CE600
	public bool IsStationary() { }

	// RVA: 0x936300 Offset: 0x934900 VA: 0x180936300
	public bool IsMoving() { }

	// RVA: 0x936D10 Offset: 0x935310 VA: 0x180936D10
	public bool get_IsMovingOrOn() { }

	// RVA: 0x936D50 Offset: 0x935350 VA: 0x180936D50 Slot: 76
	public override float get_RealisticMass() { }

	// RVA: 0x936850 Offset: 0x934E50 VA: 0x180936850 Slot: 157
	public override bool PlayerIsMounted(BasePlayer player) { }

	// RVA: 0x6FDC20 Offset: 0x6FC220 VA: 0x1806FDC20 Slot: 192
	protected virtual bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x936010 Offset: 0x934610 VA: 0x180936010
	public bool HasMountPoints() { }

	// RVA: 0x9362A0 Offset: 0x9348A0 VA: 0x1809362A0 Slot: 153
	public override bool IsMounted() { }

	// RVA: 0x9358D0 Offset: 0x933ED0 VA: 0x1809358D0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x9361D0 Offset: 0x9347D0 VA: 0x1809361D0
	public bool IsFlipped() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 193
	public virtual bool IsVehicleRoot() { }

	// RVA: 0x935990 Offset: 0x933F90 VA: 0x180935990 Slot: 147
	public override bool DirectlyMountable() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 170
	public override BaseVehicle VehicleParent() { }

	// RVA: 0x936580 Offset: 0x934B80 VA: 0x180936580 Slot: 22
	protected override void OnChildAdded(BaseEntity child) { }

	// RVA: 0x936690 Offset: 0x934C90 VA: 0x180936690 Slot: 23
	protected override void OnChildRemoved(BaseEntity child) { }

	// RVA: 0x936DF0 Offset: 0x9353F0 VA: 0x180936DF0
	public BaseVehicle.Enumerable get_allMountPoints() { }

	// RVA: 0x935CE0 Offset: 0x9342E0 VA: 0x180935CE0
	public BaseVehicle.MountPointInfo GetMountPoint(int index) { }

	// RVA: 0x936B90 Offset: 0x935190 VA: 0x180936B90
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

	// RVA: 0x93A7F0 Offset: 0x938DF0 VA: 0x18093A7F0
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

	// RVA: 0x93A0A0 Offset: 0x9386A0 VA: 0x18093A0A0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x93A0A0 Offset: 0x9386A0 VA: 0x18093A0A0 Slot: 5
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

	// RVA: 0x9329D0 Offset: 0x930FD0 VA: 0x1809329D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x935140 Offset: 0x933740 VA: 0x180935140 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x933D00 Offset: 0x932300 VA: 0x180933D00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x932280 Offset: 0x930880 VA: 0x180932280 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x932530 Offset: 0x930B30 VA: 0x180932530 Slot: 194
	public virtual void ClientVehicleTick() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 195
	public virtual void OnClientTickStopped() { }

	// RVA: 0x932300 Offset: 0x930900 VA: 0x180932300 Slot: 196
	public virtual void ClientOnLoad() { }

	// RVA: 0x932690 Offset: 0x930C90 VA: 0x180932690 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x934E10 Offset: 0x933410 VA: 0x180934E10
	public void SetLightState(bool headlightsOn, bool brakesOn) { }

	// RVA: 0x932090 Offset: 0x930690 VA: 0x180932090
	public void ClearDecals(BaseVehicleModule.DecalType decalType) { }

	// RVA: 0x932700 Offset: 0x930D00 VA: 0x180932700
	public void DrawHighlight() { }

	// RVA: 0x933580 Offset: 0x931B80 VA: 0x180933580 Slot: 183
	public override bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Description] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Icon] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	// RVA: 0x933700 Offset: 0x931D00 VA: 0x180933700
	public void Menu_Push(BasePlayer player) { }

	// RVA: 0x933650 Offset: 0x931C50 VA: 0x180933650 Slot: 189
	public override bool Menu_Push_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	[BaseEntity.Menu.Description] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	[BaseEntity.Menu.Icon] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	[BaseEntity.Menu.ShowIf] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	// RVA: 0x933AA0 Offset: 0x9320A0 VA: 0x180933AA0
	public void Menu_Use(BasePlayer player) { }

	// RVA: 0x9337A0 Offset: 0x931DA0 VA: 0x1809337A0
	public bool Menu_Use_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	[BaseEntity.Menu.Description] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	[BaseEntity.Menu.Icon] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	[BaseEntity.Menu.ShowIf] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Locked(BasePlayer player) { }

	// RVA: 0x933430 Offset: 0x931A30 VA: 0x180933430 Slot: 197
	public virtual bool Menu_Locked_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935340 Offset: 0x933940 VA: 0x180935340
	public BaseModularVehicle get_Vehicle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935360 Offset: 0x933960 VA: 0x180935360
	private void set_Vehicle(BaseModularVehicle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935130 Offset: 0x933730 VA: 0x180935130
	public int get_FirstSocketIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935350 Offset: 0x933950 VA: 0x180935350
	private void set_FirstSocketIndex(int value) { }

	// RVA: 0x9350F0 Offset: 0x9336F0 VA: 0x1809350F0
	public Vector3 get_CentreOfMass() { }

	// RVA: 0x935330 Offset: 0x933930 VA: 0x180935330
	public float get_Mass() { }

	// RVA: 0x52EEF0 Offset: 0x52D4F0 VA: 0x18052EEF0
	public uint get_ID() { }

	// RVA: 0x9352D0 Offset: 0x9338D0 VA: 0x1809352D0
	public bool get_IsOnAVehicle() { }

	// RVA: 0x77AA30 Offset: 0x779030 VA: 0x18077AA30
	public ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 198
	public virtual bool get_HasSeating() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 199
	public virtual bool get_HasAnEngine() { }

	// RVA: 0x933E30 Offset: 0x932430 VA: 0x180933E30 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x934C10 Offset: 0x933210 VA: 0x180934C10
	public void RefreshParameters() { }

	// RVA: 0x933C40 Offset: 0x932240 VA: 0x180933C40 Slot: 200
	public virtual void ModuleAdded(BaseModularVehicle vehicle, int firstSocketIndex) { }

	// RVA: 0x933CD0 Offset: 0x9322D0 VA: 0x180933CD0 Slot: 201
	public virtual void ModuleRemoved() { }

	// RVA: 0x933DF0 Offset: 0x9323F0 VA: 0x180933DF0
	public void OtherVehicleModulesChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 202
	public virtual void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState) { }

	// RVA: 0x933390 Offset: 0x931990 VA: 0x180933390 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x934E90 Offset: 0x933490 VA: 0x180934E90 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x933180 Offset: 0x931780 VA: 0x180933180
	public int GetNumSocketsTaken() { }

	// RVA: 0x932830 Offset: 0x930E30 VA: 0x180932830
	public List<ConditionalObject> GetConditionals() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 203
	public virtual float GetMaxDriveForce() { }

	// RVA: 0x9349F0 Offset: 0x932FF0 VA: 0x1809349F0
	public void RefreshConditionals(bool canGib) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 204
	protected virtual void PostConditionalRefresh() { }

	// RVA: 0x933F10 Offset: 0x932510 VA: 0x180933F10
	private void RefreshConditional(ConditionalObject conditional, bool canGib) { }

	// RVA: 0x935000 Offset: 0x933600 VA: 0x180935000
	private bool TryGetAdjacentModuleInFront(out BaseVehicleModule result) { }

	// RVA: 0x934EB0 Offset: 0x9334B0 VA: 0x180934EB0
	private bool TryGetAdjacentModuleBehind(out BaseVehicleModule result) { }

	// RVA: 0x933220 Offset: 0x931820 VA: 0x180933220
	private bool InSameVisualGroupAs(BaseVehicleModule moduleEntity, ConditionalObject.AdjacentMatchType matchType) { }

	// RVA: 0x931F30 Offset: 0x930530 VA: 0x180931F30
	private bool CanBeUsedNowBy(BasePlayer player) { }

	// RVA: 0x933E00 Offset: 0x932400 VA: 0x180933E00
	public bool PlayerIsLookingAtUsable(string lookingAtColldierName, string usableColliderName) { }

	// RVA: 0x933320 Offset: 0x931920 VA: 0x180933320 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 193
	public override bool IsVehicleRoot() { }

	// RVA: 0x9350C0 Offset: 0x9336C0 VA: 0x1809350C0
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

	// RVA: 0x8C34E0 Offset: 0x8C1AE0 VA: 0x1808C34E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8C3BE0 Offset: 0x8C21E0 VA: 0x1808C3BE0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8C3A90 Offset: 0x8C2090 VA: 0x1808C3A90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	[BaseEntity.Menu.Description] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	[BaseEntity.Menu.Icon] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	[BaseEntity.Menu.ShowIf] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	// RVA: 0x8C3A10 Offset: 0x8C2010 VA: 0x1808C3A10
	public void Menu_StartEngine(BasePlayer player) { }

	// RVA: 0x50DF50 Offset: 0x50C550 VA: 0x18050DF50
	public bool Menu_EngineOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	[BaseEntity.Menu.Description] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	[BaseEntity.Menu.Icon] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	[BaseEntity.Menu.ShowIf] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	// RVA: 0x8C3A50 Offset: 0x8C2050 VA: 0x1808C3A50
	public void Menu_StopEngine(BasePlayer player) { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool Menu_EngineOff_ShowIf(BasePlayer player) { }

	// RVA: 0x8C3B80 Offset: 0x8C2180 VA: 0x1808C3B80
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

	// RVA: 0x7784B0 Offset: 0x776AB0 VA: 0x1807784B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x77AA60 Offset: 0x779060 VA: 0x18077AA60 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7799E0 Offset: 0x777FE0 VA: 0x1807799E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AC10 Offset: 0x779210 VA: 0x18077AC10
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFL() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AC50 Offset: 0x779250 VA: 0x18077AC50
	private void set_WheelDataFL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AC20 Offset: 0x779220 VA: 0x18077AC20
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFR() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AC60 Offset: 0x779260 VA: 0x18077AC60
	private void set_WheelDataFR(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AC30 Offset: 0x779230 VA: 0x18077AC30
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRL() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AC70 Offset: 0x779270 VA: 0x18077AC70
	private void set_WheelDataRL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AC40 Offset: 0x779240 VA: 0x18077AC40
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRR() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AC80 Offset: 0x779280 VA: 0x18077AC80
	private void set_WheelDataRR(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	// RVA: 0x777B60 Offset: 0x776160 VA: 0x180777B60 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x779890 Offset: 0x777E90 VA: 0x180779890 Slot: 132
	protected override void OnLifeStateChanged() { }

	// RVA: 0x777F70 Offset: 0x776570 VA: 0x180777F70 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x778B60 Offset: 0x777160 VA: 0x180778B60
	public bool HasAnEngineAtLowPerformance() { }

	// RVA: 0x778D70 Offset: 0x777370 VA: 0x180778D70
	public bool HasLowFuel() { }

	// RVA: 0x778B20 Offset: 0x777120 VA: 0x180778B20
	public bool HadRecentFailedEngineStart() { }

	// RVA: 0x77A6A0 Offset: 0x778CA0 VA: 0x18077A6A0 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0x778A40 Offset: 0x777040 VA: 0x180778A40 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0x7797D0 Offset: 0x777DD0 VA: 0x1807797D0 Slot: 201
	protected override void OnClientTickStopped() { }

	// RVA: 0x778E20 Offset: 0x777420 VA: 0x180778E20 Slot: 204
	protected override bool IsBraking() { }

	[BaseEntity.Menu] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Description] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Icon] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	// RVA: 0x779140 Offset: 0x777740 VA: 0x180779140
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x779070 Offset: 0x777670 VA: 0x180779070
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	[BaseEntity.Menu.Description] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	[BaseEntity.Menu.Icon] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	[BaseEntity.Menu.ShowIf] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Locked(BasePlayer player) { }

	// RVA: 0x779180 Offset: 0x777780 VA: 0x180779180
	public bool Menu_Locked_ShowIf(BasePlayer player) { }

	// RVA: 0x7795E0 Offset: 0x777BE0 VA: 0x1807795E0 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x778060 Offset: 0x776660 VA: 0x180778060 Slot: 187
	public override float GetHUDHealth() { }

	// RVA: 0x778130 Offset: 0x776730 VA: 0x180778130 Slot: 188
	public override float GetHUDMaxHealth() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x779260 Offset: 0x777860 VA: 0x180779260
	private void ModularCarUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x777FA0 Offset: 0x7765A0 VA: 0x180777FA0
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x77AA50 Offset: 0x779050 VA: 0x18077AA50 Slot: 196
	public override float get_DriveWheelVelocity() { }

	// RVA: 0x77AA40 Offset: 0x779040 VA: 0x18077AA40
	public float get_DriveWheelSlip() { }

	// RVA: 0x77AC00 Offset: 0x779200 VA: 0x18077AC00 Slot: 215
	public float get_SteerAngle() { }

	// RVA: 0x77AA30 Offset: 0x779030 VA: 0x18077AA30
	public ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0x77ABE0 Offset: 0x7791E0 VA: 0x18077ABE0 Slot: 216
	public float get_MaxSteerAngle() { }

	// RVA: 0x77ABB0 Offset: 0x7791B0 VA: 0x18077ABB0 Slot: 206
	public override bool get_IsLockable() { }

	// RVA: 0x77A360 Offset: 0x778960 VA: 0x18077A360 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x778D90 Offset: 0x777390 VA: 0x180778D90 Slot: 28
	public override void InitShared() { }

	// RVA: 0x779040 Offset: 0x777640 VA: 0x180779040 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x779040 Offset: 0x777640 VA: 0x180779040 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x778060 Offset: 0x776660 VA: 0x180778060
	public float TotalHealth() { }

	// RVA: 0x778130 Offset: 0x776730 VA: 0x180778130
	public float TotalMaxHealth() { }

	// RVA: 0x778320 Offset: 0x776920 VA: 0x180778320 Slot: 197
	public override float GetMaxForwardSpeed() { }

	// RVA: 0x778E50 Offset: 0x777450 VA: 0x180778E50 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x779850 Offset: 0x777E50 VA: 0x180779850 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x778A10 Offset: 0x777010 VA: 0x180778A10 Slot: 198
	public override float GetThrottleInput() { }

	// RVA: 0x778020 Offset: 0x776620 VA: 0x180778020 Slot: 199
	public override float GetBrakeInput() { }

	// RVA: 0x778200 Offset: 0x776800 VA: 0x180778200
	public float GetMaxDriveForce() { }

	// RVA: 0x778050 Offset: 0x776650 VA: 0x180778050
	public float GetFuelFraction() { }

	// RVA: 0x77A330 Offset: 0x778930 VA: 0x18077A330 Slot: 210
	public bool PlayerHasUnlockPermission(BasePlayer player) { }

	// RVA: 0x77A2D0 Offset: 0x7788D0 VA: 0x18077A2D0 Slot: 207
	public override bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0x77A280 Offset: 0x778880 VA: 0x18077A280 Slot: 212
	public bool PlayerCanDestroyLock(BasePlayer player, BaseVehicleModule viaModule) { }

	// RVA: 0x7779E0 Offset: 0x775FE0 VA: 0x1807779E0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x777AF0 Offset: 0x7760F0 VA: 0x180777AF0 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x77A460 Offset: 0x778A60 VA: 0x18077A460
	protected bool RefreshEngineState() { }

	// RVA: 0x77A630 Offset: 0x778C30 VA: 0x18077A630
	private float RollOffDriveForce(float driveForce) { }

	// RVA: 0x77A410 Offset: 0x778A10 VA: 0x18077A410
	private void RefreshChassisProtectionState() { }

	// RVA: 0x779380 Offset: 0x777980 VA: 0x180779380 Slot: 208
	protected override void ModuleEntityAdded(BaseVehicleModule addedModule) { }

	// RVA: 0x7794B0 Offset: 0x777AB0 VA: 0x1807794B0 Slot: 209
	protected override void ModuleEntityRemoved(BaseVehicleModule removedModule) { }

	// RVA: 0x77AA10 Offset: 0x779010 VA: 0x18077AA10
	public void .ctor() { }

	// RVA: 0x77A9A0 Offset: 0x778FA0 VA: 0x18077A9A0
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

	// RVA: 0x77EAA0 Offset: 0x77D0A0 VA: 0x18077EAA0
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

	// RVA: 0x775600 Offset: 0x773C00 VA: 0x180775600 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x776CC0 Offset: 0x7752C0 VA: 0x180776CC0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7763B0 Offset: 0x7749B0 VA: 0x1807763B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x775460 Offset: 0x773A60 VA: 0x180775460 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x776A60 Offset: 0x775060 VA: 0x180776A60
	public void TryRepair(uint itemUID) { }

	// RVA: 0x775B50 Offset: 0x774150 VA: 0x180775B50 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x775590 Offset: 0x773B90 VA: 0x180775590
	public void ClientSelectedLootItem(Item item) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 165
	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x7764A0 Offset: 0x774AA0 VA: 0x1807764A0
	private bool PlayerHasInternalModuleLoot() { }

	// RVA: 0x7754D0 Offset: 0x773AD0 VA: 0x1807754D0
	public void ClientRequestAddLock() { }

	// RVA: 0x775550 Offset: 0x773B50 VA: 0x180775550
	public void ClientRequestRemoveLock() { }

	// RVA: 0x775510 Offset: 0x773B10 VA: 0x180775510
	public void ClientRequestNewKey() { }

	// RVA: 0x776760 Offset: 0x774D60 VA: 0x180776760
	private void RefreshPoweredLightState() { }

	// RVA: 0x7766D0 Offset: 0x774CD0 VA: 0x1807766D0
	private void RefreshInUseLightState() { }

	[BaseEntity.Menu] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	[BaseEntity.Menu.Description] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	[BaseEntity.Menu.Icon] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	[BaseEntity.Menu.ShowIf] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	// RVA: 0x775E80 Offset: 0x774480 VA: 0x180775E80
	public void Menu_EditVehicle(BasePlayer player) { }

	// RVA: 0x775D80 Offset: 0x774380 VA: 0x180775D80
	public bool Menu_EditVehicle_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	[BaseEntity.Menu.Description] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	[BaseEntity.Menu.Icon] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	[BaseEntity.Menu.ShowIf] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_InsufficientPower(BasePlayer player) { }

	// RVA: 0x775EC0 Offset: 0x7744C0 VA: 0x180775EC0
	public bool Menu_InsufficientPower_ShowIf(BasePlayer player) { }

	// RVA: 0x776860 Offset: 0x774E60 VA: 0x180776860
	public void StartChassisDestroy() { }

	// RVA: 0x775400 Offset: 0x773A00 VA: 0x180775400
	public void CancelChassisDestroy() { }

	// RVA: 0x776E90 Offset: 0x775490 VA: 0x180776E90
	public float get_TimeLeftToCancelChassisDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776E80 Offset: 0x775480 VA: 0x180776E80
	public bool get_PlatformIsOccupied() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776F70 Offset: 0x775570 VA: 0x180776F70
	private void set_PlatformIsOccupied(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776CB0 Offset: 0x7752B0 VA: 0x180776CB0
	public bool get_HasEditableOccupant() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776F40 Offset: 0x775540 VA: 0x180776F40
	private void set_HasEditableOccupant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776CA0 Offset: 0x7752A0 VA: 0x180776CA0
	public bool get_HasDriveableOccupant() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776F30 Offset: 0x775530 VA: 0x180776F30
	private void set_HasDriveableOccupant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776E70 Offset: 0x775470 VA: 0x180776E70
	public ModularCarGarage.OccupantLock get_OccupantLockState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776F60 Offset: 0x775560 VA: 0x180776F60
	private void set_OccupantLockState(ModularCarGarage.OccupantLock value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776E60 Offset: 0x775460 VA: 0x180776E60
	public int get_OccupantLockID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776F50 Offset: 0x775550 VA: 0x180776F50
	private void set_OccupantLockID(int value) { }

	// RVA: 0x776E50 Offset: 0x775450 VA: 0x180776E50
	private bool get_LiftIsUp() { }

	// RVA: 0x776E20 Offset: 0x775420 VA: 0x180776E20
	private bool get_LiftIsMoving() { }

	// RVA: 0x776E10 Offset: 0x775410 VA: 0x180776E10
	private bool get_LiftIsDown() { }

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool get_IsDestroyingChassis() { }

	// RVA: 0x776670 Offset: 0x774C70 VA: 0x180776670 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x776350 Offset: 0x774950 VA: 0x180776350 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5B0430 Offset: 0x5AEA30 VA: 0x1805B0430 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x6F3500 Offset: 0x6F1B00 VA: 0x1806F3500 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x7767A0 Offset: 0x774DA0 VA: 0x1807767A0
	private void SetOccupantState(bool hasOccupant, bool editableOccupant, bool driveableOccupant, ModularCarGarage.OccupantLock occupantLockState, int occupantLockID, bool forced = False) { }

	// RVA: 0x776700 Offset: 0x774D00 VA: 0x180776700
	private void RefreshLiftState(bool forced = False) { }

	// RVA: 0x7761B0 Offset: 0x7747B0 VA: 0x1807761B0
	private void MoveLift(ModularCarGarage.VehicleLiftState desiredLiftState, float startDelay = 0, bool forced = False) { }

	// RVA: 0x776130 Offset: 0x774730 VA: 0x180776130
	private void MoveLiftUp() { }

	// RVA: 0x775F80 Offset: 0x774580 VA: 0x180775F80
	private void MoveLiftDown() { }

	// RVA: 0x7768B0 Offset: 0x774EB0 VA: 0x1807768B0
	private void StartLiftSounds() { }

	// RVA: 0x776AB0 Offset: 0x7750B0 VA: 0x180776AB0
	private void UpdateLiftSounds() { }

	// RVA: 0x776C40 Offset: 0x775240 VA: 0x180776C40
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

	// RVA: 0x7B6FE0 Offset: 0x7B55E0 VA: 0x1807B6FE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7B97A0 Offset: 0x7B7DA0 VA: 0x1807B97A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7B7E90 Offset: 0x7B6490 VA: 0x1807B7E90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7B89D0 Offset: 0x7B6FD0 VA: 0x1807B89D0
	public void UpdateSounds() { }

	// RVA: 0x7B7890 Offset: 0x7B5E90 VA: 0x1807B7890 Slot: 28
	public override void InitShared() { }

	// RVA: 0x7B88B0 Offset: 0x7B6EB0 VA: 0x1807B88B0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x7B9590 Offset: 0x7B7B90 VA: 0x1807B9590
	public void Update() { }

	// RVA: 0x7B9070 Offset: 0x7B7670 VA: 0x1807B9070
	public void UpdateWake() { }

	// RVA: 0x7B8170 Offset: 0x7B6770 VA: 0x1807B8170
	public void UpdateEffects() { }

	// RVA: 0x7B7940 Offset: 0x7B5F40 VA: 0x1807B7940 Slot: 186
	public override void InitializeClientEffects() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 196
	public virtual void ShutdownClientEffects() { }

	// RVA: 0x7B85D0 Offset: 0x7B6BD0 VA: 0x1807B85D0 Slot: 197
	public virtual void UpdateEngineRotation() { }

	// RVA: 0x7B8060 Offset: 0x7B6660 VA: 0x1807B8060 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x7B7E20 Offset: 0x7B6420 VA: 0x1807B7E20 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x67E0A0 Offset: 0x67C6A0 VA: 0x18067E0A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x7B7AD0 Offset: 0x7B60D0 VA: 0x1807B7AD0 Slot: 198
	public virtual bool LookingAtEngine(BasePlayer player) { }

	// RVA: 0x6A17D0 Offset: 0x69FDD0 VA: 0x1806A17D0 Slot: 199
	public virtual bool LookingAtFuelArea(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	[BaseEntity.Menu.Description] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	[BaseEntity.Menu.Icon] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	// RVA: 0x7B7D00 Offset: 0x7B6300 VA: 0x1807B7D00
	public void Menu_StartEngine(BasePlayer player) { }

	// RVA: 0x7B7C60 Offset: 0x7B6260 VA: 0x1807B7C60
	public bool Menu_StartEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	[BaseEntity.Menu.Description] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	[BaseEntity.Menu.Icon] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	// RVA: 0x7B7DD0 Offset: 0x7B63D0 VA: 0x1807B7DD0
	public void Menu_StopEngine(BasePlayer player) { }

	// RVA: 0x7B7D50 Offset: 0x7B6350 VA: 0x1807B7D50
	public bool Menu_StopEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	[BaseEntity.Menu.Description] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	[BaseEntity.Menu.Icon] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	// RVA: 0x7B7C20 Offset: 0x7B6220 VA: 0x1807B7C20
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x7B7BB0 Offset: 0x7B61B0 VA: 0x1807B7BB0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x7B7F80 Offset: 0x7B6580 VA: 0x1807B7F80 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x7B6D90 Offset: 0x7B5390 VA: 0x1807B6D90 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x7B80D0 Offset: 0x7B66D0 VA: 0x1807B80D0
	private bool ShowPushMenu(BasePlayer player) { }

	// RVA: 0x7B7A20 Offset: 0x7B6020 VA: 0x1807B7A20 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7B95F0 Offset: 0x7B7BF0 VA: 0x1807B95F0 Slot: 191
	protected override void WorkshopMode() { }

	// RVA: 0x7B96B0 Offset: 0x7B7CB0 VA: 0x1807B96B0
	public void .ctor() { }

	// RVA: 0x7B9650 Offset: 0x7B7C50 VA: 0x1807B9650
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

	// RVA: 0xAD12C0 Offset: 0xACF8C0 VA: 0x180AD12C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD2F00 Offset: 0xAD1500 VA: 0x180AD2F00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD2DB0 Offset: 0xAD13B0 VA: 0x180AD2DB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD11B0 Offset: 0xACF7B0 VA: 0x180AD11B0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0xAD2460 Offset: 0xAD0A60 VA: 0x180AD2460 Slot: 205
	public override bool IsOnThisModule(BasePlayer player) { }

	// RVA: 0xAD2620 Offset: 0xAD0C20 VA: 0x180AD2620 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.Icon] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.Description] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	// RVA: 0xAD2A50 Offset: 0xAD1050 VA: 0x180AD2A50
	public void Menu_MakeBed(BasePlayer player) { }

	// RVA: 0xAD2990 Offset: 0xAD0F90 VA: 0x180AD2990 Slot: 206
	public virtual bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	[BaseEntity.Menu.Icon] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	[BaseEntity.Menu.Description] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	[BaseEntity.Menu.ShowIf] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	// RVA: 0xAD2900 Offset: 0xAD0F00 VA: 0x180AD2900
	public void Menu_ClearBedOwner(BasePlayer player) { }

	// RVA: 0xAD2840 Offset: 0xAD0E40 VA: 0x180AD2840 Slot: 207
	public virtual bool Menu_ClearBedOwner_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.Icon] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.Description] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.ShowIf] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	// RVA: 0xAD27B0 Offset: 0xAD0DB0 VA: 0x180AD27B0
	public void Menu_AssignToFriend(BasePlayer player) { }

	// RVA: 0xAD26F0 Offset: 0xAD0CF0 VA: 0x180AD26F0 Slot: 208
	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.Icon] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.Description] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.ShowIf] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	// RVA: 0xAD2D20 Offset: 0xAD1320 VA: 0x180AD2D20
	public void Menu_Rename(BasePlayer player) { }

	// RVA: 0xAD1200 Offset: 0xACF800 VA: 0x180AD1200 Slot: 209
	protected virtual bool CanRename_Test(BasePlayer player) { }

	// RVA: 0xAD2080 Offset: 0xAD0680 VA: 0x180AD2080
	private SleepingBagCamper GetSleepingBagForPlayer(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	[BaseEntity.Menu.Description] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	[BaseEntity.Menu.Icon] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	[BaseEntity.Menu.ShowIf] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	// RVA: 0xAD2BB0 Offset: 0xAD11B0 VA: 0x180AD2BB0
	public void Menu_OpenLocker(BasePlayer player) { }

	// RVA: 0xAD2AE0 Offset: 0xAD10E0 VA: 0x180AD2AE0
	public bool Menu_OpenLocker_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	[BaseEntity.Menu.Description] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	[BaseEntity.Menu.Icon] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	[BaseEntity.Menu.ShowIf] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	// RVA: 0xAD2CE0 Offset: 0xAD12E0 VA: 0x180AD2CE0
	public void Menu_OpenStorage(BasePlayer player) { }

	// RVA: 0xAD2BF0 Offset: 0xAD11F0 VA: 0x180AD2BF0
	public bool Menu_OpenStorage_ShowIf(BasePlayer player) { }

	// RVA: 0xAD2EA0 Offset: 0xAD14A0 VA: 0x180AD2EA0
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

	// RVA: 0xAD4B40 Offset: 0xAD3140 VA: 0x180AD4B40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD6D10 Offset: 0xAD5310 VA: 0x180AD6D10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD5AD0 Offset: 0xAD40D0 VA: 0x180AD5AD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD6DD0 Offset: 0xAD53D0 VA: 0x180AD6DD0 Slot: 198
	public override bool get_HasSeating() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD6CE0 Offset: 0xAD52E0 VA: 0x180AD6CE0
	protected ModularCar get_Car() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD6E90 Offset: 0xAD5490 VA: 0x180AD6E90
	private void set_Car(ModularCar value) { }

	// RVA: 0xAD6E20 Offset: 0xAD5420 VA: 0x180AD6E20
	protected bool get_IsOnACar() { }

	// RVA: 0xAD6E80 Offset: 0xAD5480 VA: 0x180AD6E80
	protected bool get_IsOnAVehicleLockUser() { }

	// RVA: 0xAD6CF0 Offset: 0xAD52F0 VA: 0x180AD6CF0
	public bool get_DoorsAreLockable() { }

	// RVA: 0xAD5DD0 Offset: 0xAD43D0 VA: 0x180AD5DD0 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xAD4420 Offset: 0xAD2A20 VA: 0x180AD4420 Slot: 194
	public override void ClientVehicleTick() { }

	// RVA: 0xAD56A0 Offset: 0xAD3CA0 VA: 0x180AD56A0 Slot: 195
	public override void OnClientTickStopped() { }

	// RVA: 0xAD6440 Offset: 0xAD4A40 VA: 0x180AD6440 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xAD60F0 Offset: 0xAD46F0 VA: 0x180AD60F0
	private void SetCheckEngineLightState(bool isOn) { }

	// RVA: 0xAD61B0 Offset: 0xAD47B0 VA: 0x180AD61B0
	private void SetFuelLightState(bool isOn) { }

	// RVA: 0xAD6280 Offset: 0xAD4880 VA: 0x180AD6280
	private void SetLightState(bool isOn, int lightMatIndex, Color lightEmission) { }

	// RVA: 0xAD5770 Offset: 0xAD3D70 VA: 0x180AD5770 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xAD6BC0 Offset: 0xAD51C0 VA: 0x180AD6BC0
	public bool ValidMountRay(BasePlayer player) { }

	// RVA: 0xAD5430 Offset: 0xAD3A30 VA: 0x180AD5430 Slot: 197
	public override bool Menu_Locked_ShowIf(BasePlayer player) { }

	// RVA: 0xAD50D0 Offset: 0xAD36D0 VA: 0x180AD50D0
	private bool LookingAtAMountHotSpot(BasePlayer localPlayer) { }

	[BaseEntity.Menu] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	[BaseEntity.Menu.Description] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	[BaseEntity.Menu.Icon] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	[BaseEntity.Menu.ShowIf] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	// RVA: 0xAD53F0 Offset: 0xAD39F0 VA: 0x180AD53F0
	public void Menu_DestroyLock(BasePlayer player) { }

	// RVA: 0xAD53E0 Offset: 0xAD39E0 VA: 0x180AD53E0
	public bool Menu_DestroyLock_ShowIf(BasePlayer player) { }

	// RVA: 0xAD4FB0 Offset: 0xAD35B0 VA: 0x180AD4FB0 Slot: 205
	public virtual bool IsOnThisModule(BasePlayer player) { }

	// RVA: 0xAD4E50 Offset: 0xAD3450 VA: 0x180AD4E50
	public bool HasADriverSeat() { }

	// RVA: 0xAD5590 Offset: 0xAD3B90 VA: 0x180AD5590 Slot: 200
	public override void ModuleAdded(BaseModularVehicle vehicle, int firstSocketIndex) { }

	// RVA: 0xAD5660 Offset: 0xAD3C60 VA: 0x180AD5660 Slot: 201
	public override void ModuleRemoved() { }

	// RVA: 0xAD5BC0 Offset: 0xAD41C0 VA: 0x180AD5BC0
	public bool PlayerCanDestroyLock(BasePlayer player) { }

	// RVA: 0xAD6CD0 Offset: 0xAD52D0 VA: 0x180AD6CD0
	public void .ctor() { }

	// RVA: 0xAD6C80 Offset: 0xAD5280 VA: 0x180AD6C80
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

	// RVA: 0xAC9930 Offset: 0xAC7F30 VA: 0x180AC9930
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

	// RVA: 0xAD6FA0 Offset: 0xAD55A0 VA: 0x180AD6FA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD7510 Offset: 0xAD5B10 VA: 0x180AD7510 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD7420 Offset: 0xAD5A20 VA: 0x180AD7420 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD6F00 Offset: 0xAD5500 VA: 0x180AD6F00
	public IItemContainerEntity GetContainer() { }

	// RVA: 0xAD72B0 Offset: 0xAD58B0 VA: 0x180AD72B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD6EA0 Offset: 0xAD54A0 VA: 0x180AD6EA0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Description] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Icon] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	// RVA: 0xAD73E0 Offset: 0xAD59E0 VA: 0x180AD73E0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0xAD7310 Offset: 0xAD5910 VA: 0x180AD7310
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0xAD4020 Offset: 0xAD2620 VA: 0x180AD4020
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

	// RVA: 0xAD7940 Offset: 0xAD5F40 VA: 0x180AD7940 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD7EF0 Offset: 0xAD64F0 VA: 0x180AD7EF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD7DA0 Offset: 0xAD63A0 VA: 0x180AD7DA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD8060 Offset: 0xAD6660 VA: 0x180AD8060
	private Vector3 get_KickButtonPos() { }

	// RVA: 0xAD75D0 Offset: 0xAD5BD0 VA: 0x180AD75D0
	private bool CanKickPassengers(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	[BaseEntity.Menu.Description] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	[BaseEntity.Menu.Icon] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	// RVA: 0xAD7D10 Offset: 0xAD6310 VA: 0x180AD7D10
	public void Menu_Kick_Passengers(BasePlayer player) { }

	// RVA: 0xAD7C50 Offset: 0xAD6250 VA: 0x180AD7C50
	public bool Menu_Kick_Passengers_ShowIf(BasePlayer player) { }

	// RVA: 0xAD7E90 Offset: 0xAD6490 VA: 0x180AD7E90
	public void .ctor() { }

}

public class ModularCarOven : BaseOven // TypeDefIndex: 8608
{	// Fields
	private BaseVehicleModule moduleParent; // 0x4E8

	// Properties
	private BaseVehicleModule ModuleParent { get; }

	// Methods

	// RVA: 0x7773A0 Offset: 0x7759A0 VA: 0x1807773A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7776B0 Offset: 0x775CB0 VA: 0x1807776B0
	private BaseVehicleModule get_ModuleParent() { }

	// RVA: 0x777490 Offset: 0x775A90 VA: 0x180777490 Slot: 27
	public override void ResetState() { }

	// RVA: 0x7774C0 Offset: 0x775AC0 VA: 0x1807774C0 Slot: 156
	protected override bool SwitchOff_ShowIf(BasePlayer player) { }

	// RVA: 0x777590 Offset: 0x775B90 VA: 0x180777590 Slot: 155
	protected override bool SwitchOn_ShowIf(BasePlayer player) { }

	// RVA: 0x7772D0 Offset: 0x7758D0 VA: 0x1807772D0 Slot: 154
	protected override bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x52ED00 Offset: 0x52D300 VA: 0x18052ED00
	public void .ctor() { }

}

public class VehicleVendor : NPCTalking // TypeDefIndex: 8851
{	// Fields
	public EntityRef spawnerRef; // 0x858
	public VehicleSpawner vehicleSpawner; // 0x868

	// Methods

	// RVA: 0xAD8450 Offset: 0xAD6A50 VA: 0x180AD8450 Slot: 158
	public override string GetConversationStartSpeech(BasePlayer player) { }

	// RVA: 0xAD84A0 Offset: 0xAD6AA0 VA: 0x180AD84A0
	public VehicleSpawner GetVehicleSpawner() { }

	// RVA: 0xAD8540 Offset: 0xAD6B40 VA: 0x180AD8540 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7C46A0 Offset: 0x7C2CA0 VA: 0x1807C46A0 Slot: 159
	public override ConversationData GetConversationFor(BasePlayer player) { }

	// RVA: 0xAD85A0 Offset: 0xAD6BA0 VA: 0x180AD85A0
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

	// RVA: 0xAD8220 Offset: 0xAD6820 VA: 0x180AD8220 Slot: 131
	public virtual int GetOccupyLayer() { }

	// RVA: 0xAD8230 Offset: 0xAD6830 VA: 0x180AD8230
	public BaseVehicle GetVehicleOccupying() { }

	// RVA: 0xAD83D0 Offset: 0xAD69D0 VA: 0x180AD83D0
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

	// RVA: 0x8C1B90 Offset: 0x8C0190 VA: 0x1808C1B90
	private int GetBucketRPM(int RPM) { }

	// RVA: 0x8C1A00 Offset: 0x8C0000 VA: 0x1808C1A00
	private void Awake() { }

	// RVA: 0x8C2630 Offset: 0x8C0C30 VA: 0x1808C2630
	private void Update() { }

	// RVA: 0x8C2510 Offset: 0x8C0B10 VA: 0x1808C2510
	private void UpdateRPM() { }

	// RVA: 0x8C1C00 Offset: 0x8C0200 VA: 0x1808C1C00
	private void InitAudioClip() { }

	// RVA: 0x8C1D30 Offset: 0x8C0330 VA: 0x1808C1D30
	private void OnAudioRead(float[] data) { }

	// RVA: 0x8C21A0 Offset: 0x8C07A0 VA: 0x1808C21A0
	private void SpawnGrain() { }

	// RVA: 0x8C1A80 Offset: 0x8C0080 VA: 0x1808C1A80
	private void CleanupFinishedGrains() { }

	// RVA: 0x8C1EF0 Offset: 0x8C04F0 VA: 0x1808C1EF0
	private void SetupRPMBuckets() { }

	// RVA: 0x8C2A00 Offset: 0x8C1000 VA: 0x1808C2A00
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

	// RVA: 0x8C2F10 Offset: 0x8C1510 VA: 0x1808C2F10
	public void .ctor(int RPM, int startSample, int endSample, float period, int id) { }

}

public class EngineAudioClip.EngineCycleBucket // TypeDefIndex: 8989
{	// Fields
	public int RPM; // 0x10
	public List<EngineAudioClip.EngineCycle> cycles; // 0x18
	public List<int> remainingCycles; // 0x20

	// Methods

	// RVA: 0x8C2E60 Offset: 0x8C1460 VA: 0x1808C2E60
	public void .ctor(int RPM) { }

	// RVA: 0x8C2C90 Offset: 0x8C1290 VA: 0x1808C2C90
	public EngineAudioClip.EngineCycle GetCycle(Random random, int lastCycleId) { }

	// RVA: 0x8C2DA0 Offset: 0x8C13A0 VA: 0x1808C2DA0
	private void ResetRemainingCycles(Random random) { }

	// RVA: 0x8C2C20 Offset: 0x8C1220 VA: 0x1808C2C20
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

	// RVA: 0x8D6740 Offset: 0x8D4D40 VA: 0x1808D6740
	public void Init(float[] source, EngineAudioClip.EngineCycle cycle, int cyclePadding) { }

	// RVA: 0x8D6680 Offset: 0x8D4C80 VA: 0x1808D6680
	public float GetSample() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class BaseVehicleMountPoint : BaseMountable // TypeDefIndex: 9697
{	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 147
	public override bool DirectlyMountable() { }

	// RVA: 0x9354C0 Offset: 0x933AC0 VA: 0x1809354C0 Slot: 170
	public override BaseVehicle VehicleParent() { }

	// RVA: 0x935410 Offset: 0x933A10 VA: 0x180935410 Slot: 109
	public override bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x935630 Offset: 0x933C30 VA: 0x180935630 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x935370 Offset: 0x933970 VA: 0x180935370 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x9356E0 Offset: 0x933CE0 VA: 0x1809356E0
	public void .ctor() { }

}

public class BaseVehicleSeat : BaseVehicleMountPoint // TypeDefIndex: 9698
{	// Fields
	public float mountedAnimationSpeed; // 0x320
	public bool sendClientInputToVehicleParent; // 0x324
	public bool forcePlayerModelUpdate; // 0x325

	// Methods

	// RVA: 0x935760 Offset: 0x933D60 VA: 0x180935760 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x935820 Offset: 0x933E20 VA: 0x180935820 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x935750 Offset: 0x933D50 VA: 0x180935750 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0x935740 Offset: 0x933D40 VA: 0x180935740 Slot: 159
	public override bool ForceUpdatePlayerModel(BasePlayer p) { }

	// RVA: 0x9356E0 Offset: 0x933CE0 VA: 0x1809356E0
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

	// RVA: 0x8C2B70 Offset: 0x8C1170 VA: 0x1808C2B70
	public BlendedEngineLoopDefinition GetEngineLoopDef(int numEngines) { }

	// RVA: 0x8C2BB0 Offset: 0x8C11B0 VA: 0x1808C2BB0
	public void .ctor() { }

}

public class ModularCarCentralLockingSwitch : VehicleModuleButtonComponent // TypeDefIndex: 9738
{	// Fields
	public Transform centralLockingSwitch; // 0x28
	public Vector3 switchOffPos; // 0x30
	public Vector3 switchOnPos; // 0x3C

	// Methods

	// RVA: 0x774880 Offset: 0x772E80 VA: 0x180774880 Slot: 4
	public override void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	// RVA: 0x774700 Offset: 0x772D00 VA: 0x180774700 Slot: 5
	public override void ClientUpdateTick(BaseVehicleModule parentModule) { }

	// RVA: 0x774990 Offset: 0x772F90 VA: 0x180774990
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

	// RVA: 0x7749A0 Offset: 0x772FA0 VA: 0x1807749A0 Slot: 4
	public override void Init(ModularCar owner, VehicleChassisVisuals.ClientWheelData<ModularCar>[] clientWheelData) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected override void PreWheelUpdateTick() { }

	// RVA: 0x774C00 Offset: 0x773200 VA: 0x180774C00 Slot: 7
	protected override void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt) { }

	// RVA: 0x775120 Offset: 0x773720 VA: 0x180775120 Slot: 6
	protected override void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, bool isOn, float steer, float dt) { }

	// RVA: 0x774D90 Offset: 0x773390 VA: 0x180774D90
	private void UpdateAxle(Transform axle, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataL, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataR, float dt, bool instant) { }

	// RVA: 0x774A10 Offset: 0x773010 VA: 0x180774A10
	private void LookAt(ModularCarChassisVisuals.LookAtTarget lookAt) { }

	// RVA: 0x7753C0 Offset: 0x7739C0 VA: 0x1807753C0
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

	// RVA: 0x777230 Offset: 0x775830 VA: 0x180777230
	public bool get_HasALock() { }

	// RVA: 0x777240 Offset: 0x775840 VA: 0x180777240
	public bool get_IsLocked() { }

	// RVA: 0x7771A0 Offset: 0x7757A0 VA: 0x1807771A0
	public bool get_CentralLockingIsOn() { }

	// RVA: 0x777150 Offset: 0x775750 VA: 0x180777150
	public void .ctor(ModularCar owner, bool isServer) { }

	// RVA: 0x777050 Offset: 0x775650 VA: 0x180777050
	public bool PlayerHasUnlockPermission(BasePlayer player) { }

	// RVA: 0x777000 Offset: 0x775600 VA: 0x180777000
	public bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0x776FC0 Offset: 0x7755C0 VA: 0x180776FC0
	public bool PlayerCanDestroyLock(BaseVehicleModule viaModule) { }

	// RVA: 0x776F80 Offset: 0x775580 VA: 0x180776F80
	private bool KeyCanUnlockThis(Item key) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776F80 Offset: 0x775580 VA: 0x180776F80
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

	// RVA: 0x7777A0 Offset: 0x775DA0 VA: 0x1807777A0
	public bool get_HasLeftFootIK() { }

	// RVA: 0x7777E0 Offset: 0x775DE0 VA: 0x1807777E0
	public bool get_HasRightFootIK() { }

	// RVA: 0x777820 Offset: 0x775E20 VA: 0x180777820
	public Vector3 get_LeftFootIKPos() { }

	// RVA: 0x777900 Offset: 0x775F00 VA: 0x180777900
	public Vector3 get_RightFootIKPos() { }

	// RVA: 0x7777C0 Offset: 0x775DC0 VA: 0x1807777C0
	public bool get_HasLeftHandIK() { }

	// RVA: 0x777800 Offset: 0x775E00 VA: 0x180777800
	public bool get_HasRightHandIK() { }

	// RVA: 0x777890 Offset: 0x775E90 VA: 0x180777890
	public Vector3 get_LeftHandIKPos() { }

	// RVA: 0x777970 Offset: 0x775F70 VA: 0x180777970
	public Vector3 get_RightHandIKPos() { }

	// RVA: 0x777790 Offset: 0x775D90 VA: 0x180777790
	public void .ctor() { }

}

public class ModularVehicleShopFront : ShopFront // TypeDefIndex: 9748
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxUseDistance; // 0x3F0

	// Methods

	// RVA: 0x77AC90 Offset: 0x779290 VA: 0x18077AC90 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x77AD20 Offset: 0x779320 VA: 0x18077AD20 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x77AE30 Offset: 0x779430 VA: 0x18077AE30
	private bool WithinUseDistance(BasePlayer player) { }

	// RVA: 0x77AEA0 Offset: 0x7794A0 VA: 0x18077AEA0
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

	// RVA: 0xAD10A0 Offset: 0xACF6A0 VA: 0x180AD10A0 Slot: 4
	public virtual void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void ClientUpdateTick(BaseVehicleModule parentModule) { }

	// RVA: 0xAD1160 Offset: 0xACF760 VA: 0x180AD1160
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
	// RVA: 0xAD41D0 Offset: 0xAD27D0 VA: 0x180AD41D0
	public bool get_IsUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4240 Offset: 0xAD2840 VA: 0x180AD4240
	private void set_IsUsable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4210 Offset: 0xAD2810 VA: 0x180AD4210
	public float get_PerformanceFractionAcceleration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4260 Offset: 0xAD2860 VA: 0x180AD4260
	private void set_PerformanceFractionAcceleration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4230 Offset: 0xAD2830 VA: 0x180AD4230
	public float get_PerformanceFractionTopSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4280 Offset: 0xAD2880 VA: 0x180AD4280
	private void set_PerformanceFractionTopSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4220 Offset: 0xAD2820 VA: 0x180AD4220
	public float get_PerformanceFractionFuelEconomy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4270 Offset: 0xAD2870 VA: 0x180AD4270
	private void set_PerformanceFractionFuelEconomy(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4200 Offset: 0xAD2800 VA: 0x180AD4200
	public float get_OverallPerformanceFraction() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4250 Offset: 0xAD2850 VA: 0x180AD4250
	private void set_OverallPerformanceFraction(float value) { }

	// RVA: 0xAD4080 Offset: 0xAD2680 VA: 0x180AD4080
	public bool get_AtLowPerformance() { }

	// RVA: 0xAD40A0 Offset: 0xAD26A0 VA: 0x180AD40A0
	public bool get_AtPeakPerformance() { }

	// RVA: 0xAD41E0 Offset: 0xAD27E0 VA: 0x180AD41E0
	public int get_KW() { }

	// RVA: 0xAD4110 Offset: 0xAD2710 VA: 0x180AD4110
	public EngineAudioSet get_AudioSet() { }

	// RVA: 0xAD4130 Offset: 0xAD2730 VA: 0x180AD4130
	private bool get_EngineIsOn() { }

	// RVA: 0xAD3A10 Offset: 0xAD2010 VA: 0x180AD3A10 Slot: 28
	public override void InitShared() { }

	// RVA: 0xAD3B80 Offset: 0xAD2180 VA: 0x180AD3B80 Slot: 202
	public override void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState) { }

	// RVA: 0xAD38E0 Offset: 0xAD1EE0 VA: 0x180AD38E0 Slot: 203
	public override float GetMaxDriveForce() { }

	// RVA: 0xAD3DC0 Offset: 0xAD23C0 VA: 0x180AD3DC0
	public void RefreshPerformanceStats(EngineStorage engineStorage) { }

	// RVA: 0xAD3930 Offset: 0xAD1F30 VA: 0x180AD3930
	private float GetPerformanceFraction(float statBoostPercent) { }

	// RVA: 0xAD3AB0 Offset: 0xAD20B0 VA: 0x180AD3AB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD3160 Offset: 0xAD1760 VA: 0x180AD3160 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xAD3200 Offset: 0xAD1800 VA: 0x180AD3200 Slot: 194
	public override void ClientVehicleTick() { }

	// RVA: 0xAD3C60 Offset: 0xAD2260 VA: 0x180AD3C60
	private void PlayBadPerformanceSound() { }

	// RVA: 0xAD3F60 Offset: 0xAD2560 VA: 0x180AD3F60
	private void StopBadPerformanceSound() { }

	// RVA: 0xAD3ED0 Offset: 0xAD24D0 VA: 0x180AD3ED0
	private void SetFXState(bool isOn) { }

	// RVA: 0xAD4020 Offset: 0xAD2620 VA: 0x180AD4020
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

	// RVA: 0xAC77E0 Offset: 0xAC5DE0 VA: 0x180AC77E0
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

	// RVA: 0xAD0DE0 Offset: 0xACF3E0 VA: 0x180AD0DE0
	public void SetLightVisuals(bool headlightsOn, bool brakesOn) { }

	// RVA: 0xAD0B70 Offset: 0xACF170 VA: 0x180AD0B70
	public static void SetLightVisuals(IReadOnlyList<VehicleLight> lights, bool headlightsOn, bool brakesOn) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xAD1050 Offset: 0xACF650 VA: 0x180AD1050
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

	// RVA: 0x8C31F0 Offset: 0x8C17F0 VA: 0x1808C31F0
	public void .ctor(float triggerDamage, float maxSeconds, Action trigger) { }

	// RVA: 0x8C3080 Offset: 0x8C1680 VA: 0x1808C3080
	public void TakeDamage(float amount) { }

	// RVA: 0x8C2F70 Offset: 0x8C1570 VA: 0x1808C2F70
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
	|-RVA: 0x19CDF50 Offset: 0x19CC550 VA: 0x1819CDF50
	|-VehicleChassisVisuals<ModularCar>.Init
	|-VehicleChassisVisuals<Snowmobile>.Init
	|-VehicleChassisVisuals<object>.Init
	*/

	// RVA: -1 Offset: -1
	public void UpdateTick(float dt, bool instantForced = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE9D0 Offset: 0x19CCFD0 VA: 0x1819CE9D0
	|-VehicleChassisVisuals<ModularCar>.UpdateTick
	|-VehicleChassisVisuals<Snowmobile>.UpdateTick
	|-VehicleChassisVisuals<object>.UpdateTick
	*/

	// RVA: -1 Offset: -1
	public bool IsGrounded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CDFC0 Offset: 0x19CC5C0 VA: 0x1819CDFC0
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
	|-RVA: 0x19CD890 Offset: 0x19CBE90 VA: 0x1819CD890
	|-VehicleChassisVisuals<ModularCar>.CalculateWheelSlip
	|-VehicleChassisVisuals<Snowmobile>.CalculateWheelSlip
	|-VehicleChassisVisuals<object>.CalculateWheelSlip
	*/

	// RVA: -1 Offset: -1
	protected void UpdateWheelSuspensionData(VehicleChassisVisuals.ClientWheelData<T> wheelData, Vector3 traceSource, Nullable<Vector3> traceSource2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CEDE0 Offset: 0x19CD3E0 VA: 0x1819CEDE0
	|-VehicleChassisVisuals<ModularCar>.UpdateWheelSuspensionData
	|-VehicleChassisVisuals<Snowmobile>.UpdateWheelSuspensionData
	|-VehicleChassisVisuals<object>.UpdateWheelSuspensionData
	*/

	// RVA: -1 Offset: -1
	protected float GetWheelRotation(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool receivingDriveWheelVels, float dt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CDCD0 Offset: 0x19CC2D0 VA: 0x1819CDCD0
	|-VehicleChassisVisuals<ModularCar>.GetWheelRotation
	|-VehicleChassisVisuals<Snowmobile>.GetWheelRotation
	|-VehicleChassisVisuals<object>.GetWheelRotation
	*/

	// RVA: -1 Offset: -1
	protected static void UpdateSteerRotation(Transform t, float steer, int axis) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE8E0 Offset: 0x19CCEE0 VA: 0x1819CE8E0
	|-VehicleChassisVisuals<ModularCar>.UpdateSteerRotation
	|-VehicleChassisVisuals<object>.UpdateSteerRotation
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, float throttleInput) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE090 Offset: 0x19CC690 VA: 0x1819CE090
	|-VehicleChassisVisuals<ModularCar>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, float throttleInput, float speed, float minSpeed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE4F0 Offset: 0x19CCAF0 VA: 0x1819CE4F0
	|-VehicleChassisVisuals<Snowmobile>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOnWater, float spinSlip, TerrainConfig.GroundType groundType, float throttleInput) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE180 Offset: 0x19CC780 VA: 0x1819CE180
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOnWater, float spinSlip, TerrainConfig.GroundType groundType, float throttleInput, float speed, float minSpeed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE250 Offset: 0x19CC850 VA: 0x1819CE250
	|-VehicleChassisVisuals<Snowmobile>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	public void UpdateTickStopped() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE980 Offset: 0x19CCF80 VA: 0x1819CE980
	|-VehicleChassisVisuals<ModularCar>.UpdateTickStopped
	|-VehicleChassisVisuals<Snowmobile>.UpdateTickStopped
	|-VehicleChassisVisuals<object>.UpdateTickStopped
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void StopAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE610 Offset: 0x19CCC10 VA: 0x1819CE610
	|-VehicleChassisVisuals<ModularCar>.StopAll
	|-VehicleChassisVisuals<Snowmobile>.StopAll
	|-VehicleChassisVisuals<object>.StopAll
	*/

	// RVA: -1 Offset: -1
	protected static void StopTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE6C0 Offset: 0x19CCCC0 VA: 0x1819CE6C0
	|-VehicleChassisVisuals<object>.StopTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x847110 Offset: 0x845710 VA: 0x180847110
	|-VehicleChassisVisuals<ModularCar>..ctor
	|-VehicleChassisVisuals<Snowmobile>..ctor
	|-VehicleChassisVisuals<object>..ctor
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static bool <UpdateWheelSuspensionData>g__GetSuspensionHit|17_0(Vector3 ts, out RaycastHit hit, ref VehicleChassisVisuals.<>c__DisplayClass17_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CE7C0 Offset: 0x19CCDC0 VA: 0x1819CE7C0
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
	|-RVA: 0x19BB860 Offset: 0x19B9E60 VA: 0x1819BB860
	|-VehicleChassisVisuals.ClientWheelData<ModularCar>.get_isOnHardGround
	|-VehicleChassisVisuals.ClientWheelData<object>.get_isOnHardGround
	*/

	// RVA: -1 Offset: -1
	public void .ctor(VisualCarWheel wheel, Transform vehicleTransform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BB790 Offset: 0x19B9D90 VA: 0x1819BB790
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
	|-RVA: 0x19CF4B0 Offset: 0x19CDAB0 VA: 0x1819CF4B0
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
	|-RVA: 0x19CF510 Offset: 0x19CDB10 VA: 0x1819CF510
	|-VehicleEngineController<BaseSubmarine>.get_IsOn
	|-VehicleEngineController<GroundVehicle>.get_IsOn
	|-VehicleEngineController<object>.get_IsOn
	*/

	// RVA: -1 Offset: -1
	public bool get_IsOff() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E6750 Offset: 0x15E4D50 VA: 0x1815E6750
	|-VehicleEngineController<object>.get_IsOff
	|-VehicleEngineController<TrainEngine>.get_IsOff
	*/

	// RVA: -1 Offset: -1
	public bool get_IsStarting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF570 Offset: 0x19CDB70 VA: 0x1819CF570
	|-VehicleEngineController<MiniCopter>.get_IsStarting
	|-VehicleEngineController<object>.get_IsStarting
	*/

	// RVA: -1 Offset: -1
	public bool get_IsStartingOrOn() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF540 Offset: 0x19CDB40 VA: 0x1819CF540
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
	|-RVA: 0x19CF390 Offset: 0x19CD990 VA: 0x1819CF390
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
	|-RVA: 0x19CF290 Offset: 0x19CD890 VA: 0x1819CF290
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

	// RVA: 0xAD8210 Offset: 0xAD6810 VA: 0x180AD8210
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

	// RVA: 0x8C32A0 Offset: 0x8C18A0 VA: 0x1808C32A0 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x8C3320 Offset: 0x8C1920 VA: 0x1808C3320 Slot: 5
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

	// RVA: 0xACD820 Offset: 0xACBE20 VA: 0x180ACD820
	protected void Awake() { }

	// RVA: 0xACDAC0 Offset: 0xACC0C0 VA: 0x180ACDAC0
	protected void OnEnable() { }

	// RVA: 0xACDA40 Offset: 0xACC040 VA: 0x180ACDA40
	protected void OnDisable() { }

	// RVA: 0xACDB80 Offset: 0xACC180 VA: 0x180ACDB80 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0xACD8B0 Offset: 0xACBEB0 VA: 0x180ACD8B0
	private void InventoryChangeRefresh() { }

	// RVA: 0xACDB90 Offset: 0xACC190 VA: 0x180ACDB90
	private void SetLinkSprite(Sprite sprite) { }

	// RVA: 0xACD870 Offset: 0xACBE70 VA: 0x180ACD870
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

	// RVA: 0xAD0AB0 Offset: 0xACF0B0 VA: 0x180AD0AB0
	private Item get_CurSelectedItem() { }

	// RVA: 0xAD0B60 Offset: 0xACF160 VA: 0x180AD0B60
	private ItemContainer get_ModulesContainer() { }

	// RVA: 0xAD0AA0 Offset: 0xACF0A0 VA: 0x180AD0AA0
	private ItemContainer get_ChassisContainer() { }

	// RVA: 0xAD0B50 Offset: 0xACF150 VA: 0x180AD0B50
	private ItemContainer get_ModuleInternalItemContainer() { }

	// RVA: 0xACE3C0 Offset: 0xACC9C0 VA: 0x180ACE3C0
	protected void OnEnable() { }

	// RVA: 0xAD0880 Offset: 0xACEE80 VA: 0x180AD0880 Slot: 5
	public override void Update() { }

	// RVA: 0xAD00D0 Offset: 0xACE6D0 VA: 0x180AD00D0
	public void RepairClicked() { }

	// RVA: 0xACDE10 Offset: 0xACC410 VA: 0x180ACDE10
	public void CraftLockClicked() { }

	// RVA: 0xAD0050 Offset: 0xACE650 VA: 0x180AD0050
	public void RemoveLockClicked() { }

	// RVA: 0xACDEC0 Offset: 0xACC4C0 VA: 0x180ACDEC0
	public void DestroyChassisClicked() { }

	// RVA: 0xAD0220 Offset: 0xACE820 VA: 0x180AD0220
	public void TakeInternalItemsClicked() { }

	// RVA: 0xACE150 Offset: 0xACC750 VA: 0x180ACE150
	public void OnCopyFromLiquidDown() { }

	// RVA: 0xACE1D0 Offset: 0xACC7D0 VA: 0x180ACE1D0
	public void OnCopyFromLiquidUp() { }

	// RVA: 0xAD0180 Offset: 0xACE780 VA: 0x180AD0180
	private bool SelectedValidLiquidTarget() { }

	// RVA: 0xACDFF0 Offset: 0xACC5F0 VA: 0x180ACDFF0
	private void LiquidCopyFrom() { }

	// RVA: 0xACDBE0 Offset: 0xACC1E0 VA: 0x180ACDBE0
	private bool CanTakeLiquid() { }

	// RVA: 0xACDF60 Offset: 0xACC560 VA: 0x180ACDF60
	private ModularCarGarage GetGarage() { }

	// RVA: 0xACE880 Offset: 0xACCE80 VA: 0x180ACE880
	private void RefreshEditUI() { }

	// RVA: 0xACEAE0 Offset: 0xACD0E0 VA: 0x180ACEAE0
	private void RefreshHasVehicle(ModularCarGarage garage, bool forced = False) { }

	// RVA: 0xACEC50 Offset: 0xACD250 VA: 0x180ACEC50
	private void RefreshInfoText() { }

	// RVA: 0xACFC00 Offset: 0xACE200 VA: 0x180ACFC00
	private void RefreshWarningText() { }

	// RVA: 0xACE570 Offset: 0xACCB70 VA: 0x180ACE570
	private void OnSelectedItemChanged(Item newSelectedItem) { }

	// RVA: 0xACE600 Offset: 0xACCC00 VA: 0x180ACE600
	private void RefreshDestroyGroup(ModularCarGarage garage) { }

	// RVA: 0xACEF40 Offset: 0xACD540 VA: 0x180ACEF40
	private void RefreshLockCreation(ModularCarGarage garage) { }

	// RVA: 0xACF5A0 Offset: 0xACDBA0 VA: 0x180ACF5A0
	private void RefreshRepair() { }

	// RVA: 0xAD0A90 Offset: 0xACF090 VA: 0x180AD0A90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD04E0 Offset: 0xACEAE0 VA: 0x180AD04E0
	private bool <RefreshLockCreation>g__AddResourceInfo|72_0(string prefixText, ItemAmount ingredient, ref VehicleEditingPanel.<>c__DisplayClass72_0 ) { }

}

private class VehicleEditingPanel.CreateChassisEntry // TypeDefIndex: 11063
{	// Fields
	public byte garageChassisIndex; // 0x10
	public Button craftButton; // 0x18
	public Text craftButtonText; // 0x20
	public Text requirementsText; // 0x28

	// Methods

	// RVA: 0xAC7790 Offset: 0xAC5D90 VA: 0x180AC7790
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

	// RVA: 0xAD4290 Offset: 0xAD2890 VA: 0x180AD4290 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0xAD42E0 Offset: 0xAD28E0 VA: 0x180AD42E0 Slot: 5
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

