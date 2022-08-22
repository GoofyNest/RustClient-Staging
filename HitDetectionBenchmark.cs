public class HitDetectionBenchmark : BenchmarkScene // TypeDefIndex: 8255
{	// Fields
	private const int PlayerCount = 50;
	public GameObjectRef PlayerModelPrefab; // 0x40
	public GameObjectRef PlayerCollisionPrefab; // 0x48
	protected List<PlayerModel> PlayerModels; // 0x50
	protected List<BaseCollision> PlayerCollisions; // 0x58
	protected ItemModWearable[] Wearables; // 0x60

	// Methods

	// RVA: 0x73B790 Offset: 0x739D90 VA: 0x18073B790 Slot: 7
	public override void StartBenchmark() { }

	// RVA: 0x73B410 Offset: 0x739A10 VA: 0x18073B410 Slot: 8
	public override void BenchmarkUpdate() { }

	// RVA: 0x73BE30 Offset: 0x73A430 VA: 0x18073BE30 Slot: 9
	public override void StopBenchmark() { }

	// RVA: 0x73C0E0 Offset: 0x73A6E0 VA: 0x18073C0E0
	public void .ctor() { }

}

private sealed class HitDetectionBenchmark.<>c // TypeDefIndex: 8256
{	// Fields
	public static readonly HitDetectionBenchmark.<>c <>9; // 0x0
	public static Func<ItemDefinition, ItemModWearable> <>9__6_0; // 0x8
	public static Func<ItemModWearable, bool> <>9__6_1; // 0x10
	public static Func<ItemModWearable, Guid> <>9__6_2; // 0x18

	// Methods

	// RVA: 0x7493E0 Offset: 0x7479E0 VA: 0x1807493E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x749270 Offset: 0x747870 VA: 0x180749270
	internal ItemModWearable <StartBenchmark>b__6_0(ItemDefinition x) { }

	// RVA: 0x7492C0 Offset: 0x7478C0 VA: 0x1807492C0
	internal bool <StartBenchmark>b__6_1(ItemModWearable x) { }

	// RVA: 0x749320 Offset: 0x747920 VA: 0x180749320
	internal Guid <StartBenchmark>b__6_2(ItemModWearable x) { }

}

