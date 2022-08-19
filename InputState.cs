public class InputState // TypeDefIndex: 10102
{	// Fields
	public InputMessage current; // 0x10
	public InputMessage previous; // 0x18
	private int SwallowedButtons; // 0x20

	// Methods

	// RVA: 0x813CA0 Offset: 0x8122A0 VA: 0x180813CA0
	public bool IsDown(BUTTON btn) { }

	// RVA: 0x813D70 Offset: 0x812370 VA: 0x180813D70
	public bool WasDown(BUTTON btn) { }

	// RVA: 0x813C70 Offset: 0x812270 VA: 0x180813C70
	public bool IsAnyDown() { }

	// RVA: 0x813D90 Offset: 0x812390 VA: 0x180813D90
	public bool WasJustPressed(BUTTON btn) { }

	// RVA: 0x813DD0 Offset: 0x8123D0 VA: 0x180813DD0
	public bool WasJustReleased(BUTTON btn) { }

	// RVA: 0x813D60 Offset: 0x812360 VA: 0x180813D60
	public void SwallowButton(BUTTON btn) { }

	// RVA: 0x813A30 Offset: 0x812030 VA: 0x180813A30
	public Quaternion AimAngle() { }

	// RVA: 0x813CD0 Offset: 0x8122D0 VA: 0x180813CD0
	public Vector3 MouseDelta() { }

	// RVA: 0x813BA0 Offset: 0x8121A0 VA: 0x180813BA0
	public void Flip(InputMessage newcurrent) { }

	// RVA: 0x813AF0 Offset: 0x8120F0 VA: 0x180813AF0
	public void Clear() { }

	// RVA: 0x813E10 Offset: 0x812410 VA: 0x180813E10
	public void .ctor() { }

}

