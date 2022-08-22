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
	// RVA: 0xA79C80 Offset: 0xA78280 VA: 0x180A79C80
	public Vector3 get_smoothedCameraVel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA79CA0 Offset: 0xA782A0 VA: 0x180A79CA0
	private void set_smoothedCameraVel(Vector3 value) { }

	// RVA: 0xA76E00 Offset: 0xA75400 VA: 0x180A76E00 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA79480 Offset: 0xA77A80 VA: 0x180A79480
	public void Update() { }

	// RVA: 0xA79180 Offset: 0xA77780 VA: 0x180A79180
	private void UpdateCameraVelocity() { }

	// RVA: 0xA78E60 Offset: 0xA77460 VA: 0x180A78E60
	private void StartPendingSoundPlayers() { }

	// RVA: 0xA78F70 Offset: 0xA77570 VA: 0x180A78F70
	private void StartScheduledSounds() { }

	// RVA: 0xA76D10 Offset: 0xA75310 VA: 0x180A76D10
	public static void AddPendingSoundPlayer(SoundPlayer player) { }

	// RVA: 0xA76C20 Offset: 0xA75220 VA: 0x180A76C20
	public static void AddBudgetedUpdatable(ISoundBudgetedUpdate updatable) { }

	// RVA: 0xA77E30 Offset: 0xA76430 VA: 0x180A77E30
	public static void RemoveBudgetedUpdatable(ISoundBudgetedUpdate updatable) { }

	// RVA: 0xA78D00 Offset: 0xA77300 VA: 0x180A78D00
	public static SoundManager.ScheduledSound ScheduleOneshot(SoundDefinition def, float startTime, Vector3 position, float volumeMod = 1) { }

	// RVA: 0xA76E70 Offset: 0xA75470 VA: 0x180A76E70
	public static void CancelScheduledSound(SoundManager.ScheduledSound scheduledSound) { }

	// RVA: 0xA778C0 Offset: 0xA75EC0 VA: 0x180A778C0
	public static Sound PlayOneshot(SoundDefinition def, GameObject targetParent, bool firstPerson = False, Vector3 position) { }

	// RVA: 0xA77F20 Offset: 0xA76520 VA: 0x180A77F20
	public static Sound RequestSoundInstance(SoundDefinition def, GameObject targetParent, Vector3 position, bool firstPerson = False) { }

	// RVA: 0xA76F60 Offset: 0xA75560 VA: 0x180A76F60
	private Sound CreateSoundInstance(SoundDefinition def, GameObject targetParent, bool firstPerson, float cameraDistance) { }

	// RVA: 0xA77550 Offset: 0xA75B50 VA: 0x180A77550
	private List<Sound> GetOtherLocalSoundInstances(SoundDefinition def, Vector3 pos, List<Sound> otherSounds) { }

	// RVA: 0xA77780 Offset: 0xA75D80 VA: 0x180A77780
	private GameObject GetSoundObject(SoundDefinition soundDef) { }

	// RVA: 0xA77BA0 Offset: 0xA761A0 VA: 0x180A77BA0
	public static void RecycleSound(Sound sound) { }

	// RVA: 0xA79B10 Offset: 0xA78110 VA: 0x180A79B10
	public void .ctor() { }

}

public class SoundManager.ScheduledSound // TypeDefIndex: 9033
{	// Fields
	public SoundDefinition def; // 0x10
	public float startTime; // 0x18
	public Vector3 position; // 0x1C
	public float volumeMod; // 0x28

	// Methods

	// RVA: 0xA750D0 Offset: 0xA736D0 VA: 0x180A750D0
	public void .ctor(SoundDefinition def, float startTime, Vector3 position, float volumeMod = 1) { }

}

