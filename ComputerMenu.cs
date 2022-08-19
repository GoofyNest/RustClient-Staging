public class ComputerMenu : UIDialog // TypeDefIndex: 8685
{	// Fields
	public RectTransform bookmarkContainer; // 0x30
	public GameObject bookmarkPrefab; // 0x38
	public List<RCBookmarkEntry> activeEntries; // 0x40
	public EntityRef ownerComputer; // 0x48

	// Methods

	// RVA: 0x6D2DB0 Offset: 0x6D13B0 VA: 0x1806D2DB0 Slot: 10
	public virtual void InitMenu(BaseEntity computer) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	public virtual bool WantsEyeOverride() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 12
	public virtual Transform GetCameraOverrideTransform() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 13
	public virtual BasePlayer.CameraMode GetCameraMode() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 14
	public virtual void BookmarkPressed(RCBookmarkEntry entry) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public virtual void DisconnectPressed(RCBookmarkEntry entry) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	public virtual void DeletePressed(RCBookmarkEntry entry) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 17
	public virtual bool IsControlling(string identifier) { }

	// RVA: 0x6D2C40 Offset: 0x6D1240 VA: 0x1806D2C40
	public void ClearBookmarkEntries() { }

	// RVA: 0x6D2DE0 Offset: 0x6D13E0 VA: 0x1806D2DE0
	public void UpdateBookmarks() { }

	// RVA: 0x6D3130 Offset: 0x6D1730 VA: 0x1806D3130
	public void .ctor() { }

}

