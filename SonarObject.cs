public class SonarObject : MonoBehaviour, IClientComponent // TypeDefIndex: 11677
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SonarObject.SType sonarType; // 0x18
	public static List<SonarObject> trackedObjects; // 0x0

	// Properties
	public SonarObject.SType SonarType { get; }

	// Methods

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public SonarObject.SType get_SonarType() { }

	// RVA: 0x5BFB10 Offset: 0x5BE110 VA: 0x1805BFB10
	protected void OnEnable() { }

	// RVA: 0x5BFA90 Offset: 0x5BE090 VA: 0x1805BFA90
	protected void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x5BFBE0 Offset: 0x5BE1E0 VA: 0x1805BFBE0
	private static void .cctor() { }

}

public enum SonarObject.SType // TypeDefIndex: 11678
{	// Fields
	public int value__; // 0x0
	public const SonarObject.SType MoonPool = 0;
	public const SonarObject.SType Sub = 1;

}

