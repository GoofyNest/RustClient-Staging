public abstract class LODComponent : BaseMonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 9930
{	// Fields
	public LODDistanceMode DistanceMode; // 0x18
	public LODComponent.OccludeeParameters OccludeeParams; // 0x1C
	protected Transform cachedTransform; // 0x30
	protected Impostor impostor; // 0x38
	private LODEnvironmentMode EnvironmentMode; // 0x40
	private bool culled; // 0x44
	private LODCell cell; // 0x48
	private float currentDistance; // 0x50
	private bool occludeeCulled; // 0x54
	private bool occludeeShadowsVisible; // 0x55
	private float occludeeShadowRange; // 0x58
	private OccludeeSphere occludee; // 0x60
	private const float OccludeeMinTimeVisible = 0,1;
	private static HashSet<LODComponent> occludeeSet; // 0x0
	private static readonly int DynamicOccludeeLowPerFrame; // 0x8
	private static readonly float DynamicOccludeeMinimumLowInterval; // 0xC
	private static ListHashSet<LODComponent> dynamicOccludees; // 0x10
	private static int dynamicOccludeeLowIndex; // 0x18

	// Properties
	public static HashSet<LODComponent> OccludeeSet { get; }
	public float CurrentDistance { get; }

	// Methods

	// RVA: 0x684A60 Offset: 0x683060 VA: 0x180684A60
	public static HashSet<LODComponent> get_OccludeeSet() { }

	// RVA: 0x684A50 Offset: 0x683050 VA: 0x180684A50
	public float get_CurrentDistance() { }

	// RVA: 0x683560 Offset: 0x681B60 VA: 0x180683560
	private float GetDistance() { }

	// RVA: 0x682DC0 Offset: 0x6813C0 VA: 0x180682DC0
	protected void Awake() { }

	// RVA: 0x6840F0 Offset: 0x6826F0 VA: 0x1806840F0
	public void SetEnvironmentMode(LODEnvironmentMode mode) { }

	// RVA: 0x683910 Offset: 0x681F10 VA: 0x180683910
	protected void OnEnable() { }

	// RVA: 0x6836B0 Offset: 0x681CB0 VA: 0x1806836B0
	protected void OnDisable() { }

	// RVA: 0x6834D0 Offset: 0x681AD0 VA: 0x1806834D0
	private void EnableCulling() { }

	// RVA: 0x683440 Offset: 0x681A40 VA: 0x180683440
	private void DisableCulling() { }

	// RVA: 0x683C50 Offset: 0x682250 VA: 0x180683C50 Slot: 7
	public void RefreshLOD() { }

	// RVA: 0x683310 Offset: 0x681910 VA: 0x180683310 Slot: 6
	public void ChangeLOD() { }

	// RVA: 0x683160 Offset: 0x681760 VA: 0x180683160
	private void ChangeCulling(float distance) { }

	// RVA: 0x683300 Offset: 0x681900 VA: 0x180683300
	private void ChangeCulling() { }

	// RVA: 0x682EA0 Offset: 0x6814A0 VA: 0x180682EA0
	public static void ChangeCullingAll() { }

	// RVA: 0x684810 Offset: 0x682E10 VA: 0x180684810
	private void UpdateVisibility() { }

	// RVA: 0x684100 Offset: 0x682700 VA: 0x180684100
	public void SetVisible(bool state) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void InitLOD();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void EnableLOD();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void DisableLOD();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract int GetLOD(float distance);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void SetLOD(int newlod);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void Show();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void Hide();

	// RVA: 0x683690 Offset: 0x681C90 VA: 0x180683690 Slot: 15
	protected virtual void Hide(bool shadowsVisible) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 16
	protected virtual bool IsLODHiding() { }

	// RVA: 0x6848A0 Offset: 0x682EA0 VA: 0x1806848A0
	public void WorkshopMode() { }

	// RVA: 0x683430 Offset: 0x681A30 VA: 0x180683430 Slot: 17
	protected virtual bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x6847F0 Offset: 0x682DF0 VA: 0x1806847F0
	private void UpdateShadowRange() { }

	// RVA: 0x683380 Offset: 0x681980 VA: 0x180683380
	public static void ClearOccludees() { }

	// RVA: 0x684200 Offset: 0x682800 VA: 0x180684200
	private static void UpdateDynamicOccludeeBounds(LODComponent lodcomp) { }

	// RVA: 0x684350 Offset: 0x682950 VA: 0x180684350
	public static void UpdateDynamicOccludees() { }

	// RVA: 0x684090 Offset: 0x682690 VA: 0x180684090
	public void ResetCulling() { }

	// RVA: 0x683E30 Offset: 0x682430 VA: 0x180683E30 Slot: 18
	protected virtual void RegisterToCulling(bool isVisible = True) { }

	// RVA: 0x684110 Offset: 0x682710 VA: 0x180684110 Slot: 19
	protected virtual void UnregisterFromCulling() { }

	// RVA: 0x683B10 Offset: 0x682110 VA: 0x180683B10 Slot: 20
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x6849B0 Offset: 0x682FB0 VA: 0x1806849B0
	protected void .ctor() { }

	// RVA: 0x6848D0 Offset: 0x682ED0 VA: 0x1806848D0
	private static void .cctor() { }

}

public struct LODComponent.OccludeeParameters // TypeDefIndex: 9931
{	// Fields
	[TooltipAttribute] // RVA: 0xA9CB0 Offset: 0xA90B0 VA: 0x1800A9CB0
	public bool isDynamic; // 0x0
	[TooltipAttribute] // RVA: 0xA9D70 Offset: 0xA9170 VA: 0x1800A9D70
	public float dynamicUpdateInterval; // 0x4
	[TooltipAttribute] // RVA: 0xA9DE0 Offset: 0xA91E0 VA: 0x1800A9DE0
	public float shadowRangeScale; // 0x8
	[TooltipAttribute] // RVA: 0xA9E10 Offset: 0xA9210 VA: 0x1800A9E10
	public bool showBounds; // 0xC

}

private sealed class LODComponent.<>c // TypeDefIndex: 9932
{	// Fields
	public static readonly LODComponent.<>c <>9; // 0x0
	public static Predicate<LODComponent> <>9__34_0; // 0x8

	// Methods

	// RVA: 0x691040 Offset: 0x68F640 VA: 0x180691040
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690CD0 Offset: 0x68F2D0 VA: 0x180690CD0
	internal bool <ChangeCullingAll>b__34_0(LODComponent i) { }

}

