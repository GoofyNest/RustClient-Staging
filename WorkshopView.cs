public class WorkshopView : MonoBehaviour // TypeDefIndex: 7769
{	// Fields
	public TextMeshProUGUI Title; // 0x18
	public TextMeshProUGUI AuthorName; // 0x20
	public TextMeshProUGUI VoteInfo; // 0x28
	public Button VoteUp; // 0x30
	public Button VoteDown; // 0x38
	private IWorkshopContent item; // 0x40

	// Properties
	protected WorkshopInterface Interface { get; }
	protected WorkshopItemEditor Editor { get; }

	// Methods

	// RVA: 0xE87F80 Offset: 0xE86580 VA: 0x180E87F80
	protected WorkshopInterface get_Interface() { }

	// RVA: 0xE87EE0 Offset: 0xE864E0 VA: 0x180E87EE0
	protected WorkshopItemEditor get_Editor() { }

	// RVA: 0xE87DE0 Offset: 0xE863E0 VA: 0x180E87DE0
	public void Update() { }

	// RVA: 0xE87C60 Offset: 0xE86260 VA: 0x180E87C60
	public void UpdateFrom(IWorkshopContent item) { }

	// RVA: 0xE87AD0 Offset: 0xE860D0 VA: 0x180E87AD0
	public void OnVoteUp() { }

	// RVA: 0xE879A0 Offset: 0xE85FA0 VA: 0x180E879A0
	public void OnVoteDown() { }

	// RVA: 0xE87C00 Offset: 0xE86200 VA: 0x180E87C00
	public void OpenWeb() { }

	// RVA: 0xE87920 Offset: 0xE85F20 VA: 0x180E87920
	internal void Clear() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

