public class MiningQuarry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6324
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ResourceExtractor extractor; // 0x18
	public int staticType; // 0x20

	// Methods

	// RVA: 0x1F49EB0 Offset: 0x1F484B0 VA: 0x181F49EB0
	public static void ResetToPool(MiningQuarry instance) { }

	// RVA: 0x1F49F60 Offset: 0x1F48560 VA: 0x181F49F60
	public void ResetToPool() { }

	// RVA: 0x1F49D40 Offset: 0x1F48340 VA: 0x181F49D40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F48F60 Offset: 0x1F47560 VA: 0x181F48F60
	public void CopyTo(MiningQuarry instance) { }

	// RVA: 0x1F48FF0 Offset: 0x1F475F0 VA: 0x181F48FF0
	public MiningQuarry Copy() { }

	// RVA: 0x1F49B80 Offset: 0x1F48180 VA: 0x181F49B80
	public static MiningQuarry Deserialize(Stream stream) { }

	// RVA: 0x1F49330 Offset: 0x1F47930 VA: 0x181F49330
	public static MiningQuarry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F495F0 Offset: 0x1F47BF0 VA: 0x181F495F0
	public static MiningQuarry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F49680 Offset: 0x1F47C80 VA: 0x181F49680
	public static MiningQuarry Deserialize(byte[] buffer) { }

	// RVA: 0x1F49E70 Offset: 0x1F48470 VA: 0x181F49E70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4A5D0 Offset: 0x1F48BD0 VA: 0x181F4A5D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4A5F0 Offset: 0x1F48BF0 VA: 0x181F4A5F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MiningQuarry previous) { }

	// RVA: 0x1F49E90 Offset: 0x1F48490 VA: 0x181F49E90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F49A80 Offset: 0x1F48080 VA: 0x181F49A80
	public static MiningQuarry Deserialize(byte[] buffer, MiningQuarry instance, bool isDelta = False) { }

	// RVA: 0x1F498F0 Offset: 0x1F47EF0 VA: 0x181F498F0
	public static MiningQuarry Deserialize(Stream stream, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F490C0 Offset: 0x1F476C0 VA: 0x181F490C0
	public static MiningQuarry DeserializeLengthDelimited(Stream stream, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F493B0 Offset: 0x1F479B0 VA: 0x181F493B0
	public static MiningQuarry DeserializeLength(Stream stream, int length, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F4A010 Offset: 0x1F48610 VA: 0x181F4A010
	public static void SerializeDelta(Stream stream, MiningQuarry instance, MiningQuarry previous) { }

	// RVA: 0x1F4A3E0 Offset: 0x1F489E0 VA: 0x181F4A3E0
	public static void Serialize(Stream stream, MiningQuarry instance) { }

	// RVA: 0x1F4A5C0 Offset: 0x1F48BC0 VA: 0x181F4A5C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4A5D0 Offset: 0x1F48BD0 VA: 0x181F4A5D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4A2D0 Offset: 0x1F488D0 VA: 0x181F4A2D0
	public static byte[] SerializeToBytes(MiningQuarry instance) { }

	// RVA: 0x1F4A220 Offset: 0x1F48820 VA: 0x181F4A220
	public static void SerializeLengthDelimited(Stream stream, MiningQuarry instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x767990 Offset: 0x765F90 VA: 0x180767990
	public void Update() { }

	// RVA: 0x7677A0 Offset: 0x765DA0 VA: 0x1807677A0
	public void BucketDrop() { }

	// RVA: 0x767800 Offset: 0x765E00 VA: 0x180767800 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x767D40 Offset: 0x766340 VA: 0x180767D40
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

