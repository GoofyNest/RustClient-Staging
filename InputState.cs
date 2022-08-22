public class InputState // TypeDefIndex: 10102
{	// Fields
	public InputMessage current; // 0x10
	public InputMessage previous; // 0x18
	private int SwallowedButtons; // 0x20

	// Methods

	// RVA: 0x813DB0 Offset: 0x8123B0 VA: 0x180813DB0
	public bool IsDown(BUTTON btn) { }

	// RVA: 0x813E80 Offset: 0x812480 VA: 0x180813E80
	public bool WasDown(BUTTON btn) { }

	// RVA: 0x813D80 Offset: 0x812380 VA: 0x180813D80
	public bool IsAnyDown() { }

	// RVA: 0x813EA0 Offset: 0x8124A0 VA: 0x180813EA0
	public bool WasJustPressed(BUTTON btn) { }

	// RVA: 0x813EE0 Offset: 0x8124E0 VA: 0x180813EE0
	public bool WasJustReleased(BUTTON btn) { }

	// RVA: 0x813E70 Offset: 0x812470 VA: 0x180813E70
	public void SwallowButton(BUTTON btn) { }

	// RVA: 0x813B40 Offset: 0x812140 VA: 0x180813B40
	public Quaternion AimAngle() { }

	// RVA: 0x813DE0 Offset: 0x8123E0 VA: 0x180813DE0
	public Vector3 MouseDelta() { }

	// RVA: 0x813CB0 Offset: 0x8122B0 VA: 0x180813CB0
	public void Flip(InputMessage newcurrent) { }

	// RVA: 0x813C00 Offset: 0x812200 VA: 0x180813C00
	public void Clear() { }

	// RVA: 0x813F20 Offset: 0x812520 VA: 0x180813F20
	public void .ctor() { }

}

