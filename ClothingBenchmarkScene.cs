public class ClothingBenchmarkScene : BenchmarkScene // TypeDefIndex: 8249
{	// Fields
	public GameObjectRef PlayerModelPrefab; // 0x40
	public bool ChangeClothingEveryFrame; // 0x48
	protected List<PlayerModel> PlayerModels; // 0x50
	protected ItemModWearable[] Wearables; // 0x58

	// Methods

	// RVA: 0x574F40 Offset: 0x573540 VA: 0x180574F40 Slot: 7
	public override void StartBenchmark() { }

	// RVA: 0x574BE0 Offset: 0x5731E0 VA: 0x180574BE0 Slot: 8
	public override void BenchmarkUpdate() { }

	// RVA: 0x575480 Offset: 0x573A80 VA: 0x180575480 Slot: 9
	public override void StopBenchmark() { }

	// RVA: 0x5755F0 Offset: 0x573BF0 VA: 0x1805755F0
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

	// RVA: 0x589D20 Offset: 0x588320 VA: 0x180589D20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589A20 Offset: 0x588020 VA: 0x180589A20
	internal ItemModWearable <StartBenchmark>b__4_0(ItemDefinition x) { }

	// RVA: 0x589A70 Offset: 0x588070 VA: 0x180589A70
	internal bool <StartBenchmark>b__4_1(ItemModWearable x) { }

	// RVA: 0x589AD0 Offset: 0x5880D0 VA: 0x180589AD0
	internal Guid <StartBenchmark>b__4_2(ItemModWearable x) { }

	// RVA: 0x5899A0 Offset: 0x587FA0 VA: 0x1805899A0
	internal Guid <BenchmarkUpdate>b__5_0(ItemModWearable x) { }

}

