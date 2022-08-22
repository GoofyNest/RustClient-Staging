public class ClothingBenchmarkScene : BenchmarkScene // TypeDefIndex: 8249
{	// Fields
	public GameObjectRef PlayerModelPrefab; // 0x40
	public bool ChangeClothingEveryFrame; // 0x48
	protected List<PlayerModel> PlayerModels; // 0x50
	protected ItemModWearable[] Wearables; // 0x58

	// Methods

	// RVA: 0x574ED0 Offset: 0x5734D0 VA: 0x180574ED0 Slot: 7
	public override void StartBenchmark() { }

	// RVA: 0x574B70 Offset: 0x573170 VA: 0x180574B70 Slot: 8
	public override void BenchmarkUpdate() { }

	// RVA: 0x575410 Offset: 0x573A10 VA: 0x180575410 Slot: 9
	public override void StopBenchmark() { }

	// RVA: 0x575580 Offset: 0x573B80 VA: 0x180575580
	public void .ctor() { }

}

private sealed class ClothingBenchmarkScene.<>c // TypeDefIndex: 8250
{	// Fields
	public static readonly ClothingBenchmarkScene.<>c <>9; // 0x0
	public static Func<ItemDefinition, ItemModWearable> <>9__4_0; // 0x8
	public static Func<ItemModWearable, bool> <>9__4_1; // 0x10
	public static Func<ItemModWearable, Guid> <>9__4_2; // 0x18
	public static Func<ItemModWearable, Guid> <>9__5_0; // 0x20

	// Methods

	// RVA: 0x589CB0 Offset: 0x5882B0 VA: 0x180589CB0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5899B0 Offset: 0x587FB0 VA: 0x1805899B0
	internal ItemModWearable <StartBenchmark>b__4_0(ItemDefinition x) { }

	// RVA: 0x589A00 Offset: 0x588000 VA: 0x180589A00
	internal bool <StartBenchmark>b__4_1(ItemModWearable x) { }

	// RVA: 0x589A60 Offset: 0x588060 VA: 0x180589A60
	internal Guid <StartBenchmark>b__4_2(ItemModWearable x) { }

	// RVA: 0x589930 Offset: 0x587F30 VA: 0x180589930
	internal Guid <BenchmarkUpdate>b__5_0(ItemModWearable x) { }

}

