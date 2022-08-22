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

	// RVA: 0x8FE250 Offset: 0x8FC850 VA: 0x1808FE250 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8FEAF0 Offset: 0x8FD0F0 VA: 0x1808FEAF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8FE680 Offset: 0x8FCC80 VA: 0x1808FE680 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	[BaseEntity.Menu.Description] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	[BaseEntity.Menu.Icon] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	[BaseEntity.Menu.ShowIf] // RVA: 0x9D270 Offset: 0x9C670 VA: 0x18009D270
	// RVA: 0x8FEA50 Offset: 0x8FD050 VA: 0x1808FEA50
	public void UseBench(BasePlayer player) { }

	// RVA: 0x8FE620 Offset: 0x8FCC20 VA: 0x1808FE620
	public bool Menu_UseBench_ShowIf(BasePlayer player) { }

	// RVA: 0x8FEA10 Offset: 0x8FD010 VA: 0x1808FEA10
	public void TryExperiment() { }

	// RVA: 0x8FE770 Offset: 0x8FCD70 VA: 0x1808FE770
	public bool PlayerUnlockedThisTier() { }

	// RVA: 0x8FE200 Offset: 0x8FC800 VA: 0x1808FE200
	public void ClientAttemptUnlock(TechTreeData data, int selectedNodeID) { }

	// RVA: 0x8FE590 Offset: 0x8FCB90 VA: 0x1808FE590
	public int GetScrapForExperiment() { }

	// RVA: 0x4F62A0 Offset: 0x4F48A0 VA: 0x1804F62A0
	public bool IsWorking() { }

	// RVA: 0x8FEA90 Offset: 0x8FD090 VA: 0x1808FEA90
	public void .ctor() { }

}

