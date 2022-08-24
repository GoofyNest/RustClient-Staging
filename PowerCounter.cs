public class PowerCounter : IOEntity // TypeDefIndex: 8428
{	private Option __menuOption_Menu_SetTarget; // 0x288
	private Option __menuOption_Menu_ShowCounter; // 0x2E0
	private Option __menuOption_Menu_ShowPassthrough; // 0x338
	private int counterNumber; // 0x390
	private int targetCounterNumber; // 0x394
	public Canvas canvas; // 0x398
	public CanvasGroup screenAlpha; // 0x3A0
	public Text screenText; // 0x3A8
	public const BaseEntity.Flags Flag_ShowPassthrough = 256;
	public GameObjectRef counterConfigPanel; // 0x3B0
	public Color passthroughColor; // 0x3B8
	public Color counterColor; // 0x3C8
	private int client_counterNumber; // 0x3D8
	private int client_passthrough; // 0x3DC
	private float nextScreenVisTime; // 0x3E0
	private int pendingNumberChange; // 0x3E4

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool DisplayPassthrough() { }

	public bool DisplayCounter() { }

	public bool CanPlayerAdmin(BasePlayer player) { }

	public int GetTarget() { }

	public override void ResetState() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void UpdateNumber(int newNumber) { }

	public void Update() { }

	public void DelayedNumberChange() { }

	public Color GetColor() { }

	public void UpdateColor() { }

	protected override void ClientInit(Entity info) { }

	public override void PostNetworkUpdate() { }

	[BaseEntity.Menu] // RVA: 0x7C9C0 Offset: 0x7BDC0 VA: 0x18007C9C0
	[BaseEntity.Menu.Description] // RVA: 0x7C9C0 Offset: 0x7BDC0 VA: 0x18007C9C0
	[BaseEntity.Menu.Icon] // RVA: 0x7C9C0 Offset: 0x7BDC0 VA: 0x18007C9C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C9C0 Offset: 0x7BDC0 VA: 0x18007C9C0
	public void Menu_ShowPassthrough(BasePlayer player) { }

	public bool Menu_Passthrough_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7CDF0 Offset: 0x7C1F0 VA: 0x18007CDF0
	[BaseEntity.Menu.Description] // RVA: 0x7CDF0 Offset: 0x7C1F0 VA: 0x18007CDF0
	[BaseEntity.Menu.Icon] // RVA: 0x7CDF0 Offset: 0x7C1F0 VA: 0x18007CDF0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7CDF0 Offset: 0x7C1F0 VA: 0x18007CDF0
	public void Menu_ShowCounter(BasePlayer player) { }

	public bool Menu_Counter_ShowIf(BasePlayer player) { }

	public void SendNewTarget(int newTarget) { }

	[BaseEntity.Menu] // RVA: 0x7D010 Offset: 0x7C410 VA: 0x18007D010
	[BaseEntity.Menu.Description] // RVA: 0x7D010 Offset: 0x7C410 VA: 0x18007D010
	[BaseEntity.Menu.Icon] // RVA: 0x7D010 Offset: 0x7C410 VA: 0x18007D010
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D010 Offset: 0x7C410 VA: 0x18007D010
	public void Menu_SetTarget(BasePlayer player) { }

	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

