public class Snowmobile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6423
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float steerInput; // 0x14
	public float driveWheelVel; // 0x18
	public float throttleInput; // 0x1C
	public float brakeInput; // 0x20
	public uint storageID; // 0x24
	public uint fuelStorageID; // 0x28
	public float fuelFraction; // 0x2C

	// Methods

	// RVA: 0x1DB5620 Offset: 0x1DB3C20 VA: 0x181DB5620
	public static void ResetToPool(Snowmobile instance) { }

	// RVA: 0x1DB5550 Offset: 0x1DB3B50 VA: 0x181DB5550
	public void ResetToPool() { }

	// RVA: 0x1DB4D90 Offset: 0x1DB3390 VA: 0x181DB4D90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB3340 Offset: 0x1DB1940 VA: 0x181DB3340
	public void CopyTo(Snowmobile instance) { }

	// RVA: 0x1DB3380 Offset: 0x1DB1980 VA: 0x181DB3380
	public Snowmobile Copy() { }

	// RVA: 0x1DB4A70 Offset: 0x1DB3070 VA: 0x181DB4A70
	public static Snowmobile Deserialize(Stream stream) { }

	// RVA: 0x1DB3410 Offset: 0x1DB1A10 VA: 0x181DB3410
	public static Snowmobile DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB3850 Offset: 0x1DB1E50 VA: 0x181DB3850
	public static Snowmobile DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB4680 Offset: 0x1DB2C80 VA: 0x181DB4680
	public static Snowmobile Deserialize(byte[] buffer) { }

	// RVA: 0x1DB4EE0 Offset: 0x1DB34E0 VA: 0x181DB4EE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB5DC0 Offset: 0x1DB43C0 VA: 0x181DB5DC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB5DE0 Offset: 0x1DB43E0 VA: 0x181DB5DE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Snowmobile previous) { }

	// RVA: 0x1DB51C0 Offset: 0x1DB37C0 VA: 0x181DB51C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB42B0 Offset: 0x1DB28B0 VA: 0x181DB42B0
	public static Snowmobile Deserialize(byte[] buffer, Snowmobile instance, bool isDelta = False) { }

	// RVA: 0x1DB3FD0 Offset: 0x1DB25D0 VA: 0x181DB3FD0
	public static Snowmobile Deserialize(Stream stream, Snowmobile instance, bool isDelta) { }

	// RVA: 0x1DB3490 Offset: 0x1DB1A90 VA: 0x181DB3490
	public static Snowmobile DeserializeLengthDelimited(Stream stream, Snowmobile instance, bool isDelta) { }

	// RVA: 0x1DB3C30 Offset: 0x1DB2230 VA: 0x181DB3C30
	public static Snowmobile DeserializeLength(Stream stream, int length, Snowmobile instance, bool isDelta) { }

	// RVA: 0x1DB56F0 Offset: 0x1DB3CF0 VA: 0x181DB56F0
	public static void SerializeDelta(Stream stream, Snowmobile instance, Snowmobile previous) { }

	// RVA: 0x1DB5BF0 Offset: 0x1DB41F0 VA: 0x181DB5BF0
	public static void Serialize(Stream stream, Snowmobile instance) { }

	// RVA: 0x1DB5DB0 Offset: 0x1DB43B0 VA: 0x181DB5DB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB5DC0 Offset: 0x1DB43C0 VA: 0x181DB5DC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB5AE0 Offset: 0x1DB40E0 VA: 0x181DB5AE0
	public static byte[] SerializeToBytes(Snowmobile instance) { }

	// RVA: 0x1DB5A30 Offset: 0x1DB4030 VA: 0x181DB5A30
	public static void SerializeLengthDelimited(Stream stream, Snowmobile instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class Snowmobile : GroundVehicle, VehicleChassisVisuals.IClientWheelUser<Snowmobile>, IPrefabPreProcess // TypeDefIndex: 8451
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x408
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
	[HeaderAttribute] // RVA: 0x88A90 Offset: 0x87E90 VA: 0x180088A90
	[SerializeField] // RVA: 0x88A90 Offset: 0x87E90 VA: 0x180088A90
	private Transform centreOfMassTransform; // 0x578
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef itemStoragePrefab; // 0x580
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VisualCarWheel wheelSkiFL; // 0x588
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VisualCarWheel wheelSkiFR; // 0x590
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VisualCarWheel wheelTreadFL; // 0x598
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VisualCarWheel wheelTreadFR; // 0x5A0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VisualCarWheel wheelTreadRL; // 0x5A8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VisualCarWheel wheelTreadRR; // 0x5B0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CarSettings carSettings; // 0x5B8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int engineKW; // 0x5C0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float idleFuelPerSec; // 0x5C4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxFuelPerSec; // 0x5C8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float airControlStability; // 0x5CC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float airControlPower; // 0x5D0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float badTerrainDrag; // 0x5D4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ProtectionProperties riderProtection; // 0x5D8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float hurtTriggerMinSpeed; // 0x5E0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TriggerHurtNotChild hurtTriggerFront; // 0x5E8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TriggerHurtNotChild hurtTriggerRear; // 0x5F0
	[HeaderAttribute] // RVA: 0x8AD10 Offset: 0x8A110 VA: 0x18008AD10
	public float minGroundFXSpeed; // 0x5F8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SnowmobileChassisVisuals chassisVisuals; // 0x600
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VehicleLight[] lights; // 0x608
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform steeringLeftIK; // 0x610
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform steeringRightIK; // 0x618
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform leftFootIK; // 0x620
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rightFootIK; // 0x628
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform starterKey; // 0x630
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 engineOffKeyRot; // 0x638
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 engineOnKeyRot; // 0x644
	[ServerVar] // RVA: 0x8B210 Offset: 0x8A610 VA: 0x18008B210
	public static float outsideDecayMinutes; // 0x0
	[ServerVar] // RVA: 0x8B330 Offset: 0x8A730 VA: 0x18008B330
	public static bool allowPassengerOnly; // 0x4
	[ServerVar] // RVA: 0x8B430 Offset: 0x8A830 VA: 0x18008B430
	public static bool allTerrain; // 0x5
	private float _throttle; // 0x650
	private float _brake; // 0x654
	private float _steer; // 0x658
	private float _mass; // 0x65C
	public const BaseEntity.Flags Flag_Slowmode = 65536;
	private EntityRef<StorageContainer> itemStorageInstance; // 0x660
	private float cachedFuelFraction; // 0x670
	private const float FORCE_MULTIPLIER = 10;

	// Properties
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

	// Methods

	// RVA: 0x5B4950 Offset: 0x5B2F50 VA: 0x1805B4950 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5B6E50 Offset: 0x5B5450 VA: 0x1805B6E50 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5B5980 Offset: 0x5B3F80 VA: 0x1805B5980 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5B4070 Offset: 0x5B2670 VA: 0x1805B4070 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5B3F00 Offset: 0x5B2500 VA: 0x1805B3F00 Slot: 200
	protected override void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5B62E0 Offset: 0x5B48E0 VA: 0x1805B62E0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x5B53F0 Offset: 0x5B39F0 VA: 0x1805B53F0
	public bool IsATreadWheel(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	// RVA: 0x5B53D0 Offset: 0x5B39D0 VA: 0x1805B53D0
	public bool IsASkiWheel(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	// RVA: 0x5B4660 Offset: 0x5B2C60 VA: 0x1805B4660 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x5B5210 Offset: 0x5B3810 VA: 0x1805B5210 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0x5B58C0 Offset: 0x5B3EC0 VA: 0x1805B58C0 Slot: 201
	protected override void OnClientTickStopped() { }

	[BaseEntity.Menu] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Description] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Icon] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	// RVA: 0x5B5730 Offset: 0x5B3D30 VA: 0x1805B5730
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x5B5550 Offset: 0x5B3B50 VA: 0x1805B5550
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8C900 Offset: 0x8BD00 VA: 0x18008C900
	[BaseEntity.Menu.Description] // RVA: 0x8C900 Offset: 0x8BD00 VA: 0x18008C900
	[BaseEntity.Menu.Icon] // RVA: 0x8C900 Offset: 0x8BD00 VA: 0x18008C900
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C900 Offset: 0x8BD00 VA: 0x18008C900
	// RVA: 0x5B5840 Offset: 0x5B3E40 VA: 0x1805B5840
	public void Menu_ItemStorage(BasePlayer player) { }

	// RVA: 0x5B5770 Offset: 0x5B3D70 VA: 0x1805B5770
	public bool Menu_ItemStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Description] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Icon] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	// RVA: 0x5B5880 Offset: 0x5B3E80 VA: 0x1805B5880
	public void Menu_Push(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5B61C0 Offset: 0x5B47C0 VA: 0x1805B61C0
	private void SnowmobileUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5B46B0 Offset: 0x5B2CB0 VA: 0x1805B46B0
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5B51B0 Offset: 0x5B37B0 VA: 0x1805B51B0
	public float get_ThrottleInput() { }

	// RVA: 0x5B7250 Offset: 0x5B5850 VA: 0x1805B7250
	protected void set_ThrottleInput(float value) { }

	// RVA: 0x5B4710 Offset: 0x5B2D10 VA: 0x1805B4710
	public float get_BrakeInput() { }

	// RVA: 0x5B7150 Offset: 0x5B5750 VA: 0x1805B7150
	protected void set_BrakeInput(float value) { }

	// RVA: 0x5B7030 Offset: 0x5B5630 VA: 0x1805B7030
	public bool get_IsBraking() { }

	// RVA: 0x5B51A0 Offset: 0x5B37A0 VA: 0x1805B51A0
	public float get_SteerInput() { }

	// RVA: 0x5B71D0 Offset: 0x5B57D0 VA: 0x1805B71D0
	protected void set_SteerInput(float value) { }

	// RVA: 0x5B7120 Offset: 0x5B5720 VA: 0x1805B7120 Slot: 205
	public float get_SteerAngle() { }

	// RVA: 0x5B6D50 Offset: 0x5B5350 VA: 0x1805B6D50 Slot: 196
	public override float get_DriveWheelVelocity() { }

	// RVA: 0x5B6D40 Offset: 0x5B5340 VA: 0x1805B6D40
	public float get_DriveWheelSlip() { }

	// RVA: 0x5B7100 Offset: 0x5B5700 VA: 0x1805B7100 Slot: 206
	public float get_MaxSteerAngle() { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60
	public bool get_InSlowMode() { }

	// RVA: 0x5B7050 Offset: 0x5B5650 VA: 0x1805B7050
	private float get_Mass() { }

	// RVA: 0x5B5410 Offset: 0x5B3A10 VA: 0x1805B5410 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5B4730 Offset: 0x5B2D30 VA: 0x1805B4730
	public float GetMaxDriveForce() { }

	// RVA: 0x5B47F0 Offset: 0x5B2DF0 VA: 0x1805B47F0 Slot: 197
	public override float GetMaxForwardSpeed() { }

	// RVA: 0x5B51B0 Offset: 0x5B37B0 VA: 0x1805B51B0 Slot: 198
	public override float GetThrottleInput() { }

	// RVA: 0x5B4710 Offset: 0x5B2D10 VA: 0x1805B4710 Slot: 199
	public override float GetBrakeInput() { }

	// RVA: 0x5B51A0 Offset: 0x5B37A0 VA: 0x1805B51A0
	public float GetSteerInput() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool GetSteerModInput() { }

	// RVA: 0x5B5100 Offset: 0x5B3700 VA: 0x1805B5100
	public float GetPerformanceFraction() { }

	// RVA: 0x5B4720 Offset: 0x5B2D20 VA: 0x1805B4720
	public float GetFuelFraction() { }

	// RVA: 0x559570 Offset: 0x557B70 VA: 0x180559570 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x5B5970 Offset: 0x5B3F70 VA: 0x1805B5970 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5B6C90 Offset: 0x5B5290 VA: 0x1805B6C90
	public void .ctor() { }

	// RVA: 0x5B6C30 Offset: 0x5B5230 VA: 0x1805B6C30
	private static void .cctor() { }

}

