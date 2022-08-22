public class TechTreeWidget : BaseMonoBehaviour // TypeDefIndex: 10918
{	// Fields
	public int id; // 0x18
	private Vector3 originalPos; // 0x1C

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x7CE310 Offset: 0x7CC910 VA: 0x1807CE310
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

	// RVA: 0x7CE1D0 Offset: 0x7CC7D0 VA: 0x1807CE1D0 Slot: 11
	public virtual void UnlockPunch(float scale = 1) { }

	// RVA: 0x7CDFE0 Offset: 0x7CC5E0 VA: 0x1807CDFE0
	public void PunchSim() { }

	// RVA: 0x7CD120 Offset: 0x7CB720 VA: 0x1807CD120
	public void .ctor() { }

}

