public class Elevator : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6387
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int floor; // 0x14

	// Methods

	// RVA: 0x1E734A0 Offset: 0x1E71AA0 VA: 0x181E734A0
	public static void ResetToPool(Elevator instance) { }

	// RVA: 0x1E73520 Offset: 0x1E71B20 VA: 0x181E73520
	public void ResetToPool() { }

	// RVA: 0x1E73370 Offset: 0x1E71970 VA: 0x181E73370 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(Elevator instance) { }

	// RVA: 0x1E729F0 Offset: 0x1E70FF0 VA: 0x181E729F0
	public Elevator Copy() { }

	// RVA: 0x1E72F90 Offset: 0x1E71590 VA: 0x181E72F90
	public static Elevator Deserialize(Stream stream) { }

	// RVA: 0x1E72C80 Offset: 0x1E71280 VA: 0x181E72C80
	public static Elevator DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E72F00 Offset: 0x1E71500 VA: 0x181E72F00
	public static Elevator DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E73010 Offset: 0x1E71610 VA: 0x181E73010
	public static Elevator Deserialize(byte[] buffer) { }

	// RVA: 0x1E73460 Offset: 0x1E71A60 VA: 0x181E73460
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E739F0 Offset: 0x1E71FF0 VA: 0x181E739F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E73AC0 Offset: 0x1E720C0 VA: 0x181E73AC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Elevator previous) { }

	// RVA: 0x1E73480 Offset: 0x1E71A80 VA: 0x181E73480 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E73130 Offset: 0x1E71730 VA: 0x181E73130
	public static Elevator Deserialize(byte[] buffer, Elevator instance, bool isDelta = False) { }

	// RVA: 0x1E73230 Offset: 0x1E71830 VA: 0x181E73230
	public static Elevator Deserialize(Stream stream, Elevator instance, bool isDelta) { }

	// RVA: 0x1E72A60 Offset: 0x1E71060 VA: 0x181E72A60
	public static Elevator DeserializeLengthDelimited(Stream stream, Elevator instance, bool isDelta) { }

	// RVA: 0x1E72D00 Offset: 0x1E71300 VA: 0x181E72D00
	public static Elevator DeserializeLength(Stream stream, int length, Elevator instance, bool isDelta) { }

	// RVA: 0x1E735A0 Offset: 0x1E71BA0 VA: 0x181E735A0
	public static void SerializeDelta(Stream stream, Elevator instance, Elevator previous) { }

	// RVA: 0x1E73910 Offset: 0x1E71F10 VA: 0x181E73910
	public static void Serialize(Stream stream, Elevator instance) { }

	// RVA: 0x1E739E0 Offset: 0x1E71FE0 VA: 0x181E739E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E739F0 Offset: 0x1E71FF0 VA: 0x181E739F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E73760 Offset: 0x1E71D60 VA: 0x181E73760
	public static byte[] SerializeToBytes(Elevator instance) { }

	// RVA: 0x1E736B0 Offset: 0x1E71CB0 VA: 0x181E736B0
	public static void SerializeLengthDelimited(Stream stream, Elevator instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0xAC2A70 Offset: 0xAC1070 VA: 0x180AC2A70 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC3FA0 Offset: 0xAC25A0 VA: 0x180AC3FA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAC36C0 Offset: 0xAC1CC0 VA: 0x180AC36C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAC4170 Offset: 0xAC2770 VA: 0x180AC4170
	private Elevator get_owner() { }

	[BaseEntity.Menu] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	[BaseEntity.Menu.Description] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	[BaseEntity.Menu.Icon] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	// RVA: 0xAC3670 Offset: 0xAC1C70 VA: 0x180AC3670
	public void Menu_RaiseElevator(BasePlayer p) { }

	// RVA: 0xAC35D0 Offset: 0xAC1BD0 VA: 0x180AC35D0
	protected bool Menu_RaiseElevator_ShowIf(BasePlayer p) { }

	// RVA: 0xAC35C0 Offset: 0xAC1BC0 VA: 0x180AC35C0 Slot: 145
	protected virtual bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	[BaseEntity.Menu.Description] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	[BaseEntity.Menu.Icon] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	// RVA: 0xAC3570 Offset: 0xAC1B70 VA: 0x180AC3570
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	[BaseEntity.Menu.Description] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	[BaseEntity.Menu.Icon] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	// RVA: 0xAC3520 Offset: 0xAC1B20 VA: 0x180AC3520
	public void Menu_LowerElevator(BasePlayer p) { }

	// RVA: 0xAC3480 Offset: 0xAC1A80 VA: 0x180AC3480
	protected bool Menu_LowerElevator_ShowIf(BasePlayer p) { }

	// RVA: 0xAC3470 Offset: 0xAC1A70 VA: 0x180AC3470 Slot: 146
	protected virtual bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	[BaseEntity.Menu.Description] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	[BaseEntity.Menu.Icon] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	// RVA: 0xAC3420 Offset: 0xAC1A20 VA: 0x180AC3420
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	// RVA: 0xAC28E0 Offset: 0xAC0EE0 VA: 0x180AC28E0
	protected bool GetLookingAtButton(BasePlayer p, out Elevator.Direction d) { }

	// RVA: 0xAC37B0 Offset: 0xAC1DB0 VA: 0x180AC37B0
	public void PlayLiftArrivalEffect() { }

	// RVA: 0xAC3A60 Offset: 0xAC2060 VA: 0x180AC3A60
	public void StartMovementSounds() { }

	// RVA: 0xAC3DC0 Offset: 0xAC23C0 VA: 0x180AC3DC0
	public void UpdateMovementSounds() { }

	// RVA: 0xAC3C00 Offset: 0xAC2200 VA: 0x180AC3C00
	public void StopMovementSounds() { }

	// RVA: 0xAC3D20 Offset: 0xAC2320 VA: 0x180AC3D20
	public void ToggleMovementCollider(bool state) { }

	// RVA: 0xAC2770 Offset: 0xAC0D70 VA: 0x180AC2770
	public void .ctor() { }

}

