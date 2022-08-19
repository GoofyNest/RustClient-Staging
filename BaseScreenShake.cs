public abstract class BaseScreenShake : MonoBehaviour // TypeDefIndex: 9365
{	// Fields
	public static List<BaseScreenShake> list; // 0x0
	internal static float punchFadeScale; // 0x8
	internal static float bobScale; // 0xC
	internal static float animPunchMagnitude; // 0x10
	public float length; // 0x18
	internal float timeTaken; // 0x1C
	private int currentFrame; // 0x20

	// Methods

	// RVA: 0x92B210 Offset: 0x929810 VA: 0x18092B210
	public static void Apply(Camera cam, BaseViewModel vm) { }

	// RVA: 0x92BEA0 Offset: 0x92A4A0 VA: 0x18092BEA0
	protected void OnEnable() { }

	// RVA: 0x92BDF0 Offset: 0x92A3F0 VA: 0x18092BDF0
	protected void OnDisable() { }

	// RVA: 0x92BF30 Offset: 0x92A530 VA: 0x18092BF30
	public void Run(ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Setup();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm);

	// RVA: 0x92C0C0 Offset: 0x92A6C0 VA: 0x18092C0C0
	protected void .ctor() { }

	// RVA: 0x92C020 Offset: 0x92A620 VA: 0x18092C020
	private static void .cctor() { }

}

