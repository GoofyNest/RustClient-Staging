public class TechTreeLine : TechTreeWidget // TypeDefIndex: 10916
{	// Fields
	public RawImage center; // 0x28
	public RawImage topLeft; // 0x30
	public RawImage topRight; // 0x38
	public RawImage bottomLeft; // 0x40
	public RawImage bottomRight; // 0x48
	public RawImage centerDotted; // 0x50
	public RawImage topLeftDotted; // 0x58
	public RawImage topRightDotted; // 0x60
	public RawImage bottomLeftDotted; // 0x68
	public RawImage bottomRightDotted; // 0x70
	public int from; // 0x78
	public int to; // 0x7C
	private bool isLocked; // 0x80
	private bool targetAbove; // 0x81
	private bool targetLeft; // 0x82

	// Methods

	// RVA: 0x7AEEF0 Offset: 0x7AD4F0 VA: 0x1807AEEF0 Slot: 8
	public override void SetLocked(bool wantsLocked) { }

	// RVA: 0x7AEF00 Offset: 0x7AD500 VA: 0x1807AEF00
	public void SetTargetAbove(bool isTargetAbove) { }

	// RVA: 0x7AEF10 Offset: 0x7AD510 VA: 0x1807AEF10
	public void SetTargetToLeft(bool isLeft) { }

	// RVA: 0x7AEC90 Offset: 0x7AD290 VA: 0x1807AEC90
	public void Refresh() { }

	// RVA: 0x7AEC20 Offset: 0x7AD220 VA: 0x1807AEC20
	public void .ctor() { }

}

