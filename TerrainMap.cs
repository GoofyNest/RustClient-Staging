public abstract class TerrainMap : TerrainExtension // TypeDefIndex: 10408
{	// Fields
	internal int res; // 0x30

	// Methods

	// RVA: 0x1145940 Offset: 0x1143F40 VA: 0x181145940
	public void ApplyFilter(float normX, float normZ, float radius, float fade, Action<int, int, float> action) { }

	// RVA: 0x11479D0 Offset: 0x1145FD0 VA: 0x1811479D0
	public void ForEach(Vector3 worldPos, float radius, Action<int, int> action) { }

	// RVA: 0x1146C40 Offset: 0x1145240 VA: 0x181146C40
	public void ForEachParallel(Vector3 v0, Vector3 v1, Vector3 v2, Action<int, int> action) { }

	// RVA: 0x1146A50 Offset: 0x1145050 VA: 0x181146A50
	public void ForEachParallel(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action) { }

	// RVA: 0x11474E0 Offset: 0x1145AE0 VA: 0x1811474E0
	public void ForEach(Vector3 v0, Vector3 v1, Vector3 v2, Action<int, int> action) { }

	// RVA: 0x1147440 Offset: 0x1145A40 VA: 0x181147440
	public void ForEach(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action) { }

	// RVA: 0x1145D10 Offset: 0x1144310 VA: 0x181145D10
	private void ForEachInternal(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action, Vector2i min, Vector2i max) { }

	// RVA: 0x1146450 Offset: 0x1144A50 VA: 0x181146450
	public void ForEachParallel(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Action<int, int> action) { }

	// RVA: 0x11470C0 Offset: 0x11456C0 VA: 0x1811470C0
	public void ForEachParallel(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action) { }

	// RVA: 0x1147D00 Offset: 0x1146300 VA: 0x181147D00
	public void ForEach(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Action<int, int> action) { }

	// RVA: 0x1147C50 Offset: 0x1146250 VA: 0x181147C50
	public void ForEach(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action) { }

	// RVA: 0x1146010 Offset: 0x1144610 VA: 0x181146010
	private void ForEachInternal(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action, Vector2i min, Vector2i max) { }

	// RVA: 0x11473A0 Offset: 0x11459A0 VA: 0x1811473A0
	public void ForEach(int x_min, int x_max, int z_min, int z_max, Action<int, int> action) { }

	// RVA: 0x1147310 Offset: 0x1145910 VA: 0x181147310
	public void ForEach(Action<int, int> action) { }

	// RVA: 0x1148380 Offset: 0x1146980 VA: 0x181148380
	public int Index(float normalized) { }

	// RVA: 0x1145CF0 Offset: 0x11442F0 VA: 0x181145CF0
	public float Coordinate(int index) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

private sealed class TerrainMap.<>c__DisplayClass4_0 // TypeDefIndex: 10409
{	// Fields
	public Vector2i base_min; // 0x10
	public Vector2i base_count; // 0x18
	public TerrainMap <>4__this; // 0x20
	public Vector2i v0; // 0x28
	public Vector2i v1; // 0x30
	public Vector2i v2; // 0x38
	public Action<int, int> action; // 0x40

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11555E0 Offset: 0x1153BE0 VA: 0x1811555E0
	internal void <ForEachParallel>b__0(int thread_id, int thread_count) { }

}

private sealed class TerrainMap.<>c__DisplayClass9_0 // TypeDefIndex: 10410
{	// Fields
	public Vector2i base_min; // 0x10
	public Vector2i size_y; // 0x18
	public Vector2i size_x; // 0x20
	public TerrainMap <>4__this; // 0x28
	public Vector2i v0; // 0x30
	public Vector2i v1; // 0x38
	public Vector2i v2; // 0x40
	public Vector2i v3; // 0x48
	public Action<int, int> action; // 0x50

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11559E0 Offset: 0x1153FE0 VA: 0x1811559E0
	internal void <ForEachParallel>b__0(int thread_id, int thread_count) { }

}

