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

	// RVA: 0x1EF2810 Offset: 0x1EF0E10 VA: 0x181EF2810
	public static void ResetToPool(TrainEngine instance) { }

	// RVA: 0x1EF28C0 Offset: 0x1EF0EC0 VA: 0x181EF28C0
	public void ResetToPool() { }

	// RVA: 0x1EF2470 Offset: 0x1EF0A70 VA: 0x181EF2470 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E22480 Offset: 0x1E20A80 VA: 0x181E22480
	public void CopyTo(TrainEngine instance) { }

	// RVA: 0x1EF1160 Offset: 0x1EEF760 VA: 0x181EF1160
	public TrainEngine Copy() { }

	// RVA: 0x1EF1910 Offset: 0x1EEFF10 VA: 0x181EF1910
	public static TrainEngine Deserialize(Stream stream) { }

	// RVA: 0x1EF11E0 Offset: 0x1EEF7E0 VA: 0x181EF11E0
	public static TrainEngine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF1580 Offset: 0x1EEFB80 VA: 0x181EF1580
	public static TrainEngine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF1ED0 Offset: 0x1EF04D0 VA: 0x181EF1ED0
	public static TrainEngine Deserialize(byte[] buffer) { }

	// RVA: 0x1EF25A0 Offset: 0x1EF0BA0 VA: 0x181EF25A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF2F20 Offset: 0x1EF1520 VA: 0x181EF2F20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF2F40 Offset: 0x1EF1540 VA: 0x181EF2F40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TrainEngine previous) { }

	// RVA: 0x1EF27F0 Offset: 0x1EF0DF0 VA: 0x181EF27F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF1BA0 Offset: 0x1EF01A0 VA: 0x181EF1BA0
	public static TrainEngine Deserialize(byte[] buffer, TrainEngine instance, bool isDelta = False) { }

	// RVA: 0x1EF2220 Offset: 0x1EF0820 VA: 0x181EF2220
	public static TrainEngine Deserialize(Stream stream, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EF1260 Offset: 0x1EEF860 VA: 0x181EF1260
	public static TrainEngine DeserializeLengthDelimited(Stream stream, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EF1610 Offset: 0x1EEFC10 VA: 0x181EF1610
	public static TrainEngine DeserializeLength(Stream stream, int length, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EF2970 Offset: 0x1EF0F70 VA: 0x181EF2970
	public static void SerializeDelta(Stream stream, TrainEngine instance, TrainEngine previous) { }

	// RVA: 0x1EF2DA0 Offset: 0x1EF13A0 VA: 0x181EF2DA0
	public static void Serialize(Stream stream, TrainEngine instance) { }

	// RVA: 0x1EF2F10 Offset: 0x1EF1510 VA: 0x181EF2F10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF2F20 Offset: 0x1EF1520 VA: 0x181EF2F20
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF2C90 Offset: 0x1EF1290 VA: 0x181EF2C90
	public static byte[] SerializeToBytes(TrainEngine instance) { }

	// RVA: 0x1EF2BE0 Offset: 0x1EF11E0 VA: 0x181EF2BE0
	public static void SerializeLengthDelimited(Stream stream, TrainEngine instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0xA14340 Offset: 0xA12940 VA: 0x180A14340 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA16F80 Offset: 0xA15580 VA: 0x180A16F80 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA14EF0 Offset: 0xA134F0 VA: 0x180A14EF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA141C0 Offset: 0xA127C0 VA: 0x180A141C0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0xA14010 Offset: 0xA12610 VA: 0x180A14010 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA14190 Offset: 0xA12790 VA: 0x180A14190 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xA15DA0 Offset: 0xA143A0 VA: 0x180A15DA0 Slot: 201
	protected override void TrainClientTick() { }

	// RVA: 0xA15BB0 Offset: 0xA141B0 VA: 0x180A15BB0 Slot: 200
	protected override void StopClientTick() { }

	// RVA: 0xA15680 Offset: 0xA13C80 VA: 0x180A15680 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xA16C70 Offset: 0xA15270 VA: 0x180A16C70 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA14D90 Offset: 0xA13390 VA: 0x180A14D90 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0xA13C40 Offset: 0xA12240 VA: 0x180A13C40 Slot: 199
	protected override void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA14EC0 Offset: 0xA134C0 VA: 0x180A14EC0 Slot: 132
	protected override void OnLifeStateChanged() { }

	// RVA: 0xA156C0 Offset: 0xA13CC0 VA: 0x180A156C0
	private void RefreshMovementLightVisuals() { }

	// RVA: 0xA168C0 Offset: 0xA14EC0 VA: 0x180A168C0
	private void UpdateMonitorVisuals(bool couplingChanged = False) { }

	// RVA: 0xA15900 Offset: 0xA13F00 VA: 0x180A15900
	private void ResetMonitorCouplingHighlight() { }

	// RVA: 0xA160E0 Offset: 0xA146E0 VA: 0x180A160E0
	private void UpdateControlLeverVisuals() { }

	// RVA: 0xA15F80 Offset: 0xA14580 VA: 0x180A15F80 Slot: 202
	protected override bool UpdateBraking(float forwardSpeed) { }

	// RVA: 0xA15670 Offset: 0xA13C70 VA: 0x180A15670
	protected void PlaySparks() { }

	// RVA: 0xA15D90 Offset: 0xA14390 VA: 0x180A15D90
	protected void StopSparks() { }

	// RVA: 0xA15970 Offset: 0xA13F70 VA: 0x180A15970
	protected void SetSparks(bool play) { }

	// RVA: 0xA16410 Offset: 0xA14A10 VA: 0x180A16410
	private void UpdateDamageFX() { }

	// RVA: 0xA16790 Offset: 0xA14D90 VA: 0x180A16790
	private void UpdateEngineFX() { }

	[BaseEntity.Menu] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Description] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Icon] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	// RVA: 0xA14D50 Offset: 0xA13350 VA: 0x180A14D50
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0xA14C80 Offset: 0xA13280 VA: 0x180A14C80
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA15B30 Offset: 0xA14130 VA: 0x180A15B30
	private void SetThrottle(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA15920 Offset: 0xA13F20 VA: 0x180A15920
	private void SetFuelAmount(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7381F0 Offset: 0x7367F0 VA: 0x1807381F0
	public bool get_LightsAreOn() { }

	// RVA: 0x557EE0 Offset: 0x5564E0 VA: 0x180557EE0
	public bool get_CloseToHazard() { }

	// RVA: 0xA16F70 Offset: 0xA15570 VA: 0x180A16F70
	public bool get_EngineIsSlowed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA16F60 Offset: 0xA15560 VA: 0x180A16F60
	public TrainEngine.EngineSpeeds get_CurThrottleSetting() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA17040 Offset: 0xA15640 VA: 0x180A17040
	protected void set_CurThrottleSetting(TrainEngine.EngineSpeeds value) { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 204
	public override TrainCar.TrainCarType get_CarType() { }

	// RVA: 0xA146D0 Offset: 0xA12CD0 VA: 0x180A146D0 Slot: 28
	public override void InitShared() { }

	// RVA: 0xA14A60 Offset: 0xA13060 VA: 0x180A14A60 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA13AA0 Offset: 0xA120A0 VA: 0x180A13AA0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0xA14270 Offset: 0xA12870 VA: 0x180A14270
	private float GetEnginePowerMultiplier(float minPercent) { }

	// RVA: 0xA14650 Offset: 0xA12C50 VA: 0x180A14650
	public float GetThrottleFraction() { }

	// RVA: 0xA14920 Offset: 0xA12F20 VA: 0x180A14920
	public bool IsNearDesiredSpeed(float leeway) { }

	// RVA: 0xA15B70 Offset: 0xA14170 VA: 0x180A15B70 Slot: 205
	protected override void SetTrackSelection(TrainTrackSpline.TrackSelection trackSelection) { }

	// RVA: 0xA15AA0 Offset: 0xA140A0 VA: 0x180A15AA0
	private void SetThrottle(TrainEngine.EngineSpeeds throttle) { }

	// RVA: 0xA14330 Offset: 0xA12930 VA: 0x180A14330
	private int GetFuelAmount() { }

	// RVA: 0xA13BC0 Offset: 0xA121C0 VA: 0x180A13BC0
	private bool CanMount(BasePlayer player) { }

	// RVA: 0xA13BC0 Offset: 0xA121C0 VA: 0x180A13BC0
	private bool PlayerIsOnPlatform(BasePlayer player) { }

	// RVA: 0xA16E20 Offset: 0xA15420 VA: 0x180A16E20
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

