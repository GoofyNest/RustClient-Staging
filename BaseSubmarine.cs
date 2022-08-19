public class BaseSubmarine : BaseVehicle, IEngineControllerUser, IEntity, IAirSupply // TypeDefIndex: 8349
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x3B8
	private Option __menuOption_Menu_ItemStorage; // 0x410
	private Option __menuOption_Menu_Push; // 0x468
	private Option __menuOption_Menu_TorpedoStorage; // 0x4C0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <PropPercentVelocity>k__BackingField; // 0x518
	private bool runningClientTick; // 0x51C
	private bool playedDiveBubbles; // 0x51D
	private bool playedWindowFilm; // 0x51E
	private float baseAlphaInside; // 0x520
	private float baseAlphaOutside; // 0x524
	[HeaderAttribute] // RVA: 0xC6220 Offset: 0xC5620 VA: 0x1800C6220
	[SerializeField] // RVA: 0xC6220 Offset: 0xC5620 VA: 0x1800C6220
	private Transform centreOfMassTransform; // 0x528
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Buoyancy buoyancy; // 0x530
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected float maxRudderAngle; // 0x538
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform rudderVisualTransform; // 0x540
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform rudderDetailedColliderTransform; // 0x548
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform propellerTransform; // 0x550
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float timeUntilAutoSurface; // 0x558
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Renderer[] interiorRenderers; // 0x560
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SonarObject sonarObject; // 0x568
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private BaseSubmarine.ParentTriggerInfo[] parentTriggers; // 0x570
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef fuelStoragePrefab; // 0x578
	[HeaderAttribute] // RVA: 0xC69F0 Offset: 0xC5DF0 VA: 0x1800C69F0
	[SerializeField] // RVA: 0xC69F0 Offset: 0xC5DF0 VA: 0x1800C69F0
	private float engineKW; // 0x580
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float turnPower; // 0x584
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float engineStartupTime; // 0x588
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef itemStoragePrefab; // 0x590
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float depthChangeTargetSpeed; // 0x598
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float idleFuelPerSec; // 0x59C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float maxFuelPerSec; // 0x5A0
	[FormerlySerializedAsAttribute] // RVA: 0xC6E10 Offset: 0xC6210 VA: 0x1800C6E10
	[SerializeField] // RVA: 0xC6E10 Offset: 0xC6210 VA: 0x1800C6E10
	private bool internalAccessStorage; // 0x5A4
	[HeaderAttribute] // RVA: 0xC6F70 Offset: 0xC6370 VA: 0x1800C6F70
	[SerializeField] // RVA: 0xC6F70 Offset: 0xC6370 VA: 0x1800C6F70
	private GameObjectRef torpedoStoragePrefab; // 0x5A8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform torpedoFiringPoint; // 0x5B0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float maxFireRate; // 0x5B8
	[HeaderAttribute] // RVA: 0xC87E0 Offset: 0xC7BE0 VA: 0x1800C87E0
	[SerializeField] // RVA: 0xC87E0 Offset: 0xC7BE0 VA: 0x1800C87E0
	protected SubmarineAudio submarineAudio; // 0x5C0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxTorpedoFire; // 0x5C8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject internalFXContainer; // 0x5D0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject internalOnFXContainer; // 0x5D8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxIntAmbientBubbleLoop; // 0x5E0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxIntInitialDiveBubbles; // 0x5E8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxIntWaterDropSpray; // 0x5F0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxIntWindowFilm; // 0x5F8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystemContainer fxIntMediumDamage; // 0x600
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystemContainer fxIntHeavyDamage; // 0x608
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject externalFXContainer; // 0x610
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject externalOnFXContainer; // 0x618
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxExtAmbientBubbleLoop; // 0x620
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxExtInitialDiveBubbles; // 0x628
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxExtAboveWaterEngineThrustForward; // 0x630
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxExtAboveWaterEngineThrustReverse; // 0x638
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxExtUnderWaterEngineThrustForward; // 0x640
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem[] fxExtUnderWaterEngineThrustForwardSubs; // 0x648
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxExtUnderWaterEngineThrustReverse; // 0x650
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem[] fxExtUnderWaterEngineThrustReverseSubs; // 0x658
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxExtBowWave; // 0x660
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem fxExtWakeEffect; // 0x668
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef aboveWatercollisionEffect; // 0x670
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef underWatercollisionEffect; // 0x678
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private VolumetricLightBeam spotlightVolumetrics; // 0x680
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float mountedAlphaInside; // 0x688
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float mountedAlphaOutside; // 0x68C
	[ServerVar] // RVA: 0xCA310 Offset: 0xC9710 VA: 0x1800CA310
	public static float outsidedecayminutes; // 0x0
	[ServerVar] // RVA: 0xCA350 Offset: 0xC9750 VA: 0x1800CA350
	public static float deepwaterdecayminutes; // 0x4
	[ServerVar] // RVA: 0xCA420 Offset: 0xC9820 VA: 0x1800CA420
	public static float oxygenminutes; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x92DF60 Offset: 0x92C560 VA: 0x18092DF60 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9319A0 Offset: 0x92FFA0 VA: 0x1809319A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x92F610 Offset: 0x92DC10 VA: 0x18092F610 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x931C40 Offset: 0x930240 VA: 0x180931C40
	public float get_PropPercentVelocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x931D70 Offset: 0x930370 VA: 0x180931D70
	private void set_PropPercentVelocity(float value) { }

	// RVA: 0x92DD30 Offset: 0x92C330 VA: 0x18092DD30 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x92DBD0 Offset: 0x92C1D0 VA: 0x18092DBD0
	private void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5B4660 Offset: 0x5B2C60 VA: 0x1805B4660 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x92F390 Offset: 0x92D990 VA: 0x18092F390 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x930460 Offset: 0x92EA60 VA: 0x180930460
	private void StartClientTick() { }

	// RVA: 0x9304F0 Offset: 0x92EAF0 VA: 0x1809304F0
	private void StopClientTick() { }

	// RVA: 0x9305D0 Offset: 0x92EBD0 VA: 0x1809305D0
	protected void SubmarineClientTick() { }

	// RVA: 0x931160 Offset: 0x92F760 VA: 0x180931160 Slot: 197
	protected virtual bool UpdateInteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x930AE0 Offset: 0x92F0E0 VA: 0x180930AE0 Slot: 198
	protected virtual bool UpdateExteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x92D970 Offset: 0x92BF70 VA: 0x18092D970
	private void AmbientLoopBubbles(ParticleSystem particleSystem) { }

	// RVA: 0x92EDB0 Offset: 0x92D3B0 VA: 0x18092EDB0
	private void InitialDiveBubbles(ParticleSystem particleSystem) { }

	// RVA: 0x930AB0 Offset: 0x92F0B0 VA: 0x180930AB0 Slot: 199
	protected virtual void TorpedoFired() { }

	[BaseEntity.Menu] // RVA: 0x73DF0 Offset: 0x731F0 VA: 0x180073DF0
	[BaseEntity.Menu.Description] // RVA: 0x73DF0 Offset: 0x731F0 VA: 0x180073DF0
	[BaseEntity.Menu.Icon] // RVA: 0x73DF0 Offset: 0x731F0 VA: 0x180073DF0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73DF0 Offset: 0x731F0 VA: 0x180073DF0
	// RVA: 0x92F0D0 Offset: 0x92D6D0 VA: 0x18092F0D0
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x92F000 Offset: 0x92D600 VA: 0x18092F000
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCA740 Offset: 0xC9B40 VA: 0x1800CA740
	[BaseEntity.Menu.Description] // RVA: 0xCA740 Offset: 0xC9B40 VA: 0x1800CA740
	[BaseEntity.Menu.Icon] // RVA: 0xCA740 Offset: 0xC9B40 VA: 0x1800CA740
	[BaseEntity.Menu.ShowIf] // RVA: 0xCA740 Offset: 0xC9B40 VA: 0x1800CA740
	// RVA: 0x92F350 Offset: 0x92D950 VA: 0x18092F350
	public void Menu_TorpedoStorage(BasePlayer player) { }

	// RVA: 0x92F260 Offset: 0x92D860 VA: 0x18092F260
	public bool Menu_TorpedoStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCAA80 Offset: 0xC9E80 VA: 0x1800CAA80
	[BaseEntity.Menu.Description] // RVA: 0xCAA80 Offset: 0xC9E80 VA: 0x1800CAA80
	[BaseEntity.Menu.Icon] // RVA: 0xCAA80 Offset: 0xC9E80 VA: 0x1800CAA80
	[BaseEntity.Menu.ShowIf] // RVA: 0xCAA80 Offset: 0xC9E80 VA: 0x1800CAA80
	// RVA: 0x92F1E0 Offset: 0x92D7E0 VA: 0x18092F1E0
	public void Menu_ItemStorage(BasePlayer player) { }

	// RVA: 0x92F110 Offset: 0x92D710 VA: 0x18092F110
	public bool Menu_ItemStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	[BaseEntity.Menu.Description] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	[BaseEntity.Menu.Icon] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	// RVA: 0x92F220 Offset: 0x92D820 VA: 0x18092F220 Slot: 200
	public virtual void Menu_Push(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x930950 Offset: 0x92EF50 VA: 0x180930950
	private void SubmarineUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x92DE40 Offset: 0x92C440 VA: 0x18092DE40
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x766630 Offset: 0x764C30 VA: 0x180766630
	private void TorpedoFired(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x930A80 Offset: 0x92F080 VA: 0x180930A80
	private void TorpedoFireFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 195
	public ItemModGiveOxygen.AirSupplyType get_AirType() { }

	// RVA: 0x931950 Offset: 0x92FF50 VA: 0x180931950
	public VehicleEngineController.EngineState<BaseSubmarine> get_EngineState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x931CD0 Offset: 0x9302D0 VA: 0x180931CD0
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x931F00 Offset: 0x930500 VA: 0x180931F00
	private void set_Velocity(Vector3 value) { }

	// RVA: 0x738190 Offset: 0x736790 VA: 0x180738190
	public bool get_LightsAreOn() { }

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool get_HasAmmo() { }

	// RVA: 0x931C60 Offset: 0x930260 VA: 0x180931C60
	public float get_ThrottleInput() { }

	// RVA: 0x931E00 Offset: 0x930400 VA: 0x180931E00
	protected void set_ThrottleInput(float value) { }

	// RVA: 0x931C50 Offset: 0x930250 VA: 0x180931C50
	public float get_RudderInput() { }

	// RVA: 0x931D80 Offset: 0x930380 VA: 0x180931D80
	protected void set_RudderInput(float value) { }

	// RVA: 0x931CC0 Offset: 0x9302C0 VA: 0x180931CC0
	public float get_UpDownInput() { }

	// RVA: 0x931E80 Offset: 0x930480 VA: 0x180931E80
	protected void set_UpDownInput(float value) { }

	// RVA: 0x92D960 Offset: 0x92BF60 VA: 0x18092D960
	public float get_Oxygen() { }

	// RVA: 0x931CF0 Offset: 0x9302F0 VA: 0x180931CF0
	protected void set_Oxygen(float value) { }

	// RVA: 0x931BF0 Offset: 0x9301F0 VA: 0x180931BF0
	protected float get_PhysicalRudderAngle() { }

	// RVA: 0x931BB0 Offset: 0x9301B0 VA: 0x180931BB0
	protected bool get_IsInWater() { }

	// RVA: 0x931BD0 Offset: 0x9301D0 VA: 0x180931BD0
	protected bool get_IsSurfaced() { }

	// RVA: 0x92EC40 Offset: 0x92D240 VA: 0x18092EC40 Slot: 28
	public override void InitShared() { }

	// RVA: 0x92EE70 Offset: 0x92D470 VA: 0x18092EE70 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x92F480 Offset: 0x92DA80 VA: 0x18092F480 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x92D960 Offset: 0x92BF60 VA: 0x18092D960 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 109
	public override bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x92DF50 Offset: 0x92C550 VA: 0x18092DF50
	public float GetFuelAmount() { }

	// RVA: 0x92E910 Offset: 0x92CF10 VA: 0x18092E910
	public float GetSpeed() { }

	// RVA: 0x92DA40 Offset: 0x92C040 VA: 0x18092DA40 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x92DE70 Offset: 0x92C470 VA: 0x18092DE70 Slot: 196
	public float GetAirTimeRemaining() { }

	// RVA: 0x92DB40 Offset: 0x92C140 VA: 0x18092DB40 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x931660 Offset: 0x92FC60 VA: 0x180931660
	private void UpdatePhysicalRudder(float turnInput, float deltaTime) { }

	// RVA: 0x92DB10 Offset: 0x92C110 VA: 0x18092DB10
	private bool CanMount(BasePlayer player) { }

	// RVA: 0x931800 Offset: 0x92FE00 VA: 0x180931800
	private void UpdateWaterInfo() { }

	// RVA: 0x92EA00 Offset: 0x92D000 VA: 0x18092EA00
	private float GetWaterSurfaceY() { }

	// RVA: 0x9318C0 Offset: 0x92FEC0 VA: 0x1809318C0
	public void .ctor() { }

	// RVA: 0x931860 Offset: 0x92FE60 VA: 0x180931860
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
