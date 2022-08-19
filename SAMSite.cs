public class SAMSite : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6345
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aimDir; // 0x14

	// Methods

	// RVA: 0x1E07230 Offset: 0x1E05830 VA: 0x181E07230
	public static void ResetToPool(SAMSite instance) { }

	// RVA: 0x1E071B0 Offset: 0x1E057B0 VA: 0x181E071B0
	public void ResetToPool() { }

	// RVA: 0x1E07080 Offset: 0x1E05680 VA: 0x181E07080 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB8330 Offset: 0x1DB6930 VA: 0x181DB8330
	public void CopyTo(SAMSite instance) { }

	// RVA: 0x1E06700 Offset: 0x1E04D00 VA: 0x181E06700
	public SAMSite Copy() { }

	// RVA: 0x1E07000 Offset: 0x1E05600 VA: 0x181E07000
	public static SAMSite Deserialize(Stream stream) { }

	// RVA: 0x1E06770 Offset: 0x1E04D70 VA: 0x181E06770
	public static SAMSite DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E06C00 Offset: 0x1E05200 VA: 0x181E06C00
	public static SAMSite DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E06EE0 Offset: 0x1E054E0 VA: 0x181E06EE0
	public static SAMSite Deserialize(byte[] buffer) { }

	// RVA: 0x1E07170 Offset: 0x1E05770 VA: 0x181E07170
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E07830 Offset: 0x1E05E30 VA: 0x181E07830 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E07850 Offset: 0x1E05E50 VA: 0x181E07850 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SAMSite previous) { }

	// RVA: 0x1E07190 Offset: 0x1E05790 VA: 0x181E07190 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E06C90 Offset: 0x1E05290 VA: 0x181E06C90
	public static SAMSite Deserialize(byte[] buffer, SAMSite instance, bool isDelta = False) { }

	// RVA: 0x1E06D90 Offset: 0x1E05390 VA: 0x181E06D90
	public static SAMSite Deserialize(Stream stream, SAMSite instance, bool isDelta) { }

	// RVA: 0x1E067F0 Offset: 0x1E04DF0 VA: 0x181E067F0
	public static SAMSite DeserializeLengthDelimited(Stream stream, SAMSite instance, bool isDelta) { }

	// RVA: 0x1E06A10 Offset: 0x1E05010 VA: 0x181E06A10
	public static SAMSite DeserializeLength(Stream stream, int length, SAMSite instance, bool isDelta) { }

	// RVA: 0x1E072B0 Offset: 0x1E058B0 VA: 0x181E072B0
	public static void SerializeDelta(Stream stream, SAMSite instance, SAMSite previous) { }

	// RVA: 0x1E076B0 Offset: 0x1E05CB0 VA: 0x181E076B0
	public static void Serialize(Stream stream, SAMSite instance) { }

	// RVA: 0x1E07820 Offset: 0x1E05E20 VA: 0x181E07820
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E07830 Offset: 0x1E05E30 VA: 0x181E07830
	public void ToProto(Stream stream) { }

	// RVA: 0x1E075A0 Offset: 0x1E05BA0 VA: 0x181E075A0
	public static byte[] SerializeToBytes(SAMSite instance) { }

	// RVA: 0x1E074F0 Offset: 0x1E05AF0 VA: 0x181E074F0
	public static void SerializeLengthDelimited(Stream stream, SAMSite instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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
	[ServerVar] // RVA: 0x81830 Offset: 0x80C30 VA: 0x180081830
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

	[BaseEntity.Menu] // RVA: 0x81910 Offset: 0x80D10 VA: 0x180081910
	[BaseEntity.Menu.Description] // RVA: 0x81910 Offset: 0x80D10 VA: 0x180081910
	[BaseEntity.Menu.Icon] // RVA: 0x81910 Offset: 0x80D10 VA: 0x180081910
	[BaseEntity.Menu.ShowIf] // RVA: 0x81910 Offset: 0x80D10 VA: 0x180081910
	// RVA: 0x49E510 Offset: 0x49CB10 VA: 0x18049E510
	private void Menu_EnableDefenderMode(BasePlayer player) { }

	// RVA: 0x49E4B0 Offset: 0x49CAB0 VA: 0x18049E4B0
	private bool Menu_EnableDefenderMode_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x81B20 Offset: 0x80F20 VA: 0x180081B20
	[BaseEntity.Menu.Description] // RVA: 0x81B20 Offset: 0x80F20 VA: 0x180081B20
	[BaseEntity.Menu.Icon] // RVA: 0x81B20 Offset: 0x80F20 VA: 0x180081B20
	[BaseEntity.Menu.ShowIf] // RVA: 0x81B20 Offset: 0x80F20 VA: 0x180081B20
	// RVA: 0x49E460 Offset: 0x49CA60 VA: 0x18049E460
	private void Menu_DisableDefenderMode(BasePlayer player) { }

	// RVA: 0x49E410 Offset: 0x49CA10 VA: 0x18049E410
	private bool Menu_DisableDefenderMode_ShowIf(BasePlayer player) { }

	// RVA: 0x49F1D0 Offset: 0x49D7D0 VA: 0x18049F1D0
	public void .ctor() { }

	// RVA: 0x49F190 Offset: 0x49D790 VA: 0x18049F190
	private static void .cctor() { }

}

