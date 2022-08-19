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

	// RVA: 0x6C42B0 Offset: 0x6C28B0 VA: 0x1806C42B0
	private void Start() { }

	// RVA: 0x6C3570 Offset: 0x6C1B70 VA: 0x1806C3570
	private void FixedUpdate() { }

	// RVA: 0x6C43E0 Offset: 0x6C29E0 VA: 0x1806C43E0
	private void Update() { }

	// RVA: 0x6C3C20 Offset: 0x6C2220 VA: 0x1806C3C20
	public void PointsEffect() { }

	// RVA: 0x6C3420 Offset: 0x6C1A20 VA: 0x1806C3420
	public void DoPointsSplash(int amount) { }

	// RVA: 0x6C3410 Offset: 0x6C1A10 VA: 0x1806C3410
	private void ClearPoints() { }

	// RVA: 0x6C35F0 Offset: 0x6C1BF0 VA: 0x1806C35F0
	public static void OnHit(bool wasKillShot = False) { }

	// RVA: 0x6C3D10 Offset: 0x6C2310 VA: 0x1806C3D10
	private bool ShouldShowCrosshair() { }

	// RVA: 0x6C4C60 Offset: 0x6C3260 VA: 0x1806C4C60
	public void .ctor() { }

	// RVA: 0x6C4C10 Offset: 0x6C3210 VA: 0x1806C4C10
	private static void .cctor() { }

}

