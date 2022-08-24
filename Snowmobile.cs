public class Snowmobile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6423
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float steerInput; // 0x14
	public float driveWheelVel; // 0x18
	public float throttleInput; // 0x1C
	public float brakeInput; // 0x20
	public uint storageID; // 0x24
	public uint fuelStorageID; // 0x28
	public float fuelFraction; // 0x2C


	public static void ResetToPool(Snowmobile instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Snowmobile instance) { }

	public Snowmobile Copy() { }

	public static Snowmobile Deserialize(Stream stream) { }

	public static Snowmobile DeserializeLengthDelimited(Stream stream) { }

	public static Snowmobile DeserializeLength(Stream stream, int length) { }

	public static Snowmobile Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Snowmobile previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Snowmobile Deserialize(byte[] buffer, Snowmobile instance, bool isDelta = False) { }

	public static Snowmobile Deserialize(Stream stream, Snowmobile instance, bool isDelta) { }

	public static Snowmobile DeserializeLengthDelimited(Stream stream, Snowmobile instance, bool isDelta) { }

	public static Snowmobile DeserializeLength(Stream stream, int length, Snowmobile instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Snowmobile instance, Snowmobile previous) { }

	public static void Serialize(Stream stream, Snowmobile instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Snowmobile instance) { }

	public static void SerializeLengthDelimited(Stream stream, Snowmobile instance) { }

	public void .ctor() { }

}

public class Snowmobile : GroundVehicle, VehicleChassisVisuals.IClientWheelUser<Snowmobile>, IPrefabPreProcess // TypeDefIndex: 8451
{	private Option __menuOption_Menu_FuelStorage; // 0x408
	private Option __menuOption_Menu_ItemStorage; // 0x460
	private Option __menuOption_Menu_Push; // 0x4B8
	public TimeSince timeSinceLastUpdate; // 0x510
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadFLData; // 0x518
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadFRData; // 0x520
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadRLData; // 0x528
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadRRData; // 0x530
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> skiLData; // 0x538
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> skiRData; // 0x540
	private float clientSteerInput; // 0x548
	private float clientDriveWheelVelocity; // 0x54C
	private float clientDriveWheelSlip; // 0x550
	private bool wasBraking; // 0x554
	private Vector3 leanVector; // 0x558
	private Vector3[] recentVels; // 0x568
	private int recentVelsIndex; // 0x570
	private TimeSince timeSinceFailedStartAttempt; // 0x574
	private const float FAILED_START_MIN_TIME = 1;
	[HeaderAttribute] // RVA: 0x88BE0 Offset: 0x87FE0 VA: 0x180088BE0
	[SerializeField] // RVA: 0x88BE0 Offset: 0x87FE0 VA: 0x180088BE0
	private Transform centreOfMassTransform; // 0x578
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObjectRef itemStoragePrefab; // 0x580
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private VisualCarWheel wheelSkiFL; // 0x588
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private VisualCarWheel wheelSkiFR; // 0x590
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private VisualCarWheel wheelTreadFL; // 0x598
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private VisualCarWheel wheelTreadFR; // 0x5A0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private VisualCarWheel wheelTreadRL; // 0x5A8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private VisualCarWheel wheelTreadRR; // 0x5B0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private CarSettings carSettings; // 0x5B8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int engineKW; // 0x5C0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float idleFuelPerSec; // 0x5C4
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float maxFuelPerSec; // 0x5C8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float airControlStability; // 0x5CC
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float airControlPower; // 0x5D0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float badTerrainDrag; // 0x5D4
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ProtectionProperties riderProtection; // 0x5D8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float hurtTriggerMinSpeed; // 0x5E0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TriggerHurtNotChild hurtTriggerFront; // 0x5E8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TriggerHurtNotChild hurtTriggerRear; // 0x5F0
	[HeaderAttribute] // RVA: 0x8AE00 Offset: 0x8A200 VA: 0x18008AE00
	public float minGroundFXSpeed; // 0x5F8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SnowmobileChassisVisuals chassisVisuals; // 0x600
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private VehicleLight[] lights; // 0x608
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform steeringLeftIK; // 0x610
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform steeringRightIK; // 0x618
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform leftFootIK; // 0x620
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform rightFootIK; // 0x628
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform starterKey; // 0x630
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Vector3 engineOffKeyRot; // 0x638
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Vector3 engineOnKeyRot; // 0x644
	[ServerVar] // RVA: 0x8B360 Offset: 0x8A760 VA: 0x18008B360
	public static float outsideDecayMinutes; // 0x0
	[ServerVar] // RVA: 0x8B480 Offset: 0x8A880 VA: 0x18008B480
	public static bool allowPassengerOnly; // 0x4
	[ServerVar] // RVA: 0x8B580 Offset: 0x8A980 VA: 0x18008B580
	public static bool allTerrain; // 0x5
	private float _throttle; // 0x650
	private float _brake; // 0x654
	private float _steer; // 0x658
	private float _mass; // 0x65C
	public const BaseEntity.Flags Flag_Slowmode = 65536;
	private EntityRef<StorageContainer> itemStorageInstance; // 0x660
	private float cachedFuelFraction; // 0x670
	private const float FORCE_MULTIPLIER = 10;

