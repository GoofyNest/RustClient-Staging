public class TerrainPlacementMap : TerrainMap<bool> // TypeDefIndex: 10412
{	// Fields
	private bool isEnabled; // 0x48

	// Methods

	// RVA: 0x1151D50 Offset: 0x1150350 VA: 0x181151D50 Slot: 4
	public override void Setup() { }

	// RVA: 0x11517C0 Offset: 0x114FDC0 VA: 0x1811517C0 Slot: 5
	public override void PostSetup() { }

	// RVA: 0xA99EC0 Offset: 0xA984C0 VA: 0x180A99EC0
	public void Enable() { }

	// RVA: 0xFD6110 Offset: 0xFD4710 VA: 0x180FD6110
	public void Disable() { }

	// RVA: 0x11517F0 Offset: 0x114FDF0 VA: 0x1811517F0
	public void Reset() { }

	// RVA: 0x1151440 Offset: 0x114FA40 VA: 0x181151440
	public bool GetBlocked(Vector3 worldPos) { }

	// RVA: 0x11513A0 Offset: 0x114F9A0 VA: 0x1811513A0
	public bool GetBlocked(float normX, float normZ) { }

	// RVA: 0x1151600 Offset: 0x114FC00 VA: 0x181151600
	public bool GetBlocked(int x, int z) { }

	// RVA: 0x11519E0 Offset: 0x114FFE0 VA: 0x1811519E0
	public void SetBlocked(Vector3 worldPos) { }

	// RVA: 0x1151920 Offset: 0x114FF20 VA: 0x181151920
	public void SetBlocked(float normX, float normZ) { }

	// RVA: 0x11519A0 Offset: 0x114FFA0 VA: 0x1811519A0
	public void SetBlocked(int x, int z) { }

	// RVA: 0x1151660 Offset: 0x114FC60 VA: 0x181151660
	public bool GetBlocked(Vector3 worldPos, float radius) { }

	// RVA: 0x1151230 Offset: 0x114F830 VA: 0x181151230
	public bool GetBlocked(float normX, float normZ, float radius) { }

	// RVA: 0x1151B80 Offset: 0x1150180 VA: 0x181151B80
	public void SetBlocked(Vector3 worldPos, float radius, float fade = 0) { }

	// RVA: 0x1151860 Offset: 0x114FE60 VA: 0x181151860
	public void SetBlocked(float normX, float normZ, float radius, float fade = 0) { }

	// RVA: 0x1151E40 Offset: 0x1150440 VA: 0x181151E40
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1151DF0 Offset: 0x11503F0 VA: 0x181151DF0
	private void <SetBlocked>b__15_0(int x, int z, float lerp) { }

}

