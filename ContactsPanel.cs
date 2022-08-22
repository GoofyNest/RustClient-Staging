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

	// RVA: 0x6B75D0 Offset: 0x6B5BD0 VA: 0x1806B75D0
	public RectTransform BucketFromType(RelationshipManager.RelationshipType type) { }

	// RVA: 0x6B7C20 Offset: 0x6B6220 VA: 0x1806B7C20
	public void Repopulate() { }

	// RVA: 0x6B8410 Offset: 0x6B6A10 VA: 0x1806B8410
	public void SelectRelationshipType(int type) { }

	// RVA: 0x6B7A20 Offset: 0x6B6020 VA: 0x1806B7A20
	public static RelationshipManager.PlayerRelationshipInfo GetSelectedContact() { }

	// RVA: 0x6B7940 Offset: 0x6B5F40 VA: 0x1806B7940
	public void DeselectContact(ContactsEntry deselected) { }

	// RVA: 0x6B7950 Offset: 0x6B5F50 VA: 0x1806B7950
	public static void DeselectContact() { }

	// RVA: 0x6B76B0 Offset: 0x6B5CB0 VA: 0x1806B76B0
	public void ContactClicked(ContactsEntry selected) { }

	// RVA: 0x6B86A0 Offset: 0x6B6CA0 VA: 0x1806B86A0
	private bool WantsUpdate() { }

	// RVA: 0x6B85F0 Offset: 0x6B6BF0 VA: 0x1806B85F0
	public void Update() { }

	// RVA: 0x4C7920 Offset: 0x4C5F20 VA: 0x1804C7920
	public void MarkDirty() { }

	// RVA: 0x6B7BB0 Offset: 0x6B61B0 VA: 0x1806B7BB0
	public static void ReceivedNewContacts() { }

	// RVA: 0x6A3A00 Offset: 0x6A2000 VA: 0x1806A3A00 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6B7670 Offset: 0x6B5C70 VA: 0x1806B7670
	private static int CompareRecentlySeen(RelationshipManager.PlayerRelationshipInfo a, RelationshipManager.PlayerRelationshipInfo b) { }

	// RVA: 0x6B84C0 Offset: 0x6B6AC0 VA: 0x1806B84C0
	public void SetSortOff() { }

	// RVA: 0x6B8530 Offset: 0x6B6B30 VA: 0x1806B8530
	public void SetSortOn() { }

	// RVA: 0x6B7600 Offset: 0x6B5C00 VA: 0x1806B7600
	private void ChangeSortMode(ContactsPanel.SortMode newMode) { }

	// RVA: 0x6B85A0 Offset: 0x6B6BA0 VA: 0x1806B85A0
	private void UpdateSortText() { }

	// RVA: 0x6B86D0 Offset: 0x6B6CD0 VA: 0x1806B86D0
	public void .ctor() { }

}

public enum ContactsPanel.SortMode // TypeDefIndex: 10940
{	// Fields
	public int value__; // 0x0
	public const ContactsPanel.SortMode None = 0;
	public const ContactsPanel.SortMode RecentlySeen = 1;

}

