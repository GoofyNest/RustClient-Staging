internal class CompositeLoadAssetsResult : LoadAssetsResult // TypeDefIndex: 6657
{	// Fields
	private readonly List<LoadAssetsResult> _loads; // 0x20

	// Properties
	public override int TotalCount { get; }
	public override int CompletedCount { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x22BCD50 Offset: 0x22BB350 VA: 0x1822BCD50
	public void .ctor(List<LoadAssetsResult> loads) { }

	// RVA: 0x22BD140 Offset: 0x22BB740 VA: 0x1822BD140 Slot: 8
	public override int get_TotalCount() { }

	// RVA: 0x22BD040 Offset: 0x22BB640 VA: 0x1822BD040 Slot: 9
	public override int get_CompletedCount() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void set_CompletedCount(int value) { }

	// RVA: 0x22BD240 Offset: 0x22BB840 VA: 0x1822BD240 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x22BCA90 Offset: 0x22BB090 VA: 0x1822BCA90 Slot: 11
	public override Dictionary<string, Object> GetResult() { }

	// RVA: 0x22BC9F0 Offset: 0x22BAFF0 VA: 0x1822BC9F0
	private void AssetLoadedHandler(string assetPath, Object obj) { }

}

private sealed class CompositeLoadAssetsResult.<>c // TypeDefIndex: 6658
{	// Fields
	public static readonly CompositeLoadAssetsResult.<>c <>9; // 0x0
	public static Func<LoadAssetsResult, int> <>9__3_0; // 0x8
	public static Func<LoadAssetsResult, int> <>9__5_0; // 0x10
	public static Func<LoadAssetsResult, bool> <>9__8_0; // 0x18

	// Methods

	// RVA: 0x22BE350 Offset: 0x22BC950 VA: 0x1822BE350
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1814BF0 Offset: 0x18131F0 VA: 0x181814BF0
	internal int <get_TotalCount>b__3_0(LoadAssetsResult l) { }

	// RVA: 0x22BDF10 Offset: 0x22BC510 VA: 0x1822BDF10
	internal int <get_CompletedCount>b__5_0(LoadAssetsResult l) { }

	// RVA: 0x22BDF40 Offset: 0x22BC540 VA: 0x1822BDF40
	internal bool <get_keepWaiting>b__8_0(LoadAssetsResult l) { }

}

