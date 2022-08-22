public class TerrainPlacementMap : TerrainMap<bool> // TypeDefIndex: 10412
{	// Fields
	private bool isEnabled; // 0x48

	// Methods

	// RVA: 0x1151020 Offset: 0x114F620 VA: 0x181151020 Slot: 4
	public override void Setup() { }

	// RVA: 0x1150A90 Offset: 0x114F090 VA: 0x181150A90 Slot: 5
	public override void PostSetup() { }

	// RVA: 0xA99730 Offset: 0xA97D30 VA: 0x180A99730
	public void Enable() { }

	// RVA: 0xFD53B0 Offset: 0xFD39B0 VA: 0x180FD53B0
	public void Disable() { }

	// RVA: 0x1150AC0 Offset: 0x114F0C0 VA: 0x181150AC0
	public void Reset() { }

	// RVA: 0x1150710 Offset: 0x114ED10 VA: 0x181150710
	public bool GetBlocked(Vector3 worldPos) { }

	// RVA: 0x1150670 Offset: 0x114EC70 VA: 0x181150670
	public bool GetBlocked(float normX, float normZ) { }

	// RVA: 0x11508D0 Offset: 0x114EED0 VA: 0x1811508D0
	public bool GetBlocked(int x, int z) { }

	// RVA: 0x1150CB0 Offset: 0x114F2B0 VA: 0x181150CB0
	public void SetBlocked(Vector3 worldPos) { }

	// RVA: 0x1150BF0 Offset: 0x114F1F0 VA: 0x181150BF0
	public void SetBlocked(float normX, float normZ) { }

	// RVA: 0x1150C70 Offset: 0x114F270 VA: 0x181150C70
	public void SetBlocked(int x, int z) { }

	// RVA: 0x1150930 Offset: 0x114EF30 VA: 0x181150930
	public bool GetBlocked(Vector3 worldPos, float radius) { }

	// RVA: 0x1150500 Offset: 0x114EB00 VA: 0x181150500
	public bool GetBlocked(float normX, float normZ, float radius) { }

	// RVA: 0x1150E50 Offset: 0x114F450 VA: 0x181150E50
	public void SetBlocked(Vector3 worldPos, float radius, float fade = 0) { }

	// RVA: 0x1150B30 Offset: 0x114F130 VA: 0x181150B30
	public void SetBlocked(float normX, float normZ, float radius, float fade = 0) { }

	// RVA: 0x1151110 Offset: 0x114F710 VA: 0x181151110
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11510C0 Offset: 0x114F6C0 VA: 0x1811510C0
	private void <SetBlocked>b__15_0(int x, int z, float lerp) { }

}

