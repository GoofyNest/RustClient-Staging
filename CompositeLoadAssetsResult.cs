internal class CompositeLoadAssetsResult : LoadAssetsResult // TypeDefIndex: 6657
{	// Fields
	private readonly List<LoadAssetsResult> _loads; // 0x20

	// Properties
	public override int TotalCount { get; }
	public override int CompletedCount { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x22BCF10 Offset: 0x22BB510 VA: 0x1822BCF10
	public void .ctor(List<LoadAssetsResult> loads) { }

	// RVA: 0x22BD300 Offset: 0x22BB900 VA: 0x1822BD300 Slot: 8
	public override int get_TotalCount() { }

	// RVA: 0x22BD200 Offset: 0x22BB800 VA: 0x1822BD200 Slot: 9
	public override int get_CompletedCount() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void set_CompletedCount(int value) { }

	// RVA: 0x22BD400 Offset: 0x22BBA00 VA: 0x1822BD400 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22BCC50 Offset: 0x22BB250 VA: 0x1822BCC50 Slot: 11
	public override Dictionary<string, Object> GetResult() { }

	// RVA: 0x22BCBB0 Offset: 0x22BB1B0 VA: 0x1822BCBB0
	private void AssetLoadedHandler(string assetPath, Object obj) { }

}

private sealed class CompositeLoadAssetsResult.<>c // TypeDefIndex: 6658
{	// Fields
	public static readonly CompositeLoadAssetsResult.<>c <>9; // 0x0
	public static Func<LoadAssetsResult, int> <>9__3_0; // 0x8
	public static Func<LoadAssetsResult, int> <>9__5_0; // 0x10
	public static Func<LoadAssetsResult, bool> <>9__8_0; // 0x18

	// Methods

	// RVA: 0x22BE510 Offset: 0x22BCB10 VA: 0x1822BE510
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1814BF0 Offset: 0x18131F0 VA: 0x181814BF0
	internal int <get_TotalCount>b__3_0(LoadAssetsResult l) { }

	// RVA: 0x22BE0D0 Offset: 0x22BC6D0 VA: 0x1822BE0D0
	internal int <get_CompletedCount>b__5_0(LoadAssetsResult l) { }

	// RVA: 0x22BE100 Offset: 0x22BC700 VA: 0x1822BE100
	internal bool <get_keepWaiting>b__8_0(LoadAssetsResult l) { }

}

