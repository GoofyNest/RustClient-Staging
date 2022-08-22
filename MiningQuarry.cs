public class MiningQuarry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6324
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ResourceExtractor extractor; // 0x18
	public int staticType; // 0x20

	// Methods

	// RVA: 0x1F4A170 Offset: 0x1F48770 VA: 0x181F4A170
	public static void ResetToPool(MiningQuarry instance) { }

	// RVA: 0x1F4A220 Offset: 0x1F48820 VA: 0x181F4A220
	public void ResetToPool() { }

	// RVA: 0x1F4A000 Offset: 0x1F48600 VA: 0x181F4A000 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F49220 Offset: 0x1F47820 VA: 0x181F49220
	public void CopyTo(MiningQuarry instance) { }

	// RVA: 0x1F492B0 Offset: 0x1F478B0 VA: 0x181F492B0
	public MiningQuarry Copy() { }

	// RVA: 0x1F49E40 Offset: 0x1F48440 VA: 0x181F49E40
	public static MiningQuarry Deserialize(Stream stream) { }

	// RVA: 0x1F495F0 Offset: 0x1F47BF0 VA: 0x181F495F0
	public static MiningQuarry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F498B0 Offset: 0x1F47EB0 VA: 0x181F498B0
	public static MiningQuarry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F49940 Offset: 0x1F47F40 VA: 0x181F49940
	public static MiningQuarry Deserialize(byte[] buffer) { }

	// RVA: 0x1F4A130 Offset: 0x1F48730 VA: 0x181F4A130
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4A890 Offset: 0x1F48E90 VA: 0x181F4A890 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4A8B0 Offset: 0x1F48EB0 VA: 0x181F4A8B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MiningQuarry previous) { }

	// RVA: 0x1F4A150 Offset: 0x1F48750 VA: 0x181F4A150 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F49D40 Offset: 0x1F48340 VA: 0x181F49D40
	public static MiningQuarry Deserialize(byte[] buffer, MiningQuarry instance, bool isDelta = False) { }

	// RVA: 0x1F49BB0 Offset: 0x1F481B0 VA: 0x181F49BB0
	public static MiningQuarry Deserialize(Stream stream, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F49380 Offset: 0x1F47980 VA: 0x181F49380
	public static MiningQuarry DeserializeLengthDelimited(Stream stream, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F49670 Offset: 0x1F47C70 VA: 0x181F49670
	public static MiningQuarry DeserializeLength(Stream stream, int length, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F4A2D0 Offset: 0x1F488D0 VA: 0x181F4A2D0
	public static void SerializeDelta(Stream stream, MiningQuarry instance, MiningQuarry previous) { }

	// RVA: 0x1F4A6A0 Offset: 0x1F48CA0 VA: 0x181F4A6A0
	public static void Serialize(Stream stream, MiningQuarry instance) { }

	// RVA: 0x1F4A880 Offset: 0x1F48E80 VA: 0x181F4A880
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4A890 Offset: 0x1F48E90 VA: 0x181F4A890
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4A590 Offset: 0x1F48B90 VA: 0x181F4A590
	public static byte[] SerializeToBytes(MiningQuarry instance) { }

	// RVA: 0x1F4A4E0 Offset: 0x1F48AE0 VA: 0x181F4A4E0
	public static void SerializeLengthDelimited(Stream stream, MiningQuarry instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class MiningQuarry : BaseResourceExtractor // TypeDefIndex: 9568
{	// Fields
	public Animator beltAnimator; // 0x248
	public Renderer beltScrollRenderer; // 0x250
	public int scrollMatIndex; // 0x258
	public SoundPlayer[] onSounds; // 0x260
	public float processRate; // 0x268
	public float workToAdd; // 0x26C
	public GameObjectRef bucketDropEffect; // 0x270
	public GameObject bucketDropTransform; // 0x278
	public MiningQuarry.ChildPrefab engineSwitchPrefab; // 0x280
	public MiningQuarry.ChildPrefab hopperPrefab; // 0x288
	public MiningQuarry.ChildPrefab fuelStoragePrefab; // 0x290
	public MiningQuarry.QuarryType staticType; // 0x298
	public bool isStatic; // 0x29C
	private List<SoundModulation.Modulator> soundGainMods; // 0x2A0
	private List<SoundModulation.Modulator> soundPitchMods; // 0x2A8
	private float beltSpeed; // 0x2B0

	// Methods

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool IsEngineOn() { }

	// RVA: 0x767AA0 Offset: 0x7660A0 VA: 0x180767AA0
	public void Update() { }

	// RVA: 0x7678B0 Offset: 0x765EB0 VA: 0x1807678B0
	public void BucketDrop() { }

	// RVA: 0x767910 Offset: 0x765F10 VA: 0x180767910 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x767E50 Offset: 0x766450 VA: 0x180767E50
	public void .ctor() { }

}

public enum MiningQuarry.QuarryType // TypeDefIndex: 9569
{	// Fields
	public int value__; // 0x0
	public const MiningQuarry.QuarryType None = 0;
	public const MiningQuarry.QuarryType Basic = 1;
	public const MiningQuarry.QuarryType Sulfur = 2;
	public const MiningQuarry.QuarryType HQM = 3;

}

public class MiningQuarry.ChildPrefab // TypeDefIndex: 9570
{	// Fields
	public GameObjectRef prefabToSpawn; // 0x10
	public GameObject origin; // 0x18
	public BaseEntity instance; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

