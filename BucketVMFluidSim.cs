public class BucketVMFluidSim : MonoBehaviour // TypeDefIndex: 9329
{	// Fields
	public Animator waterbucketAnim; // 0x18
	public ParticleSystem waterPour; // 0x20
	public ParticleSystem waterTurbulence; // 0x28
	public ParticleSystem waterFill; // 0x30
	public float waterLevel; // 0x38
	public float targetWaterLevel; // 0x3C
	public AudioSource waterSpill; // 0x40
	private float PlayerEyePitch; // 0x48
	private float turb_forward; // 0x4C
	private float turb_side; // 0x50
	private Vector3 lastPosition; // 0x54
	protected Vector3 groundSpeedLast; // 0x60
	private Vector3 lastAngle; // 0x6C
	protected Vector3 vecAngleSpeedLast; // 0x78
	private Vector3 initialPosition; // 0x84

	// Methods

	// RVA: 0x5222A0 Offset: 0x5208A0 VA: 0x1805222A0
	private void Start() { }

	// RVA: 0x522280 Offset: 0x520880 VA: 0x180522280
	private void SetFillingFromWorld(bool isFilling) { }

	// RVA: 0x522320 Offset: 0x520920 VA: 0x180522320
	private void UpdateWaterLevel(float newLevel) { }

	// RVA: 0x5225C0 Offset: 0x520BC0 VA: 0x1805225C0
	private void Update() { }

	// RVA: 0x521C20 Offset: 0x520220 VA: 0x180521C20
	private void CalculateTurbulence() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void DoWaterTipping() { }

	// RVA: 0x521B90 Offset: 0x520190 VA: 0x180521B90
	public void AddWater(float waterAmount) { }

	// RVA: 0x522080 Offset: 0x520680 VA: 0x180522080
	private void DisableWaterSpillEffects() { }

	// RVA: 0x522330 Offset: 0x520930 VA: 0x180522330
	private void UpdateWaterLine() { }

	// RVA: 0x522630 Offset: 0x520C30 VA: 0x180522630
	private float fsel(float c, float x, float y) { }

	// RVA: 0x5221A0 Offset: 0x5207A0 VA: 0x1805221A0
	private float RemapValClamped(float val, float A, float B, float C, float D) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

