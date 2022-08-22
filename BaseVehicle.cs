public class BaseVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6327
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<BaseVehicle.MountPoint> mountPoints; // 0x18

	// Methods

	// RVA: 0x1F6B870 Offset: 0x1F69E70 VA: 0x181F6B870
	public static void ResetToPool(BaseVehicle instance) { }

	// RVA: 0x1F6B6C0 Offset: 0x1F69CC0 VA: 0x181F6B6C0
	public void ResetToPool() { }

	// RVA: 0x1F6B440 Offset: 0x1F69A40 VA: 0x181F6B440 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F6A5C0 Offset: 0x1F68BC0 VA: 0x181F6A5C0
	public void CopyTo(BaseVehicle instance) { }

	// RVA: 0x1F6A750 Offset: 0x1F68D50 VA: 0x181F6A750
	public BaseVehicle Copy() { }

	// RVA: 0x1F6B1D0 Offset: 0x1F697D0 VA: 0x181F6B1D0
	public static BaseVehicle Deserialize(Stream stream) { }

	// RVA: 0x1F6AC00 Offset: 0x1F69200 VA: 0x181F6AC00
	public static BaseVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F6AC80 Offset: 0x1F69280 VA: 0x181F6AC80
	public static BaseVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F6B0B0 Offset: 0x1F696B0 VA: 0x181F6B0B0
	public static BaseVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1F6B680 Offset: 0x1F69C80 VA: 0x181F6B680
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F6BFB0 Offset: 0x1F6A5B0 VA: 0x181F6BFB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F6BFD0 Offset: 0x1F6A5D0 VA: 0x181F6BFD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseVehicle previous) { }

	// RVA: 0x1F6B6A0 Offset: 0x1F69CA0 VA: 0x181F6B6A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F6AFB0 Offset: 0x1F695B0 VA: 0x181F6AFB0
	public static BaseVehicle Deserialize(byte[] buffer, BaseVehicle instance, bool isDelta = False) { }

	// RVA: 0x1F6B250 Offset: 0x1F69850 VA: 0x181F6B250
	public static BaseVehicle Deserialize(Stream stream, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F6A930 Offset: 0x1F68F30 VA: 0x181F6A930
	public static BaseVehicle DeserializeLengthDelimited(Stream stream, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F6AD10 Offset: 0x1F69310 VA: 0x181F6AD10
	public static BaseVehicle DeserializeLength(Stream stream, int length, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F6BA20 Offset: 0x1F6A020 VA: 0x181F6BA20
	public static void SerializeDelta(Stream stream, BaseVehicle instance, BaseVehicle previous) { }

	// RVA: 0x1F6BDC0 Offset: 0x1F6A3C0 VA: 0x181F6BDC0
	public static void Serialize(Stream stream, BaseVehicle instance) { }

	// RVA: 0x1F6BFA0 Offset: 0x1F6A5A0 VA: 0x181F6BFA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F6BFB0 Offset: 0x1F6A5B0 VA: 0x181F6BFB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F6BCB0 Offset: 0x1F6A2B0 VA: 0x181F6BCB0
	public static byte[] SerializeToBytes(BaseVehicle instance) { }

	// RVA: 0x1F6BC00 Offset: 0x1F6A200 VA: 0x181F6BC00
	public static void SerializeLengthDelimited(Stream stream, BaseVehicle instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class BaseVehicle.MountPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6328
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int index; // 0x14
	public uint mountableId; // 0x18

	// Methods

	// RVA: 0x1F7D8D0 Offset: 0x1F7BED0 VA: 0x181F7D8D0
	public static void ResetToPool(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7D850 Offset: 0x1F7BE50 VA: 0x181F7D850
	public void ResetToPool() { }

	// RVA: 0x1F7D630 Offset: 0x1F7BC30 VA: 0x181F7D630 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7C830 Offset: 0x1F7AE30 VA: 0x181F7C830
	public BaseVehicle.MountPoint Copy() { }

	// RVA: 0x1F7CFB0 Offset: 0x1F7B5B0 VA: 0x181F7CFB0
	public static BaseVehicle.MountPoint Deserialize(Stream stream) { }

	// RVA: 0x1F7CAF0 Offset: 0x1F7B0F0 VA: 0x181F7CAF0
	public static BaseVehicle.MountPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7CB70 Offset: 0x1F7B170 VA: 0x181F7CB70
	public static BaseVehicle.MountPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7D170 Offset: 0x1F7B770 VA: 0x181F7D170
	public static BaseVehicle.MountPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F7D6B0 Offset: 0x1F7BCB0 VA: 0x181F7D6B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7DD90 Offset: 0x1F7C390 VA: 0x181F7DD90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7DDB0 Offset: 0x1F7C3B0 VA: 0x181F7DDB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseVehicle.MountPoint previous) { }

	// RVA: 0x1F7D830 Offset: 0x1F7BE30 VA: 0x181F7D830 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7D3E0 Offset: 0x1F7B9E0 VA: 0x181F7D3E0
	public static BaseVehicle.MountPoint Deserialize(byte[] buffer, BaseVehicle.MountPoint instance, bool isDelta = False) { }

	// RVA: 0x1F7CE30 Offset: 0x1F7B430 VA: 0x181F7CE30
	public static BaseVehicle.MountPoint Deserialize(Stream stream, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F7C8A0 Offset: 0x1F7AEA0 VA: 0x181F7C8A0
	public static BaseVehicle.MountPoint DeserializeLengthDelimited(Stream stream, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F7CC00 Offset: 0x1F7B200 VA: 0x181F7CC00
	public static BaseVehicle.MountPoint DeserializeLength(Stream stream, int length, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F7D950 Offset: 0x1F7BF50 VA: 0x181F7D950
	public static void SerializeDelta(Stream stream, BaseVehicle.MountPoint instance, BaseVehicle.MountPoint previous) { }

	// RVA: 0x1F7DC80 Offset: 0x1F7C280 VA: 0x181F7DC80
	public static void Serialize(Stream stream, BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7DD80 Offset: 0x1F7C380 VA: 0x181F7DD80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7DD90 Offset: 0x1F7C390 VA: 0x181F7DD90
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7DB70 Offset: 0x1F7C170 VA: 0x181F7DB70
	public static byte[] SerializeToBytes(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F7DAC0 Offset: 0x1F7C0C0 VA: 0x181F7DAC0
	public static void SerializeLengthDelimited(Stream stream, BaseVehicle.MountPoint instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class Motorboat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6346
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint storageid; // 0x14
	public uint fuelStorageID; // 0x18

	// Methods

	// RVA: 0x1F8BD50 Offset: 0x1F8A350 VA: 0x181F8BD50
	public static void ResetToPool(Motorboat instance) { }

	// RVA: 0x1F8BCD0 Offset: 0x1F8A2D0 VA: 0x181F8BCD0
	public void ResetToPool() { }

	// RVA: 0x1F8BA30 Offset: 0x1F8A030 VA: 0x181F8BA30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(Motorboat instance) { }

	// RVA: 0x1F8AC30 Offset: 0x1F89230 VA: 0x181F8AC30
	public Motorboat Copy() { }

	// RVA: 0x1F8B870 Offset: 0x1F89E70 VA: 0x181F8B870
	public static Motorboat Deserialize(Stream stream) { }

	// RVA: 0x1F8ACA0 Offset: 0x1F892A0 VA: 0x181F8ACA0
	public static Motorboat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8B1A0 Offset: 0x1F897A0 VA: 0x181F8B1A0
	public static Motorboat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8B230 Offset: 0x1F89830 VA: 0x181F8B230
	public static Motorboat Deserialize(byte[] buffer) { }

	// RVA: 0x1F8BB30 Offset: 0x1F8A130 VA: 0x181F8BB30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8C210 Offset: 0x1F8A810 VA: 0x181F8C210 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8C230 Offset: 0x1F8A830 VA: 0x181F8C230 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Motorboat previous) { }

	// RVA: 0x1F8BCB0 Offset: 0x1F8A2B0 VA: 0x181F8BCB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8B620 Offset: 0x1F89C20 VA: 0x181F8B620
	public static Motorboat Deserialize(byte[] buffer, Motorboat instance, bool isDelta = False) { }

	// RVA: 0x1F8B4A0 Offset: 0x1F89AA0 VA: 0x181F8B4A0
	public static Motorboat Deserialize(Stream stream, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F8AD20 Offset: 0x1F89320 VA: 0x181F8AD20
	public static Motorboat DeserializeLengthDelimited(Stream stream, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F8AF70 Offset: 0x1F89570 VA: 0x181F8AF70
	public static Motorboat DeserializeLength(Stream stream, int length, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F8BDD0 Offset: 0x1F8A3D0 VA: 0x181F8BDD0
	public static void SerializeDelta(Stream stream, Motorboat instance, Motorboat previous) { }

	// RVA: 0x1F8C100 Offset: 0x1F8A700 VA: 0x181F8C100
	public static void Serialize(Stream stream, Motorboat instance) { }

	// RVA: 0x1F8C200 Offset: 0x1F8A800 VA: 0x181F8C200
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8C210 Offset: 0x1F8A810 VA: 0x181F8C210
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8BFF0 Offset: 0x1F8A5F0 VA: 0x181F8BFF0
	public static byte[] SerializeToBytes(Motorboat instance) { }

	// RVA: 0x1F8BF40 Offset: 0x1F8A540 VA: 0x181F8BF40
	public static void SerializeLengthDelimited(Stream stream, Motorboat instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ModularVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6348
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool editable; // 0x12

	// Methods

	// RVA: 0x1F887C0 Offset: 0x1F86DC0 VA: 0x181F887C0
	public static void ResetToPool(ModularVehicle instance) { }

	// RVA: 0x1F88740 Offset: 0x1F86D40 VA: 0x181F88740
	public void ResetToPool() { }

	// RVA: 0x1F88610 Offset: 0x1F86C10 VA: 0x181F88610 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E19C60 Offset: 0x1E18260 VA: 0x181E19C60
	public void CopyTo(ModularVehicle instance) { }

	// RVA: 0x1F87C90 Offset: 0x1F86290 VA: 0x181F87C90
	public ModularVehicle Copy() { }

	// RVA: 0x1F88590 Offset: 0x1F86B90 VA: 0x181F88590
	public static ModularVehicle Deserialize(Stream stream) { }

	// RVA: 0x1F87D00 Offset: 0x1F86300 VA: 0x181F87D00
	public static ModularVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F87FA0 Offset: 0x1F865A0 VA: 0x181F87FA0
	public static ModularVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F88470 Offset: 0x1F86A70 VA: 0x181F88470
	public static ModularVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1F88700 Offset: 0x1F86D00 VA: 0x181F88700
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F88C50 Offset: 0x1F87250 VA: 0x181F88C50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F88D20 Offset: 0x1F87320 VA: 0x181F88D20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModularVehicle previous) { }

	// RVA: 0x1F88720 Offset: 0x1F86D20 VA: 0x181F88720 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F88230 Offset: 0x1F86830 VA: 0x181F88230
	public static ModularVehicle Deserialize(byte[] buffer, ModularVehicle instance, bool isDelta = False) { }

	// RVA: 0x1F88330 Offset: 0x1F86930 VA: 0x181F88330
	public static ModularVehicle Deserialize(Stream stream, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F87D80 Offset: 0x1F86380 VA: 0x181F87D80
	public static ModularVehicle DeserializeLengthDelimited(Stream stream, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F88030 Offset: 0x1F86630 VA: 0x181F88030
	public static ModularVehicle DeserializeLength(Stream stream, int length, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F88840 Offset: 0x1F86E40 VA: 0x181F88840
	public static void SerializeDelta(Stream stream, ModularVehicle instance, ModularVehicle previous) { }

	// RVA: 0x1F88B70 Offset: 0x1F87170 VA: 0x181F88B70
	public static void Serialize(Stream stream, ModularVehicle instance) { }

	// RVA: 0x1F88C40 Offset: 0x1F87240 VA: 0x181F88C40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F88C50 Offset: 0x1F87250 VA: 0x181F88C50
	public void ToProto(Stream stream) { }

	// RVA: 0x1F889C0 Offset: 0x1F86FC0 VA: 0x181F889C0
	public static byte[] SerializeToBytes(ModularVehicle instance) { }

	// RVA: 0x1F88910 Offset: 0x1F86F10 VA: 0x181F88910
	public static void SerializeLengthDelimited(Stream stream, ModularVehicle instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1F874B0 Offset: 0x1F85AB0 VA: 0x181F874B0
	public static void ResetToPool(ModularCar instance) { }

	// RVA: 0x1F873E0 Offset: 0x1F859E0 VA: 0x181F873E0
	public void ResetToPool() { }

	// RVA: 0x1F86C20 Offset: 0x1F85220 VA: 0x181F86C20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB3DF0 Offset: 0x1DB23F0 VA: 0x181DB3DF0
	public void CopyTo(ModularCar instance) { }

	// RVA: 0x1F85210 Offset: 0x1F83810 VA: 0x181F85210
	public ModularCar Copy() { }

	// RVA: 0x1F86620 Offset: 0x1F84C20 VA: 0x181F86620
	public static ModularCar Deserialize(Stream stream) { }

	// RVA: 0x1F85660 Offset: 0x1F83C60 VA: 0x181F85660
	public static ModularCar DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F85A80 Offset: 0x1F84080 VA: 0x181F85A80
	public static ModularCar DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F86230 Offset: 0x1F84830 VA: 0x181F86230
	public static ModularCar Deserialize(byte[] buffer) { }

	// RVA: 0x1F86D70 Offset: 0x1F85370 VA: 0x181F86D70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F87C50 Offset: 0x1F86250 VA: 0x181F87C50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F87C70 Offset: 0x1F86270 VA: 0x181F87C70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModularCar previous) { }

	// RVA: 0x1F87050 Offset: 0x1F85650 VA: 0x181F87050 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F85E60 Offset: 0x1F84460 VA: 0x181F85E60
	public static ModularCar Deserialize(byte[] buffer, ModularCar instance, bool isDelta = False) { }

	// RVA: 0x1F86940 Offset: 0x1F84F40 VA: 0x181F86940
	public static ModularCar Deserialize(Stream stream, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F852A0 Offset: 0x1F838A0 VA: 0x181F852A0
	public static ModularCar DeserializeLengthDelimited(Stream stream, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F856E0 Offset: 0x1F83CE0 VA: 0x181F856E0
	public static ModularCar DeserializeLength(Stream stream, int length, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F87580 Offset: 0x1F85B80 VA: 0x181F87580
	public static void SerializeDelta(Stream stream, ModularCar instance, ModularCar previous) { }

	// RVA: 0x1F87A80 Offset: 0x1F86080 VA: 0x181F87A80
	public static void Serialize(Stream stream, ModularCar instance) { }

	// RVA: 0x1F87C40 Offset: 0x1F86240 VA: 0x181F87C40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F87C50 Offset: 0x1F86250 VA: 0x181F87C50
	public void ToProto(Stream stream) { }

	// RVA: 0x1F87970 Offset: 0x1F85F70 VA: 0x181F87970
	public static byte[] SerializeToBytes(ModularCar instance) { }

	// RVA: 0x1F878C0 Offset: 0x1F85EC0 VA: 0x181F878C0
	public static void SerializeLengthDelimited(Stream stream, ModularCar instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1EFBB30 Offset: 0x1EFA130 VA: 0x181EFBB30
	public static void ResetToPool(VehicleLift instance) { }

	// RVA: 0x1EFBBE0 Offset: 0x1EFA1E0 VA: 0x181EFBBE0
	public void ResetToPool() { }

	// RVA: 0x1EFB780 Offset: 0x1EF9D80 VA: 0x181EFB780 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EFA430 Offset: 0x1EF8A30 VA: 0x181EFA430
	public void CopyTo(VehicleLift instance) { }

	// RVA: 0x1EFA470 Offset: 0x1EF8A70 VA: 0x181EFA470
	public VehicleLift Copy() { }

	// RVA: 0x1EFAF50 Offset: 0x1EF9550 VA: 0x181EFAF50
	public static VehicleLift Deserialize(Stream stream) { }

	// RVA: 0x1EFA4F0 Offset: 0x1EF8AF0 VA: 0x181EFA4F0
	public static VehicleLift DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFAB90 Offset: 0x1EF9190 VA: 0x181EFAB90
	public static VehicleLift DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFB430 Offset: 0x1EF9A30 VA: 0x181EFB430
	public static VehicleLift Deserialize(byte[] buffer) { }

	// RVA: 0x1EFB8C0 Offset: 0x1EF9EC0 VA: 0x181EFB8C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EFC1C0 Offset: 0x1EFA7C0 VA: 0x181EFC1C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EFC1E0 Offset: 0x1EFA7E0 VA: 0x181EFC1E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleLift previous) { }

	// RVA: 0x1EFBB10 Offset: 0x1EFA110 VA: 0x181EFBB10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFAC20 Offset: 0x1EF9220 VA: 0x181EFAC20
	public static VehicleLift Deserialize(byte[] buffer, VehicleLift instance, bool isDelta = False) { }

	// RVA: 0x1EFB1E0 Offset: 0x1EF97E0 VA: 0x181EFB1E0
	public static VehicleLift Deserialize(Stream stream, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EFA570 Offset: 0x1EF8B70 VA: 0x181EFA570
	public static VehicleLift DeserializeLengthDelimited(Stream stream, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EFA890 Offset: 0x1EF8E90 VA: 0x181EFA890
	public static VehicleLift DeserializeLength(Stream stream, int length, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EFBC90 Offset: 0x1EFA290 VA: 0x181EFBC90
	public static void SerializeDelta(Stream stream, VehicleLift instance, VehicleLift previous) { }

	// RVA: 0x1EFC040 Offset: 0x1EFA640 VA: 0x181EFC040
	public static void Serialize(Stream stream, VehicleLift instance) { }

	// RVA: 0x1EFC1B0 Offset: 0x1EFA7B0 VA: 0x181EFC1B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EFC1C0 Offset: 0x1EFA7C0 VA: 0x181EFC1C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EFBF30 Offset: 0x1EFA530 VA: 0x181EFBF30
	public static byte[] SerializeToBytes(VehicleLift instance) { }

	// RVA: 0x1EFBE80 Offset: 0x1EFA480 VA: 0x181EFBE80
	public static void SerializeLengthDelimited(Stream stream, VehicleLift instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1E75CB0 Offset: 0x1E742B0 VA: 0x181E75CB0
	public static void ResetToPool(EngineStorage instance) { }

	// RVA: 0x1E75D50 Offset: 0x1E74350 VA: 0x181E75D50
	public void ResetToPool() { }

	// RVA: 0x1E75950 Offset: 0x1E73F50 VA: 0x181E75950 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E74750 Offset: 0x1E72D50 VA: 0x181E74750
	public void CopyTo(EngineStorage instance) { }

	// RVA: 0x1E74780 Offset: 0x1E72D80 VA: 0x181E74780
	public EngineStorage Copy() { }

	// RVA: 0x1E74ED0 Offset: 0x1E734D0 VA: 0x181E74ED0
	public static EngineStorage Deserialize(Stream stream) { }

	// RVA: 0x1E74AF0 Offset: 0x1E730F0 VA: 0x181E74AF0
	public static EngineStorage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E74B70 Offset: 0x1E73170 VA: 0x181E74B70
	public static EngineStorage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E75420 Offset: 0x1E73A20 VA: 0x181E75420
	public static EngineStorage Deserialize(byte[] buffer) { }

	// RVA: 0x1E75A70 Offset: 0x1E74070 VA: 0x181E75A70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E76320 Offset: 0x1E74920 VA: 0x181E76320 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E76340 Offset: 0x1E74940 VA: 0x181E76340 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EngineStorage previous) { }

	// RVA: 0x1E75C90 Offset: 0x1E74290 VA: 0x181E75C90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E75130 Offset: 0x1E73730 VA: 0x181E75130
	public static EngineStorage Deserialize(byte[] buffer, EngineStorage instance, bool isDelta = False) { }

	// RVA: 0x1E75730 Offset: 0x1E73D30 VA: 0x181E75730
	public static EngineStorage Deserialize(Stream stream, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E74800 Offset: 0x1E72E00 VA: 0x181E74800
	public static EngineStorage DeserializeLengthDelimited(Stream stream, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E74C00 Offset: 0x1E73200 VA: 0x181E74C00
	public static EngineStorage DeserializeLength(Stream stream, int length, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E75DF0 Offset: 0x1E743F0 VA: 0x181E75DF0
	public static void SerializeDelta(Stream stream, EngineStorage instance, EngineStorage previous) { }

	// RVA: 0x1E761C0 Offset: 0x1E747C0 VA: 0x181E761C0
	public static void Serialize(Stream stream, EngineStorage instance) { }

	// RVA: 0x1E76310 Offset: 0x1E74910 VA: 0x181E76310
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E76320 Offset: 0x1E74920 VA: 0x181E76320
	public void ToProto(Stream stream) { }

	// RVA: 0x1E760B0 Offset: 0x1E746B0 VA: 0x181E760B0
	public static byte[] SerializeToBytes(EngineStorage instance) { }

	// RVA: 0x1E76000 Offset: 0x1E74600 VA: 0x181E76000
	public static void SerializeLengthDelimited(Stream stream, EngineStorage instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class VehicleVendor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6378
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VehicleVendor.PlayerStorage> playerStorage; // 0x18
	public uint spawnerRef; // 0x20

	// Methods

	// RVA: 0x1EFE4A0 Offset: 0x1EFCAA0 VA: 0x181EFE4A0
	public static void ResetToPool(VehicleVendor instance) { }

	// RVA: 0x1EFE680 Offset: 0x1EFCC80 VA: 0x181EFE680
	public void ResetToPool() { }

	// RVA: 0x1EFE3E0 Offset: 0x1EFC9E0 VA: 0x181EFE3E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EFD480 Offset: 0x1EFBA80 VA: 0x181EFD480
	public void CopyTo(VehicleVendor instance) { }

	// RVA: 0x1EFD620 Offset: 0x1EFBC20 VA: 0x181EFD620
	public VehicleVendor Copy() { }

	// RVA: 0x1EFE260 Offset: 0x1EFC860 VA: 0x181EFE260
	public static VehicleVendor Deserialize(Stream stream) { }

	// RVA: 0x1EFDB20 Offset: 0x1EFC120 VA: 0x181EFDB20
	public static VehicleVendor DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFDE80 Offset: 0x1EFC480 VA: 0x181EFDE80
	public static VehicleVendor DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFDF10 Offset: 0x1EFC510 VA: 0x181EFDF10
	public static VehicleVendor Deserialize(byte[] buffer) { }

	// RVA: 0x1EFE460 Offset: 0x1EFCA60 VA: 0x181EFE460
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EFEEB0 Offset: 0x1EFD4B0 VA: 0x181EFEEB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EFEED0 Offset: 0x1EFD4D0 VA: 0x181EFEED0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor previous) { }

	// RVA: 0x1EFE480 Offset: 0x1EFCA80 VA: 0x181EFE480 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFE2E0 Offset: 0x1EFC8E0 VA: 0x181EFE2E0
	public static VehicleVendor Deserialize(byte[] buffer, VehicleVendor instance, bool isDelta = False) { }

	// RVA: 0x1EFE030 Offset: 0x1EFC630 VA: 0x181EFE030
	public static VehicleVendor Deserialize(Stream stream, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EFD810 Offset: 0x1EFBE10 VA: 0x181EFD810
	public static VehicleVendor DeserializeLengthDelimited(Stream stream, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EFDBA0 Offset: 0x1EFC1A0 VA: 0x181EFDBA0
	public static VehicleVendor DeserializeLength(Stream stream, int length, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EFE860 Offset: 0x1EFCE60 VA: 0x181EFE860
	public static void SerializeDelta(Stream stream, VehicleVendor instance, VehicleVendor previous) { }

	// RVA: 0x1EFEC70 Offset: 0x1EFD270 VA: 0x181EFEC70
	public static void Serialize(Stream stream, VehicleVendor instance) { }

	// RVA: 0x1EFEEA0 Offset: 0x1EFD4A0 VA: 0x181EFEEA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EFEEB0 Offset: 0x1EFD4B0 VA: 0x181EFEEB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EFEB60 Offset: 0x1EFD160 VA: 0x181EFEB60
	public static byte[] SerializeToBytes(VehicleVendor instance) { }

	// RVA: 0x1EFEAB0 Offset: 0x1EFD0B0 VA: 0x181EFEAB0
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class VehicleVendor.PlayerStorage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6379
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong userid; // 0x18
	public List<VehicleVendor.PlayerStorage.PlayerStoredVehicle> storedVehicles; // 0x20

	// Methods

	// RVA: 0x1EE7780 Offset: 0x1EE5D80 VA: 0x181EE7780
	public static void ResetToPool(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE7940 Offset: 0x1EE5F40 VA: 0x181EE7940
	public void ResetToPool() { }

	// RVA: 0x1EE76C0 Offset: 0x1EE5CC0 VA: 0x181EE76C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE68C0 Offset: 0x1EE4EC0 VA: 0x181EE68C0
	public void CopyTo(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE6A70 Offset: 0x1EE5070 VA: 0x181EE6A70
	public VehicleVendor.PlayerStorage Copy() { }

	// RVA: 0x1EE7420 Offset: 0x1EE5A20 VA: 0x181EE7420
	public static VehicleVendor.PlayerStorage Deserialize(Stream stream) { }

	// RVA: 0x1EE6E00 Offset: 0x1EE5400 VA: 0x181EE6E00
	public static VehicleVendor.PlayerStorage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE6E80 Offset: 0x1EE5480 VA: 0x181EE6E80
	public static VehicleVendor.PlayerStorage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE74A0 Offset: 0x1EE5AA0 VA: 0x181EE74A0
	public static VehicleVendor.PlayerStorage Deserialize(byte[] buffer) { }

	// RVA: 0x1EE7740 Offset: 0x1EE5D40 VA: 0x181EE7740
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EE8130 Offset: 0x1EE6730 VA: 0x181EE8130 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EE8150 Offset: 0x1EE6750 VA: 0x181EE8150 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor.PlayerStorage previous) { }

	// RVA: 0x1EE7760 Offset: 0x1EE5D60 VA: 0x181EE7760 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE75C0 Offset: 0x1EE5BC0 VA: 0x181EE75C0
	public static VehicleVendor.PlayerStorage Deserialize(byte[] buffer, VehicleVendor.PlayerStorage instance, bool isDelta = False) { }

	// RVA: 0x1EE71F0 Offset: 0x1EE57F0 VA: 0x181EE71F0
	public static VehicleVendor.PlayerStorage Deserialize(Stream stream, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE6AF0 Offset: 0x1EE50F0 VA: 0x181EE6AF0
	public static VehicleVendor.PlayerStorage DeserializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE6F10 Offset: 0x1EE5510 VA: 0x181EE6F10
	public static VehicleVendor.PlayerStorage DeserializeLength(Stream stream, int length, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE7B00 Offset: 0x1EE6100 VA: 0x181EE7B00
	public static void SerializeDelta(Stream stream, VehicleVendor.PlayerStorage instance, VehicleVendor.PlayerStorage previous) { }

	// RVA: 0x1EE7F00 Offset: 0x1EE6500 VA: 0x181EE7F00
	public static void Serialize(Stream stream, VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE8120 Offset: 0x1EE6720 VA: 0x181EE8120
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EE8130 Offset: 0x1EE6730 VA: 0x181EE8130
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE7DF0 Offset: 0x1EE63F0 VA: 0x181EE7DF0
	public static byte[] SerializeToBytes(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE7D40 Offset: 0x1EE6340 VA: 0x181EE7D40
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1EE9510 Offset: 0x1EE7B10 VA: 0x181EE9510
	public static void ResetToPool(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE9440 Offset: 0x1EE7A40 VA: 0x181EE9440
	public void ResetToPool() { }

	// RVA: 0x1EE91D0 Offset: 0x1EE77D0 VA: 0x181EE91D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE8170 Offset: 0x1EE6770 VA: 0x181EE8170
	public void CopyTo(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE81C0 Offset: 0x1EE67C0 VA: 0x181EE81C0
	public VehicleVendor.PlayerStorage.PlayerStoredVehicle Copy() { }

	// RVA: 0x1EE8D00 Offset: 0x1EE7300 VA: 0x181EE8D00
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(Stream stream) { }

	// RVA: 0x1EE8500 Offset: 0x1EE6B00 VA: 0x181EE8500
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE8800 Offset: 0x1EE6E00 VA: 0x181EE8800
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE8F10 Offset: 0x1EE7510 VA: 0x181EE8F10
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1EE9250 Offset: 0x1EE7850 VA: 0x181EE9250
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EE9B70 Offset: 0x1EE8170 VA: 0x181EE9B70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EE9B90 Offset: 0x1EE8190 VA: 0x181EE9B90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle previous) { }

	// RVA: 0x1EE9420 Offset: 0x1EE7A20 VA: 0x181EE9420 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE8890 Offset: 0x1EE6E90 VA: 0x181EE8890
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(byte[] buffer, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta = False) { }

	// RVA: 0x1EE8B30 Offset: 0x1EE7130 VA: 0x181EE8B30
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE8260 Offset: 0x1EE6860 VA: 0x181EE8260
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE8580 Offset: 0x1EE6B80 VA: 0x181EE8580
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLength(Stream stream, int length, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE95E0 Offset: 0x1EE7BE0 VA: 0x181EE95E0
	public static void SerializeDelta(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, VehicleVendor.PlayerStorage.PlayerStoredVehicle previous) { }

	// RVA: 0x1EE99B0 Offset: 0x1EE7FB0 VA: 0x181EE99B0
	public static void Serialize(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE9B60 Offset: 0x1EE8160 VA: 0x181EE9B60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EE9B70 Offset: 0x1EE8170 VA: 0x181EE9B70
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE98A0 Offset: 0x1EE7EA0 VA: 0x181EE98A0
	public static byte[] SerializeToBytes(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE97F0 Offset: 0x1EE7DF0 VA: 0x181EE97F0
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class VehicleModule : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6385
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int socketIndex; // 0x14

	// Methods

	// RVA: 0x1EFCCB0 Offset: 0x1EFB2B0 VA: 0x181EFCCB0
	public static void ResetToPool(VehicleModule instance) { }

	// RVA: 0x1EFCD30 Offset: 0x1EFB330 VA: 0x181EFCD30
	public void ResetToPool() { }

	// RVA: 0x1EFCB80 Offset: 0x1EFB180 VA: 0x181EFCB80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(VehicleModule instance) { }

	// RVA: 0x1EFC200 Offset: 0x1EFA800 VA: 0x181EFC200
	public VehicleModule Copy() { }

	// RVA: 0x1EFCB00 Offset: 0x1EFB100 VA: 0x181EFCB00
	public static VehicleModule Deserialize(Stream stream) { }

	// RVA: 0x1EFC270 Offset: 0x1EFA870 VA: 0x181EFC270
	public static VehicleModule DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFC710 Offset: 0x1EFAD10 VA: 0x181EFC710
	public static VehicleModule DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFC9E0 Offset: 0x1EFAFE0 VA: 0x181EFC9E0
	public static VehicleModule Deserialize(byte[] buffer) { }

	// RVA: 0x1EFCC70 Offset: 0x1EFB270 VA: 0x181EFCC70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EFD200 Offset: 0x1EFB800 VA: 0x181EFD200 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EFD2D0 Offset: 0x1EFB8D0 VA: 0x181EFD2D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleModule previous) { }

	// RVA: 0x1EFCC90 Offset: 0x1EFB290 VA: 0x181EFCC90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFC7A0 Offset: 0x1EFADA0 VA: 0x181EFC7A0
	public static VehicleModule Deserialize(byte[] buffer, VehicleModule instance, bool isDelta = False) { }

	// RVA: 0x1EFC8A0 Offset: 0x1EFAEA0 VA: 0x181EFC8A0
	public static VehicleModule Deserialize(Stream stream, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EFC2F0 Offset: 0x1EFA8F0 VA: 0x181EFC2F0
	public static VehicleModule DeserializeLengthDelimited(Stream stream, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EFC510 Offset: 0x1EFAB10 VA: 0x181EFC510
	public static VehicleModule DeserializeLength(Stream stream, int length, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EFCDB0 Offset: 0x1EFB3B0 VA: 0x181EFCDB0
	public static void SerializeDelta(Stream stream, VehicleModule instance, VehicleModule previous) { }

	// RVA: 0x1EFD120 Offset: 0x1EFB720 VA: 0x181EFD120
	public static void Serialize(Stream stream, VehicleModule instance) { }

	// RVA: 0x1EFD1F0 Offset: 0x1EFB7F0 VA: 0x181EFD1F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EFD200 Offset: 0x1EFB800 VA: 0x181EFD200
	public void ToProto(Stream stream) { }

	// RVA: 0x1EFCF70 Offset: 0x1EFB570 VA: 0x181EFCF70
	public static byte[] SerializeToBytes(VehicleModule instance) { }

	// RVA: 0x1EFCEC0 Offset: 0x1EFB4C0 VA: 0x181EFCEC0
	public static void SerializeLengthDelimited(Stream stream, VehicleModule instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1F75A20 Offset: 0x1F74020 VA: 0x181F75A20
	public static void ResetToPool(CamperModule instance) { }

	// RVA: 0x1F75AB0 Offset: 0x1F740B0 VA: 0x181F75AB0
	public void ResetToPool() { }

	// RVA: 0x1F75740 Offset: 0x1F73D40 VA: 0x181F75740 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E28F40 Offset: 0x1E27540 VA: 0x181E28F40
	public void CopyTo(CamperModule instance) { }

	// RVA: 0x1F74810 Offset: 0x1F72E10 VA: 0x181F74810
	public CamperModule Copy() { }

	// RVA: 0x1F75030 Offset: 0x1F73630 VA: 0x181F75030
	public static CamperModule Deserialize(Stream stream) { }

	// RVA: 0x1F74890 Offset: 0x1F72E90 VA: 0x181F74890
	public static CamperModule DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F74B90 Offset: 0x1F73190 VA: 0x181F74B90
	public static CamperModule DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F75220 Offset: 0x1F73820 VA: 0x181F75220
	public static CamperModule Deserialize(byte[] buffer) { }

	// RVA: 0x1F75850 Offset: 0x1F73E50 VA: 0x181F75850
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F75FF0 Offset: 0x1F745F0 VA: 0x181F75FF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F76010 Offset: 0x1F74610 VA: 0x181F76010 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CamperModule previous) { }

	// RVA: 0x1F75A00 Offset: 0x1F74000 VA: 0x181F75A00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F754C0 Offset: 0x1F73AC0 VA: 0x181F754C0
	public static CamperModule Deserialize(byte[] buffer, CamperModule instance, bool isDelta = False) { }

	// RVA: 0x1F74E80 Offset: 0x1F73480 VA: 0x181F74E80
	public static CamperModule Deserialize(Stream stream, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F74910 Offset: 0x1F72F10 VA: 0x181F74910
	public static CamperModule DeserializeLengthDelimited(Stream stream, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F74C20 Offset: 0x1F73220 VA: 0x181F74C20
	public static CamperModule DeserializeLength(Stream stream, int length, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F75B40 Offset: 0x1F74140 VA: 0x181F75B40
	public static void SerializeDelta(Stream stream, CamperModule instance, CamperModule previous) { }

	// RVA: 0x1F75EC0 Offset: 0x1F744C0 VA: 0x181F75EC0
	public static void Serialize(Stream stream, CamperModule instance) { }

	// RVA: 0x1F75FE0 Offset: 0x1F745E0 VA: 0x181F75FE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F75FF0 Offset: 0x1F745F0 VA: 0x181F75FF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F75DB0 Offset: 0x1F743B0 VA: 0x181F75DB0
	public static byte[] SerializeToBytes(CamperModule instance) { }

	// RVA: 0x1F75D00 Offset: 0x1F74300 VA: 0x181F75D00
	public static void SerializeLengthDelimited(Stream stream, CamperModule instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x935FF0 Offset: 0x9345F0 VA: 0x180935FF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x937260 Offset: 0x935860 VA: 0x180937260 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x936D80 Offset: 0x935380 VA: 0x180936D80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x936FA0 Offset: 0x9355A0 VA: 0x180936FA0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x935F80 Offset: 0x934580 VA: 0x180935F80 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x936F10 Offset: 0x935510 VA: 0x180936F10 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 186
	public virtual void InitializeClientEffects() { }

	// RVA: 0x935FD0 Offset: 0x9345D0 VA: 0x180935FD0 Slot: 187
	public virtual float GetHUDHealth() { }

	// RVA: 0x9354B0 Offset: 0x933AB0 VA: 0x1809354B0 Slot: 188
	public virtual float GetHUDMaxHealth() { }

	// RVA: 0x936940 Offset: 0x934F40 VA: 0x180936940 Slot: 169
	public override bool LocalPlayerIsMounted() { }

	// RVA: 0x936B80 Offset: 0x935180 VA: 0x180936B80 Slot: 189
	public virtual bool Menu_Push_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	[BaseEntity.Menu.Description] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	[BaseEntity.Menu.Icon] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	[BaseEntity.Menu.ShowIf] // RVA: 0xCBA80 Offset: 0xCAE80 VA: 0x1800CBA80
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x936A90 Offset: 0x935090 VA: 0x180936A90 Slot: 190
	protected virtual bool Menu_Occupied_ShowIf(BasePlayer player) { }

	// RVA: 0x936A00 Offset: 0x935000 VA: 0x180936A00 Slot: 183
	public override bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x937190 Offset: 0x935790 VA: 0x180937190 Slot: 191
	protected virtual void WorkshopMode() { }

	// RVA: 0x8CEC20 Offset: 0x8CD220 VA: 0x1808CEC20
	public bool IsStationary() { }

	// RVA: 0x936920 Offset: 0x934F20 VA: 0x180936920
	public bool IsMoving() { }

	// RVA: 0x937330 Offset: 0x935930 VA: 0x180937330
	public bool get_IsMovingOrOn() { }

	// RVA: 0x937370 Offset: 0x935970 VA: 0x180937370 Slot: 76
	public override float get_RealisticMass() { }

	// RVA: 0x936E70 Offset: 0x935470 VA: 0x180936E70 Slot: 157
	public override bool PlayerIsMounted(BasePlayer player) { }

	// RVA: 0x6FDC80 Offset: 0x6FC280 VA: 0x1806FDC80 Slot: 192
	protected virtual bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x936630 Offset: 0x934C30 VA: 0x180936630
	public bool HasMountPoints() { }

	// RVA: 0x9368C0 Offset: 0x934EC0 VA: 0x1809368C0 Slot: 153
	public override bool IsMounted() { }

	// RVA: 0x935EF0 Offset: 0x9344F0 VA: 0x180935EF0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x9367F0 Offset: 0x934DF0 VA: 0x1809367F0
	public bool IsFlipped() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 193
	public virtual bool IsVehicleRoot() { }

	// RVA: 0x935FB0 Offset: 0x9345B0 VA: 0x180935FB0 Slot: 147
	public override bool DirectlyMountable() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 170
	public override BaseVehicle VehicleParent() { }

	// RVA: 0x936BA0 Offset: 0x9351A0 VA: 0x180936BA0 Slot: 22
	protected override void OnChildAdded(BaseEntity child) { }

	// RVA: 0x936CB0 Offset: 0x9352B0 VA: 0x180936CB0 Slot: 23
	protected override void OnChildRemoved(BaseEntity child) { }

	// RVA: 0x937410 Offset: 0x935A10 VA: 0x180937410
	public BaseVehicle.Enumerable get_allMountPoints() { }

	// RVA: 0x936300 Offset: 0x934900 VA: 0x180936300
	public BaseVehicle.MountPointInfo GetMountPoint(int index) { }

	// RVA: 0x9371B0 Offset: 0x9357B0 VA: 0x1809371B0
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

	// RVA: 0x93AE10 Offset: 0x939410 VA: 0x18093AE10
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

	// RVA: 0x93A6C0 Offset: 0x938CC0 VA: 0x18093A6C0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x93A6C0 Offset: 0x938CC0 VA: 0x18093A6C0 Slot: 5
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

	// RVA: 0x932FF0 Offset: 0x9315F0 VA: 0x180932FF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x935760 Offset: 0x933D60 VA: 0x180935760 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x934320 Offset: 0x932920 VA: 0x180934320 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9328A0 Offset: 0x930EA0 VA: 0x1809328A0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x932B50 Offset: 0x931150 VA: 0x180932B50 Slot: 194
	public virtual void ClientVehicleTick() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 195
	public virtual void OnClientTickStopped() { }

	// RVA: 0x932920 Offset: 0x930F20 VA: 0x180932920 Slot: 196
	public virtual void ClientOnLoad() { }

	// RVA: 0x932CB0 Offset: 0x9312B0 VA: 0x180932CB0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x935430 Offset: 0x933A30 VA: 0x180935430
	public void SetLightState(bool headlightsOn, bool brakesOn) { }

	// RVA: 0x9326B0 Offset: 0x930CB0 VA: 0x1809326B0
	public void ClearDecals(BaseVehicleModule.DecalType decalType) { }

	// RVA: 0x932D20 Offset: 0x931320 VA: 0x180932D20
	public void DrawHighlight() { }

	// RVA: 0x933BA0 Offset: 0x9321A0 VA: 0x180933BA0 Slot: 183
	public override bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Description] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Icon] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	// RVA: 0x933D20 Offset: 0x932320 VA: 0x180933D20
	public void Menu_Push(BasePlayer player) { }

	// RVA: 0x933C70 Offset: 0x932270 VA: 0x180933C70 Slot: 189
	public override bool Menu_Push_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	[BaseEntity.Menu.Description] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	[BaseEntity.Menu.Icon] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	[BaseEntity.Menu.ShowIf] // RVA: 0xCD080 Offset: 0xCC480 VA: 0x1800CD080
	// RVA: 0x9340C0 Offset: 0x9326C0 VA: 0x1809340C0
	public void Menu_Use(BasePlayer player) { }

	// RVA: 0x933DC0 Offset: 0x9323C0 VA: 0x180933DC0
	public bool Menu_Use_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	[BaseEntity.Menu.Description] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	[BaseEntity.Menu.Icon] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	[BaseEntity.Menu.ShowIf] // RVA: 0xCD300 Offset: 0xCC700 VA: 0x1800CD300
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Locked(BasePlayer player) { }

	// RVA: 0x933A50 Offset: 0x932050 VA: 0x180933A50 Slot: 197
	public virtual bool Menu_Locked_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935960 Offset: 0x933F60 VA: 0x180935960
	public BaseModularVehicle get_Vehicle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935980 Offset: 0x933F80 VA: 0x180935980
	private void set_Vehicle(BaseModularVehicle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935750 Offset: 0x933D50 VA: 0x180935750
	public int get_FirstSocketIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x935970 Offset: 0x933F70 VA: 0x180935970
	private void set_FirstSocketIndex(int value) { }

	// RVA: 0x935710 Offset: 0x933D10 VA: 0x180935710
	public Vector3 get_CentreOfMass() { }

	// RVA: 0x935950 Offset: 0x933F50 VA: 0x180935950
	public float get_Mass() { }

	// RVA: 0x52EE80 Offset: 0x52D480 VA: 0x18052EE80
	public uint get_ID() { }

	// RVA: 0x9358F0 Offset: 0x933EF0 VA: 0x1809358F0
	public bool get_IsOnAVehicle() { }

	// RVA: 0x77AA90 Offset: 0x779090 VA: 0x18077AA90
	public ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 198
	public virtual bool get_HasSeating() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 199
	public virtual bool get_HasAnEngine() { }

	// RVA: 0x934450 Offset: 0x932A50 VA: 0x180934450 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x935230 Offset: 0x933830 VA: 0x180935230
	public void RefreshParameters() { }

	// RVA: 0x934260 Offset: 0x932860 VA: 0x180934260 Slot: 200
	public virtual void ModuleAdded(BaseModularVehicle vehicle, int firstSocketIndex) { }

	// RVA: 0x9342F0 Offset: 0x9328F0 VA: 0x1809342F0 Slot: 201
	public virtual void ModuleRemoved() { }

	// RVA: 0x934410 Offset: 0x932A10 VA: 0x180934410
	public void OtherVehicleModulesChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 202
	public virtual void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState) { }

	// RVA: 0x9339B0 Offset: 0x931FB0 VA: 0x1809339B0 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x9354B0 Offset: 0x933AB0 VA: 0x1809354B0 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x9337A0 Offset: 0x931DA0 VA: 0x1809337A0
	public int GetNumSocketsTaken() { }

	// RVA: 0x932E50 Offset: 0x931450 VA: 0x180932E50
	public List<ConditionalObject> GetConditionals() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 203
	public virtual float GetMaxDriveForce() { }

	// RVA: 0x935010 Offset: 0x933610 VA: 0x180935010
	public void RefreshConditionals(bool canGib) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 204
	protected virtual void PostConditionalRefresh() { }

	// RVA: 0x934530 Offset: 0x932B30 VA: 0x180934530
	private void RefreshConditional(ConditionalObject conditional, bool canGib) { }

	// RVA: 0x935620 Offset: 0x933C20 VA: 0x180935620
	private bool TryGetAdjacentModuleInFront(out BaseVehicleModule result) { }

	// RVA: 0x9354D0 Offset: 0x933AD0 VA: 0x1809354D0
	private bool TryGetAdjacentModuleBehind(out BaseVehicleModule result) { }

	// RVA: 0x933840 Offset: 0x931E40 VA: 0x180933840
	private bool InSameVisualGroupAs(BaseVehicleModule moduleEntity, ConditionalObject.AdjacentMatchType matchType) { }

	// RVA: 0x932550 Offset: 0x930B50 VA: 0x180932550
	private bool CanBeUsedNowBy(BasePlayer player) { }

	// RVA: 0x934420 Offset: 0x932A20 VA: 0x180934420
	public bool PlayerIsLookingAtUsable(string lookingAtColldierName, string usableColliderName) { }

	// RVA: 0x933940 Offset: 0x931F40 VA: 0x180933940 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 193
	public override bool IsVehicleRoot() { }

	// RVA: 0x9356E0 Offset: 0x933CE0 VA: 0x1809356E0
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

	// RVA: 0x8C3B00 Offset: 0x8C2100 VA: 0x1808C3B00 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8C4200 Offset: 0x8C2800 VA: 0x1808C4200 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8C40B0 Offset: 0x8C26B0 VA: 0x1808C40B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	[BaseEntity.Menu.Description] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	[BaseEntity.Menu.Icon] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	[BaseEntity.Menu.ShowIf] // RVA: 0xDC460 Offset: 0xDB860 VA: 0x1800DC460
	// RVA: 0x8C4030 Offset: 0x8C2630 VA: 0x1808C4030
	public void Menu_StartEngine(BasePlayer player) { }

	// RVA: 0x50DEE0 Offset: 0x50C4E0 VA: 0x18050DEE0
	public bool Menu_EngineOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	[BaseEntity.Menu.Description] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	[BaseEntity.Menu.Icon] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	[BaseEntity.Menu.ShowIf] // RVA: 0xDD950 Offset: 0xDCD50 VA: 0x1800DD950
	// RVA: 0x8C4070 Offset: 0x8C2670 VA: 0x1808C4070
	public void Menu_StopEngine(BasePlayer player) { }

	// RVA: 0x4F62A0 Offset: 0x4F48A0 VA: 0x1804F62A0
	public bool Menu_EngineOff_ShowIf(BasePlayer player) { }

	// RVA: 0x8C41A0 Offset: 0x8C27A0 VA: 0x1808C41A0
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

	// RVA: 0x778510 Offset: 0x776B10 VA: 0x180778510 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x77AAC0 Offset: 0x7790C0 VA: 0x18077AAC0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x779A40 Offset: 0x778040 VA: 0x180779A40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AC70 Offset: 0x779270 VA: 0x18077AC70
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFL() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77ACB0 Offset: 0x7792B0 VA: 0x18077ACB0
	private void set_WheelDataFL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AC80 Offset: 0x779280 VA: 0x18077AC80
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFR() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77ACC0 Offset: 0x7792C0 VA: 0x18077ACC0
	private void set_WheelDataFR(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77AC90 Offset: 0x779290 VA: 0x18077AC90
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRL() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77ACD0 Offset: 0x7792D0 VA: 0x18077ACD0
	private void set_WheelDataRL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77ACA0 Offset: 0x7792A0 VA: 0x18077ACA0
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRR() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77ACE0 Offset: 0x7792E0 VA: 0x18077ACE0
	private void set_WheelDataRR(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	// RVA: 0x777BC0 Offset: 0x7761C0 VA: 0x180777BC0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7798F0 Offset: 0x777EF0 VA: 0x1807798F0 Slot: 132
	protected override void OnLifeStateChanged() { }

	// RVA: 0x777FD0 Offset: 0x7765D0 VA: 0x180777FD0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x778BC0 Offset: 0x7771C0 VA: 0x180778BC0
	public bool HasAnEngineAtLowPerformance() { }

	// RVA: 0x778DD0 Offset: 0x7773D0 VA: 0x180778DD0
	public bool HasLowFuel() { }

	// RVA: 0x778B80 Offset: 0x777180 VA: 0x180778B80
	public bool HadRecentFailedEngineStart() { }

	// RVA: 0x77A700 Offset: 0x778D00 VA: 0x18077A700 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0x778AA0 Offset: 0x7770A0 VA: 0x180778AA0 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0x779830 Offset: 0x777E30 VA: 0x180779830 Slot: 201
	protected override void OnClientTickStopped() { }

	// RVA: 0x778E80 Offset: 0x777480 VA: 0x180778E80 Slot: 204
	protected override bool IsBraking() { }

	[BaseEntity.Menu] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Description] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Icon] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	// RVA: 0x7791A0 Offset: 0x7777A0 VA: 0x1807791A0
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x7790D0 Offset: 0x7776D0 VA: 0x1807790D0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	[BaseEntity.Menu.Description] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	[BaseEntity.Menu.Icon] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	[BaseEntity.Menu.ShowIf] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Locked(BasePlayer player) { }

	// RVA: 0x7791E0 Offset: 0x7777E0 VA: 0x1807791E0
	public bool Menu_Locked_ShowIf(BasePlayer player) { }

	// RVA: 0x779640 Offset: 0x777C40 VA: 0x180779640 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x7780C0 Offset: 0x7766C0 VA: 0x1807780C0 Slot: 187
	public override float GetHUDHealth() { }

	// RVA: 0x778190 Offset: 0x776790 VA: 0x180778190 Slot: 188
	public override float GetHUDMaxHealth() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7792C0 Offset: 0x7778C0 VA: 0x1807792C0
	private void ModularCarUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x778000 Offset: 0x776600 VA: 0x180778000
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x77AAB0 Offset: 0x7790B0 VA: 0x18077AAB0 Slot: 196
	public override float get_DriveWheelVelocity() { }

	// RVA: 0x77AAA0 Offset: 0x7790A0 VA: 0x18077AAA0
	public float get_DriveWheelSlip() { }

	// RVA: 0x77AC60 Offset: 0x779260 VA: 0x18077AC60 Slot: 215
	public float get_SteerAngle() { }

	// RVA: 0x77AA90 Offset: 0x779090 VA: 0x18077AA90
	public ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0x77AC40 Offset: 0x779240 VA: 0x18077AC40 Slot: 216
	public float get_MaxSteerAngle() { }

	// RVA: 0x77AC10 Offset: 0x779210 VA: 0x18077AC10 Slot: 206
	public override bool get_IsLockable() { }

	// RVA: 0x77A3C0 Offset: 0x7789C0 VA: 0x18077A3C0 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x778DF0 Offset: 0x7773F0 VA: 0x180778DF0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x7790A0 Offset: 0x7776A0 VA: 0x1807790A0 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x7790A0 Offset: 0x7776A0 VA: 0x1807790A0 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x7780C0 Offset: 0x7766C0 VA: 0x1807780C0
	public float TotalHealth() { }

	// RVA: 0x778190 Offset: 0x776790 VA: 0x180778190
	public float TotalMaxHealth() { }

	// RVA: 0x778380 Offset: 0x776980 VA: 0x180778380 Slot: 197
	public override float GetMaxForwardSpeed() { }

	// RVA: 0x778EB0 Offset: 0x7774B0 VA: 0x180778EB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7798B0 Offset: 0x777EB0 VA: 0x1807798B0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x778A70 Offset: 0x777070 VA: 0x180778A70 Slot: 198
	public override float GetThrottleInput() { }

	// RVA: 0x778080 Offset: 0x776680 VA: 0x180778080 Slot: 199
	public override float GetBrakeInput() { }

	// RVA: 0x778260 Offset: 0x776860 VA: 0x180778260
	public float GetMaxDriveForce() { }

	// RVA: 0x7780B0 Offset: 0x7766B0 VA: 0x1807780B0
	public float GetFuelFraction() { }

	// RVA: 0x77A390 Offset: 0x778990 VA: 0x18077A390 Slot: 210
	public bool PlayerHasUnlockPermission(BasePlayer player) { }

	// RVA: 0x77A330 Offset: 0x778930 VA: 0x18077A330 Slot: 207
	public override bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0x77A2E0 Offset: 0x7788E0 VA: 0x18077A2E0 Slot: 212
	public bool PlayerCanDestroyLock(BasePlayer player, BaseVehicleModule viaModule) { }

	// RVA: 0x777A40 Offset: 0x776040 VA: 0x180777A40 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x777B50 Offset: 0x776150 VA: 0x180777B50 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x77A4C0 Offset: 0x778AC0 VA: 0x18077A4C0
	protected bool RefreshEngineState() { }

	// RVA: 0x77A690 Offset: 0x778C90 VA: 0x18077A690
	private float RollOffDriveForce(float driveForce) { }

	// RVA: 0x77A470 Offset: 0x778A70 VA: 0x18077A470
	private void RefreshChassisProtectionState() { }

	// RVA: 0x7793E0 Offset: 0x7779E0 VA: 0x1807793E0 Slot: 208
	protected override void ModuleEntityAdded(BaseVehicleModule addedModule) { }

	// RVA: 0x779510 Offset: 0x777B10 VA: 0x180779510 Slot: 209
	protected override void ModuleEntityRemoved(BaseVehicleModule removedModule) { }

	// RVA: 0x77AA70 Offset: 0x779070 VA: 0x18077AA70
	public void .ctor() { }

	// RVA: 0x77AA00 Offset: 0x779000 VA: 0x18077AA00
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

	// RVA: 0x77EB00 Offset: 0x77D100 VA: 0x18077EB00
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

	// RVA: 0x775660 Offset: 0x773C60 VA: 0x180775660 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x776D20 Offset: 0x775320 VA: 0x180776D20 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x776410 Offset: 0x774A10 VA: 0x180776410 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7754C0 Offset: 0x773AC0 VA: 0x1807754C0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x776AC0 Offset: 0x7750C0 VA: 0x180776AC0
	public void TryRepair(uint itemUID) { }

	// RVA: 0x775BB0 Offset: 0x7741B0 VA: 0x180775BB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7755F0 Offset: 0x773BF0 VA: 0x1807755F0
	public void ClientSelectedLootItem(Item item) { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 165
	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x776500 Offset: 0x774B00 VA: 0x180776500
	private bool PlayerHasInternalModuleLoot() { }

	// RVA: 0x775530 Offset: 0x773B30 VA: 0x180775530
	public void ClientRequestAddLock() { }

	// RVA: 0x7755B0 Offset: 0x773BB0 VA: 0x1807755B0
	public void ClientRequestRemoveLock() { }

	// RVA: 0x775570 Offset: 0x773B70 VA: 0x180775570
	public void ClientRequestNewKey() { }

	// RVA: 0x7767C0 Offset: 0x774DC0 VA: 0x1807767C0
	private void RefreshPoweredLightState() { }

	// RVA: 0x776730 Offset: 0x774D30 VA: 0x180776730
	private void RefreshInUseLightState() { }

	[BaseEntity.Menu] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	[BaseEntity.Menu.Description] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	[BaseEntity.Menu.Icon] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	[BaseEntity.Menu.ShowIf] // RVA: 0x77310 Offset: 0x76710 VA: 0x180077310
	// RVA: 0x775EE0 Offset: 0x7744E0 VA: 0x180775EE0
	public void Menu_EditVehicle(BasePlayer player) { }

	// RVA: 0x775DE0 Offset: 0x7743E0 VA: 0x180775DE0
	public bool Menu_EditVehicle_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	[BaseEntity.Menu.Description] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	[BaseEntity.Menu.Icon] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	[BaseEntity.Menu.ShowIf] // RVA: 0x77650 Offset: 0x76A50 VA: 0x180077650
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_InsufficientPower(BasePlayer player) { }

	// RVA: 0x775F20 Offset: 0x774520 VA: 0x180775F20
	public bool Menu_InsufficientPower_ShowIf(BasePlayer player) { }

	// RVA: 0x7768C0 Offset: 0x774EC0 VA: 0x1807768C0
	public void StartChassisDestroy() { }

	// RVA: 0x775460 Offset: 0x773A60 VA: 0x180775460
	public void CancelChassisDestroy() { }

	// RVA: 0x776EF0 Offset: 0x7754F0 VA: 0x180776EF0
	public float get_TimeLeftToCancelChassisDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776EE0 Offset: 0x7754E0 VA: 0x180776EE0
	public bool get_PlatformIsOccupied() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776FD0 Offset: 0x7755D0 VA: 0x180776FD0
	private void set_PlatformIsOccupied(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776D10 Offset: 0x775310 VA: 0x180776D10
	public bool get_HasEditableOccupant() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776FA0 Offset: 0x7755A0 VA: 0x180776FA0
	private void set_HasEditableOccupant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776D00 Offset: 0x775300 VA: 0x180776D00
	public bool get_HasDriveableOccupant() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776F90 Offset: 0x775590 VA: 0x180776F90
	private void set_HasDriveableOccupant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776ED0 Offset: 0x7754D0 VA: 0x180776ED0
	public ModularCarGarage.OccupantLock get_OccupantLockState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776FC0 Offset: 0x7755C0 VA: 0x180776FC0
	private void set_OccupantLockState(ModularCarGarage.OccupantLock value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776EC0 Offset: 0x7754C0 VA: 0x180776EC0
	public int get_OccupantLockID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776FB0 Offset: 0x7755B0 VA: 0x180776FB0
	private void set_OccupantLockID(int value) { }

	// RVA: 0x776EB0 Offset: 0x7754B0 VA: 0x180776EB0
	private bool get_LiftIsUp() { }

	// RVA: 0x776E80 Offset: 0x775480 VA: 0x180776E80
	private bool get_LiftIsMoving() { }

	// RVA: 0x776E70 Offset: 0x775470 VA: 0x180776E70
	private bool get_LiftIsDown() { }

	// RVA: 0x557EE0 Offset: 0x5564E0 VA: 0x180557EE0
	public bool get_IsDestroyingChassis() { }

	// RVA: 0x7766D0 Offset: 0x774CD0 VA: 0x1807766D0 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x7763B0 Offset: 0x7749B0 VA: 0x1807763B0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5B03C0 Offset: 0x5AE9C0 VA: 0x1805B03C0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x6F35A0 Offset: 0x6F1BA0 VA: 0x1806F35A0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x776800 Offset: 0x774E00 VA: 0x180776800
	private void SetOccupantState(bool hasOccupant, bool editableOccupant, bool driveableOccupant, ModularCarGarage.OccupantLock occupantLockState, int occupantLockID, bool forced = False) { }

	// RVA: 0x776760 Offset: 0x774D60 VA: 0x180776760
	private void RefreshLiftState(bool forced = False) { }

	// RVA: 0x776210 Offset: 0x774810 VA: 0x180776210
	private void MoveLift(ModularCarGarage.VehicleLiftState desiredLiftState, float startDelay = 0, bool forced = False) { }

	// RVA: 0x776190 Offset: 0x774790 VA: 0x180776190
	private void MoveLiftUp() { }

	// RVA: 0x775FE0 Offset: 0x7745E0 VA: 0x180775FE0
	private void MoveLiftDown() { }

	// RVA: 0x776910 Offset: 0x774F10 VA: 0x180776910
	private void StartLiftSounds() { }

	// RVA: 0x776B10 Offset: 0x775110 VA: 0x180776B10
	private void UpdateLiftSounds() { }

	// RVA: 0x776CA0 Offset: 0x7752A0 VA: 0x180776CA0
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

	// RVA: 0x7D54E0 Offset: 0x7D3AE0 VA: 0x1807D54E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7D7CA0 Offset: 0x7D62A0 VA: 0x1807D7CA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7D6390 Offset: 0x7D4990 VA: 0x1807D6390 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7D6ED0 Offset: 0x7D54D0 VA: 0x1807D6ED0
	public void UpdateSounds() { }

	// RVA: 0x7D5D90 Offset: 0x7D4390 VA: 0x1807D5D90 Slot: 28
	public override void InitShared() { }

	// RVA: 0x7D6DB0 Offset: 0x7D53B0 VA: 0x1807D6DB0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x7D7A90 Offset: 0x7D6090 VA: 0x1807D7A90
	public void Update() { }

	// RVA: 0x7D7570 Offset: 0x7D5B70 VA: 0x1807D7570
	public void UpdateWake() { }

	// RVA: 0x7D6670 Offset: 0x7D4C70 VA: 0x1807D6670
	public void UpdateEffects() { }

	// RVA: 0x7D5E40 Offset: 0x7D4440 VA: 0x1807D5E40 Slot: 186
	public override void InitializeClientEffects() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 196
	public virtual void ShutdownClientEffects() { }

	// RVA: 0x7D6AD0 Offset: 0x7D50D0 VA: 0x1807D6AD0 Slot: 197
	public virtual void UpdateEngineRotation() { }

	// RVA: 0x7D6560 Offset: 0x7D4B60 VA: 0x1807D6560 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x7D6320 Offset: 0x7D4920 VA: 0x1807D6320 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x67E030 Offset: 0x67C630 VA: 0x18067E030 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x7D5FD0 Offset: 0x7D45D0 VA: 0x1807D5FD0 Slot: 198
	public virtual bool LookingAtEngine(BasePlayer player) { }

	// RVA: 0x6A1870 Offset: 0x69FE70 VA: 0x1806A1870 Slot: 199
	public virtual bool LookingAtFuelArea(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	[BaseEntity.Menu.Description] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	[BaseEntity.Menu.Icon] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A140 Offset: 0x79540 VA: 0x18007A140
	// RVA: 0x7D6200 Offset: 0x7D4800 VA: 0x1807D6200
	public void Menu_StartEngine(BasePlayer player) { }

	// RVA: 0x7D6160 Offset: 0x7D4760 VA: 0x1807D6160
	public bool Menu_StartEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	[BaseEntity.Menu.Description] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	[BaseEntity.Menu.Icon] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A540 Offset: 0x79940 VA: 0x18007A540
	// RVA: 0x7D62D0 Offset: 0x7D48D0 VA: 0x1807D62D0
	public void Menu_StopEngine(BasePlayer player) { }

	// RVA: 0x7D6250 Offset: 0x7D4850 VA: 0x1807D6250
	public bool Menu_StopEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	[BaseEntity.Menu.Description] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	[BaseEntity.Menu.Icon] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A840 Offset: 0x79C40 VA: 0x18007A840
	// RVA: 0x7D6120 Offset: 0x7D4720 VA: 0x1807D6120
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x7D60B0 Offset: 0x7D46B0 VA: 0x1807D60B0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x7D6480 Offset: 0x7D4A80 VA: 0x1807D6480 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x7D5290 Offset: 0x7D3890 VA: 0x1807D5290 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x7D65D0 Offset: 0x7D4BD0 VA: 0x1807D65D0
	private bool ShowPushMenu(BasePlayer player) { }

	// RVA: 0x7D5F20 Offset: 0x7D4520 VA: 0x1807D5F20 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7D7AF0 Offset: 0x7D60F0 VA: 0x1807D7AF0 Slot: 191
	protected override void WorkshopMode() { }

	// RVA: 0x7D7BB0 Offset: 0x7D61B0 VA: 0x1807D7BB0
	public void .ctor() { }

	// RVA: 0x7D7B50 Offset: 0x7D6150 VA: 0x1807D7B50
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

	// RVA: 0xAD1A50 Offset: 0xAD0050 VA: 0x180AD1A50 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD3690 Offset: 0xAD1C90 VA: 0x180AD3690 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD3540 Offset: 0xAD1B40 VA: 0x180AD3540 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD1940 Offset: 0xACFF40 VA: 0x180AD1940 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0xAD2BF0 Offset: 0xAD11F0 VA: 0x180AD2BF0 Slot: 205
	public override bool IsOnThisModule(BasePlayer player) { }

	// RVA: 0xAD2DB0 Offset: 0xAD13B0 VA: 0x180AD2DB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.Icon] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.Description] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	// RVA: 0xAD31E0 Offset: 0xAD17E0 VA: 0x180AD31E0
	public void Menu_MakeBed(BasePlayer player) { }

	// RVA: 0xAD3120 Offset: 0xAD1720 VA: 0x180AD3120 Slot: 206
	public virtual bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	[BaseEntity.Menu.Icon] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	[BaseEntity.Menu.Description] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	[BaseEntity.Menu.ShowIf] // RVA: 0x96B80 Offset: 0x95F80 VA: 0x180096B80
	// RVA: 0xAD3090 Offset: 0xAD1690 VA: 0x180AD3090
	public void Menu_ClearBedOwner(BasePlayer player) { }

	// RVA: 0xAD2FD0 Offset: 0xAD15D0 VA: 0x180AD2FD0 Slot: 207
	public virtual bool Menu_ClearBedOwner_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.Icon] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.Description] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.ShowIf] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	// RVA: 0xAD2F40 Offset: 0xAD1540 VA: 0x180AD2F40
	public void Menu_AssignToFriend(BasePlayer player) { }

	// RVA: 0xAD2E80 Offset: 0xAD1480 VA: 0x180AD2E80 Slot: 208
	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.Icon] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.Description] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.ShowIf] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	// RVA: 0xAD34B0 Offset: 0xAD1AB0 VA: 0x180AD34B0
	public void Menu_Rename(BasePlayer player) { }

	// RVA: 0xAD1990 Offset: 0xACFF90 VA: 0x180AD1990 Slot: 209
	protected virtual bool CanRename_Test(BasePlayer player) { }

	// RVA: 0xAD2810 Offset: 0xAD0E10 VA: 0x180AD2810
	private SleepingBagCamper GetSleepingBagForPlayer(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	[BaseEntity.Menu.Description] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	[BaseEntity.Menu.Icon] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	[BaseEntity.Menu.ShowIf] // RVA: 0x97550 Offset: 0x96950 VA: 0x180097550
	// RVA: 0xAD3340 Offset: 0xAD1940 VA: 0x180AD3340
	public void Menu_OpenLocker(BasePlayer player) { }

	// RVA: 0xAD3270 Offset: 0xAD1870 VA: 0x180AD3270
	public bool Menu_OpenLocker_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	[BaseEntity.Menu.Description] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	[BaseEntity.Menu.Icon] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	[BaseEntity.Menu.ShowIf] // RVA: 0x97790 Offset: 0x96B90 VA: 0x180097790
	// RVA: 0xAD3470 Offset: 0xAD1A70 VA: 0x180AD3470
	public void Menu_OpenStorage(BasePlayer player) { }

	// RVA: 0xAD3380 Offset: 0xAD1980 VA: 0x180AD3380
	public bool Menu_OpenStorage_ShowIf(BasePlayer player) { }

	// RVA: 0xAD3630 Offset: 0xAD1C30 VA: 0x180AD3630
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

	// RVA: 0xAD52D0 Offset: 0xAD38D0 VA: 0x180AD52D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD74A0 Offset: 0xAD5AA0 VA: 0x180AD74A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD6260 Offset: 0xAD4860 VA: 0x180AD6260 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD7560 Offset: 0xAD5B60 VA: 0x180AD7560 Slot: 198
	public override bool get_HasSeating() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD7470 Offset: 0xAD5A70 VA: 0x180AD7470
	protected ModularCar get_Car() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD7620 Offset: 0xAD5C20 VA: 0x180AD7620
	private void set_Car(ModularCar value) { }

	// RVA: 0xAD75B0 Offset: 0xAD5BB0 VA: 0x180AD75B0
	protected bool get_IsOnACar() { }

	// RVA: 0xAD7610 Offset: 0xAD5C10 VA: 0x180AD7610
	protected bool get_IsOnAVehicleLockUser() { }

	// RVA: 0xAD7480 Offset: 0xAD5A80 VA: 0x180AD7480
	public bool get_DoorsAreLockable() { }

	// RVA: 0xAD6560 Offset: 0xAD4B60 VA: 0x180AD6560 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xAD4BB0 Offset: 0xAD31B0 VA: 0x180AD4BB0 Slot: 194
	public override void ClientVehicleTick() { }

	// RVA: 0xAD5E30 Offset: 0xAD4430 VA: 0x180AD5E30 Slot: 195
	public override void OnClientTickStopped() { }

	// RVA: 0xAD6BD0 Offset: 0xAD51D0 VA: 0x180AD6BD0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xAD6880 Offset: 0xAD4E80 VA: 0x180AD6880
	private void SetCheckEngineLightState(bool isOn) { }

	// RVA: 0xAD6940 Offset: 0xAD4F40 VA: 0x180AD6940
	private void SetFuelLightState(bool isOn) { }

	// RVA: 0xAD6A10 Offset: 0xAD5010 VA: 0x180AD6A10
	private void SetLightState(bool isOn, int lightMatIndex, Color lightEmission) { }

	// RVA: 0xAD5F00 Offset: 0xAD4500 VA: 0x180AD5F00 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xAD7350 Offset: 0xAD5950 VA: 0x180AD7350
	public bool ValidMountRay(BasePlayer player) { }

	// RVA: 0xAD5BC0 Offset: 0xAD41C0 VA: 0x180AD5BC0 Slot: 197
	public override bool Menu_Locked_ShowIf(BasePlayer player) { }

	// RVA: 0xAD5860 Offset: 0xAD3E60 VA: 0x180AD5860
	private bool LookingAtAMountHotSpot(BasePlayer localPlayer) { }

	[BaseEntity.Menu] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	[BaseEntity.Menu.Description] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	[BaseEntity.Menu.Icon] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	[BaseEntity.Menu.ShowIf] // RVA: 0x98A20 Offset: 0x97E20 VA: 0x180098A20
	// RVA: 0xAD5B80 Offset: 0xAD4180 VA: 0x180AD5B80
	public void Menu_DestroyLock(BasePlayer player) { }

	// RVA: 0xAD5B70 Offset: 0xAD4170 VA: 0x180AD5B70
	public bool Menu_DestroyLock_ShowIf(BasePlayer player) { }

	// RVA: 0xAD5740 Offset: 0xAD3D40 VA: 0x180AD5740 Slot: 205
	public virtual bool IsOnThisModule(BasePlayer player) { }

	// RVA: 0xAD55E0 Offset: 0xAD3BE0 VA: 0x180AD55E0
	public bool HasADriverSeat() { }

	// RVA: 0xAD5D20 Offset: 0xAD4320 VA: 0x180AD5D20 Slot: 200
	public override void ModuleAdded(BaseModularVehicle vehicle, int firstSocketIndex) { }

	// RVA: 0xAD5DF0 Offset: 0xAD43F0 VA: 0x180AD5DF0 Slot: 201
	public override void ModuleRemoved() { }

	// RVA: 0xAD6350 Offset: 0xAD4950 VA: 0x180AD6350
	public bool PlayerCanDestroyLock(BasePlayer player) { }

	// RVA: 0xAD7460 Offset: 0xAD5A60 VA: 0x180AD7460
	public void .ctor() { }

	// RVA: 0xAD7410 Offset: 0xAD5A10 VA: 0x180AD7410
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

	// RVA: 0xACA0C0 Offset: 0xAC86C0 VA: 0x180ACA0C0
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

	// RVA: 0xAD7730 Offset: 0xAD5D30 VA: 0x180AD7730 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD7CA0 Offset: 0xAD62A0 VA: 0x180AD7CA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD7BB0 Offset: 0xAD61B0 VA: 0x180AD7BB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD7690 Offset: 0xAD5C90 VA: 0x180AD7690
	public IItemContainerEntity GetContainer() { }

	// RVA: 0xAD7A40 Offset: 0xAD6040 VA: 0x180AD7A40 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD7630 Offset: 0xAD5C30 VA: 0x180AD7630 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Description] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Icon] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	// RVA: 0xAD7B70 Offset: 0xAD6170 VA: 0x180AD7B70
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0xAD7AA0 Offset: 0xAD60A0 VA: 0x180AD7AA0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0xAD47B0 Offset: 0xAD2DB0 VA: 0x180AD47B0
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

	// RVA: 0xAD80D0 Offset: 0xAD66D0 VA: 0x180AD80D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD8680 Offset: 0xAD6C80 VA: 0x180AD8680 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD8530 Offset: 0xAD6B30 VA: 0x180AD8530 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD87F0 Offset: 0xAD6DF0 VA: 0x180AD87F0
	private Vector3 get_KickButtonPos() { }

	// RVA: 0xAD7D60 Offset: 0xAD6360 VA: 0x180AD7D60
	private bool CanKickPassengers(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	[BaseEntity.Menu.Description] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	[BaseEntity.Menu.Icon] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9A5A0 Offset: 0x999A0 VA: 0x18009A5A0
	// RVA: 0xAD84A0 Offset: 0xAD6AA0 VA: 0x180AD84A0
	public void Menu_Kick_Passengers(BasePlayer player) { }

	// RVA: 0xAD83E0 Offset: 0xAD69E0 VA: 0x180AD83E0
	public bool Menu_Kick_Passengers_ShowIf(BasePlayer player) { }

	// RVA: 0xAD8620 Offset: 0xAD6C20 VA: 0x180AD8620
	public void .ctor() { }

}

public class ModularCarOven : BaseOven // TypeDefIndex: 8608
{	// Fields
	private BaseVehicleModule moduleParent; // 0x4E8

	// Properties
	private BaseVehicleModule ModuleParent { get; }

	// Methods

	// RVA: 0x777400 Offset: 0x775A00 VA: 0x180777400 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x777710 Offset: 0x775D10 VA: 0x180777710
	private BaseVehicleModule get_ModuleParent() { }

	// RVA: 0x7774F0 Offset: 0x775AF0 VA: 0x1807774F0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x777520 Offset: 0x775B20 VA: 0x180777520 Slot: 156
	protected override bool SwitchOff_ShowIf(BasePlayer player) { }

	// RVA: 0x7775F0 Offset: 0x775BF0 VA: 0x1807775F0 Slot: 155
	protected override bool SwitchOn_ShowIf(BasePlayer player) { }

	// RVA: 0x777330 Offset: 0x775930 VA: 0x180777330 Slot: 154
	protected override bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x52EC90 Offset: 0x52D290 VA: 0x18052EC90
	public void .ctor() { }

}

public class VehicleVendor : NPCTalking // TypeDefIndex: 8851
{	// Fields
	public EntityRef spawnerRef; // 0x858
	public VehicleSpawner vehicleSpawner; // 0x868

	// Methods

	// RVA: 0xAD8BE0 Offset: 0xAD71E0 VA: 0x180AD8BE0 Slot: 158
	public override string GetConversationStartSpeech(BasePlayer player) { }

	// RVA: 0xAD8C30 Offset: 0xAD7230 VA: 0x180AD8C30
	public VehicleSpawner GetVehicleSpawner() { }

	// RVA: 0xAD8CD0 Offset: 0xAD72D0 VA: 0x180AD8CD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7E2BA0 Offset: 0x7E11A0 VA: 0x1807E2BA0 Slot: 159
	public override ConversationData GetConversationFor(BasePlayer player) { }

	// RVA: 0xAD8D30 Offset: 0xAD7330 VA: 0x180AD8D30
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

	// RVA: 0xAD89B0 Offset: 0xAD6FB0 VA: 0x180AD89B0 Slot: 131
	public virtual int GetOccupyLayer() { }

	// RVA: 0xAD89C0 Offset: 0xAD6FC0 VA: 0x180AD89C0
	public BaseVehicle GetVehicleOccupying() { }

	// RVA: 0xAD8B60 Offset: 0xAD7160 VA: 0x180AD8B60
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

	// RVA: 0x8C21B0 Offset: 0x8C07B0 VA: 0x1808C21B0
	private int GetBucketRPM(int RPM) { }

	// RVA: 0x8C2020 Offset: 0x8C0620 VA: 0x1808C2020
	private void Awake() { }

	// RVA: 0x8C2C50 Offset: 0x8C1250 VA: 0x1808C2C50
	private void Update() { }

	// RVA: 0x8C2B30 Offset: 0x8C1130 VA: 0x1808C2B30
	private void UpdateRPM() { }

	// RVA: 0x8C2220 Offset: 0x8C0820 VA: 0x1808C2220
	private void InitAudioClip() { }

	// RVA: 0x8C2350 Offset: 0x8C0950 VA: 0x1808C2350
	private void OnAudioRead(float[] data) { }

	// RVA: 0x8C27C0 Offset: 0x8C0DC0 VA: 0x1808C27C0
	private void SpawnGrain() { }

	// RVA: 0x8C20A0 Offset: 0x8C06A0 VA: 0x1808C20A0
	private void CleanupFinishedGrains() { }

	// RVA: 0x8C2510 Offset: 0x8C0B10 VA: 0x1808C2510
	private void SetupRPMBuckets() { }

	// RVA: 0x8C3020 Offset: 0x8C1620 VA: 0x1808C3020
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

	// RVA: 0x8C3530 Offset: 0x8C1B30 VA: 0x1808C3530
	public void .ctor(int RPM, int startSample, int endSample, float period, int id) { }

}

public class EngineAudioClip.EngineCycleBucket // TypeDefIndex: 8989
{	// Fields
	public int RPM; // 0x10
	public List<EngineAudioClip.EngineCycle> cycles; // 0x18
	public List<int> remainingCycles; // 0x20

	// Methods

	// RVA: 0x8C3480 Offset: 0x8C1A80 VA: 0x1808C3480
	public void .ctor(int RPM) { }

	// RVA: 0x8C32B0 Offset: 0x8C18B0 VA: 0x1808C32B0
	public EngineAudioClip.EngineCycle GetCycle(Random random, int lastCycleId) { }

	// RVA: 0x8C33C0 Offset: 0x8C19C0 VA: 0x1808C33C0
	private void ResetRemainingCycles(Random random) { }

	// RVA: 0x8C3240 Offset: 0x8C1840 VA: 0x1808C3240
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

	// RVA: 0x5A4E60 Offset: 0x5A3460 VA: 0x1805A4E60
	public bool get_finished() { }

	// RVA: 0x8D6D60 Offset: 0x8D5360 VA: 0x1808D6D60
	public void Init(float[] source, EngineAudioClip.EngineCycle cycle, int cyclePadding) { }

	// RVA: 0x8D6CA0 Offset: 0x8D52A0 VA: 0x1808D6CA0
	public float GetSample() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class BaseVehicleMountPoint : BaseMountable // TypeDefIndex: 9697
{	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 147
	public override bool DirectlyMountable() { }

	// RVA: 0x935AE0 Offset: 0x9340E0 VA: 0x180935AE0 Slot: 170
	public override BaseVehicle VehicleParent() { }

	// RVA: 0x935A30 Offset: 0x934030 VA: 0x180935A30 Slot: 109
	public override bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x935C50 Offset: 0x934250 VA: 0x180935C50 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x935990 Offset: 0x933F90 VA: 0x180935990 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x935D00 Offset: 0x934300 VA: 0x180935D00
	public void .ctor() { }

}

public class BaseVehicleSeat : BaseVehicleMountPoint // TypeDefIndex: 9698
{	// Fields
	public float mountedAnimationSpeed; // 0x320
	public bool sendClientInputToVehicleParent; // 0x324
	public bool forcePlayerModelUpdate; // 0x325

	// Methods

	// RVA: 0x935D80 Offset: 0x934380 VA: 0x180935D80 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x935E40 Offset: 0x934440 VA: 0x180935E40 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x935D70 Offset: 0x934370 VA: 0x180935D70 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0x935D60 Offset: 0x934360 VA: 0x180935D60 Slot: 159
	public override bool ForceUpdatePlayerModel(BasePlayer p) { }

	// RVA: 0x935D00 Offset: 0x934300 VA: 0x180935D00
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

	// RVA: 0x8C3190 Offset: 0x8C1790 VA: 0x1808C3190
	public BlendedEngineLoopDefinition GetEngineLoopDef(int numEngines) { }

	// RVA: 0x8C31D0 Offset: 0x8C17D0 VA: 0x1808C31D0
	public void .ctor() { }

}

public class ModularCarCentralLockingSwitch : VehicleModuleButtonComponent // TypeDefIndex: 9738
{	// Fields
	public Transform centralLockingSwitch; // 0x28
	public Vector3 switchOffPos; // 0x30
	public Vector3 switchOnPos; // 0x3C

	// Methods

	// RVA: 0x7748E0 Offset: 0x772EE0 VA: 0x1807748E0 Slot: 4
	public override void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	// RVA: 0x774760 Offset: 0x772D60 VA: 0x180774760 Slot: 5
	public override void ClientUpdateTick(BaseVehicleModule parentModule) { }

	// RVA: 0x7749F0 Offset: 0x772FF0 VA: 0x1807749F0
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

	// RVA: 0x774A00 Offset: 0x773000 VA: 0x180774A00 Slot: 4
	public override void Init(ModularCar owner, VehicleChassisVisuals.ClientWheelData<ModularCar>[] clientWheelData) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected override void PreWheelUpdateTick() { }

	// RVA: 0x774C60 Offset: 0x773260 VA: 0x180774C60 Slot: 7
	protected override void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt) { }

	// RVA: 0x775180 Offset: 0x773780 VA: 0x180775180 Slot: 6
	protected override void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, bool isOn, float steer, float dt) { }

	// RVA: 0x774DF0 Offset: 0x7733F0 VA: 0x180774DF0
	private void UpdateAxle(Transform axle, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataL, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataR, float dt, bool instant) { }

	// RVA: 0x774A70 Offset: 0x773070 VA: 0x180774A70
	private void LookAt(ModularCarChassisVisuals.LookAtTarget lookAt) { }

	// RVA: 0x775420 Offset: 0x773A20 VA: 0x180775420
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

	// RVA: 0x4D3840 Offset: 0x4D1E40 VA: 0x1804D3840
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

	// RVA: 0x777290 Offset: 0x775890 VA: 0x180777290
	public bool get_HasALock() { }

	// RVA: 0x7772A0 Offset: 0x7758A0 VA: 0x1807772A0
	public bool get_IsLocked() { }

	// RVA: 0x777200 Offset: 0x775800 VA: 0x180777200
	public bool get_CentralLockingIsOn() { }

	// RVA: 0x7771B0 Offset: 0x7757B0 VA: 0x1807771B0
	public void .ctor(ModularCar owner, bool isServer) { }

	// RVA: 0x7770B0 Offset: 0x7756B0 VA: 0x1807770B0
	public bool PlayerHasUnlockPermission(BasePlayer player) { }

	// RVA: 0x777060 Offset: 0x775660 VA: 0x180777060
	public bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0x777020 Offset: 0x775620 VA: 0x180777020
	public bool PlayerCanDestroyLock(BaseVehicleModule viaModule) { }

	// RVA: 0x776FE0 Offset: 0x7755E0 VA: 0x180776FE0
	private bool KeyCanUnlockThis(Item key) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x776FE0 Offset: 0x7755E0 VA: 0x180776FE0
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

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
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

	// RVA: 0x777800 Offset: 0x775E00 VA: 0x180777800
	public bool get_HasLeftFootIK() { }

	// RVA: 0x777840 Offset: 0x775E40 VA: 0x180777840
	public bool get_HasRightFootIK() { }

	// RVA: 0x777880 Offset: 0x775E80 VA: 0x180777880
	public Vector3 get_LeftFootIKPos() { }

	// RVA: 0x777960 Offset: 0x775F60 VA: 0x180777960
	public Vector3 get_RightFootIKPos() { }

	// RVA: 0x777820 Offset: 0x775E20 VA: 0x180777820
	public bool get_HasLeftHandIK() { }

	// RVA: 0x777860 Offset: 0x775E60 VA: 0x180777860
	public bool get_HasRightHandIK() { }

	// RVA: 0x7778F0 Offset: 0x775EF0 VA: 0x1807778F0
	public Vector3 get_LeftHandIKPos() { }

	// RVA: 0x7779D0 Offset: 0x775FD0 VA: 0x1807779D0
	public Vector3 get_RightHandIKPos() { }

	// RVA: 0x7777F0 Offset: 0x775DF0 VA: 0x1807777F0
	public void .ctor() { }

}

public class ModularVehicleShopFront : ShopFront // TypeDefIndex: 9748
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxUseDistance; // 0x3F0

	// Methods

	// RVA: 0x77ACF0 Offset: 0x7792F0 VA: 0x18077ACF0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x77AD80 Offset: 0x779380 VA: 0x18077AD80 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x77AE90 Offset: 0x779490 VA: 0x18077AE90
	private bool WithinUseDistance(BasePlayer player) { }

	// RVA: 0x77AF00 Offset: 0x779500 VA: 0x18077AF00
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

	// RVA: 0xAD1830 Offset: 0xACFE30 VA: 0x180AD1830 Slot: 4
	public virtual void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void ClientUpdateTick(BaseVehicleModule parentModule) { }

	// RVA: 0xAD18F0 Offset: 0xACFEF0 VA: 0x180AD18F0
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

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 199
	public override bool get_HasAnEngine() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4960 Offset: 0xAD2F60 VA: 0x180AD4960
	public bool get_IsUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD49D0 Offset: 0xAD2FD0 VA: 0x180AD49D0
	private void set_IsUsable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD49A0 Offset: 0xAD2FA0 VA: 0x180AD49A0
	public float get_PerformanceFractionAcceleration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD49F0 Offset: 0xAD2FF0 VA: 0x180AD49F0
	private void set_PerformanceFractionAcceleration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD49C0 Offset: 0xAD2FC0 VA: 0x180AD49C0
	public float get_PerformanceFractionTopSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4A10 Offset: 0xAD3010 VA: 0x180AD4A10
	private void set_PerformanceFractionTopSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD49B0 Offset: 0xAD2FB0 VA: 0x180AD49B0
	public float get_PerformanceFractionFuelEconomy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4A00 Offset: 0xAD3000 VA: 0x180AD4A00
	private void set_PerformanceFractionFuelEconomy(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD4990 Offset: 0xAD2F90 VA: 0x180AD4990
	public float get_OverallPerformanceFraction() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD49E0 Offset: 0xAD2FE0 VA: 0x180AD49E0
	private void set_OverallPerformanceFraction(float value) { }

	// RVA: 0xAD4810 Offset: 0xAD2E10 VA: 0x180AD4810
	public bool get_AtLowPerformance() { }

	// RVA: 0xAD4830 Offset: 0xAD2E30 VA: 0x180AD4830
	public bool get_AtPeakPerformance() { }

	// RVA: 0xAD4970 Offset: 0xAD2F70 VA: 0x180AD4970
	public int get_KW() { }

	// RVA: 0xAD48A0 Offset: 0xAD2EA0 VA: 0x180AD48A0
	public EngineAudioSet get_AudioSet() { }

	// RVA: 0xAD48C0 Offset: 0xAD2EC0 VA: 0x180AD48C0
	private bool get_EngineIsOn() { }

	// RVA: 0xAD41A0 Offset: 0xAD27A0 VA: 0x180AD41A0 Slot: 28
	public override void InitShared() { }

	// RVA: 0xAD4310 Offset: 0xAD2910 VA: 0x180AD4310 Slot: 202
	public override void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState) { }

	// RVA: 0xAD4070 Offset: 0xAD2670 VA: 0x180AD4070 Slot: 203
	public override float GetMaxDriveForce() { }

	// RVA: 0xAD4550 Offset: 0xAD2B50 VA: 0x180AD4550
	public void RefreshPerformanceStats(EngineStorage engineStorage) { }

	// RVA: 0xAD40C0 Offset: 0xAD26C0 VA: 0x180AD40C0
	private float GetPerformanceFraction(float statBoostPercent) { }

	// RVA: 0xAD4240 Offset: 0xAD2840 VA: 0x180AD4240 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD38F0 Offset: 0xAD1EF0 VA: 0x180AD38F0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xAD3990 Offset: 0xAD1F90 VA: 0x180AD3990 Slot: 194
	public override void ClientVehicleTick() { }

	// RVA: 0xAD43F0 Offset: 0xAD29F0 VA: 0x180AD43F0
	private void PlayBadPerformanceSound() { }

	// RVA: 0xAD46F0 Offset: 0xAD2CF0 VA: 0x180AD46F0
	private void StopBadPerformanceSound() { }

	// RVA: 0xAD4660 Offset: 0xAD2C60 VA: 0x180AD4660
	private void SetFXState(bool isOn) { }

	// RVA: 0xAD47B0 Offset: 0xAD2DB0 VA: 0x180AD47B0
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

	// RVA: 0xAC7F70 Offset: 0xAC6570 VA: 0x180AC7F70
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

	// RVA: 0xAD1570 Offset: 0xACFB70 VA: 0x180AD1570
	public void SetLightVisuals(bool headlightsOn, bool brakesOn) { }

	// RVA: 0xAD1300 Offset: 0xACF900 VA: 0x180AD1300
	public static void SetLightVisuals(IReadOnlyList<VehicleLight> lights, bool headlightsOn, bool brakesOn) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xAD17E0 Offset: 0xACFDE0 VA: 0x180AD17E0
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

	// RVA: 0x8C3810 Offset: 0x8C1E10 VA: 0x1808C3810
	public void .ctor(float triggerDamage, float maxSeconds, Action trigger) { }

	// RVA: 0x8C36A0 Offset: 0x8C1CA0 VA: 0x1808C36A0
	public void TakeDamage(float amount) { }

	// RVA: 0x8C3590 Offset: 0x8C1B90 VA: 0x1808C3590
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
	|-RVA: 0x19BB610 Offset: 0x19B9C10 VA: 0x1819BB610
	|-VehicleChassisVisuals<ModularCar>.Init
	|-VehicleChassisVisuals<Snowmobile>.Init
	|-VehicleChassisVisuals<object>.Init
	*/

	// RVA: -1 Offset: -1
	public void UpdateTick(float dt, bool instantForced = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BC090 Offset: 0x19BA690 VA: 0x1819BC090
	|-VehicleChassisVisuals<ModularCar>.UpdateTick
	|-VehicleChassisVisuals<Snowmobile>.UpdateTick
	|-VehicleChassisVisuals<object>.UpdateTick
	*/

	// RVA: -1 Offset: -1
	public bool IsGrounded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BB680 Offset: 0x19B9C80 VA: 0x1819BB680
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
	|-RVA: 0x19BAF50 Offset: 0x19B9550 VA: 0x1819BAF50
	|-VehicleChassisVisuals<ModularCar>.CalculateWheelSlip
	|-VehicleChassisVisuals<Snowmobile>.CalculateWheelSlip
	|-VehicleChassisVisuals<object>.CalculateWheelSlip
	*/

	// RVA: -1 Offset: -1
	protected void UpdateWheelSuspensionData(VehicleChassisVisuals.ClientWheelData<T> wheelData, Vector3 traceSource, Nullable<Vector3> traceSource2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BC4A0 Offset: 0x19BAAA0 VA: 0x1819BC4A0
	|-VehicleChassisVisuals<ModularCar>.UpdateWheelSuspensionData
	|-VehicleChassisVisuals<Snowmobile>.UpdateWheelSuspensionData
	|-VehicleChassisVisuals<object>.UpdateWheelSuspensionData
	*/

	// RVA: -1 Offset: -1
	protected float GetWheelRotation(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool receivingDriveWheelVels, float dt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BB390 Offset: 0x19B9990 VA: 0x1819BB390
	|-VehicleChassisVisuals<ModularCar>.GetWheelRotation
	|-VehicleChassisVisuals<Snowmobile>.GetWheelRotation
	|-VehicleChassisVisuals<object>.GetWheelRotation
	*/

	// RVA: -1 Offset: -1
	protected static void UpdateSteerRotation(Transform t, float steer, int axis) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BBFA0 Offset: 0x19BA5A0 VA: 0x1819BBFA0
	|-VehicleChassisVisuals<ModularCar>.UpdateSteerRotation
	|-VehicleChassisVisuals<object>.UpdateSteerRotation
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, float throttleInput) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BB750 Offset: 0x19B9D50 VA: 0x1819BB750
	|-VehicleChassisVisuals<ModularCar>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, float throttleInput, float speed, float minSpeed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BBBB0 Offset: 0x19BA1B0 VA: 0x1819BBBB0
	|-VehicleChassisVisuals<Snowmobile>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOnWater, float spinSlip, TerrainConfig.GroundType groundType, float throttleInput) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BB840 Offset: 0x19B9E40 VA: 0x1819BB840
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOnWater, float spinSlip, TerrainConfig.GroundType groundType, float throttleInput, float speed, float minSpeed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BB910 Offset: 0x19B9F10 VA: 0x1819BB910
	|-VehicleChassisVisuals<Snowmobile>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	public void UpdateTickStopped() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BC040 Offset: 0x19BA640 VA: 0x1819BC040
	|-VehicleChassisVisuals<ModularCar>.UpdateTickStopped
	|-VehicleChassisVisuals<Snowmobile>.UpdateTickStopped
	|-VehicleChassisVisuals<object>.UpdateTickStopped
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void StopAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BBCD0 Offset: 0x19BA2D0 VA: 0x1819BBCD0
	|-VehicleChassisVisuals<ModularCar>.StopAll
	|-VehicleChassisVisuals<Snowmobile>.StopAll
	|-VehicleChassisVisuals<object>.StopAll
	*/

	// RVA: -1 Offset: -1
	protected static void StopTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BBD80 Offset: 0x19BA380 VA: 0x1819BBD80
	|-VehicleChassisVisuals<object>.StopTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x847770 Offset: 0x845D70 VA: 0x180847770
	|-VehicleChassisVisuals<ModularCar>..ctor
	|-VehicleChassisVisuals<Snowmobile>..ctor
	|-VehicleChassisVisuals<object>..ctor
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static bool <UpdateWheelSuspensionData>g__GetSuspensionHit|17_0(Vector3 ts, out RaycastHit hit, ref VehicleChassisVisuals.<>c__DisplayClass17_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BBE80 Offset: 0x19BA480 VA: 0x1819BBE80
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
	|-RVA: 0x19A8F20 Offset: 0x19A7520 VA: 0x1819A8F20
	|-VehicleChassisVisuals.ClientWheelData<ModularCar>.get_isOnHardGround
	|-VehicleChassisVisuals.ClientWheelData<object>.get_isOnHardGround
	*/

	// RVA: -1 Offset: -1
	public void .ctor(VisualCarWheel wheel, Transform vehicleTransform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19A8E50 Offset: 0x19A7450 VA: 0x1819A8E50
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
	|-RVA: 0x19BCB70 Offset: 0x19BB170 VA: 0x1819BCB70
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
	|-RVA: 0x19BCBD0 Offset: 0x19BB1D0 VA: 0x1819BCBD0
	|-VehicleEngineController<BaseSubmarine>.get_IsOn
	|-VehicleEngineController<GroundVehicle>.get_IsOn
	|-VehicleEngineController<object>.get_IsOn
	*/

	// RVA: -1 Offset: -1
	public bool get_IsOff() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1893750 Offset: 0x1891D50 VA: 0x181893750
	|-VehicleEngineController<object>.get_IsOff
	|-VehicleEngineController<TrainEngine>.get_IsOff
	*/

	// RVA: -1 Offset: -1
	public bool get_IsStarting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BCC30 Offset: 0x19BB230 VA: 0x1819BCC30
	|-VehicleEngineController<MiniCopter>.get_IsStarting
	|-VehicleEngineController<object>.get_IsStarting
	*/

	// RVA: -1 Offset: -1
	public bool get_IsStartingOrOn() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BCC00 Offset: 0x19BB200 VA: 0x1819BCC00
	|-VehicleEngineController<GroundVehicle>.get_IsStartingOrOn
	|-VehicleEngineController<object>.get_IsStartingOrOn
	|-VehicleEngineController<TrainEngine>.get_IsStartingOrOn
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public EntityFuelSystem get_FuelSystem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
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
	|-RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	|-VehicleEngineController<object>.set_FuelSystem
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TOwner owner, bool isServer, float engineStartupTime, GameObjectRef fuelStoragePrefab, Transform waterloggedPoint, BaseEntity.Flags engineStartingFlag = 128) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BCA50 Offset: 0x19BB050 VA: 0x1819BCA50
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
	|-RVA: 0x19BC950 Offset: 0x19BAF50 VA: 0x1819BC950
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

	// RVA: 0xAD89A0 Offset: 0xAD6FA0 VA: 0x180AD89A0
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

	// RVA: 0x8C38C0 Offset: 0x8C1EC0 VA: 0x1808C38C0 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x8C3940 Offset: 0x8C1F40 VA: 0x1808C3940 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
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

	// RVA: 0xACDFB0 Offset: 0xACC5B0 VA: 0x180ACDFB0
	protected void Awake() { }

	// RVA: 0xACE250 Offset: 0xACC850 VA: 0x180ACE250
	protected void OnEnable() { }

	// RVA: 0xACE1D0 Offset: 0xACC7D0 VA: 0x180ACE1D0
	protected void OnDisable() { }

	// RVA: 0xACE310 Offset: 0xACC910 VA: 0x180ACE310 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0xACE040 Offset: 0xACC640 VA: 0x180ACE040
	private void InventoryChangeRefresh() { }

	// RVA: 0xACE320 Offset: 0xACC920 VA: 0x180ACE320
	private void SetLinkSprite(Sprite sprite) { }

	// RVA: 0xACE000 Offset: 0xACC600 VA: 0x180ACE000
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

	// RVA: 0xAD1240 Offset: 0xACF840 VA: 0x180AD1240
	private Item get_CurSelectedItem() { }

	// RVA: 0xAD12F0 Offset: 0xACF8F0 VA: 0x180AD12F0
	private ItemContainer get_ModulesContainer() { }

	// RVA: 0xAD1230 Offset: 0xACF830 VA: 0x180AD1230
	private ItemContainer get_ChassisContainer() { }

	// RVA: 0xAD12E0 Offset: 0xACF8E0 VA: 0x180AD12E0
	private ItemContainer get_ModuleInternalItemContainer() { }

	// RVA: 0xACEB50 Offset: 0xACD150 VA: 0x180ACEB50
	protected void OnEnable() { }

	// RVA: 0xAD1010 Offset: 0xACF610 VA: 0x180AD1010 Slot: 5
	public override void Update() { }

	// RVA: 0xAD0860 Offset: 0xACEE60 VA: 0x180AD0860
	public void RepairClicked() { }

	// RVA: 0xACE5A0 Offset: 0xACCBA0 VA: 0x180ACE5A0
	public void CraftLockClicked() { }

	// RVA: 0xAD07E0 Offset: 0xACEDE0 VA: 0x180AD07E0
	public void RemoveLockClicked() { }

	// RVA: 0xACE650 Offset: 0xACCC50 VA: 0x180ACE650
	public void DestroyChassisClicked() { }

	// RVA: 0xAD09B0 Offset: 0xACEFB0 VA: 0x180AD09B0
	public void TakeInternalItemsClicked() { }

	// RVA: 0xACE8E0 Offset: 0xACCEE0 VA: 0x180ACE8E0
	public void OnCopyFromLiquidDown() { }

	// RVA: 0xACE960 Offset: 0xACCF60 VA: 0x180ACE960
	public void OnCopyFromLiquidUp() { }

	// RVA: 0xAD0910 Offset: 0xACEF10 VA: 0x180AD0910
	private bool SelectedValidLiquidTarget() { }

	// RVA: 0xACE780 Offset: 0xACCD80 VA: 0x180ACE780
	private void LiquidCopyFrom() { }

	// RVA: 0xACE370 Offset: 0xACC970 VA: 0x180ACE370
	private bool CanTakeLiquid() { }

	// RVA: 0xACE6F0 Offset: 0xACCCF0 VA: 0x180ACE6F0
	private ModularCarGarage GetGarage() { }

	// RVA: 0xACF010 Offset: 0xACD610 VA: 0x180ACF010
	private void RefreshEditUI() { }

	// RVA: 0xACF270 Offset: 0xACD870 VA: 0x180ACF270
	private void RefreshHasVehicle(ModularCarGarage garage, bool forced = False) { }

	// RVA: 0xACF3E0 Offset: 0xACD9E0 VA: 0x180ACF3E0
	private void RefreshInfoText() { }

	// RVA: 0xAD0390 Offset: 0xACE990 VA: 0x180AD0390
	private void RefreshWarningText() { }

	// RVA: 0xACED00 Offset: 0xACD300 VA: 0x180ACED00
	private void OnSelectedItemChanged(Item newSelectedItem) { }

	// RVA: 0xACED90 Offset: 0xACD390 VA: 0x180ACED90
	private void RefreshDestroyGroup(ModularCarGarage garage) { }

	// RVA: 0xACF6D0 Offset: 0xACDCD0 VA: 0x180ACF6D0
	private void RefreshLockCreation(ModularCarGarage garage) { }

	// RVA: 0xACFD30 Offset: 0xACE330 VA: 0x180ACFD30
	private void RefreshRepair() { }

	// RVA: 0xAD1220 Offset: 0xACF820 VA: 0x180AD1220
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD0C70 Offset: 0xACF270 VA: 0x180AD0C70
	private bool <RefreshLockCreation>g__AddResourceInfo|72_0(string prefixText, ItemAmount ingredient, ref VehicleEditingPanel.<>c__DisplayClass72_0 ) { }

}

private class VehicleEditingPanel.CreateChassisEntry // TypeDefIndex: 11063
{	// Fields
	public byte garageChassisIndex; // 0x10
	public Button craftButton; // 0x18
	public Text craftButtonText; // 0x20
	public Text requirementsText; // 0x28

	// Methods

	// RVA: 0xAC7F20 Offset: 0xAC6520 VA: 0x180AC7F20
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

	// RVA: 0xAD4A20 Offset: 0xAD3020 VA: 0x180AD4A20 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0xAD4A70 Offset: 0xAD3070 VA: 0x180AD4A70 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
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
	// RVA: 0x4BCC30 Offset: 0x4BB230 VA: 0x1804BCC30
	public static bool BoostsAcceleration(EngineStorage.EngineItemTypes engineItemType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BCC50 Offset: 0x4BB250 VA: 0x1804BCC50
	public static bool BoostsTopSpeed(EngineStorage.EngineItemTypes engineItemType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BCC40 Offset: 0x4BB240 VA: 0x1804BCC40
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
	// RVA: 0x4BD0E0 Offset: 0x4BB6E0 VA: 0x1804BD0E0
	public bool get_isUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD120 Offset: 0x4BB720 VA: 0x1804BD120
	private void set_isUsable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD0C0 Offset: 0x4BB6C0 VA: 0x1804BD0C0
	public float get_accelerationBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD100 Offset: 0x4BB700 VA: 0x1804BD100
	private void set_accelerationBoostPercent(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD0F0 Offset: 0x4BB6F0 VA: 0x1804BD0F0
	public float get_topSpeedBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD130 Offset: 0x4BB730 VA: 0x1804BD130
	private void set_topSpeedBoostPercent(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD0D0 Offset: 0x4BB6D0 VA: 0x1804BD0D0
	public float get_fuelEconomyBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BD110 Offset: 0x4BB710 VA: 0x1804BD110
	private void set_fuelEconomyBoostPercent(float value) { }

	// RVA: 0x4BCD30 Offset: 0x4BB330 VA: 0x1804BCD30
	public VehicleModuleEngine GetEngineModule() { }

	// RVA: 0x4BCD00 Offset: 0x4BB300 VA: 0x1804BCD00
	public float GetAveragedLoadoutPercent() { }

	// RVA: 0x4BCFB0 Offset: 0x4BB5B0 VA: 0x1804BCFB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4BCC60 Offset: 0x4BB260 VA: 0x1804BCC60 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x4BCDD0 Offset: 0x4BB3D0 VA: 0x1804BCDD0
	private int GetValidSlot(Item item) { }

	// RVA: 0x4BCDC0 Offset: 0x4BB3C0 VA: 0x1804BCDC0 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x4BD060 Offset: 0x4BB660 VA: 0x1804BD060
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

	// RVA: 0x4C1270 Offset: 0x4BF870 VA: 0x1804C1270 Slot: 4
	protected override EngineAudioSet get_EngineAudioSet() { }

	// RVA: 0x4C1340 Offset: 0x4BF940 VA: 0x1804C1340 Slot: 5
	protected override void set_EngineAudioSet(EngineAudioSet value) { }

	// RVA: 0x4C1280 Offset: 0x4BF880 VA: 0x1804C1280
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataFL() { }

	// RVA: 0x4C12B0 Offset: 0x4BF8B0 VA: 0x1804C12B0
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataFR() { }

	// RVA: 0x4C12E0 Offset: 0x4BF8E0 VA: 0x1804C12E0
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataRL() { }

	// RVA: 0x4C1310 Offset: 0x4BF910 VA: 0x1804C1310
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataRR() { }

	// RVA: 0x4BF2B0 Offset: 0x4BD8B0 VA: 0x1804BF2B0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4BF350 Offset: 0x4BD950 VA: 0x1804BF350 Slot: 7
	public override void ClientTick() { }

	// RVA: 0x4BF700 Offset: 0x4BDD00 VA: 0x1804BF700 Slot: 8
	public override void OnClientTickStopped() { }

	// RVA: 0x4BF740 Offset: 0x4BDD40 VA: 0x1804BF740
	internal void OnModuleAdded(BaseVehicleModule addedModule) { }

	// RVA: 0x4BF8F0 Offset: 0x4BDEF0 VA: 0x1804BF8F0
	internal void OnModuleRemoved(BaseVehicleModule removedModule) { }

	// RVA: 0x4BF690 Offset: 0x4BDC90 VA: 0x1804BF690 Slot: 9
	protected override int GetNumEngines() { }

	// RVA: 0x4BFC30 Offset: 0x4BE230 VA: 0x1804BFC30
	private void PlayTyreAudio() { }

	// RVA: 0x4BFF10 Offset: 0x4BE510 VA: 0x1804BFF10
	private void StopTyreAudio() { }

	// RVA: 0x4BFE50 Offset: 0x4BE450 VA: 0x1804BFE50
	private void StopSkidSound() { }

	// RVA: 0x4C0070 Offset: 0x4BE670 VA: 0x1804C0070
	private void UpdateMovementRattleSound() { }

	// RVA: 0x4BFD90 Offset: 0x4BE390 VA: 0x1804BFD90
	private void StopMovementRattleSound() { }

	// RVA: 0x4C09A0 Offset: 0x4BEFA0 VA: 0x1804C09A0
	private void UpdateSuspensionSounds() { }

	// RVA: 0x4C0590 Offset: 0x4BEB90 VA: 0x1804C0590
	private void UpdateSkidSound(float dt, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData) { }

	// RVA: 0x4BFFA0 Offset: 0x4BE5A0 VA: 0x1804BFFA0
	private void StopTyreSound(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData) { }

	// RVA: 0x4C0D40 Offset: 0x4BF340 VA: 0x1804C0D40
	private void UpdateTyreSound(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, float speedRatio) { }

	// RVA: 0x4C1110 Offset: 0x4BF710 VA: 0x1804C1110
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

	// RVA: 0x4C1410 Offset: 0x4BFA10 VA: 0x1804C1410
	public Vector3 get_WorldPosition() { }

	// RVA: 0x4C1450 Offset: 0x4BFA50 VA: 0x1804C1450
	public Quaternion get_WorldRotation() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public ModularVehicleSocket.SocketWheelType get_WheelType() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public ModularVehicleSocket.SocketLocationType get_LocationType() { }

	// RVA: 0x4C1350 Offset: 0x4BF950 VA: 0x1804C1350
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

	// RVA: 0x4D2B40 Offset: 0x4D1140 VA: 0x1804D2B40
	public bool TryGetItem(int tier, EngineStorage.EngineItemTypes type, out ItemModEngineItem output) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
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

	// RVA: 0x4D3170 Offset: 0x4D1770 VA: 0x1804D3170
	public bool WantsOpenPos(BaseEntity parentEntity) { }

	// RVA: 0x4D2F40 Offset: 0x4D1540 VA: 0x1804D2F40
	public void ClientUpdateTick(BaseVehicleModule parentModule) { }

	// RVA: 0x4D2F80 Offset: 0x4D1580 VA: 0x1804D2F80
	private void PlaySounds(bool wantsOpenPos) { }

	// RVA: 0x4D2CB0 Offset: 0x4D12B0 VA: 0x1804D2CB0
	private void CheckPosition(BaseEntity parentEntity, float dt) { }

	// RVA: 0x4D31A0 Offset: 0x4D17A0 VA: 0x1804D31A0
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

