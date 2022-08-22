public class Animator : Behaviour // TypeDefIndex: 4487
{	public bool isInitialized { get; }
	public bool applyRootMotion { set; }
	public AnimatorUpdateMode updateMode { set; }
	public int layerCount { get; }
	public float speed { set; }
	public AnimatorCullingMode cullingMode { get; set; }
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public bool hasBoundPlayables { get; }
	public Avatar avatar { set; }
	public bool logWarnings { get; }
	public bool fireEvents { set; }


	[NativeMethodAttribute] // RVA: 0xCA4F0 Offset: 0xC98F0 VA: 0x1800CA4F0
	public bool get_isInitialized() { }

	public float GetFloat(string name) { }

	public float GetFloat(int id) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	public void SetFloat(int id, float value) { }

	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	public bool GetBool(int id) { }

	public void SetBool(string name, bool value) { }

	public void SetBool(int id, bool value) { }

	public int GetInteger(string name) { }

	public void SetInteger(string name, int value) { }

	public void SetInteger(int id, int value) { }

	public void SetTrigger(string name) { }

	public void SetTrigger(int id) { }

	public void ResetTrigger(string name) { }

	public void ResetTrigger(int id) { }

	public void set_applyRootMotion(bool value) { }

	public void set_updateMode(AnimatorUpdateMode value) { }

	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethodAttribute] // RVA: 0xCA660 Offset: 0xC9A60 VA: 0x1800CA660
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	public void SetLookAtWeight(float weight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethodAttribute] // RVA: 0xCA9D0 Offset: 0xC9DD0 VA: 0x1800CA9D0
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	public int get_layerCount() { }

	public int GetLayerIndex(string layerName) { }

	public float GetLayerWeight(int layerIndex) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCAA30 Offset: 0xC9E30 VA: 0x1800CAA30
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCABF0 Offset: 0xC9FF0 VA: 0x1800CABF0
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	public bool IsInTransition(int layerIndex) { }

	public void set_speed(float value) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0xCAF90 Offset: 0xCA390 VA: 0x1800CAF90
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	public void Play(string stateName, int layer) { }

	public void Play(string stateName) { }

	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunctionAttribute] // RVA: 0xCB2A0 Offset: 0xCA6A0 VA: 0x1800CB2A0
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	public void Play(int stateNameHash, int layer) { }

	public void Play(int stateNameHash) { }

	public AnimatorCullingMode get_cullingMode() { }

	public void set_cullingMode(AnimatorCullingMode value) { }

	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethodAttribute] // RVA: 0xCB570 Offset: 0xCA970 VA: 0x1800CB570
	public bool get_hasBoundPlayables() { }

	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethodAttribute] // RVA: 0xCB730 Offset: 0xCAB30 VA: 0x1800CB730
	public static int StringToHash(string name) { }

	public void set_avatar(Avatar value) { }

	private void CheckIfInIKPass() { }

	private bool IsInIKPass() { }

	[FreeFunctionAttribute] // RVA: 0xCB990 Offset: 0xCAD90 VA: 0x1800CB990
	private void SetFloatString(string name, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBBF0 Offset: 0xCAFF0 VA: 0x1800CBBF0
	private void SetFloatID(int id, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBD30 Offset: 0xCB130 VA: 0x1800CBD30
	private float GetFloatString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCBE10 Offset: 0xCB210 VA: 0x1800CBE10
	private float GetFloatID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCBEF0 Offset: 0xCB2F0 VA: 0x1800CBEF0
	private void SetBoolString(string name, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCBFE0 Offset: 0xCB3E0 VA: 0x1800CBFE0
	private void SetBoolID(int id, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCC1A0 Offset: 0xCB5A0 VA: 0x1800CC1A0
	private bool GetBoolID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCC2E0 Offset: 0xCB6E0 VA: 0x1800CC2E0
	private void SetIntegerString(string name, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC470 Offset: 0xCB870 VA: 0x1800CC470
	private void SetIntegerID(int id, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC590 Offset: 0xCB990 VA: 0x1800CC590
	private int GetIntegerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC7B0 Offset: 0xCBBB0 VA: 0x1800CC7B0
	private void SetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC890 Offset: 0xCBC90 VA: 0x1800CC890
	private void SetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCA20 Offset: 0xCBE20 VA: 0x1800CCA20
	private void ResetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCCB50 Offset: 0xCBF50 VA: 0x1800CCB50
	private void ResetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCCC0 Offset: 0xCC0C0 VA: 0x1800CCCC0
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0xCCE50 Offset: 0xCC250 VA: 0x1800CCE50
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[NativeMethodAttribute] // RVA: 0xCCF10 Offset: 0xCC310 VA: 0x1800CCF10
	public void Update(float deltaTime) { }

	public bool get_logWarnings() { }

	public void set_fireEvents(bool value) { }

	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

}

