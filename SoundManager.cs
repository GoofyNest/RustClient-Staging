public class SoundManager : SingletonComponent<SoundManager>, IClientComponent // TypeDefIndex: 9032
{	// Fields
	public SoundClass defaultSoundClass; // 0x18
	public Dictionary<SoundDefinition, List<Sound>> activeSoundsByDef; // 0x20
	public List<ISoundBudgetedUpdate> budgetUpdatables; // 0x28
	public List<SoundPlayer> pendingSoundPlayers; // 0x30
	private List<SoundManager.ScheduledSound> scheduledSounds; // 0x38
	private int updatableIndex; // 0x40
	private Stopwatch watch; // 0x48
	private Vector3 prevCameraPos; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 <smoothedCameraVel>k__BackingField; // 0x5C
	private float cameraVelSmoothSpeed; // 0x68
	private List<Sound> otherLocalSounds; // 0x70

	// Properties
	public Vector3 smoothedCameraVel { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA794F0 Offset: 0xA77AF0 VA: 0x180A794F0
	public Vector3 get_smoothedCameraVel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA79510 Offset: 0xA77B10 VA: 0x180A79510
	private void set_smoothedCameraVel(Vector3 value) { }

	// RVA: 0xA76670 Offset: 0xA74C70 VA: 0x180A76670 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA78CF0 Offset: 0xA772F0 VA: 0x180A78CF0
	public void Update() { }

	// RVA: 0xA789F0 Offset: 0xA76FF0 VA: 0x180A789F0
	private void UpdateCameraVelocity() { }

	// RVA: 0xA786D0 Offset: 0xA76CD0 VA: 0x180A786D0
	private void StartPendingSoundPlayers() { }

	// RVA: 0xA787E0 Offset: 0xA76DE0 VA: 0x180A787E0
	private void StartScheduledSounds() { }

	// RVA: 0xA76580 Offset: 0xA74B80 VA: 0x180A76580
	public static void AddPendingSoundPlayer(SoundPlayer player) { }

	// RVA: 0xA76490 Offset: 0xA74A90 VA: 0x180A76490
	public static void AddBudgetedUpdatable(ISoundBudgetedUpdate updatable) { }

	// RVA: 0xA776A0 Offset: 0xA75CA0 VA: 0x180A776A0
	public static void RemoveBudgetedUpdatable(ISoundBudgetedUpdate updatable) { }

	// RVA: 0xA78570 Offset: 0xA76B70 VA: 0x180A78570
	public static SoundManager.ScheduledSound ScheduleOneshot(SoundDefinition def, float startTime, Vector3 position, float volumeMod = 1) { }

	// RVA: 0xA766E0 Offset: 0xA74CE0 VA: 0x180A766E0
	public static void CancelScheduledSound(SoundManager.ScheduledSound scheduledSound) { }

	// RVA: 0xA77130 Offset: 0xA75730 VA: 0x180A77130
	public static Sound PlayOneshot(SoundDefinition def, GameObject targetParent, bool firstPerson = False, Vector3 position) { }

	// RVA: 0xA77790 Offset: 0xA75D90 VA: 0x180A77790
	public static Sound RequestSoundInstance(SoundDefinition def, GameObject targetParent, Vector3 position, bool firstPerson = False) { }

	// RVA: 0xA767D0 Offset: 0xA74DD0 VA: 0x180A767D0
	private Sound CreateSoundInstance(SoundDefinition def, GameObject targetParent, bool firstPerson, float cameraDistance) { }

	// RVA: 0xA76DC0 Offset: 0xA753C0 VA: 0x180A76DC0
	private List<Sound> GetOtherLocalSoundInstances(SoundDefinition def, Vector3 pos, List<Sound> otherSounds) { }

	// RVA: 0xA76FF0 Offset: 0xA755F0 VA: 0x180A76FF0
	private GameObject GetSoundObject(SoundDefinition soundDef) { }

	// RVA: 0xA77410 Offset: 0xA75A10 VA: 0x180A77410
	public static void RecycleSound(Sound sound) { }

	// RVA: 0xA79380 Offset: 0xA77980 VA: 0x180A79380
	public void .ctor() { }

}

public class SoundManager.ScheduledSound // TypeDefIndex: 9033
{	// Fields
	public SoundDefinition def; // 0x10
	public float startTime; // 0x18
	public Vector3 position; // 0x1C
	public float volumeMod; // 0x28

	// Methods

	// RVA: 0xA74940 Offset: 0xA72F40 VA: 0x180A74940
	public void .ctor(SoundDefinition def, float startTime, Vector3 position, float volumeMod = 1) { }

}