	public override bool HasMenuOptions { get; }
	public float ThrottleInput { get; set; }
	public float BrakeInput { get; set; }
	public bool IsBraking { get; }
	public float SteerInput { get; set; }
	public float SteerAngle { get; }
	public override float DriveWheelVelocity { get; }
	public float DriveWheelSlip { get; }
	public float MaxSteerAngle { get; }
	public bool InSlowMode { get; }
	private float Mass { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	protected override void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public bool IsATreadWheel(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	public bool IsASkiWheel(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	protected override void GroundVehicleClientTick() { }

	protected override void OnClientTickStopped() { }

	[BaseEntity.Menu] // RVA: 0x73EF0 Offset: 0x732F0 VA: 0x180073EF0
	[BaseEntity.Menu.Description] // RVA: 0x73EF0 Offset: 0x732F0 VA: 0x180073EF0
	[BaseEntity.Menu.Icon] // RVA: 0x73EF0 Offset: 0x732F0 VA: 0x180073EF0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EF0 Offset: 0x732F0 VA: 0x180073EF0
	public void Menu_FuelStorage(BasePlayer player) { }

	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CA00 Offset: 0x8BE00 VA: 0x18008CA00
	[BaseEntity.Menu.Description] // RVA: 0x8CA00 Offset: 0x8BE00 VA: 0x18008CA00
	[BaseEntity.Menu.Icon] // RVA: 0x8CA00 Offset: 0x8BE00 VA: 0x18008CA00
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CA00 Offset: 0x8BE00 VA: 0x18008CA00
	public void Menu_ItemStorage(BasePlayer player) { }

	public bool Menu_ItemStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CB60 Offset: 0x8BF60 VA: 0x18008CB60
	[BaseEntity.Menu.Description] // RVA: 0x8CB60 Offset: 0x8BF60 VA: 0x18008CB60
	[BaseEntity.Menu.Icon] // RVA: 0x8CB60 Offset: 0x8BF60 VA: 0x18008CB60
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CB60 Offset: 0x8BF60 VA: 0x18008CB60
	public void Menu_Push(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SnowmobileUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	public float get_ThrottleInput() { }

	protected void set_ThrottleInput(float value) { }

	public float get_BrakeInput() { }

	protected void set_BrakeInput(float value) { }

	public bool get_IsBraking() { }

	public float get_SteerInput() { }

	protected void set_SteerInput(float value) { }

	public float get_SteerAngle() { }

	public override float get_DriveWheelVelocity() { }

	public float get_DriveWheelSlip() { }

	public float get_MaxSteerAngle() { }

	public bool get_InSlowMode() { }

	private float get_Mass() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public float GetMaxDriveForce() { }

	public override float GetMaxForwardSpeed() { }

	public override float GetThrottleInput() { }

	public override float GetBrakeInput() { }

	public float GetSteerInput() { }

	public bool GetSteerModInput() { }

	public float GetPerformanceFraction() { }

	public float GetFuelFraction() { }

	public override bool CanBeLooted(BasePlayer player) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

	private static void .cctor() { }

}

