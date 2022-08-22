public class SelectedContact : SingletonComponent<SelectedContact> // TypeDefIndex: 10970
{	// Fields
	public RustText nameText; // 0x18
	public RustText seenText; // 0x20
	public RawImage mugshotImage; // 0x28
	public Texture2D unknownMugshot; // 0x30
	public InputField noteInput; // 0x38
	public GameObject[] relationshipTypeTags; // 0x40
	public Translate.Phrase lastSeenPrefix; // 0x48
	public Translate.Phrase nowPhrase; // 0x50
	public Translate.Phrase agoSuffix; // 0x58
	public RustButton FriendlyButton; // 0x60
	public RustButton SeenButton; // 0x68
	public RustButton EnemyButton; // 0x70
	public RustButton chatMute; // 0x78
	private ulong selectedPlayerId; // 0x80
	private RelationshipManager.RelationshipType selectedPlayerRelationship; // 0x88

	// Methods

	// RVA: 0x4AB110 Offset: 0x4A9710 VA: 0x1804AB110
	public void SetSelected_Internal(RelationshipManager.PlayerRelationshipInfo selected) { }

	// RVA: 0x4AB780 Offset: 0x4A9D80 VA: 0x1804AB780
	public void Update() { }

	// RVA: 0x4AB680 Offset: 0x4A9C80 VA: 0x1804AB680
	public void SetVisible(bool wantsVis) { }

	// RVA: 0x4AB600 Offset: 0x4A9C00 VA: 0x1804AB600
	public static void SetSelected(RelationshipManager.PlayerRelationshipInfo selected) { }

	// RVA: 0x4AAF20 Offset: 0x4A9520 VA: 0x1804AAF20
	public void OnNoteTextChanged() { }

	// RVA: 0x4AB100 Offset: 0x4A9700 VA: 0x1804AB100
	public bool SelectedValid() { }

	// RVA: 0x4AADD0 Offset: 0x4A93D0 VA: 0x1804AADD0
	public void MakeAlly() { }

	// RVA: 0x4AAEB0 Offset: 0x4A94B0 VA: 0x1804AAEB0
	public void MakeSeen() { }

	// RVA: 0x4AAE40 Offset: 0x4A9440 VA: 0x1804AAE40
	public void MakeEnemy() { }

	// RVA: 0x4AAD60 Offset: 0x4A9360 VA: 0x1804AAD60
	public void Forget() { }

	// RVA: 0x4AB6E0 Offset: 0x4A9CE0 VA: 0x1804AB6E0
	public void ToggleMute(bool state) { }

	// RVA: 0x4AB040 Offset: 0x4A9640 VA: 0x1804AB040
	public void ReportPlayer() { }

	// RVA: 0x4AB910 Offset: 0x4A9F10 VA: 0x1804AB910
	public void .ctor() { }

}

