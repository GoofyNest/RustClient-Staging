public class TechTreeWidget : BaseMonoBehaviour // TypeDefIndex: 10918
{	// Fields
	public int id; // 0x18
	private Vector3 originalPos; // 0x1C

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x7AFE10 Offset: 0x7AE410 VA: 0x1807AFE10
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

	// RVA: 0x7AFCD0 Offset: 0x7AE2D0 VA: 0x1807AFCD0 Slot: 11
	public virtual void UnlockPunch(float scale = 1) { }

	// RVA: 0x7AFAE0 Offset: 0x7AE0E0 VA: 0x1807AFAE0
	public void PunchSim() { }

	// RVA: 0x7AEC20 Offset: 0x7AD220 VA: 0x1807AEC20
	public void .ctor() { }

}

