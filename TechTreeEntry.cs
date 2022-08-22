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

	// RVA: 0x7CCA00 Offset: 0x7CB000 VA: 0x1807CCA00 Slot: 6
	public override bool IsLocked() { }

	// RVA: 0x7CCC80 Offset: 0x7CB280 VA: 0x1807CCC80 Slot: 9
	public override void SetSelected(bool wantsSelected) { }

	// RVA: 0x7CCD70 Offset: 0x7CB370 VA: 0x1807CCD70
	private void UpdateRadialFill() { }

	// RVA: 0x7CCC70 Offset: 0x7CB270 VA: 0x1807CCC70 Slot: 8
	public override void SetLocked(bool isLocked) { }

	// RVA: 0x7CCC60 Offset: 0x7CB260 VA: 0x1807CCC60 Slot: 10
	public override void SetAbleToUnlock(bool wants) { }

	// RVA: 0x7CC9F0 Offset: 0x7CAFF0 VA: 0x1807CC9F0 Slot: 7
	public override bool HasPathToUnlock() { }

	// RVA: 0x7CCA10 Offset: 0x7CB010 VA: 0x1807CCA10
	public void Refresh() { }

	// RVA: 0x7CD0A0 Offset: 0x7CB6A0 VA: 0x1807CD0A0
	public void .ctor() { }

}

