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

	// RVA: 0x93ECE0 Offset: 0x93D2E0 VA: 0x18093ECE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x93F820 Offset: 0x93DE20 VA: 0x18093F820 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x93F580 Offset: 0x93DB80 VA: 0x18093F580 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x93F670 Offset: 0x93DC70 VA: 0x18093F670 Slot: 27
	public override void ResetState() { }

	// RVA: 0x93EA60 Offset: 0x93D060 VA: 0x18093EA60
	private bool CanBeRecycled(Item item) { }

	[BaseEntity.Menu] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	[BaseEntity.Menu.Description] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	[BaseEntity.Menu.Icon] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	// RVA: 0x93F530 Offset: 0x93DB30 VA: 0x18093F530
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x93F470 Offset: 0x93DA70 VA: 0x18093F470
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7FB00 Offset: 0x7EF00 VA: 0x18007FB00
	[BaseEntity.Menu.Description] // RVA: 0x7FB00 Offset: 0x7EF00 VA: 0x18007FB00
	[BaseEntity.Menu.Icon] // RVA: 0x7FB00 Offset: 0x7EF00 VA: 0x18007FB00
	[BaseEntity.Menu.ShowIf] // RVA: 0x7FB00 Offset: 0x7EF00 VA: 0x18007FB00
	// RVA: 0x93F420 Offset: 0x93DA20 VA: 0x18093F420
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x93F360 Offset: 0x93D960 VA: 0x18093F360
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	// RVA: 0x93EAE0 Offset: 0x93D0E0 VA: 0x18093EAE0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x93F230 Offset: 0x93D830 VA: 0x18093F230
	public void InitializeClientsideEffects() { }

	// RVA: 0x93EC20 Offset: 0x93D220 VA: 0x18093EC20 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x93F6A0 Offset: 0x93DCA0 VA: 0x18093F6A0
	public void Update() { }

	// RVA: 0x93F7C0 Offset: 0x93DDC0 VA: 0x18093F7C0
	public void .ctor() { }

}

