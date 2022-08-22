public class SonarObject : MonoBehaviour, IClientComponent // TypeDefIndex: 11677
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SonarObject.SType sonarType; // 0x18
	public static List<SonarObject> trackedObjects; // 0x0

	// Properties
	public SonarObject.SType SonarType { get; }

	// Methods

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public SonarObject.SType get_SonarType() { }

	// RVA: 0x5BFB80 Offset: 0x5BE180 VA: 0x1805BFB80
	protected void OnEnable() { }

	// RVA: 0x5BFB00 Offset: 0x5BE100 VA: 0x1805BFB00
	protected void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x5BFC50 Offset: 0x5BE250 VA: 0x1805BFC50
	private static void .cctor() { }

}

public enum SonarObject.SType // TypeDefIndex: 11678
{	// Fields
	public int value__; // 0x0
	public const SonarObject.SType MoonPool = 0;
	public const SonarObject.SType Sub = 1;

}

