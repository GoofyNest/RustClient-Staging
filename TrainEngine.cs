public class TrainEngine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6394
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int throttleSetting; // 0x14
	public uint fuelStorageID; // 0x18
	public int fuelAmount; // 0x1C
	public int numConnectedCars; // 0x20
	public int linedUpToUnload; // 0x24

	// Methods

	// RVA: 0x1EF1D30 Offset: 0x1EF0330 VA: 0x181EF1D30
	public static void ResetToPool(TrainEngine instance) { }

	// RVA: 0x1EF1DE0 Offset: 0x1EF03E0 VA: 0x181EF1DE0
	public void ResetToPool() { }

	// RVA: 0x1EF1990 Offset: 0x1EEFF90 VA: 0x181EF1990 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E219A0 Offset: 0x1E1FFA0 VA: 0x181E219A0
	public void CopyTo(TrainEngine instance) { }

	// RVA: 0x1EF0680 Offset: 0x1EEEC80 VA: 0x181EF0680
	public TrainEngine Copy() { }

	// RVA: 0x1EF0E30 Offset: 0x1EEF430 VA: 0x181EF0E30
	public static TrainEngine Deserialize(Stream stream) { }

	// RVA: 0x1EF0700 Offset: 0x1EEED00 VA: 0x181EF0700
	public static TrainEngine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF0AA0 Offset: 0x1EEF0A0 VA: 0x181EF0AA0
	public static TrainEngine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF13F0 Offset: 0x1EEF9F0 VA: 0x181EF13F0
	public static TrainEngine Deserialize(byte[] buffer) { }

	// RVA: 0x1EF1AC0 Offset: 0x1EF00C0 VA: 0x181EF1AC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF2440 Offset: 0x1EF0A40 VA: 0x181EF2440 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF2460 Offset: 0x1EF0A60 VA: 0x181EF2460 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TrainEngine previous) { }

	// RVA: 0x1EF1D10 Offset: 0x1EF0310 VA: 0x181EF1D10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF10C0 Offset: 0x1EEF6C0 VA: 0x181EF10C0
	public static TrainEngine Deserialize(byte[] buffer, TrainEngine instance, bool isDelta = False) { }

	// RVA: 0x1EF1740 Offset: 0x1EEFD40 VA: 0x181EF1740
	public static TrainEngine Deserialize(Stream stream, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EF0780 Offset: 0x1EEED80 VA: 0x181EF0780
	public static TrainEngine DeserializeLengthDelimited(Stream stream, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EF0B30 Offset: 0x1EEF130 VA: 0x181EF0B30
	public static TrainEngine DeserializeLength(Stream stream, int length, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EF1E90 Offset: 0x1EF0490 VA: 0x181EF1E90
	public static void SerializeDelta(Stream stream, TrainEngine instance, TrainEngine previous) { }

	// RVA: 0x1EF22C0 Offset: 0x1EF08C0 VA: 0x181EF22C0
	public static void Serialize(Stream stream, TrainEngine instance) { }

	// RVA: 0x1EF2430 Offset: 0x1EF0A30 VA: 0x181EF2430
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF2440 Offset: 0x1EF0A40 VA: 0x181EF2440
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF21B0 Offset: 0x1EF07B0 VA: 0x181EF21B0
	public static byte[] SerializeToBytes(TrainEngine instance) { }

	// RVA: 0x1EF2100 Offset: 0x1EF0700 VA: 0x181EF2100
	public static void SerializeLengthDelimited(Stream stream, TrainEngine instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class TrainEngine : TrainCar, IEngineControllerUser, IEntity // TypeDefIndex: 8472
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x538
	private int clientFuelAmount; // 0x590
	private int clientNumConnectedCars; // 0x594
	private int clientLinedUpToUnload; // 0x598
	private float lastUpdateHealth; // 0x59C
	private StringBuilder monitorTextStr; // 0x5A0
	private bool wasBraking; // 0x5A8
	private bool highlightCouplingInfo; // 0x5A9
	private TrainEngine.TrainMovementState movementState; // 0x5AC
	private Nullable<TrainEngine.TrainMovementState> prevLightVisualsState; // 0x5B0
	private Nullable<bool> prevLightVisualsOnState; // 0x5B8
	private Nullable<bool> prevLightVisualsHeadlightOnState; // 0x5BA
	[HeaderAttribute] // RVA: 0x94950 Offset: 0x93D50 VA: 0x180094950
	[SerializeField] // RVA: 0x94950 Offset: 0x93D50 VA: 0x180094950
	private Transform leftHandLever; // 0x5C0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rightHandLever; // 0x5C8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform leftHandGrip; // 0x5D0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rightHandGrip; // 0x5D8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TrainEngine.LeverStyle leverStyle; // 0x5E0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Canvas monitorCanvas; // 0x5E8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustText monitorText; // 0x5F0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private LocomotiveExtraVisuals gauges; // 0x5F8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float engineForce; // 0x600
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxSpeed; // 0x604
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float engineStartupTime; // 0x608
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef fuelStoragePrefab; // 0x610
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float idleFuelPerSec; // 0x618
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxFuelPerSec; // 0x61C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ProtectionProperties driverProtection; // 0x620
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool lootablesAreOnPlatform; // 0x628
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleLight[] onLights; // 0x630
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleLight[] headlights; // 0x638
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleLight[] notMovingLights; // 0x640
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleLight[] movingForwardLights; // 0x648
	[FormerlySerializedAsAttribute] // RVA: 0x95630 Offset: 0x94A30 VA: 0x180095630
	[SerializeField] // RVA: 0x95630 Offset: 0x94A30 VA: 0x180095630
	private VehicleLight[] movingBackwardLights; // 0x650
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemContainer fxEngineOn; // 0x658
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemContainer fxLightDamage; // 0x660
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemContainer fxMediumDamage; // 0x668
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemContainer fxHeavyDamage; // 0x670
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemContainer fxEngineTrouble; // 0x678
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BoxCollider engineWorldCol; // 0x680
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float engineDamageToSlow; // 0x688
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float engineDamageTimeframe; // 0x68C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float engineSlowedTime; // 0x690
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float engineSlowedMaxVel; // 0x694
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemContainer[] sparks; // 0x698
	[FormerlySerializedAsAttribute] // RVA: 0x96140 Offset: 0x95540 VA: 0x180096140
	[SerializeField] // RVA: 0x96140 Offset: 0x95540 VA: 0x180096140
	private Light[] sparkLights; // 0x6A0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TrainEngineAudio trainAudio; // 0x6A8
	public const BaseEntity.Flags Flag_HazardAhead = 16384;
	private const BaseEntity.Flags Flag_Horn = 65536;
	public const BaseEntity.Flags Flag_AltColor = 131072;
	public const BaseEntity.Flags Flag_EngineSlowed = 262144;
	private VehicleEngineController<TrainEngine> engineController; // 0x6B0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TrainEngine.EngineSpeeds <CurThrottleSetting>k__BackingField; // 0x6B8

	// Properties
	public override bool HasMenuOptions { get; }
	public bool LightsAreOn { get; }
	public bool CloseToHazard { get; }
	public bool EngineIsSlowed { get; }
	public TrainEngine.EngineSpeeds CurThrottleSetting { get; set; }
	public override TrainCar.TrainCarType CarType { get; }

	// Methods

	// RVA: 0xA13B90 Offset: 0xA12190 VA: 0x180A13B90 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA167D0 Offset: 0xA14DD0 VA: 0x180A167D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA14740 Offset: 0xA12D40 VA: 0x180A14740 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA13A10 Offset: 0xA12010 VA: 0x180A13A10 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0xA13860 Offset: 0xA11E60 VA: 0x180A13860 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA139E0 Offset: 0xA11FE0 VA: 0x180A139E0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xA155F0 Offset: 0xA13BF0 VA: 0x180A155F0 Slot: 201
	protected override void TrainClientTick() { }

	// RVA: 0xA15400 Offset: 0xA13A00 VA: 0x180A15400 Slot: 200
	protected override void StopClientTick() { }

	// RVA: 0xA14ED0 Offset: 0xA134D0 VA: 0x180A14ED0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xA164C0 Offset: 0xA14AC0 VA: 0x180A164C0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA145E0 Offset: 0xA12BE0 VA: 0x180A145E0 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0xA13490 Offset: 0xA11A90 VA: 0x180A13490 Slot: 199
	protected override void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA14710 Offset: 0xA12D10 VA: 0x180A14710 Slot: 132
	protected override void OnLifeStateChanged() { }

	// RVA: 0xA14F10 Offset: 0xA13510 VA: 0x180A14F10
	private void RefreshMovementLightVisuals() { }

	// RVA: 0xA16110 Offset: 0xA14710 VA: 0x180A16110
	private void UpdateMonitorVisuals(bool couplingChanged = False) { }

	// RVA: 0xA15150 Offset: 0xA13750 VA: 0x180A15150
	private void ResetMonitorCouplingHighlight() { }

	// RVA: 0xA15930 Offset: 0xA13F30 VA: 0x180A15930
	private void UpdateControlLeverVisuals() { }

	// RVA: 0xA157D0 Offset: 0xA13DD0 VA: 0x180A157D0 Slot: 202
	protected override bool UpdateBraking(float forwardSpeed) { }

	// RVA: 0xA14EC0 Offset: 0xA134C0 VA: 0x180A14EC0
	protected void PlaySparks() { }

	// RVA: 0xA155E0 Offset: 0xA13BE0 VA: 0x180A155E0
	protected void StopSparks() { }

	// RVA: 0xA151C0 Offset: 0xA137C0 VA: 0x180A151C0
	protected void SetSparks(bool play) { }

	// RVA: 0xA15C60 Offset: 0xA14260 VA: 0x180A15C60
	private void UpdateDamageFX() { }

	// RVA: 0xA15FE0 Offset: 0xA145E0 VA: 0x180A15FE0
	private void UpdateEngineFX() { }

	[BaseEntity.Menu] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Description] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Icon] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	// RVA: 0xA145A0 Offset: 0xA12BA0 VA: 0x180A145A0
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0xA144D0 Offset: 0xA12AD0 VA: 0x180A144D0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA15380 Offset: 0xA13980 VA: 0x180A15380
	private void SetThrottle(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA15170 Offset: 0xA13770 VA: 0x180A15170
	private void SetFuelAmount(BaseEntity.RPCMessage msg) { }

	// RVA: 0x738190 Offset: 0x736790 VA: 0x180738190
	public bool get_LightsAreOn() { }

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool get_CloseToHazard() { }

	// RVA: 0xA167C0 Offset: 0xA14DC0 VA: 0x180A167C0
	public bool get_EngineIsSlowed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA167B0 Offset: 0xA14DB0 VA: 0x180A167B0
	public TrainEngine.EngineSpeeds get_CurThrottleSetting() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA16890 Offset: 0xA14E90 VA: 0x180A16890
	protected void set_CurThrottleSetting(TrainEngine.EngineSpeeds value) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 204
	public override TrainCar.TrainCarType get_CarType() { }

	// RVA: 0xA13F20 Offset: 0xA12520 VA: 0x180A13F20 Slot: 28
	public override void InitShared() { }

	// RVA: 0xA142B0 Offset: 0xA128B0 VA: 0x180A142B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA132F0 Offset: 0xA118F0 VA: 0x180A132F0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0xA13AC0 Offset: 0xA120C0 VA: 0x180A13AC0
	private float GetEnginePowerMultiplier(float minPercent) { }

	// RVA: 0xA13EA0 Offset: 0xA124A0 VA: 0x180A13EA0
	public float GetThrottleFraction() { }

	// RVA: 0xA14170 Offset: 0xA12770 VA: 0x180A14170
	public bool IsNearDesiredSpeed(float leeway) { }

	// RVA: 0xA153C0 Offset: 0xA139C0 VA: 0x180A153C0 Slot: 205
	protected override void SetTrackSelection(TrainTrackSpline.TrackSelection trackSelection) { }

	// RVA: 0xA152F0 Offset: 0xA138F0 VA: 0x180A152F0
	private void SetThrottle(TrainEngine.EngineSpeeds throttle) { }

	// RVA: 0xA13B80 Offset: 0xA12180 VA: 0x180A13B80
	private int GetFuelAmount() { }

	// RVA: 0xA13410 Offset: 0xA11A10 VA: 0x180A13410
	private bool CanMount(BasePlayer player) { }

	// RVA: 0xA13410 Offset: 0xA11A10 VA: 0x180A13410
	private bool PlayerIsOnPlatform(BasePlayer player) { }

	// RVA: 0xA16670 Offset: 0xA14C70 VA: 0x180A16670
	public void .ctor() { }

}

private enum TrainEngine.TrainMovementState // TypeDefIndex: 8473
{	// Fields
	public int value__; // 0x0
	public const TrainEngine.TrainMovementState Stationary = 0;
	public const TrainEngine.TrainMovementState MovingForwards = 1;
	public const TrainEngine.TrainMovementState MovingBackwards = 2;

}

private enum TrainEngine.LeverStyle // TypeDefIndex: 8474
{	// Fields
	public int value__; // 0x0
	public const TrainEngine.LeverStyle WorkCart = 0;
	public const TrainEngine.LeverStyle Locomotive = 1;

}

public enum TrainEngine.EngineSpeeds // TypeDefIndex: 8475
{	// Fields
	public int value__; // 0x0
	public const TrainEngine.EngineSpeeds Rev_Hi = 0;
	public const TrainEngine.EngineSpeeds Rev_Med = 1;
	public const TrainEngine.EngineSpeeds Rev_Lo = 2;
	public const TrainEngine.EngineSpeeds Zero = 3;
	public const TrainEngine.EngineSpeeds Fwd_Lo = 4;
	public const TrainEngine.EngineSpeeds Fwd_Med = 5;
	public const TrainEngine.EngineSpeeds Fwd_Hi = 6;

}

