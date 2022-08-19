public class BaseViewModel : MonoBehaviour // TypeDefIndex: 11436
{	// Fields
	public static bool HideViewmodel; // 0x0
	public static BaseViewModel GestureModel; // 0x8
	public static List<BaseViewModel> ActiveModels; // 0x10
	[HeaderAttribute] // RVA: 0xB06E0 Offset: 0xAFAE0 VA: 0x1800B06E0
	public LazyAimProperties lazyaimRegular; // 0x18
	public LazyAimProperties lazyaimIronsights; // 0x20
	public Transform pivot; // 0x28
	public bool useViewModelCamera; // 0x30
	public bool wantsHeldItemFlags; // 0x31
	public GameObject[] hideSightMeshes; // 0x38
	public bool isGestureViewModel; // 0x40
	public Transform MuzzlePoint; // 0x48
	[HeaderAttribute] // RVA: 0x7F510 Offset: 0x7E910 VA: 0x18007F510
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

	// RVA: 0x939D60 Offset: 0x938360 VA: 0x180939D60
	public static BaseViewModel get_ActiveModel() { }

	// RVA: 0x939F10 Offset: 0x938510 VA: 0x180939F10
	public static bool get_UsingViewModelCamera() { }

	// RVA: 0x937CA0 Offset: 0x9362A0 VA: 0x180937CA0
	public bool IsOK() { }

	// RVA: 0x938DB0 Offset: 0x9373B0 VA: 0x180938DB0
	public void PreDestroy() { }

	// RVA: 0x938A00 Offset: 0x937000 VA: 0x180938A00
	private void OnEnable() { }

	// RVA: 0x938890 Offset: 0x936E90 VA: 0x180938890
	private void OnDisable() { }

	// RVA: 0x936F50 Offset: 0x935550 VA: 0x180936F50
	private void Awake() { }

	// RVA: 0x939A00 Offset: 0x938000 VA: 0x180939A00
	public void UpdateRenderersAndSkin(BasePlayer forPlayer) { }

	// RVA: 0x938880 Offset: 0x936E80 VA: 0x180938880
	public void OnClothingChanged(BasePlayer player) { }

	// RVA: 0x939B40 Offset: 0x938140 VA: 0x180939B40
	private void UpdateRenderers(BasePlayer forPlayer) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void AddHandsModel() { }

	// RVA: 0x939740 Offset: 0x937D40 VA: 0x180939740
	private void UpdateClothingModels(BasePlayer player) { }

	// RVA: 0x936EA0 Offset: 0x9354A0 VA: 0x180936EA0
	private void AddClothing(ViewmodelClothing clothing, Item item) { }

	// RVA: 0x939170 Offset: 0x937770 VA: 0x180939170
	private void SetSkinColor(Color skinColor) { }

	// RVA: 0x937D00 Offset: 0x936300 VA: 0x180937D00
	public void OnCameraPositionChanged(Camera cam) { }

	// RVA: 0x937D10 Offset: 0x936310 VA: 0x180937D10
	public void OnCameraPositionChanged(Camera cam, BasePlayer player) { }

	// RVA: 0x937B80 Offset: 0x936180 VA: 0x180937B80
	public LazyAimProperties GetLazyAim() { }

	// RVA: 0x937660 Offset: 0x935C60 VA: 0x180937660
	private Quaternion GetGestureRotationOffset(out Vector3 offset) { }

	// RVA: 0x9392B0 Offset: 0x9378B0 VA: 0x1809392B0
	public static void ToggleGestureHide(bool state) { }

	// RVA: 0x939370 Offset: 0x937970 VA: 0x180939370
	public void TriggerAdmire() { }

	// RVA: 0x939460 Offset: 0x937A60 VA: 0x180939460
	public void TriggerAttack() { }

	// RVA: 0x939420 Offset: 0x937A20 VA: 0x180939420
	public void TriggerAttack2() { }

	// RVA: 0x9395A0 Offset: 0x937BA0 VA: 0x1809395A0
	public void TriggerReady() { }

	// RVA: 0x9394A0 Offset: 0x937AA0 VA: 0x1809394A0
	public void TriggerCancel() { }

	// RVA: 0x9394E0 Offset: 0x937AE0 VA: 0x1809394E0
	public void TriggerDeploy() { }

	// RVA: 0x9395E0 Offset: 0x937BE0 VA: 0x1809395E0
	public void TriggerReload() { }

	// RVA: 0x939560 Offset: 0x937B60 VA: 0x180939560
	public void TriggerHolster() { }

	// RVA: 0x939520 Offset: 0x937B20 VA: 0x180939520
	public void TriggerEmpty() { }

	// RVA: 0x939620 Offset: 0x937C20 VA: 0x180939620
	public void Trigger(string name) { }

	// RVA: 0x9396B0 Offset: 0x937CB0 VA: 0x1809396B0
	public void Trigger(int hash) { }

	// RVA: 0x938E60 Offset: 0x937460 VA: 0x180938E60
	public void ResetTrigger(string name) { }

	// RVA: 0x938DD0 Offset: 0x9373D0 VA: 0x180938DD0
	public void ResetTrigger(int hash) { }

	// RVA: 0x938F90 Offset: 0x937590 VA: 0x180938F90
	public void SetBool(string name, bool bState) { }

	// RVA: 0x938EF0 Offset: 0x9374F0 VA: 0x180938EF0
	public void SetBool(int hash, bool bState) { }

	// RVA: 0x939030 Offset: 0x937630 VA: 0x180939030
	public void SetFloat(string name, float fAmount) { }

	// RVA: 0x9390D0 Offset: 0x9376D0 VA: 0x1809390D0
	public void SetFloat(int hash, float fAmount) { }

	// RVA: 0x938BF0 Offset: 0x9371F0 VA: 0x180938BF0
	public void Play(string anim, int layer = 0) { }

	// RVA: 0x937500 Offset: 0x935B00 VA: 0x180937500
	public void CrossFade(string anim, float fade) { }

	// RVA: 0x937C20 Offset: 0x936220 VA: 0x180937C20
	public void HideSightMeshes(bool bHide) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void OnDeployedNoSkin() { }

	// RVA: 0x939C70 Offset: 0x938270 VA: 0x180939C70
	public void WorkshopMode() { }

	// RVA: 0x939D50 Offset: 0x938350 VA: 0x180939D50
	public void .ctor() { }

	// RVA: 0x939C80 Offset: 0x938280 VA: 0x180939C80
	private static void .cctor() { }

}

