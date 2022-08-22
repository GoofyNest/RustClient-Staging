public class RespawnInformation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6491
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<RespawnInformation.SpawnOptions> spawnOptions; // 0x18
	public PlayerLifeStory previousLife; // 0x20
	public bool fadeIn; // 0x28

	// Methods

	// RVA: 0x1E058B0 Offset: 0x1E03EB0 VA: 0x181E058B0
	public static void ResetToPool(RespawnInformation instance) { }

	// RVA: 0x1E05AD0 Offset: 0x1E040D0 VA: 0x181E05AD0
	public void ResetToPool() { }

	// RVA: 0x1E057F0 Offset: 0x1E03DF0 VA: 0x181E057F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E048A0 Offset: 0x1E02EA0 VA: 0x181E048A0
	public void CopyTo(RespawnInformation instance) { }

	// RVA: 0x1E04AC0 Offset: 0x1E030C0 VA: 0x181E04AC0
	public RespawnInformation Copy() { }

	// RVA: 0x1E05650 Offset: 0x1E03C50 VA: 0x181E05650
	public static RespawnInformation Deserialize(Stream stream) { }

	// RVA: 0x1E04B40 Offset: 0x1E03140 VA: 0x181E04B40
	public static RespawnInformation DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E05230 Offset: 0x1E03830 VA: 0x181E05230
	public static RespawnInformation DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E056D0 Offset: 0x1E03CD0 VA: 0x181E056D0
	public static RespawnInformation Deserialize(byte[] buffer) { }

	// RVA: 0x1E05870 Offset: 0x1E03E70 VA: 0x181E05870
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E06500 Offset: 0x1E04B00 VA: 0x181E06500 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E06520 Offset: 0x1E04B20 VA: 0x181E06520 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation previous) { }

	// RVA: 0x1E05890 Offset: 0x1E03E90 VA: 0x181E05890 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E052C0 Offset: 0x1E038C0 VA: 0x181E052C0
	public static RespawnInformation Deserialize(byte[] buffer, RespawnInformation instance, bool isDelta = False) { }

	// RVA: 0x1E053C0 Offset: 0x1E039C0 VA: 0x181E053C0
	public static RespawnInformation Deserialize(Stream stream, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E04BC0 Offset: 0x1E031C0 VA: 0x181E04BC0
	public static RespawnInformation DeserializeLengthDelimited(Stream stream, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E04F10 Offset: 0x1E03510 VA: 0x181E04F10
	public static RespawnInformation DeserializeLength(Stream stream, int length, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E05CF0 Offset: 0x1E042F0 VA: 0x181E05CF0
	public static void SerializeDelta(Stream stream, RespawnInformation instance, RespawnInformation previous) { }

	// RVA: 0x1E061E0 Offset: 0x1E047E0 VA: 0x181E061E0
	public static void Serialize(Stream stream, RespawnInformation instance) { }

	// RVA: 0x1E064F0 Offset: 0x1E04AF0 VA: 0x181E064F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E06500 Offset: 0x1E04B00 VA: 0x181E06500
	public void ToProto(Stream stream) { }

	// RVA: 0x1E060D0 Offset: 0x1E046D0 VA: 0x181E060D0
	public static byte[] SerializeToBytes(RespawnInformation instance) { }

	// RVA: 0x1E06020 Offset: 0x1E04620 VA: 0x181E06020
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

	// RVA: 0x1E10690 Offset: 0x1E0EC90 VA: 0x181E10690
	public static void ResetToPool(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E105A0 Offset: 0x1E0EBA0 VA: 0x181E105A0
	public void ResetToPool() { }

	// RVA: 0x1E10260 Offset: 0x1E0E860 VA: 0x181E10260 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E0EA10 Offset: 0x1E0D010 VA: 0x181E0EA10
	public void CopyTo(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E0EA70 Offset: 0x1E0D070 VA: 0x181E0EA70
	public RespawnInformation.SpawnOptions Copy() { }

	// RVA: 0x1E0F5E0 Offset: 0x1E0DBE0 VA: 0x181E0F5E0
	public static RespawnInformation.SpawnOptions Deserialize(Stream stream) { }

	// RVA: 0x1E0EE90 Offset: 0x1E0D490 VA: 0x181E0EE90
	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0EF10 Offset: 0x1E0D510 VA: 0x181E0EF10
	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0FED0 Offset: 0x1E0E4D0 VA: 0x181E0FED0
	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer) { }

	// RVA: 0x1E102E0 Offset: 0x1E0E8E0 VA: 0x181E102E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E11030 Offset: 0x1E0F630 VA: 0x181E11030 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E11050 Offset: 0x1E0F650 VA: 0x181E11050 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation.SpawnOptions previous) { }

	// RVA: 0x1E10580 Offset: 0x1E0EB80 VA: 0x181E10580 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0F8C0 Offset: 0x1E0DEC0 VA: 0x181E0F8C0
	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer, RespawnInformation.SpawnOptions instance, bool isDelta = False) { }

	// RVA: 0x1E0FC20 Offset: 0x1E0E220 VA: 0x181E0FC20
	public static RespawnInformation.SpawnOptions Deserialize(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E0EB20 Offset: 0x1E0D120 VA: 0x181E0EB20
	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E0F2A0 Offset: 0x1E0D8A0 VA: 0x181E0F2A0
	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E10780 Offset: 0x1E0ED80 VA: 0x181E10780
	public static void SerializeDelta(Stream stream, RespawnInformation.SpawnOptions instance, RespawnInformation.SpawnOptions previous) { }

	// RVA: 0x1E10D60 Offset: 0x1E0F360 VA: 0x181E10D60
	public static void Serialize(Stream stream, RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E11020 Offset: 0x1E0F620 VA: 0x181E11020
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E11030 Offset: 0x1E0F630 VA: 0x181E11030
	public void ToProto(Stream stream) { }

	// RVA: 0x1E10C50 Offset: 0x1E0F250 VA: 0x181E10C50
	public static byte[] SerializeToBytes(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E10BA0 Offset: 0x1E0F1A0 VA: 0x181E10BA0
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

