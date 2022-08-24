public class CoalingTower : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6438
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int lootTypeIndex; // 0x14
	public uint oreStorageID; // 0x18
	public uint fuelStorageID; // 0x1C
	public uint activeUnloadableID; // 0x20


	public static void ResetToPool(CoalingTower instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CoalingTower instance) { }

	public CoalingTower Copy() { }

	public static CoalingTower Deserialize(Stream stream) { }

	public static CoalingTower DeserializeLengthDelimited(Stream stream) { }

	public static CoalingTower DeserializeLength(Stream stream, int length) { }

	public static CoalingTower Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CoalingTower previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CoalingTower Deserialize(byte[] buffer, CoalingTower instance, bool isDelta = False) { }

	public static CoalingTower Deserialize(Stream stream, CoalingTower instance, bool isDelta) { }

	public static CoalingTower DeserializeLengthDelimited(Stream stream, CoalingTower instance, bool isDelta) { }

	public static CoalingTower DeserializeLength(Stream stream, int length, CoalingTower instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CoalingTower instance, CoalingTower previous) { }

	public static void Serialize(Stream stream, CoalingTower instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CoalingTower instance) { }

	public static void SerializeLengthDelimited(Stream stream, CoalingTower instance) { }

	public void .ctor() { }

}

public class CoalingTower : IOEntity // TypeDefIndex: 8282
{	private static MaterialPropertyBlock materialPB; // 0x0
	private static int emissionColorID; // 0x8
	private static Color yellowLightOffColour; // 0xC
	private static Color greenLightOffColour; // 0x1C
	[HeaderAttribute] // RVA: 0xA7E00 Offset: 0xA7200 VA: 0x1800A7E00
	[SerializeField] // RVA: 0xA7E00 Offset: 0xA7200 VA: 0x1800A7E00
	private BoxCollider unloadingBounds; // 0x288
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObjectRef oreStoragePrefab; // 0x290
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObjectRef fuelStoragePrefab; // 0x298
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private MeshRenderer[] signalLightsExterior; // 0x2A0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private MeshRenderer[] signalLightsInterior; // 0x2A8
	[ColorUsageAttribute] // RVA: 0x76B60 Offset: 0x75F60 VA: 0x180076B60
	public Color greenLightOnColour; // 0x2B0
	[ColorUsageAttribute] // RVA: 0x76B60 Offset: 0x75F60 VA: 0x180076B60
	public Color yellowLightOnColour; // 0x2C0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Animator vacuumAnimator; // 0x2D0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float vacuumStartDelay; // 0x2D8
	[FormerlySerializedAsAttribute] // RVA: 0xA9660 Offset: 0xA8A60 VA: 0x1800A9660
	[SerializeField] // RVA: 0xA9660 Offset: 0xA8A60 VA: 0x1800A9660
	private ParticleSystemContainer unloadingFXContainerOre; // 0x2E0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem[] unloadingFXMain; // 0x2E8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem[] unloadingFXDust; // 0x2F0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystemContainer unloadingFXContainerFuel; // 0x2F8
	[HeaderAttribute] // RVA: 0xA98D0 Offset: 0xA8CD0 VA: 0x1800A98D0
	[SerializeField] // RVA: 0xA98D0 Offset: 0xA8CD0 VA: 0x1800A98D0
	private TokenisedPhrase noTraincar; // 0x300
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TokenisedPhrase noNextTraincar; // 0x308
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TokenisedPhrase noPrevTraincar; // 0x310
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TokenisedPhrase trainIsMoving; // 0x318
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TokenisedPhrase outputIsFull; // 0x320
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TokenisedPhrase trainHasThrottle; // 0x328
	[HeaderAttribute] // RVA: 0xA9D80 Offset: 0xA9180 VA: 0x1800A9D80
	[SerializeField] // RVA: 0xA9D80 Offset: 0xA9180 VA: 0x1800A9D80
	private GameObject buttonSoundPos; // 0x330
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition buttonPressSound; // 0x338
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition buttonReleaseSound; // 0x340
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition failedActionSound; // 0x348
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition failedShuntAlarmSound; // 0x350
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition armMovementLower; // 0x358
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition armMovementRaise; // 0x360
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suctionAirStart; // 0x368
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suctionAirStop; // 0x370
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suctionAirLoop; // 0x378
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suctionOreStart; // 0x380
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suctionOreLoop; // 0x388
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suctionOreStop; // 0x390
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suctionOreInteriorLoop; // 0x398
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition oreBinLoop; // 0x3A0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suctionFluidStart; // 0x3A8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suctionFluidLoop; // 0x3B0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suctionFluidStop; // 0x3B8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition suctionFluidInteriorLoop; // 0x3C0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SoundDefinition fluidTankLoop; // 0x3C8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObject interiorPipeSoundLocation; // 0x3D0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObject armMovementSoundLocation; // 0x3D8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObject armSuctionSoundLocation; // 0x3E0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObject oreBinSoundLocation; // 0x3E8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObject fluidTankSoundLocation; // 0x3F0
	private NetworkedProperty<int> LootTypeIndex; // 0x3F8
	private EntityRef<TrainCar> activeTrainCarRef; // 0x400
	private EntityRef<TrainCarUnloadable> activeUnloadableRef; // 0x410
	private const BaseEntity.Flags LinedUpFlag = 256;
	private const BaseEntity.Flags HasUnloadableFlag = 128;
	private const BaseEntity.Flags UnloadingInProgressFlag = 8192;
	private const BaseEntity.Flags MoveToNextInProgressFlag = 512;
	private const BaseEntity.Flags MoveToPrevInProgressFlag = 1024;
	private EntityRef<OreHopper> oreStorageInstance; // 0x420
	private EntityRef<PercentFullStorageContainer> fuelStorageInstance; // 0x430
	public const float TIME_TO_EMPTY = 40;
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Vector3 <UnloadingPos>k__BackingField; // 0x440
	private static List<CoalingTower> unloadersInWorld; // 0x30
	private Sound armMovementLoopSound; // 0x450
	private Sound suctionAirLoopSound; // 0x458
	private Sound suctionMaterialLoopSound; // 0x460
	private Sound interiorPipeLoopSound; // 0x468
	private Sound unloadDestinationSound; // 0x470
	private Option __menuOption_Menu_BinFull; // 0x478
	private Option __menuOption_Menu_Next; // 0x4D0
	private Option __menuOption_Menu_Prev; // 0x528
	private Option __menuOption_Menu_Unavailable; // 0x580
	private Option __menuOption_Menu_Unload; // 0x5D8

