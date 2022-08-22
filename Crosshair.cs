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

	// RVA: 0x6C4350 Offset: 0x6C2950 VA: 0x1806C4350
	private void Start() { }

	// RVA: 0x6C3610 Offset: 0x6C1C10 VA: 0x1806C3610
	private void FixedUpdate() { }

	// RVA: 0x6C4480 Offset: 0x6C2A80 VA: 0x1806C4480
	private void Update() { }

	// RVA: 0x6C3CC0 Offset: 0x6C22C0 VA: 0x1806C3CC0
	public void PointsEffect() { }

	// RVA: 0x6C34C0 Offset: 0x6C1AC0 VA: 0x1806C34C0
	public void DoPointsSplash(int amount) { }

	// RVA: 0x6C34B0 Offset: 0x6C1AB0 VA: 0x1806C34B0
	private void ClearPoints() { }

	// RVA: 0x6C3690 Offset: 0x6C1C90 VA: 0x1806C3690
	public static void OnHit(bool wasKillShot = False) { }

	// RVA: 0x6C3DB0 Offset: 0x6C23B0 VA: 0x1806C3DB0
	private bool ShouldShowCrosshair() { }

	// RVA: 0x6C4D00 Offset: 0x6C3300 VA: 0x1806C4D00
	public void .ctor() { }

	// RVA: 0x6C4CB0 Offset: 0x6C32B0 VA: 0x1806C4CB0
	private static void .cctor() { }

}

