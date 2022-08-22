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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <smoothedCameraVel>k__BackingField; // 0x5C
	private float cameraVelSmoothSpeed; // 0x68
	private List<Sound> otherLocalSounds; // 0x70

	// Properties
	public Vector3 smoothedCameraVel { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA797B0 Offset: 0xA77DB0 VA: 0x180A797B0
	public Vector3 get_smoothedCameraVel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA797D0 Offset: 0xA77DD0 VA: 0x180A797D0
	private void set_smoothedCameraVel(Vector3 value) { }

	// RVA: 0xA76930 Offset: 0xA74F30 VA: 0x180A76930 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA78FB0 Offset: 0xA775B0 VA: 0x180A78FB0
	public void Update() { }

	// RVA: 0xA78CB0 Offset: 0xA772B0 VA: 0x180A78CB0
	private void UpdateCameraVelocity() { }

	// RVA: 0xA78990 Offset: 0xA76F90 VA: 0x180A78990
	private void StartPendingSoundPlayers() { }

	// RVA: 0xA78AA0 Offset: 0xA770A0 VA: 0x180A78AA0
	private void StartScheduledSounds() { }

	// RVA: 0xA76840 Offset: 0xA74E40 VA: 0x180A76840
	public static void AddPendingSoundPlayer(SoundPlayer player) { }

	// RVA: 0xA76750 Offset: 0xA74D50 VA: 0x180A76750
	public static void AddBudgetedUpdatable(ISoundBudgetedUpdate updatable) { }

	// RVA: 0xA77960 Offset: 0xA75F60 VA: 0x180A77960
	public static void RemoveBudgetedUpdatable(ISoundBudgetedUpdate updatable) { }

	// RVA: 0xA78830 Offset: 0xA76E30 VA: 0x180A78830
	public static SoundManager.ScheduledSound ScheduleOneshot(SoundDefinition def, float startTime, Vector3 position, float volumeMod = 1) { }

	// RVA: 0xA769A0 Offset: 0xA74FA0 VA: 0x180A769A0
	public static void CancelScheduledSound(SoundManager.ScheduledSound scheduledSound) { }

	// RVA: 0xA773F0 Offset: 0xA759F0 VA: 0x180A773F0
	public static Sound PlayOneshot(SoundDefinition def, GameObject targetParent, bool firstPerson = False, Vector3 position) { }

	// RVA: 0xA77A50 Offset: 0xA76050 VA: 0x180A77A50
	public static Sound RequestSoundInstance(SoundDefinition def, GameObject targetParent, Vector3 position, bool firstPerson = False) { }

	// RVA: 0xA76A90 Offset: 0xA75090 VA: 0x180A76A90
	private Sound CreateSoundInstance(SoundDefinition def, GameObject targetParent, bool firstPerson, float cameraDistance) { }

	// RVA: 0xA77080 Offset: 0xA75680 VA: 0x180A77080
	private List<Sound> GetOtherLocalSoundInstances(SoundDefinition def, Vector3 pos, List<Sound> otherSounds) { }

	// RVA: 0xA772B0 Offset: 0xA758B0 VA: 0x180A772B0
	private GameObject GetSoundObject(SoundDefinition soundDef) { }

	// RVA: 0xA776D0 Offset: 0xA75CD0 VA: 0x180A776D0
	public static void RecycleSound(Sound sound) { }

	// RVA: 0xA79640 Offset: 0xA77C40 VA: 0x180A79640
	public void .ctor() { }

}

public class SoundManager.ScheduledSound // TypeDefIndex: 9033
{	// Fields
	public SoundDefinition def; // 0x10
	public float startTime; // 0x18
	public Vector3 position; // 0x1C
	public float volumeMod; // 0x28

	// Methods

	// RVA: 0xA74C00 Offset: 0xA73200 VA: 0x180A74C00
	public void .ctor(SoundDefinition def, float startTime, Vector3 position, float volumeMod = 1) { }

}

