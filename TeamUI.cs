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

	// RVA: 0x7C7EB0 Offset: 0x7C64B0 VA: 0x1807C7EB0
	public void Update() { }

	// RVA: 0x7C7CC0 Offset: 0x7C62C0 VA: 0x1807C7CC0
	public void LeaveTeamClicked() { }

	// RVA: 0x7C7C30 Offset: 0x7C6230 VA: 0x1807C7C30
	public void CreateTeam() { }

	// RVA: 0x7C7AD0 Offset: 0x7C60D0 VA: 0x1807C7AD0
	public void AcceptJoin() { }

	// RVA: 0x7C7D50 Offset: 0x7C6350 VA: 0x1807C7D50
	public void RejectJoin() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x7C8520 Offset: 0x7C6B20 VA: 0x1807C8520
	private static void .cctor() { }

}

