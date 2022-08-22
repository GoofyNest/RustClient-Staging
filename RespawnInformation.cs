public class RespawnInformation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6491
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<RespawnInformation.SpawnOptions> spawnOptions; // 0x18
	public PlayerLifeStory previousLife; // 0x20
	public bool fadeIn; // 0x28

	// Methods

	// RVA: 0x1E05B70 Offset: 0x1E04170 VA: 0x181E05B70
	public static void ResetToPool(RespawnInformation instance) { }

	// RVA: 0x1E05D90 Offset: 0x1E04390 VA: 0x181E05D90
	public void ResetToPool() { }

	// RVA: 0x1E05AB0 Offset: 0x1E040B0 VA: 0x181E05AB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E04B60 Offset: 0x1E03160 VA: 0x181E04B60
	public void CopyTo(RespawnInformation instance) { }

	// RVA: 0x1E04D80 Offset: 0x1E03380 VA: 0x181E04D80
	public RespawnInformation Copy() { }

	// RVA: 0x1E05910 Offset: 0x1E03F10 VA: 0x181E05910
	public static RespawnInformation Deserialize(Stream stream) { }

	// RVA: 0x1E04E00 Offset: 0x1E03400 VA: 0x181E04E00
	public static RespawnInformation DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E054F0 Offset: 0x1E03AF0 VA: 0x181E054F0
	public static RespawnInformation DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E05990 Offset: 0x1E03F90 VA: 0x181E05990
	public static RespawnInformation Deserialize(byte[] buffer) { }

	// RVA: 0x1E05B30 Offset: 0x1E04130 VA: 0x181E05B30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E067C0 Offset: 0x1E04DC0 VA: 0x181E067C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E067E0 Offset: 0x1E04DE0 VA: 0x181E067E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation previous) { }

	// RVA: 0x1E05B50 Offset: 0x1E04150 VA: 0x181E05B50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E05580 Offset: 0x1E03B80 VA: 0x181E05580
	public static RespawnInformation Deserialize(byte[] buffer, RespawnInformation instance, bool isDelta = False) { }

	// RVA: 0x1E05680 Offset: 0x1E03C80 VA: 0x181E05680
	public static RespawnInformation Deserialize(Stream stream, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E04E80 Offset: 0x1E03480 VA: 0x181E04E80
	public static RespawnInformation DeserializeLengthDelimited(Stream stream, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E051D0 Offset: 0x1E037D0 VA: 0x181E051D0
	public static RespawnInformation DeserializeLength(Stream stream, int length, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E05FB0 Offset: 0x1E045B0 VA: 0x181E05FB0
	public static void SerializeDelta(Stream stream, RespawnInformation instance, RespawnInformation previous) { }

	// RVA: 0x1E064A0 Offset: 0x1E04AA0 VA: 0x181E064A0
	public static void Serialize(Stream stream, RespawnInformation instance) { }

	// RVA: 0x1E067B0 Offset: 0x1E04DB0 VA: 0x181E067B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E067C0 Offset: 0x1E04DC0 VA: 0x181E067C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E06390 Offset: 0x1E04990 VA: 0x181E06390
	public static byte[] SerializeToBytes(RespawnInformation instance) { }

	// RVA: 0x1E062E0 Offset: 0x1E048E0 VA: 0x181E062E0
	public static void SerializeLengthDelimited(Stream stream, RespawnInformation instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class RespawnInformation.SpawnOptions : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6492
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public RespawnInformation.SpawnOptions.RespawnType type; // 0x14
	public uint id; // 0x18
	public string name; // 0x20
	public float unlockSeconds; // 0x28
	public Vector3 worldPosition; // 0x2C
	public bool occupied; // 0x38

	// Methods

	// RVA: 0x1E10950 Offset: 0x1E0EF50 VA: 0x181E10950
	public static void ResetToPool(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E10860 Offset: 0x1E0EE60 VA: 0x181E10860
	public void ResetToPool() { }

	// RVA: 0x1E10520 Offset: 0x1E0EB20 VA: 0x181E10520 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E0ECD0 Offset: 0x1E0D2D0 VA: 0x181E0ECD0
	public void CopyTo(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E0ED30 Offset: 0x1E0D330 VA: 0x181E0ED30
	public RespawnInformation.SpawnOptions Copy() { }

	// RVA: 0x1E0F8A0 Offset: 0x1E0DEA0 VA: 0x181E0F8A0
	public static RespawnInformation.SpawnOptions Deserialize(Stream stream) { }

	// RVA: 0x1E0F150 Offset: 0x1E0D750 VA: 0x181E0F150
	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0F1D0 Offset: 0x1E0D7D0 VA: 0x181E0F1D0
	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E10190 Offset: 0x1E0E790 VA: 0x181E10190
	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer) { }

	// RVA: 0x1E105A0 Offset: 0x1E0EBA0 VA: 0x181E105A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E112F0 Offset: 0x1E0F8F0 VA: 0x181E112F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E11310 Offset: 0x1E0F910 VA: 0x181E11310 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation.SpawnOptions previous) { }

	// RVA: 0x1E10840 Offset: 0x1E0EE40 VA: 0x181E10840 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0FB80 Offset: 0x1E0E180 VA: 0x181E0FB80
	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer, RespawnInformation.SpawnOptions instance, bool isDelta = False) { }

	// RVA: 0x1E0FEE0 Offset: 0x1E0E4E0 VA: 0x181E0FEE0
	public static RespawnInformation.SpawnOptions Deserialize(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E0EDE0 Offset: 0x1E0D3E0 VA: 0x181E0EDE0
	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E0F560 Offset: 0x1E0DB60 VA: 0x181E0F560
	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E10A40 Offset: 0x1E0F040 VA: 0x181E10A40
	public static void SerializeDelta(Stream stream, RespawnInformation.SpawnOptions instance, RespawnInformation.SpawnOptions previous) { }

	// RVA: 0x1E11020 Offset: 0x1E0F620 VA: 0x181E11020
	public static void Serialize(Stream stream, RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E112E0 Offset: 0x1E0F8E0 VA: 0x181E112E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E112F0 Offset: 0x1E0F8F0 VA: 0x181E112F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E10F10 Offset: 0x1E0F510 VA: 0x181E10F10
	public static byte[] SerializeToBytes(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E10E60 Offset: 0x1E0F460 VA: 0x181E10E60
	public static void SerializeLengthDelimited(Stream stream, RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public enum RespawnInformation.SpawnOptions.RespawnType // TypeDefIndex: 6493
{	// Fields
	public int value__; // 0x0
	public const RespawnInformation.SpawnOptions.RespawnType SleepingBag = 1;
	public const RespawnInformation.SpawnOptions.RespawnType Bed = 2;
	public const RespawnInformation.SpawnOptions.RespawnType BeachTowel = 3;
	public const RespawnInformation.SpawnOptions.RespawnType Camper = 4;

}

