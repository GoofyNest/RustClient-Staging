public class HostileNote : MonoBehaviour, IClientComponent // TypeDefIndex: 10934
{	public CanvasGroup warnGroup; // 0x18
	public CanvasGroup group; // 0x20
	public CanvasGroup timerGroup; // 0x28
	public CanvasGroup smallWarning; // 0x30
	public Text timerText; // 0x38
	public Text smallWarningText; // 0x40
	public static float unhostileTime; // 0x0
	public static float weaponDrawnDuration; // 0x4
	public Color warnColor; // 0x48
	public Color hostileColor; // 0x58
	public float requireDistanceToSafeZone; // 0x68
	private TimeSince nextMonumentUpdate; // 0x6C
	private bool isNearSafeZone; // 0x70
	private double lastHostileTimeStringUpdate; // 0x78
	private double lastWeaponDrawnStringUpdate; // 0x80
	private string hostileTimeLeftString; // 0x88


	public void Update() { }

	public void .ctor() { }

	private static void .cctor() { }

}

