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

	// RVA: 0x802D90 Offset: 0x801390 VA: 0x180802D90
	public static bool get_IsRecordingVoicemail() { }

	// RVA: 0x802960 Offset: 0x800F60 VA: 0x180802960
	public void ShowRecordingDialog(float recordingTime) { }

	// RVA: 0x802590 Offset: 0x800B90 VA: 0x180802590
	public void ShowBrowsingDialog(List<VoicemailEntry> ids, int maxVoicemail) { }

	// RVA: 0x802B90 Offset: 0x801190 VA: 0x180802B90
	private void Update() { }

	// RVA: 0x802410 Offset: 0x800A10 VA: 0x180802410
	public void CloseDialog() { }

	// RVA: 0x802A40 Offset: 0x801040 VA: 0x180802A40
	public void StopPlayingAllVoicemails(VoicemailEntry exceptFor) { }

	// RVA: 0x8024B0 Offset: 0x800AB0 VA: 0x1808024B0
	public void OnDeletedVoicemail(VoicemailEntry entry) { }

	// RVA: 0x802D20 Offset: 0x801320 VA: 0x180802D20
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

