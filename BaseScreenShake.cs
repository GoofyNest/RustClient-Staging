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

	// RVA: 0x92B830 Offset: 0x929E30 VA: 0x18092B830
	public static void Apply(Camera cam, BaseViewModel vm) { }

	// RVA: 0x92C4C0 Offset: 0x92AAC0 VA: 0x18092C4C0
	protected void OnEnable() { }

	// RVA: 0x92C410 Offset: 0x92AA10 VA: 0x18092C410
	protected void OnDisable() { }

	// RVA: 0x92C550 Offset: 0x92AB50 VA: 0x18092C550
	public void Run(ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Setup();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm);

	// RVA: 0x92C6E0 Offset: 0x92ACE0 VA: 0x18092C6E0
	protected void .ctor() { }

	// RVA: 0x92C640 Offset: 0x92AC40 VA: 0x18092C640
	private static void .cctor() { }

}

