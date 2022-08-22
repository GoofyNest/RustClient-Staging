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

	// RVA: 0x1EF1FF0 Offset: 0x1EF05F0 VA: 0x181EF1FF0
	public static void ResetToPool(TrainEngine instance) { }

	// RVA: 0x1EF20A0 Offset: 0x1EF06A0 VA: 0x181EF20A0
	public void ResetToPool() { }

	// RVA: 0x1EF1C50 Offset: 0x1EF0250 VA: 0x181EF1C50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E21C60 Offset: 0x1E20260 VA: 0x181E21C60
	public void CopyTo(TrainEngine instance) { }

	// RVA: 0x1EF0940 Offset: 0x1EEEF40 VA: 0x181EF0940
	public TrainEngine Copy() { }

	// RVA: 0x1EF10F0 Offset: 0x1EEF6F0 VA: 0x181EF10F0
	public static TrainEngine Deserialize(Stream stream) { }

	// RVA: 0x1EF09C0 Offset: 0x1EEEFC0 VA: 0x181EF09C0
	public static TrainEngine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF0D60 Offset: 0x1EEF360 VA: 0x181EF0D60
	public static TrainEngine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF16B0 Offset: 0x1EEFCB0 VA: 0x181EF16B0
	public static TrainEngine Deserialize(byte[] buffer) { }

	// RVA: 0x1EF1D80 Offset: 0x1EF0380 VA: 0x181EF1D80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF2700 Offset: 0x1EF0D00 VA: 0x181EF2700 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF2720 Offset: 0x1EF0D20 VA: 0x181EF2720 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TrainEngine previous) { }

	// RVA: 0x1EF1FD0 Offset: 0x1EF05D0 VA: 0x181EF1FD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF1380 Offset: 0x1EEF980 VA: 0x181EF1380
	public static TrainEngine Deserialize(byte[] buffer, TrainEngine instance, bool isDelta = False) { }

	// RVA: 0x1EF1A00 Offset: 0x1EF0000 VA: 0x181EF1A00
	public static TrainEngine Deserialize(Stream stream, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EF0A40 Offset: 0x1EEF040 VA: 0x181EF0A40
	public static TrainEngine DeserializeLengthDelimited(Stream stream, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EF0DF0 Offset: 0x1EEF3F0 VA: 0x181EF0DF0
	public static TrainEngine DeserializeLength(Stream stream, int length, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EF2150 Offset: 0x1EF0750 VA: 0x181EF2150
	public static void SerializeDelta(Stream stream, TrainEngine instance, TrainEngine previous) { }

	// RVA: 0x1EF2580 Offset: 0x1EF0B80 VA: 0x181EF2580
	public static void Serialize(Stream stream, TrainEngine instance) { }

	// RVA: 0x1EF26F0 Offset: 0x1EF0CF0 VA: 0x181EF26F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF2700 Offset: 0x1EF0D00 VA: 0x181EF2700
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF2470 Offset: 0x1EF0A70 VA: 0x181EF2470
	public static byte[] SerializeToBytes(TrainEngine instance) { }

	// RVA: 0x1EF23C0 Offset: 0x1EF09C0 VA: 0x181EF23C0
	public static void SerializeLengthDelimited(Stream stream, TrainEngine instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0xA13E50 Offset: 0xA12450 VA: 0x180A13E50 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA16A90 Offset: 0xA15090 VA: 0x180A16A90 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA14A00 Offset: 0xA13000 VA: 0x180A14A00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA13CD0 Offset: 0xA122D0 VA: 0x180A13CD0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0xA13B20 Offset: 0xA12120 VA: 0x180A13B20 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA13CA0 Offset: 0xA122A0 VA: 0x180A13CA0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xA158B0 Offset: 0xA13EB0 VA: 0x180A158B0 Slot: 201
	protected override void TrainClientTick() { }

	// RVA: 0xA156C0 Offset: 0xA13CC0 VA: 0x180A156C0 Slot: 200
	protected override void StopClientTick() { }

	// RVA: 0xA15190 Offset: 0xA13790 VA: 0x180A15190 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xA16780 Offset: 0xA14D80 VA: 0x180A16780 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA148A0 Offset: 0xA12EA0 VA: 0x180A148A0 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0xA13750 Offset: 0xA11D50 VA: 0x180A13750 Slot: 199
	protected override void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA149D0 Offset: 0xA12FD0 VA: 0x180A149D0 Slot: 132
	protected override void OnLifeStateChanged() { }

	// RVA: 0xA151D0 Offset: 0xA137D0 VA: 0x180A151D0
	private void RefreshMovementLightVisuals() { }

	// RVA: 0xA163D0 Offset: 0xA149D0 VA: 0x180A163D0
	private void UpdateMonitorVisuals(bool couplingChanged = False) { }

	// RVA: 0xA15410 Offset: 0xA13A10 VA: 0x180A15410
	private void ResetMonitorCouplingHighlight() { }

	// RVA: 0xA15BF0 Offset: 0xA141F0 VA: 0x180A15BF0
	private void UpdateControlLeverVisuals() { }

	// RVA: 0xA15A90 Offset: 0xA14090 VA: 0x180A15A90 Slot: 202
	protected override bool UpdateBraking(float forwardSpeed) { }

	// RVA: 0xA15180 Offset: 0xA13780 VA: 0x180A15180
	protected void PlaySparks() { }

	// RVA: 0xA158A0 Offset: 0xA13EA0 VA: 0x180A158A0
	protected void StopSparks() { }

	// RVA: 0xA15480 Offset: 0xA13A80 VA: 0x180A15480
	protected void SetSparks(bool play) { }

	// RVA: 0xA15F20 Offset: 0xA14520 VA: 0x180A15F20
	private void UpdateDamageFX() { }

	// RVA: 0xA162A0 Offset: 0xA148A0 VA: 0x180A162A0
	private void UpdateEngineFX() { }

	[BaseEntity.Menu] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Description] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Icon] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	// RVA: 0xA14860 Offset: 0xA12E60 VA: 0x180A14860
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0xA14790 Offset: 0xA12D90 VA: 0x180A14790
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA15640 Offset: 0xA13C40 VA: 0x180A15640
	private void SetThrottle(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA15430 Offset: 0xA13A30 VA: 0x180A15430
	private void SetFuelAmount(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7382A0 Offset: 0x7368A0 VA: 0x1807382A0
	public bool get_LightsAreOn() { }

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool get_CloseToHazard() { }

	// RVA: 0xA16A80 Offset: 0xA15080 VA: 0x180A16A80
	public bool get_EngineIsSlowed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA16A70 Offset: 0xA15070 VA: 0x180A16A70
	public TrainEngine.EngineSpeeds get_CurThrottleSetting() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA16B50 Offset: 0xA15150 VA: 0x180A16B50
	protected void set_CurThrottleSetting(TrainEngine.EngineSpeeds value) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 204
	public override TrainCar.TrainCarType get_CarType() { }

	// RVA: 0xA141E0 Offset: 0xA127E0 VA: 0x180A141E0 Slot: 28
	public override void InitShared() { }

	// RVA: 0xA14570 Offset: 0xA12B70 VA: 0x180A14570 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA135B0 Offset: 0xA11BB0 VA: 0x180A135B0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0xA13D80 Offset: 0xA12380 VA: 0x180A13D80
	private float GetEnginePowerMultiplier(float minPercent) { }

	// RVA: 0xA14160 Offset: 0xA12760 VA: 0x180A14160
	public float GetThrottleFraction() { }

	// RVA: 0xA14430 Offset: 0xA12A30 VA: 0x180A14430
	public bool IsNearDesiredSpeed(float leeway) { }

	// RVA: 0xA15680 Offset: 0xA13C80 VA: 0x180A15680 Slot: 205
	protected override void SetTrackSelection(TrainTrackSpline.TrackSelection trackSelection) { }

	// RVA: 0xA155B0 Offset: 0xA13BB0 VA: 0x180A155B0
	private void SetThrottle(TrainEngine.EngineSpeeds throttle) { }

	// RVA: 0xA13E40 Offset: 0xA12440 VA: 0x180A13E40
	private int GetFuelAmount() { }

	// RVA: 0xA136D0 Offset: 0xA11CD0 VA: 0x180A136D0
	private bool CanMount(BasePlayer player) { }

	// RVA: 0xA136D0 Offset: 0xA11CD0 VA: 0x180A136D0
	private bool PlayerIsOnPlatform(BasePlayer player) { }

	// RVA: 0xA16930 Offset: 0xA14F30 VA: 0x180A16930
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

