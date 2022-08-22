public class Elevator : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6387
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int floor; // 0x14

	// Methods

	// RVA: 0x1E73760 Offset: 0x1E71D60 VA: 0x181E73760
	public static void ResetToPool(Elevator instance) { }

	// RVA: 0x1E737E0 Offset: 0x1E71DE0 VA: 0x181E737E0
	public void ResetToPool() { }

	// RVA: 0x1E73630 Offset: 0x1E71C30 VA: 0x181E73630 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(Elevator instance) { }

	// RVA: 0x1E72CB0 Offset: 0x1E712B0 VA: 0x181E72CB0
	public Elevator Copy() { }

	// RVA: 0x1E73250 Offset: 0x1E71850 VA: 0x181E73250
	public static Elevator Deserialize(Stream stream) { }

	// RVA: 0x1E72F40 Offset: 0x1E71540 VA: 0x181E72F40
	public static Elevator DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E731C0 Offset: 0x1E717C0 VA: 0x181E731C0
	public static Elevator DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E732D0 Offset: 0x1E718D0 VA: 0x181E732D0
	public static Elevator Deserialize(byte[] buffer) { }

	// RVA: 0x1E73720 Offset: 0x1E71D20 VA: 0x181E73720
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E73CB0 Offset: 0x1E722B0 VA: 0x181E73CB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E73D80 Offset: 0x1E72380 VA: 0x181E73D80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Elevator previous) { }

	// RVA: 0x1E73740 Offset: 0x1E71D40 VA: 0x181E73740 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E733F0 Offset: 0x1E719F0 VA: 0x181E733F0
	public static Elevator Deserialize(byte[] buffer, Elevator instance, bool isDelta = False) { }

	// RVA: 0x1E734F0 Offset: 0x1E71AF0 VA: 0x181E734F0
	public static Elevator Deserialize(Stream stream, Elevator instance, bool isDelta) { }

	// RVA: 0x1E72D20 Offset: 0x1E71320 VA: 0x181E72D20
	public static Elevator DeserializeLengthDelimited(Stream stream, Elevator instance, bool isDelta) { }

	// RVA: 0x1E72FC0 Offset: 0x1E715C0 VA: 0x181E72FC0
	public static Elevator DeserializeLength(Stream stream, int length, Elevator instance, bool isDelta) { }

	// RVA: 0x1E73860 Offset: 0x1E71E60 VA: 0x181E73860
	public static void SerializeDelta(Stream stream, Elevator instance, Elevator previous) { }

	// RVA: 0x1E73BD0 Offset: 0x1E721D0 VA: 0x181E73BD0
	public static void Serialize(Stream stream, Elevator instance) { }

	// RVA: 0x1E73CA0 Offset: 0x1E722A0 VA: 0x181E73CA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E73CB0 Offset: 0x1E722B0 VA: 0x181E73CB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E73A20 Offset: 0x1E72020 VA: 0x181E73A20
	public static byte[] SerializeToBytes(Elevator instance) { }

	// RVA: 0x1E73970 Offset: 0x1E71F70 VA: 0x181E73970
	public static void SerializeLengthDelimited(Stream stream, Elevator instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ElevatorLift : BaseCombatEntity // TypeDefIndex: 8387
{	// Fields
	private Option __menuOption_Menu_LowerElevator; // 0x240
	private Option __menuOption_Menu_LowerElevatorToFloor; // 0x298
	private Option __menuOption_Menu_RaiseElevator; // 0x2F0
	private Option __menuOption_Menu_RaiseElevatorToTop; // 0x348
	public GameObject DescendingHurtTrigger; // 0x3A0
	public GameObject MovementCollider; // 0x3A8
	public Transform UpButtonPoint; // 0x3B0
	public Transform DownButtonPoint; // 0x3B8
	public TriggerNotify VehicleTrigger; // 0x3C0
	public GameObjectRef LiftArrivalScreenBounce; // 0x3C8
	public SoundDefinition liftMovementLoopDef; // 0x3D0
	public SoundDefinition liftMovementStartDef; // 0x3D8
	public SoundDefinition liftMovementStopDef; // 0x3E0
	public SoundDefinition liftMovementAccentSoundDef; // 0x3E8
	public GameObjectRef liftButtonPressedEffect; // 0x3F0
	public float movementAccentMinInterval; // 0x3F8
	public float movementAccentMaxInterval; // 0x3FC
	private Sound liftMovementLoopSound; // 0x400
	private float nextMovementAccent; // 0x408
	private const BaseEntity.Flags PressedUp = 128;
	private const BaseEntity.Flags PressedDown = 256;

	// Properties
	public override bool HasMenuOptions { get; }
	private Elevator owner { get; }

	// Methods

	// RVA: 0xAC2D30 Offset: 0xAC1330 VA: 0x180AC2D30 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC4260 Offset: 0xAC2860 VA: 0x180AC4260 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAC3980 Offset: 0xAC1F80 VA: 0x180AC3980 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAC4430 Offset: 0xAC2A30 VA: 0x180AC4430
	private Elevator get_owner() { }

	[BaseEntity.Menu] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	[BaseEntity.Menu.Description] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	[BaseEntity.Menu.Icon] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	// RVA: 0xAC3930 Offset: 0xAC1F30 VA: 0x180AC3930
	public void Menu_RaiseElevator(BasePlayer p) { }

	// RVA: 0xAC3890 Offset: 0xAC1E90 VA: 0x180AC3890
	protected bool Menu_RaiseElevator_ShowIf(BasePlayer p) { }

	// RVA: 0xAC3880 Offset: 0xAC1E80 VA: 0x180AC3880 Slot: 145
	protected virtual bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	[BaseEntity.Menu.Description] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	[BaseEntity.Menu.Icon] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	// RVA: 0xAC3830 Offset: 0xAC1E30 VA: 0x180AC3830
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	[BaseEntity.Menu.Description] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	[BaseEntity.Menu.Icon] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	// RVA: 0xAC37E0 Offset: 0xAC1DE0 VA: 0x180AC37E0
	public void Menu_LowerElevator(BasePlayer p) { }

	// RVA: 0xAC3740 Offset: 0xAC1D40 VA: 0x180AC3740
	protected bool Menu_LowerElevator_ShowIf(BasePlayer p) { }

	// RVA: 0xAC3730 Offset: 0xAC1D30 VA: 0x180AC3730 Slot: 146
	protected virtual bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	[BaseEntity.Menu.Description] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	[BaseEntity.Menu.Icon] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	// RVA: 0xAC36E0 Offset: 0xAC1CE0 VA: 0x180AC36E0
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	// RVA: 0xAC2BA0 Offset: 0xAC11A0 VA: 0x180AC2BA0
	protected bool GetLookingAtButton(BasePlayer p, out Elevator.Direction d) { }

	// RVA: 0xAC3A70 Offset: 0xAC2070 VA: 0x180AC3A70
	public void PlayLiftArrivalEffect() { }

	// RVA: 0xAC3D20 Offset: 0xAC2320 VA: 0x180AC3D20
	public void StartMovementSounds() { }

	// RVA: 0xAC4080 Offset: 0xAC2680 VA: 0x180AC4080
	public void UpdateMovementSounds() { }

	// RVA: 0xAC3EC0 Offset: 0xAC24C0 VA: 0x180AC3EC0
	public void StopMovementSounds() { }

	// RVA: 0xAC3FE0 Offset: 0xAC25E0 VA: 0x180AC3FE0
	public void ToggleMovementCollider(bool state) { }

	// RVA: 0xAC2A30 Offset: 0xAC1030 VA: 0x180AC2A30
	public void .ctor() { }

}

public class ElevatorLiftStatic : ElevatorLift // TypeDefIndex: 8388
{	// Fields
	private Option __menuOption_Menu_LowerElevatorToFloor; // 0x410
	private Option __menuOption_Menu_RaiseElevatorToTop; // 0x468

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAC2430 Offset: 0xAC0A30 VA: 0x180AC2430 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC2A50 Offset: 0xAC1050 VA: 0x180AC2A50 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	[BaseEntity.Menu.Description] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	[BaseEntity.Menu.Icon] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	[BaseEntity.Menu.ShowIf] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	// RVA: 0xAC29E0 Offset: 0xAC0FE0 VA: 0x180AC29E0
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	[BaseEntity.Menu.Description] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	[BaseEntity.Menu.Icon] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	[BaseEntity.Menu.ShowIf] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	// RVA: 0xAC2990 Offset: 0xAC0F90 VA: 0x180AC2990
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 145
	protected override bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 146
	protected override bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	// RVA: 0xAC2A30 Offset: 0xAC1030 VA: 0x180AC2A30
	public void .ctor() { }

}

public class Elevator : IOEntity, IFlagNotify // TypeDefIndex: 8692
{	// Fields
	public Transform LiftRoot; // 0x288
	public GameObjectRef LiftEntityPrefab; // 0x290
	public GameObjectRef IoEntityPrefab; // 0x298
	public Transform IoEntitySpawnPoint; // 0x2A0
	public GameObject FloorBlockerVolume; // 0x2A8
	public float LiftSpeedPerMetre; // 0x2B0
	public GameObject[] PoweredObjects; // 0x2B8
	public MeshRenderer PoweredMesh; // 0x2C0
	[ColorUsageAttribute] // RVA: 0x85B30 Offset: 0x84F30 VA: 0x180085B30
	public Color PoweredLightColour; // 0x2C8
	[ColorUsageAttribute] // RVA: 0x85B30 Offset: 0x84F30 VA: 0x180085B30
	public Color UnpoweredLightColour; // 0x2D8
	public SkinnedMeshRenderer[] CableRenderers; // 0x2E8
	public LODGroup CableLod; // 0x2F0
	public Transform CableRoot; // 0x2F8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Floor>k__BackingField; // 0x300
	protected const BaseEntity.Flags TopFloorFlag = 128;
	public const BaseEntity.Flags ElevatorPowered = 256;
	private ElevatorLift liftEntity; // 0x308

	// Properties
	protected virtual bool IsStatic { get; }
	public int Floor { get; set; }
	protected bool IsTop { get; }

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 160
	protected virtual bool get_IsStatic() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAC5930 Offset: 0xAC3F30 VA: 0x180AC5930
	public int get_Floor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAC5940 Offset: 0xAC3F40 VA: 0x180AC5940
	public void set_Floor(int value) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	protected bool get_IsTop() { }

	// RVA: 0xAC4750 Offset: 0xAC2D50 VA: 0x180AC4750 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAC54F0 Offset: 0xAC3AF0 VA: 0x180AC54F0
	private void UpdateCable() { }

	// RVA: 0xAC5180 Offset: 0xAC3780 VA: 0x180AC5180
	private void SetCableBounds(float height) { }

	// RVA: 0xAC4590 Offset: 0xAC2B90 VA: 0x180AC4590
	private void DisableUpdate() { }

	// RVA: 0xAC44C0 Offset: 0xAC2AC0 VA: 0x180AC44C0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xAC5350 Offset: 0xAC3950 VA: 0x180AC5350 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0xAC49A0 Offset: 0xAC2FA0 VA: 0x180AC49A0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xAC4600 Offset: 0xAC2C00 VA: 0x180AC4600
	private void FindExistingLiftChild() { }

	// RVA: 0xAC4820 Offset: 0xAC2E20 VA: 0x180AC4820 Slot: 159
	public void OnFlagToggled(bool state) { }

	// RVA: 0xAC58D0 Offset: 0xAC3ED0 VA: 0x180AC58D0
	public void .ctor() { }

}

public enum Elevator.Direction // TypeDefIndex: 8693
{	// Fields
	public int value__; // 0x0
	public const Elevator.Direction Up = 0;
	public const Elevator.Direction Down = 1;

}

public class ElevatorStatic : Elevator // TypeDefIndex: 8694
{	// Fields
	public bool StaticTop; // 0x310
	private const BaseEntity.Flags LiftRecentlyArrived = 512;

	// Properties
	protected override bool IsStatic { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 160
	protected override bool get_IsStatic() { }

	// RVA: 0x8C11A0 Offset: 0x8BF7A0 VA: 0x1808C11A0
	public void .ctor() { }

}

public class ElevatorIOEntity : IOEntity // TypeDefIndex: 9800
{	// Fields
	public int Consumption; // 0x288

	// Methods

	// RVA: 0xAC01C0 Offset: 0xABE7C0 VA: 0x180AC01C0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xAC23D0 Offset: 0xAC09D0 VA: 0x180AC23D0
	public void .ctor() { }

}