	private bool HasTrainCar { get; }
	private bool HasUnloadable { get; }
	private bool HasUnloadableLinedUp { get; }
	public Vector3 UnloadingPos { get; set; }
	public override bool HasMenuOptions { get; }


	public override void ClientOnEnable() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void RefreshSignalLights() { }

	private void SetSignalLightRenderer(MeshRenderer renderer, bool hasTrainCar, bool hasUnloadable, bool hasUnloadableLinedUp) { }

	public void PlayButtonPressSound() { }

	public void PlayButtonReleaseSound() { }

	public void PlayFailedActionSound() { }

	public void PlayFailedShuntAlarmSound() { }

	private void StartSounds() { }

	private void StartSuctionSounds() { }

	private void StopSounds() { }

	private bool IsLookingAtControls(BasePlayer player) { }

	private bool IsLookingAtUnload(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAAD80 Offset: 0xAA180 VA: 0x1800AAD80
	[BaseEntity.Menu.Description] // RVA: 0xAAD80 Offset: 0xAA180 VA: 0x1800AAD80
	[BaseEntity.Menu.Icon] // RVA: 0xAAD80 Offset: 0xAA180 VA: 0x1800AAD80
	[BaseEntity.Menu.ShowIf] // RVA: 0xAAD80 Offset: 0xAA180 VA: 0x1800AAD80
	public void Menu_Unload(BasePlayer player) { }

	public bool Menu_Unload_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB0A0 Offset: 0xAA4A0 VA: 0x1800AB0A0
	[BaseEntity.Menu.Description] // RVA: 0xAB0A0 Offset: 0xAA4A0 VA: 0x1800AB0A0
	[BaseEntity.Menu.Icon] // RVA: 0xAB0A0 Offset: 0xAA4A0 VA: 0x1800AB0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB0A0 Offset: 0xAA4A0 VA: 0x1800AB0A0
	public void Menu_Next(BasePlayer player) { }

	public bool Menu_Next_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB440 Offset: 0xAA840 VA: 0x1800AB440
	[BaseEntity.Menu.Description] // RVA: 0xAB440 Offset: 0xAA840 VA: 0x1800AB440
	[BaseEntity.Menu.Icon] // RVA: 0xAB440 Offset: 0xAA840 VA: 0x1800AB440
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB440 Offset: 0xAA840 VA: 0x1800AB440
	public void Menu_Prev(BasePlayer player) { }

	public bool Menu_Prev_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB7C0 Offset: 0xAABC0 VA: 0x1800AB7C0
	[BaseEntity.Menu.Description] // RVA: 0xAB7C0 Offset: 0xAABC0 VA: 0x1800AB7C0
	[BaseEntity.Menu.Icon] // RVA: 0xAB7C0 Offset: 0xAABC0 VA: 0x1800AB7C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB7C0 Offset: 0xAABC0 VA: 0x1800AB7C0
	public void Menu_Unavailable(BasePlayer player) { }

	public bool Menu_Unavailable_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB9E0 Offset: 0xAADE0 VA: 0x1800AB9E0
	[BaseEntity.Menu.Description] // RVA: 0xAB9E0 Offset: 0xAADE0 VA: 0x1800AB9E0
	[BaseEntity.Menu.Icon] // RVA: 0xAB9E0 Offset: 0xAADE0 VA: 0x1800AB9E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB9E0 Offset: 0xAADE0 VA: 0x1800AB9E0
	public void Menu_BinFull(BasePlayer player) { }

	public bool Menu_BinFull_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void ActionFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void IssueDuringShunt(BaseEntity.RPCMessage msg) { }

	private bool get_HasTrainCar() { }

	private bool get_HasUnloadable() { }

	private bool get_HasUnloadableLinedUp() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Vector3 get_UnloadingPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_UnloadingPos(Vector3 value) { }

	public override void InitShared() { }

	public override void DestroyShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public static bool IsUnderAnUnloader(TrainCar trainCar, out bool isLinedUp, out Vector3 unloaderPos) { }

	public bool TrainCarIsUnder(TrainCar trainCar, out bool isLinedUp) { }

	private OreHopper GetOreStorage() { }

	private PercentFullStorageContainer GetFuelStorage() { }

	private TrainCar GetActiveTrainCar() { }

	private TrainCarUnloadable GetActiveUnloadable() { }

	private bool OutputBinIsFull() { }

	private bool WagonIsEmpty() { }

	private bool CanUnloadNow(out CoalingTower.ActionAttemptStatus attemptStatus) { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum CoalingTower.ActionAttemptStatus // TypeDefIndex: 8283
{	public int value__; // 0x0
	public const CoalingTower.ActionAttemptStatus NoError = 0;
	public const CoalingTower.ActionAttemptStatus GenericError = 1;
	public const CoalingTower.ActionAttemptStatus NoTrainCar = 2;
	public const CoalingTower.ActionAttemptStatus NoNextTrainCar = 3;
	public const CoalingTower.ActionAttemptStatus NoPrevTrainCar = 4;
	public const CoalingTower.ActionAttemptStatus TrainIsMoving = 5;
	public const CoalingTower.ActionAttemptStatus OutputIsFull = 6;
	public const CoalingTower.ActionAttemptStatus AlreadyShunting = 7;
	public const CoalingTower.ActionAttemptStatus TrainHasThrottle = 8;

}

