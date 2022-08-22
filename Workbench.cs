public class Workbench : StorageContainer // TypeDefIndex: 8488
{	// Fields
	private Option __menuOption_UseBench; // 0x3D0
	public const int blueprintSlot = 0;
	public const int experimentSlot = 1;
	public bool Static; // 0x428
	public int Workbenchlevel; // 0x42C
	public LootSpawn experimentalItems; // 0x430
	public GameObjectRef experimentStartEffect; // 0x438
	public GameObjectRef experimentSuccessEffect; // 0x440
	public ItemDefinition experimentResource; // 0x448
	public TechTreeData techTree; // 0x450

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x8FDD40 Offset: 0x8FC340 VA: 0x1808FDD40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8FE5E0 Offset: 0x8FCBE0 VA: 0x1808FE5E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8FE170 Offset: 0x8FC770 VA: 0x1808FE170 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	[BaseEntity.Menu.Description] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	[BaseEntity.Menu.Icon] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	// RVA: 0x8FE540 Offset: 0x8FCB40 VA: 0x1808FE540
	public void UseBench(BasePlayer player) { }

	// RVA: 0x8FE110 Offset: 0x8FC710 VA: 0x1808FE110
	public bool Menu_UseBench_ShowIf(BasePlayer player) { }

	// RVA: 0x8FE500 Offset: 0x8FCB00 VA: 0x1808FE500
	public void TryExperiment() { }

	// RVA: 0x8FE260 Offset: 0x8FC860 VA: 0x1808FE260
	public bool PlayerUnlockedThisTier() { }

	// RVA: 0x8FDCF0 Offset: 0x8FC2F0 VA: 0x1808FDCF0
	public void ClientAttemptUnlock(TechTreeData data, int selectedNodeID) { }

	// RVA: 0x8FE080 Offset: 0x8FC680 VA: 0x1808FE080
	public int GetScrapForExperiment() { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool IsWorking() { }

	// RVA: 0x8FE580 Offset: 0x8FCB80 VA: 0x1808FE580
	public void .ctor() { }

}

