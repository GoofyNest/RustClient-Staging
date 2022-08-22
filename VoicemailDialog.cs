public class VoicemailDialog : MonoBehaviour // TypeDefIndex: 10901
{	// Fields
	public GameObject RecordingRoot; // 0x18
	public RustSlider RecordingProgress; // 0x20
	public GameObject BrowsingRoot; // 0x28
	public PhoneDialler ParentDialler; // 0x30
	public GameObjectRef VoicemailEntry; // 0x38
	public Transform VoicemailEntriesRoot; // 0x40
	public GameObject NoVoicemailRoot; // 0x48
	public GameObject NoCassetteRoot; // 0x50
	private static float endTime; // 0x0
	private float duration; // 0x58
	private List<VoicemailEntry> toRetire; // 0x60

	// Properties
	public static bool IsRecordingVoicemail { get; }

	// Methods

	// RVA: 0x803430 Offset: 0x801A30 VA: 0x180803430
	public static bool get_IsRecordingVoicemail() { }

	// RVA: 0x803000 Offset: 0x801600 VA: 0x180803000
	public void ShowRecordingDialog(float recordingTime) { }

	// RVA: 0x802C30 Offset: 0x801230 VA: 0x180802C30
	public void ShowBrowsingDialog(List<VoicemailEntry> ids, int maxVoicemail) { }

	// RVA: 0x803230 Offset: 0x801830 VA: 0x180803230
	private void Update() { }

	// RVA: 0x802AB0 Offset: 0x8010B0 VA: 0x180802AB0
	public void CloseDialog() { }

	// RVA: 0x8030E0 Offset: 0x8016E0 VA: 0x1808030E0
	public void StopPlayingAllVoicemails(VoicemailEntry exceptFor) { }

	// RVA: 0x802B50 Offset: 0x801150 VA: 0x180802B50
	public void OnDeletedVoicemail(VoicemailEntry entry) { }

	// RVA: 0x8033C0 Offset: 0x8019C0 VA: 0x1808033C0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

