internal class CompositeLoadAssetsResult : LoadAssetsResult // TypeDefIndex: 6657
{	// Fields
	private readonly List<LoadAssetsResult> _loads; // 0x20

	// Properties
	public override int TotalCount { get; }
	public override int CompletedCount { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x22BD830 Offset: 0x22BBE30 VA: 0x1822BD830
	public void .ctor(List<LoadAssetsResult> loads) { }

	// RVA: 0x22BDC20 Offset: 0x22BC220 VA: 0x1822BDC20 Slot: 8
	public override int get_TotalCount() { }

	// RVA: 0x22BDB20 Offset: 0x22BC120 VA: 0x1822BDB20 Slot: 9
	public override int get_CompletedCount() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void set_CompletedCount(int value) { }

	// RVA: 0x22BDD20 Offset: 0x22BC320 VA: 0x1822BDD20 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22BD570 Offset: 0x22BBB70 VA: 0x1822BD570 Slot: 11
	public override Dictionary<string, Object> GetResult() { }

	// RVA: 0x22BD4D0 Offset: 0x22BBAD0 VA: 0x1822BD4D0
	private void AssetLoadedHandler(string assetPath, Object obj) { }

}

private sealed class CompositeLoadAssetsResult.<>c // TypeDefIndex: 6658
{	// Fields
	public static readonly CompositeLoadAssetsResult.<>c <>9; // 0x0
	public static Func<LoadAssetsResult, int> <>9__3_0; // 0x8
	public static Func<LoadAssetsResult, int> <>9__5_0; // 0x10
	public static Func<LoadAssetsResult, bool> <>9__8_0; // 0x18

	// Methods

	// RVA: 0x22BEE30 Offset: 0x22BD430 VA: 0x1822BEE30
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x18022F0 Offset: 0x18008F0 VA: 0x1818022F0
	internal int <get_TotalCount>b__3_0(LoadAssetsResult l) { }

	// RVA: 0x22BE9F0 Offset: 0x22BCFF0 VA: 0x1822BE9F0
	internal int <get_CompletedCount>b__5_0(LoadAssetsResult l) { }

	// RVA: 0x22BEA20 Offset: 0x22BD020 VA: 0x1822BEA20
	internal bool <get_keepWaiting>b__8_0(LoadAssetsResult l) { }

}

