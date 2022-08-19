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

	// RVA: 0x4AB180 Offset: 0x4A9780 VA: 0x1804AB180
	public void SetSelected_Internal(RelationshipManager.PlayerRelationshipInfo selected) { }

	// RVA: 0x4AB7F0 Offset: 0x4A9DF0 VA: 0x1804AB7F0
	public void Update() { }

	// RVA: 0x4AB6F0 Offset: 0x4A9CF0 VA: 0x1804AB6F0
	public void SetVisible(bool wantsVis) { }

	// RVA: 0x4AB670 Offset: 0x4A9C70 VA: 0x1804AB670
	public static void SetSelected(RelationshipManager.PlayerRelationshipInfo selected) { }

	// RVA: 0x4AAF90 Offset: 0x4A9590 VA: 0x1804AAF90
	public void OnNoteTextChanged() { }

	// RVA: 0x4AB170 Offset: 0x4A9770 VA: 0x1804AB170
	public bool SelectedValid() { }

	// RVA: 0x4AAE40 Offset: 0x4A9440 VA: 0x1804AAE40
	public void MakeAlly() { }

	// RVA: 0x4AAF20 Offset: 0x4A9520 VA: 0x1804AAF20
	public void MakeSeen() { }

	// RVA: 0x4AAEB0 Offset: 0x4A94B0 VA: 0x1804AAEB0
	public void MakeEnemy() { }

	// RVA: 0x4AADD0 Offset: 0x4A93D0 VA: 0x1804AADD0
	public void Forget() { }

	// RVA: 0x4AB750 Offset: 0x4A9D50 VA: 0x1804AB750
	public void ToggleMute(bool state) { }

	// RVA: 0x4AB0B0 Offset: 0x4A96B0 VA: 0x1804AB0B0
	public void ReportPlayer() { }

	// RVA: 0x4AB980 Offset: 0x4A9F80 VA: 0x1804AB980
	public void .ctor() { }

}

