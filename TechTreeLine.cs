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

	// RVA: 0x7AF000 Offset: 0x7AD600 VA: 0x1807AF000 Slot: 8
	public override void SetLocked(bool wantsLocked) { }

	// RVA: 0x7AF010 Offset: 0x7AD610 VA: 0x1807AF010
	public void SetTargetAbove(bool isTargetAbove) { }

	// RVA: 0x7AF020 Offset: 0x7AD620 VA: 0x1807AF020
	public void SetTargetToLeft(bool isLeft) { }

	// RVA: 0x7AEDA0 Offset: 0x7AD3A0 VA: 0x1807AEDA0
	public void Refresh() { }

	// RVA: 0x7AED30 Offset: 0x7AD330 VA: 0x1807AED30
	public void .ctor() { }

}

