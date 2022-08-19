public class MiningQuarry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6324
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ResourceExtractor extractor; // 0x18
	public int staticType; // 0x20

	// Methods

	// RVA: 0x1F4A070 Offset: 0x1F48670 VA: 0x181F4A070
	public static void ResetToPool(MiningQuarry instance) { }

	// RVA: 0x1F4A120 Offset: 0x1F48720 VA: 0x181F4A120
	public void ResetToPool() { }

	// RVA: 0x1F49F00 Offset: 0x1F48500 VA: 0x181F49F00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F49120 Offset: 0x1F47720 VA: 0x181F49120
	public void CopyTo(MiningQuarry instance) { }

	// RVA: 0x1F491B0 Offset: 0x1F477B0 VA: 0x181F491B0
	public MiningQuarry Copy() { }

	// RVA: 0x1F49D40 Offset: 0x1F48340 VA: 0x181F49D40
	public static MiningQuarry Deserialize(Stream stream) { }

	// RVA: 0x1F494F0 Offset: 0x1F47AF0 VA: 0x181F494F0
	public static MiningQuarry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F497B0 Offset: 0x1F47DB0 VA: 0x181F497B0
	public static MiningQuarry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F49840 Offset: 0x1F47E40 VA: 0x181F49840
	public static MiningQuarry Deserialize(byte[] buffer) { }

	// RVA: 0x1F4A030 Offset: 0x1F48630 VA: 0x181F4A030
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4A790 Offset: 0x1F48D90 VA: 0x181F4A790 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4A7B0 Offset: 0x1F48DB0 VA: 0x181F4A7B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MiningQuarry previous) { }

	// RVA: 0x1F4A050 Offset: 0x1F48650 VA: 0x181F4A050 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F49C40 Offset: 0x1F48240 VA: 0x181F49C40
	public static MiningQuarry Deserialize(byte[] buffer, MiningQuarry instance, bool isDelta = False) { }

	// RVA: 0x1F49AB0 Offset: 0x1F480B0 VA: 0x181F49AB0
	public static MiningQuarry Deserialize(Stream stream, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F49280 Offset: 0x1F47880 VA: 0x181F49280
	public static MiningQuarry DeserializeLengthDelimited(Stream stream, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F49570 Offset: 0x1F47B70 VA: 0x181F49570
	public static MiningQuarry DeserializeLength(Stream stream, int length, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F4A1D0 Offset: 0x1F487D0 VA: 0x181F4A1D0
	public static void SerializeDelta(Stream stream, MiningQuarry instance, MiningQuarry previous) { }

	// RVA: 0x1F4A5A0 Offset: 0x1F48BA0 VA: 0x181F4A5A0
	public static void Serialize(Stream stream, MiningQuarry instance) { }

	// RVA: 0x1F4A780 Offset: 0x1F48D80 VA: 0x181F4A780
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4A790 Offset: 0x1F48D90 VA: 0x181F4A790
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4A490 Offset: 0x1F48A90 VA: 0x181F4A490
	public static byte[] SerializeToBytes(MiningQuarry instance) { }

	// RVA: 0x1F4A3E0 Offset: 0x1F489E0 VA: 0x181F4A3E0
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

