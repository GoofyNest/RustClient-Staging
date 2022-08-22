public class RespawnInformation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6491
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<RespawnInformation.SpawnOptions> spawnOptions; // 0x18
	public PlayerLifeStory previousLife; // 0x20
	public bool fadeIn; // 0x28

	// Methods

	// RVA: 0x1E06390 Offset: 0x1E04990 VA: 0x181E06390
	public static void ResetToPool(RespawnInformation instance) { }

	// RVA: 0x1E065B0 Offset: 0x1E04BB0 VA: 0x181E065B0
	public void ResetToPool() { }

	// RVA: 0x1E062D0 Offset: 0x1E048D0 VA: 0x181E062D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E05380 Offset: 0x1E03980 VA: 0x181E05380
	public void CopyTo(RespawnInformation instance) { }

	// RVA: 0x1E055A0 Offset: 0x1E03BA0 VA: 0x181E055A0
	public RespawnInformation Copy() { }

	// RVA: 0x1E06130 Offset: 0x1E04730 VA: 0x181E06130
	public static RespawnInformation Deserialize(Stream stream) { }

	// RVA: 0x1E05620 Offset: 0x1E03C20 VA: 0x181E05620
	public static RespawnInformation DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E05D10 Offset: 0x1E04310 VA: 0x181E05D10
	public static RespawnInformation DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E061B0 Offset: 0x1E047B0 VA: 0x181E061B0
	public static RespawnInformation Deserialize(byte[] buffer) { }

	// RVA: 0x1E06350 Offset: 0x1E04950 VA: 0x181E06350
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E06FE0 Offset: 0x1E055E0 VA: 0x181E06FE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E07000 Offset: 0x1E05600 VA: 0x181E07000 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation previous) { }

	// RVA: 0x1E06370 Offset: 0x1E04970 VA: 0x181E06370 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E05DA0 Offset: 0x1E043A0 VA: 0x181E05DA0
	public static RespawnInformation Deserialize(byte[] buffer, RespawnInformation instance, bool isDelta = False) { }

	// RVA: 0x1E05EA0 Offset: 0x1E044A0 VA: 0x181E05EA0
	public static RespawnInformation Deserialize(Stream stream, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E056A0 Offset: 0x1E03CA0 VA: 0x181E056A0
	public static RespawnInformation DeserializeLengthDelimited(Stream stream, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E059F0 Offset: 0x1E03FF0 VA: 0x181E059F0
	public static RespawnInformation DeserializeLength(Stream stream, int length, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E067D0 Offset: 0x1E04DD0 VA: 0x181E067D0
	public static void SerializeDelta(Stream stream, RespawnInformation instance, RespawnInformation previous) { }

	// RVA: 0x1E06CC0 Offset: 0x1E052C0 VA: 0x181E06CC0
	public static void Serialize(Stream stream, RespawnInformation instance) { }

	// RVA: 0x1E06FD0 Offset: 0x1E055D0 VA: 0x181E06FD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E06FE0 Offset: 0x1E055E0 VA: 0x181E06FE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E06BB0 Offset: 0x1E051B0 VA: 0x181E06BB0
	public static byte[] SerializeToBytes(RespawnInformation instance) { }

	// RVA: 0x1E06B00 Offset: 0x1E05100 VA: 0x181E06B00
	public static void SerializeLengthDelimited(Stream stream, RespawnInformation instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1E11170 Offset: 0x1E0F770 VA: 0x181E11170
	public static void ResetToPool(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E11080 Offset: 0x1E0F680 VA: 0x181E11080
	public void ResetToPool() { }

	// RVA: 0x1E10D40 Offset: 0x1E0F340 VA: 0x181E10D40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E0F4F0 Offset: 0x1E0DAF0 VA: 0x181E0F4F0
	public void CopyTo(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E0F550 Offset: 0x1E0DB50 VA: 0x181E0F550
	public RespawnInformation.SpawnOptions Copy() { }

	// RVA: 0x1E100C0 Offset: 0x1E0E6C0 VA: 0x181E100C0
	public static RespawnInformation.SpawnOptions Deserialize(Stream stream) { }

	// RVA: 0x1E0F970 Offset: 0x1E0DF70 VA: 0x181E0F970
	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0F9F0 Offset: 0x1E0DFF0 VA: 0x181E0F9F0
	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E109B0 Offset: 0x1E0EFB0 VA: 0x181E109B0
	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer) { }

	// RVA: 0x1E10DC0 Offset: 0x1E0F3C0 VA: 0x181E10DC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E11B10 Offset: 0x1E10110 VA: 0x181E11B10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E11B30 Offset: 0x1E10130 VA: 0x181E11B30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation.SpawnOptions previous) { }

	// RVA: 0x1E11060 Offset: 0x1E0F660 VA: 0x181E11060 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E103A0 Offset: 0x1E0E9A0 VA: 0x181E103A0
	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer, RespawnInformation.SpawnOptions instance, bool isDelta = False) { }

	// RVA: 0x1E10700 Offset: 0x1E0ED00 VA: 0x181E10700
	public static RespawnInformation.SpawnOptions Deserialize(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E0F600 Offset: 0x1E0DC00 VA: 0x181E0F600
	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E0FD80 Offset: 0x1E0E380 VA: 0x181E0FD80
	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E11260 Offset: 0x1E0F860 VA: 0x181E11260
	public static void SerializeDelta(Stream stream, RespawnInformation.SpawnOptions instance, RespawnInformation.SpawnOptions previous) { }

	// RVA: 0x1E11840 Offset: 0x1E0FE40 VA: 0x181E11840
	public static void Serialize(Stream stream, RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E11B00 Offset: 0x1E10100 VA: 0x181E11B00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E11B10 Offset: 0x1E10110 VA: 0x181E11B10
	public void ToProto(Stream stream) { }

	// RVA: 0x1E11730 Offset: 0x1E0FD30 VA: 0x181E11730
	public static byte[] SerializeToBytes(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E11680 Offset: 0x1E0FC80 VA: 0x181E11680
	public static void SerializeLengthDelimited(Stream stream, RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

