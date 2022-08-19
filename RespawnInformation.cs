public class RespawnInformation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6491
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<RespawnInformation.SpawnOptions> spawnOptions; // 0x18
	public PlayerLifeStory previousLife; // 0x20
	public bool fadeIn; // 0x28

	// Methods

	// RVA: 0x1E05A70 Offset: 0x1E04070 VA: 0x181E05A70
	public static void ResetToPool(RespawnInformation instance) { }

	// RVA: 0x1E05C90 Offset: 0x1E04290 VA: 0x181E05C90
	public void ResetToPool() { }

	// RVA: 0x1E059B0 Offset: 0x1E03FB0 VA: 0x181E059B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E04A60 Offset: 0x1E03060 VA: 0x181E04A60
	public void CopyTo(RespawnInformation instance) { }

	// RVA: 0x1E04C80 Offset: 0x1E03280 VA: 0x181E04C80
	public RespawnInformation Copy() { }

	// RVA: 0x1E05810 Offset: 0x1E03E10 VA: 0x181E05810
	public static RespawnInformation Deserialize(Stream stream) { }

	// RVA: 0x1E04D00 Offset: 0x1E03300 VA: 0x181E04D00
	public static RespawnInformation DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E053F0 Offset: 0x1E039F0 VA: 0x181E053F0
	public static RespawnInformation DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E05890 Offset: 0x1E03E90 VA: 0x181E05890
	public static RespawnInformation Deserialize(byte[] buffer) { }

	// RVA: 0x1E05A30 Offset: 0x1E04030 VA: 0x181E05A30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E066C0 Offset: 0x1E04CC0 VA: 0x181E066C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E066E0 Offset: 0x1E04CE0 VA: 0x181E066E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation previous) { }

	// RVA: 0x1E05A50 Offset: 0x1E04050 VA: 0x181E05A50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E05480 Offset: 0x1E03A80 VA: 0x181E05480
	public static RespawnInformation Deserialize(byte[] buffer, RespawnInformation instance, bool isDelta = False) { }

	// RVA: 0x1E05580 Offset: 0x1E03B80 VA: 0x181E05580
	public static RespawnInformation Deserialize(Stream stream, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E04D80 Offset: 0x1E03380 VA: 0x181E04D80
	public static RespawnInformation DeserializeLengthDelimited(Stream stream, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E050D0 Offset: 0x1E036D0 VA: 0x181E050D0
	public static RespawnInformation DeserializeLength(Stream stream, int length, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E05EB0 Offset: 0x1E044B0 VA: 0x181E05EB0
	public static void SerializeDelta(Stream stream, RespawnInformation instance, RespawnInformation previous) { }

	// RVA: 0x1E063A0 Offset: 0x1E049A0 VA: 0x181E063A0
	public static void Serialize(Stream stream, RespawnInformation instance) { }

	// RVA: 0x1E066B0 Offset: 0x1E04CB0 VA: 0x181E066B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E066C0 Offset: 0x1E04CC0 VA: 0x181E066C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E06290 Offset: 0x1E04890 VA: 0x181E06290
	public static byte[] SerializeToBytes(RespawnInformation instance) { }

	// RVA: 0x1E061E0 Offset: 0x1E047E0 VA: 0x181E061E0
	public static void SerializeLengthDelimited(Stream stream, RespawnInformation instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1E10850 Offset: 0x1E0EE50 VA: 0x181E10850
	public static void ResetToPool(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E10760 Offset: 0x1E0ED60 VA: 0x181E10760
	public void ResetToPool() { }

	// RVA: 0x1E10420 Offset: 0x1E0EA20 VA: 0x181E10420 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E0EBD0 Offset: 0x1E0D1D0 VA: 0x181E0EBD0
	public void CopyTo(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E0EC30 Offset: 0x1E0D230 VA: 0x181E0EC30
	public RespawnInformation.SpawnOptions Copy() { }

	// RVA: 0x1E0F7A0 Offset: 0x1E0DDA0 VA: 0x181E0F7A0
	public static RespawnInformation.SpawnOptions Deserialize(Stream stream) { }

	// RVA: 0x1E0F050 Offset: 0x1E0D650 VA: 0x181E0F050
	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0F0D0 Offset: 0x1E0D6D0 VA: 0x181E0F0D0
	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E10090 Offset: 0x1E0E690 VA: 0x181E10090
	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer) { }

	// RVA: 0x1E104A0 Offset: 0x1E0EAA0 VA: 0x181E104A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E111F0 Offset: 0x1E0F7F0 VA: 0x181E111F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E11210 Offset: 0x1E0F810 VA: 0x181E11210 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation.SpawnOptions previous) { }

	// RVA: 0x1E10740 Offset: 0x1E0ED40 VA: 0x181E10740 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0FA80 Offset: 0x1E0E080 VA: 0x181E0FA80
	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer, RespawnInformation.SpawnOptions instance, bool isDelta = False) { }

	// RVA: 0x1E0FDE0 Offset: 0x1E0E3E0 VA: 0x181E0FDE0
	public static RespawnInformation.SpawnOptions Deserialize(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E0ECE0 Offset: 0x1E0D2E0 VA: 0x181E0ECE0
	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E0F460 Offset: 0x1E0DA60 VA: 0x181E0F460
	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E10940 Offset: 0x1E0EF40 VA: 0x181E10940
	public static void SerializeDelta(Stream stream, RespawnInformation.SpawnOptions instance, RespawnInformation.SpawnOptions previous) { }

	// RVA: 0x1E10F20 Offset: 0x1E0F520 VA: 0x181E10F20
	public static void Serialize(Stream stream, RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E111E0 Offset: 0x1E0F7E0 VA: 0x181E111E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E111F0 Offset: 0x1E0F7F0 VA: 0x181E111F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E10E10 Offset: 0x1E0F410 VA: 0x181E10E10
	public static byte[] SerializeToBytes(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E10D60 Offset: 0x1E0F360 VA: 0x181E10D60
	public static void SerializeLengthDelimited(Stream stream, RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

