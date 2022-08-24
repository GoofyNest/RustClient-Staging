public class BaseSubmarine : BaseVehicle, IEngineControllerUser, IEntity, IAirSupply // TypeDefIndex: 8349
{	private Option __menuOption_Menu_FuelStorage; // 0x3B8
	private Option __menuOption_Menu_ItemStorage; // 0x410
	private Option __menuOption_Menu_Push; // 0x468
	private Option __menuOption_Menu_TorpedoStorage; // 0x4C0
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <PropPercentVelocity>k__BackingField; // 0x518
	private bool runningClientTick; // 0x51C
	private bool playedDiveBubbles; // 0x51D
	private bool playedWindowFilm; // 0x51E
	private float baseAlphaInside; // 0x520
	private float baseAlphaOutside; // 0x524
	[HeaderAttribute] // RVA: 0xC63D0 Offset: 0xC57D0 VA: 0x1800C63D0
	[SerializeField] // RVA: 0xC63D0 Offset: 0xC57D0 VA: 0x1800C63D0
	private Transform centreOfMassTransform; // 0x528
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Buoyancy buoyancy; // 0x530
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected float maxRudderAngle; // 0x538
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform rudderVisualTransform; // 0x540
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform rudderDetailedColliderTransform; // 0x548
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform propellerTransform; // 0x550
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float timeUntilAutoSurface; // 0x558
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Renderer[] interiorRenderers; // 0x560
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SonarObject sonarObject; // 0x568
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BaseSubmarine.ParentTriggerInfo[] parentTriggers; // 0x570
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObjectRef fuelStoragePrefab; // 0x578
	[HeaderAttribute] // RVA: 0xC6BB0 Offset: 0xC5FB0 VA: 0x1800C6BB0
	[SerializeField] // RVA: 0xC6BB0 Offset: 0xC5FB0 VA: 0x1800C6BB0
	private float engineKW; // 0x580
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float turnPower; // 0x584
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float engineStartupTime; // 0x588
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObjectRef itemStoragePrefab; // 0x590
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float depthChangeTargetSpeed; // 0x598
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float idleFuelPerSec; // 0x59C
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float maxFuelPerSec; // 0x5A0
	[FormerlySerializedAsAttribute] // RVA: 0xC6FE0 Offset: 0xC63E0 VA: 0x1800C6FE0
	[SerializeField] // RVA: 0xC6FE0 Offset: 0xC63E0 VA: 0x1800C6FE0
	private bool internalAccessStorage; // 0x5A4
	[HeaderAttribute] // RVA: 0xC7140 Offset: 0xC6540 VA: 0x1800C7140
	[SerializeField] // RVA: 0xC7140 Offset: 0xC6540 VA: 0x1800C7140
	private GameObjectRef torpedoStoragePrefab; // 0x5A8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform torpedoFiringPoint; // 0x5B0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float maxFireRate; // 0x5B8
	[HeaderAttribute] // RVA: 0xC89E0 Offset: 0xC7DE0 VA: 0x1800C89E0
	[SerializeField] // RVA: 0xC89E0 Offset: 0xC7DE0 VA: 0x1800C89E0
	protected SubmarineAudio submarineAudio; // 0x5C0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxTorpedoFire; // 0x5C8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObject internalFXContainer; // 0x5D0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObject internalOnFXContainer; // 0x5D8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxIntAmbientBubbleLoop; // 0x5E0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxIntInitialDiveBubbles; // 0x5E8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxIntWaterDropSpray; // 0x5F0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxIntWindowFilm; // 0x5F8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystemContainer fxIntMediumDamage; // 0x600
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystemContainer fxIntHeavyDamage; // 0x608
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObject externalFXContainer; // 0x610
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObject externalOnFXContainer; // 0x618
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxExtAmbientBubbleLoop; // 0x620
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxExtInitialDiveBubbles; // 0x628
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxExtAboveWaterEngineThrustForward; // 0x630
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxExtAboveWaterEngineThrustReverse; // 0x638
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxExtUnderWaterEngineThrustForward; // 0x640
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem[] fxExtUnderWaterEngineThrustForwardSubs; // 0x648
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxExtUnderWaterEngineThrustReverse; // 0x650
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem[] fxExtUnderWaterEngineThrustReverseSubs; // 0x658
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxExtBowWave; // 0x660
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem fxExtWakeEffect; // 0x668
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObjectRef aboveWatercollisionEffect; // 0x670
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObjectRef underWatercollisionEffect; // 0x678
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private VolumetricLightBeam spotlightVolumetrics; // 0x680
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float mountedAlphaInside; // 0x688
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float mountedAlphaOutside; // 0x68C
	[ServerVar] // RVA: 0xCA4D0 Offset: 0xC98D0 VA: 0x1800CA4D0
	public static float outsidedecayminutes; // 0x0
	[ServerVar] // RVA: 0xCA510 Offset: 0xC9910 VA: 0x1800CA510
	public static float deepwaterdecayminutes; // 0x4
	[ServerVar] // RVA: 0xCA5E0 Offset: 0xC99E0 VA: 0x1800CA5E0
	public static float oxygenminutes; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_PropPercentVelocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_PropPercentVelocity(float value) { }

	protected override void ClientInit(Entity info) { }

	private void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override bool MountMenuVisible(BasePlayer player) { }

	private void StartClientTick() { }

	private void StopClientTick() { }

	protected void SubmarineClientTick() { }

	protected virtual bool UpdateInteriorVisuals(bool playerIsInside, float speed) { }

	protected virtual bool UpdateExteriorVisuals(bool playerIsInside, float speed) { }

	private void AmbientLoopBubbles(ParticleSystem particleSystem) { }

	private void InitialDiveBubbles(ParticleSystem particleSystem) { }

	protected virtual void TorpedoFired() { }

	[BaseEntity.Menu] // RVA: 0x73EF0 Offset: 0x732F0 VA: 0x180073EF0
	[BaseEntity.Menu.Description] // RVA: 0x73EF0 Offset: 0x732F0 VA: 0x180073EF0
	[BaseEntity.Menu.Icon] // RVA: 0x73EF0 Offset: 0x732F0 VA: 0x180073EF0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73EF0 Offset: 0x732F0 VA: 0x180073EF0
	public void Menu_FuelStorage(BasePlayer player) { }

	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCA900 Offset: 0xC9D00 VA: 0x1800CA900
	[BaseEntity.Menu.Description] // RVA: 0xCA900 Offset: 0xC9D00 VA: 0x1800CA900
	[BaseEntity.Menu.Icon] // RVA: 0xCA900 Offset: 0xC9D00 VA: 0x1800CA900
	[BaseEntity.Menu.ShowIf] // RVA: 0xCA900 Offset: 0xC9D00 VA: 0x1800CA900
	public void Menu_TorpedoStorage(BasePlayer player) { }

	public bool Menu_TorpedoStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCAC00 Offset: 0xCA000 VA: 0x1800CAC00
	[BaseEntity.Menu.Description] // RVA: 0xCAC00 Offset: 0xCA000 VA: 0x1800CAC00
	[BaseEntity.Menu.Icon] // RVA: 0xCAC00 Offset: 0xCA000 VA: 0x1800CAC00
	[BaseEntity.Menu.ShowIf] // RVA: 0xCAC00 Offset: 0xCA000 VA: 0x1800CAC00
	public void Menu_ItemStorage(BasePlayer player) { }

	public bool Menu_ItemStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CB60 Offset: 0x8BF60 VA: 0x18008CB60
	[BaseEntity.Menu.Description] // RVA: 0x8CB60 Offset: 0x8BF60 VA: 0x18008CB60
	[BaseEntity.Menu.Icon] // RVA: 0x8CB60 Offset: 0x8BF60 VA: 0x18008CB60
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CB60 Offset: 0x8BF60 VA: 0x18008CB60
	public virtual void Menu_Push(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SubmarineUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void TorpedoFired(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void TorpedoFireFailed(BaseEntity.RPCMessage msg) { }

	public ItemModGiveOxygen.AirSupplyType get_AirType() { }

	public VehicleEngineController.EngineState<BaseSubmarine> get_EngineState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Velocity(Vector3 value) { }

	public bool get_LightsAreOn() { }

	public bool get_HasAmmo() { }

	public float get_ThrottleInput() { }

	protected void set_ThrottleInput(float value) { }

	public float get_RudderInput() { }

	protected void set_RudderInput(float value) { }

	public float get_UpDownInput() { }

	protected void set_UpDownInput(float value) { }

	public float get_Oxygen() { }

	protected void set_Oxygen(float value) { }

	protected float get_PhysicalRudderAngle() { }

	protected bool get_IsInWater() { }

	protected bool get_IsSurfaced() { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public override float WaterFactorForPlayer(BasePlayer player) { }

	public override float AirFactor() { }

	public override bool BlocksWaterFor(BasePlayer player) { }

	public float GetFuelAmount() { }

	public float GetSpeed() { }

	public override bool CanBeLooted(BasePlayer player) { }

	public float GetAirTimeRemaining() { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	private void UpdatePhysicalRudder(float turnInput, float deltaTime) { }

	private bool CanMount(BasePlayer player) { }

	private void UpdateWaterInfo() { }

	private float GetWaterSurfaceY() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class BaseSubmarine.ParentTriggerInfo // TypeDefIndex: 8350
{	public TriggerParent trigger; // 0x10
	public Transform triggerWaterLevel; // 0x18


	public void .ctor() { }

}

