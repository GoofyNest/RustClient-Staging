public class TechTreeEntry : TechTreeWidget // TypeDefIndex: 10914
{	// Fields
	public RawImage icon; // 0x28
	public GameObject ableToUnlockBackground; // 0x30
	public GameObject unlockedBackground; // 0x38
	public GameObject lockedBackground; // 0x40
	public GameObject lockOverlay; // 0x48
	public GameObject selectedBackground; // 0x50
	public Image radialUnlock; // 0x58
	public float holdTime; // 0x60
	private bool locked; // 0x64
	private bool pathToUnlock; // 0x65
	private bool isSelected; // 0x66
	private float radialFillTime; // 0x68

	// Methods

	// RVA: 0x7AE610 Offset: 0x7ACC10 VA: 0x1807AE610 Slot: 6
	public override bool IsLocked() { }

	// RVA: 0x7AE890 Offset: 0x7ACE90 VA: 0x1807AE890 Slot: 9
	public override void SetSelected(bool wantsSelected) { }

	// RVA: 0x7AE980 Offset: 0x7ACF80 VA: 0x1807AE980
	private void UpdateRadialFill() { }

	// RVA: 0x7AE880 Offset: 0x7ACE80 VA: 0x1807AE880 Slot: 8
	public override void SetLocked(bool isLocked) { }

	// RVA: 0x7AE870 Offset: 0x7ACE70 VA: 0x1807AE870 Slot: 10
	public override void SetAbleToUnlock(bool wants) { }

	// RVA: 0x7AE600 Offset: 0x7ACC00 VA: 0x1807AE600 Slot: 7
	public override bool HasPathToUnlock() { }

	// RVA: 0x7AE620 Offset: 0x7ACC20 VA: 0x1807AE620
	public void Refresh() { }

	// RVA: 0x7AECB0 Offset: 0x7AD2B0 VA: 0x1807AECB0
	public void .ctor() { }

}

