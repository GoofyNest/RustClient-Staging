public class Recycler : StorageContainer // TypeDefIndex: 8434
{	private Option __menuOption_Menu_TurnOff; // 0x3D0
	private Option __menuOption_Menu_TurnOn; // 0x428
	public float recycleEfficiency; // 0x480
	public SoundDefinition grindingLoopDef; // 0x488
	public GameObjectRef startSound; // 0x490
	public GameObjectRef stopSound; // 0x498
	private bool lastFrameOn; // 0x4A0
	private SoundModulation.Modulator grindingSoundModulator; // 0x4A8
	private Sound grindingLoop; // 0x4B0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	private bool CanBeRecycled(Item item) { }

	[BaseEntity.Menu] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	[BaseEntity.Menu.Description] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	[BaseEntity.Menu.Icon] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F900 Offset: 0x7ED00 VA: 0x18007F900
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7FB50 Offset: 0x7EF50 VA: 0x18007FB50
	[BaseEntity.Menu.Description] // RVA: 0x7FB50 Offset: 0x7EF50 VA: 0x18007FB50
	[BaseEntity.Menu.Icon] // RVA: 0x7FB50 Offset: 0x7EF50 VA: 0x18007FB50
	[BaseEntity.Menu.ShowIf] // RVA: 0x7FB50 Offset: 0x7EF50 VA: 0x18007FB50
	public void Menu_TurnOff(BasePlayer player) { }

	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	protected override void ClientInit(Entity info) { }

	public void InitializeClientsideEffects() { }

	protected override void DoClientDestroy() { }

	public void Update() { }

	public void .ctor() { }

}

