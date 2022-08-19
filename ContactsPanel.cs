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

	// RVA: 0x6B74C0 Offset: 0x6B5AC0 VA: 0x1806B74C0
	public RectTransform BucketFromType(RelationshipManager.RelationshipType type) { }

	// RVA: 0x6B7B10 Offset: 0x6B6110 VA: 0x1806B7B10
	public void Repopulate() { }

	// RVA: 0x6B8300 Offset: 0x6B6900 VA: 0x1806B8300
	public void SelectRelationshipType(int type) { }

	// RVA: 0x6B7910 Offset: 0x6B5F10 VA: 0x1806B7910
	public static RelationshipManager.PlayerRelationshipInfo GetSelectedContact() { }

	// RVA: 0x6B7830 Offset: 0x6B5E30 VA: 0x1806B7830
	public void DeselectContact(ContactsEntry deselected) { }

	// RVA: 0x6B7840 Offset: 0x6B5E40 VA: 0x1806B7840
	public static void DeselectContact() { }

	// RVA: 0x6B75A0 Offset: 0x6B5BA0 VA: 0x1806B75A0
	public void ContactClicked(ContactsEntry selected) { }

	// RVA: 0x6B8590 Offset: 0x6B6B90 VA: 0x1806B8590
	private bool WantsUpdate() { }

	// RVA: 0x6B84E0 Offset: 0x6B6AE0 VA: 0x1806B84E0
	public void Update() { }

	// RVA: 0x4C7920 Offset: 0x4C5F20 VA: 0x1804C7920
	public void MarkDirty() { }

	// RVA: 0x6B7AA0 Offset: 0x6B60A0 VA: 0x1806B7AA0
	public static void ReceivedNewContacts() { }

	// RVA: 0x6A38F0 Offset: 0x6A1EF0 VA: 0x1806A38F0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6B7560 Offset: 0x6B5B60 VA: 0x1806B7560
	private static int CompareRecentlySeen(RelationshipManager.PlayerRelationshipInfo a, RelationshipManager.PlayerRelationshipInfo b) { }

	// RVA: 0x6B83B0 Offset: 0x6B69B0 VA: 0x1806B83B0
	public void SetSortOff() { }

	// RVA: 0x6B8420 Offset: 0x6B6A20 VA: 0x1806B8420
	public void SetSortOn() { }

	// RVA: 0x6B74F0 Offset: 0x6B5AF0 VA: 0x1806B74F0
	private void ChangeSortMode(ContactsPanel.SortMode newMode) { }

	// RVA: 0x6B8490 Offset: 0x6B6A90 VA: 0x1806B8490
	private void UpdateSortText() { }

	// RVA: 0x6B85C0 Offset: 0x6B6BC0 VA: 0x1806B85C0
	public void .ctor() { }

}

public enum ContactsPanel.SortMode // TypeDefIndex: 10940
{	// Fields
	public int value__; // 0x0
	public const ContactsPanel.SortMode None = 0;
	public const ContactsPanel.SortMode RecentlySeen = 1;

}

