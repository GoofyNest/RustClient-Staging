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

	// RVA: 0x1DB60D0 Offset: 0x1DB46D0 VA: 0x181DB60D0
	public static void ResetToPool(Snowmobile instance) { }

	// RVA: 0x1DB6000 Offset: 0x1DB4600 VA: 0x181DB6000
	public void ResetToPool() { }

	// RVA: 0x1DB5840 Offset: 0x1DB3E40 VA: 0x181DB5840 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB3DF0 Offset: 0x1DB23F0 VA: 0x181DB3DF0
	public void CopyTo(Snowmobile instance) { }

	// RVA: 0x1DB3E30 Offset: 0x1DB2430 VA: 0x181DB3E30
	public Snowmobile Copy() { }

	// RVA: 0x1DB5520 Offset: 0x1DB3B20 VA: 0x181DB5520
	public static Snowmobile Deserialize(Stream stream) { }

	// RVA: 0x1DB3EC0 Offset: 0x1DB24C0 VA: 0x181DB3EC0
	public static Snowmobile DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB4300 Offset: 0x1DB2900 VA: 0x181DB4300
	public static Snowmobile DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB5130 Offset: 0x1DB3730 VA: 0x181DB5130
	public static Snowmobile Deserialize(byte[] buffer) { }

	// RVA: 0x1DB5990 Offset: 0x1DB3F90 VA: 0x181DB5990
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB6870 Offset: 0x1DB4E70 VA: 0x181DB6870 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB6890 Offset: 0x1DB4E90 VA: 0x181DB6890 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Snowmobile previous) { }

	// RVA: 0x1DB5C70 Offset: 0x1DB4270 VA: 0x181DB5C70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB4D60 Offset: 0x1DB3360 VA: 0x181DB4D60
	public static Snowmobile Deserialize(byte[] buffer, Snowmobile instance, bool isDelta = False) { }

	// RVA: 0x1DB4A80 Offset: 0x1DB3080 VA: 0x181DB4A80
	public static Snowmobile Deserialize(Stream stream, Snowmobile instance, bool isDelta) { }

	// RVA: 0x1DB3F40 Offset: 0x1DB2540 VA: 0x181DB3F40
	public static Snowmobile DeserializeLengthDelimited(Stream stream, Snowmobile instance, bool isDelta) { }

	// RVA: 0x1DB46E0 Offset: 0x1DB2CE0 VA: 0x181DB46E0
	public static Snowmobile DeserializeLength(Stream stream, int length, Snowmobile instance, bool isDelta) { }

	// RVA: 0x1DB61A0 Offset: 0x1DB47A0 VA: 0x181DB61A0
	public static void SerializeDelta(Stream stream, Snowmobile instance, Snowmobile previous) { }

	// RVA: 0x1DB66A0 Offset: 0x1DB4CA0 VA: 0x181DB66A0
	public static void Serialize(Stream stream, Snowmobile instance) { }

	// RVA: 0x1DB6860 Offset: 0x1DB4E60 VA: 0x181DB6860
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB6870 Offset: 0x1DB4E70 VA: 0x181DB6870
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB6590 Offset: 0x1DB4B90 VA: 0x181DB6590
	public static byte[] SerializeToBytes(Snowmobile instance) { }

	// RVA: 0x1DB64E0 Offset: 0x1DB4AE0 VA: 0x181DB64E0
	public static void SerializeLengthDelimited(Stream stream, Snowmobile instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x5B48E0 Offset: 0x5B2EE0 VA: 0x1805B48E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5B6DE0 Offset: 0x5B53E0 VA: 0x1805B6DE0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5B5910 Offset: 0x5B3F10 VA: 0x1805B5910 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5B4000 Offset: 0x5B2600 VA: 0x1805B4000 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5B3E90 Offset: 0x5B2490 VA: 0x1805B3E90 Slot: 200
	protected override void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5B6270 Offset: 0x5B4870 VA: 0x1805B6270 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x5B5380 Offset: 0x5B3980 VA: 0x1805B5380
	public bool IsATreadWheel(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	// RVA: 0x5B5360 Offset: 0x5B3960 VA: 0x1805B5360
	public bool IsASkiWheel(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	// RVA: 0x5B45F0 Offset: 0x5B2BF0 VA: 0x1805B45F0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x5B51A0 Offset: 0x5B37A0 VA: 0x1805B51A0 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0x5B5850 Offset: 0x5B3E50 VA: 0x1805B5850 Slot: 201
	protected override void OnClientTickStopped() { }

	[BaseEntity.Menu] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Description] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Icon] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	// RVA: 0x5B56C0 Offset: 0x5B3CC0 VA: 0x1805B56C0
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x5B54E0 Offset: 0x5B3AE0 VA: 0x1805B54E0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8C900 Offset: 0x8BD00 VA: 0x18008C900
	[BaseEntity.Menu.Description] // RVA: 0x8C900 Offset: 0x8BD00 VA: 0x18008C900
	[BaseEntity.Menu.Icon] // RVA: 0x8C900 Offset: 0x8BD00 VA: 0x18008C900
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C900 Offset: 0x8BD00 VA: 0x18008C900
	// RVA: 0x5B57D0 Offset: 0x5B3DD0 VA: 0x1805B57D0
	public void Menu_ItemStorage(BasePlayer player) { }

	// RVA: 0x5B5700 Offset: 0x5B3D00 VA: 0x1805B5700
	public bool Menu_ItemStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Description] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Icon] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	// RVA: 0x5B5810 Offset: 0x5B3E10 VA: 0x1805B5810
	public void Menu_Push(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5B6150 Offset: 0x5B4750 VA: 0x1805B6150
	private void SnowmobileUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5B4640 Offset: 0x5B2C40 VA: 0x1805B4640
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5B5140 Offset: 0x5B3740 VA: 0x1805B5140
	public float get_ThrottleInput() { }

	// RVA: 0x5B71E0 Offset: 0x5B57E0 VA: 0x1805B71E0
	protected void set_ThrottleInput(float value) { }

	// RVA: 0x5B46A0 Offset: 0x5B2CA0 VA: 0x1805B46A0
	public float get_BrakeInput() { }

	// RVA: 0x5B70E0 Offset: 0x5B56E0 VA: 0x1805B70E0
	protected void set_BrakeInput(float value) { }

	// RVA: 0x5B6FC0 Offset: 0x5B55C0 VA: 0x1805B6FC0
	public bool get_IsBraking() { }

	// RVA: 0x5B5130 Offset: 0x5B3730 VA: 0x1805B5130
	public float get_SteerInput() { }

	// RVA: 0x5B7160 Offset: 0x5B5760 VA: 0x1805B7160
	protected void set_SteerInput(float value) { }

	// RVA: 0x5B70B0 Offset: 0x5B56B0 VA: 0x1805B70B0 Slot: 205
	public float get_SteerAngle() { }

	// RVA: 0x5B6CE0 Offset: 0x5B52E0 VA: 0x1805B6CE0 Slot: 196
	public override float get_DriveWheelVelocity() { }

	// RVA: 0x5B6CD0 Offset: 0x5B52D0 VA: 0x1805B6CD0
	public float get_DriveWheelSlip() { }

	// RVA: 0x5B7090 Offset: 0x5B5690 VA: 0x1805B7090 Slot: 206
	public float get_MaxSteerAngle() { }

	// RVA: 0x557BF0 Offset: 0x5561F0 VA: 0x180557BF0
	public bool get_InSlowMode() { }

	// RVA: 0x5B6FE0 Offset: 0x5B55E0 VA: 0x1805B6FE0
	private float get_Mass() { }

	// RVA: 0x5B53A0 Offset: 0x5B39A0 VA: 0x1805B53A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5B46C0 Offset: 0x5B2CC0 VA: 0x1805B46C0
	public float GetMaxDriveForce() { }

	// RVA: 0x5B4780 Offset: 0x5B2D80 VA: 0x1805B4780 Slot: 197
	public override float GetMaxForwardSpeed() { }

	// RVA: 0x5B5140 Offset: 0x5B3740 VA: 0x1805B5140 Slot: 198
	public override float GetThrottleInput() { }

	// RVA: 0x5B46A0 Offset: 0x5B2CA0 VA: 0x1805B46A0 Slot: 199
	public override float GetBrakeInput() { }

	// RVA: 0x5B5130 Offset: 0x5B3730 VA: 0x1805B5130
	public float GetSteerInput() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool GetSteerModInput() { }

	// RVA: 0x5B5090 Offset: 0x5B3690 VA: 0x1805B5090
	public float GetPerformanceFraction() { }

	// RVA: 0x5B46B0 Offset: 0x5B2CB0 VA: 0x1805B46B0
	public float GetFuelFraction() { }

	// RVA: 0x559500 Offset: 0x557B00 VA: 0x180559500 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x5B5900 Offset: 0x5B3F00 VA: 0x1805B5900 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5B6C20 Offset: 0x5B5220 VA: 0x1805B6C20
	public void .ctor() { }

	// RVA: 0x5B6BC0 Offset: 0x5B51C0 VA: 0x1805B6BC0
	private static void .cctor() { }

}

