public class TechTreeWidget : BaseMonoBehaviour // TypeDefIndex: 10918
{	public int id; // 0x18
	private Vector3 originalPos; // 0x1C

	public RectTransform rectTransform { get; }


	public RectTransform get_rectTransform() { }

	public virtual bool IsLocked() { }

	public virtual bool HasPathToUnlock() { }

	public virtual void SetLocked(bool isLocked) { }

	public virtual void SetSelected(bool isSelected) { }

	public virtual void SetAbleToUnlock(bool wants) { }

	public virtual void UnlockPunch(float scale = 1) { }

	public void PunchSim() { }

	public void .ctor() { }

}

