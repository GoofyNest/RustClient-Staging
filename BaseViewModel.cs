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

	// RVA: 0x939E70 Offset: 0x938470 VA: 0x180939E70
	public static BaseViewModel get_ActiveModel() { }

	// RVA: 0x93A020 Offset: 0x938620 VA: 0x18093A020
	public static bool get_UsingViewModelCamera() { }

	// RVA: 0x937DB0 Offset: 0x9363B0 VA: 0x180937DB0
	public bool IsOK() { }

	// RVA: 0x938EC0 Offset: 0x9374C0 VA: 0x180938EC0
	public void PreDestroy() { }

	// RVA: 0x938B10 Offset: 0x937110 VA: 0x180938B10
	private void OnEnable() { }

	// RVA: 0x9389A0 Offset: 0x936FA0 VA: 0x1809389A0
	private void OnDisable() { }

	// RVA: 0x937060 Offset: 0x935660 VA: 0x180937060
	private void Awake() { }

	// RVA: 0x939B10 Offset: 0x938110 VA: 0x180939B10
	public void UpdateRenderersAndSkin(BasePlayer forPlayer) { }

	// RVA: 0x938990 Offset: 0x936F90 VA: 0x180938990
	public void OnClothingChanged(BasePlayer player) { }

	// RVA: 0x939C50 Offset: 0x938250 VA: 0x180939C50
	private void UpdateRenderers(BasePlayer forPlayer) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void AddHandsModel() { }

	// RVA: 0x939850 Offset: 0x937E50 VA: 0x180939850
	private void UpdateClothingModels(BasePlayer player) { }

	// RVA: 0x936FB0 Offset: 0x9355B0 VA: 0x180936FB0
	private void AddClothing(ViewmodelClothing clothing, Item item) { }

	// RVA: 0x939280 Offset: 0x937880 VA: 0x180939280
	private void SetSkinColor(Color skinColor) { }

	// RVA: 0x937E10 Offset: 0x936410 VA: 0x180937E10
	public void OnCameraPositionChanged(Camera cam) { }

	// RVA: 0x937E20 Offset: 0x936420 VA: 0x180937E20
	public void OnCameraPositionChanged(Camera cam, BasePlayer player) { }

	// RVA: 0x937C90 Offset: 0x936290 VA: 0x180937C90
	public LazyAimProperties GetLazyAim() { }

	// RVA: 0x937770 Offset: 0x935D70 VA: 0x180937770
	private Quaternion GetGestureRotationOffset(out Vector3 offset) { }

	// RVA: 0x9393C0 Offset: 0x9379C0 VA: 0x1809393C0
	public static void ToggleGestureHide(bool state) { }

	// RVA: 0x939480 Offset: 0x937A80 VA: 0x180939480
	public void TriggerAdmire() { }

	// RVA: 0x939570 Offset: 0x937B70 VA: 0x180939570
	public void TriggerAttack() { }

	// RVA: 0x939530 Offset: 0x937B30 VA: 0x180939530
	public void TriggerAttack2() { }

	// RVA: 0x9396B0 Offset: 0x937CB0 VA: 0x1809396B0
	public void TriggerReady() { }

	// RVA: 0x9395B0 Offset: 0x937BB0 VA: 0x1809395B0
	public void TriggerCancel() { }

	// RVA: 0x9395F0 Offset: 0x937BF0 VA: 0x1809395F0
	public void TriggerDeploy() { }

	// RVA: 0x9396F0 Offset: 0x937CF0 VA: 0x1809396F0
	public void TriggerReload() { }

	// RVA: 0x939670 Offset: 0x937C70 VA: 0x180939670
	public void TriggerHolster() { }

	// RVA: 0x939630 Offset: 0x937C30 VA: 0x180939630
	public void TriggerEmpty() { }

	// RVA: 0x939730 Offset: 0x937D30 VA: 0x180939730
	public void Trigger(string name) { }

	// RVA: 0x9397C0 Offset: 0x937DC0 VA: 0x1809397C0
	public void Trigger(int hash) { }

	// RVA: 0x938F70 Offset: 0x937570 VA: 0x180938F70
	public void ResetTrigger(string name) { }

	// RVA: 0x938EE0 Offset: 0x9374E0 VA: 0x180938EE0
	public void ResetTrigger(int hash) { }

	// RVA: 0x9390A0 Offset: 0x9376A0 VA: 0x1809390A0
	public void SetBool(string name, bool bState) { }

	// RVA: 0x939000 Offset: 0x937600 VA: 0x180939000
	public void SetBool(int hash, bool bState) { }

	// RVA: 0x939140 Offset: 0x937740 VA: 0x180939140
	public void SetFloat(string name, float fAmount) { }

	// RVA: 0x9391E0 Offset: 0x9377E0 VA: 0x1809391E0
	public void SetFloat(int hash, float fAmount) { }

	// RVA: 0x938D00 Offset: 0x937300 VA: 0x180938D00
	public void Play(string anim, int layer = 0) { }

	// RVA: 0x937610 Offset: 0x935C10 VA: 0x180937610
	public void CrossFade(string anim, float fade) { }

	// RVA: 0x937D30 Offset: 0x936330 VA: 0x180937D30
	public void HideSightMeshes(bool bHide) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void OnDeployedNoSkin() { }

	// RVA: 0x939D80 Offset: 0x938380 VA: 0x180939D80
	public void WorkshopMode() { }

	// RVA: 0x939E60 Offset: 0x938460 VA: 0x180939E60
	public void .ctor() { }

	// RVA: 0x939D90 Offset: 0x938390 VA: 0x180939D90
	private static void .cctor() { }

}

