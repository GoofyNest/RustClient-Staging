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

	// RVA: 0xE88CF0 Offset: 0xE872F0 VA: 0x180E88CF0
	protected WorkshopInterface get_Interface() { }

	// RVA: 0xE88C50 Offset: 0xE87250 VA: 0x180E88C50
	protected WorkshopItemEditor get_Editor() { }

	// RVA: 0xE88B50 Offset: 0xE87150 VA: 0x180E88B50
	public void Update() { }

	// RVA: 0xE889D0 Offset: 0xE86FD0 VA: 0x180E889D0
	public void UpdateFrom(IWorkshopContent item) { }

	// RVA: 0xE88840 Offset: 0xE86E40 VA: 0x180E88840
	public void OnVoteUp() { }

	// RVA: 0xE88710 Offset: 0xE86D10 VA: 0x180E88710
	public void OnVoteDown() { }

	// RVA: 0xE88970 Offset: 0xE86F70 VA: 0x180E88970
	public void OpenWeb() { }

	// RVA: 0xE88690 Offset: 0xE86C90 VA: 0x180E88690
	internal void Clear() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

