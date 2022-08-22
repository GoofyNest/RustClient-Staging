public class LiquidWobble : MonoBehaviour // TypeDefIndex: 10685
{	// Fields
	private Renderer rend; // 0x18
	private Vector3 lastPos; // 0x20
	private Vector3 velocity; // 0x2C
	private Vector3 lastRot; // 0x38
	private Vector3 angularVelocity; // 0x44
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float CurrentWaterLevelFraction; // 0x50
	public float MinWaterLevel; // 0x54
	public float MaxWaterLevel; // 0x58
	public float MaxWobble; // 0x5C
	public float WobbleSpeed; // 0x60
	public float Recovery; // 0x64
	private float wobbleAmountX; // 0x68
	private float wobbleAmountZ; // 0x6C
	private float wobbleAmountToAddX; // 0x70
	private float wobbleAmountToAddZ; // 0x74
	private float pulse; // 0x78
	private float time; // 0x7C
	public float turbulence; // 0x80
	private static MaterialPropertyBlock propertyBlock; // 0x0
	private static int wobbleXID; // 0x8
	private static int wobbleZID; // 0xC
	private static int waterLevelID; // 0x10
	private static int turbulenceID; // 0x14

	// Methods

	// RVA: 0x4F73E0 Offset: 0x4F59E0 VA: 0x1804F73E0
	private void Awake() { }

	// RVA: 0x4F74E0 Offset: 0x4F5AE0 VA: 0x1804F74E0
	private void Update() { }

	// RVA: 0x4F74C0 Offset: 0x4F5AC0 VA: 0x1804F74C0
	private float CalculateWaterLevel() { }

	// RVA: 0x4F7A60 Offset: 0x4F6060 VA: 0x1804F7A60
	public void .ctor() { }

	// RVA: 0x4F79C0 Offset: 0x4F5FC0 VA: 0x1804F79C0
	private static void .cctor() { }

}

