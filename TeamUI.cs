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

	// RVA: 0x7A99A0 Offset: 0x7A7FA0 VA: 0x1807A99A0
	public void Update() { }

	// RVA: 0x7A97B0 Offset: 0x7A7DB0 VA: 0x1807A97B0
	public void LeaveTeamClicked() { }

	// RVA: 0x7A9720 Offset: 0x7A7D20 VA: 0x1807A9720
	public void CreateTeam() { }

	// RVA: 0x7A95C0 Offset: 0x7A7BC0 VA: 0x1807A95C0
	public void AcceptJoin() { }

	// RVA: 0x7A9840 Offset: 0x7A7E40 VA: 0x1807A9840
	public void RejectJoin() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x7AA010 Offset: 0x7A8610 VA: 0x1807AA010
	private static void .cctor() { }

}

