public class HitDetectionBenchmark : BenchmarkScene // TypeDefIndex: 8255
{	// Fields
	private const int PlayerCount = 50;
	public GameObjectRef PlayerModelPrefab; // 0x40
	public GameObjectRef PlayerCollisionPrefab; // 0x48
	protected List<PlayerModel> PlayerModels; // 0x50
	protected List<BaseCollision> PlayerCollisions; // 0x58
	protected ItemModWearable[] Wearables; // 0x60

	// Methods

	// RVA: 0x73B730 Offset: 0x739D30 VA: 0x18073B730 Slot: 7
	public override void StartBenchmark() { }

	// RVA: 0x73B3B0 Offset: 0x7399B0 VA: 0x18073B3B0 Slot: 8
	public override void BenchmarkUpdate() { }

	// RVA: 0x73BDD0 Offset: 0x73A3D0 VA: 0x18073BDD0 Slot: 9
	public override void StopBenchmark() { }

	// RVA: 0x73C080 Offset: 0x73A680 VA: 0x18073C080
	public void .ctor() { }

}

private sealed class HitDetectionBenchmark.<>c // TypeDefIndex: 8256
{	// Fields
	public static readonly HitDetectionBenchmark.<>c <>9; // 0x0
	public static Func<ItemDefinition, ItemModWearable> <>9__6_0; // 0x8
	public static Func<ItemModWearable, bool> <>9__6_1; // 0x10
	public static Func<ItemModWearable, Guid> <>9__6_2; // 0x18

	// Methods

	// RVA: 0x749380 Offset: 0x747980 VA: 0x180749380
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x749210 Offset: 0x747810 VA: 0x180749210
	internal ItemModWearable <StartBenchmark>b__6_0(ItemDefinition x) { }

	// RVA: 0x749260 Offset: 0x747860 VA: 0x180749260
	internal bool <StartBenchmark>b__6_1(ItemModWearable x) { }

	// RVA: 0x7492C0 Offset: 0x7478C0 VA: 0x1807492C0
	internal Guid <StartBenchmark>b__6_2(ItemModWearable x) { }

}