public class ElevatorLiftStatic : ElevatorLift // TypeDefIndex: 8388
{	// Fields
	private Option __menuOption_Menu_LowerElevatorToFloor; // 0x410
	private Option __menuOption_Menu_RaiseElevatorToTop; // 0x468

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAC2170 Offset: 0xAC0770 VA: 0x180AC2170 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC2790 Offset: 0xAC0D90 VA: 0x180AC2790 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	[BaseEntity.Menu.Description] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	[BaseEntity.Menu.Icon] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	[BaseEntity.Menu.ShowIf] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	// RVA: 0xAC2720 Offset: 0xAC0D20 VA: 0x180AC2720
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	[BaseEntity.Menu.Description] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	[BaseEntity.Menu.Icon] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	[BaseEntity.Menu.ShowIf] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	// RVA: 0xAC26D0 Offset: 0xAC0CD0 VA: 0x180AC26D0
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 145
	protected override bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 146
	protected override bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	// RVA: 0xAC2770 Offset: 0xAC0D70 VA: 0x180AC2770
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
	// RVA: 0xAC5670 Offset: 0xAC3C70 VA: 0x180AC5670
	public int get_Floor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAC5680 Offset: 0xAC3C80 VA: 0x180AC5680
	public void set_Floor(int value) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	protected bool get_IsTop() { }

	// RVA: 0xAC4490 Offset: 0xAC2A90 VA: 0x180AC4490 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAC5230 Offset: 0xAC3830 VA: 0x180AC5230
	private void UpdateCable() { }

	// RVA: 0xAC4EC0 Offset: 0xAC34C0 VA: 0x180AC4EC0
	private void SetCableBounds(float height) { }

	// RVA: 0xAC42D0 Offset: 0xAC28D0 VA: 0x180AC42D0
	private void DisableUpdate() { }

	// RVA: 0xAC4200 Offset: 0xAC2800 VA: 0x180AC4200 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xAC5090 Offset: 0xAC3690 VA: 0x180AC5090 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0xAC46E0 Offset: 0xAC2CE0 VA: 0x180AC46E0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xAC4340 Offset: 0xAC2940 VA: 0x180AC4340
	private void FindExistingLiftChild() { }

	// RVA: 0xAC4560 Offset: 0xAC2B60 VA: 0x180AC4560 Slot: 159
	public void OnFlagToggled(bool state) { }

	// RVA: 0xAC5610 Offset: 0xAC3C10 VA: 0x180AC5610
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

	// RVA: 0x8C1090 Offset: 0x8BF690 VA: 0x1808C1090
	public void .ctor() { }

}

public class ElevatorIOEntity : IOEntity // TypeDefIndex: 9800
{	// Fields
	public int Consumption; // 0x288

	// Methods

	// RVA: 0xABFF00 Offset: 0xABE500 VA: 0x180ABFF00 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xAC2110 Offset: 0xAC0710 VA: 0x180AC2110
	public void .ctor() { }

}

