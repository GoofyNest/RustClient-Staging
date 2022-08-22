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

	// RVA: 0x8FDC30 Offset: 0x8FC230 VA: 0x1808FDC30 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8FE4D0 Offset: 0x8FCAD0 VA: 0x1808FE4D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8FE060 Offset: 0x8FC660 VA: 0x1808FE060 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	[BaseEntity.Menu.Description] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	[BaseEntity.Menu.Icon] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	// RVA: 0x8FE430 Offset: 0x8FCA30 VA: 0x1808FE430
	public void UseBench(BasePlayer player) { }

	// RVA: 0x8FE000 Offset: 0x8FC600 VA: 0x1808FE000
	public bool Menu_UseBench_ShowIf(BasePlayer player) { }

	// RVA: 0x8FE3F0 Offset: 0x8FC9F0 VA: 0x1808FE3F0
	public void TryExperiment() { }

	// RVA: 0x8FE150 Offset: 0x8FC750 VA: 0x1808FE150
	public bool PlayerUnlockedThisTier() { }

	// RVA: 0x8FDBE0 Offset: 0x8FC1E0 VA: 0x1808FDBE0
	public void ClientAttemptUnlock(TechTreeData data, int selectedNodeID) { }

	// RVA: 0x8FDF70 Offset: 0x8FC570 VA: 0x1808FDF70
	public int GetScrapForExperiment() { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool IsWorking() { }

	// RVA: 0x8FE470 Offset: 0x8FCA70 VA: 0x1808FE470
	public void .ctor() { }

}

