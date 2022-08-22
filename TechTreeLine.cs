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

	// RVA: 0x7CD3F0 Offset: 0x7CB9F0 VA: 0x1807CD3F0 Slot: 8
	public override void SetLocked(bool wantsLocked) { }

	// RVA: 0x7CD400 Offset: 0x7CBA00 VA: 0x1807CD400
	public void SetTargetAbove(bool isTargetAbove) { }

	// RVA: 0x7CD410 Offset: 0x7CBA10 VA: 0x1807CD410
	public void SetTargetToLeft(bool isLeft) { }

	// RVA: 0x7CD190 Offset: 0x7CB790 VA: 0x1807CD190
	public void Refresh() { }

	// RVA: 0x7CD120 Offset: 0x7CB720 VA: 0x1807CD120
	public void .ctor() { }

}

