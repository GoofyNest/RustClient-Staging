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

	// RVA: 0x93EBD0 Offset: 0x93D1D0 VA: 0x18093EBD0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x93F710 Offset: 0x93DD10 VA: 0x18093F710 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x93F470 Offset: 0x93DA70 VA: 0x18093F470 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x93F560 Offset: 0x93DB60 VA: 0x18093F560 Slot: 27
	public override void ResetState() { }

	// RVA: 0x93E950 Offset: 0x93CF50 VA: 0x18093E950
	private bool CanBeRecycled(Item item) { }

	[BaseEntity.Menu] // RVA: 0x7F830 Offset: 0x7EC30 VA: 0x18007F830
	[BaseEntity.Menu.Description] // RVA: 0x7F830 Offset: 0x7EC30 VA: 0x18007F830
	[BaseEntity.Menu.Icon] // RVA: 0x7F830 Offset: 0x7EC30 VA: 0x18007F830
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F830 Offset: 0x7EC30 VA: 0x18007F830
	// RVA: 0x93F420 Offset: 0x93DA20 VA: 0x18093F420
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x93F360 Offset: 0x93D960 VA: 0x18093F360
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7FA30 Offset: 0x7EE30 VA: 0x18007FA30
	[BaseEntity.Menu.Description] // RVA: 0x7FA30 Offset: 0x7EE30 VA: 0x18007FA30
	[BaseEntity.Menu.Icon] // RVA: 0x7FA30 Offset: 0x7EE30 VA: 0x18007FA30
	[BaseEntity.Menu.ShowIf] // RVA: 0x7FA30 Offset: 0x7EE30 VA: 0x18007FA30
	// RVA: 0x93F310 Offset: 0x93D910 VA: 0x18093F310
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x93F250 Offset: 0x93D850 VA: 0x18093F250
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	// RVA: 0x93E9D0 Offset: 0x93CFD0 VA: 0x18093E9D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x93F120 Offset: 0x93D720 VA: 0x18093F120
	public void InitializeClientsideEffects() { }

	// RVA: 0x93EB10 Offset: 0x93D110 VA: 0x18093EB10 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x93F590 Offset: 0x93DB90 VA: 0x18093F590
	public void Update() { }

	// RVA: 0x93F6B0 Offset: 0x93DCB0 VA: 0x18093F6B0
	public void .ctor() { }

}

