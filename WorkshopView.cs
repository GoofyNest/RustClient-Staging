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

	// RVA: 0xE88240 Offset: 0xE86840 VA: 0x180E88240
	protected WorkshopInterface get_Interface() { }

	// RVA: 0xE881A0 Offset: 0xE867A0 VA: 0x180E881A0
	protected WorkshopItemEditor get_Editor() { }

	// RVA: 0xE880A0 Offset: 0xE866A0 VA: 0x180E880A0
	public void Update() { }

	// RVA: 0xE87F20 Offset: 0xE86520 VA: 0x180E87F20
	public void UpdateFrom(IWorkshopContent item) { }

	// RVA: 0xE87D90 Offset: 0xE86390 VA: 0x180E87D90
	public void OnVoteUp() { }

	// RVA: 0xE87C60 Offset: 0xE86260 VA: 0x180E87C60
	public void OnVoteDown() { }

	// RVA: 0xE87EC0 Offset: 0xE864C0 VA: 0x180E87EC0
	public void OpenWeb() { }

	// RVA: 0xE87BE0 Offset: 0xE861E0 VA: 0x180E87BE0
	internal void Clear() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

