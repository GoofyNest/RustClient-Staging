public class TeamUI : MonoBehaviour // TypeDefIndex: 11235
{	// Fields
	public static Translate.Phrase invitePhrase; // 0x0
	public RectTransform MemberPanel; // 0x18
	public GameObject memberEntryPrefab; // 0x20
	public TeamMemberElement[] elements; // 0x28
	public GameObject NoTeamPanel; // 0x30
	public GameObject TeamPanel; // 0x38
	public GameObject LeaveTeamButton; // 0x40
	public GameObject InviteAcceptPanel; // 0x48
	public TextMeshProUGUI inviteText; // 0x50
	public static bool dirty; // 0x8
	public static ulong pendingTeamID; // 0x10
	public static string pendingTeamLeaderName; // 0x18

	// Methods

	// RVA: 0x7A9AB0 Offset: 0x7A80B0 VA: 0x1807A9AB0
	public void Update() { }

	// RVA: 0x7A98C0 Offset: 0x7A7EC0 VA: 0x1807A98C0
	public void LeaveTeamClicked() { }

	// RVA: 0x7A9830 Offset: 0x7A7E30 VA: 0x1807A9830
	public void CreateTeam() { }

	// RVA: 0x7A96D0 Offset: 0x7A7CD0 VA: 0x1807A96D0
	public void AcceptJoin() { }

	// RVA: 0x7A9950 Offset: 0x7A7F50 VA: 0x1807A9950
	public void RejectJoin() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x7AA120 Offset: 0x7A8720 VA: 0x1807AA120
	private static void .cctor() { }

}

