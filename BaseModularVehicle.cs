public abstract class BaseModularVehicle : GroundVehicle, IPrefabPreProcess // TypeDefIndex: 8328
{	// Fields
	private Option __menuOption_Menu_Push; // 0x408
	protected bool clientInEditMode; // 0x460
	private LOD[] baseVehicleLODs; // 0x468
	private LOD[] combinedLODs; // 0x470
	private int[] maxRendererIndex; // 0x478
	[HeaderAttribute] // RVA: 0xB8A20 Offset: 0xB7E20 VA: 0x1800B8A20
	[SerializeField] // RVA: 0xB8A20 Offset: 0xB7E20 VA: 0x1800B8A20
	private List<ModularVehicleSocket> moduleSockets; // 0x480
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform centreOfMassTransform; // 0x488
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	protected Transform waterSample; // 0x490
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private LODGroup lodGroup; // 0x498
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly List<BaseVehicleModule> <AttachedModuleEntities>k__BackingField; // 0x4A0
	private float _mass; // 0x4A8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <TotalMass>k__BackingField; // 0x4AC
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xA46FE0 Offset: 0xA455E0 VA: 0x180A46FE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA49340 Offset: 0xA47940 VA: 0x180A49340 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA47370 Offset: 0xA45970 VA: 0x180A47370 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0xA480C0 Offset: 0xA466C0 VA: 0x180A480C0 Slot: 201
	protected override void OnClientTickStopped() { }

	// RVA: 0xA46E10 Offset: 0xA45410 VA: 0x180A46E10 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA49110 Offset: 0xA47710 VA: 0x180A49110 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA48170 Offset: 0xA46770 VA: 0x180A48170 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA46EA0 Offset: 0xA454A0 VA: 0x180A46EA0 Slot: 203
	public virtual void ClientLightsChanged(bool headlightsOn, bool brakesOn) { }

	// RVA: -1 Offset: -1 Slot: 204
	protected abstract bool IsBraking();

	// RVA: 0xA48290 Offset: 0xA46890 VA: 0x180A48290
	private void RefreshLODSets() { }

	[BaseEntity.Menu] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	[BaseEntity.Menu.Description] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	[BaseEntity.Menu.Icon] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	// RVA: 0xA47740 Offset: 0xA45D40 VA: 0x180A47740 Slot: 205
	public virtual void Menu_Push(BasePlayer player) { }

	// RVA: 0xA492A0 Offset: 0xA478A0 VA: 0x180A492A0
	public Vector3 get_CentreOfMass() { }

	// RVA: 0xA494C0 Offset: 0xA47AC0 VA: 0x180A494C0
	public int get_NumAttachedModules() { }

	// RVA: 0xA492E0 Offset: 0xA478E0 VA: 0x180A492E0
	public bool get_HasAnyModules() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA49290 Offset: 0xA47890 VA: 0x180A49290
	public List<BaseVehicleModule> get_AttachedModuleEntities() { }

	// RVA: 0xA495F0 Offset: 0xA47BF0 VA: 0x180A495F0
	public int get_TotalSockets() { }

	// RVA: 0xA49500 Offset: 0xA47B00 VA: 0x180A49500
	public int get_NumFreeSockets() { }

	// RVA: 0xA49420 Offset: 0xA47A20 VA: 0x180A49420
	private float get_Mass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA495E0 Offset: 0xA47BE0 VA: 0x180A495E0
	public float get_TotalMass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA49640 Offset: 0xA47C40 VA: 0x180A49640
	private void set_TotalMass(float value) { }

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool get_IsKinematic() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 206
	public virtual bool get_IsLockable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA49330 Offset: 0xA47930 VA: 0x180A49330
	public bool get_HasInited() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA49630 Offset: 0xA47C30 VA: 0x180A49630
	private void set_HasInited(bool value) { }

	// RVA: 0x77AA30 Offset: 0x779030 VA: 0x18077AA30
	private ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0xA49410 Offset: 0xA47A10 VA: 0x180A49410
	public bool get_IsEditableNow() { }

	// RVA: 0xA47430 Offset: 0xA45A30 VA: 0x180A47430 Slot: 28
	public override void InitShared() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 207
	public virtual bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0xA48D40 Offset: 0xA47340 VA: 0x180A48D40
	public bool TryDeduceSocketIndex(BaseVehicleModule addedModule, out int index) { }

	// RVA: 0xA46DB0 Offset: 0xA453B0 VA: 0x180A46DB0
	public void AddMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos) { }

	// RVA: 0xA48D20 Offset: 0xA47320 VA: 0x180A48D20
	public void RemoveMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos) { }

	// RVA: 0xA48F50 Offset: 0xA47550 VA: 0x180A48F50
	public bool TryGetModuleAt(int socketIndex, out BaseVehicleModule result) { }

	// RVA: 0xA47300 Offset: 0xA45900 VA: 0x180A47300
	public ModularVehicleSocket GetSocket(int index) { }

	// RVA: 0xA47650 Offset: 0xA45C50 VA: 0x180A47650 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA46DD0 Offset: 0xA453D0 VA: 0x180A46DD0 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0xA47EE0 Offset: 0xA464E0 VA: 0x180A47EE0 Slot: 22
	protected override void OnChildAdded(BaseEntity childEntity) { }

	// RVA: 0xA48020 Offset: 0xA46620 VA: 0x180A48020 Slot: 23
	protected override void OnChildRemoved(BaseEntity childEntity) { }

	// RVA: 0xA47780 Offset: 0xA45D80 VA: 0x180A47780 Slot: 208
	protected virtual void ModuleEntityAdded(BaseVehicleModule addedModule) { }

	// RVA: 0xA47D50 Offset: 0xA46350 VA: 0x180A47D50 Slot: 209
	protected virtual void ModuleEntityRemoved(BaseVehicleModule removedModule) { }

	// RVA: 0xA48BD0 Offset: 0xA471D0 VA: 0x180A48BD0
	private void RefreshModulesExcept(BaseVehicleModule ignoredModule) { }

	// RVA: 0xA491E0 Offset: 0xA477E0 VA: 0x180A491E0
	protected void .ctor() { }

}

private sealed class BaseModularVehicle.<>c__DisplayClass64_0 // TypeDefIndex: 8329
{	// Fields
	public BaseModularVehicle <>4__this; // 0x10
	public BaseVehicleModule module; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA54660 Offset: 0xA52C60 VA: 0x180A54660
	internal void <OnChildAdded>b__0() { }

}

