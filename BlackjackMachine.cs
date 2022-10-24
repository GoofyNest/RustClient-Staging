public class BlackjackMachine : BaseCardGameEntity // TypeDefIndex: 10074
{
	private Option __menuOption_Menu_Play; 
	[HeaderAttribute] 
	[SerializeField] 
	private BlackjackMainScreenUI mainScreenUI; 
	[SerializeField] 
	private BlackjackSmallScreenUI[] smallScreenUIs; 
	[SerializeField] 
	private Canvas[] worldSpaceCanvases; 
	private BlackjackController controller; 

	public override bool HasMenuOptions { get; }
	protected override float MaxStorageInteractionDist { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	protected override float get_MaxStorageInteractionDist() { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void ClientInit(Entity info) { }

	public override void RefreshLocalPlayer(CardPlayerData localPlayerData) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public override void Menu_Play(BasePlayer player) { }

	public void .ctor() { }

}

