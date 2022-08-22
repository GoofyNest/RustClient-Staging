public class Elevator : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6387
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int floor; // 0x14

	// Methods

	// RVA: 0x1E73F80 Offset: 0x1E72580 VA: 0x181E73F80
	public static void ResetToPool(Elevator instance) { }

	// RVA: 0x1E74000 Offset: 0x1E72600 VA: 0x181E74000
	public void ResetToPool() { }

	// RVA: 0x1E73E50 Offset: 0x1E72450 VA: 0x181E73E50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(Elevator instance) { }

	// RVA: 0x1E734D0 Offset: 0x1E71AD0 VA: 0x181E734D0
	public Elevator Copy() { }

	// RVA: 0x1E73A70 Offset: 0x1E72070 VA: 0x181E73A70
	public static Elevator Deserialize(Stream stream) { }

	// RVA: 0x1E73760 Offset: 0x1E71D60 VA: 0x181E73760
	public static Elevator DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E739E0 Offset: 0x1E71FE0 VA: 0x181E739E0
	public static Elevator DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E73AF0 Offset: 0x1E720F0 VA: 0x181E73AF0
	public static Elevator Deserialize(byte[] buffer) { }

	// RVA: 0x1E73F40 Offset: 0x1E72540 VA: 0x181E73F40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E744D0 Offset: 0x1E72AD0 VA: 0x181E744D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E745A0 Offset: 0x1E72BA0 VA: 0x181E745A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Elevator previous) { }

	// RVA: 0x1E73F60 Offset: 0x1E72560 VA: 0x181E73F60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E73C10 Offset: 0x1E72210 VA: 0x181E73C10
	public static Elevator Deserialize(byte[] buffer, Elevator instance, bool isDelta = False) { }

	// RVA: 0x1E73D10 Offset: 0x1E72310 VA: 0x181E73D10
	public static Elevator Deserialize(Stream stream, Elevator instance, bool isDelta) { }

	// RVA: 0x1E73540 Offset: 0x1E71B40 VA: 0x181E73540
	public static Elevator DeserializeLengthDelimited(Stream stream, Elevator instance, bool isDelta) { }

	// RVA: 0x1E737E0 Offset: 0x1E71DE0 VA: 0x181E737E0
	public static Elevator DeserializeLength(Stream stream, int length, Elevator instance, bool isDelta) { }

	// RVA: 0x1E74080 Offset: 0x1E72680 VA: 0x181E74080
	public static void SerializeDelta(Stream stream, Elevator instance, Elevator previous) { }

	// RVA: 0x1E743F0 Offset: 0x1E729F0 VA: 0x181E743F0
	public static void Serialize(Stream stream, Elevator instance) { }

	// RVA: 0x1E744C0 Offset: 0x1E72AC0 VA: 0x181E744C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E744D0 Offset: 0x1E72AD0 VA: 0x181E744D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E74240 Offset: 0x1E72840 VA: 0x181E74240
	public static byte[] SerializeToBytes(Elevator instance) { }

	// RVA: 0x1E74190 Offset: 0x1E72790 VA: 0x181E74190
	public static void SerializeLengthDelimited(Stream stream, Elevator instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0xAC3200 Offset: 0xAC1800 VA: 0x180AC3200 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC4730 Offset: 0xAC2D30 VA: 0x180AC4730 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAC3E50 Offset: 0xAC2450 VA: 0x180AC3E50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAC4900 Offset: 0xAC2F00 VA: 0x180AC4900
	private Elevator get_owner() { }

	[BaseEntity.Menu] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	[BaseEntity.Menu.Description] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	[BaseEntity.Menu.Icon] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB120 Offset: 0xDA520 VA: 0x1800DB120
	// RVA: 0xAC3E00 Offset: 0xAC2400 VA: 0x180AC3E00
	public void Menu_RaiseElevator(BasePlayer p) { }

	// RVA: 0xAC3D60 Offset: 0xAC2360 VA: 0x180AC3D60
	protected bool Menu_RaiseElevator_ShowIf(BasePlayer p) { }

	// RVA: 0xAC3D50 Offset: 0xAC2350 VA: 0x180AC3D50 Slot: 145
	protected virtual bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	[BaseEntity.Menu.Description] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	[BaseEntity.Menu.Icon] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB4C0 Offset: 0xDA8C0 VA: 0x1800DB4C0
	// RVA: 0xAC3D00 Offset: 0xAC2300 VA: 0x180AC3D00
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	[BaseEntity.Menu.Description] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	[BaseEntity.Menu.Icon] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB800 Offset: 0xDAC00 VA: 0x1800DB800
	// RVA: 0xAC3CB0 Offset: 0xAC22B0 VA: 0x180AC3CB0
	public void Menu_LowerElevator(BasePlayer p) { }

	// RVA: 0xAC3C10 Offset: 0xAC2210 VA: 0x180AC3C10
	protected bool Menu_LowerElevator_ShowIf(BasePlayer p) { }

	// RVA: 0xAC3C00 Offset: 0xAC2200 VA: 0x180AC3C00 Slot: 146
	protected virtual bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	[BaseEntity.Menu.Description] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	[BaseEntity.Menu.Icon] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDBCB0 Offset: 0xDB0B0 VA: 0x1800DBCB0
	// RVA: 0xAC3BB0 Offset: 0xAC21B0 VA: 0x180AC3BB0
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	// RVA: 0xAC3070 Offset: 0xAC1670 VA: 0x180AC3070
	protected bool GetLookingAtButton(BasePlayer p, out Elevator.Direction d) { }

	// RVA: 0xAC3F40 Offset: 0xAC2540 VA: 0x180AC3F40
	public void PlayLiftArrivalEffect() { }

	// RVA: 0xAC41F0 Offset: 0xAC27F0 VA: 0x180AC41F0
	public void StartMovementSounds() { }

	// RVA: 0xAC4550 Offset: 0xAC2B50 VA: 0x180AC4550
	public void UpdateMovementSounds() { }

	// RVA: 0xAC4390 Offset: 0xAC2990 VA: 0x180AC4390
	public void StopMovementSounds() { }

	// RVA: 0xAC44B0 Offset: 0xAC2AB0 VA: 0x180AC44B0
	public void ToggleMovementCollider(bool state) { }

	// RVA: 0xAC2F00 Offset: 0xAC1500 VA: 0x180AC2F00
	public void .ctor() { }

}

