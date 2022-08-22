public abstract class TerrainMap : TerrainExtension // TypeDefIndex: 10408
{	// Fields
	internal int res; // 0x30

	// Methods

	// RVA: 0x1146670 Offset: 0x1144C70 VA: 0x181146670
	public void ApplyFilter(float normX, float normZ, float radius, float fade, Action<int, int, float> action) { }

	// RVA: 0x1148700 Offset: 0x1146D00 VA: 0x181148700
	public void ForEach(Vector3 worldPos, float radius, Action<int, int> action) { }

	// RVA: 0x1147970 Offset: 0x1145F70 VA: 0x181147970
	public void ForEachParallel(Vector3 v0, Vector3 v1, Vector3 v2, Action<int, int> action) { }

	// RVA: 0x1147780 Offset: 0x1145D80 VA: 0x181147780
	public void ForEachParallel(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action) { }

	// RVA: 0x1148210 Offset: 0x1146810 VA: 0x181148210
	public void ForEach(Vector3 v0, Vector3 v1, Vector3 v2, Action<int, int> action) { }

	// RVA: 0x1148170 Offset: 0x1146770 VA: 0x181148170
	public void ForEach(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action) { }

	// RVA: 0x1146A40 Offset: 0x1145040 VA: 0x181146A40
	private void ForEachInternal(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action, Vector2i min, Vector2i max) { }

	// RVA: 0x1147180 Offset: 0x1145780 VA: 0x181147180
	public void ForEachParallel(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Action<int, int> action) { }

	// RVA: 0x1147DF0 Offset: 0x11463F0 VA: 0x181147DF0
	public void ForEachParallel(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action) { }

	// RVA: 0x1148A30 Offset: 0x1147030 VA: 0x181148A30
	public void ForEach(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Action<int, int> action) { }

	// RVA: 0x1148980 Offset: 0x1146F80 VA: 0x181148980
	public void ForEach(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action) { }

	// RVA: 0x1146D40 Offset: 0x1145340 VA: 0x181146D40
	private void ForEachInternal(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action, Vector2i min, Vector2i max) { }

	// RVA: 0x11480D0 Offset: 0x11466D0 VA: 0x1811480D0
	public void ForEach(int x_min, int x_max, int z_min, int z_max, Action<int, int> action) { }

	// RVA: 0x1148040 Offset: 0x1146640 VA: 0x181148040
	public void ForEach(Action<int, int> action) { }

	// RVA: 0x11490B0 Offset: 0x11476B0 VA: 0x1811490B0
	public int Index(float normalized) { }

	// RVA: 0x1146A20 Offset: 0x1145020 VA: 0x181146A20
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

	// RVA: 0x1156310 Offset: 0x1154910 VA: 0x181156310
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

	// RVA: 0x1156710 Offset: 0x1154D10 VA: 0x181156710
	internal void <ForEachParallel>b__0(int thread_id, int thread_count) { }

}

