public abstract class TerrainMap : TerrainExtension // TypeDefIndex: 10408
{	// Fields
	internal int res; // 0x30

	// Methods

	// RVA: 0x1145C00 Offset: 0x1144200 VA: 0x181145C00
	public void ApplyFilter(float normX, float normZ, float radius, float fade, Action<int, int, float> action) { }

	// RVA: 0x1147C90 Offset: 0x1146290 VA: 0x181147C90
	public void ForEach(Vector3 worldPos, float radius, Action<int, int> action) { }

	// RVA: 0x1146F00 Offset: 0x1145500 VA: 0x181146F00
	public void ForEachParallel(Vector3 v0, Vector3 v1, Vector3 v2, Action<int, int> action) { }

	// RVA: 0x1146D10 Offset: 0x1145310 VA: 0x181146D10
	public void ForEachParallel(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action) { }

	// RVA: 0x11477A0 Offset: 0x1145DA0 VA: 0x1811477A0
	public void ForEach(Vector3 v0, Vector3 v1, Vector3 v2, Action<int, int> action) { }

	// RVA: 0x1147700 Offset: 0x1145D00 VA: 0x181147700
	public void ForEach(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action) { }

	// RVA: 0x1145FD0 Offset: 0x11445D0 VA: 0x181145FD0
	private void ForEachInternal(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action, Vector2i min, Vector2i max) { }

	// RVA: 0x1146710 Offset: 0x1144D10 VA: 0x181146710
	public void ForEachParallel(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Action<int, int> action) { }

	// RVA: 0x1147380 Offset: 0x1145980 VA: 0x181147380
	public void ForEachParallel(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action) { }

	// RVA: 0x1147FC0 Offset: 0x11465C0 VA: 0x181147FC0
	public void ForEach(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Action<int, int> action) { }

	// RVA: 0x1147F10 Offset: 0x1146510 VA: 0x181147F10
	public void ForEach(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action) { }

	// RVA: 0x11462D0 Offset: 0x11448D0 VA: 0x1811462D0
	private void ForEachInternal(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action, Vector2i min, Vector2i max) { }

	// RVA: 0x1147660 Offset: 0x1145C60 VA: 0x181147660
	public void ForEach(int x_min, int x_max, int z_min, int z_max, Action<int, int> action) { }

	// RVA: 0x11475D0 Offset: 0x1145BD0 VA: 0x1811475D0
	public void ForEach(Action<int, int> action) { }

	// RVA: 0x1148640 Offset: 0x1146C40 VA: 0x181148640
	public int Index(float normalized) { }

	// RVA: 0x1145FB0 Offset: 0x11445B0 VA: 0x181145FB0
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

	// RVA: 0x11558A0 Offset: 0x1153EA0 VA: 0x1811558A0
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

	// RVA: 0x1155CA0 Offset: 0x11542A0 VA: 0x181155CA0
	internal void <ForEachParallel>b__0(int thread_id, int thread_count) { }

}

