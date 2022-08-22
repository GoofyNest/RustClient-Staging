public class CoalingTower : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6438
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int lootTypeIndex; // 0x14
	public uint oreStorageID; // 0x18
	public uint fuelStorageID; // 0x1C
	public uint activeUnloadableID; // 0x20

	// Methods

	// RVA: 0x20ADC90 Offset: 0x20AC290 VA: 0x1820ADC90
	public static void ResetToPool(CoalingTower instance) { }

	// RVA: 0x20ADBF0 Offset: 0x20AC1F0 VA: 0x1820ADBF0
	public void ResetToPool() { }

	// RVA: 0x20AD8A0 Offset: 0x20ABEA0 VA: 0x1820AD8A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C072E0 Offset: 0x1C058E0 VA: 0x181C072E0
	public void CopyTo(CoalingTower instance) { }

	// RVA: 0x20AC710 Offset: 0x20AAD10 VA: 0x1820AC710
	public CoalingTower Copy() { }

	// RVA: 0x20AD650 Offset: 0x20ABC50 VA: 0x1820AD650
	public static CoalingTower Deserialize(Stream stream) { }

	// RVA: 0x20AC790 Offset: 0x20AAD90 VA: 0x1820AC790
	public static CoalingTower DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20ACDB0 Offset: 0x20AB3B0 VA: 0x1820ACDB0
	public static CoalingTower DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AD050 Offset: 0x20AB650 VA: 0x1820AD050
	public static CoalingTower Deserialize(byte[] buffer) { }

	// RVA: 0x20AD9C0 Offset: 0x20ABFC0 VA: 0x1820AD9C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AE260 Offset: 0x20AC860 VA: 0x1820AE260 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AE280 Offset: 0x20AC880 VA: 0x1820AE280 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CoalingTower previous) { }

	// RVA: 0x20ADBD0 Offset: 0x20AC1D0 VA: 0x1820ADBD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AD360 Offset: 0x20AB960 VA: 0x1820AD360
	public static CoalingTower Deserialize(byte[] buffer, CoalingTower instance, bool isDelta = False) { }

	// RVA: 0x20ACE40 Offset: 0x20AB440 VA: 0x1820ACE40
	public static CoalingTower Deserialize(Stream stream, CoalingTower instance, bool isDelta) { }

	// RVA: 0x20AC810 Offset: 0x20AAE10 VA: 0x1820AC810
	public static CoalingTower DeserializeLengthDelimited(Stream stream, CoalingTower instance, bool isDelta) { }

	// RVA: 0x20ACAF0 Offset: 0x20AB0F0 VA: 0x1820ACAF0
	public static CoalingTower DeserializeLength(Stream stream, int length, CoalingTower instance, bool isDelta) { }

	// RVA: 0x20ADD30 Offset: 0x20AC330 VA: 0x1820ADD30
	public static void SerializeDelta(Stream stream, CoalingTower instance, CoalingTower previous) { }

	// RVA: 0x20AE100 Offset: 0x20AC700 VA: 0x1820AE100
	public static void Serialize(Stream stream, CoalingTower instance) { }

	// RVA: 0x20AE250 Offset: 0x20AC850 VA: 0x1820AE250
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AE260 Offset: 0x20AC860 VA: 0x1820AE260
	public void ToProto(Stream stream) { }

	// RVA: 0x20ADFF0 Offset: 0x20AC5F0 VA: 0x1820ADFF0
	public static byte[] SerializeToBytes(CoalingTower instance) { }

	// RVA: 0x20ADF40 Offset: 0x20AC540 VA: 0x1820ADF40
	public static void SerializeLengthDelimited(Stream stream, CoalingTower instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class CoalingTower : IOEntity // TypeDefIndex: 8282
{	// Fields
	private static MaterialPropertyBlock materialPB; // 0x0
	private static int emissionColorID; // 0x8
	private static Color yellowLightOffColour; // 0xC
	private static Color greenLightOffColour; // 0x1C
	[HeaderAttribute] // RVA: 0xA7D50 Offset: 0xA7150 VA: 0x1800A7D50
	[SerializeField] // RVA: 0xA7D50 Offset: 0xA7150 VA: 0x1800A7D50
	private BoxCollider unloadingBounds; // 0x288
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef oreStoragePrefab; // 0x290
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef fuelStoragePrefab; // 0x298
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshRenderer[] signalLightsExterior; // 0x2A0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshRenderer[] signalLightsInterior; // 0x2A8
	[ColorUsageAttribute] // RVA: 0x768B0 Offset: 0x75CB0 VA: 0x1800768B0
	public Color greenLightOnColour; // 0x2B0
	[ColorUsageAttribute] // RVA: 0x768B0 Offset: 0x75CB0 VA: 0x1800768B0
	public Color yellowLightOnColour; // 0x2C0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Animator vacuumAnimator; // 0x2D0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float vacuumStartDelay; // 0x2D8
	[FormerlySerializedAsAttribute] // RVA: 0xA9580 Offset: 0xA8980 VA: 0x1800A9580
	[SerializeField] // RVA: 0xA9580 Offset: 0xA8980 VA: 0x1800A9580
	private ParticleSystemContainer unloadingFXContainerOre; // 0x2E0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem[] unloadingFXMain; // 0x2E8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem[] unloadingFXDust; // 0x2F0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemContainer unloadingFXContainerFuel; // 0x2F8
	[HeaderAttribute] // RVA: 0xA97F0 Offset: 0xA8BF0 VA: 0x1800A97F0
	[SerializeField] // RVA: 0xA97F0 Offset: 0xA8BF0 VA: 0x1800A97F0
	private TokenisedPhrase noTraincar; // 0x300
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TokenisedPhrase noNextTraincar; // 0x308
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TokenisedPhrase noPrevTraincar; // 0x310
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TokenisedPhrase trainIsMoving; // 0x318
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TokenisedPhrase outputIsFull; // 0x320
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TokenisedPhrase trainHasThrottle; // 0x328
	[HeaderAttribute] // RVA: 0xA9CE0 Offset: 0xA90E0 VA: 0x1800A9CE0
	[SerializeField] // RVA: 0xA9CE0 Offset: 0xA90E0 VA: 0x1800A9CE0
	private GameObject buttonSoundPos; // 0x330
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition buttonPressSound; // 0x338
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition buttonReleaseSound; // 0x340
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition failedActionSound; // 0x348
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition failedShuntAlarmSound; // 0x350
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition armMovementLower; // 0x358
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition armMovementRaise; // 0x360
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suctionAirStart; // 0x368
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suctionAirStop; // 0x370
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suctionAirLoop; // 0x378
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suctionOreStart; // 0x380
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suctionOreLoop; // 0x388
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suctionOreStop; // 0x390
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suctionOreInteriorLoop; // 0x398
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition oreBinLoop; // 0x3A0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suctionFluidStart; // 0x3A8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suctionFluidLoop; // 0x3B0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suctionFluidStop; // 0x3B8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition suctionFluidInteriorLoop; // 0x3C0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition fluidTankLoop; // 0x3C8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject interiorPipeSoundLocation; // 0x3D0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject armMovementSoundLocation; // 0x3D8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject armSuctionSoundLocation; // 0x3E0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject oreBinSoundLocation; // 0x3E8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// Properties
	private bool HasTrainCar { get; }
	private bool HasUnloadable { get; }
	private bool HasUnloadableLinedUp { get; }
	public Vector3 UnloadingPos { get; set; }
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x575940 Offset: 0x573F40 VA: 0x180575940 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x577780 Offset: 0x575D80 VA: 0x180577780 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x578580 Offset: 0x576B80 VA: 0x180578580
	public void RefreshSignalLights() { }

	// RVA: 0x578780 Offset: 0x576D80 VA: 0x180578780
	private void SetSignalLightRenderer(MeshRenderer renderer, bool hasTrainCar, bool hasUnloadable, bool hasUnloadableLinedUp) { }

	// RVA: 0x5784C0 Offset: 0x576AC0 VA: 0x1805784C0
	public void PlayButtonPressSound() { }

	// RVA: 0x578500 Offset: 0x576B00 VA: 0x180578500
	public void PlayButtonReleaseSound() { }

	// RVA: 0x578540 Offset: 0x576B40 VA: 0x180578540
	public void PlayFailedActionSound() { }

	// RVA: 0x576EB0 Offset: 0x5754B0 VA: 0x180576EB0
	public void PlayFailedShuntAlarmSound() { }

	// RVA: 0x578AE0 Offset: 0x5770E0 VA: 0x180578AE0
	private void StartSounds() { }

	// RVA: 0x578B90 Offset: 0x577190 VA: 0x180578B90
	private void StartSuctionSounds() { }

	// RVA: 0x579000 Offset: 0x577600 VA: 0x180579000
	private void StopSounds() { }

	// RVA: 0x576A10 Offset: 0x575010 VA: 0x180576A10
	private bool IsLookingAtControls(BasePlayer player) { }

	// RVA: 0x576B10 Offset: 0x575110 VA: 0x180576B10
	private bool IsLookingAtUnload(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAACB0 Offset: 0xAA0B0 VA: 0x1800AACB0
	[BaseEntity.Menu.Description] // RVA: 0xAACB0 Offset: 0xAA0B0 VA: 0x1800AACB0
	[BaseEntity.Menu.Icon] // RVA: 0xAACB0 Offset: 0xAA0B0 VA: 0x1800AACB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAACB0 Offset: 0xAA0B0 VA: 0x1800AACB0
	// RVA: 0x577740 Offset: 0x575D40 VA: 0x180577740
	public void Menu_Unload(BasePlayer player) { }

	// RVA: 0x577690 Offset: 0x575C90 VA: 0x180577690
	public bool Menu_Unload_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAAFD0 Offset: 0xAA3D0 VA: 0x1800AAFD0
	[BaseEntity.Menu.Description] // RVA: 0xAAFD0 Offset: 0xAA3D0 VA: 0x1800AAFD0
	[BaseEntity.Menu.Icon] // RVA: 0xAAFD0 Offset: 0xAA3D0 VA: 0x1800AAFD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAAFD0 Offset: 0xAA3D0 VA: 0x1800AAFD0
	// RVA: 0x577370 Offset: 0x575970 VA: 0x180577370
	public void Menu_Next(BasePlayer player) { }

	// RVA: 0x577250 Offset: 0x575850 VA: 0x180577250
	public bool Menu_Next_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB370 Offset: 0xAA770 VA: 0x1800AB370
	[BaseEntity.Menu.Description] // RVA: 0xAB370 Offset: 0xAA770 VA: 0x1800AB370
	[BaseEntity.Menu.Icon] // RVA: 0xAB370 Offset: 0xAA770 VA: 0x1800AB370
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB370 Offset: 0xAA770 VA: 0x1800AB370
	// RVA: 0x5774D0 Offset: 0x575AD0 VA: 0x1805774D0
	public void Menu_Prev(BasePlayer player) { }

	// RVA: 0x5773B0 Offset: 0x5759B0 VA: 0x1805773B0
	public bool Menu_Prev_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB6E0 Offset: 0xAAAE0 VA: 0x1800AB6E0
	[BaseEntity.Menu.Description] // RVA: 0xAB6E0 Offset: 0xAAAE0 VA: 0x1800AB6E0
	[BaseEntity.Menu.Icon] // RVA: 0xAB6E0 Offset: 0xAAAE0 VA: 0x1800AB6E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB6E0 Offset: 0xAAAE0 VA: 0x1800AB6E0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Unavailable(BasePlayer player) { }

	// RVA: 0x577510 Offset: 0x575B10 VA: 0x180577510
	public bool Menu_Unavailable_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB8D0 Offset: 0xAACD0 VA: 0x1800AB8D0
	[BaseEntity.Menu.Description] // RVA: 0xAB8D0 Offset: 0xAACD0 VA: 0x1800AB8D0
	[BaseEntity.Menu.Icon] // RVA: 0xAB8D0 Offset: 0xAACD0 VA: 0x1800AB8D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB8D0 Offset: 0xAACD0 VA: 0x1800AB8D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_BinFull(BasePlayer player) { }

	// RVA: 0x5771E0 Offset: 0x5757E0 VA: 0x1805771E0
	public bool Menu_BinFull_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x575680 Offset: 0x573C80 VA: 0x180575680
	private void ActionFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x576EB0 Offset: 0x5754B0 VA: 0x180576EB0
	private void IssueDuringShunt(BaseEntity.RPCMessage msg) { }

	// RVA: 0x579970 Offset: 0x577F70 VA: 0x180579970
	private bool get_HasTrainCar() { }

	// RVA: 0x5799D0 Offset: 0x577FD0 VA: 0x1805799D0
	private bool get_HasUnloadable() { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0
	private bool get_HasUnloadableLinedUp() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x579A20 Offset: 0x578020 VA: 0x180579A20
	public Vector3 get_UnloadingPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x579A40 Offset: 0x578040 VA: 0x180579A40
	private void set_UnloadingPos(Vector3 value) { }

	// RVA: 0x5767E0 Offset: 0x574DE0 VA: 0x1805767E0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x575990 Offset: 0x573F90 VA: 0x180575990 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x576EF0 Offset: 0x5754F0 VA: 0x180576EF0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x576BC0 Offset: 0x5751C0 VA: 0x180576BC0
	public static bool IsUnderAnUnloader(TrainCar trainCar, out bool isLinedUp, out Vector3 unloaderPos) { }

	// RVA: 0x579360 Offset: 0x577960 VA: 0x180579360
	public bool TrainCarIsUnder(TrainCar trainCar, out bool isLinedUp) { }

	// RVA: 0x576770 Offset: 0x574D70 VA: 0x180576770
	private OreHopper GetOreStorage() { }

	// RVA: 0x575AF0 Offset: 0x5740F0 VA: 0x180575AF0
	private PercentFullStorageContainer GetFuelStorage() { }

	// RVA: 0x575A10 Offset: 0x574010 VA: 0x180575A10
	private TrainCar GetActiveTrainCar() { }

	// RVA: 0x575A80 Offset: 0x574080 VA: 0x180575A80
	private TrainCarUnloadable GetActiveUnloadable() { }

	// RVA: 0x578320 Offset: 0x576920 VA: 0x180578320
	private bool OutputBinIsFull() { }

	// RVA: 0x579480 Offset: 0x577A80 VA: 0x180579480
	private bool WagonIsEmpty() { }

	// RVA: 0x5758C0 Offset: 0x573EC0 VA: 0x1805758C0
	private bool CanUnloadNow(out CoalingTower.ActionAttemptStatus attemptStatus) { }

	// RVA: 0x575B60 Offset: 0x574160 VA: 0x180575B60 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x579640 Offset: 0x577C40 VA: 0x180579640 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x577BA0 Offset: 0x5761A0 VA: 0x180577BA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5795E0 Offset: 0x577BE0 VA: 0x1805795E0
	public void .ctor() { }

	// RVA: 0x579560 Offset: 0x577B60 VA: 0x180579560
	private static void .cctor() { }

}

public enum CoalingTower.ActionAttemptStatus // TypeDefIndex: 8283
{	// Fields
	public int value__; // 0x0
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

