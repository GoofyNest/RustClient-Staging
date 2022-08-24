public class TechTreeLine : TechTreeWidget // TypeDefIndex: 10920
{	public RawImage center; // 0x28
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


	public override void SetLocked(bool wantsLocked) { }

	public void SetTargetAbove(bool isTargetAbove) { }

	public void SetTargetToLeft(bool isLeft) { }

	public void Refresh() { }

	public void .ctor() { }

}

