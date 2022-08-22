public class Recycler : StorageContainer // TypeDefIndex: 8434
{	// Fields
	private Option __menuOption_Menu_TurnOff; // 0x3D0
	private Option __menuOption_Menu_TurnOn; // 0x428
	public float recycleEfficiency; // 0x480
	public SoundDefinition grindingLoopDef; // 0x488
	public GameObjectRef startSound; // 0x490
	public GameObjectRef stopSound; // 0x498
	private bool lastFrameOn; // 0x4A0
	private SoundModulation.Modulator grindingSoundModulator; // 0x4A8
	private Sound grindingLoop; // 0x4B0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x93F1F0 Offset: 0x93D7F0 VA: 0x18093F1F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x93FD30 Offset: 0x93E330 VA: 0x18093FD30 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x93FA90 Offset: 0x93E090 VA: 0x18093FA90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x93FB80 Offset: 0x93E180 VA: 0x18093FB80 Slot: 27
	public override void ResetState() { }

	// RVA: 0x93EF70 Offset: 0x93D570 VA: 0x18093EF70
	private bool CanBeRecycled(Item item) { }

	[BaseEntity.Menu] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	[BaseEntity.Menu.Description] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	[BaseEntity.Menu.Icon] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	// RVA: 0x93FA40 Offset: 0x93E040 VA: 0x18093FA40
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x93F980 Offset: 0x93DF80 VA: 0x18093F980
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7FB00 Offset: 0x7EF00 VA: 0x18007FB00
	[BaseEntity.Menu.Description] // RVA: 0x7FB00 Offset: 0x7EF00 VA: 0x18007FB00
	[BaseEntity.Menu.Icon] // RVA: 0x7FB00 Offset: 0x7EF00 VA: 0x18007FB00
	[BaseEntity.Menu.ShowIf] // RVA: 0x7FB00 Offset: 0x7EF00 VA: 0x18007FB00
	// RVA: 0x93F930 Offset: 0x93DF30 VA: 0x18093F930
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x93F870 Offset: 0x93DE70 VA: 0x18093F870
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	// RVA: 0x93EFF0 Offset: 0x93D5F0 VA: 0x18093EFF0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x93F740 Offset: 0x93DD40 VA: 0x18093F740
	public void InitializeClientsideEffects() { }

	// RVA: 0x93F130 Offset: 0x93D730 VA: 0x18093F130 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x93FBB0 Offset: 0x93E1B0 VA: 0x18093FBB0
	public void Update() { }

	// RVA: 0x93FCD0 Offset: 0x93E2D0 VA: 0x18093FCD0
	public void .ctor() { }

}

