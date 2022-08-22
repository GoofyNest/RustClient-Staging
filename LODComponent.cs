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

	// RVA: 0x684AD0 Offset: 0x6830D0 VA: 0x180684AD0
	public static HashSet<LODComponent> get_OccludeeSet() { }

	// RVA: 0x684AC0 Offset: 0x6830C0 VA: 0x180684AC0
	public float get_CurrentDistance() { }

	// RVA: 0x6835D0 Offset: 0x681BD0 VA: 0x1806835D0
	private float GetDistance() { }

	// RVA: 0x682E30 Offset: 0x681430 VA: 0x180682E30
	protected void Awake() { }

	// RVA: 0x684160 Offset: 0x682760 VA: 0x180684160
	public void SetEnvironmentMode(LODEnvironmentMode mode) { }

	// RVA: 0x683980 Offset: 0x681F80 VA: 0x180683980
	protected void OnEnable() { }

	// RVA: 0x683720 Offset: 0x681D20 VA: 0x180683720
	protected void OnDisable() { }

	// RVA: 0x683540 Offset: 0x681B40 VA: 0x180683540
	private void EnableCulling() { }

	// RVA: 0x6834B0 Offset: 0x681AB0 VA: 0x1806834B0
	private void DisableCulling() { }

	// RVA: 0x683CC0 Offset: 0x6822C0 VA: 0x180683CC0 Slot: 7
	public void RefreshLOD() { }

	// RVA: 0x683380 Offset: 0x681980 VA: 0x180683380 Slot: 6
	public void ChangeLOD() { }

	// RVA: 0x6831D0 Offset: 0x6817D0 VA: 0x1806831D0
	private void ChangeCulling(float distance) { }

	// RVA: 0x683370 Offset: 0x681970 VA: 0x180683370
	private void ChangeCulling() { }

	// RVA: 0x682F10 Offset: 0x681510 VA: 0x180682F10
	public static void ChangeCullingAll() { }

	// RVA: 0x684880 Offset: 0x682E80 VA: 0x180684880
	private void UpdateVisibility() { }

	// RVA: 0x684170 Offset: 0x682770 VA: 0x180684170
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

	// RVA: 0x683700 Offset: 0x681D00 VA: 0x180683700 Slot: 15
	protected virtual void Hide(bool shadowsVisible) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	protected virtual bool IsLODHiding() { }

	// RVA: 0x684910 Offset: 0x682F10 VA: 0x180684910
	public void WorkshopMode() { }

	// RVA: 0x6834A0 Offset: 0x681AA0 VA: 0x1806834A0 Slot: 17
	protected virtual bool ComputeCullingSphereBounds(out OcclusionCulling.Sphere sphereBounds) { }

	// RVA: 0x684860 Offset: 0x682E60 VA: 0x180684860
	private void UpdateShadowRange() { }

	// RVA: 0x6833F0 Offset: 0x6819F0 VA: 0x1806833F0
	public static void ClearOccludees() { }

	// RVA: 0x684270 Offset: 0x682870 VA: 0x180684270
	private static void UpdateDynamicOccludeeBounds(LODComponent lodcomp) { }

	// RVA: 0x6843C0 Offset: 0x6829C0 VA: 0x1806843C0
	public static void UpdateDynamicOccludees() { }

	// RVA: 0x684100 Offset: 0x682700 VA: 0x180684100
	public void ResetCulling() { }

	// RVA: 0x683EA0 Offset: 0x6824A0 VA: 0x180683EA0 Slot: 18
	protected virtual void RegisterToCulling(bool isVisible = True) { }

	// RVA: 0x684180 Offset: 0x682780 VA: 0x180684180 Slot: 19
	protected virtual void UnregisterFromCulling() { }

	// RVA: 0x683B80 Offset: 0x682180 VA: 0x180683B80 Slot: 20
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x684A20 Offset: 0x683020 VA: 0x180684A20
	protected void .ctor() { }

	// RVA: 0x684940 Offset: 0x682F40 VA: 0x180684940
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

	// RVA: 0x690FA0 Offset: 0x68F5A0 VA: 0x180690FA0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690C30 Offset: 0x68F230 VA: 0x180690C30
	internal bool <ChangeCullingAll>b__34_0(LODComponent i) { }

}

