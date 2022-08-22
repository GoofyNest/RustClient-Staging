public class ContactsPanel : SingletonComponent<ContactsPanel> // TypeDefIndex: 10939
{	// Fields
	public RectTransform alliesBucket; // 0x18
	public RectTransform seenBucket; // 0x20
	public RectTransform enemiesBucket; // 0x28
	public RectTransform contentsBucket; // 0x30
	public ContactsEntry contactEntryPrefab; // 0x38
	public RawImage mugshotTest; // 0x40
	public RawImage fullBodyTest; // 0x48
	public RustButton[] filterButtons; // 0x50
	public RelationshipManager.RelationshipType selectedRelationshipType; // 0x58
	public RustButton lastSeenToggle; // 0x60
	public Translate.Phrase sortingByLastSeenPhrase; // 0x68
	public Translate.Phrase sortingByFirstSeen; // 0x70
	public RustText sortText; // 0x78
	private ContactsPanel.SortMode sortMode; // 0x80
	private ulong selectedPlayerID; // 0x88
	private float nextUpdateTime; // 0x90
	private bool dirty; // 0x94

	// Methods

	// RVA: 0x6B7560 Offset: 0x6B5B60 VA: 0x1806B7560
	public RectTransform BucketFromType(RelationshipManager.RelationshipType type) { }

	// RVA: 0x6B7BB0 Offset: 0x6B61B0 VA: 0x1806B7BB0
	public void Repopulate() { }

	// RVA: 0x6B83A0 Offset: 0x6B69A0 VA: 0x1806B83A0
	public void SelectRelationshipType(int type) { }

	// RVA: 0x6B79B0 Offset: 0x6B5FB0 VA: 0x1806B79B0
	public static RelationshipManager.PlayerRelationshipInfo GetSelectedContact() { }

	// RVA: 0x6B78D0 Offset: 0x6B5ED0 VA: 0x1806B78D0
	public void DeselectContact(ContactsEntry deselected) { }

	// RVA: 0x6B78E0 Offset: 0x6B5EE0 VA: 0x1806B78E0
	public static void DeselectContact() { }

	// RVA: 0x6B7640 Offset: 0x6B5C40 VA: 0x1806B7640
	public void ContactClicked(ContactsEntry selected) { }

	// RVA: 0x6B8630 Offset: 0x6B6C30 VA: 0x1806B8630
	private bool WantsUpdate() { }

	// RVA: 0x6B8580 Offset: 0x6B6B80 VA: 0x1806B8580
	public void Update() { }

	// RVA: 0x4C78B0 Offset: 0x4C5EB0 VA: 0x1804C78B0
	public void MarkDirty() { }

	// RVA: 0x6B7B40 Offset: 0x6B6140 VA: 0x1806B7B40
	public static void ReceivedNewContacts() { }

	// RVA: 0x6A3990 Offset: 0x6A1F90 VA: 0x1806A3990 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6B7600 Offset: 0x6B5C00 VA: 0x1806B7600
	private static int CompareRecentlySeen(RelationshipManager.PlayerRelationshipInfo a, RelationshipManager.PlayerRelationshipInfo b) { }

	// RVA: 0x6B8450 Offset: 0x6B6A50 VA: 0x1806B8450
	public void SetSortOff() { }

	// RVA: 0x6B84C0 Offset: 0x6B6AC0 VA: 0x1806B84C0
	public void SetSortOn() { }

	// RVA: 0x6B7590 Offset: 0x6B5B90 VA: 0x1806B7590
	private void ChangeSortMode(ContactsPanel.SortMode newMode) { }

	// RVA: 0x6B8530 Offset: 0x6B6B30 VA: 0x1806B8530
	private void UpdateSortText() { }

	// RVA: 0x6B8660 Offset: 0x6B6C60 VA: 0x1806B8660
	public void .ctor() { }

}

public enum ContactsPanel.SortMode // TypeDefIndex: 10940
{	// Fields
	public int value__; // 0x0
	public const ContactsPanel.SortMode None = 0;
	public const ContactsPanel.SortMode RecentlySeen = 1;

}

