public class GameModeCapturePoint : BaseEntity // TypeDefIndex: 9882
{	// Fields
	public CapturePointTrigger captureTrigger; // 0x168
	public float timeToCapture; // 0x170
	public int scorePerSecond; // 0x174
	public string scoreName; // 0x178
	private float captureFraction; // 0x180
	private int captureTeam; // 0x184
	private int capturingTeam; // 0x188
	public EntityRef capturingPlayer; // 0x190
	public EntityRef capturedPlayer; // 0x1A0
	public const BaseEntity.Flags Flag_Contested = 8192;
	public RustText capturePointText; // 0x1B0
	public RustText captureOwnerName; // 0x1B8
	public Image captureProgressImage; // 0x1C0
	public GameObjectRef progressBeepEffect; // 0x1C8
	public GameObjectRef progressCompleteEffect; // 0x1D0
	public Transform computerPoint; // 0x1D8

	// Methods

	// RVA: 0x5329F0 Offset: 0x530FF0 VA: 0x1805329F0
	public bool IsContested() { }

	// RVA: 0x7589B0 Offset: 0x756FB0 VA: 0x1807589B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x758A90 Offset: 0x757090 VA: 0x180758A90 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x758C90 Offset: 0x757290 VA: 0x180758C90
	public void .ctor() { }

}

