public class SAMSite : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6345
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aimDir; // 0x14

	// Methods

	// RVA: 0x1E07330 Offset: 0x1E05930 VA: 0x181E07330
	public static void ResetToPool(SAMSite instance) { }

	// RVA: 0x1E072B0 Offset: 0x1E058B0 VA: 0x181E072B0
	public void ResetToPool() { }

	// RVA: 0x1E07180 Offset: 0x1E05780 VA: 0x181E07180 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB8430 Offset: 0x1DB6A30 VA: 0x181DB8430
	public void CopyTo(SAMSite instance) { }

	// RVA: 0x1E06800 Offset: 0x1E04E00 VA: 0x181E06800
	public SAMSite Copy() { }

	// RVA: 0x1E07100 Offset: 0x1E05700 VA: 0x181E07100
	public static SAMSite Deserialize(Stream stream) { }

	// RVA: 0x1E06870 Offset: 0x1E04E70 VA: 0x181E06870
	public static SAMSite DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E06D00 Offset: 0x1E05300 VA: 0x181E06D00
	public static SAMSite DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E06FE0 Offset: 0x1E055E0 VA: 0x181E06FE0
	public static SAMSite Deserialize(byte[] buffer) { }

	// RVA: 0x1E07270 Offset: 0x1E05870 VA: 0x181E07270
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E07930 Offset: 0x1E05F30 VA: 0x181E07930 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E07950 Offset: 0x1E05F50 VA: 0x181E07950 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SAMSite previous) { }

	// RVA: 0x1E07290 Offset: 0x1E05890 VA: 0x181E07290 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E06D90 Offset: 0x1E05390 VA: 0x181E06D90
	public static SAMSite Deserialize(byte[] buffer, SAMSite instance, bool isDelta = False) { }

	// RVA: 0x1E06E90 Offset: 0x1E05490 VA: 0x181E06E90
	public static SAMSite Deserialize(Stream stream, SAMSite instance, bool isDelta) { }

	// RVA: 0x1E068F0 Offset: 0x1E04EF0 VA: 0x181E068F0
	public static SAMSite DeserializeLengthDelimited(Stream stream, SAMSite instance, bool isDelta) { }

	// RVA: 0x1E06B10 Offset: 0x1E05110 VA: 0x181E06B10
	public static SAMSite DeserializeLength(Stream stream, int length, SAMSite instance, bool isDelta) { }

	// RVA: 0x1E073B0 Offset: 0x1E059B0 VA: 0x181E073B0
	public static void SerializeDelta(Stream stream, SAMSite instance, SAMSite previous) { }

	// RVA: 0x1E077B0 Offset: 0x1E05DB0 VA: 0x181E077B0
	public static void Serialize(Stream stream, SAMSite instance) { }

	// RVA: 0x1E07920 Offset: 0x1E05F20 VA: 0x181E07920
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E07930 Offset: 0x1E05F30 VA: 0x181E07930
	public void ToProto(Stream stream) { }

	// RVA: 0x1E076A0 Offset: 0x1E05CA0 VA: 0x181E076A0
	public static byte[] SerializeToBytes(SAMSite instance) { }

	// RVA: 0x1E075F0 Offset: 0x1E05BF0 VA: 0x181E075F0
	public static void SerializeLengthDelimited(Stream stream, SAMSite instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class SamSite : ContainerIOEntity // TypeDefIndex: 8441
{	// Fields
	private Option __menuOption_Menu_DisableDefenderMode; // 0x378
	private Option __menuOption_Menu_EnableDefenderMode; // 0x3D0
	public Animator pitchAnimator; // 0x428
	public GameObject yaw; // 0x430
	public GameObject pitch; // 0x438
	public GameObject gear; // 0x440
	public Transform eyePoint; // 0x448
	public float gearEpislonDegrees; // 0x450
	public float turnSpeed; // 0x454
	public float clientLerpSpeed; // 0x458
	public Vector3 currentAimDir; // 0x45C
	public Vector3 targetAimDir; // 0x468
	public float vehicleScanRadius; // 0x474
	public float missileScanRadius; // 0x478
	public GameObjectRef projectileTest; // 0x480
	public GameObjectRef muzzleFlashTest; // 0x488
	public bool staticRespawn; // 0x490
	public ItemDefinition ammoType; // 0x498
	public Transform[] tubes; // 0x4A0
	[ServerVar] // RVA: 0x818B0 Offset: 0x80CB0 VA: 0x1800818B0
	public static float staticrepairseconds; // 0x0
	public SoundDefinition yawMovementLoopDef; // 0x4A8
	public float yawGainLerp; // 0x4B0
	public float yawGainMovementSpeedMult; // 0x4B4
	public SoundDefinition pitchMovementLoopDef; // 0x4B8
	public float pitchGainLerp; // 0x4C0
	public float pitchGainMovementSpeedMult; // 0x4C4
	public int lowAmmoThreshold; // 0x4C8
	public BaseEntity.Flags Flag_DefenderMode; // 0x4CC
	private Sound yawMovementLoop; // 0x4D0
	private Sound pitchMovementLoop; // 0x4D8
	private SoundModulation.Modulator yawGainModulator; // 0x4E0
	private SoundModulation.Modulator pitchGainModulator; // 0x4E8
	private float previousYawAngle; // 0x4F0
	private float previousPitchAngle; // 0x4F4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x49DDA0 Offset: 0x49C3A0 VA: 0x18049DDA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x49F2E0 Offset: 0x49D8E0 VA: 0x18049F2E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x49E560 Offset: 0x49CB60 VA: 0x18049E560 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49E370 Offset: 0x49C970 VA: 0x18049E370 Slot: 153
	public override bool IsPowered() { }

	// RVA: 0x49DC50 Offset: 0x49C250 VA: 0x18049DC50 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x49E360 Offset: 0x49C960 VA: 0x18049E360
	public bool IsInDefenderMode() { }

	// RVA: 0x49E390 Offset: 0x49C990 VA: 0x18049E390 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x49E8A0 Offset: 0x49CEA0 VA: 0x18049E8A0
	public void UpdateClientTargetAimDir(Vector3 aimDir) { }

	// RVA: 0x49E650 Offset: 0x49CC50 VA: 0x18049E650
	public void SetClientAim(Vector3 aimDir) { }

	// RVA: 0x49F020 Offset: 0x49D620 VA: 0x18049F020
	public void Update() { }

	// RVA: 0x49E8C0 Offset: 0x49CEC0 VA: 0x18049E8C0
	private void UpdateSounds() { }

	// RVA: 0x49DC60 Offset: 0x49C260 VA: 0x18049DC60 Slot: 19
	protected override void DoClientDestroy() { }

	[BaseEntity.Menu] // RVA: 0x81990 Offset: 0x80D90 VA: 0x180081990
	[BaseEntity.Menu.Description] // RVA: 0x81990 Offset: 0x80D90 VA: 0x180081990
	[BaseEntity.Menu.Icon] // RVA: 0x81990 Offset: 0x80D90 VA: 0x180081990
	[BaseEntity.Menu.ShowIf] // RVA: 0x81990 Offset: 0x80D90 VA: 0x180081990
	// RVA: 0x49E510 Offset: 0x49CB10 VA: 0x18049E510
	private void Menu_EnableDefenderMode(BasePlayer player) { }

	// RVA: 0x49E4B0 Offset: 0x49CAB0 VA: 0x18049E4B0
	private bool Menu_EnableDefenderMode_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x81B90 Offset: 0x80F90 VA: 0x180081B90
	[BaseEntity.Menu.Description] // RVA: 0x81B90 Offset: 0x80F90 VA: 0x180081B90
	[BaseEntity.Menu.Icon] // RVA: 0x81B90 Offset: 0x80F90 VA: 0x180081B90
	[BaseEntity.Menu.ShowIf] // RVA: 0x81B90 Offset: 0x80F90 VA: 0x180081B90
	// RVA: 0x49E460 Offset: 0x49CA60 VA: 0x18049E460
	private void Menu_DisableDefenderMode(BasePlayer player) { }

	// RVA: 0x49E410 Offset: 0x49CA10 VA: 0x18049E410
	private bool Menu_DisableDefenderMode_ShowIf(BasePlayer player) { }

	// RVA: 0x49F1D0 Offset: 0x49D7D0 VA: 0x18049F1D0
	public void .ctor() { }

	// RVA: 0x49F190 Offset: 0x49D790 VA: 0x18049F190
	private static void .cctor() { }

}

