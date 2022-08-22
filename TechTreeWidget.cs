public class TechTreeWidget : BaseMonoBehaviour // TypeDefIndex: 10918
{	// Fields
	public int id; // 0x18
	private Vector3 originalPos; // 0x1C

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x7AFF20 Offset: 0x7AE520 VA: 0x1807AFF20
	public RectTransform get_rectTransform() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 6
	public virtual bool IsLocked() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public virtual bool HasPathToUnlock() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void SetLocked(bool isLocked) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void SetSelected(bool isSelected) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public virtual void SetAbleToUnlock(bool wants) { }

	// RVA: 0x7AFDE0 Offset: 0x7AE3E0 VA: 0x1807AFDE0 Slot: 11
	public virtual void UnlockPunch(float scale = 1) { }

	// RVA: 0x7AFBF0 Offset: 0x7AE1F0 VA: 0x1807AFBF0
	public void PunchSim() { }

	// RVA: 0x7AED30 Offset: 0x7AD330 VA: 0x1807AED30
	public void .ctor() { }

}

