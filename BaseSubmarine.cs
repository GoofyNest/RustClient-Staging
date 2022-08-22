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

	// RVA: 0x92E580 Offset: 0x92CB80 VA: 0x18092E580 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x931FC0 Offset: 0x9305C0 VA: 0x180931FC0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x92FC30 Offset: 0x92E230 VA: 0x18092FC30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x932260 Offset: 0x930860 VA: 0x180932260
	public float get_PropPercentVelocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x932390 Offset: 0x930990 VA: 0x180932390
	private void set_PropPercentVelocity(float value) { }

	// RVA: 0x92E350 Offset: 0x92C950 VA: 0x18092E350 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x92E1F0 Offset: 0x92C7F0 VA: 0x18092E1F0
	private void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5B45F0 Offset: 0x5B2BF0 VA: 0x1805B45F0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x92F9B0 Offset: 0x92DFB0 VA: 0x18092F9B0 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x930A80 Offset: 0x92F080 VA: 0x180930A80
	private void StartClientTick() { }

	// RVA: 0x930B10 Offset: 0x92F110 VA: 0x180930B10
	private void StopClientTick() { }

	// RVA: 0x930BF0 Offset: 0x92F1F0 VA: 0x180930BF0
	protected void SubmarineClientTick() { }

	// RVA: 0x931780 Offset: 0x92FD80 VA: 0x180931780 Slot: 197
	protected virtual bool UpdateInteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x931100 Offset: 0x92F700 VA: 0x180931100 Slot: 198
	protected virtual bool UpdateExteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x92DF90 Offset: 0x92C590 VA: 0x18092DF90
	private void AmbientLoopBubbles(ParticleSystem particleSystem) { }

	// RVA: 0x92F3D0 Offset: 0x92D9D0 VA: 0x18092F3D0
	private void InitialDiveBubbles(ParticleSystem particleSystem) { }

	// RVA: 0x9310D0 Offset: 0x92F6D0 VA: 0x1809310D0 Slot: 199
	protected virtual void TorpedoFired() { }

	[BaseEntity.Menu] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Description] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.Icon] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EC0 Offset: 0x732C0 VA: 0x180073EC0
	// RVA: 0x92F6F0 Offset: 0x92DCF0 VA: 0x18092F6F0
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x92F620 Offset: 0x92DC20 VA: 0x18092F620
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCA7D0 Offset: 0xC9BD0 VA: 0x1800CA7D0
	[BaseEntity.Menu.Description] // RVA: 0xCA7D0 Offset: 0xC9BD0 VA: 0x1800CA7D0
	[BaseEntity.Menu.Icon] // RVA: 0xCA7D0 Offset: 0xC9BD0 VA: 0x1800CA7D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCA7D0 Offset: 0xC9BD0 VA: 0x1800CA7D0
	// RVA: 0x92F970 Offset: 0x92DF70 VA: 0x18092F970
	public void Menu_TorpedoStorage(BasePlayer player) { }

	// RVA: 0x92F880 Offset: 0x92DE80 VA: 0x18092F880
	public bool Menu_TorpedoStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCAB10 Offset: 0xC9F10 VA: 0x1800CAB10
	[BaseEntity.Menu.Description] // RVA: 0xCAB10 Offset: 0xC9F10 VA: 0x1800CAB10
	[BaseEntity.Menu.Icon] // RVA: 0xCAB10 Offset: 0xC9F10 VA: 0x1800CAB10
	[BaseEntity.Menu.ShowIf] // RVA: 0xCAB10 Offset: 0xC9F10 VA: 0x1800CAB10
	// RVA: 0x92F800 Offset: 0x92DE00 VA: 0x18092F800
	public void Menu_ItemStorage(BasePlayer player) { }

	// RVA: 0x92F730 Offset: 0x92DD30 VA: 0x18092F730
	public bool Menu_ItemStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Description] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Icon] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	// RVA: 0x92F840 Offset: 0x92DE40 VA: 0x18092F840 Slot: 200
	public virtual void Menu_Push(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x930F70 Offset: 0x92F570 VA: 0x180930F70
	private void SubmarineUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92E460 Offset: 0x92CA60 VA: 0x18092E460
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x766690 Offset: 0x764C90 VA: 0x180766690
	private void TorpedoFired(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9310A0 Offset: 0x92F6A0 VA: 0x1809310A0
	private void TorpedoFireFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 195
	public ItemModGiveOxygen.AirSupplyType get_AirType() { }

	// RVA: 0x931F70 Offset: 0x930570 VA: 0x180931F70
	public VehicleEngineController.EngineState<BaseSubmarine> get_EngineState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9322F0 Offset: 0x9308F0 VA: 0x1809322F0
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x932520 Offset: 0x930B20 VA: 0x180932520
	private void set_Velocity(Vector3 value) { }

	// RVA: 0x7381F0 Offset: 0x7367F0 VA: 0x1807381F0
	public bool get_LightsAreOn() { }

	// RVA: 0x557EE0 Offset: 0x5564E0 VA: 0x180557EE0
	public bool get_HasAmmo() { }

	// RVA: 0x932280 Offset: 0x930880 VA: 0x180932280
	public float get_ThrottleInput() { }

	// RVA: 0x932420 Offset: 0x930A20 VA: 0x180932420
	protected void set_ThrottleInput(float value) { }

	// RVA: 0x932270 Offset: 0x930870 VA: 0x180932270
	public float get_RudderInput() { }

	// RVA: 0x9323A0 Offset: 0x9309A0 VA: 0x1809323A0
	protected void set_RudderInput(float value) { }

	// RVA: 0x9322E0 Offset: 0x9308E0 VA: 0x1809322E0
	public float get_UpDownInput() { }

	// RVA: 0x9324A0 Offset: 0x930AA0 VA: 0x1809324A0
	protected void set_UpDownInput(float value) { }

	// RVA: 0x92DF80 Offset: 0x92C580 VA: 0x18092DF80
	public float get_Oxygen() { }

	// RVA: 0x932310 Offset: 0x930910 VA: 0x180932310
	protected void set_Oxygen(float value) { }

	// RVA: 0x932210 Offset: 0x930810 VA: 0x180932210
	protected float get_PhysicalRudderAngle() { }

	// RVA: 0x9321D0 Offset: 0x9307D0 VA: 0x1809321D0
	protected bool get_IsInWater() { }

	// RVA: 0x9321F0 Offset: 0x9307F0 VA: 0x1809321F0
	protected bool get_IsSurfaced() { }

	// RVA: 0x92F260 Offset: 0x92D860 VA: 0x18092F260 Slot: 28
	public override void InitShared() { }

	// RVA: 0x92F490 Offset: 0x92DA90 VA: 0x18092F490 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x92FAA0 Offset: 0x92E0A0 VA: 0x18092FAA0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x92DF80 Offset: 0x92C580 VA: 0x18092DF80 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 109
	public override bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x92E570 Offset: 0x92CB70 VA: 0x18092E570
	public float GetFuelAmount() { }

	// RVA: 0x92EF30 Offset: 0x92D530 VA: 0x18092EF30
	public float GetSpeed() { }

	// RVA: 0x92E060 Offset: 0x92C660 VA: 0x18092E060 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x92E490 Offset: 0x92CA90 VA: 0x18092E490 Slot: 196
	public float GetAirTimeRemaining() { }

	// RVA: 0x92E160 Offset: 0x92C760 VA: 0x18092E160 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x931C80 Offset: 0x930280 VA: 0x180931C80
	private void UpdatePhysicalRudder(float turnInput, float deltaTime) { }

	// RVA: 0x92E130 Offset: 0x92C730 VA: 0x18092E130
	private bool CanMount(BasePlayer player) { }

	// RVA: 0x931E20 Offset: 0x930420 VA: 0x180931E20
	private void UpdateWaterInfo() { }

	// RVA: 0x92F020 Offset: 0x92D620 VA: 0x18092F020
	private float GetWaterSurfaceY() { }

	// RVA: 0x931EE0 Offset: 0x9304E0 VA: 0x180931EE0
	public void .ctor() { }

	// RVA: 0x931E80 Offset: 0x930480 VA: 0x180931E80
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

