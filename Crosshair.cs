public class Crosshair : BaseMonoBehaviour // TypeDefIndex: 10844
{	// Fields
	public static bool Enabled; // 0x0
	public Image Image; // 0x18
	public RectTransform reticleTransform; // 0x20
	public CanvasGroup reticleAlpha; // 0x28
	public RectTransform hitNotifyMarker; // 0x30
	public CanvasGroup hitNotifyAlpha; // 0x38
	public static Crosshair instance; // 0x8
	public static float lastHitTime; // 0x10
	public float crosshairAlpha; // 0x40
	internal RectTransform rectTransform; // 0x48
	public float aimconeMultiplier; // 0x50
	public float aimconeLerpSpeed; // 0x54
	private Vector2 hitNotifyStartSize; // 0x58
	private Vector2 originalReticleSize; // 0x60
	public GameObjectRef pointsSplashEffect; // 0x68
	internal int activePoints; // 0x70

	// Methods

	// RVA: 0x6C43C0 Offset: 0x6C29C0 VA: 0x1806C43C0
	private void Start() { }

	// RVA: 0x6C3680 Offset: 0x6C1C80 VA: 0x1806C3680
	private void FixedUpdate() { }

	// RVA: 0x6C44F0 Offset: 0x6C2AF0 VA: 0x1806C44F0
	private void Update() { }

	// RVA: 0x6C3D30 Offset: 0x6C2330 VA: 0x1806C3D30
	public void PointsEffect() { }

	// RVA: 0x6C3530 Offset: 0x6C1B30 VA: 0x1806C3530
	public void DoPointsSplash(int amount) { }

	// RVA: 0x6C3520 Offset: 0x6C1B20 VA: 0x1806C3520
	private void ClearPoints() { }

	// RVA: 0x6C3700 Offset: 0x6C1D00 VA: 0x1806C3700
	public static void OnHit(bool wasKillShot = False) { }

	// RVA: 0x6C3E20 Offset: 0x6C2420 VA: 0x1806C3E20
	private bool ShouldShowCrosshair() { }

	// RVA: 0x6C4D70 Offset: 0x6C3370 VA: 0x1806C4D70
	public void .ctor() { }

	// RVA: 0x6C4D20 Offset: 0x6C3320 VA: 0x1806C4D20
	private static void .cctor() { }

}

