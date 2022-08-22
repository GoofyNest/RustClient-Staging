public class CoalingTower : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6438
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int lootTypeIndex; // 0x14
	public uint oreStorageID; // 0x18
	public uint fuelStorageID; // 0x1C
	public uint activeUnloadableID; // 0x20

	// Methods

	// RVA: 0x20AE4B0 Offset: 0x20ACAB0 VA: 0x1820AE4B0
	public static void ResetToPool(CoalingTower instance) { }

	// RVA: 0x20AE410 Offset: 0x20ACA10 VA: 0x1820AE410
	public void ResetToPool() { }

	// RVA: 0x20AE0C0 Offset: 0x20AC6C0 VA: 0x1820AE0C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C07AD0 Offset: 0x1C060D0 VA: 0x181C07AD0
	public void CopyTo(CoalingTower instance) { }

	// RVA: 0x20ACF30 Offset: 0x20AB530 VA: 0x1820ACF30
	public CoalingTower Copy() { }

	// RVA: 0x20ADE70 Offset: 0x20AC470 VA: 0x1820ADE70
	public static CoalingTower Deserialize(Stream stream) { }

	// RVA: 0x20ACFB0 Offset: 0x20AB5B0 VA: 0x1820ACFB0
	public static CoalingTower DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AD5D0 Offset: 0x20ABBD0 VA: 0x1820AD5D0
	public static CoalingTower DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AD870 Offset: 0x20ABE70 VA: 0x1820AD870
	public static CoalingTower Deserialize(byte[] buffer) { }

	// RVA: 0x20AE1E0 Offset: 0x20AC7E0 VA: 0x1820AE1E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AEA80 Offset: 0x20AD080 VA: 0x1820AEA80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AEAA0 Offset: 0x20AD0A0 VA: 0x1820AEAA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CoalingTower previous) { }

	// RVA: 0x20AE3F0 Offset: 0x20AC9F0 VA: 0x1820AE3F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20ADB80 Offset: 0x20AC180 VA: 0x1820ADB80
	public static CoalingTower Deserialize(byte[] buffer, CoalingTower instance, bool isDelta = False) { }

	// RVA: 0x20AD660 Offset: 0x20ABC60 VA: 0x1820AD660
	public static CoalingTower Deserialize(Stream stream, CoalingTower instance, bool isDelta) { }

	// RVA: 0x20AD030 Offset: 0x20AB630 VA: 0x1820AD030
	public static CoalingTower DeserializeLengthDelimited(Stream stream, CoalingTower instance, bool isDelta) { }

	// RVA: 0x20AD310 Offset: 0x20AB910 VA: 0x1820AD310
	public static CoalingTower DeserializeLength(Stream stream, int length, CoalingTower instance, bool isDelta) { }

	// RVA: 0x20AE550 Offset: 0x20ACB50 VA: 0x1820AE550
	public static void SerializeDelta(Stream stream, CoalingTower instance, CoalingTower previous) { }

	// RVA: 0x20AE920 Offset: 0x20ACF20 VA: 0x1820AE920
	public static void Serialize(Stream stream, CoalingTower instance) { }

	// RVA: 0x20AEA70 Offset: 0x20AD070 VA: 0x1820AEA70
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AEA80 Offset: 0x20AD080 VA: 0x1820AEA80
	public void ToProto(Stream stream) { }

	// RVA: 0x20AE810 Offset: 0x20ACE10 VA: 0x1820AE810
	public static byte[] SerializeToBytes(CoalingTower instance) { }

	// RVA: 0x20AE760 Offset: 0x20ACD60 VA: 0x1820AE760
	public static void SerializeLengthDelimited(Stream stream, CoalingTower instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x5758D0 Offset: 0x573ED0 VA: 0x1805758D0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x577710 Offset: 0x575D10 VA: 0x180577710 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x578510 Offset: 0x576B10 VA: 0x180578510
	public void RefreshSignalLights() { }

	// RVA: 0x578710 Offset: 0x576D10 VA: 0x180578710
	private void SetSignalLightRenderer(MeshRenderer renderer, bool hasTrainCar, bool hasUnloadable, bool hasUnloadableLinedUp) { }

	// RVA: 0x578450 Offset: 0x576A50 VA: 0x180578450
	public void PlayButtonPressSound() { }

	// RVA: 0x578490 Offset: 0x576A90 VA: 0x180578490
	public void PlayButtonReleaseSound() { }

	// RVA: 0x5784D0 Offset: 0x576AD0 VA: 0x1805784D0
	public void PlayFailedActionSound() { }

	// RVA: 0x576E40 Offset: 0x575440 VA: 0x180576E40
	public void PlayFailedShuntAlarmSound() { }

	// RVA: 0x578A70 Offset: 0x577070 VA: 0x180578A70
	private void StartSounds() { }

	// RVA: 0x578B20 Offset: 0x577120 VA: 0x180578B20
	private void StartSuctionSounds() { }

	// RVA: 0x578F90 Offset: 0x577590 VA: 0x180578F90
	private void StopSounds() { }

	// RVA: 0x5769A0 Offset: 0x574FA0 VA: 0x1805769A0
	private bool IsLookingAtControls(BasePlayer player) { }

	// RVA: 0x576AA0 Offset: 0x5750A0 VA: 0x180576AA0
	private bool IsLookingAtUnload(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAACB0 Offset: 0xAA0B0 VA: 0x1800AACB0
	[BaseEntity.Menu.Description] // RVA: 0xAACB0 Offset: 0xAA0B0 VA: 0x1800AACB0
	[BaseEntity.Menu.Icon] // RVA: 0xAACB0 Offset: 0xAA0B0 VA: 0x1800AACB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAACB0 Offset: 0xAA0B0 VA: 0x1800AACB0
	// RVA: 0x5776D0 Offset: 0x575CD0 VA: 0x1805776D0
	public void Menu_Unload(BasePlayer player) { }

	// RVA: 0x577620 Offset: 0x575C20 VA: 0x180577620
	public bool Menu_Unload_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAAFD0 Offset: 0xAA3D0 VA: 0x1800AAFD0
	[BaseEntity.Menu.Description] // RVA: 0xAAFD0 Offset: 0xAA3D0 VA: 0x1800AAFD0
	[BaseEntity.Menu.Icon] // RVA: 0xAAFD0 Offset: 0xAA3D0 VA: 0x1800AAFD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAAFD0 Offset: 0xAA3D0 VA: 0x1800AAFD0
	// RVA: 0x577300 Offset: 0x575900 VA: 0x180577300
	public void Menu_Next(BasePlayer player) { }

	// RVA: 0x5771E0 Offset: 0x5757E0 VA: 0x1805771E0
	public bool Menu_Next_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB370 Offset: 0xAA770 VA: 0x1800AB370
	[BaseEntity.Menu.Description] // RVA: 0xAB370 Offset: 0xAA770 VA: 0x1800AB370
	[BaseEntity.Menu.Icon] // RVA: 0xAB370 Offset: 0xAA770 VA: 0x1800AB370
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB370 Offset: 0xAA770 VA: 0x1800AB370
	// RVA: 0x577460 Offset: 0x575A60 VA: 0x180577460
	public void Menu_Prev(BasePlayer player) { }

	// RVA: 0x577340 Offset: 0x575940 VA: 0x180577340
	public bool Menu_Prev_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB6E0 Offset: 0xAAAE0 VA: 0x1800AB6E0
	[BaseEntity.Menu.Description] // RVA: 0xAB6E0 Offset: 0xAAAE0 VA: 0x1800AB6E0
	[BaseEntity.Menu.Icon] // RVA: 0xAB6E0 Offset: 0xAAAE0 VA: 0x1800AB6E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB6E0 Offset: 0xAAAE0 VA: 0x1800AB6E0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Unavailable(BasePlayer player) { }

	// RVA: 0x5774A0 Offset: 0x575AA0 VA: 0x1805774A0
	public bool Menu_Unavailable_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB8D0 Offset: 0xAACD0 VA: 0x1800AB8D0
	[BaseEntity.Menu.Description] // RVA: 0xAB8D0 Offset: 0xAACD0 VA: 0x1800AB8D0
	[BaseEntity.Menu.Icon] // RVA: 0xAB8D0 Offset: 0xAACD0 VA: 0x1800AB8D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB8D0 Offset: 0xAACD0 VA: 0x1800AB8D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_BinFull(BasePlayer player) { }

	// RVA: 0x577170 Offset: 0x575770 VA: 0x180577170
	public bool Menu_BinFull_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x575610 Offset: 0x573C10 VA: 0x180575610
	private void ActionFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x576E40 Offset: 0x575440 VA: 0x180576E40
	private void IssueDuringShunt(BaseEntity.RPCMessage msg) { }

	// RVA: 0x579900 Offset: 0x577F00 VA: 0x180579900
	private bool get_HasTrainCar() { }

	// RVA: 0x579960 Offset: 0x577F60 VA: 0x180579960
	private bool get_HasUnloadable() { }

	// RVA: 0x579950 Offset: 0x577F50 VA: 0x180579950
	private bool get_HasUnloadableLinedUp() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5799B0 Offset: 0x577FB0 VA: 0x1805799B0
	public Vector3 get_UnloadingPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5799D0 Offset: 0x577FD0 VA: 0x1805799D0
	private void set_UnloadingPos(Vector3 value) { }

	// RVA: 0x576770 Offset: 0x574D70 VA: 0x180576770 Slot: 28
	public override void InitShared() { }

	// RVA: 0x575920 Offset: 0x573F20 VA: 0x180575920 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x576E80 Offset: 0x575480 VA: 0x180576E80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x576B50 Offset: 0x575150 VA: 0x180576B50
	public static bool IsUnderAnUnloader(TrainCar trainCar, out bool isLinedUp, out Vector3 unloaderPos) { }

	// RVA: 0x5792F0 Offset: 0x5778F0 VA: 0x1805792F0
	public bool TrainCarIsUnder(TrainCar trainCar, out bool isLinedUp) { }

	// RVA: 0x576700 Offset: 0x574D00 VA: 0x180576700
	private OreHopper GetOreStorage() { }

	// RVA: 0x575A80 Offset: 0x574080 VA: 0x180575A80
	private PercentFullStorageContainer GetFuelStorage() { }

	// RVA: 0x5759A0 Offset: 0x573FA0 VA: 0x1805759A0
	private TrainCar GetActiveTrainCar() { }

	// RVA: 0x575A10 Offset: 0x574010 VA: 0x180575A10
	private TrainCarUnloadable GetActiveUnloadable() { }

	// RVA: 0x5782B0 Offset: 0x5768B0 VA: 0x1805782B0
	private bool OutputBinIsFull() { }

	// RVA: 0x579410 Offset: 0x577A10 VA: 0x180579410
	private bool WagonIsEmpty() { }

	// RVA: 0x575850 Offset: 0x573E50 VA: 0x180575850
	private bool CanUnloadNow(out CoalingTower.ActionAttemptStatus attemptStatus) { }

	// RVA: 0x575AF0 Offset: 0x5740F0 VA: 0x180575AF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5795D0 Offset: 0x577BD0 VA: 0x1805795D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x577B30 Offset: 0x576130 VA: 0x180577B30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x579570 Offset: 0x577B70 VA: 0x180579570
	public void .ctor() { }

	// RVA: 0x5794F0 Offset: 0x577AF0 VA: 0x1805794F0
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

