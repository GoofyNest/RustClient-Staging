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

	// RVA: 0x802EA0 Offset: 0x8014A0 VA: 0x180802EA0
	public static bool get_IsRecordingVoicemail() { }

	// RVA: 0x802A70 Offset: 0x801070 VA: 0x180802A70
	public void ShowRecordingDialog(float recordingTime) { }

	// RVA: 0x8026A0 Offset: 0x800CA0 VA: 0x1808026A0
	public void ShowBrowsingDialog(List<VoicemailEntry> ids, int maxVoicemail) { }

	// RVA: 0x802CA0 Offset: 0x8012A0 VA: 0x180802CA0
	private void Update() { }

	// RVA: 0x802520 Offset: 0x800B20 VA: 0x180802520
	public void CloseDialog() { }

	// RVA: 0x802B50 Offset: 0x801150 VA: 0x180802B50
	public void StopPlayingAllVoicemails(VoicemailEntry exceptFor) { }

	// RVA: 0x8025C0 Offset: 0x800BC0 VA: 0x1808025C0
	public void OnDeletedVoicemail(VoicemailEntry entry) { }

	// RVA: 0x802E30 Offset: 0x801430 VA: 0x180802E30
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

