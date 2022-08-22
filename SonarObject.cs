public class SonarObject : MonoBehaviour, IClientComponent // TypeDefIndex: 11677
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SonarObject.SType sonarType; // 0x18
	public static List<SonarObject> trackedObjects; // 0x0

	public SonarObject.SType SonarType { get; }


	public SonarObject.SType get_SonarType() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum SonarObject.SType // TypeDefIndex: 11678
{	public int value__; // 0x0
	public const SonarObject.SType MoonPool = 0;
	public const SonarObject.SType Sub = 1;

}

