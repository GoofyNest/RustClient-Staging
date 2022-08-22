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

	// RVA: 0xA47790 Offset: 0xA45D90 VA: 0x180A47790 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA49AF0 Offset: 0xA480F0 VA: 0x180A49AF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA47B20 Offset: 0xA46120 VA: 0x180A47B20 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0xA48870 Offset: 0xA46E70 VA: 0x180A48870 Slot: 201
	protected override void OnClientTickStopped() { }

	// RVA: 0xA475C0 Offset: 0xA45BC0 VA: 0x180A475C0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA498C0 Offset: 0xA47EC0 VA: 0x180A498C0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA48920 Offset: 0xA46F20 VA: 0x180A48920 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA47650 Offset: 0xA45C50 VA: 0x180A47650 Slot: 203
	public virtual void ClientLightsChanged(bool headlightsOn, bool brakesOn) { }

	// RVA: -1 Offset: -1 Slot: 204
	protected abstract bool IsBraking();

	// RVA: 0xA48A40 Offset: 0xA47040 VA: 0x180A48A40
	private void RefreshLODSets() { }

	[BaseEntity.Menu] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Description] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.Icon] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CA10 Offset: 0x8BE10 VA: 0x18008CA10
	// RVA: 0xA47EF0 Offset: 0xA464F0 VA: 0x180A47EF0 Slot: 205
	public virtual void Menu_Push(BasePlayer player) { }

	// RVA: 0xA49A50 Offset: 0xA48050 VA: 0x180A49A50
	public Vector3 get_CentreOfMass() { }

	// RVA: 0xA49C70 Offset: 0xA48270 VA: 0x180A49C70
	public int get_NumAttachedModules() { }

	// RVA: 0xA49A90 Offset: 0xA48090 VA: 0x180A49A90
	public bool get_HasAnyModules() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA49A40 Offset: 0xA48040 VA: 0x180A49A40
	public List<BaseVehicleModule> get_AttachedModuleEntities() { }

	// RVA: 0xA49DA0 Offset: 0xA483A0 VA: 0x180A49DA0
	public int get_TotalSockets() { }

	// RVA: 0xA49CB0 Offset: 0xA482B0 VA: 0x180A49CB0
	public int get_NumFreeSockets() { }

	// RVA: 0xA49BD0 Offset: 0xA481D0 VA: 0x180A49BD0
	private float get_Mass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA49D90 Offset: 0xA48390 VA: 0x180A49D90
	public float get_TotalMass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA49DF0 Offset: 0xA483F0 VA: 0x180A49DF0
	private void set_TotalMass(float value) { }

	// RVA: 0x557EE0 Offset: 0x5564E0 VA: 0x180557EE0
	public bool get_IsKinematic() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 206
	public virtual bool get_IsLockable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA49AE0 Offset: 0xA480E0 VA: 0x180A49AE0
	public bool get_HasInited() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA49DE0 Offset: 0xA483E0 VA: 0x180A49DE0
	private void set_HasInited(bool value) { }

	// RVA: 0x77AA90 Offset: 0x779090 VA: 0x18077AA90
	private ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0xA49BC0 Offset: 0xA481C0 VA: 0x180A49BC0
	public bool get_IsEditableNow() { }

	// RVA: 0xA47BE0 Offset: 0xA461E0 VA: 0x180A47BE0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 207
	public virtual bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0xA494F0 Offset: 0xA47AF0 VA: 0x180A494F0
	public bool TryDeduceSocketIndex(BaseVehicleModule addedModule, out int index) { }

	// RVA: 0xA47560 Offset: 0xA45B60 VA: 0x180A47560
	public void AddMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos) { }

	// RVA: 0xA494D0 Offset: 0xA47AD0 VA: 0x180A494D0
	public void RemoveMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos) { }

	// RVA: 0xA49700 Offset: 0xA47D00 VA: 0x180A49700
	public bool TryGetModuleAt(int socketIndex, out BaseVehicleModule result) { }

	// RVA: 0xA47AB0 Offset: 0xA460B0 VA: 0x180A47AB0
	public ModularVehicleSocket GetSocket(int index) { }

	// RVA: 0xA47E00 Offset: 0xA46400 VA: 0x180A47E00 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA47580 Offset: 0xA45B80 VA: 0x180A47580 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0xA48690 Offset: 0xA46C90 VA: 0x180A48690 Slot: 22
	protected override void OnChildAdded(BaseEntity childEntity) { }

	// RVA: 0xA487D0 Offset: 0xA46DD0 VA: 0x180A487D0 Slot: 23
	protected override void OnChildRemoved(BaseEntity childEntity) { }

	// RVA: 0xA47F30 Offset: 0xA46530 VA: 0x180A47F30 Slot: 208
	protected virtual void ModuleEntityAdded(BaseVehicleModule addedModule) { }

	// RVA: 0xA48500 Offset: 0xA46B00 VA: 0x180A48500 Slot: 209
	protected virtual void ModuleEntityRemoved(BaseVehicleModule removedModule) { }

	// RVA: 0xA49380 Offset: 0xA47980 VA: 0x180A49380
	private void RefreshModulesExcept(BaseVehicleModule ignoredModule) { }

	// RVA: 0xA49990 Offset: 0xA47F90 VA: 0x180A49990
	protected void .ctor() { }

}

private sealed class BaseModularVehicle.<>c__DisplayClass64_0 // TypeDefIndex: 8329
{	// Fields
	public BaseModularVehicle <>4__this; // 0x10
	public BaseVehicleModule module; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA54DF0 Offset: 0xA533F0 VA: 0x180A54DF0
	internal void <OnChildAdded>b__0() { }

}

