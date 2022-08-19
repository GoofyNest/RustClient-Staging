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

	// RVA: 0x7AE500 Offset: 0x7ACB00 VA: 0x1807AE500 Slot: 6
	public override bool IsLocked() { }

	// RVA: 0x7AE780 Offset: 0x7ACD80 VA: 0x1807AE780 Slot: 9
	public override void SetSelected(bool wantsSelected) { }

	// RVA: 0x7AE870 Offset: 0x7ACE70 VA: 0x1807AE870
	private void UpdateRadialFill() { }

	// RVA: 0x7AE770 Offset: 0x7ACD70 VA: 0x1807AE770 Slot: 8
	public override void SetLocked(bool isLocked) { }

	// RVA: 0x7AE760 Offset: 0x7ACD60 VA: 0x1807AE760 Slot: 10
	public override void SetAbleToUnlock(bool wants) { }

	// RVA: 0x7AE4F0 Offset: 0x7ACAF0 VA: 0x1807AE4F0 Slot: 7
	public override bool HasPathToUnlock() { }

	// RVA: 0x7AE510 Offset: 0x7ACB10 VA: 0x1807AE510
	public void Refresh() { }

	// RVA: 0x7AEBA0 Offset: 0x7AD1A0 VA: 0x1807AEBA0
	public void .ctor() { }

}

