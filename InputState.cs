public class InputState // TypeDefIndex: 10102
{	// Fields
	public InputMessage current; // 0x10
	public InputMessage previous; // 0x18
	private int SwallowedButtons; // 0x20

	// Methods

	// RVA: 0x814340 Offset: 0x812940 VA: 0x180814340
	public bool IsDown(BUTTON btn) { }

	// RVA: 0x814410 Offset: 0x812A10 VA: 0x180814410
	public bool WasDown(BUTTON btn) { }

	// RVA: 0x814310 Offset: 0x812910 VA: 0x180814310
	public bool IsAnyDown() { }

	// RVA: 0x814430 Offset: 0x812A30 VA: 0x180814430
	public bool WasJustPressed(BUTTON btn) { }

	// RVA: 0x814470 Offset: 0x812A70 VA: 0x180814470
	public bool WasJustReleased(BUTTON btn) { }

	// RVA: 0x814400 Offset: 0x812A00 VA: 0x180814400
	public void SwallowButton(BUTTON btn) { }

	// RVA: 0x8140D0 Offset: 0x8126D0 VA: 0x1808140D0
	public Quaternion AimAngle() { }

	// RVA: 0x814370 Offset: 0x812970 VA: 0x180814370
	public Vector3 MouseDelta() { }

	// RVA: 0x814240 Offset: 0x812840 VA: 0x180814240
	public void Flip(InputMessage newcurrent) { }

	// RVA: 0x814190 Offset: 0x812790 VA: 0x180814190
	public void Clear() { }

	// RVA: 0x8144B0 Offset: 0x812AB0 VA: 0x1808144B0
	public void .ctor() { }

}

