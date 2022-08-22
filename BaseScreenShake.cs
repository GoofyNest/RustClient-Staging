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

	// RVA: 0x92B320 Offset: 0x929920 VA: 0x18092B320
	public static void Apply(Camera cam, BaseViewModel vm) { }

	// RVA: 0x92BFB0 Offset: 0x92A5B0 VA: 0x18092BFB0
	protected void OnEnable() { }

	// RVA: 0x92BF00 Offset: 0x92A500 VA: 0x18092BF00
	protected void OnDisable() { }

	// RVA: 0x92C040 Offset: 0x92A640 VA: 0x18092C040
	public void Run(ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Setup();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm);

	// RVA: 0x92C1D0 Offset: 0x92A7D0 VA: 0x18092C1D0
	protected void .ctor() { }

	// RVA: 0x92C130 Offset: 0x92A730 VA: 0x18092C130
	private static void .cctor() { }

}

