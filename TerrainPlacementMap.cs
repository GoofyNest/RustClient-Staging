public class TerrainPlacementMap : TerrainMap<bool> // TypeDefIndex: 10412
{	// Fields
	private bool isEnabled; // 0x48

	// Methods

	// RVA: 0x11512E0 Offset: 0x114F8E0 VA: 0x1811512E0 Slot: 4
	public override void Setup() { }

	// RVA: 0x1150D50 Offset: 0x114F350 VA: 0x181150D50 Slot: 5
	public override void PostSetup() { }

	// RVA: 0xA999F0 Offset: 0xA97FF0 VA: 0x180A999F0
	public void Enable() { }

	// RVA: 0xFD5670 Offset: 0xFD3C70 VA: 0x180FD5670
	public void Disable() { }

	// RVA: 0x1150D80 Offset: 0x114F380 VA: 0x181150D80
	public void Reset() { }

	// RVA: 0x11509D0 Offset: 0x114EFD0 VA: 0x1811509D0
	public bool GetBlocked(Vector3 worldPos) { }

	// RVA: 0x1150930 Offset: 0x114EF30 VA: 0x181150930
	public bool GetBlocked(float normX, float normZ) { }

	// RVA: 0x1150B90 Offset: 0x114F190 VA: 0x181150B90
	public bool GetBlocked(int x, int z) { }

	// RVA: 0x1150F70 Offset: 0x114F570 VA: 0x181150F70
	public void SetBlocked(Vector3 worldPos) { }

	// RVA: 0x1150EB0 Offset: 0x114F4B0 VA: 0x181150EB0
	public void SetBlocked(float normX, float normZ) { }

	// RVA: 0x1150F30 Offset: 0x114F530 VA: 0x181150F30
	public void SetBlocked(int x, int z) { }

	// RVA: 0x1150BF0 Offset: 0x114F1F0 VA: 0x181150BF0
	public bool GetBlocked(Vector3 worldPos, float radius) { }

	// RVA: 0x11507C0 Offset: 0x114EDC0 VA: 0x1811507C0
	public bool GetBlocked(float normX, float normZ, float radius) { }

	// RVA: 0x1151110 Offset: 0x114F710 VA: 0x181151110
	public void SetBlocked(Vector3 worldPos, float radius, float fade = 0) { }

	// RVA: 0x1150DF0 Offset: 0x114F3F0 VA: 0x181150DF0
	public void SetBlocked(float normX, float normZ, float radius, float fade = 0) { }

	// RVA: 0x11513D0 Offset: 0x114F9D0 VA: 0x1811513D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1151380 Offset: 0x114F980 VA: 0x181151380
	private void <SetBlocked>b__15_0(int x, int z, float lerp) { }

}