public class ElevatorLiftStatic : ElevatorLift // TypeDefIndex: 8388
{	// Fields
	private Option __menuOption_Menu_LowerElevatorToFloor; // 0x410
	private Option __menuOption_Menu_RaiseElevatorToTop; // 0x468

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAC2900 Offset: 0xAC0F00 VA: 0x180AC2900 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAC2F20 Offset: 0xAC1520 VA: 0x180AC2F20 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	[BaseEntity.Menu.Description] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	[BaseEntity.Menu.Icon] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	[BaseEntity.Menu.ShowIf] // RVA: 0xDBF50 Offset: 0xDB350 VA: 0x1800DBF50
	// RVA: 0xAC2EB0 Offset: 0xAC14B0 VA: 0x180AC2EB0
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	[BaseEntity.Menu.Description] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	[BaseEntity.Menu.Icon] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	[BaseEntity.Menu.ShowIf] // RVA: 0xDC240 Offset: 0xDB640 VA: 0x1800DC240
	// RVA: 0xAC2E60 Offset: 0xAC1460 VA: 0x180AC2E60
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 145
	protected override bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 146
	protected override bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	// RVA: 0xAC2F00 Offset: 0xAC1500 VA: 0x180AC2F00
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
	// RVA: 0xAC5E00 Offset: 0xAC4400 VA: 0x180AC5E00
	public int get_Floor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAC5E10 Offset: 0xAC4410 VA: 0x180AC5E10
	public void set_Floor(int value) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	protected bool get_IsTop() { }

	// RVA: 0xAC4C20 Offset: 0xAC3220 VA: 0x180AC4C20 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAC59C0 Offset: 0xAC3FC0 VA: 0x180AC59C0
	private void UpdateCable() { }

	// RVA: 0xAC5650 Offset: 0xAC3C50 VA: 0x180AC5650
	private void SetCableBounds(float height) { }

	// RVA: 0xAC4A60 Offset: 0xAC3060 VA: 0x180AC4A60
	private void DisableUpdate() { }

	// RVA: 0xAC4990 Offset: 0xAC2F90 VA: 0x180AC4990 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xAC5820 Offset: 0xAC3E20 VA: 0x180AC5820 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0xAC4E70 Offset: 0xAC3470 VA: 0x180AC4E70 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xAC4AD0 Offset: 0xAC30D0 VA: 0x180AC4AD0
	private void FindExistingLiftChild() { }

	// RVA: 0xAC4CF0 Offset: 0xAC32F0 VA: 0x180AC4CF0 Slot: 159
	public void OnFlagToggled(bool state) { }

	// RVA: 0xAC5DA0 Offset: 0xAC43A0 VA: 0x180AC5DA0
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

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 160
	protected override bool get_IsStatic() { }

	// RVA: 0x8C16B0 Offset: 0x8BFCB0 VA: 0x1808C16B0
	public void .ctor() { }

}

public class ElevatorIOEntity : IOEntity // TypeDefIndex: 9800
{	// Fields
	public int Consumption; // 0x288

	// Methods

	// RVA: 0xAC0690 Offset: 0xABEC90 VA: 0x180AC0690 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xAC28A0 Offset: 0xAC0EA0 VA: 0x180AC28A0
	public void .ctor() { }

}

