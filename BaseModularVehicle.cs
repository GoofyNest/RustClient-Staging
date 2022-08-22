public abstract class BaseModularVehicle : GroundVehicle, IPrefabPreProcess // TypeDefIndex: 8328
{	// Fields
	private Option __menuOption_Menu_Push; // 0x408
	protected bool clientInEditMode; // 0x460
	private LOD[] baseVehicleLODs; // 0x468
	private LOD[] combinedLODs; // 0x470
	private int[] maxRendererIndex; // 0x478
	[HeaderAttribute] // RVA: 0xB8AC0 Offset: 0xB7EC0 VA: 0x1800B8AC0
	[SerializeField] // RVA: 0xB8AC0 Offset: 0xB7EC0 VA: 0x1800B8AC0
	private List<ModularVehicleSocket> moduleSockets; // 0x480
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform centreOfMassTransform; // 0x488
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected Transform waterSample; // 0x490
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private LODGroup lodGroup; // 0x498
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly List<BaseVehicleModule> <AttachedModuleEntities>k__BackingField; // 0x4A0
	private float _mass; // 0x4A8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <TotalMass>k__BackingField; // 0x4AC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <HasInited>k__BackingField; // 0x4B0
	public const BaseEntity.Flags FLAG_KINEMATIC = 16384;
	private Dictionary<BaseVehicleModule, Action> moduleAddActions; // 0x4B8

	// Properties
	public override bool HasMenuOptions { get; }
	public Vector3 CentreOfMass { get; }
	public int NumAttachedModules { get; }
	public bool HasAnyModules { get; }
	public List<BaseVehicleModule> AttachedModuleEntities { get; }
	public int TotalSockets { get; }
	public int NumFreeSockets { get; }
	private float Mass { get; }
	public float TotalMass { get; set; }
	public bool IsKinematic { get; }
	public virtual bool IsLockable { get; }
	public bool HasInited { get; set; }
	private ItemDefinition AssociatedItemDef { get; }
	public bool IsEditableNow { get; }

	// Methods

	// RVA: 0xA472A0 Offset: 0xA458A0 VA: 0x180A472A0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA49600 Offset: 0xA47C00 VA: 0x180A49600 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA47630 Offset: 0xA45C30 VA: 0x180A47630 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0xA48380 Offset: 0xA46980 VA: 0x180A48380 Slot: 201
	protected override void OnClientTickStopped() { }

	// RVA: 0xA470D0 Offset: 0xA456D0 VA: 0x180A470D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA493D0 Offset: 0xA479D0 VA: 0x180A493D0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA48430 Offset: 0xA46A30 VA: 0x180A48430 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA47160 Offset: 0xA45760 VA: 0x180A47160 Slot: 203
	public virtual void ClientLightsChanged(bool headlightsOn, bool brakesOn) { }

	// RVA: -1 Offset: -1 Slot: 204
	protected abstract bool IsBraking();

	// RVA: 0xA48550 Offset: 0xA46B50 VA: 0x180A48550
	private void RefreshLODSets() { }

	[BaseEntity.Menu] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Description] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Icon] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	// RVA: 0xA47A00 Offset: 0xA46000 VA: 0x180A47A00 Slot: 205
	public virtual void Menu_Push(BasePlayer player) { }

	// RVA: 0xA49560 Offset: 0xA47B60 VA: 0x180A49560
	public Vector3 get_CentreOfMass() { }

	// RVA: 0xA49780 Offset: 0xA47D80 VA: 0x180A49780
	public int get_NumAttachedModules() { }

	// RVA: 0xA495A0 Offset: 0xA47BA0 VA: 0x180A495A0
	public bool get_HasAnyModules() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA49550 Offset: 0xA47B50 VA: 0x180A49550
	public List<BaseVehicleModule> get_AttachedModuleEntities() { }

	// RVA: 0xA498B0 Offset: 0xA47EB0 VA: 0x180A498B0
	public int get_TotalSockets() { }

	// RVA: 0xA497C0 Offset: 0xA47DC0 VA: 0x180A497C0
	public int get_NumFreeSockets() { }

	// RVA: 0xA496E0 Offset: 0xA47CE0 VA: 0x180A496E0
	private float get_Mass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA498A0 Offset: 0xA47EA0 VA: 0x180A498A0
	public float get_TotalMass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA49900 Offset: 0xA47F00 VA: 0x180A49900
	private void set_TotalMass(float value) { }

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool get_IsKinematic() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 206
	public virtual bool get_IsLockable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA495F0 Offset: 0xA47BF0 VA: 0x180A495F0
	public bool get_HasInited() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA498F0 Offset: 0xA47EF0 VA: 0x180A498F0
	private void set_HasInited(bool value) { }

	// RVA: 0x77AB40 Offset: 0x779140 VA: 0x18077AB40
	private ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0xA496D0 Offset: 0xA47CD0 VA: 0x180A496D0
	public bool get_IsEditableNow() { }

	// RVA: 0xA476F0 Offset: 0xA45CF0 VA: 0x180A476F0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 207
	public virtual bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0xA49000 Offset: 0xA47600 VA: 0x180A49000
	public bool TryDeduceSocketIndex(BaseVehicleModule addedModule, out int index) { }

	// RVA: 0xA47070 Offset: 0xA45670 VA: 0x180A47070
	public void AddMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos) { }

	// RVA: 0xA48FE0 Offset: 0xA475E0 VA: 0x180A48FE0
	public void RemoveMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos) { }

	// RVA: 0xA49210 Offset: 0xA47810 VA: 0x180A49210
	public bool TryGetModuleAt(int socketIndex, out BaseVehicleModule result) { }

	// RVA: 0xA475C0 Offset: 0xA45BC0 VA: 0x180A475C0
	public ModularVehicleSocket GetSocket(int index) { }

	// RVA: 0xA47910 Offset: 0xA45F10 VA: 0x180A47910 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA47090 Offset: 0xA45690 VA: 0x180A47090 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0xA481A0 Offset: 0xA467A0 VA: 0x180A481A0 Slot: 22
	protected override void OnChildAdded(BaseEntity childEntity) { }

	// RVA: 0xA482E0 Offset: 0xA468E0 VA: 0x180A482E0 Slot: 23
	protected override void OnChildRemoved(BaseEntity childEntity) { }

	// RVA: 0xA47A40 Offset: 0xA46040 VA: 0x180A47A40 Slot: 208
	protected virtual void ModuleEntityAdded(BaseVehicleModule addedModule) { }

	// RVA: 0xA48010 Offset: 0xA46610 VA: 0x180A48010 Slot: 209
	protected virtual void ModuleEntityRemoved(BaseVehicleModule removedModule) { }

	// RVA: 0xA48E90 Offset: 0xA47490 VA: 0x180A48E90
	private void RefreshModulesExcept(BaseVehicleModule ignoredModule) { }

	// RVA: 0xA494A0 Offset: 0xA47AA0 VA: 0x180A494A0
	protected void .ctor() { }

}

private sealed class BaseModularVehicle.<>c__DisplayClass64_0 // TypeDefIndex: 8329
{	// Fields
	public BaseModularVehicle <>4__this; // 0x10
	public BaseVehicleModule module; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA54920 Offset: 0xA52F20 VA: 0x180A54920
	internal void <OnChildAdded>b__0() { }

}

