public class MiningQuarry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6324
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ResourceExtractor extractor; // 0x18
	public int staticType; // 0x20

	// Methods

	// RVA: 0x1F4A990 Offset: 0x1F48F90 VA: 0x181F4A990
	public static void ResetToPool(MiningQuarry instance) { }

	// RVA: 0x1F4AA40 Offset: 0x1F49040 VA: 0x181F4AA40
	public void ResetToPool() { }

	// RVA: 0x1F4A820 Offset: 0x1F48E20 VA: 0x181F4A820 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F49A40 Offset: 0x1F48040 VA: 0x181F49A40
	public void CopyTo(MiningQuarry instance) { }

	// RVA: 0x1F49AD0 Offset: 0x1F480D0 VA: 0x181F49AD0
	public MiningQuarry Copy() { }

	// RVA: 0x1F4A660 Offset: 0x1F48C60 VA: 0x181F4A660
	public static MiningQuarry Deserialize(Stream stream) { }

	// RVA: 0x1F49E10 Offset: 0x1F48410 VA: 0x181F49E10
	public static MiningQuarry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4A0D0 Offset: 0x1F486D0 VA: 0x181F4A0D0
	public static MiningQuarry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4A160 Offset: 0x1F48760 VA: 0x181F4A160
	public static MiningQuarry Deserialize(byte[] buffer) { }

	// RVA: 0x1F4A950 Offset: 0x1F48F50 VA: 0x181F4A950
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4B0B0 Offset: 0x1F496B0 VA: 0x181F4B0B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4B0D0 Offset: 0x1F496D0 VA: 0x181F4B0D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MiningQuarry previous) { }

	// RVA: 0x1F4A970 Offset: 0x1F48F70 VA: 0x181F4A970 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4A560 Offset: 0x1F48B60 VA: 0x181F4A560
	public static MiningQuarry Deserialize(byte[] buffer, MiningQuarry instance, bool isDelta = False) { }

	// RVA: 0x1F4A3D0 Offset: 0x1F489D0 VA: 0x181F4A3D0
	public static MiningQuarry Deserialize(Stream stream, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F49BA0 Offset: 0x1F481A0 VA: 0x181F49BA0
	public static MiningQuarry DeserializeLengthDelimited(Stream stream, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F49E90 Offset: 0x1F48490 VA: 0x181F49E90
	public static MiningQuarry DeserializeLength(Stream stream, int length, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F4AAF0 Offset: 0x1F490F0 VA: 0x181F4AAF0
	public static void SerializeDelta(Stream stream, MiningQuarry instance, MiningQuarry previous) { }

	// RVA: 0x1F4AEC0 Offset: 0x1F494C0 VA: 0x181F4AEC0
	public static void Serialize(Stream stream, MiningQuarry instance) { }

	// RVA: 0x1F4B0A0 Offset: 0x1F496A0 VA: 0x181F4B0A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4B0B0 Offset: 0x1F496B0 VA: 0x181F4B0B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4ADB0 Offset: 0x1F493B0 VA: 0x181F4ADB0
	public static byte[] SerializeToBytes(MiningQuarry instance) { }

	// RVA: 0x1F4AD00 Offset: 0x1F49300 VA: 0x181F4AD00
	public static void SerializeLengthDelimited(Stream stream, MiningQuarry instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x4F62A0 Offset: 0x4F48A0 VA: 0x1804F62A0
	public bool IsEngineOn() { }

	// RVA: 0x7679F0 Offset: 0x765FF0 VA: 0x1807679F0
	public void Update() { }

	// RVA: 0x767800 Offset: 0x765E00 VA: 0x180767800
	public void BucketDrop() { }

	// RVA: 0x767860 Offset: 0x765E60 VA: 0x180767860 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x767DA0 Offset: 0x7663A0 VA: 0x180767DA0
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

