public class BaseSubmarine : BaseVehicle, IEngineControllerUser, IEntity, IAirSupply // TypeDefIndex: 8349
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x3B8
	private Option __menuOption_Menu_ItemStorage; // 0x410
	private Option __menuOption_Menu_Push; // 0x468
	private Option __menuOption_Menu_TorpedoStorage; // 0x4C0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <PropPercentVelocity>k__BackingField; // 0x518
	private bool runningClientTick; // 0x51C
	private bool playedDiveBubbles; // 0x51D
	private bool playedWindowFilm; // 0x51E
	private float baseAlphaInside; // 0x520
	private float baseAlphaOutside; // 0x524
	[HeaderAttribute] // RVA: 0xC62B0 Offset: 0xC56B0 VA: 0x1800C62B0
	[SerializeField] // RVA: 0xC62B0 Offset: 0xC56B0 VA: 0x1800C62B0
	private Transform centreOfMassTransform; // 0x528
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Buoyancy buoyancy; // 0x530
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected float maxRudderAngle; // 0x538
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rudderVisualTransform; // 0x540
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rudderDetailedColliderTransform; // 0x548
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform propellerTransform; // 0x550
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float timeUntilAutoSurface; // 0x558
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer[] interiorRenderers; // 0x560
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SonarObject sonarObject; // 0x568
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseSubmarine.ParentTriggerInfo[] parentTriggers; // 0x570
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef fuelStoragePrefab; // 0x578
	[HeaderAttribute] // RVA: 0xC6A80 Offset: 0xC5E80 VA: 0x1800C6A80
	[SerializeField] // RVA: 0xC6A80 Offset: 0xC5E80 VA: 0x1800C6A80
	private float engineKW; // 0x580
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float turnPower; // 0x584
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float engineStartupTime; // 0x588
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef itemStoragePrefab; // 0x590
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float depthChangeTargetSpeed; // 0x598
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float idleFuelPerSec; // 0x59C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxFuelPerSec; // 0x5A0
	[FormerlySerializedAsAttribute] // RVA: 0xC6EA0 Offset: 0xC62A0 VA: 0x1800C6EA0
	[SerializeField] // RVA: 0xC6EA0 Offset: 0xC62A0 VA: 0x1800C6EA0
	private bool internalAccessStorage; // 0x5A4
	[HeaderAttribute] // RVA: 0xC7000 Offset: 0xC6400 VA: 0x1800C7000
	[SerializeField] // RVA: 0xC7000 Offset: 0xC6400 VA: 0x1800C7000
	private GameObjectRef torpedoStoragePrefab; // 0x5A8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform torpedoFiringPoint; // 0x5B0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxFireRate; // 0x5B8
	[HeaderAttribute] // RVA: 0xC8870 Offset: 0xC7C70 VA: 0x1800C8870
	[SerializeField] // RVA: 0xC8870 Offset: 0xC7C70 VA: 0x1800C8870
	protected SubmarineAudio submarineAudio; // 0x5C0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxTorpedoFire; // 0x5C8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject internalFXContainer; // 0x5D0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject internalOnFXContainer; // 0x5D8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxIntAmbientBubbleLoop; // 0x5E0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxIntInitialDiveBubbles; // 0x5E8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxIntWaterDropSpray; // 0x5F0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxIntWindowFilm; // 0x5F8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemContainer fxIntMediumDamage; // 0x600
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemContainer fxIntHeavyDamage; // 0x608
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject externalFXContainer; // 0x610
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject externalOnFXContainer; // 0x618
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxExtAmbientBubbleLoop; // 0x620
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxExtInitialDiveBubbles; // 0x628
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxExtAboveWaterEngineThrustForward; // 0x630
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxExtAboveWaterEngineThrustReverse; // 0x638
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxExtUnderWaterEngineThrustForward; // 0x640
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem[] fxExtUnderWaterEngineThrustForwardSubs; // 0x648
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxExtUnderWaterEngineThrustReverse; // 0x650
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem[] fxExtUnderWaterEngineThrustReverseSubs; // 0x658
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxExtBowWave; // 0x660
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem fxExtWakeEffect; // 0x668
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef aboveWatercollisionEffect; // 0x670
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef underWatercollisionEffect; // 0x678
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private VolumetricLightBeam spotlightVolumetrics; // 0x680
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float mountedAlphaInside; // 0x688
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float mountedAlphaOutside; // 0x68C
	[ServerVar] // RVA: 0xCA3A0 Offset: 0xC97A0 VA: 0x1800CA3A0
	public static float outsidedecayminutes; // 0x0
	[ServerVar] // RVA: 0xCA3E0 Offset: 0xC97E0 VA: 0x1800CA3E0
	public static float deepwaterdecayminutes; // 0x4
	[ServerVar] // RVA: 0xCA4B0 Offset: 0xC98B0 VA: 0x1800CA4B0
	public static float oxygenminutes; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <Velocity>k__BackingField; // 0x690
	public const BaseEntity.Flags Flag_Ammo = 16384;
	private float _throttle; // 0x69C
	private float _rudder; // 0x6A0
	private float _upDown; // 0x6A4
	private float _oxygen; // 0x6A8
	protected VehicleEngineController<BaseSubmarine> engineController; // 0x6B0
	protected float cachedFuelAmount; // 0x6B8
	protected Vector3 steerAngle; // 0x6BC
	protected float waterSurfaceY; // 0x6C8
	protected float curSubDepthY; // 0x6CC
	private EntityRef<StorageContainer> torpedoStorageInstance; // 0x6D0
	private EntityRef<StorageContainer> itemStorageInstance; // 0x6E0
	private int waterLayerMask; // 0x6F0

	// Properties
	public override bool HasMenuOptions { get; }
	public float PropPercentVelocity { get; set; }
	public ItemModGiveOxygen.AirSupplyType AirType { get; }
	public VehicleEngineController.EngineState<BaseSubmarine> EngineState { get; }
	public Vector3 Velocity { get; set; }
	public bool LightsAreOn { get; }
	public bool HasAmmo { get; }
	public float ThrottleInput { get; set; }
	public float RudderInput { get; set; }
	public float UpDownInput { get; set; }
	public float Oxygen { get; set; }
	protected float PhysicalRudderAngle { get; }
	protected bool IsInWater { get; }
	protected bool IsSurfaced { get; }

	// Methods

	// RVA: 0x92E070 Offset: 0x92C670 VA: 0x18092E070 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x931AB0 Offset: 0x9300B0 VA: 0x180931AB0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x92F720 Offset: 0x92DD20 VA: 0x18092F720 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x931D50 Offset: 0x930350 VA: 0x180931D50
	public float get_PropPercentVelocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x931E80 Offset: 0x930480 VA: 0x180931E80
	private void set_PropPercentVelocity(float value) { }

	// RVA: 0x92DE40 Offset: 0x92C440 VA: 0x18092DE40 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x92DCE0 Offset: 0x92C2E0 VA: 0x18092DCE0
	private void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5B4660 Offset: 0x5B2C60 VA: 0x1805B4660 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x92F4A0 Offset: 0x92DAA0 VA: 0x18092F4A0 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x930570 Offset: 0x92EB70 VA: 0x180930570
	private void StartClientTick() { }

	// RVA: 0x930600 Offset: 0x92EC00 VA: 0x180930600
	private void StopClientTick() { }

	// RVA: 0x9306E0 Offset: 0x92ECE0 VA: 0x1809306E0
	protected void SubmarineClientTick() { }

	// RVA: 0x931270 Offset: 0x92F870 VA: 0x180931270 Slot: 197
	protected virtual bool UpdateInteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x930BF0 Offset: 0x92F1F0 VA: 0x180930BF0 Slot: 198
	protected virtual bool UpdateExteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x92DA80 Offset: 0x92C080 VA: 0x18092DA80
	private void AmbientLoopBubbles(ParticleSystem particleSystem) { }

	// RVA: 0x92EEC0 Offset: 0x92D4C0 VA: 0x18092EEC0
	private void InitialDiveBubbles(ParticleSystem particleSystem) { }

	// RVA: 0x930BC0 Offset: 0x92F1C0 VA: 0x180930BC0 Slot: 199
	protected virtual void TorpedoFired() { }

	[BaseEntity.Menu] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Description] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Icon] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	// RVA: 0x92F1E0 Offset: 0x92D7E0 VA: 0x18092F1E0
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x92F110 Offset: 0x92D710 VA: 0x18092F110
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCA7D0 Offset: 0xC9BD0 VA: 0x1800CA7D0
	[BaseEntity.Menu.Description] // RVA: 0xCA7D0 Offset: 0xC9BD0 VA: 0x1800CA7D0
	[BaseEntity.Menu.Icon] // RVA: 0xCA7D0 Offset: 0xC9BD0 VA: 0x1800CA7D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCA7D0 Offset: 0xC9BD0 VA: 0x1800CA7D0
	// RVA: 0x92F460 Offset: 0x92DA60 VA: 0x18092F460
	public void Menu_TorpedoStorage(BasePlayer player) { }

	// RVA: 0x92F370 Offset: 0x92D970 VA: 0x18092F370
	public bool Menu_TorpedoStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCAB10 Offset: 0xC9F10 VA: 0x1800CAB10
	[BaseEntity.Menu.Description] // RVA: 0xCAB10 Offset: 0xC9F10 VA: 0x1800CAB10
	[BaseEntity.Menu.Icon] // RVA: 0xCAB10 Offset: 0xC9F10 VA: 0x1800CAB10
	[BaseEntity.Menu.ShowIf] // RVA: 0xCAB10 Offset: 0xC9F10 VA: 0x1800CAB10
	// RVA: 0x92F2F0 Offset: 0x92D8F0 VA: 0x18092F2F0
	public void Menu_ItemStorage(BasePlayer player) { }

	// RVA: 0x92F220 Offset: 0x92D820 VA: 0x18092F220
	public bool Menu_ItemStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Description] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Icon] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	// RVA: 0x92F330 Offset: 0x92D930 VA: 0x18092F330 Slot: 200
	public virtual void Menu_Push(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x930A60 Offset: 0x92F060 VA: 0x180930A60
	private void SubmarineUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92DF50 Offset: 0x92C550 VA: 0x18092DF50
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x766740 Offset: 0x764D40 VA: 0x180766740
	private void TorpedoFired(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x930B90 Offset: 0x92F190 VA: 0x180930B90
	private void TorpedoFireFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 195
	public ItemModGiveOxygen.AirSupplyType get_AirType() { }

	// RVA: 0x931A60 Offset: 0x930060 VA: 0x180931A60
	public VehicleEngineController.EngineState<BaseSubmarine> get_EngineState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x931DE0 Offset: 0x9303E0 VA: 0x180931DE0
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x932010 Offset: 0x930610 VA: 0x180932010
	private void set_Velocity(Vector3 value) { }

	// RVA: 0x7382A0 Offset: 0x7368A0 VA: 0x1807382A0
	public bool get_LightsAreOn() { }

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool get_HasAmmo() { }

	// RVA: 0x931D70 Offset: 0x930370 VA: 0x180931D70
	public float get_ThrottleInput() { }

	// RVA: 0x931F10 Offset: 0x930510 VA: 0x180931F10
	protected void set_ThrottleInput(float value) { }

	// RVA: 0x931D60 Offset: 0x930360 VA: 0x180931D60
	public float get_RudderInput() { }

	// RVA: 0x931E90 Offset: 0x930490 VA: 0x180931E90
	protected void set_RudderInput(float value) { }

	// RVA: 0x931DD0 Offset: 0x9303D0 VA: 0x180931DD0
	public float get_UpDownInput() { }

	// RVA: 0x931F90 Offset: 0x930590 VA: 0x180931F90
	protected void set_UpDownInput(float value) { }

	// RVA: 0x92DA70 Offset: 0x92C070 VA: 0x18092DA70
	public float get_Oxygen() { }

	// RVA: 0x931E00 Offset: 0x930400 VA: 0x180931E00
	protected void set_Oxygen(float value) { }

	// RVA: 0x931D00 Offset: 0x930300 VA: 0x180931D00
	protected float get_PhysicalRudderAngle() { }

	// RVA: 0x931CC0 Offset: 0x9302C0 VA: 0x180931CC0
	protected bool get_IsInWater() { }

	// RVA: 0x931CE0 Offset: 0x9302E0 VA: 0x180931CE0
	protected bool get_IsSurfaced() { }

	// RVA: 0x92ED50 Offset: 0x92D350 VA: 0x18092ED50 Slot: 28
	public override void InitShared() { }

	// RVA: 0x92EF80 Offset: 0x92D580 VA: 0x18092EF80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x92F590 Offset: 0x92DB90 VA: 0x18092F590 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x92DA70 Offset: 0x92C070 VA: 0x18092DA70 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 109
	public override bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x92E060 Offset: 0x92C660 VA: 0x18092E060
	public float GetFuelAmount() { }

	// RVA: 0x92EA20 Offset: 0x92D020 VA: 0x18092EA20
	public float GetSpeed() { }

	// RVA: 0x92DB50 Offset: 0x92C150 VA: 0x18092DB50 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x92DF80 Offset: 0x92C580 VA: 0x18092DF80 Slot: 196
	public float GetAirTimeRemaining() { }

	// RVA: 0x92DC50 Offset: 0x92C250 VA: 0x18092DC50 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x931770 Offset: 0x92FD70 VA: 0x180931770
	private void UpdatePhysicalRudder(float turnInput, float deltaTime) { }

	// RVA: 0x92DC20 Offset: 0x92C220 VA: 0x18092DC20
	private bool CanMount(BasePlayer player) { }

	// RVA: 0x931910 Offset: 0x92FF10 VA: 0x180931910
	private void UpdateWaterInfo() { }

	// RVA: 0x92EB10 Offset: 0x92D110 VA: 0x18092EB10
	private float GetWaterSurfaceY() { }

	// RVA: 0x9319D0 Offset: 0x92FFD0 VA: 0x1809319D0
	public void .ctor() { }

	// RVA: 0x931970 Offset: 0x92FF70 VA: 0x180931970
	private static void .cctor() { }

}

public class BaseSubmarine.ParentTriggerInfo // TypeDefIndex: 8350
{	// Fields
	public TriggerParent trigger; // 0x10
	public Transform triggerWaterLevel; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

