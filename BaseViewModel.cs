public class BaseViewModel : MonoBehaviour // TypeDefIndex: 11436
{	// Fields
	public static bool HideViewmodel; // 0x0
	public static BaseViewModel GestureModel; // 0x8
	public static List<BaseViewModel> ActiveModels; // 0x10
	[HeaderAttribute] // RVA: 0xB0780 Offset: 0xAFB80 VA: 0x1800B0780
	public LazyAimProperties lazyaimRegular; // 0x18
	public LazyAimProperties lazyaimIronsights; // 0x20
	public Transform pivot; // 0x28
	public bool useViewModelCamera; // 0x30
	public bool wantsHeldItemFlags; // 0x31
	public GameObject[] hideSightMeshes; // 0x38
	public bool isGestureViewModel; // 0x40
	public Transform MuzzlePoint; // 0x48
	[HeaderAttribute] // RVA: 0x7F5E0 Offset: 0x7E9E0 VA: 0x18007F5E0
	public SubsurfaceProfile subsurfaceProfile; // 0x50
	internal Animator animator; // 0x58
	internal AnimationEvents animationEvent; // 0x60
	internal IronSights ironSights; // 0x68
	internal ViewmodelSway sway; // 0x70
	internal ViewmodelLower lower; // 0x78
	internal ViewmodelBob bob; // 0x80
	internal ViewmodelPunch punch; // 0x88
	internal ViewmodelAspectOffset aspectOffset; // 0x90
	internal ViewmodelMountedAnchor mountedAnchor; // 0x98
	internal Model model; // 0xA0
	internal static bool gestureHide; // 0x18
	internal static TimeSince gestureHideTime; // 0x1C
	private static GestureCollection gestureCollection; // 0x20
	private Skeleton Skeleton; // 0xA8
	private GameObject Clothing; // 0xB0
	private bool workshopMode; // 0xB8

	// Properties
	public static BaseViewModel ActiveModel { get; }
	public static bool UsingViewModelCamera { get; }

	// Methods

	// RVA: 0x93A380 Offset: 0x938980 VA: 0x18093A380
	public static BaseViewModel get_ActiveModel() { }

	// RVA: 0x93A530 Offset: 0x938B30 VA: 0x18093A530
	public static bool get_UsingViewModelCamera() { }

	// RVA: 0x9382C0 Offset: 0x9368C0 VA: 0x1809382C0
	public bool IsOK() { }

	// RVA: 0x9393D0 Offset: 0x9379D0 VA: 0x1809393D0
	public void PreDestroy() { }

	// RVA: 0x939020 Offset: 0x937620 VA: 0x180939020
	private void OnEnable() { }

	// RVA: 0x938EB0 Offset: 0x9374B0 VA: 0x180938EB0
	private void OnDisable() { }

	// RVA: 0x937570 Offset: 0x935B70 VA: 0x180937570
	private void Awake() { }

	// RVA: 0x93A020 Offset: 0x938620 VA: 0x18093A020
	public void UpdateRenderersAndSkin(BasePlayer forPlayer) { }

	// RVA: 0x938EA0 Offset: 0x9374A0 VA: 0x180938EA0
	public void OnClothingChanged(BasePlayer player) { }

	// RVA: 0x93A160 Offset: 0x938760 VA: 0x18093A160
	private void UpdateRenderers(BasePlayer forPlayer) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void AddHandsModel() { }

	// RVA: 0x939D60 Offset: 0x938360 VA: 0x180939D60
	private void UpdateClothingModels(BasePlayer player) { }

	// RVA: 0x9374C0 Offset: 0x935AC0 VA: 0x1809374C0
	private void AddClothing(ViewmodelClothing clothing, Item item) { }

	// RVA: 0x939790 Offset: 0x937D90 VA: 0x180939790
	private void SetSkinColor(Color skinColor) { }

	// RVA: 0x938320 Offset: 0x936920 VA: 0x180938320
	public void OnCameraPositionChanged(Camera cam) { }

	// RVA: 0x938330 Offset: 0x936930 VA: 0x180938330
	public void OnCameraPositionChanged(Camera cam, BasePlayer player) { }

	// RVA: 0x9381A0 Offset: 0x9367A0 VA: 0x1809381A0
	public LazyAimProperties GetLazyAim() { }

	// RVA: 0x937C80 Offset: 0x936280 VA: 0x180937C80
	private Quaternion GetGestureRotationOffset(out Vector3 offset) { }

	// RVA: 0x9398D0 Offset: 0x937ED0 VA: 0x1809398D0
	public static void ToggleGestureHide(bool state) { }

	// RVA: 0x939990 Offset: 0x937F90 VA: 0x180939990
	public void TriggerAdmire() { }

	// RVA: 0x939A80 Offset: 0x938080 VA: 0x180939A80
	public void TriggerAttack() { }

	// RVA: 0x939A40 Offset: 0x938040 VA: 0x180939A40
	public void TriggerAttack2() { }

	// RVA: 0x939BC0 Offset: 0x9381C0 VA: 0x180939BC0
	public void TriggerReady() { }

	// RVA: 0x939AC0 Offset: 0x9380C0 VA: 0x180939AC0
	public void TriggerCancel() { }

	// RVA: 0x939B00 Offset: 0x938100 VA: 0x180939B00
	public void TriggerDeploy() { }

	// RVA: 0x939C00 Offset: 0x938200 VA: 0x180939C00
	public void TriggerReload() { }

	// RVA: 0x939B80 Offset: 0x938180 VA: 0x180939B80
	public void TriggerHolster() { }

	// RVA: 0x939B40 Offset: 0x938140 VA: 0x180939B40
	public void TriggerEmpty() { }

	// RVA: 0x939C40 Offset: 0x938240 VA: 0x180939C40
	public void Trigger(string name) { }

	// RVA: 0x939CD0 Offset: 0x9382D0 VA: 0x180939CD0
	public void Trigger(int hash) { }

	// RVA: 0x939480 Offset: 0x937A80 VA: 0x180939480
	public void ResetTrigger(string name) { }

	// RVA: 0x9393F0 Offset: 0x9379F0 VA: 0x1809393F0
	public void ResetTrigger(int hash) { }

	// RVA: 0x9395B0 Offset: 0x937BB0 VA: 0x1809395B0
	public void SetBool(string name, bool bState) { }

	// RVA: 0x939510 Offset: 0x937B10 VA: 0x180939510
	public void SetBool(int hash, bool bState) { }

	// RVA: 0x939650 Offset: 0x937C50 VA: 0x180939650
	public void SetFloat(string name, float fAmount) { }

	// RVA: 0x9396F0 Offset: 0x937CF0 VA: 0x1809396F0
	public void SetFloat(int hash, float fAmount) { }

	// RVA: 0x939210 Offset: 0x937810 VA: 0x180939210
	public void Play(string anim, int layer = 0) { }

	// RVA: 0x937B20 Offset: 0x936120 VA: 0x180937B20
	public void CrossFade(string anim, float fade) { }

	// RVA: 0x938240 Offset: 0x936840 VA: 0x180938240
	public void HideSightMeshes(bool bHide) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void OnDeployedNoSkin() { }

	// RVA: 0x93A290 Offset: 0x938890 VA: 0x18093A290
	public void WorkshopMode() { }

	// RVA: 0x93A370 Offset: 0x938970 VA: 0x18093A370
	public void .ctor() { }

	// RVA: 0x93A2A0 Offset: 0x9388A0 VA: 0x18093A2A0
	private static void .cctor() { }

}

